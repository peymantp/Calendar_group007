namespace PJCalender
{
    partial class Menus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menus));
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.dropDownView = new System.Windows.Forms.ToolStripComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelMonth = new System.Windows.Forms.TableLayoutPanel();
            this.labelSunday = new System.Windows.Forms.Label();
            this.labelMonday = new System.Windows.Forms.Label();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.labelThursday = new System.Windows.Forms.Label();
            this.labelFriday = new System.Windows.Forms.Label();
            this.labelSaturday = new System.Windows.Forms.Label();
            this.tabPageMonth = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageWeek = new System.Windows.Forms.TabPage();
            this.tabPageDay = new System.Windows.Forms.TabPage();
            this.labelDay = new System.Windows.Forms.Label();
            this.tabPageAgenda = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutAgenda = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPickDay = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonEvent = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanelMonth.SuspendLayout();
            this.tabPageMonth.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageDay.SuspendLayout();
            this.tabPageAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            resources.ApplyResources(this.toolStripTextBox1, "toolStripTextBox1");
            // 
            // dropDownView
            // 
            this.dropDownView.Name = "dropDownView";
            resources.ApplyResources(this.dropDownView, "dropDownView");
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.CloseUp += new System.EventHandler(this.dateTimePicker_DatePicked);
            // 
            // tableLayoutPanelMonth
            // 
            resources.ApplyResources(this.tableLayoutPanelMonth, "tableLayoutPanelMonth");
            this.tableLayoutPanelMonth.Controls.Add(this.labelSunday, 0, 0);
            this.tableLayoutPanelMonth.Controls.Add(this.labelMonday, 1, 0);
            this.tableLayoutPanelMonth.Controls.Add(this.labelTuesday, 2, 0);
            this.tableLayoutPanelMonth.Controls.Add(this.labelWednesday, 3, 0);
            this.tableLayoutPanelMonth.Controls.Add(this.labelThursday, 4, 0);
            this.tableLayoutPanelMonth.Controls.Add(this.labelFriday, 5, 0);
            this.tableLayoutPanelMonth.Controls.Add(this.labelSaturday, 6, 0);
            this.tableLayoutPanelMonth.Name = "tableLayoutPanelMonth";
            // 
            // labelSunday
            // 
            resources.ApplyResources(this.labelSunday, "labelSunday");
            this.labelSunday.Name = "labelSunday";
            // 
            // labelMonday
            // 
            resources.ApplyResources(this.labelMonday, "labelMonday");
            this.labelMonday.Name = "labelMonday";
            // 
            // labelTuesday
            // 
            resources.ApplyResources(this.labelTuesday, "labelTuesday");
            this.labelTuesday.Name = "labelTuesday";
            // 
            // labelWednesday
            // 
            resources.ApplyResources(this.labelWednesday, "labelWednesday");
            this.labelWednesday.Name = "labelWednesday";
            // 
            // labelThursday
            // 
            resources.ApplyResources(this.labelThursday, "labelThursday");
            this.labelThursday.Name = "labelThursday";
            // 
            // labelFriday
            // 
            resources.ApplyResources(this.labelFriday, "labelFriday");
            this.labelFriday.Name = "labelFriday";
            // 
            // labelSaturday
            // 
            resources.ApplyResources(this.labelSaturday, "labelSaturday");
            this.labelSaturday.Name = "labelSaturday";
            // 
            // tabPageMonth
            // 
            this.tabPageMonth.Controls.Add(this.tableLayoutPanelMonth);
            resources.ApplyResources(this.tabPageMonth, "tabPageMonth");
            this.tabPageMonth.Name = "tabPageMonth";
            this.tabPageMonth.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPageMonth);
            this.tabControl.Controls.Add(this.tabPageWeek);
            this.tabControl.Controls.Add(this.tabPageDay);
            this.tabControl.Controls.Add(this.tabPageAgenda);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabPageWeek
            // 
            resources.ApplyResources(this.tabPageWeek, "tabPageWeek");
            this.tabPageWeek.Name = "tabPageWeek";
            this.tabPageWeek.UseVisualStyleBackColor = true;
            // 
            // tabPageDay
            // 
            this.tabPageDay.Controls.Add(this.labelDay);
            resources.ApplyResources(this.tabPageDay, "tabPageDay");
            this.tabPageDay.Name = "tabPageDay";
            this.tabPageDay.UseVisualStyleBackColor = true;
            // 
            // labelDay
            // 
            resources.ApplyResources(this.labelDay, "labelDay");
            this.labelDay.Name = "labelDay";
            // 
            // tabPageAgenda
            // 
            this.tabPageAgenda.Controls.Add(this.flowLayoutPanel);
            resources.ApplyResources(this.tabPageAgenda, "tabPageAgenda");
            this.tabPageAgenda.Name = "tabPageAgenda";
            this.tabPageAgenda.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            resources.ApplyResources(this.flowLayoutPanel, "flowLayoutPanel");
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            // 
            // tableLayoutAgenda
            // 
            resources.ApplyResources(this.tableLayoutAgenda, "tableLayoutAgenda");
            this.tableLayoutAgenda.Name = "tableLayoutAgenda";
            // 
            // buttonPickDay
            // 
            resources.ApplyResources(this.buttonPickDay, "buttonPickDay");
            this.buttonPickDay.Name = "buttonPickDay";
            this.buttonPickDay.UseVisualStyleBackColor = true;
            this.buttonPickDay.Click += new System.EventHandler(this.buttonPickDay_Click);
            // 
            // buttonLog
            // 
            resources.ApplyResources(this.buttonLog, "buttonLog");
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEvent
            // 
            resources.ApplyResources(this.buttonEvent, "buttonEvent");
            this.buttonEvent.Name = "buttonEvent";
            this.buttonEvent.UseVisualStyleBackColor = true;
            this.buttonEvent.Click += new System.EventHandler(this.buttonEvent_Click);
            // 
            // Menus
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.buttonEvent);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonPickDay);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Menus";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.tableLayoutPanelMonth.ResumeLayout(false);
            this.tableLayoutPanelMonth.PerformLayout();
            this.tabPageMonth.ResumeLayout(false);
            this.tabPageMonth.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageDay.ResumeLayout(false);
            this.tabPageDay.PerformLayout();
            this.tabPageAgenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }
        
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripComboBox dropDownView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMonth;
        private System.Windows.Forms.TabPage tabPageMonth;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDay;
        private System.Windows.Forms.Label labelWednesday;
        private System.Windows.Forms.Label labelTuesday;
        private System.Windows.Forms.Label labelMonday;
        private System.Windows.Forms.Label labelSunday;
        private System.Windows.Forms.Label labelSaturday;
        private System.Windows.Forms.Label labelFriday;
        private System.Windows.Forms.Label labelThursday;
        private System.Windows.Forms.Button buttonPickDay;
        private System.Windows.Forms.TabPage tabPageAgenda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAgenda;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        public System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Button buttonEvent;
        private System.Windows.Forms.TabPage tabPageWeek;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

