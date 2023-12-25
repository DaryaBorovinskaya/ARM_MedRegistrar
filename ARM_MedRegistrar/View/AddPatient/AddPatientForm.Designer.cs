namespace ARM_MedRegistrar;

partial class AddPatientForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    //protected override void Dispose(bool disposing)
    //{
    //    if (disposing && (components != null))
    //    {
    //        components.Dispose();
    //    }
    //    base.Dispose(disposing);
    //}

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        label1 = new Label();
        buttAddPatient = new Button();
        label3 = new Label();
        label2 = new Label();
        label4 = new Label();
        textSurname = new TextBox();
        textName = new TextBox();
        textPatr = new TextBox();
        dateTimeDateOfBirth = new DateTimePicker();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        comboBoxBloodType = new ComboBox();
        comboBoxRhFactor = new ComboBox();
        label9 = new Label();
        label10 = new Label();
        label11 = new Label();
        textAllergies = new TextBox();
        textCity = new TextBox();
        textRegion = new TextBox();
        textStreet = new TextBox();
        label12 = new Label();
        label13 = new Label();
        label14 = new Label();
        label15 = new Label();
        label16 = new Label();
        textPolicyNumb = new TextBox();
        label17 = new Label();
        label18 = new Label();
        errorNoSurname = new ErrorProvider(components);
        errorNoName = new ErrorProvider(components);
        errorNoPolicySeries = new ErrorProvider(components);
        errorNoPolicyNumber = new ErrorProvider(components);
        errorWrongDate = new ErrorProvider(components);
        errorNoStreet = new ErrorProvider(components);
        errorNoNumbOfHouse = new ErrorProvider(components);
        errorNoNumbOfFlat = new ErrorProvider(components);
        errorNoBloodType = new ErrorProvider(components);
        errorNoRhFactor = new ErrorProvider(components);
        textNumbOfPatientCard = new TextBox();
        checkNoCloseWindow = new CheckBox();
        errorNoNumbOfPatientCard = new ErrorProvider(components);
        textDocumentSeries = new TextBox();
        textDocumentNumber = new TextBox();
        label19 = new Label();
        label20 = new Label();
        label21 = new Label();
        label22 = new Label();
        errorNoDocumentSeries = new ErrorProvider(components);
        errorNoDocumentNumber = new ErrorProvider(components);
        errorNoPlotNumber = new ErrorProvider(components);
        errorNoCity = new ErrorProvider(components);
        errorNoRegion = new ErrorProvider(components);
        textPhoneNumber = new TextBox();
        label23 = new Label();
        errorNoPhoneNumber = new ErrorProvider(components);
        textPlotNumber = new TextBox();
        textPolicySeries = new TextBox();
        textNumbOfHouse = new TextBox();
        textNumbOfFlat = new TextBox();
        ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPolicySeries).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPolicyNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorWrongDate).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoStreet).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoNumbOfHouse).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoNumbOfFlat).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoBloodType).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoRhFactor).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoNumbOfPatientCard).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoDocumentSeries).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoDocumentNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPlotNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoCity).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoRegion).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = Color.Firebrick;
        label1.Location = new Point(430, 10);
        label1.Name = "label1";
        label1.Size = new Size(315, 37);
        label1.TabIndex = 0;
        label1.Text = "Добавление пациента\r\n";
        // 
        // buttAddPatient
        // 
        buttAddPatient.BackColor = Color.FromArgb(255, 192, 192);
        buttAddPatient.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        buttAddPatient.ForeColor = Color.Firebrick;
        buttAddPatient.Location = new Point(428, 697);
        buttAddPatient.Margin = new Padding(4);
        buttAddPatient.Name = "buttAddPatient";
        buttAddPatient.Size = new Size(308, 78);
        buttAddPatient.TabIndex = 26;
        buttAddPatient.Text = "Добавить";
        buttAddPatient.UseVisualStyleBackColor = false;
        buttAddPatient.Click += buttAddPatient_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label3.ForeColor = Color.Firebrick;
        label3.Location = new Point(12, 50);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(96, 28);
        label3.TabIndex = 29;
        label3.Text = "Фамилия";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label2.ForeColor = Color.Firebrick;
        label2.Location = new Point(12, 120);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(51, 28);
        label2.TabIndex = 30;
        label2.Text = "Имя";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label4.ForeColor = Color.Firebrick;
        label4.Location = new Point(12, 190);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(234, 28);
        label4.TabIndex = 31;
        label4.Text = "Отчество (при наличии)";
        // 
        // textSurname
        // 
        textSurname.BackColor = Color.White;
        textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textSurname.Location = new Point(13, 82);
        textSurname.Margin = new Padding(4);
        textSurname.Name = "textSurname";
        textSurname.Size = new Size(400, 34);
        textSurname.TabIndex = 32;
        textSurname.KeyPress += textBox_SpacePress;
        // 
        // textName
        // 
        textName.BackColor = Color.White;
        textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textName.Location = new Point(12, 152);
        textName.Margin = new Padding(4);
        textName.Name = "textName";
        textName.Size = new Size(401, 34);
        textName.TabIndex = 33;
        textName.KeyPress += textBox_SpacePress;
        // 
        // textPatr
        // 
        textPatr.BackColor = Color.White;
        textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPatr.Location = new Point(12, 222);
        textPatr.Margin = new Padding(4);
        textPatr.Name = "textPatr";
        textPatr.Size = new Size(401, 34);
        textPatr.TabIndex = 34;
        textPatr.KeyPress += textBox_SpacePress;
        // 
        // dateTimeDateOfBirth
        // 
        dateTimeDateOfBirth.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimeDateOfBirth.CalendarTitleBackColor = Color.White;
        dateTimeDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dateTimeDateOfBirth.Location = new Point(486, 152);
        dateTimeDateOfBirth.Name = "dateTimeDateOfBirth";
        dateTimeDateOfBirth.Size = new Size(250, 34);
        dateTimeDateOfBirth.TabIndex = 35;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label5.ForeColor = Color.Firebrick;
        label5.Location = new Point(531, 107);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(153, 28);
        label5.TabIndex = 36;
        label5.Text = "Дата рождения";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
        label6.ForeColor = Color.Firebrick;
        label6.Location = new Point(895, 15);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(79, 31);
        label6.TabIndex = 37;
        label6.Text = "Адрес";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label7.ForeColor = Color.Firebrick;
        label7.Location = new Point(541, 424);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(147, 28);
        label7.TabIndex = 41;
        label7.Text = "Номер участка";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label8.ForeColor = Color.Firebrick;
        label8.Location = new Point(528, 523);
        label8.Margin = new Padding(4, 0, 4, 0);
        label8.Name = "label8";
        label8.Size = new Size(273, 28);
        label8.TabIndex = 42;
        label8.Text = "Номер амбулаторной карты";
        // 
        // comboBoxBloodType
        // 
        comboBoxBloodType.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxBloodType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        comboBoxBloodType.ForeColor = Color.Firebrick;
        comboBoxBloodType.FormattingEnabled = true;
        comboBoxBloodType.Location = new Point(721, 471);
        comboBoxBloodType.Name = "comboBoxBloodType";
        comboBoxBloodType.Size = new Size(151, 36);
        comboBoxBloodType.TabIndex = 43;
        // 
        // comboBoxRhFactor
        // 
        comboBoxRhFactor.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxRhFactor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        comboBoxRhFactor.ForeColor = Color.Firebrick;
        comboBoxRhFactor.FormattingEnabled = true;
        comboBoxRhFactor.Location = new Point(909, 472);
        comboBoxRhFactor.Name = "comboBoxRhFactor";
        comboBoxRhFactor.Size = new Size(202, 36);
        comboBoxRhFactor.TabIndex = 44;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label9.ForeColor = Color.Firebrick;
        label9.Location = new Point(721, 424);
        label9.Margin = new Padding(4, 0, 4, 0);
        label9.Name = "label9";
        label9.Size = new Size(139, 28);
        label9.TabIndex = 45;
        label9.Text = "Группа крови";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label10.ForeColor = Color.Firebrick;
        label10.Location = new Point(937, 424);
        label10.Margin = new Padding(4, 0, 4, 0);
        label10.Name = "label10";
        label10.Size = new Size(135, 28);
        label10.TabIndex = 46;
        label10.Text = "Резус-фактор";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label11.ForeColor = Color.Firebrick;
        label11.Location = new Point(895, 523);
        label11.Margin = new Padding(4, 0, 4, 0);
        label11.Name = "label11";
        label11.Size = new Size(101, 28);
        label11.TabIndex = 48;
        label11.Text = "Аллергии";
        // 
        // textAllergies
        // 
        textAllergies.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textAllergies.Location = new Point(859, 565);
        textAllergies.Multiline = true;
        textAllergies.Name = "textAllergies";
        textAllergies.Size = new Size(178, 138);
        textAllergies.TabIndex = 49;
        // 
        // textCity
        // 
        textCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textCity.Location = new Point(783, 82);
        textCity.Name = "textCity";
        textCity.Size = new Size(313, 34);
        textCity.TabIndex = 50;
        textCity.KeyPress += textBox_SpacePress;
        // 
        // textRegion
        // 
        textRegion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textRegion.Location = new Point(783, 152);
        textRegion.Name = "textRegion";
        textRegion.Size = new Size(313, 34);
        textRegion.TabIndex = 51;
        textRegion.KeyPress += textBox_SpacePress;
        // 
        // textStreet
        // 
        textStreet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textStreet.Location = new Point(783, 222);
        textStreet.Name = "textStreet";
        textStreet.Size = new Size(313, 34);
        textStreet.TabIndex = 52;
        textStreet.KeyPress += textBox_SpacePress;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label12.ForeColor = Color.Firebrick;
        label12.Location = new Point(784, 191);
        label12.Margin = new Padding(4, 0, 4, 0);
        label12.Name = "label12";
        label12.Size = new Size(68, 28);
        label12.TabIndex = 55;
        label12.Text = "Улица";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label13.ForeColor = Color.Firebrick;
        label13.Location = new Point(783, 121);
        label13.Margin = new Padding(4, 0, 4, 0);
        label13.Name = "label13";
        label13.Size = new Size(69, 28);
        label13.TabIndex = 56;
        label13.Text = "Район";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label14.ForeColor = Color.Firebrick;
        label14.Location = new Point(783, 51);
        label14.Margin = new Padding(4, 0, 4, 0);
        label14.Name = "label14";
        label14.Size = new Size(68, 28);
        label14.TabIndex = 57;
        label14.Text = "Город";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label15.ForeColor = Color.Firebrick;
        label15.Location = new Point(774, 286);
        label15.Margin = new Padding(4, 0, 4, 0);
        label15.Name = "label15";
        label15.Size = new Size(126, 28);
        label15.TabIndex = 58;
        label15.Text = "Номер дома";
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label16.ForeColor = Color.Firebrick;
        label16.Location = new Point(960, 286);
        label16.Margin = new Padding(4, 0, 4, 0);
        label16.Name = "label16";
        label16.Size = new Size(168, 28);
        label16.TabIndex = 59;
        label16.Text = "Номер квартиры";
        // 
        // textPolicyNumb
        // 
        textPolicyNumb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPolicyNumb.Location = new Point(12, 706);
        textPolicyNumb.Name = "textPolicyNumb";
        textPolicyNumb.Size = new Size(372, 34);
        textPolicyNumb.TabIndex = 61;
        textPolicyNumb.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label17.ForeColor = Color.Firebrick;
        label17.Location = new Point(13, 675);
        label17.Margin = new Padding(4, 0, 4, 0);
        label17.Name = "label17";
        label17.Size = new Size(189, 28);
        label17.TabIndex = 63;
        label17.Text = "Номер мед. полиса";
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label18.ForeColor = Color.Firebrick;
        label18.Location = new Point(12, 581);
        label18.Margin = new Padding(4, 0, 4, 0);
        label18.Name = "label18";
        label18.Size = new Size(183, 28);
        label18.TabIndex = 64;
        label18.Text = "Серия мед. полиса";
        // 
        // errorNoSurname
        // 
        errorNoSurname.ContainerControl = this;
        // 
        // errorNoName
        // 
        errorNoName.ContainerControl = this;
        // 
        // errorNoPolicySeries
        // 
        errorNoPolicySeries.ContainerControl = this;
        // 
        // errorNoPolicyNumber
        // 
        errorNoPolicyNumber.ContainerControl = this;
        // 
        // errorWrongDate
        // 
        errorWrongDate.ContainerControl = this;
        // 
        // errorNoStreet
        // 
        errorNoStreet.ContainerControl = this;
        // 
        // errorNoNumbOfHouse
        // 
        errorNoNumbOfHouse.ContainerControl = this;
        // 
        // errorNoNumbOfFlat
        // 
        errorNoNumbOfFlat.ContainerControl = this;
        // 
        // errorNoBloodType
        // 
        errorNoBloodType.ContainerControl = this;
        // 
        // errorNoRhFactor
        // 
        errorNoRhFactor.ContainerControl = this;
        // 
        // textNumbOfPatientCard
        // 
        textNumbOfPatientCard.BackColor = Color.White;
        textNumbOfPatientCard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textNumbOfPatientCard.Location = new Point(541, 575);
        textNumbOfPatientCard.Name = "textNumbOfPatientCard";
        textNumbOfPatientCard.Size = new Size(267, 34);
        textNumbOfPatientCard.TabIndex = 65;
        textNumbOfPatientCard.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // checkNoCloseWindow
        // 
        checkNoCloseWindow.AutoSize = true;
        checkNoCloseWindow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        checkNoCloseWindow.ForeColor = Color.Black;
        checkNoCloseWindow.Location = new Point(743, 722);
        checkNoCloseWindow.Name = "checkNoCloseWindow";
        checkNoCloseWindow.Size = new Size(213, 32);
        checkNoCloseWindow.TabIndex = 66;
        checkNoCloseWindow.Text = "Не закрывать окно ";
        checkNoCloseWindow.UseVisualStyleBackColor = true;
        // 
        // errorNoNumbOfPatientCard
        // 
        errorNoNumbOfPatientCard.ContainerControl = this;
        // 
        // textDocumentSeries
        // 
        textDocumentSeries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textDocumentSeries.Location = new Point(13, 415);
        textDocumentSeries.Name = "textDocumentSeries";
        textDocumentSeries.Size = new Size(372, 34);
        textDocumentSeries.TabIndex = 68;
        textDocumentSeries.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // textDocumentNumber
        // 
        textDocumentNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textDocumentNumber.Location = new Point(12, 483);
        textDocumentNumber.Name = "textDocumentNumber";
        textDocumentNumber.Size = new Size(372, 34);
        textDocumentNumber.TabIndex = 69;
        textDocumentNumber.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label19.ForeColor = Color.Firebrick;
        label19.Location = new Point(12, 384);
        label19.Margin = new Padding(4, 0, 4, 0);
        label19.Name = "label19";
        label19.Size = new Size(170, 28);
        label19.TabIndex = 70;
        label19.Text = "Серия документа";
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label20.ForeColor = Color.Firebrick;
        label20.Location = new Point(12, 452);
        label20.Margin = new Padding(4, 0, 4, 0);
        label20.Name = "label20";
        label20.Size = new Size(176, 28);
        label20.TabIndex = 71;
        label20.Text = "Номер документа";
        // 
        // label21
        // 
        label21.AutoSize = true;
        label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label21.ForeColor = Color.Firebrick;
        label21.Location = new Point(13, 324);
        label21.Margin = new Padding(4, 0, 4, 0);
        label21.Name = "label21";
        label21.Size = new Size(386, 28);
        label21.TabIndex = 72;
        label21.Text = "Документ, подтверждающий личность";
        // 
        // label22
        // 
        label22.AutoSize = true;
        label22.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label22.ForeColor = Color.Firebrick;
        label22.Location = new Point(130, 538);
        label22.Margin = new Padding(4, 0, 4, 0);
        label22.Name = "label22";
        label22.Size = new Size(122, 28);
        label22.TabIndex = 73;
        label22.Text = "Полис ОМС";
        // 
        // errorNoDocumentSeries
        // 
        errorNoDocumentSeries.ContainerControl = this;
        // 
        // errorNoDocumentNumber
        // 
        errorNoDocumentNumber.ContainerControl = this;
        // 
        // errorNoPlotNumber
        // 
        errorNoPlotNumber.ContainerControl = this;
        // 
        // errorNoCity
        // 
        errorNoCity.ContainerControl = this;
        // 
        // errorNoRegion
        // 
        errorNoRegion.ContainerControl = this;
        // 
        // textPhoneNumber
        // 
        textPhoneNumber.BackColor = Color.White;
        textPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPhoneNumber.Location = new Point(13, 286);
        textPhoneNumber.Margin = new Padding(4);
        textPhoneNumber.Name = "textPhoneNumber";
        textPhoneNumber.Size = new Size(400, 34);
        textPhoneNumber.TabIndex = 74;
        textPhoneNumber.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // label23
        // 
        label23.AutoSize = true;
        label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label23.ForeColor = Color.Firebrick;
        label23.Location = new Point(12, 260);
        label23.Margin = new Padding(4, 0, 4, 0);
        label23.Name = "label23";
        label23.Size = new Size(166, 28);
        label23.TabIndex = 75;
        label23.Text = "Номер телефона";
        // 
        // errorNoPhoneNumber
        // 
        errorNoPhoneNumber.ContainerControl = this;
        // 
        // textPlotNumber
        // 
        textPlotNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPlotNumber.Location = new Point(541, 471);
        textPlotNumber.Name = "textPlotNumber";
        textPlotNumber.Size = new Size(143, 34);
        textPlotNumber.TabIndex = 76;
        textPlotNumber.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // textPolicySeries
        // 
        textPolicySeries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textPolicySeries.Location = new Point(13, 629);
        textPolicySeries.Name = "textPolicySeries";
        textPolicySeries.Size = new Size(192, 34);
        textPolicySeries.TabIndex = 77;
        textPolicySeries.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // textNumbOfHouse
        // 
        textNumbOfHouse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textNumbOfHouse.Location = new Point(783, 333);
        textNumbOfHouse.Name = "textNumbOfHouse";
        textNumbOfHouse.Size = new Size(125, 34);
        textNumbOfHouse.TabIndex = 78;
        textNumbOfHouse.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // textNumbOfFlat
        // 
        textNumbOfFlat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textNumbOfFlat.Location = new Point(971, 333);
        textNumbOfFlat.Name = "textNumbOfFlat";
        textNumbOfFlat.Size = new Size(125, 34);
        textNumbOfFlat.TabIndex = 79;
        textNumbOfFlat.KeyPress += textBox_ContainsExceptNumbers;
        // 
        // AddPatientForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(1132, 788);
        Controls.Add(textNumbOfFlat);
        Controls.Add(textNumbOfHouse);
        Controls.Add(textPolicySeries);
        Controls.Add(textPlotNumber);
        Controls.Add(label23);
        Controls.Add(textPhoneNumber);
        Controls.Add(label22);
        Controls.Add(label21);
        Controls.Add(label20);
        Controls.Add(label19);
        Controls.Add(textDocumentNumber);
        Controls.Add(textDocumentSeries);
        Controls.Add(checkNoCloseWindow);
        Controls.Add(textNumbOfPatientCard);
        Controls.Add(label18);
        Controls.Add(label17);
        Controls.Add(textPolicyNumb);
        Controls.Add(label16);
        Controls.Add(label15);
        Controls.Add(label14);
        Controls.Add(label13);
        Controls.Add(label12);
        Controls.Add(textStreet);
        Controls.Add(textRegion);
        Controls.Add(textCity);
        Controls.Add(textAllergies);
        Controls.Add(label11);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(comboBoxRhFactor);
        Controls.Add(comboBoxBloodType);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(dateTimeDateOfBirth);
        Controls.Add(textPatr);
        Controls.Add(textName);
        Controls.Add(textSurname);
        Controls.Add(label4);
        Controls.Add(label2);
        Controls.Add(label3);
        Controls.Add(buttAddPatient);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "AddPatientForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ARM_MedRegistrar";
        ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPolicySeries).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPolicyNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorWrongDate).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoStreet).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoNumbOfHouse).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoNumbOfFlat).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoBloodType).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoRhFactor).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoNumbOfPatientCard).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoDocumentSeries).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoDocumentNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPlotNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoCity).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoRegion).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private void TextDocumentNumber_KeyPress(object sender, KeyPressEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void TextDocumentSeries_KeyPress(object sender, KeyPressEventArgs e)
    {
        throw new NotImplementedException();
    }



    #endregion

    private Label label1;
    private Button buttAddPatient;
    private Label label3;
    private Label label2;
    private Label label4;
    private TextBox textSurname;
    private TextBox textName;
    private TextBox textPatr;
    private DateTimePicker dateTimeDateOfBirth;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private ComboBox comboBoxBloodType;
    private ComboBox comboBoxRhFactor;
    private Label label9;
    private Label label10;
    private Label label11;
    private TextBox textAllergies;
    private TextBox textCity;
    private TextBox textRegion;
    private TextBox textStreet;
    private NumericUpDown numericNumbOfHouse;
    private NumericUpDown numericNumbOfFlat;
    private Label label12;
    private Label label13;
    private Label label14;
    private Label label15;
    private Label label16;
    private TextBox textPolicyNumb;
    private NumericUpDown numeric;
    private Label label17;
    private Label label18;
    private ErrorProvider errorNoSurname;
    private ErrorProvider errorNoName;
    private ErrorProvider errorNoPolicySeries;
    private ErrorProvider errorNoPolicyNumber;
    private ErrorProvider errorWrongDate;
    private ErrorProvider errorNoStreet;
    private ErrorProvider errorNoNumbOfHouse;
    private ErrorProvider errorNoNumbOfFlat;
    private ErrorProvider errorNoBloodType;
    private ErrorProvider errorNoRhFactor;
    private TextBox textNumbOfPatientCard;
    private CheckBox checkNoCloseWindow;
    private ErrorProvider errorNoNumbOfPatientCard;
    private Label label21;
    private Label label20;
    private Label label19;
    private TextBox textDocumentNumber;
    private TextBox textDocumentSeries;
    private Label label22;
    private ErrorProvider errorNoDocumentSeries;
    private ErrorProvider errorNoDocumentNumber;
    private ErrorProvider errorNoPlotNumber;
    private ErrorProvider errorNoCity;
    private ErrorProvider errorNoRegion;
    private Label label23;
    private TextBox textPhoneNumber;
    private ErrorProvider errorNoPhoneNumber;
    private TextBox textBox4;
    private TextBox textNumbOfHouse;
    private TextBox textPolicySeries;
    private TextBox textPlotNumber;
    private TextBox textNumbOfFlat;
}