namespace AITestTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTask = new System.Windows.Forms.TabPage();
            this.groupActions = new System.Windows.Forms.GroupBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonGenerateJson = new System.Windows.Forms.Button();
            this.groupParams = new System.Windows.Forms.GroupBox();
            this.labelEpochs = new System.Windows.Forms.Label();
            this.textEpochs = new System.Windows.Forms.TextBox();
            this.labelImgSize = new System.Windows.Forms.Label();
            this.textImgSize = new System.Windows.Forms.TextBox();
            this.labelDevice = new System.Windows.Forms.Label();
            this.textDevice = new System.Windows.Forms.TextBox();
            this.labelBatch = new System.Windows.Forms.Label();
            this.textBatch = new System.Windows.Forms.TextBox();
            this.groupTask = new System.Windows.Forms.GroupBox();
            this.labelTaskType = new System.Windows.Forms.Label();
            this.comboTaskType = new System.Windows.Forms.ComboBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.comboMode = new System.Windows.Forms.ComboBox();
            this.labelData = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            this.buttonBrowseData = new System.Windows.Forms.Button();
            this.labelDataHint = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.buttonBrowseModel = new System.Windows.Forms.Button();
            this.tabList = new System.Windows.Forms.TabPage();
            this.gridTasks = new System.Windows.Forms.DataGridView();
            this.columnTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTaskType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTaskMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTaskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTaskDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTaskDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRefreshTasks = new System.Windows.Forms.Button();
            this.buttonOpenTask = new System.Windows.Forms.Button();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.textLogs = new System.Windows.Forms.TextBox();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.listResults = new System.Windows.Forms.ListView();
            this.columnResultKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnResultValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDownloadModel = new System.Windows.Forms.Button();
            this.buttonOpenResultFolder = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabTask.SuspendLayout();
            this.groupActions.SuspendLayout();
            this.groupParams.SuspendLayout();
            this.groupTask.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
            this.tabLogs.SuspendLayout();
            this.tabResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabTask);
            this.tabMain.Controls.Add(this.tabList);
            this.tabMain.Controls.Add(this.tabLogs);
            this.tabMain.Controls.Add(this.tabResults);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1100, 720);
            this.tabMain.TabIndex = 0;
            // 
            // tabTask
            // 
            this.tabTask.Controls.Add(this.groupActions);
            this.tabTask.Controls.Add(this.groupParams);
            this.tabTask.Controls.Add(this.groupTask);
            this.tabTask.Location = new System.Drawing.Point(4, 25);
            this.tabTask.Name = "tabTask";
            this.tabTask.Padding = new System.Windows.Forms.Padding(10);
            this.tabTask.Size = new System.Drawing.Size(1092, 691);
            this.tabTask.TabIndex = 0;
            this.tabTask.Text = "任务创建";
            this.tabTask.UseVisualStyleBackColor = true;
            // 
            // groupActions
            // 
            this.groupActions.Controls.Add(this.buttonSubmit);
            this.groupActions.Controls.Add(this.buttonValidate);
            this.groupActions.Controls.Add(this.buttonGenerateJson);
            this.groupActions.Location = new System.Drawing.Point(16, 514);
            this.groupActions.Name = "groupActions";
            this.groupActions.Size = new System.Drawing.Size(1048, 148);
            this.groupActions.TabIndex = 2;
            this.groupActions.TabStop = false;
            this.groupActions.Text = "操作";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(32, 47);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(160, 40);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "提交任务";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(214, 47);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(160, 40);
            this.buttonValidate.TabIndex = 1;
            this.buttonValidate.Text = "数据校验";
            this.buttonValidate.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateJson
            // 
            this.buttonGenerateJson.Location = new System.Drawing.Point(396, 47);
            this.buttonGenerateJson.Name = "buttonGenerateJson";
            this.buttonGenerateJson.Size = new System.Drawing.Size(160, 40);
            this.buttonGenerateJson.TabIndex = 2;
            this.buttonGenerateJson.Text = "生成任务JSON";
            this.buttonGenerateJson.UseVisualStyleBackColor = true;
            // 
            // groupParams
            // 
            this.groupParams.Controls.Add(this.labelEpochs);
            this.groupParams.Controls.Add(this.textEpochs);
            this.groupParams.Controls.Add(this.labelImgSize);
            this.groupParams.Controls.Add(this.textImgSize);
            this.groupParams.Controls.Add(this.labelDevice);
            this.groupParams.Controls.Add(this.textDevice);
            this.groupParams.Controls.Add(this.labelBatch);
            this.groupParams.Controls.Add(this.textBatch);
            this.groupParams.Location = new System.Drawing.Point(16, 321);
            this.groupParams.Name = "groupParams";
            this.groupParams.Size = new System.Drawing.Size(1048, 171);
            this.groupParams.TabIndex = 1;
            this.groupParams.TabStop = false;
            this.groupParams.Text = "超参配置";
            // 
            // labelEpochs
            // 
            this.labelEpochs.AutoSize = true;
            this.labelEpochs.Location = new System.Drawing.Point(30, 40);
            this.labelEpochs.Name = "labelEpochs";
            this.labelEpochs.Size = new System.Drawing.Size(50, 17);
            this.labelEpochs.TabIndex = 0;
            this.labelEpochs.Text = "epochs";
            // 
            // textEpochs
            // 
            this.textEpochs.Location = new System.Drawing.Point(120, 36);
            this.textEpochs.Name = "textEpochs";
            this.textEpochs.Size = new System.Drawing.Size(160, 22);
            this.textEpochs.TabIndex = 1;
            this.textEpochs.Text = "50";
            // 
            // labelImgSize
            // 
            this.labelImgSize.AutoSize = true;
            this.labelImgSize.Location = new System.Drawing.Point(318, 40);
            this.labelImgSize.Name = "labelImgSize";
            this.labelImgSize.Size = new System.Drawing.Size(42, 17);
            this.labelImgSize.TabIndex = 2;
            this.labelImgSize.Text = "imgsz";
            // 
            // textImgSize
            // 
            this.textImgSize.Location = new System.Drawing.Point(392, 36);
            this.textImgSize.Name = "textImgSize";
            this.textImgSize.Size = new System.Drawing.Size(160, 22);
            this.textImgSize.TabIndex = 3;
            this.textImgSize.Text = "640";
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Location = new System.Drawing.Point(30, 90);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(47, 17);
            this.labelDevice.TabIndex = 4;
            this.labelDevice.Text = "device";
            // 
            // textDevice
            // 
            this.textDevice.Location = new System.Drawing.Point(120, 86);
            this.textDevice.Name = "textDevice";
            this.textDevice.Size = new System.Drawing.Size(160, 22);
            this.textDevice.TabIndex = 5;
            this.textDevice.Text = "0";
            // 
            // labelBatch
            // 
            this.labelBatch.AutoSize = true;
            this.labelBatch.Location = new System.Drawing.Point(318, 90);
            this.labelBatch.Name = "labelBatch";
            this.labelBatch.Size = new System.Drawing.Size(41, 17);
            this.labelBatch.TabIndex = 6;
            this.labelBatch.Text = "batch";
            // 
            // textBatch
            // 
            this.textBatch.Location = new System.Drawing.Point(392, 86);
            this.textBatch.Name = "textBatch";
            this.textBatch.Size = new System.Drawing.Size(160, 22);
            this.textBatch.TabIndex = 7;
            this.textBatch.Text = "4";
            // 
            // groupTask
            // 
            this.groupTask.Controls.Add(this.labelTaskType);
            this.groupTask.Controls.Add(this.comboTaskType);
            this.groupTask.Controls.Add(this.labelMode);
            this.groupTask.Controls.Add(this.comboMode);
            this.groupTask.Controls.Add(this.labelData);
            this.groupTask.Controls.Add(this.textData);
            this.groupTask.Controls.Add(this.buttonBrowseData);
            this.groupTask.Controls.Add(this.labelDataHint);
            this.groupTask.Controls.Add(this.labelModel);
            this.groupTask.Controls.Add(this.comboModel);
            this.groupTask.Controls.Add(this.buttonBrowseModel);
            this.groupTask.Location = new System.Drawing.Point(16, 16);
            this.groupTask.Name = "groupTask";
            this.groupTask.Size = new System.Drawing.Size(1048, 286);
            this.groupTask.TabIndex = 0;
            this.groupTask.TabStop = false;
            this.groupTask.Text = "任务信息";
            // 
            // labelTaskType
            // 
            this.labelTaskType.AutoSize = true;
            this.labelTaskType.Location = new System.Drawing.Point(30, 35);
            this.labelTaskType.Name = "labelTaskType";
            this.labelTaskType.Size = new System.Drawing.Size(53, 17);
            this.labelTaskType.TabIndex = 0;
            this.labelTaskType.Text = "任务类型";
            // 
            // comboTaskType
            // 
            this.comboTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTaskType.FormattingEnabled = true;
            this.comboTaskType.Items.AddRange(new object[] {
            "classify",
            "detect"});
            this.comboTaskType.Location = new System.Drawing.Point(120, 31);
            this.comboTaskType.Name = "comboTaskType";
            this.comboTaskType.Size = new System.Drawing.Size(160, 24);
            this.comboTaskType.TabIndex = 1;
            this.comboTaskType.SelectedIndexChanged += new System.EventHandler(this.comboTaskType_SelectedIndexChanged);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(318, 35);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(32, 17);
            this.labelMode.TabIndex = 2;
            this.labelMode.Text = "动作";
            // 
            // comboMode
            // 
            this.comboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMode.FormattingEnabled = true;
            this.comboMode.Items.AddRange(new object[] {
            "train",
            "val",
            "predict"});
            this.comboMode.Location = new System.Drawing.Point(392, 31);
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(160, 24);
            this.comboMode.TabIndex = 3;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(30, 88);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(68, 17);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "数据集目录";
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(120, 84);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(660, 22);
            this.textData.TabIndex = 5;
            // 
            // buttonBrowseData
            // 
            this.buttonBrowseData.Location = new System.Drawing.Point(802, 81);
            this.buttonBrowseData.Name = "buttonBrowseData";
            this.buttonBrowseData.Size = new System.Drawing.Size(90, 28);
            this.buttonBrowseData.TabIndex = 6;
            this.buttonBrowseData.Text = "选择...";
            this.buttonBrowseData.UseVisualStyleBackColor = true;
            // 
            // labelDataHint
            // 
            this.labelDataHint.AutoSize = true;
            this.labelDataHint.ForeColor = System.Drawing.Color.DimGray;
            this.labelDataHint.Location = new System.Drawing.Point(120, 114);
            this.labelDataHint.Name = "labelDataHint";
            this.labelDataHint.Size = new System.Drawing.Size(193, 17);
            this.labelDataHint.TabIndex = 7;
            this.labelDataHint.Text = "目录结构: train/val/类别子目录";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(30, 165);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(44, 17);
            this.labelModel.TabIndex = 8;
            this.labelModel.Text = "模型";
            // 
            // comboModel
            // 
            this.comboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Items.AddRange(new object[] {
            "yolo11n-cls.pt",
            "yolo11n.pt",
            "自定义..."});
            this.comboModel.Location = new System.Drawing.Point(120, 161);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(410, 24);
            this.comboModel.TabIndex = 9;
            // 
            // buttonBrowseModel
            // 
            this.buttonBrowseModel.Location = new System.Drawing.Point(550, 158);
            this.buttonBrowseModel.Name = "buttonBrowseModel";
            this.buttonBrowseModel.Size = new System.Drawing.Size(90, 28);
            this.buttonBrowseModel.TabIndex = 10;
            this.buttonBrowseModel.Text = "选择...";
            this.buttonBrowseModel.UseVisualStyleBackColor = true;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.gridTasks);
            this.tabList.Controls.Add(this.buttonRefreshTasks);
            this.tabList.Controls.Add(this.buttonOpenTask);
            this.tabList.Location = new System.Drawing.Point(4, 25);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(10);
            this.tabList.Size = new System.Drawing.Size(1092, 691);
            this.tabList.TabIndex = 1;
            this.tabList.Text = "任务列表";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // gridTasks
            // 
            this.gridTasks.AllowUserToAddRows = false;
            this.gridTasks.AllowUserToDeleteRows = false;
            this.gridTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTaskId,
            this.columnTaskType,
            this.columnTaskMode,
            this.columnTaskStatus,
            this.columnTaskDevice,
            this.columnTaskDuration});
            this.gridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTasks.Location = new System.Drawing.Point(14, 58);
            this.gridTasks.Name = "gridTasks";
            this.gridTasks.ReadOnly = true;
            this.gridTasks.RowHeadersVisible = false;
            this.gridTasks.Size = new System.Drawing.Size(1064, 615);
            this.gridTasks.TabIndex = 0;
            // 
            // columnTaskId
            // 
            this.columnTaskId.HeaderText = "task_id";
            this.columnTaskId.Name = "columnTaskId";
            this.columnTaskId.ReadOnly = true;
            this.columnTaskId.Width = 220;
            // 
            // columnTaskType
            // 
            this.columnTaskType.HeaderText = "类型";
            this.columnTaskType.Name = "columnTaskType";
            this.columnTaskType.ReadOnly = true;
            this.columnTaskType.Width = 80;
            // 
            // columnTaskMode
            // 
            this.columnTaskMode.HeaderText = "动作";
            this.columnTaskMode.Name = "columnTaskMode";
            this.columnTaskMode.ReadOnly = true;
            this.columnTaskMode.Width = 80;
            // 
            // columnTaskStatus
            // 
            this.columnTaskStatus.HeaderText = "状态";
            this.columnTaskStatus.Name = "columnTaskStatus";
            this.columnTaskStatus.ReadOnly = true;
            this.columnTaskStatus.Width = 120;
            // 
            // columnTaskDevice
            // 
            this.columnTaskDevice.HeaderText = "device";
            this.columnTaskDevice.Name = "columnTaskDevice";
            this.columnTaskDevice.ReadOnly = true;
            this.columnTaskDevice.Width = 90;
            // 
            // columnTaskDuration
            // 
            this.columnTaskDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnTaskDuration.HeaderText = "耗时";
            this.columnTaskDuration.Name = "columnTaskDuration";
            this.columnTaskDuration.ReadOnly = true;
            // 
            // buttonRefreshTasks
            // 
            this.buttonRefreshTasks.Location = new System.Drawing.Point(14, 14);
            this.buttonRefreshTasks.Name = "buttonRefreshTasks";
            this.buttonRefreshTasks.Size = new System.Drawing.Size(120, 32);
            this.buttonRefreshTasks.TabIndex = 1;
            this.buttonRefreshTasks.Text = "刷新";
            this.buttonRefreshTasks.UseVisualStyleBackColor = true;
            // 
            // buttonOpenTask
            // 
            this.buttonOpenTask.Location = new System.Drawing.Point(146, 14);
            this.buttonOpenTask.Name = "buttonOpenTask";
            this.buttonOpenTask.Size = new System.Drawing.Size(160, 32);
            this.buttonOpenTask.TabIndex = 2;
            this.buttonOpenTask.Text = "打开任务详情";
            this.buttonOpenTask.UseVisualStyleBackColor = true;
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.textLogs);
            this.tabLogs.Location = new System.Drawing.Point(4, 25);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(10);
            this.tabLogs.Size = new System.Drawing.Size(1092, 691);
            this.tabLogs.TabIndex = 2;
            this.tabLogs.Text = "日志";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // textLogs
            // 
            this.textLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLogs.Font = new System.Drawing.Font("Consolas", 10F);
            this.textLogs.Location = new System.Drawing.Point(10, 10);
            this.textLogs.Multiline = true;
            this.textLogs.Name = "textLogs";
            this.textLogs.ReadOnly = true;
            this.textLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLogs.Size = new System.Drawing.Size(1072, 671);
            this.textLogs.TabIndex = 0;
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.listResults);
            this.tabResults.Controls.Add(this.buttonDownloadModel);
            this.tabResults.Controls.Add(this.buttonOpenResultFolder);
            this.tabResults.Location = new System.Drawing.Point(4, 25);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(10);
            this.tabResults.Size = new System.Drawing.Size(1092, 691);
            this.tabResults.TabIndex = 3;
            this.tabResults.Text = "结果";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // listResults
            // 
            this.listResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnResultKey,
            this.columnResultValue});
            this.listResults.FullRowSelect = true;
            this.listResults.GridLines = true;
            this.listResults.Location = new System.Drawing.Point(14, 58);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(1064, 615);
            this.listResults.TabIndex = 0;
            this.listResults.UseCompatibleStateImageBehavior = false;
            this.listResults.View = System.Windows.Forms.View.Details;
            // 
            // columnResultKey
            // 
            this.columnResultKey.Text = "字段";
            this.columnResultKey.Width = 200;
            // 
            // columnResultValue
            // 
            this.columnResultValue.Text = "值/路径";
            this.columnResultValue.Width = 820;
            // 
            // buttonDownloadModel
            // 
            this.buttonDownloadModel.Location = new System.Drawing.Point(14, 14);
            this.buttonDownloadModel.Name = "buttonDownloadModel";
            this.buttonDownloadModel.Size = new System.Drawing.Size(160, 32);
            this.buttonDownloadModel.TabIndex = 1;
            this.buttonDownloadModel.Text = "下载模型";
            this.buttonDownloadModel.UseVisualStyleBackColor = true;
            // 
            // buttonOpenResultFolder
            // 
            this.buttonOpenResultFolder.Location = new System.Drawing.Point(186, 14);
            this.buttonOpenResultFolder.Name = "buttonOpenResultFolder";
            this.buttonOpenResultFolder.Size = new System.Drawing.Size(160, 32);
            this.buttonOpenResultFolder.TabIndex = 2;
            this.buttonOpenResultFolder.Text = "打开结果目录";
            this.buttonOpenResultFolder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.tabMain);
            this.MinimumSize = new System.Drawing.Size(1000, 680);
            this.Name = "Form1";
            this.Text = "YOLO 任务管理工具";
            this.tabMain.ResumeLayout(false);
            this.tabTask.ResumeLayout(false);
            this.groupActions.ResumeLayout(false);
            this.groupParams.ResumeLayout(false);
            this.groupParams.PerformLayout();
            this.groupTask.ResumeLayout(false);
            this.groupTask.PerformLayout();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            this.tabResults.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTask;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.GroupBox groupTask;
        private System.Windows.Forms.Label labelTaskType;
        private System.Windows.Forms.ComboBox comboTaskType;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ComboBox comboMode;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.Button buttonBrowseData;
        private System.Windows.Forms.Label labelDataHint;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.Button buttonBrowseModel;
        private System.Windows.Forms.GroupBox groupParams;
        private System.Windows.Forms.Label labelEpochs;
        private System.Windows.Forms.TextBox textEpochs;
        private System.Windows.Forms.Label labelImgSize;
        private System.Windows.Forms.TextBox textImgSize;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.TextBox textDevice;
        private System.Windows.Forms.Label labelBatch;
        private System.Windows.Forms.TextBox textBatch;
        private System.Windows.Forms.GroupBox groupActions;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonGenerateJson;
        private System.Windows.Forms.DataGridView gridTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTaskType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTaskMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTaskStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTaskDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTaskDuration;
        private System.Windows.Forms.Button buttonRefreshTasks;
        private System.Windows.Forms.Button buttonOpenTask;
        private System.Windows.Forms.TextBox textLogs;
        private System.Windows.Forms.ListView listResults;
        private System.Windows.Forms.ColumnHeader columnResultKey;
        private System.Windows.Forms.ColumnHeader columnResultValue;
        private System.Windows.Forms.Button buttonDownloadModel;
        private System.Windows.Forms.Button buttonOpenResultFolder;
    }
}
