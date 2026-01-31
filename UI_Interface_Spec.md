# YOLO Windows 工具：页面介绍与接口定义（初版）

> 目标：Windows 端只负责“填表 + 查看状态/日志/结果”，Linux 端负责拼命令与执行。本文档用于和同事对齐页面结构与接口字段含义。

## 1. 页面/模块说明

### 1.1 任务创建页（任务创建）
**用途**：用户填写任务参数，生成 `task.json` 并提交到 Linux。  
**关键字段**：
- **任务类型**：`classify` / `detect`
- **动作**：`train` / `val` / `predict`
- **data**：  
  - `classify`：目录路径（分类数据集目录）  
  - `detect`：`data.yaml` 路径  
  - UI 需要根据任务类型显示提示：`目录` vs `yaml`
- **model**：模型路径（`*.pt`）
- **epochs / imgsz / device / batch**：基础超参

**操作按钮**：
- 生成任务 JSON
- 数据校验（本地路径格式校验 + 可选完整性校验）
- 提交任务

---

### 1.2 任务列表页（任务列表）
**用途**：显示任务队列与执行状态。  
**字段**：
`task_id`、`类型`、`动作`、`状态`、`device`、`耗时`  
**操作按钮**：
- 刷新
- 打开任务详情（切换到日志/结果页并加载该任务）

---

### 1.3 日志页（日志）
**用途**：展示 Linux 输出的 `logs.txt`，支持刷新/轮询。  
**展示内容**：原始运行日志（纯文本）。

---

### 1.4 结果页（结果）
**用途**：展示 `result.json` 中的输出项、产物路径、可下载模型。  
**展示内容**：
- key/value 列表：`best.pt`、`results.png`、`confusion_matrix.png`、`metrics.json` 等  
**操作按钮**：
- 下载模型（`best.pt`）
- 打开结果目录

---

## 2. Windows <-> Linux 接口概览

> **约定**：Windows 端只做表单、列表、日志、结果展示；Linux 端负责拼命令与执行。  
> 下面是最小可用接口集合（文件/HTTP/SFTP 任一种方式均可）。

### 2.1 创建任务（提交 `task.json`）
**入口**：`POST /tasks` 或 `SFTP 上传 task.json`  
**请求体**：`task.json`  

**字段说明：**
| 字段 | 类型 | 必填 | 示例 | 说明 |
|---|---|---|---|---|
| task_id | string | 是 | `20260127_170500_cls01` | 任务唯一标识（Windows 生成） |
| yolo_task | string | 是 | `classify` / `detect` | YOLO 任务类型 |
| mode | string | 是 | `train` / `val` / `predict` | 动作类型 |
| data | string | 是 | `/opt/yolo/datasets/cls_ds_001/` | 输入数据路径：classify 为目录，detect 为 yaml |
| model | string | 是 | `/opt/yolo/pretrained/yolo11n.pt` | 初始模型路径 |
| params | object | 是 | `{ "epochs": 50, "imgsz": 640, "device": "0", "batch": 4 }` | 超参集合 |
| params.epochs | int | train 必填 | `50` | 训练轮数 |
| params.imgsz | int | 可选 | `640` | 输入尺寸 |
| params.device | string | 可选 | `0` / `cpu` | 训练/推理设备 |
| params.batch | int | train 必填 | `4` | batch size |

**响应**（可选）：  
`{ "accepted": true, "task_id": "20260127_170500_cls01" }`

---

### 2.2 查询任务列表
**入口**：`GET /tasks` 或 `SFTP 读取 tasks/index.json`  
**响应字段**：
| 字段 | 类型 | 示例 | 说明 |
|---|---|---|---|
| task_id | string | `20260127_170500_cls01` | 任务ID |
| yolo_task | string | `classify` | 任务类型 |
| mode | string | `train` | 动作 |
| status | string | `queued` / `running` / `done` / `failed` | 状态 |
| device | string | `0` | 设备 |
| duration | string | `00:12:34` | 耗时 |

---

### 2.3 查询任务状态
**入口**：`GET /tasks/{task_id}/status` 或 `SFTP 读取 status.json`  
**响应字段**：
| 字段 | 类型 | 示例 | 说明 |
|---|---|---|---|
| status | string | `running` | 任务状态 |
| message | string | `loading weights` | 简要运行信息 |
| updated_at | string | `2026-01-27 18:05:02` | 更新时间 |

---

### 2.4 读取日志
**入口**：`GET /tasks/{task_id}/logs` 或 `SFTP 读取 logs.txt`  
**响应**：纯文本（原始日志）。

---

### 2.5 获取结果清单
**入口**：`GET /tasks/{task_id}/result` 或 `SFTP 读取 result.json`  
**响应字段**：
| 字段 | 类型 | 示例 | 说明 |
|---|---|---|---|
| best_model | string | `/opt/yolo/runs/.../best.pt` | 训练最佳模型 |
| outputs | object | `{ "results.png": "/opt/yolo/runs/.../results.png" }` | 产物路径映射 |
| metrics | object | `{ "mAP50": 0.89 }` | 指标（可选） |

---

### 2.6 下载模型/产物
**入口**：`GET /tasks/{task_id}/artifact?path=...` 或 `SFTP 下载指定路径`
**用途**：下载 `best.pt` / `results.png` / `metrics.json` 等。

---

## 3. Linux 端拼命令规则（统一约束）

> Windows 端不拼命令，Linux 端根据 `task.json` 拼命令。

### 分类（classify）
- 训练：`yolo task=classify train data=... model=... epochs=... imgsz=... device=... batch=...`
- 评估：`yolo task=classify val data=... model=... imgsz=... device=...`
- 推理：`yolo task=classify predict model=... source=... imgsz=... device=...`

### 检测（detect）
- 训练：`yolo task=detect mode=train model=... data=... epochs=... imgsz=... device=... batch=...`
- 评估：`yolo task=detect mode=val model=... data=... imgsz=... device=...`
- 推理：`yolo task=detect mode=predict model=... source=... imgsz=... device=... conf=... iou=...`

---

## 4. 路径/数据约束建议

### 分类数据集（目录型）
```
cls_ds_001/
  train/
    classA/*.jpg
    classB/*.jpg
  val/
    classA/*.jpg
    classB/*.jpg
```

### 检测数据集（yaml型）
```
det_ds_001/
  images/train
  images/val
  labels/train
  labels/val
  mydata.yaml
```

**可选校验建议**：
- classify：检查 `train/val` 下是否有类别子目录与图像
- detect：校验 yaml 中路径与 class 数量一致

