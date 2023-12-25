namespace ARM_MedRegistrar;

partial class AddDoctorForm
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
        label2 = new Label();
        comboBoxSpecializations = new ComboBox();
        textSurname = new TextBox();
        textName = new TextBox();
        textPatr = new TextBox();
        buttAddDoctor = new Button();
        label3 = new Label();
        label1 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        errorNoSurname = new ErrorProvider(components);
        errorNoName = new ErrorProvider(components);
        errorNoCabinet = new ErrorProvider(components);
        errorNoSpecial = new ErrorProvider(components);
        checkNoCloseWindow = new CheckBox();
        textPhoneNumber = new TextBox();
        label8 = new Label();
        errorNoPhoneNumber = new ErrorProvider(components);
        toolEnterPhoneNumb = new ToolTip(components);
        textPlotNumber = new TextBox();
        textCabinet = new TextBox();
        errorNoPlotNumber = new ErrorProvider(components);
        label9 = new Label();
        errorNoSchedule = new ErrorProvider(components);
        label10 = new Label();
        label11 = new Label();
        label12 = new Label();
        label13 = new Label();
        label14 = new Label();
        label15 = new Label();
        label16 = new Label();
        timeMonWorkBeginning = new DateTimePicker();
        timeMonWorkEnd = new DateTimePicker();
        timeWedWorkEnd = new DateTimePicker();
        timeWedWorkBeginning = new DateTimePicker();
        timeSatWorkEnd = new DateTimePicker();
        timeSatWorkBeginning = new DateTimePicker();
        timeFriWorkEnd = new DateTimePicker();
        timeFriWorkBeginning = new DateTimePicker();
        timeThursWorkEnd = new DateTimePicker();
        timeThursWorkBeginning = new DateTimePicker();
        timeTuesWorkEnd = new DateTimePicker();
        timeTuesWorkBeginning = new DateTimePicker();
        timeSunWorkBeginning = new DateTimePicker();
        timeSunWorkEnd = new DateTimePicker();
        checkIsWeekendMon = new CheckBox();
        checkIsWeekendSun = new CheckBox();
        checkIsWeekendSat = new CheckBox();
        checkIsWeekendFri = new CheckBox();
        checkIsWeekendThurs = new CheckBox();
        checkIsWeekendWed = new CheckBox();
        checkIsWeekendTues = new CheckBox();
        label17 = new Label();
        timeDurationOfAppointment = new DateTimePicker();
        label18 = new Label();
        errorNoDurationOfAppointment = new ErrorProvider(components);
        errorNoCorrectTimeMon = new ErrorProvider(components);
        errorNoCorrectTimeThurs = new ErrorProvider(components);
        errorNoCorrectTimeFri = new ErrorProvider(components);
        errorNoCorrectTimeSat = new ErrorProvider(components);
        errorNoCorrectTimeSun = new ErrorProvider(components);
        errorNoCorrectTimeWed = new ErrorProvider(components);
        errorNoCorrectTimeTues = new ErrorProvider(components);
        label19 = new Label();
        label20 = new Label();
        ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoCabinet).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoSpecial).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPlotNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoSchedule).BeginInit();
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
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.Firebrick;
        label2.Location = new Point(196, 47);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(268, 37);
        label2.TabIndex = 2;
        label2.Text = "Добавление врача";
        // 
        // comboBoxSpecializations
        // 
        comboBoxSpecializations.BackColor = Color.White;
        comboBoxSpecializations.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxSpecializations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        comboBoxSpecializations.ForeColor = Color.Firebrick;
        comboBoxSpecializations.FormattingEnabled = true;
        comboBoxSpecializations.Location = new Point(413, 142);
        comboBoxSpecializations.Margin = new Padding(4);
        comboBoxSpecializations.Name = "comboBoxSpecializations";
        comboBoxSpecializations.Size = new Size(252, 36);
        comboBoxSpecializations.TabIndex = 3;
        // 
        // textSurname
        // 
        textSurname.BackColor = Color.White;
        textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textSurname.Location = new Point(16, 144);
        textSurname.Margin = new Padding(4);
        textSurname.Name = "textSurname";
        textSurname.Size = new Size(312, 34);
        textSurname.TabIndex = 20;
        textSurname.KeyPress += textBox_SpacePress;
        // 
        // textName
        // 
        textName.BackColor = Color.White;
        textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textName.Location = new Point(16, 261);
        textName.Margin = new Padding(4);
        textName.Name = "textName";
        textName.Size = new Size(312, 34);
        textName.TabIndex = 21;
        textName.KeyPress += textBox_SpacePress;
        // 
        // textPatr
        // 
        textPatr.BackColor = Color.White;
        textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPatr.Location = new Point(13, 370);
        textPatr.Margin = new Padding(4);
        textPatr.Name = "textPatr";
        textPatr.Size = new Size(315, 34);
        textPatr.TabIndex = 22;
        textPatr.KeyPress += textBox_SpacePress;
        // 
        // buttAddDoctor
        // 
        buttAddDoctor.BackColor = Color.FromArgb(255, 192, 192);
        buttAddDoctor.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        buttAddDoctor.ForeColor = Color.Firebrick;
        buttAddDoctor.Location = new Point(502, 575);
        buttAddDoctor.Margin = new Padding(4);
        buttAddDoctor.Name = "buttAddDoctor";
        buttAddDoctor.Size = new Size(194, 70);
        buttAddDoctor.TabIndex = 25;
        buttAddDoctor.Text = "Добавить";
        buttAddDoctor.UseVisualStyleBackColor = false;
        buttAddDoctor.Click += buttAddDoctor_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label3.ForeColor = Color.Firebrick;
        label3.Location = new Point(16, 112);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(96, 28);
        label3.TabIndex = 28;
        label3.Text = "Фамилия";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.Firebrick;
        label1.Location = new Point(16, 229);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(51, 28);
        label1.TabIndex = 29;
        label1.Text = "Имя";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label4.ForeColor = Color.Firebrick;
        label4.Location = new Point(13, 338);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(234, 28);
        label4.TabIndex = 30;
        label4.Text = "Отчество (при наличии)";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label5.ForeColor = Color.Firebrick;
        label5.Location = new Point(413, 110);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(156, 28);
        label5.TabIndex = 31;
        label5.Text = "Специализация";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label6.ForeColor = Color.Firebrick;
        label6.Location = new Point(413, 229);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(147, 28);
        label6.TabIndex = 32;
        label6.Text = "Номер участка";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label7.ForeColor = Color.Firebrick;
        label7.Location = new Point(413, 338);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(163, 28);
        label7.TabIndex = 33;
        label7.Text = "Номер кабинета";
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
        // errorNoSpecial
        // 
        errorNoSpecial.ContainerControl = this;
        // 
        // checkNoCloseWindow
        // 
        checkNoCloseWindow.AutoSize = true;
        checkNoCloseWindow.ForeColor = Color.Black;
        checkNoCloseWindow.Location = new Point(262, 596);
        checkNoCloseWindow.Name = "checkNoCloseWindow";
        checkNoCloseWindow.Size = new Size(213, 32);
        checkNoCloseWindow.TabIndex = 34;
        checkNoCloseWindow.Text = "Не закрывать окно ";
        checkNoCloseWindow.UseVisualStyleBackColor = true;
        // 
        // textPhoneNumber
        // 
        textPhoneNumber.BackColor = Color.White;
        textPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPhoneNumber.Location = new Point(13, 475);
        textPhoneNumber.Margin = new Padding(4);
        textPhoneNumber.Name = "textPhoneNumber";
        textPhoneNumber.Size = new Size(315, 34);
        textPhoneNumber.TabIndex = 36;
        textPhoneNumber.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label8.ForeColor = Color.Firebrick;
        label8.Location = new Point(13, 443);
        label8.Margin = new Padding(4, 0, 4, 0);
        label8.Name = "label8";
        label8.Size = new Size(166, 28);
        label8.TabIndex = 37;
        label8.Text = "Номер телефона\r\n";
        // 
        // errorNoPhoneNumber
        // 
        errorNoPhoneNumber.ContainerControl = this;
        // 
        // textPlotNumber
        // 
        textPlotNumber.BackColor = Color.White;
        textPlotNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPlotNumber.Location = new Point(413, 282);
        textPlotNumber.Margin = new Padding(4);
        textPlotNumber.Name = "textPlotNumber";
        textPlotNumber.Size = new Size(198, 34);
        textPlotNumber.TabIndex = 38;
        textPlotNumber.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // textCabinet
        // 
        textCabinet.BackColor = Color.White;
        textCabinet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textCabinet.Location = new Point(413, 396);
        textCabinet.Margin = new Padding(4);
        textCabinet.Name = "textCabinet";
        textCabinet.Size = new Size(198, 34);
        textCabinet.TabIndex = 39;
        textCabinet.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // errorNoPlotNumber
        // 
        errorNoPlotNumber.ContainerControl = this;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
        label9.ForeColor = Color.Firebrick;
        label9.Location = new Point(1046, 24);
        label9.Name = "label9";
        label9.Size = new Size(190, 31);
        label9.TabIndex = 43;
        label9.Text = "График работы ";
        label9.TextAlign = ContentAlignment.TopCenter;
        // 
        // errorNoSchedule
        // 
        errorNoSchedule.ContainerControl = this;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.ForeColor = Color.Firebrick;
        label10.Location = new Point(923, 127);
        label10.Name = "label10";
        label10.Size = new Size(38, 28);
        label10.TabIndex = 46;
        label10.Text = "Пн";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.ForeColor = Color.Firebrick;
        label11.Location = new Point(923, 196);
        label11.Name = "label11";
        label11.Size = new Size(31, 28);
        label11.TabIndex = 47;
        label11.Text = "Вт";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.ForeColor = Color.Firebrick;
        label12.Location = new Point(923, 267);
        label12.Name = "label12";
        label12.Size = new Size(36, 28);
        label12.TabIndex = 48;
        label12.Text = "Ср";
        label12.Click += label12_Click;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.ForeColor = Color.Firebrick;
        label13.Location = new Point(927, 542);
        label13.Name = "label13";
        label13.Size = new Size(32, 28);
        label13.TabIndex = 49;
        label13.Text = "Вс";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.ForeColor = Color.Firebrick;
        label14.Location = new Point(923, 479);
        label14.Name = "label14";
        label14.Size = new Size(36, 28);
        label14.TabIndex = 50;
        label14.Text = "Сб";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.ForeColor = Color.Firebrick;
        label15.Location = new Point(923, 338);
        label15.Name = "label15";
        label15.Size = new Size(33, 28);
        label15.TabIndex = 51;
        label15.Text = "Чт";
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.ForeColor = Color.Firebrick;
        label16.Location = new Point(926, 407);
        label16.Name = "label16";
        label16.Size = new Size(34, 28);
        label16.TabIndex = 52;
        label16.Text = "Пт";
        // 
        // timeMonWorkBeginning
        // 
        timeMonWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeMonWorkBeginning.Format = DateTimePickerFormat.Time;
        timeMonWorkBeginning.Location = new Point(1011, 122);
        timeMonWorkBeginning.Name = "timeMonWorkBeginning";
        timeMonWorkBeginning.ShowUpDown = true;
        timeMonWorkBeginning.Size = new Size(115, 34);
        timeMonWorkBeginning.TabIndex = 54;
        // 
        // timeMonWorkEnd
        // 
        timeMonWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeMonWorkEnd.Format = DateTimePickerFormat.Time;
        timeMonWorkEnd.Location = new Point(1224, 121);
        timeMonWorkEnd.Name = "timeMonWorkEnd";
        timeMonWorkEnd.ShowUpDown = true;
        timeMonWorkEnd.Size = new Size(115, 34);
        timeMonWorkEnd.TabIndex = 55;
        // 
        // timeWedWorkEnd
        // 
        timeWedWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeWedWorkEnd.Format = DateTimePickerFormat.Time;
        timeWedWorkEnd.Location = new Point(1226, 267);
        timeWedWorkEnd.Name = "timeWedWorkEnd";
        timeWedWorkEnd.ShowUpDown = true;
        timeWedWorkEnd.Size = new Size(115, 34);
        timeWedWorkEnd.TabIndex = 56;
        // 
        // timeWedWorkBeginning
        // 
        timeWedWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeWedWorkBeginning.Format = DateTimePickerFormat.Time;
        timeWedWorkBeginning.Location = new Point(1011, 267);
        timeWedWorkBeginning.Name = "timeWedWorkBeginning";
        timeWedWorkBeginning.ShowUpDown = true;
        timeWedWorkBeginning.Size = new Size(115, 34);
        timeWedWorkBeginning.TabIndex = 57;
        // 
        // timeSatWorkEnd
        // 
        timeSatWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeSatWorkEnd.Format = DateTimePickerFormat.Time;
        timeSatWorkEnd.Location = new Point(1224, 473);
        timeSatWorkEnd.Name = "timeSatWorkEnd";
        timeSatWorkEnd.ShowUpDown = true;
        timeSatWorkEnd.Size = new Size(115, 34);
        timeSatWorkEnd.TabIndex = 58;
        // 
        // timeSatWorkBeginning
        // 
        timeSatWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeSatWorkBeginning.Format = DateTimePickerFormat.Time;
        timeSatWorkBeginning.Location = new Point(1011, 473);
        timeSatWorkBeginning.Name = "timeSatWorkBeginning";
        timeSatWorkBeginning.ShowUpDown = true;
        timeSatWorkBeginning.Size = new Size(115, 34);
        timeSatWorkBeginning.TabIndex = 59;
        // 
        // timeFriWorkEnd
        // 
        timeFriWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeFriWorkEnd.Format = DateTimePickerFormat.Time;
        timeFriWorkEnd.Location = new Point(1224, 402);
        timeFriWorkEnd.Name = "timeFriWorkEnd";
        timeFriWorkEnd.ShowUpDown = true;
        timeFriWorkEnd.Size = new Size(115, 34);
        timeFriWorkEnd.TabIndex = 60;
        // 
        // timeFriWorkBeginning
        // 
        timeFriWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeFriWorkBeginning.Format = DateTimePickerFormat.Time;
        timeFriWorkBeginning.Location = new Point(1011, 402);
        timeFriWorkBeginning.Name = "timeFriWorkBeginning";
        timeFriWorkBeginning.ShowUpDown = true;
        timeFriWorkBeginning.Size = new Size(115, 34);
        timeFriWorkBeginning.TabIndex = 61;
        // 
        // timeThursWorkEnd
        // 
        timeThursWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeThursWorkEnd.Format = DateTimePickerFormat.Time;
        timeThursWorkEnd.Location = new Point(1224, 338);
        timeThursWorkEnd.Name = "timeThursWorkEnd";
        timeThursWorkEnd.ShowUpDown = true;
        timeThursWorkEnd.Size = new Size(115, 34);
        timeThursWorkEnd.TabIndex = 62;
        // 
        // timeThursWorkBeginning
        // 
        timeThursWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeThursWorkBeginning.Format = DateTimePickerFormat.Time;
        timeThursWorkBeginning.Location = new Point(1011, 338);
        timeThursWorkBeginning.Name = "timeThursWorkBeginning";
        timeThursWorkBeginning.ShowUpDown = true;
        timeThursWorkBeginning.Size = new Size(115, 34);
        timeThursWorkBeginning.TabIndex = 63;
        // 
        // timeTuesWorkEnd
        // 
        timeTuesWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeTuesWorkEnd.Format = DateTimePickerFormat.Time;
        timeTuesWorkEnd.Location = new Point(1224, 196);
        timeTuesWorkEnd.Name = "timeTuesWorkEnd";
        timeTuesWorkEnd.ShowUpDown = true;
        timeTuesWorkEnd.Size = new Size(115, 34);
        timeTuesWorkEnd.TabIndex = 64;
        // 
        // timeTuesWorkBeginning
        // 
        timeTuesWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeTuesWorkBeginning.Format = DateTimePickerFormat.Time;
        timeTuesWorkBeginning.Location = new Point(1011, 196);
        timeTuesWorkBeginning.Name = "timeTuesWorkBeginning";
        timeTuesWorkBeginning.ShowUpDown = true;
        timeTuesWorkBeginning.Size = new Size(115, 34);
        timeTuesWorkBeginning.TabIndex = 65;
        // 
        // timeSunWorkBeginning
        // 
        timeSunWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeSunWorkBeginning.Format = DateTimePickerFormat.Time;
        timeSunWorkBeginning.Location = new Point(1011, 536);
        timeSunWorkBeginning.Name = "timeSunWorkBeginning";
        timeSunWorkBeginning.ShowUpDown = true;
        timeSunWorkBeginning.Size = new Size(115, 34);
        timeSunWorkBeginning.TabIndex = 66;
        // 
        // timeSunWorkEnd
        // 
        timeSunWorkEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeSunWorkEnd.Format = DateTimePickerFormat.Time;
        timeSunWorkEnd.Location = new Point(1224, 537);
        timeSunWorkEnd.Name = "timeSunWorkEnd";
        timeSunWorkEnd.ShowUpDown = true;
        timeSunWorkEnd.Size = new Size(115, 34);
        timeSunWorkEnd.TabIndex = 67;
        // 
        // checkIsWeekendMon
        // 
        checkIsWeekendMon.AutoSize = true;
        checkIsWeekendMon.Location = new Point(821, 126);
        checkIsWeekendMon.Name = "checkIsWeekendMon";
        checkIsWeekendMon.Size = new Size(72, 32);
        checkIsWeekendMon.TabIndex = 68;
        checkIsWeekendMon.Text = "Вых.";
        checkIsWeekendMon.UseVisualStyleBackColor = true;
        checkIsWeekendMon.CheckedChanged += checkIsWeekendMon_CheckedChanged;
        // 
        // checkIsWeekendSun
        // 
        checkIsWeekendSun.AutoSize = true;
        checkIsWeekendSun.Location = new Point(821, 541);
        checkIsWeekendSun.Name = "checkIsWeekendSun";
        checkIsWeekendSun.Size = new Size(72, 32);
        checkIsWeekendSun.TabIndex = 75;
        checkIsWeekendSun.Text = "Вых.";
        checkIsWeekendSun.UseVisualStyleBackColor = true;
        checkIsWeekendSun.CheckedChanged += checkIsWeekendSun_CheckedChanged;
        // 
        // checkIsWeekendSat
        // 
        checkIsWeekendSat.AutoSize = true;
        checkIsWeekendSat.Location = new Point(821, 479);
        checkIsWeekendSat.Name = "checkIsWeekendSat";
        checkIsWeekendSat.Size = new Size(72, 32);
        checkIsWeekendSat.TabIndex = 76;
        checkIsWeekendSat.Text = "Вых.";
        checkIsWeekendSat.UseVisualStyleBackColor = true;
        checkIsWeekendSat.CheckedChanged += checkIsWeekendSat_CheckedChanged;
        // 
        // checkIsWeekendFri
        // 
        checkIsWeekendFri.AutoSize = true;
        checkIsWeekendFri.Location = new Point(821, 407);
        checkIsWeekendFri.Name = "checkIsWeekendFri";
        checkIsWeekendFri.Size = new Size(72, 32);
        checkIsWeekendFri.TabIndex = 77;
        checkIsWeekendFri.Text = "Вых.";
        checkIsWeekendFri.UseVisualStyleBackColor = true;
        checkIsWeekendFri.CheckedChanged += checkIsWeekendFri_CheckedChanged;
        // 
        // checkIsWeekendThurs
        // 
        checkIsWeekendThurs.AutoSize = true;
        checkIsWeekendThurs.Location = new Point(821, 342);
        checkIsWeekendThurs.Name = "checkIsWeekendThurs";
        checkIsWeekendThurs.Size = new Size(72, 32);
        checkIsWeekendThurs.TabIndex = 78;
        checkIsWeekendThurs.Text = "Вых.";
        checkIsWeekendThurs.UseVisualStyleBackColor = true;
        checkIsWeekendThurs.CheckedChanged += checkIsWeekendThurs_CheckedChanged;
        // 
        // checkIsWeekendWed
        // 
        checkIsWeekendWed.AutoSize = true;
        checkIsWeekendWed.Location = new Point(821, 268);
        checkIsWeekendWed.Name = "checkIsWeekendWed";
        checkIsWeekendWed.Size = new Size(72, 32);
        checkIsWeekendWed.TabIndex = 79;
        checkIsWeekendWed.Text = "Вых.";
        checkIsWeekendWed.UseVisualStyleBackColor = true;
        checkIsWeekendWed.CheckedChanged += checkIsWeekendWed_CheckedChanged;
        // 
        // checkIsWeekendTues
        // 
        checkIsWeekendTues.AutoSize = true;
        checkIsWeekendTues.Location = new Point(821, 195);
        checkIsWeekendTues.Name = "checkIsWeekendTues";
        checkIsWeekendTues.Size = new Size(72, 32);
        checkIsWeekendTues.TabIndex = 80;
        checkIsWeekendTues.Text = "Вых.";
        checkIsWeekendTues.UseVisualStyleBackColor = true;
        checkIsWeekendTues.CheckedChanged += checkIsWeekendTues_CheckedChanged;
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(776, 616);
        label17.Name = "label17";
        label17.Size = new Size(329, 28);
        label17.TabIndex = 81;
        label17.Text = "Вых. - выходной (нерабочий день)";
        // 
        // timeDurationOfAppointment
        // 
        timeDurationOfAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        timeDurationOfAppointment.Format = DateTimePickerFormat.Time;
        timeDurationOfAppointment.Location = new Point(413, 502);
        timeDurationOfAppointment.Name = "timeDurationOfAppointment";
        timeDurationOfAppointment.ShowUpDown = true;
        timeDurationOfAppointment.Size = new Size(115, 34);
        timeDurationOfAppointment.TabIndex = 82;
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label18.ForeColor = Color.Firebrick;
        label18.Location = new Point(413, 456);
        label18.Margin = new Padding(4, 0, 4, 0);
        label18.Name = "label18";
        label18.Size = new Size(276, 28);
        label18.TabIndex = 83;
        label18.Text = "Продолжительность приёма";
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
        // label19
        // 
        label19.AutoSize = true;
        label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label19.ForeColor = Color.Firebrick;
        label19.Location = new Point(959, 87);
        label19.Name = "label19";
        label19.Size = new Size(184, 28);
        label19.TabIndex = 84;
        label19.Text = "Начало рабоч. дня";
        label19.TextAlign = ContentAlignment.TopCenter;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label20.ForeColor = Color.Firebrick;
        label20.Location = new Point(1182, 87);
        label20.Name = "label20";
        label20.Size = new Size(174, 28);
        label20.TabIndex = 85;
        label20.Text = "Конец рабоч. дня";
        label20.TextAlign = ContentAlignment.TopCenter;
        // 
        // AddDoctorForm
        // 
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(1399, 669);
        Controls.Add(label20);
        Controls.Add(label19);
        Controls.Add(label18);
        Controls.Add(timeDurationOfAppointment);
        Controls.Add(label17);
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
        Controls.Add(label9);
        Controls.Add(textCabinet);
        Controls.Add(textPlotNumber);
        Controls.Add(label8);
        Controls.Add(textPhoneNumber);
        Controls.Add(checkNoCloseWindow);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label1);
        Controls.Add(label3);
        Controls.Add(buttAddDoctor);
        Controls.Add(textPatr);
        Controls.Add(textName);
        Controls.Add(textSurname);
        Controls.Add(comboBoxSpecializations);
        Controls.Add(label2);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "AddDoctorForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ARM_MedRegistrar";
        ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoCabinet).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoSpecial).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPlotNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoSchedule).EndInit();
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

    private Label label2;

    public AddDoctorForm(Label label2)
    {
        label2 = label2;
    }

    private ComboBox comboBoxSpecializations;
    private TextBox textSurname;
    private TextBox textName;
    private TextBox textPatr;
    private Button buttAddDoctor;
    private Label label3;
    private Label label1;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private ErrorProvider errorNoSurname;
    private ErrorProvider errorNoName;
    private ErrorProvider errorNoCabinet;
    private ErrorProvider errorNoSpecial;
    private CheckBox checkNoCloseWindow;
    private Label label8;
    private TextBox textPhoneNumber;
    private ErrorProvider errorNoPhoneNumber;
    private ToolTip toolEnterPhoneNumb;
    private TextBox textCabinet;
    private TextBox textPlotNumber;
    private ErrorProvider errorNoPlotNumber;
    private Label label9;
    private ErrorProvider errorNoSchedule;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label16;
    private Label label15;
    private Label label14;
    private Label label13;
    private DateTimePicker timeMonWorkBeginning;
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
    private CheckBox checkIsWeekendMon;
    private CheckBox checkIsWeekendTues;
    private CheckBox checkIsWeekendWed;
    private CheckBox checkIsWeekendThurs;
    private CheckBox checkIsWeekendFri;
    private CheckBox checkIsWeekendSat;
    private CheckBox checkIsWeekendSun;
    private Label label17;
    private DateTimePicker timeDurationOfAppointment;
    private Label label18;
    private ErrorProvider errorNoDurationOfAppointment;
    private ErrorProvider errorNoCorrectTimeMon;
    private ErrorProvider errorNoCorrectTimeThurs;
    private ErrorProvider errorNoCorrectTimeFri;
    private ErrorProvider errorNoCorrectTimeSat;
    private ErrorProvider errorNoCorrectTimeSun;
    private ErrorProvider errorNoCorrectTimeWed;
    private ErrorProvider errorNoCorrectTimeTues;
    private Label label20;
    private Label label19;
}