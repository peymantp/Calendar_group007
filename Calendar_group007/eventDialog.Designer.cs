namespace PJCalender
{
    partial class eventDialog
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.checkBoxAllDay = new System.Windows.Forms.CheckBox();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.labelWhere = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxWhere = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelRepeat = new System.Windows.Forms.Panel();
            this.labelRepeat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRepeatEvery = new System.Windows.Forms.Label();
            this.labelRepeatOn = new System.Windows.Forms.Label();
            this.labelEnds = new System.Windows.Forms.Label();
            this.radioButtonNever = new System.Windows.Forms.RadioButton();
            this.radioButtonAfter = new System.Windows.Forms.RadioButton();
            this.radioButtonOn = new System.Windows.Forms.RadioButton();
            this.comboBoxRepeats = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelChange = new System.Windows.Forms.Label();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.panelWeekDay = new System.Windows.Forms.Panel();
            this.panelRepeat.SuspendLayout();
            this.panelWeekDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(14, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(98, 31);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(116, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 31);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEvent.Location = new System.Drawing.Point(14, 51);
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(451, 35);
            this.textBoxEvent.TabIndex = 4;
            this.textBoxEvent.Text = "Untitled event";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd, MM, yyyy: HH:mm";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(14, 100);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(185, 26);
            this.dateTimePickerFrom.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd, MM, yyyy: HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(273, 100);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(190, 26);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(214, 100);
            this.labelTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(28, 25);
            this.labelTo.TabIndex = 7;
            this.labelTo.Text = "to";
            // 
            // checkBoxAllDay
            // 
            this.checkBoxAllDay.AutoSize = true;
            this.checkBoxAllDay.Location = new System.Drawing.Point(14, 139);
            this.checkBoxAllDay.Name = "checkBoxAllDay";
            this.checkBoxAllDay.Size = new System.Drawing.Size(81, 24);
            this.checkBoxAllDay.TabIndex = 8;
            this.checkBoxAllDay.Text = "All day";
            this.checkBoxAllDay.UseVisualStyleBackColor = true;
            this.checkBoxAllDay.CheckStateChanged += new System.EventHandler(this.Check_AllDay);
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(126, 139);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(88, 24);
            this.checkBoxRepeat.TabIndex = 9;
            this.checkBoxRepeat.Text = "Repeat";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            this.checkBoxRepeat.CheckedChanged += new System.EventHandler(this.checkBoxRepeat_CheckedChanged);
            // 
            // labelWhere
            // 
            this.labelWhere.AutoSize = true;
            this.labelWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhere.Location = new System.Drawing.Point(9, 177);
            this.labelWhere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhere.Name = "labelWhere";
            this.labelWhere.Size = new System.Drawing.Size(71, 25);
            this.labelWhere.TabIndex = 10;
            this.labelWhere.Text = "Where";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(9, 214);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(109, 25);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Description";
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.Location = new System.Drawing.Point(142, 176);
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.Size = new System.Drawing.Size(323, 26);
            this.textBoxWhere.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 215);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 64);
            this.textBox1.TabIndex = 13;
            // 
            // panelRepeat
            // 
            this.panelRepeat.AutoSize = true;
            this.panelRepeat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelRepeat.Controls.Add(this.panelWeekDay);
            this.panelRepeat.Controls.Add(this.labelChange);
            this.panelRepeat.Controls.Add(this.comboBox2);
            this.panelRepeat.Controls.Add(this.comboBoxRepeats);
            this.panelRepeat.Controls.Add(this.radioButtonOn);
            this.panelRepeat.Controls.Add(this.radioButtonAfter);
            this.panelRepeat.Controls.Add(this.radioButtonNever);
            this.panelRepeat.Controls.Add(this.labelEnds);
            this.panelRepeat.Controls.Add(this.labelRepeatEvery);
            this.panelRepeat.Controls.Add(this.label1);
            this.panelRepeat.Controls.Add(this.labelRepeat);
            this.panelRepeat.Location = new System.Drawing.Point(-1, 291);
            this.panelRepeat.Name = "panelRepeat";
            this.panelRepeat.Size = new System.Drawing.Size(484, 238);
            this.panelRepeat.TabIndex = 14;
            this.panelRepeat.Visible = false;
            // 
            // labelRepeat
            // 
            this.labelRepeat.AutoSize = true;
            this.labelRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepeat.Location = new System.Drawing.Point(4, 4);
            this.labelRepeat.Name = "labelRepeat";
            this.labelRepeat.Size = new System.Drawing.Size(88, 26);
            this.labelRepeat.TabIndex = 0;
            this.labelRepeat.Text = "Repeat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Repeats";
            // 
            // labelRepeatEvery
            // 
            this.labelRepeatEvery.AutoSize = true;
            this.labelRepeatEvery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepeatEvery.Location = new System.Drawing.Point(21, 76);
            this.labelRepeatEvery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRepeatEvery.Name = "labelRepeatEvery";
            this.labelRepeatEvery.Size = new System.Drawing.Size(127, 25);
            this.labelRepeatEvery.TabIndex = 12;
            this.labelRepeatEvery.Text = "Repeat every";
            // 
            // labelRepeatOn
            // 
            this.labelRepeatOn.AutoSize = true;
            this.labelRepeatOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepeatOn.Location = new System.Drawing.Point(6, 8);
            this.labelRepeatOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRepeatOn.Name = "labelRepeatOn";
            this.labelRepeatOn.Size = new System.Drawing.Size(101, 25);
            this.labelRepeatOn.TabIndex = 13;
            this.labelRepeatOn.Text = "Repeat on";
            // 
            // labelEnds
            // 
            this.labelEnds.AutoSize = true;
            this.labelEnds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnds.Location = new System.Drawing.Point(21, 151);
            this.labelEnds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnds.Name = "labelEnds";
            this.labelEnds.Size = new System.Drawing.Size(57, 25);
            this.labelEnds.TabIndex = 14;
            this.labelEnds.Text = "Ends";
            // 
            // radioButtonNever
            // 
            this.radioButtonNever.AutoSize = true;
            this.radioButtonNever.Checked = true;
            this.radioButtonNever.Location = new System.Drawing.Point(154, 151);
            this.radioButtonNever.Name = "radioButtonNever";
            this.radioButtonNever.Size = new System.Drawing.Size(75, 24);
            this.radioButtonNever.TabIndex = 15;
            this.radioButtonNever.TabStop = true;
            this.radioButtonNever.Text = "Never";
            this.radioButtonNever.UseVisualStyleBackColor = true;
            // 
            // radioButtonAfter
            // 
            this.radioButtonAfter.AutoSize = true;
            this.radioButtonAfter.Location = new System.Drawing.Point(154, 181);
            this.radioButtonAfter.Name = "radioButtonAfter";
            this.radioButtonAfter.Size = new System.Drawing.Size(69, 24);
            this.radioButtonAfter.TabIndex = 16;
            this.radioButtonAfter.TabStop = true;
            this.radioButtonAfter.Text = "After";
            this.radioButtonAfter.UseVisualStyleBackColor = true;
            // 
            // radioButtonOn
            // 
            this.radioButtonOn.AutoSize = true;
            this.radioButtonOn.Location = new System.Drawing.Point(154, 211);
            this.radioButtonOn.Name = "radioButtonOn";
            this.radioButtonOn.Size = new System.Drawing.Size(138, 24);
            this.radioButtonOn.TabIndex = 17;
            this.radioButtonOn.TabStop = true;
            this.radioButtonOn.Text = "radioButtonOn";
            this.radioButtonOn.UseVisualStyleBackColor = true;
            // 
            // comboBoxRepeats
            // 
            this.comboBoxRepeats.FormattingEnabled = true;
            this.comboBoxRepeats.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.comboBoxRepeats.Location = new System.Drawing.Point(154, 40);
            this.comboBoxRepeats.Name = "comboBoxRepeats";
            this.comboBoxRepeats.Size = new System.Drawing.Size(291, 28);
            this.comboBoxRepeats.TabIndex = 18;
            this.comboBoxRepeats.Text = "Daily";
            this.comboBoxRepeats.SelectedIndexChanged += new System.EventHandler(this.Repeats_Changed);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboBox2.Location = new System.Drawing.Point(154, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 19;
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(281, 80);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(42, 20);
            this.labelChange.TabIndex = 20;
            this.labelChange.Text = "days";
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.Location = new System.Drawing.Point(139, 8);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(46, 24);
            this.checkBox0.TabIndex = 21;
            this.checkBox0.Text = "S";
            this.checkBox0.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(185, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 24);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "M";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(234, 8);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(44, 24);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "T";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(282, 8);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(50, 24);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.Text = "W";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(332, 8);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(44, 24);
            this.checkBox4.TabIndex = 25;
            this.checkBox4.Text = "T";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(380, 8);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(45, 24);
            this.checkBox5.TabIndex = 26;
            this.checkBox5.Text = "F";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(422, 8);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(46, 24);
            this.checkBox6.TabIndex = 27;
            this.checkBox6.Text = "S";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // panelWeekDay
            // 
            this.panelWeekDay.Controls.Add(this.labelRepeatOn);
            this.panelWeekDay.Controls.Add(this.checkBox6);
            this.panelWeekDay.Controls.Add(this.checkBox0);
            this.panelWeekDay.Controls.Add(this.checkBox5);
            this.panelWeekDay.Controls.Add(this.checkBox1);
            this.panelWeekDay.Controls.Add(this.checkBox4);
            this.panelWeekDay.Controls.Add(this.checkBox2);
            this.panelWeekDay.Controls.Add(this.checkBox3);
            this.panelWeekDay.Location = new System.Drawing.Point(15, 109);
            this.panelWeekDay.Name = "panelWeekDay";
            this.panelWeekDay.Size = new System.Drawing.Size(466, 39);
            this.panelWeekDay.TabIndex = 28;
            this.panelWeekDay.Visible = false;
            // 
            // eventDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(483, 543);
            this.Controls.Add(this.panelRepeat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxWhere);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelWhere);
            this.Controls.Add(this.checkBoxRepeat);
            this.Controls.Add(this.checkBoxAllDay);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.textBoxEvent);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "eventDialog";
            this.ShowInTaskbar = false;
            this.Text = "eventDialog";
            this.TopMost = true;
            this.panelRepeat.ResumeLayout(false);
            this.panelRepeat.PerformLayout();
            this.panelWeekDay.ResumeLayout(false);
            this.panelWeekDay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBoxAllDay;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.Label labelWhere;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxWhere;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelRepeat;
        private System.Windows.Forms.Label labelRepeatOn;
        private System.Windows.Forms.Label labelRepeatEvery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRepeat;
        private System.Windows.Forms.RadioButton radioButtonOn;
        private System.Windows.Forms.RadioButton radioButtonAfter;
        private System.Windows.Forms.RadioButton radioButtonNever;
        private System.Windows.Forms.Label labelEnds;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox0;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBoxRepeats;
        private System.Windows.Forms.Panel panelWeekDay;
    }
}