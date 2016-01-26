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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxViewPicker = new System.Windows.Forms.ComboBox();
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
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // comboBoxViewPicker
            // 
            this.comboBoxViewPicker.FormattingEnabled = true;
            this.comboBoxViewPicker.Items.AddRange(new object[] {
            resources.GetString("comboBoxViewPicker.Items"),
            resources.GetString("comboBoxViewPicker.Items1"),
            resources.GetString("comboBoxViewPicker.Items2"),
            resources.GetString("comboBoxViewPicker.Items3")});
            resources.ApplyResources(this.comboBoxViewPicker, "comboBoxViewPicker");
            this.comboBoxViewPicker.Name = "comboBoxViewPicker";
            // 
            // Menus
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxViewPicker);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonExit);
            this.MaximizeBox = false;
            this.Name = "Menus";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripComboBox dropDownView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxViewPicker;
    }
}

