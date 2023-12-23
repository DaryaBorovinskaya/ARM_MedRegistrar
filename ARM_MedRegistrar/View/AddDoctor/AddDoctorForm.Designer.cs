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
        dataGridSchedule = new DataGridView();
        buttClearSchedule = new Button();
        label9 = new Label();
        errorNoSchedule = new ErrorProvider(components);
        buttShowSchedule = new Button();
        label10 = new Label();
        label11 = new Label();
        label12 = new Label();
        label13 = new Label();
        label14 = new Label();
        label15 = new Label();
        label16 = new Label();
        TimeMonWorkBeginning = new DateTimePicker();
        dateTimePicker1 = new DateTimePicker();
        dateTimePicker2 = new DateTimePicker();
        dateTimePicker3 = new DateTimePicker();
        dateTimePicker4 = new DateTimePicker();
        dateTimePicker5 = new DateTimePicker();
        dateTimePicker6 = new DateTimePicker();
        dateTimePicker7 = new DateTimePicker();
        dateTimePicker8 = new DateTimePicker();
        dateTimePicker9 = new DateTimePicker();
        dateTimePicker10 = new DateTimePicker();
        dateTimePicker11 = new DateTimePicker();
        dateTimePicker12 = new DateTimePicker();
        dateTimePicker13 = new DateTimePicker();
        ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoCabinet).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoSpecial).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPlotNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridSchedule).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoSchedule).BeginInit();
        SuspendLayout();
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.Firebrick;
        label2.Location = new Point(207, 50);
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
        // dataGridSchedule
        // 
        dataGridSchedule.BackgroundColor = Color.White;
        dataGridSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridSchedule.Location = new Point(1146, 625);
        dataGridSchedule.Name = "dataGridSchedule";
        dataGridSchedule.RowHeadersWidth = 51;
        dataGridSchedule.RowTemplate.Height = 29;
        dataGridSchedule.Size = new Size(48, 20);
        dataGridSchedule.TabIndex = 40;
        // 
        // buttClearSchedule
        // 
        buttClearSchedule.ForeColor = Color.Firebrick;
        buttClearSchedule.Location = new Point(1313, 596);
        buttClearSchedule.Name = "buttClearSchedule";
        buttClearSchedule.Size = new Size(74, 68);
        buttClearSchedule.TabIndex = 42;
        buttClearSchedule.Text = "Очистить таблицу";
        buttClearSchedule.UseVisualStyleBackColor = true;
        buttClearSchedule.Click += buttClearSchedule_Click;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        label9.ForeColor = Color.Firebrick;
        label9.Location = new Point(1067, 50);
        label9.Name = "label9";
        label9.Size = new Size(188, 32);
        label9.TabIndex = 43;
        label9.Text = "График работы ";
        label9.TextAlign = ContentAlignment.TopCenter;
        // 
        // errorNoSchedule
        // 
        errorNoSchedule.ContainerControl = this;
        // 
        // buttShowSchedule
        // 
        buttShowSchedule.ForeColor = Color.Firebrick;
        buttShowSchedule.Location = new Point(1210, 606);
        buttShowSchedule.Name = "buttShowSchedule";
        buttShowSchedule.Size = new Size(97, 51);
        buttShowSchedule.TabIndex = 45;
        buttShowSchedule.Text = "Показать таблицу";
        buttShowSchedule.UseVisualStyleBackColor = true;
        buttShowSchedule.Click += buttShowSchedule_Click;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(923, 127);
        label10.Name = "label10";
        label10.Size = new Size(38, 28);
        label10.TabIndex = 46;
        label10.Text = "Пн";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(923, 196);
        label11.Name = "label11";
        label11.Size = new Size(31, 28);
        label11.TabIndex = 47;
        label11.Text = "Вт";
        // 
        // label12
        // 
        label12.AutoSize = true;
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
        label13.Location = new Point(927, 542);
        label13.Name = "label13";
        label13.Size = new Size(32, 28);
        label13.TabIndex = 49;
        label13.Text = "Вс";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(923, 479);
        label14.Name = "label14";
        label14.Size = new Size(36, 28);
        label14.TabIndex = 50;
        label14.Text = "Сб";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(923, 338);
        label15.Name = "label15";
        label15.Size = new Size(33, 28);
        label15.TabIndex = 51;
        label15.Text = "Чт";
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(926, 407);
        label16.Name = "label16";
        label16.Size = new Size(34, 28);
        label16.TabIndex = 52;
        label16.Text = "Пт";
        // 
        // TimeMonWorkBeginning
        // 
        TimeMonWorkBeginning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        TimeMonWorkBeginning.Format = DateTimePickerFormat.Time;
        TimeMonWorkBeginning.Location = new Point(1011, 122);
        TimeMonWorkBeginning.Name = "TimeMonWorkBeginning";
        TimeMonWorkBeginning.ShowUpDown = true;
        TimeMonWorkBeginning.Size = new Size(115, 34);
        TimeMonWorkBeginning.TabIndex = 54;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker1.Format = DateTimePickerFormat.Time;
        dateTimePicker1.Location = new Point(1224, 121);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.ShowUpDown = true;
        dateTimePicker1.Size = new Size(115, 34);
        dateTimePicker1.TabIndex = 55;
        // 
        // dateTimePicker2
        // 
        dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker2.Format = DateTimePickerFormat.Time;
        dateTimePicker2.Location = new Point(1224, 267);
        dateTimePicker2.Name = "dateTimePicker2";
        dateTimePicker2.ShowUpDown = true;
        dateTimePicker2.Size = new Size(115, 34);
        dateTimePicker2.TabIndex = 56;
        // 
        // dateTimePicker3
        // 
        dateTimePicker3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker3.Format = DateTimePickerFormat.Time;
        dateTimePicker3.Location = new Point(1011, 267);
        dateTimePicker3.Name = "dateTimePicker3";
        dateTimePicker3.ShowUpDown = true;
        dateTimePicker3.Size = new Size(115, 34);
        dateTimePicker3.TabIndex = 57;
        // 
        // dateTimePicker4
        // 
        dateTimePicker4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker4.Format = DateTimePickerFormat.Time;
        dateTimePicker4.Location = new Point(1224, 473);
        dateTimePicker4.Name = "dateTimePicker4";
        dateTimePicker4.ShowUpDown = true;
        dateTimePicker4.Size = new Size(115, 34);
        dateTimePicker4.TabIndex = 58;
        // 
        // dateTimePicker5
        // 
        dateTimePicker5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker5.Format = DateTimePickerFormat.Time;
        dateTimePicker5.Location = new Point(1011, 473);
        dateTimePicker5.Name = "dateTimePicker5";
        dateTimePicker5.ShowUpDown = true;
        dateTimePicker5.Size = new Size(115, 34);
        dateTimePicker5.TabIndex = 59;
        // 
        // dateTimePicker6
        // 
        dateTimePicker6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker6.Format = DateTimePickerFormat.Time;
        dateTimePicker6.Location = new Point(1224, 402);
        dateTimePicker6.Name = "dateTimePicker6";
        dateTimePicker6.ShowUpDown = true;
        dateTimePicker6.Size = new Size(115, 34);
        dateTimePicker6.TabIndex = 60;
        // 
        // dateTimePicker7
        // 
        dateTimePicker7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker7.Format = DateTimePickerFormat.Time;
        dateTimePicker7.Location = new Point(1011, 402);
        dateTimePicker7.Name = "dateTimePicker7";
        dateTimePicker7.ShowUpDown = true;
        dateTimePicker7.Size = new Size(115, 34);
        dateTimePicker7.TabIndex = 61;
        // 
        // dateTimePicker8
        // 
        dateTimePicker8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker8.Format = DateTimePickerFormat.Time;
        dateTimePicker8.Location = new Point(1224, 332);
        dateTimePicker8.Name = "dateTimePicker8";
        dateTimePicker8.ShowUpDown = true;
        dateTimePicker8.Size = new Size(115, 34);
        dateTimePicker8.TabIndex = 62;
        // 
        // dateTimePicker9
        // 
        dateTimePicker9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker9.Format = DateTimePickerFormat.Time;
        dateTimePicker9.Location = new Point(1011, 338);
        dateTimePicker9.Name = "dateTimePicker9";
        dateTimePicker9.ShowUpDown = true;
        dateTimePicker9.Size = new Size(115, 34);
        dateTimePicker9.TabIndex = 63;
        // 
        // dateTimePicker10
        // 
        dateTimePicker10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker10.Format = DateTimePickerFormat.Time;
        dateTimePicker10.Location = new Point(1224, 190);
        dateTimePicker10.Name = "dateTimePicker10";
        dateTimePicker10.ShowUpDown = true;
        dateTimePicker10.Size = new Size(115, 34);
        dateTimePicker10.TabIndex = 64;
        // 
        // dateTimePicker11
        // 
        dateTimePicker11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker11.Format = DateTimePickerFormat.Time;
        dateTimePicker11.Location = new Point(1011, 196);
        dateTimePicker11.Name = "dateTimePicker11";
        dateTimePicker11.ShowUpDown = true;
        dateTimePicker11.Size = new Size(115, 34);
        dateTimePicker11.TabIndex = 65;
        // 
        // dateTimePicker12
        // 
        dateTimePicker12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker12.Format = DateTimePickerFormat.Time;
        dateTimePicker12.Location = new Point(1011, 536);
        dateTimePicker12.Name = "dateTimePicker12";
        dateTimePicker12.ShowUpDown = true;
        dateTimePicker12.Size = new Size(115, 34);
        dateTimePicker12.TabIndex = 66;
        // 
        // dateTimePicker13
        // 
        dateTimePicker13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimePicker13.Format = DateTimePickerFormat.Time;
        dateTimePicker13.Location = new Point(1224, 537);
        dateTimePicker13.Name = "dateTimePicker13";
        dateTimePicker13.ShowUpDown = true;
        dateTimePicker13.Size = new Size(115, 34);
        dateTimePicker13.TabIndex = 67;
        // 
        // AddDoctorForm
        // 
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(1399, 669);
        Controls.Add(dateTimePicker13);
        Controls.Add(dateTimePicker12);
        Controls.Add(dateTimePicker11);
        Controls.Add(dateTimePicker10);
        Controls.Add(dateTimePicker9);
        Controls.Add(dateTimePicker8);
        Controls.Add(dateTimePicker7);
        Controls.Add(dateTimePicker6);
        Controls.Add(dateTimePicker5);
        Controls.Add(dateTimePicker4);
        Controls.Add(dateTimePicker3);
        Controls.Add(dateTimePicker2);
        Controls.Add(dateTimePicker1);
        Controls.Add(TimeMonWorkBeginning);
        Controls.Add(label16);
        Controls.Add(label15);
        Controls.Add(label14);
        Controls.Add(label13);
        Controls.Add(label12);
        Controls.Add(label11);
        Controls.Add(label10);
        Controls.Add(buttShowSchedule);
        Controls.Add(label9);
        Controls.Add(buttClearSchedule);
        Controls.Add(dataGridSchedule);
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
        Text = "AddDoctor";
        ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoCabinet).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoSpecial).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPlotNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridSchedule).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoSchedule).EndInit();
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
    private DataGridView dataGridSchedule;
    private Button buttClearSchedule;
    private Label label9;
    private ErrorProvider errorNoSchedule;
    private Button buttShowSchedule;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label16;
    private Label label15;
    private Label label14;
    private Label label13;
    private DateTimePicker TimeMonWorkBeginning;
    private DateTimePicker dateTimePicker13;
    private DateTimePicker dateTimePicker12;
    private DateTimePicker dateTimePicker11;
    private DateTimePicker dateTimePicker10;
    private DateTimePicker dateTimePicker9;
    private DateTimePicker dateTimePicker8;
    private DateTimePicker dateTimePicker7;
    private DateTimePicker dateTimePicker6;
    private DateTimePicker dateTimePicker5;
    private DateTimePicker dateTimePicker4;
    private DateTimePicker dateTimePicker3;
    private DateTimePicker dateTimePicker2;
    private DateTimePicker dateTimePicker1;
}