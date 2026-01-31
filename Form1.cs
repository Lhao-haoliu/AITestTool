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
        }

        private void comboTaskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataLabel();
        }

        private void UpdateDataLabel()
        {
            var isClassify = comboTaskType.SelectedItem != null &&
                             comboTaskType.SelectedItem.ToString() == "classify";
            labelData.Text = isClassify ? "数据集目录" : "data.yaml";
            labelDataHint.Text = isClassify ? "目录结构: train/val/类别子目录" : "仅支持 .yaml/.yml";
        }
    }
}
