namespace ARM_MedRegistrar.View.ChangeDataOfDoctor
{
    partial class ChangeDataOfDoctorForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label6 = new Label();
            textId = new TextBox();
            buttSearch = new Button();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            textPatr = new TextBox();
            textName = new TextBox();
            textSurname = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label8 = new Label();
            comboBoxSpecializations = new ComboBox();
            label9 = new Label();
            textPhoneNumber = new TextBox();
            checkNoCloseWindow = new CheckBox();
            buttSaveChanges = new Button();
            errorNoId = new ErrorProvider(components);
            errorNoSurname = new ErrorProvider(components);
            errorNoName = new ErrorProvider(components);
            errorNoCabinet = new ErrorProvider(components);
            errorNoPhoneNumber = new ErrorProvider(components);
            errorNoSpecialization = new ErrorProvider(components);
            textCabinet = new TextBox();
            textPlotNumber = new TextBox();
            errorNoPlotNumber = new ErrorProvider(components);
            label20 = new Label();
            label19 = new Label();
            checkIsWeekendTues = new CheckBox();
            checkIsWeekendWed = new CheckBox();
            checkIsWeekendThurs = new CheckBox();
            checkIsWeekendFri = new CheckBox();
            checkIsWeekendSat = new CheckBox();
            checkIsWeekendSun = new CheckBox();
            checkIsWeekendMon = new CheckBox();
            timeSunWorkEnd = new DateTimePicker();
            timeSunWorkBeginning = new DateTimePicker();
            timeTuesWorkBeginning = new DateTimePicker();
            timeTuesWorkEnd = new DateTimePicker();
            timeThursWorkBeginning = new DateTimePicker();
            timeThursWorkEnd = new DateTimePicker();
            timeFriWorkBeginning = new DateTimePicker();
            timeFriWorkEnd = new DateTimePicker();
            timeSatWorkBeginning = new DateTimePicker();
            timeSatWorkEnd = new DateTimePicker();
            timeWedWorkBeginning = new DateTimePicker();
            timeWedWorkEnd = new DateTimePicker();
            timeMonWorkEnd = new DateTimePicker();
            timeMonWorkBeginning = new DateTimePicker();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label17 = new Label();
            label18 = new Label();
            timeDurationOfAppointment = new DateTimePicker();
            label21 = new Label();
            errorNoDurationOfAppointment = new ErrorProvider(components);
            errorNoCorrectTimeMon = new ErrorProvider(components);
            errorNoCorrectTimeThurs = new ErrorProvider(components);
            errorNoCorrectTimeFri = new ErrorProvider(components);
            errorNoCorrectTimeSat = new ErrorProvider(components);
            errorNoCorrectTimeSun = new ErrorProvider(components);
            errorNoCorrectTimeWed = new ErrorProvider(components);
            errorNoCorrectTimeTues = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorNoId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCabinet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSpecialization).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPlotNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoDurationOfAppointment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeMon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeThurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeFri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeSat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeSun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeWed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeTues).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(322, 32);
            label1.TabIndex = 2;
            label1.Text = "Изменение данных врача";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(392, 46);
            label6.Name = "label6";
            label6.Size = new Size(172, 28);
            label6.TabIndex = 102;
            label6.Text = "Введите ID врача:\r\n";
            // 
            // textId
            // 
            textId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(579, 46);
            textId.Name = "textId";
            textId.Size = new Size(125, 34);
            textId.TabIndex = 103;
            textId.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // buttSearch
            // 
            buttSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttSearch.Location = new Point(721, 42);
            buttSearch.Name = "buttSearch";
            buttSearch.Size = new Size(103, 43);
            buttSearch.TabIndex = 104;
            buttSearch.Text = "Найти";
            buttSearch.UseVisualStyleBackColor = true;
            buttSearch.Click += buttSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(25, 249);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(234, 28);
            label4.TabIndex = 110;
            label4.Text = "Отчество (при наличии)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(25, 182);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 109;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(25, 114);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 108;
            label3.Text = "Фамилия";
            // 
            // textPatr
            // 
            textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatr.Location = new Point(24, 280);
            textPatr.Name = "textPatr";
            textPatr.Size = new Size(289, 34);
            textPatr.TabIndex = 107;
            textPatr.KeyPress += textBox_SpacePress;
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(24, 210);
            textName.Name = "textName";
            textName.Size = new Size(289, 34);
            textName.TabIndex = 106;
            textName.KeyPress += textBox_SpacePress;
            // 
            // textSurname
            // 
            textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(24, 145);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(289, 34);
            textSurname.TabIndex = 105;
            textSurname.KeyPress += textBox_SpacePress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(498, 310);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 28);
            label7.TabIndex = 116;
            label7.Text = "Номер кабинета";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(498, 210);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 28);
            label5.TabIndex = 115;
            label5.Text = "Номер участка";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(498, 113);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(156, 28);
            label8.TabIndex = 114;
            label8.Text = "Специализация";
            // 
            // comboBoxSpecializations
            // 
            comboBoxSpecializations.BackColor = Color.White;
            comboBoxSpecializations.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecializations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSpecializations.ForeColor = Color.Firebrick;
            comboBoxSpecializations.FormattingEnabled = true;
            comboBoxSpecializations.Location = new Point(498, 159);
            comboBoxSpecializations.Margin = new Padding(4);
            comboBoxSpecializations.Name = "comboBoxSpecializations";
            comboBoxSpecializations.Size = new Size(252, 36);
            comboBoxSpecializations.TabIndex = 111;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(25, 328);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(166, 28);
            label9.TabIndex = 118;
            label9.Text = "Номер телефона\r\n";
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.BackColor = Color.White;
            textPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPhoneNumber.Location = new Point(24, 360);
            textPhoneNumber.Margin = new Padding(4);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(278, 34);
            textPhoneNumber.TabIndex = 117;
            textPhoneNumber.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // checkNoCloseWindow
            // 
            checkNoCloseWindow.AutoSize = true;
            checkNoCloseWindow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkNoCloseWindow.Location = new Point(579, 575);
            checkNoCloseWindow.Name = "checkNoCloseWindow";
            checkNoCloseWindow.Size = new Size(206, 32);
            checkNoCloseWindow.TabIndex = 120;
            checkNoCloseWindow.Text = "не закрывать окно";
            checkNoCloseWindow.UseVisualStyleBackColor = true;
            // 
            // buttSaveChanges
            // 
            buttSaveChanges.BackColor = Color.FromArgb(255, 192, 192);
            buttSaveChanges.Enabled = false;
            buttSaveChanges.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttSaveChanges.ForeColor = Color.Firebrick;
            buttSaveChanges.Location = new Point(195, 566);
            buttSaveChanges.Margin = new Padding(4);
            buttSaveChanges.Name = "buttSaveChanges";
            buttSaveChanges.Size = new Size(369, 47);
            buttSaveChanges.TabIndex = 119;
            buttSaveChanges.Text = "Сохранить изменения";
            buttSaveChanges.UseVisualStyleBackColor = false;
            buttSaveChanges.Click += buttSaveChanges_Click;
            // 
            // errorNoId
            // 
            errorNoId.ContainerControl = this;
            // 
            // errorNoSurname
            // 
            errorNoSurname.ContainerControl = this;
            // 
            // errorNoName
            // 
            errorNoName.ContainerControl = this;
            // 
            // errorNoCabinet
            // 
            errorNoCabinet.ContainerControl = this;
            // 
            // errorNoPhoneNumber
            // 
            errorNoPhoneNumber.ContainerControl = this;
            // 
            // errorNoSpecialization
            // 
            errorNoSpecialization.ContainerControl = this;
            // 
            // textCabinet
            // 
            textCabinet.BackColor = Color.White;
            textCabinet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textCabinet.Location = new Point(498, 360);
            textCabinet.Margin = new Padding(4);
            textCabinet.Name = "textCabinet";
            textCabinet.Size = new Size(198, 34);
            textCabinet.TabIndex = 123;
            textCabinet.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // textPlotNumber
            // 
            textPlotNumber.BackColor = Color.White;
            textPlotNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPlotNumber.Location = new Point(498, 258);
            textPlotNumber.Margin = new Padding(4);
            textPlotNumber.Name = "textPlotNumber";
            textPlotNumber.Size = new Size(198, 34);
            textPlotNumber.TabIndex = 122;
            textPlotNumber.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // errorNoPlotNumber
            // 
            errorNoPlotNumber.ContainerControl = this;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Firebrick;
            label20.Location = new Point(1206, 105);
            label20.Name = "label20";
            label20.Size = new Size(174, 28);
            label20.TabIndex = 154;
            label20.Text = "Конец рабоч. дня";
            label20.TextAlign = ContentAlignment.TopCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Firebrick;
            label19.Location = new Point(983, 105);
            label19.Name = "label19";
            label19.Size = new Size(184, 28);
            label19.TabIndex = 153;
            label19.Text = "Начало рабоч. дня";
            label19.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkIsWeekendTues
            // 
            checkIsWeekendTues.AutoSize = true;
            checkIsWeekendTues.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkIsWeekendTues.Location = new Point(845, 213);
            checkIsWeekendTues.Name = "checkIsWeekendTues";
            checkIsWeekendTues.Size = new Size(72, 32);
            checkIsWeekendTues.TabIndex = 152;
            checkIsWeekendTues.Text = "Вых.";
            checkIsWeekendTues.UseVisualStyleBackColor = true;
            checkIsWeekendTues.CheckedChanged += checkIsWeekendTues_CheckedChanged;
            // 
            // checkIsWeekendWed
            // 
            checkIsWeekendWed.AutoSize = true;
            checkIsWeekendWed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkIsWeekendWed.Location = new Point(845, 286);
            checkIsWeekendWed.Name = "checkIsWeekendWed";
            checkIsWeekendWed.Size = new Size(72, 32);
            checkIsWeekendWed.TabIndex = 151;
            checkIsWeekendWed.Text = "Вых.";
            checkIsWeekendWed.UseVisualStyleBackColor = true;
            checkIsWeekendWed.CheckedChanged += checkIsWeekendWed_CheckedChanged;
            // 
            // checkIsWeekendThurs
            // 
            checkIsWeekendThurs.AutoSize = true;
            checkIsWeekendThurs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkIsWeekendThurs.Location = new Point(845, 360);
            checkIsWeekendThurs.Name = "checkIsWeekendThurs";
            checkIsWeekendThurs.Size = new Size(72, 32);
            checkIsWeekendThurs.TabIndex = 150;
            checkIsWeekendThurs.Text = "Вых.";
            checkIsWeekendThurs.UseVisualStyleBackColor = true;
            checkIsWeekendThurs.CheckedChanged += checkIsWeekendThurs_CheckedChanged;
            // 
            // checkIsWeekendFri
            // 
            checkIsWeekendFri.AutoSize = true;
            checkIsWeekendFri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkIsWeekendFri.Location = new Point(845, 425);
            checkIsWeekendFri.Name = "checkIsWeekendFri";
            checkIsWeekendFri.Size = new Size(72, 32);
            checkIsWeekendFri.TabIndex = 149;
            checkIsWeekendFri.Text = "Вых.";
            checkIsWeekendFri.UseVisualStyleBackColor = true;
            checkIsWeekendFri.CheckedChanged += checkIsWeekendFri_CheckedChanged;
            // 
            // checkIsWeekendSat
            // 
            checkIsWeekendSat.AutoSize = true;
            checkIsWeekendSat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkIsWeekendSat.Location = new Point(845, 497);
            checkIsWeekendSat.Name = "checkIsWeekendSat";
            checkIsWeekendSat.Size = new Size(72, 32);
            checkIsWeekendSat.TabIndex = 148;
            checkIsWeekendSat.Text = "Вых.";
            checkIsWeekendSat.UseVisualStyleBackColor = true;
            checkIsWeekendSat.CheckedChanged += checkIsWeekendSat_CheckedChanged;
            // 
            // checkIsWeekendSun
            // 
            checkIsWeekendSun.AutoSize = true;
            checkIsWeekendSun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkIsWeekendSun.Location = new Point(845, 559);
            checkIsWeekendSun.Name = "checkIsWeekendSun";
            checkIsWeekendSun.Size = new Size(72, 32);
            checkIsWeekendSun.TabIndex = 147;
            checkIsWeekendSun.Text = "Вых.";
            checkIsWeekendSun.UseVisualStyleBackColor = true;
            checkIsWeekendSun.CheckedChanged += checkIsWeekendSun_CheckedChanged;
            // 
            // checkIsWeekendMon
            // 
            checkIsWeekendMon.AutoSize = true;
            checkIsWeekendMon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkIsWeekendMon.Location = new Point(845, 144);
            checkIsWeekendMon.Name = "checkIsWeekendMon";
            checkIsWeekendMon.Size = new Size(72, 32);
            checkIsWeekendMon.TabIndex = 146;
            checkIsWeekendMon.Text = "Вых.";
            checkIsWeekendMon.UseVisualStyleBackColor = true;
            checkIsWeekendMon.CheckedChanged += checkIsWeekendMon_CheckedChanged;
            // 
            // timeSunWorkEnd
            // 
            timeSunWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeSunWorkEnd.Format = DateTimePickerFormat.Time;
            timeSunWorkEnd.Location = new Point(1248, 555);
            timeSunWorkEnd.Name = "timeSunWorkEnd";
            timeSunWorkEnd.ShowUpDown = true;
            timeSunWorkEnd.Size = new Size(115, 34);
            timeSunWorkEnd.TabIndex = 145;
            // 
            // timeSunWorkBeginning
            // 
            timeSunWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeSunWorkBeginning.Format = DateTimePickerFormat.Time;
            timeSunWorkBeginning.Location = new Point(1035, 554);
            timeSunWorkBeginning.Name = "timeSunWorkBeginning";
            timeSunWorkBeginning.ShowUpDown = true;
            timeSunWorkBeginning.Size = new Size(115, 34);
            timeSunWorkBeginning.TabIndex = 144;
            // 
            // timeTuesWorkBeginning
            // 
            timeTuesWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeTuesWorkBeginning.Format = DateTimePickerFormat.Time;
            timeTuesWorkBeginning.Location = new Point(1035, 214);
            timeTuesWorkBeginning.Name = "timeTuesWorkBeginning";
            timeTuesWorkBeginning.ShowUpDown = true;
            timeTuesWorkBeginning.Size = new Size(115, 34);
            timeTuesWorkBeginning.TabIndex = 143;
            // 
            // timeTuesWorkEnd
            // 
            timeTuesWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeTuesWorkEnd.Format = DateTimePickerFormat.Time;
            timeTuesWorkEnd.Location = new Point(1248, 214);
            timeTuesWorkEnd.Name = "timeTuesWorkEnd";
            timeTuesWorkEnd.ShowUpDown = true;
            timeTuesWorkEnd.Size = new Size(115, 34);
            timeTuesWorkEnd.TabIndex = 142;
            // 
            // timeThursWorkBeginning
            // 
            timeThursWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeThursWorkBeginning.Format = DateTimePickerFormat.Time;
            timeThursWorkBeginning.Location = new Point(1035, 356);
            timeThursWorkBeginning.Name = "timeThursWorkBeginning";
            timeThursWorkBeginning.ShowUpDown = true;
            timeThursWorkBeginning.Size = new Size(115, 34);
            timeThursWorkBeginning.TabIndex = 141;
            // 
            // timeThursWorkEnd
            // 
            timeThursWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeThursWorkEnd.Format = DateTimePickerFormat.Time;
            timeThursWorkEnd.Location = new Point(1248, 356);
            timeThursWorkEnd.Name = "timeThursWorkEnd";
            timeThursWorkEnd.ShowUpDown = true;
            timeThursWorkEnd.Size = new Size(115, 34);
            timeThursWorkEnd.TabIndex = 140;
            // 
            // timeFriWorkBeginning
            // 
            timeFriWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeFriWorkBeginning.Format = DateTimePickerFormat.Time;
            timeFriWorkBeginning.Location = new Point(1035, 420);
            timeFriWorkBeginning.Name = "timeFriWorkBeginning";
            timeFriWorkBeginning.ShowUpDown = true;
            timeFriWorkBeginning.Size = new Size(115, 34);
            timeFriWorkBeginning.TabIndex = 139;
            // 
            // timeFriWorkEnd
            // 
            timeFriWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeFriWorkEnd.Format = DateTimePickerFormat.Time;
            timeFriWorkEnd.Location = new Point(1248, 420);
            timeFriWorkEnd.Name = "timeFriWorkEnd";
            timeFriWorkEnd.ShowUpDown = true;
            timeFriWorkEnd.Size = new Size(115, 34);
            timeFriWorkEnd.TabIndex = 138;
            // 
            // timeSatWorkBeginning
            // 
            timeSatWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeSatWorkBeginning.Format = DateTimePickerFormat.Time;
            timeSatWorkBeginning.Location = new Point(1035, 491);
            timeSatWorkBeginning.Name = "timeSatWorkBeginning";
            timeSatWorkBeginning.ShowUpDown = true;
            timeSatWorkBeginning.Size = new Size(115, 34);
            timeSatWorkBeginning.TabIndex = 137;
            // 
            // timeSatWorkEnd
            // 
            timeSatWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeSatWorkEnd.Format = DateTimePickerFormat.Time;
            timeSatWorkEnd.Location = new Point(1248, 491);
            timeSatWorkEnd.Name = "timeSatWorkEnd";
            timeSatWorkEnd.ShowUpDown = true;
            timeSatWorkEnd.Size = new Size(115, 34);
            timeSatWorkEnd.TabIndex = 136;
            // 
            // timeWedWorkBeginning
            // 
            timeWedWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeWedWorkBeginning.Format = DateTimePickerFormat.Time;
            timeWedWorkBeginning.Location = new Point(1035, 285);
            timeWedWorkBeginning.Name = "timeWedWorkBeginning";
            timeWedWorkBeginning.ShowUpDown = true;
            timeWedWorkBeginning.Size = new Size(115, 34);
            timeWedWorkBeginning.TabIndex = 135;
            // 
            // timeWedWorkEnd
            // 
            timeWedWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeWedWorkEnd.Format = DateTimePickerFormat.Time;
            timeWedWorkEnd.Location = new Point(1250, 285);
            timeWedWorkEnd.Name = "timeWedWorkEnd";
            timeWedWorkEnd.ShowUpDown = true;
            timeWedWorkEnd.Size = new Size(115, 34);
            timeWedWorkEnd.TabIndex = 134;
            // 
            // timeMonWorkEnd
            // 
            timeMonWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeMonWorkEnd.Format = DateTimePickerFormat.Time;
            timeMonWorkEnd.Location = new Point(1248, 139);
            timeMonWorkEnd.Name = "timeMonWorkEnd";
            timeMonWorkEnd.ShowUpDown = true;
            timeMonWorkEnd.Size = new Size(115, 34);
            timeMonWorkEnd.TabIndex = 133;
            // 
            // timeMonWorkBeginning
            // 
            timeMonWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeMonWorkBeginning.Format = DateTimePickerFormat.Time;
            timeMonWorkBeginning.Location = new Point(1035, 140);
            timeMonWorkBeginning.Name = "timeMonWorkBeginning";
            timeMonWorkBeginning.ShowUpDown = true;
            timeMonWorkBeginning.Size = new Size(115, 34);
            timeMonWorkBeginning.TabIndex = 132;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Firebrick;
            label16.Location = new Point(950, 425);
            label16.Name = "label16";
            label16.Size = new Size(34, 28);
            label16.TabIndex = 131;
            label16.Text = "Пт";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Firebrick;
            label15.Location = new Point(947, 356);
            label15.Name = "label15";
            label15.Size = new Size(33, 28);
            label15.TabIndex = 130;
            label15.Text = "Чт";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Firebrick;
            label14.Location = new Point(947, 497);
            label14.Name = "label14";
            label14.Size = new Size(36, 28);
            label14.TabIndex = 129;
            label14.Text = "Сб";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Firebrick;
            label13.Location = new Point(951, 560);
            label13.Name = "label13";
            label13.Size = new Size(32, 28);
            label13.TabIndex = 128;
            label13.Text = "Вс";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Firebrick;
            label12.Location = new Point(947, 285);
            label12.Name = "label12";
            label12.Size = new Size(36, 28);
            label12.TabIndex = 127;
            label12.Text = "Ср";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Firebrick;
            label11.Location = new Point(947, 214);
            label11.Name = "label11";
            label11.Size = new Size(31, 28);
            label11.TabIndex = 126;
            label11.Text = "Вт";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(947, 145);
            label10.Name = "label10";
            label10.Size = new Size(38, 28);
            label10.TabIndex = 125;
            label10.Text = "Пн";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Firebrick;
            label17.Location = new Point(1082, 49);
            label17.Name = "label17";
            label17.Size = new Size(190, 31);
            label17.TabIndex = 124;
            label17.Text = "График работы ";
            label17.TextAlign = ContentAlignment.TopCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(838, 614);
            label18.Name = "label18";
            label18.Size = new Size(329, 28);
            label18.TabIndex = 155;
            label18.Text = "Вых. - выходной (нерабочий день)";
            // 
            // timeDurationOfAppointment
            // 
            timeDurationOfAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeDurationOfAppointment.Format = DateTimePickerFormat.Time;
            timeDurationOfAppointment.Location = new Point(279, 465);
            timeDurationOfAppointment.Name = "timeDurationOfAppointment";
            timeDurationOfAppointment.ShowUpDown = true;
            timeDurationOfAppointment.Size = new Size(115, 34);
            timeDurationOfAppointment.TabIndex = 156;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.Firebrick;
            label21.Location = new Point(279, 420);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(276, 28);
            label21.TabIndex = 157;
            label21.Text = "Продолжительность приёма";
            // 
            // errorNoDurationOfAppointment
            // 
            errorNoDurationOfAppointment.ContainerControl = this;
            // 
            // errorNoCorrectTimeMon
            // 
            errorNoCorrectTimeMon.ContainerControl = this;
            // 
            // errorNoCorrectTimeThurs
            // 
            errorNoCorrectTimeThurs.ContainerControl = this;
            // 
            // errorNoCorrectTimeFri
            // 
            errorNoCorrectTimeFri.ContainerControl = this;
            // 
            // errorNoCorrectTimeSat
            // 
            errorNoCorrectTimeSat.ContainerControl = this;
            // 
            // errorNoCorrectTimeSun
            // 
            errorNoCorrectTimeSun.ContainerControl = this;
            // 
            // errorNoCorrectTimeWed
            // 
            errorNoCorrectTimeWed.ContainerControl = this;
            // 
            // errorNoCorrectTimeTues
            // 
            errorNoCorrectTimeTues.ContainerControl = this;
            // 
            // ChangeDataOfDoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1427, 662);
            Controls.Add(label21);
            Controls.Add(timeDurationOfAppointment);
            Controls.Add(label18);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(checkIsWeekendTues);
            Controls.Add(checkIsWeekendWed);
            Controls.Add(checkIsWeekendThurs);
            Controls.Add(checkIsWeekendFri);
            Controls.Add(checkIsWeekendSat);
            Controls.Add(checkIsWeekendSun);
            Controls.Add(checkIsWeekendMon);
            Controls.Add(timeSunWorkEnd);
            Controls.Add(timeSunWorkBeginning);
            Controls.Add(timeTuesWorkBeginning);
            Controls.Add(timeTuesWorkEnd);
            Controls.Add(timeThursWorkBeginning);
            Controls.Add(timeThursWorkEnd);
            Controls.Add(timeFriWorkBeginning);
            Controls.Add(timeFriWorkEnd);
            Controls.Add(timeSatWorkBeginning);
            Controls.Add(timeSatWorkEnd);
            Controls.Add(timeWedWorkBeginning);
            Controls.Add(timeWedWorkEnd);
            Controls.Add(timeMonWorkEnd);
            Controls.Add(timeMonWorkBeginning);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label17);
            Controls.Add(textCabinet);
            Controls.Add(textPlotNumber);
            Controls.Add(checkNoCloseWindow);
            Controls.Add(buttSaveChanges);
            Controls.Add(label9);
            Controls.Add(textPhoneNumber);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(comboBoxSpecializations);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textPatr);
            Controls.Add(textName);
            Controls.Add(textSurname);
            Controls.Add(buttSearch);
            Controls.Add(textId);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChangeDataOfDoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARM_MedRegistrar";
            ((System.ComponentModel.ISupportInitialize)errorNoId).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCabinet).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSpecialization).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPlotNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoDurationOfAppointment).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeMon).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeThurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeFri).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeSat).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeSun).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeWed).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCorrectTimeTues).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private TextBox textId;
        private Button buttSearch;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox textPatr;
        private TextBox textName;
        private TextBox textSurname;
        private Label label7;
        private Label label5;
        private Label label8;
        private ComboBox comboBoxSpecializations;
        private Label label9;
        private TextBox textPhoneNumber;
        private CheckBox checkNoCloseWindow;
        private Button buttSaveChanges;
        private ErrorProvider errorNoId;
        private ErrorProvider errorNoSurname;
        private ErrorProvider errorNoName;
        private ErrorProvider errorNoCabinet;
        private ErrorProvider errorNoPhoneNumber;
        private ErrorProvider errorNoSpecialization;
        private TextBox textCabinet;
        private TextBox textPlotNumber;
        private ErrorProvider errorNoPlotNumber;
        private Label label20;
        private Label label19;
        private CheckBox checkIsWeekendTues;
        private CheckBox checkIsWeekendWed;
        private CheckBox checkIsWeekendThurs;
        private CheckBox checkIsWeekendFri;
        private CheckBox checkIsWeekendSat;
        private CheckBox checkIsWeekendSun;
        private CheckBox checkIsWeekendMon;
        private DateTimePicker timeSunWorkEnd;
        private DateTimePicker timeSunWorkBeginning;
        private DateTimePicker timeTuesWorkBeginning;
        private DateTimePicker timeTuesWorkEnd;
        private DateTimePicker timeThursWorkBeginning;
        private DateTimePicker timeThursWorkEnd;
        private DateTimePicker timeFriWorkBeginning;
        private DateTimePicker timeFriWorkEnd;
        private DateTimePicker timeSatWorkBeginning;
        private DateTimePicker timeSatWorkEnd;
        private DateTimePicker timeWedWorkBeginning;
        private DateTimePicker timeWedWorkEnd;
        private DateTimePicker timeMonWorkEnd;
        private DateTimePicker timeMonWorkBeginning;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label17;
        private Label label18;
        private DateTimePicker timeDurationOfAppointment;
        private Label label21;
        private ErrorProvider errorNoDurationOfAppointment;
        private ErrorProvider errorNoCorrectTimeMon;
        private ErrorProvider errorNoCorrectTimeThurs;
        private ErrorProvider errorNoCorrectTimeFri;
        private ErrorProvider errorNoCorrectTimeSat;
        private ErrorProvider errorNoCorrectTimeSun;
        private ErrorProvider errorNoCorrectTimeWed;
        private ErrorProvider errorNoCorrectTimeTues;
    }
}