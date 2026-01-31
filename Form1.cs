using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITestTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeUiState();
        }

        private void InitializeUiState()
        {
            comboTaskType.SelectedIndex = 0;
            comboMode.SelectedIndex = 0;
            comboModel.SelectedIndex = 0;
            UpdateDataLabel();
            SeedPreviewData();
        }

        private void comboTaskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataLabel();
        }

        private void UpdateDataLabel()
        {
            var isClassify = comboTaskType.SelectedIndex == 0;
            labelData.Text = isClassify ? "数据路径(目录)" : "数据路径(yaml)";
            labelDataHint.Text = isClassify ? "目录结构: train/val/类别子目录" : "仅支持 .yaml/.yml";
        }

        private void SeedPreviewData()
        {
            gridTasks.Rows.Clear();
            gridTasks.Rows.Add("20240427_153012_cls01", "分类", "训练", "执行中", "GPU:0", "00:04:11");
            gridTasks.Rows.Add("20240427_153012_det01", "检测", "训练", "排队中", "GPU:0", "00:00:31");
            gridTasks.Rows.Add("20240427_153012_cls02", "分类", "验证", "已完成", "GPU:0", "00:02:55");
            gridTasks.Rows.Add("20240427_153012_det02", "检测", "推理", "失败", "GPU:0", "00:01:11");

            textLogs.Text = string.Join(Environment.NewLine, new[]
            {
                "[2024-04-27 15:31:01] 开始任务: 20240427_153012_cls01",
                "yolo task=classify train data=/datasets/cls_ds_20240210 model=yolo11n-cls.pt epochs=100 imgsz=640 device=0 batch=16",
                "Ultralytics YOLOv8.1.2",
                "Epoch 1/100 - loss: 1.203 - acc: 0.531",
                "Epoch 2/100 - loss: 1.102 - acc: 0.566",
                "Epoch 3/100 - loss: 0.998 - acc: 0.602",
                "Saving best model to /opt/yolo/runs/cls/20240427_153012_cls01/best.pt",
                "Task running..."
            });

            listResults.Items.Clear();
            listResults.Items.Add(new ListViewItem(new[] { "任务ID", "20240427_153012_det01" }));
            listResults.Items.Add(new ListViewItem(new[] { "Best", "best_1_20240427_153012_det01.pt" }));
            listResults.Items.Add(new ListViewItem(new[] { "PR Curve", "/opt/yolo/runs/det/20240427_153012_det01/PR_curve.png" }));
            listResults.Items.Add(new ListViewItem(new[] { "结果图", "/opt/yolo/runs/det/20240427_153012_det01/results.png" }));
            listResults.Items.Add(new ListViewItem(new[] { "混淆矩阵", "/opt/yolo/runs/det/20240427_153012_det01/confusion_matrix.png" }));
            listResults.Items.Add(new ListViewItem(new[] { "mAP50", "0.695" }));
            listResults.Items.Add(new ListViewItem(new[] { "Precision", "0.751" }));
            listResults.Items.Add(new ListViewItem(new[] { "Recall", "0.732" }));
        }
    }
}
