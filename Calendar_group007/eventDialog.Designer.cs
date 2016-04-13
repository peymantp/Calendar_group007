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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.panelRepeat = new System.Windows.Forms.Panel();
            this.dateTimePickerOn = new System.Windows.Forms.DateTimePicker();
            this.labelOccurrences = new System.Windows.Forms.Label();
            this.comboBoxAfter = new System.Windows.Forms.ComboBox();
            this.panelWeekDay = new System.Windows.Forms.Panel();
            this.labelRepeatOn = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.labelChange = new System.Windows.Forms.Label();
            this.comboBoxRepeatEvery = new System.Windows.Forms.ComboBox();
            this.comboBoxRepeats = new System.Windows.Forms.ComboBox();
            this.radioButtonOn = new System.Windows.Forms.RadioButton();
            this.radioButtonAfter = new System.Windows.Forms.RadioButton();
            this.radioButtonNever = new System.Windows.Forms.RadioButton();
            this.labelEnds = new System.Windows.Forms.Label();
            this.labelRepeatEvery = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRepeat = new System.Windows.Forms.Label();
            this.panelRepeat.SuspendLayout();
            this.panelWeekDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(9, 8);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(65, 20);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(77, 8);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(65, 20);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEvent.Location = new System.Drawing.Point(9, 33);
            this.textBoxEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(302, 26);
            this.textBoxEvent.TabIndex = 4;
            this.textBoxEvent.Text = "Untitled event";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd, MM, yyyy: HH:mm";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(9, 65);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(135, 20);
            this.dateTimePickerFrom.TabIndex = 5;
            this.dateTimePickerFrom.Value = new System.DateTime(2016, 4, 1, 13, 0, 0, 0);
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd, MM, yyyy: HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(175, 65);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(150, 69);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(19, 16);
            this.labelTo.TabIndex = 7;
            this.labelTo.Text = "to";
            // 
            // checkBoxAllDay
            // 
            this.checkBoxAllDay.AutoSize = true;
            this.checkBoxAllDay.Location = new System.Drawing.Point(9, 90);
            this.checkBoxAllDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxAllDay.Name = "checkBoxAllDay";
            this.checkBoxAllDay.Size = new System.Drawing.Size(57, 17);
            this.checkBoxAllDay.TabIndex = 8;
            this.checkBoxAllDay.Text = "All day";
            this.checkBoxAllDay.UseVisualStyleBackColor = true;
            this.checkBoxAllDay.CheckStateChanged += new System.EventHandler(this.Check_AllDay);
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(84, 90);
            this.checkBoxRepeat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(61, 17);
            this.checkBoxRepeat.TabIndex = 9;
            this.checkBoxRepeat.Text = "Repeat";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            this.checkBoxRepeat.Visible = false;
            this.checkBoxRepeat.CheckedChanged += new System.EventHandler(this.checkBoxRepeat_CheckedChanged);
            // 
            // labelWhere
            // 
            this.labelWhere.AutoSize = true;
            this.labelWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhere.Location = new System.Drawing.Point(6, 115);
            this.labelWhere.Name = "labelWhere";
            this.labelWhere.Size = new System.Drawing.Size(48, 16);
            this.labelWhere.TabIndex = 10;
            this.labelWhere.Text = "Where";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(6, 139);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(76, 16);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Description";
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.Location = new System.Drawing.Point(95, 114);
            this.textBoxWhere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.Size = new System.Drawing.Size(217, 20);
            this.textBoxWhere.TabIndex = 12;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(95, 140);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(217, 43);
            this.textBoxDescription.TabIndex = 13;
            // 
            // panelRepeat
            // 
            this.panelRepeat.AutoSize = true;
            this.panelRepeat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelRepeat.Controls.Add(this.dateTimePickerOn);
            this.panelRepeat.Controls.Add(this.labelOccurrences);
            this.panelRepeat.Controls.Add(this.comboBoxAfter);
            this.panelRepeat.Controls.Add(this.panelWeekDay);
            this.panelRepeat.Controls.Add(this.labelChange);
            this.panelRepeat.Controls.Add(this.comboBoxRepeatEvery);
            this.panelRepeat.Controls.Add(this.comboBoxRepeats);
            this.panelRepeat.Controls.Add(this.radioButtonOn);
            this.panelRepeat.Controls.Add(this.radioButtonAfter);
            this.panelRepeat.Controls.Add(this.radioButtonNever);
            this.panelRepeat.Controls.Add(this.labelEnds);
            this.panelRepeat.Controls.Add(this.labelRepeatEvery);
            this.panelRepeat.Controls.Add(this.label1);
            this.panelRepeat.Controls.Add(this.labelRepeat);
            this.panelRepeat.Location = new System.Drawing.Point(-1, 189);
            this.panelRepeat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRepeat.Name = "panelRepeat";
            this.panelRepeat.Size = new System.Drawing.Size(323, 160);
            this.panelRepeat.TabIndex = 14;
            this.panelRepeat.Visible = false;
            // 
            // dateTimePickerOn
            // 
            this.dateTimePickerOn.CustomFormat = "MMM dd, yyyy";
            this.dateTimePickerOn.Enabled = false;
            this.dateTimePickerOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOn.Location = new System.Drawing.Point(153, 137);
            this.dateTimePickerOn.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerOn.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerOn.Name = "dateTimePickerOn";
            this.dateTimePickerOn.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerOn.TabIndex = 15;
            this.dateTimePickerOn.Value = new System.DateTime(2016, 12, 25, 23, 59, 59, 0);
            // 
            // labelOccurrences
            // 
            this.labelOccurrences.AutoSize = true;
            this.labelOccurrences.Location = new System.Drawing.Point(237, 118);
            this.labelOccurrences.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOccurrences.Name = "labelOccurrences";
            this.labelOccurrences.Size = new System.Drawing.Size(68, 13);
            this.labelOccurrences.TabIndex = 30;
            this.labelOccurrences.Text = "Occurrences";
            // 
            // comboBoxAfter
            // 
            this.comboBoxAfter.Enabled = false;
            this.comboBoxAfter.FormattingEnabled = true;
            this.comboBoxAfter.Items.AddRange(new object[] {
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
            this.comboBoxAfter.Location = new System.Drawing.Point(153, 115);
            this.comboBoxAfter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAfter.Name = "comboBoxAfter";
            this.comboBoxAfter.Size = new System.Drawing.Size(82, 21);
            this.comboBoxAfter.TabIndex = 29;
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
            this.panelWeekDay.Location = new System.Drawing.Point(10, 71);
            this.panelWeekDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelWeekDay.Name = "panelWeekDay";
            this.panelWeekDay.Size = new System.Drawing.Size(311, 25);
            this.panelWeekDay.TabIndex = 28;
            this.panelWeekDay.Visible = false;
            // 
            // labelRepeatOn
            // 
            this.labelRepeatOn.AutoSize = true;
            this.labelRepeatOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepeatOn.Location = new System.Drawing.Point(4, 5);
            this.labelRepeatOn.Name = "labelRepeatOn";
            this.labelRepeatOn.Size = new System.Drawing.Size(71, 16);
            this.labelRepeatOn.TabIndex = 13;
            this.labelRepeatOn.Text = "Repeat on";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(281, 5);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(33, 17);
            this.checkBox6.TabIndex = 27;
            this.checkBox6.Text = "S";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.Location = new System.Drawing.Point(93, 5);
            this.checkBox0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(33, 17);
            this.checkBox0.TabIndex = 21;
            this.checkBox0.Text = "S";
            this.checkBox0.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(253, 5);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(32, 17);
            this.checkBox5.TabIndex = 26;
            this.checkBox5.Text = "F";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(123, 5);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(35, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "M";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(221, 5);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(33, 17);
            this.checkBox4.TabIndex = 25;
            this.checkBox4.Text = "T";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(156, 5);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(33, 17);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "T";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(188, 5);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(37, 17);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.Text = "W";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(187, 52);
            this.labelChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(29, 13);
            this.labelChange.TabIndex = 20;
            this.labelChange.Text = "days";
            // 
            // comboBoxRepeatEvery
            // 
            this.comboBoxRepeatEvery.FormattingEnabled = true;
            this.comboBoxRepeatEvery.Items.AddRange(new object[] {
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
            this.comboBoxRepeatEvery.Location = new System.Drawing.Point(103, 49);
            this.comboBoxRepeatEvery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxRepeatEvery.Name = "comboBoxRepeatEvery";
            this.comboBoxRepeatEvery.Size = new System.Drawing.Size(82, 21);
            this.comboBoxRepeatEvery.TabIndex = 19;
            this.comboBoxRepeatEvery.Text = "1";
            // 
            // comboBoxRepeats
            // 
            this.comboBoxRepeats.FormattingEnabled = true;
            this.comboBoxRepeats.Items.AddRange(new object[] {
            "DAILY",
            "WEEKLY",
            "MONTHLY",
            "YEARLY"});
            this.comboBoxRepeats.Location = new System.Drawing.Point(103, 26);
            this.comboBoxRepeats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxRepeats.Name = "comboBoxRepeats";
            this.comboBoxRepeats.Size = new System.Drawing.Size(195, 21);
            this.comboBoxRepeats.TabIndex = 18;
            this.comboBoxRepeats.Text = "DAILY";
            this.comboBoxRepeats.SelectedIndexChanged += new System.EventHandler(this.Repeats_Changed);
            // 
            // radioButtonOn
            // 
            this.radioButtonOn.AutoSize = true;
            this.radioButtonOn.Location = new System.Drawing.Point(103, 137);
            this.radioButtonOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonOn.Name = "radioButtonOn";
            this.radioButtonOn.Size = new System.Drawing.Size(39, 17);
            this.radioButtonOn.TabIndex = 17;
            this.radioButtonOn.TabStop = true;
            this.radioButtonOn.Text = "On";
            this.radioButtonOn.UseVisualStyleBackColor = true;
            this.radioButtonOn.CheckedChanged += new System.EventHandler(this.radioButtonOn_CheckedChanged);
            // 
            // radioButtonAfter
            // 
            this.radioButtonAfter.AutoSize = true;
            this.radioButtonAfter.Location = new System.Drawing.Point(103, 118);
            this.radioButtonAfter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonAfter.Name = "radioButtonAfter";
            this.radioButtonAfter.Size = new System.Drawing.Size(47, 17);
            this.radioButtonAfter.TabIndex = 16;
            this.radioButtonAfter.TabStop = true;
            this.radioButtonAfter.Text = "After";
            this.radioButtonAfter.UseVisualStyleBackColor = true;
            this.radioButtonAfter.CheckedChanged += new System.EventHandler(this.radioButtonAfter_CheckedChanged);
            // 
            // radioButtonNever
            // 
            this.radioButtonNever.AutoSize = true;
            this.radioButtonNever.Checked = true;
            this.radioButtonNever.Location = new System.Drawing.Point(103, 98);
            this.radioButtonNever.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonNever.Name = "radioButtonNever";
            this.radioButtonNever.Size = new System.Drawing.Size(54, 17);
            this.radioButtonNever.TabIndex = 15;
            this.radioButtonNever.TabStop = true;
            this.radioButtonNever.Text = "Never";
            this.radioButtonNever.UseVisualStyleBackColor = true;
            // 
            // labelEnds
            // 
            this.labelEnds.AutoSize = true;
            this.labelEnds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnds.Location = new System.Drawing.Point(14, 98);
            this.labelEnds.Name = "labelEnds";
            this.labelEnds.Size = new System.Drawing.Size(39, 16);
            this.labelEnds.TabIndex = 14;
            this.labelEnds.Text = "Ends";
            // 
            // labelRepeatEvery
            // 
            this.labelRepeatEvery.AutoSize = true;
            this.labelRepeatEvery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepeatEvery.Location = new System.Drawing.Point(14, 49);
            this.labelRepeatEvery.Name = "labelRepeatEvery";
            this.labelRepeatEvery.Size = new System.Drawing.Size(90, 16);
            this.labelRepeatEvery.TabIndex = 12;
            this.labelRepeatEvery.Text = "Repeat every";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Repeats";
            // 
            // labelRepeat
            // 
            this.labelRepeat.AutoSize = true;
            this.labelRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepeat.Location = new System.Drawing.Point(3, 3);
            this.labelRepeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRepeat.Name = "labelRepeat";
            this.labelRepeat.Size = new System.Drawing.Size(61, 18);
            this.labelRepeat.TabIndex = 0;
            this.labelRepeat.Text = "Repeat";
            // 
            // eventDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(322, 353);
            this.Controls.Add(this.panelRepeat);
            this.Controls.Add(this.textBoxDescription);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox textBoxDescription;
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
        private System.Windows.Forms.ComboBox comboBoxRepeatEvery;
        private System.Windows.Forms.ComboBox comboBoxRepeats;
        private System.Windows.Forms.Panel panelWeekDay;
        private System.Windows.Forms.ComboBox comboBoxAfter;
        private System.Windows.Forms.DateTimePicker dateTimePickerOn;
        private System.Windows.Forms.Label labelOccurrences;
    }
}