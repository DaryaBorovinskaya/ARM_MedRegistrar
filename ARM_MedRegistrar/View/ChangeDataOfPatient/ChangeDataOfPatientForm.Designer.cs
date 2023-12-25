namespace ARM_MedRegistrar.View.ChangeDataOfPatient
{
    partial class ChangeDataOfPatientForm
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
            textSurname = new TextBox();
            textName = new TextBox();
            textPatr = new TextBox();
            textPhoneNumber = new TextBox();
            textDocumentSeries = new TextBox();
            textPolicyNumber = new TextBox();
            textDocumentNumber = new TextBox();
            textCity = new TextBox();
            textStreet = new TextBox();
            textRegion = new TextBox();
            textNumbOfPatientCard = new TextBox();
            textAllergies = new TextBox();
            comboBoxBloodType = new ComboBox();
            comboBoxRhFactor = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label23 = new Label();
            label19 = new Label();
            label20 = new Label();
            label18 = new Label();
            label17 = new Label();
            label5 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label15 = new Label();
            label16 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            label11 = new Label();
            buttSaveChanges = new Button();
            dateTimeDateOfBirth = new DateTimePicker();
            checkNoCloseWindow = new CheckBox();
            label6 = new Label();
            textId = new TextBox();
            errorNoId = new ErrorProvider(components);
            buttSearch = new Button();
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
            errorNoNumbOfPatientCard = new ErrorProvider(components);
            errorNoDocumentSeries = new ErrorProvider(components);
            errorNoDocumentNumber = new ErrorProvider(components);
            errorNoPlotNumber = new ErrorProvider(components);
            errorNoCity = new ErrorProvider(components);
            errorNoRegion = new ErrorProvider(components);
            errorNoPhoneNumber = new ErrorProvider(components);
            textPolicySeries = new TextBox();
            textNumbOfHouse = new TextBox();
            textNumbOfFlat = new TextBox();
            textPlotNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorNoId).BeginInit();
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
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(7, 16);
            label1.Name = "label1";
            label1.Size = new Size(364, 32);
            label1.TabIndex = 1;
            label1.Text = "Изменение данных пациента";
            // 
            // textSurname
            // 
            textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(12, 133);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(256, 34);
            textSurname.TabIndex = 2;
            textSurname.KeyPress += textBox_SpacePress;
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(12, 198);
            textName.Name = "textName";
            textName.Size = new Size(256, 34);
            textName.TabIndex = 3;
            textName.KeyPress += textBox_SpacePress;
            // 
            // textPatr
            // 
            textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatr.Location = new Point(12, 268);
            textPatr.Name = "textPatr";
            textPatr.Size = new Size(256, 34);
            textPatr.TabIndex = 4;
            textPatr.KeyPress += textBox_SpacePress;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPhoneNumber.Location = new Point(330, 200);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(256, 34);
            textPhoneNumber.TabIndex = 5;
            textPhoneNumber.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // textDocumentSeries
            // 
            textDocumentSeries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDocumentSeries.Location = new Point(12, 355);
            textDocumentSeries.Name = "textDocumentSeries";
            textDocumentSeries.Size = new Size(256, 34);
            textDocumentSeries.TabIndex = 6;
            textDocumentSeries.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // textPolicyNumber
            // 
            textPolicyNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPolicyNumber.Location = new Point(12, 585);
            textPolicyNumber.Name = "textPolicyNumber";
            textPolicyNumber.Size = new Size(256, 34);
            textPolicyNumber.TabIndex = 8;
            textPolicyNumber.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // textDocumentNumber
            // 
            textDocumentNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDocumentNumber.Location = new Point(13, 433);
            textDocumentNumber.Name = "textDocumentNumber";
            textDocumentNumber.Size = new Size(256, 34);
            textDocumentNumber.TabIndex = 10;
            textDocumentNumber.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // textCity
            // 
            textCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textCity.Location = new Point(324, 268);
            textCity.Name = "textCity";
            textCity.Size = new Size(256, 34);
            textCity.TabIndex = 11;
            textCity.KeyPress += textBox_SpacePress;
            // 
            // textStreet
            // 
            textStreet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textStreet.Location = new Point(324, 433);
            textStreet.Name = "textStreet";
            textStreet.Size = new Size(256, 34);
            textStreet.TabIndex = 13;
            textStreet.KeyPress += textBox_SpacePress;
            // 
            // textRegion
            // 
            textRegion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textRegion.Location = new Point(324, 353);
            textRegion.Name = "textRegion";
            textRegion.Size = new Size(256, 34);
            textRegion.TabIndex = 14;
            textRegion.KeyPress += textBox_SpacePress;
            // 
            // textNumbOfPatientCard
            // 
            textNumbOfPatientCard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textNumbOfPatientCard.Location = new Point(626, 198);
            textNumbOfPatientCard.Name = "textNumbOfPatientCard";
            textNumbOfPatientCard.Size = new Size(256, 34);
            textNumbOfPatientCard.TabIndex = 18;
            textNumbOfPatientCard.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // textAllergies
            // 
            textAllergies.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textAllergies.Location = new Point(626, 443);
            textAllergies.Multiline = true;
            textAllergies.Name = "textAllergies";
            textAllergies.Size = new Size(178, 138);
            textAllergies.TabIndex = 50;
            textAllergies.KeyPress += textBox_SpacePress;
            // 
            // comboBoxBloodType
            // 
            comboBoxBloodType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBloodType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxBloodType.ForeColor = Color.Firebrick;
            comboBoxBloodType.FormattingEnabled = true;
            comboBoxBloodType.Location = new Point(626, 268);
            comboBoxBloodType.Name = "comboBoxBloodType";
            comboBoxBloodType.Size = new Size(151, 36);
            comboBoxBloodType.TabIndex = 51;
            // 
            // comboBoxRhFactor
            // 
            comboBoxRhFactor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRhFactor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRhFactor.ForeColor = Color.Firebrick;
            comboBoxRhFactor.FormattingEnabled = true;
            comboBoxRhFactor.Location = new Point(626, 353);
            comboBoxRhFactor.Name = "comboBoxRhFactor";
            comboBoxRhFactor.Size = new Size(202, 36);
            comboBoxRhFactor.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(13, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 53;
            label3.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(13, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 54;
            label2.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(13, 237);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(234, 28);
            label4.TabIndex = 55;
            label4.Text = "Отчество (при наличии)";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.Firebrick;
            label23.Location = new Point(324, 167);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(166, 28);
            label23.TabIndex = 76;
            label23.Text = "Номер телефона";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Firebrick;
            label19.Location = new Point(12, 321);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(170, 28);
            label19.TabIndex = 78;
            label19.Text = "Серия документа\r\n";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Firebrick;
            label20.Location = new Point(12, 402);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(176, 28);
            label20.TabIndex = 79;
            label20.Text = "Номер документа";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Firebrick;
            label18.Location = new Point(13, 485);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(183, 28);
            label18.TabIndex = 80;
            label18.Text = "Серия мед. полиса";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Firebrick;
            label17.Location = new Point(13, 554);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(189, 28);
            label17.TabIndex = 81;
            label17.Text = "Номер мед. полиса";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(330, 102);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(153, 28);
            label5.TabIndex = 82;
            label5.Text = "Дата рождения";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Firebrick;
            label14.Location = new Point(324, 237);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(68, 28);
            label14.TabIndex = 84;
            label14.Text = "Город";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Firebrick;
            label13.Location = new Point(323, 322);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(69, 28);
            label13.TabIndex = 85;
            label13.Text = "Район";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Firebrick;
            label12.Location = new Point(324, 402);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(68, 28);
            label12.TabIndex = 86;
            label12.Text = "Улица";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Firebrick;
            label15.Location = new Point(324, 485);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(126, 28);
            label15.TabIndex = 87;
            label15.Text = "Номер дома";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Firebrick;
            label16.Location = new Point(319, 553);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(168, 28);
            label16.TabIndex = 88;
            label16.Text = "Номер квартиры";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(626, 102);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(147, 28);
            label7.TabIndex = 89;
            label7.Text = "Номер участка";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(626, 237);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(139, 28);
            label9.TabIndex = 90;
            label9.Text = "Группа крови";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(626, 321);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(135, 28);
            label10.TabIndex = 91;
            label10.Text = "Резус-фактор";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(626, 170);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(273, 28);
            label8.TabIndex = 92;
            label8.Text = "Номер амбулаторной карты";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Firebrick;
            label11.Location = new Point(626, 402);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(101, 28);
            label11.TabIndex = 93;
            label11.Text = "Аллергии";
            // 
            // buttSaveChanges
            // 
            buttSaveChanges.BackColor = Color.FromArgb(255, 192, 192);
            buttSaveChanges.Enabled = false;
            buttSaveChanges.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttSaveChanges.ForeColor = Color.Firebrick;
            buttSaveChanges.Location = new Point(297, 662);
            buttSaveChanges.Margin = new Padding(4);
            buttSaveChanges.Name = "buttSaveChanges";
            buttSaveChanges.Size = new Size(369, 47);
            buttSaveChanges.TabIndex = 94;
            buttSaveChanges.Text = "Сохранить изменения";
            buttSaveChanges.UseVisualStyleBackColor = false;
            buttSaveChanges.Click += buttSaveChanges_Click;
            // 
            // dateTimeDateOfBirth
            // 
            dateTimeDateOfBirth.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeDateOfBirth.CalendarTitleBackColor = Color.White;
            dateTimeDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeDateOfBirth.Location = new Point(330, 133);
            dateTimeDateOfBirth.Name = "dateTimeDateOfBirth";
            dateTimeDateOfBirth.Size = new Size(250, 34);
            dateTimeDateOfBirth.TabIndex = 95;
            // 
            // checkNoCloseWindow
            // 
            checkNoCloseWindow.AutoSize = true;
            checkNoCloseWindow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkNoCloseWindow.Location = new Point(693, 671);
            checkNoCloseWindow.Name = "checkNoCloseWindow";
            checkNoCloseWindow.Size = new Size(206, 32);
            checkNoCloseWindow.TabIndex = 100;
            checkNoCloseWindow.Text = "не закрывать окно";
            checkNoCloseWindow.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(402, 43);
            label6.Name = "label6";
            label6.Size = new Size(204, 28);
            label6.TabIndex = 101;
            label6.Text = "Введите ID пациента:\r\n";
            // 
            // textId
            // 
            textId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(648, 43);
            textId.Name = "textId";
            textId.Size = new Size(125, 34);
            textId.TabIndex = 102;
            textId.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // errorNoId
            // 
            errorNoId.ContainerControl = this;
            // 
            // buttSearch
            // 
            buttSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttSearch.Location = new Point(788, 39);
            buttSearch.Name = "buttSearch";
            buttSearch.Size = new Size(103, 43);
            buttSearch.TabIndex = 103;
            buttSearch.Text = "Найти";
            buttSearch.UseVisualStyleBackColor = true;
            buttSearch.Click += buttSearch_Click;
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
            // errorNoNumbOfPatientCard
            // 
            errorNoNumbOfPatientCard.ContainerControl = this;
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
            // errorNoPhoneNumber
            // 
            errorNoPhoneNumber.ContainerControl = this;
            // 
            // textPolicySeries
            // 
            textPolicySeries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPolicySeries.Location = new Point(12, 517);
            textPolicySeries.Name = "textPolicySeries";
            textPolicySeries.Size = new Size(192, 34);
            textPolicySeries.TabIndex = 104;
            textPolicySeries.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // textNumbOfHouse
            // 
            textNumbOfHouse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textNumbOfHouse.Location = new Point(325, 516);
            textNumbOfHouse.Name = "textNumbOfHouse";
            textNumbOfHouse.Size = new Size(125, 34);
            textNumbOfHouse.TabIndex = 105;
            textNumbOfHouse.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // textNumbOfFlat
            // 
            textNumbOfFlat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textNumbOfFlat.Location = new Point(323, 585);
            textNumbOfFlat.Name = "textNumbOfFlat";
            textNumbOfFlat.Size = new Size(125, 34);
            textNumbOfFlat.TabIndex = 106;
            textNumbOfFlat.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // textPlotNumber
            // 
            textPlotNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPlotNumber.Location = new Point(626, 135);
            textPlotNumber.Name = "textPlotNumber";
            textPlotNumber.Size = new Size(143, 34);
            textPlotNumber.TabIndex = 107;
            textPlotNumber.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // ChangeDataOfPatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(903, 725);
            Controls.Add(textPlotNumber);
            Controls.Add(textNumbOfFlat);
            Controls.Add(textNumbOfHouse);
            Controls.Add(textPolicySeries);
            Controls.Add(buttSearch);
            Controls.Add(textId);
            Controls.Add(label6);
            Controls.Add(checkNoCloseWindow);
            Controls.Add(dateTimeDateOfBirth);
            Controls.Add(buttSaveChanges);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label5);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label23);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboBoxRhFactor);
            Controls.Add(comboBoxBloodType);
            Controls.Add(textAllergies);
            Controls.Add(textNumbOfPatientCard);
            Controls.Add(textRegion);
            Controls.Add(textStreet);
            Controls.Add(textCity);
            Controls.Add(textDocumentNumber);
            Controls.Add(textPolicyNumber);
            Controls.Add(textDocumentSeries);
            Controls.Add(textPhoneNumber);
            Controls.Add(textPatr);
            Controls.Add(textName);
            Controls.Add(textSurname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChangeDataOfPatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARM_MedRegistrar";
            ((System.ComponentModel.ISupportInitialize)errorNoId).EndInit();
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

        #endregion

        private Label label1;
        private TextBox textSurname;
        private TextBox textName;
        private TextBox textPatr;
        private TextBox textPhoneNumber;
        private TextBox textDocumentSeries;
        private TextBox textPolicyNumber;
        private TextBox textDocumentNumber;
        private TextBox textCity;
        private TextBox textStreet;
        private TextBox textRegion;
        private TextBox textNumbOfPatientCard;
        private TextBox textAllergies;
        private ComboBox comboBoxBloodType;
        private ComboBox comboBoxRhFactor;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label23;
        private Label label19;
        private Label label20;
        private Label label18;
        private Label label17;
        private Label label5;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label15;
        private Label label16;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label11;
        private Button buttSaveChanges;
        private DateTimePicker dateTimeDateOfBirth;
        private CheckBox checkNoCloseWindow;
        private Label label6;
        private TextBox textId;
        private ErrorProvider errorNoId;
        private Button buttSearch;
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
        private ErrorProvider errorNoNumbOfPatientCard;
        private ErrorProvider errorNoDocumentSeries;
        private ErrorProvider errorNoDocumentNumber;
        private ErrorProvider errorNoPlotNumber;
        private ErrorProvider errorNoCity;
        private ErrorProvider errorNoRegion;
        private ErrorProvider errorNoPhoneNumber;
        private TextBox textPolicySeries;
        private TextBox textNumbOfHouse;
        private TextBox textNumbOfFlat;
        private TextBox textPlotNumber;
    }
}