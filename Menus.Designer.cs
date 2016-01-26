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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menus));
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.dropDownView = new System.Windows.Forms.ToolStripComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxViewPicker = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelMonth = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSunday = new System.Windows.Forms.Label();
            this.labelFriday = new System.Windows.Forms.Label();
            this.labelMonday = new System.Windows.Forms.Label();
            this.labelThursday = new System.Windows.Forms.Label();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelWeek = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.tableLayoutPanelMonth.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanelWeek.SuspendLayout();
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
            // 
            // comboBoxViewPicker
            // 
            resources.ApplyResources(this.comboBoxViewPicker, "comboBoxViewPicker");
            this.comboBoxViewPicker.FormattingEnabled = true;
            this.comboBoxViewPicker.Items.AddRange(new object[] {
            resources.GetString("comboBoxViewPicker.Items"),
            resources.GetString("comboBoxViewPicker.Items1"),
            resources.GetString("comboBoxViewPicker.Items2"),
            resources.GetString("comboBoxViewPicker.Items3")});
            this.comboBoxViewPicker.Name = "comboBoxViewPicker";
            // 
            // tableLayoutPanelMonth
            // 
            resources.ApplyResources(this.tableLayoutPanelMonth, "tableLayoutPanelMonth");
            this.tableLayoutPanelMonth.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanelMonth.Controls.Add(this.labelSunday, 0, 0);
            this.tableLayoutPanelMonth.Controls.Add(this.labelFriday, 5, 0);
            this.tableLayoutPanelMonth.Controls.Add(this.labelMonday, 1, 0);
            this.tableLayoutPanelMonth.Controls.Add(this.labelThursday, 4, 0);
            this.tableLayoutPanelMonth.Controls.Add(this.labelTuesday, 2, 0);
            this.tableLayoutPanelMonth.Controls.Add(this.labelWednesday, 3, 0);
            this.tableLayoutPanelMonth.Name = "tableLayoutPanelMonth";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // labelSunday
            // 
            resources.ApplyResources(this.labelSunday, "labelSunday");
            this.labelSunday.Name = "labelSunday";
            // 
            // labelFriday
            // 
            resources.ApplyResources(this.labelFriday, "labelFriday");
            this.labelFriday.Name = "labelFriday";
            // 
            // labelMonday
            // 
            resources.ApplyResources(this.labelMonday, "labelMonday");
            this.labelMonday.Name = "labelMonday";
            // 
            // labelThursday
            // 
            resources.ApplyResources(this.labelThursday, "labelThursday");
            this.labelThursday.Name = "labelThursday";
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanelMonth);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanelWeek);
            this.tabPage2.Controls.Add(this.hScrollBar1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelWeek
            // 
            resources.ApplyResources(this.tableLayoutPanelWeek, "tableLayoutPanelWeek");
            this.tableLayoutPanelWeek.Controls.Add(this.label1, 6, 0);
            this.tableLayoutPanelWeek.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanelWeek.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanelWeek.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanelWeek.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanelWeek.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanelWeek.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanelWeek.Name = "tableLayoutPanelWeek";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // hScrollBar1
            // 
            resources.ApplyResources(this.hScrollBar1, "hScrollBar1");
            this.hScrollBar1.Name = "hScrollBar1";
            // 
            // Menus
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxViewPicker);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Menus";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.tableLayoutPanelMonth.ResumeLayout(false);
            this.tableLayoutPanelMonth.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanelWeek.ResumeLayout(false);
            this.tableLayoutPanelWeek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripComboBox dropDownView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxViewPicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMonth;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelWednesday;
        private System.Windows.Forms.Label labelTuesday;
        private System.Windows.Forms.Label labelMonday;
        private System.Windows.Forms.Label labelSunday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFriday;
        private System.Windows.Forms.Label labelThursday;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

