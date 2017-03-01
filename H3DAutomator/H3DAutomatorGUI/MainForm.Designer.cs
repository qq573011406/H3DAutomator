﻿namespace H3DAutomatorGUI
{
    partial class MainForm
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
            this.listView_devices = new System.Windows.Forms.ListView();
            this.Serial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Device = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip_adb = new System.Windows.Forms.StatusStrip();
            this.status_lable_adb = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_install = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.statusStrip_adb.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_devices
            // 
            this.listView_devices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Serial,
            this.State,
            this.Model,
            this.Product,
            this.Device});
            this.listView_devices.FullRowSelect = true;
            this.listView_devices.Location = new System.Drawing.Point(12, 12);
            this.listView_devices.Name = "listView_devices";
            this.listView_devices.Size = new System.Drawing.Size(441, 364);
            this.listView_devices.TabIndex = 0;
            this.listView_devices.UseCompatibleStateImageBehavior = false;
            this.listView_devices.View = System.Windows.Forms.View.Details;
            // 
            // Serial
            // 
            this.Serial.Text = "Serial";
            this.Serial.Width = 124;
            // 
            // State
            // 
            this.State.Text = "State";
            this.State.Width = 92;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 106;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 97;
            // 
            // Device
            // 
            this.Device.Text = "Device";
            this.Device.Width = 94;
            // 
            // statusStrip_adb
            // 
            this.statusStrip_adb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_lable_adb});
            this.statusStrip_adb.Location = new System.Drawing.Point(0, 390);
            this.statusStrip_adb.Name = "statusStrip_adb";
            this.statusStrip_adb.Size = new System.Drawing.Size(821, 22);
            this.statusStrip_adb.TabIndex = 2;
            this.statusStrip_adb.Text = "statusStrip1";
            // 
            // status_lable_adb
            // 
            this.status_lable_adb.Name = "status_lable_adb";
            this.status_lable_adb.Size = new System.Drawing.Size(135, 17);
            this.status_lable_adb.Text = "ADBServerStatus:Stop";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(463, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 363);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_install);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(340, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_install
            // 
            this.button_install.Location = new System.Drawing.Point(224, 308);
            this.button_install.Name = "button_install";
            this.button_install.Size = new System.Drawing.Size(110, 23);
            this.button_install.TabIndex = 4;
            this.button_install.Text = "Run";
            this.button_install.UseVisualStyleBackColor = true;
            this.button_install.Click += new System.EventHandler(this.button_install_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_log);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(340, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "日志";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_log
            // 
            this.textBox_log.BackColor = System.Drawing.Color.Black;
            this.textBox_log.ForeColor = System.Drawing.Color.White;
            this.textBox_log.Location = new System.Drawing.Point(0, 0);
            this.textBox_log.MaxLength = 32767000;
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_log.Size = new System.Drawing.Size(340, 337);
            this.textBox_log.TabIndex = 7;
            this.textBox_log.TextChanged += new System.EventHandler(this.textBox_log_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 412);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip_adb);
            this.Controls.Add(this.listView_devices);
            this.Name = "MainForm";
            this.Text = "自动化测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip_adb.ResumeLayout(false);
            this.statusStrip_adb.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_devices;
        private System.Windows.Forms.ColumnHeader Serial;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Device;
        private System.Windows.Forms.StatusStrip statusStrip_adb;
        private System.Windows.Forms.ToolStripStatusLabel status_lable_adb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_install;
        private System.Windows.Forms.TextBox textBox_log;
    }
}

