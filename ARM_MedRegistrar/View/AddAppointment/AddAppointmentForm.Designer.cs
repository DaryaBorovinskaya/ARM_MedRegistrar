namespace ARM_MedRegistrar.View.AddAppointment
{
    partial class AddAppointmentForm
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
            listViewPatients = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            listViewDoctors = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            label2 = new Label();
            buttAllPatients = new Button();
            buttAllDoctors = new Button();
            dateTimePickerDateOfAppointment = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            comboBoxTypeOfAppointment = new ComboBox();
            label6 = new Label();
            textPlace = new TextBox();
            label7 = new Label();
            buttWorkingDoctors = new Button();
            buttShowFreeTimeOfAppointment = new Button();
            comboBoxFreeTimeOfAppointment = new ComboBox();
            toolTipShowFreeTimeOfAppointment = new ToolTip(components);
            errorNoTime = new ErrorProvider(components);
            richTextBoxInfoAboutDoctor = new RichTextBox();
            buttAllDataAboutDoctor = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dateTimeDateOfBirth = new DateTimePicker();
            textPatr = new TextBox();
            textName = new TextBox();
            textSurname = new TextBox();
            buttSearchPatient = new Button();
            errorNoName = new ErrorProvider(components);
            errorNoSurname = new ErrorProvider(components);
            errorWrongDate = new ErrorProvider(components);
            errorNoSelectedPatient = new ErrorProvider(components);
            errorWrongDoctor = new ErrorProvider(components);
            buttSaveChanges = new Button();
            errorNoPlace = new ErrorProvider(components);
            buttAddAppointment = new Button();
            richTextBoxInfoAboutPatient = new RichTextBox();
            buttAllDataAboutPatient = new Button();
            buttChange = new Button();
            checkNoCloseWindow = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)errorNoTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorWrongDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSelectedPatient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorWrongDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPlace).BeginInit();
            SuspendLayout();
            // 
            // listViewPatients
            // 
            listViewPatients.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader12 });
            listViewPatients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listViewPatients.Location = new Point(11, 375);
            listViewPatients.MultiSelect = false;
            listViewPatients.Name = "listViewPatients";
            listViewPatients.Size = new Size(591, 493);
            listViewPatients.TabIndex = 0;
            listViewPatients.UseCompatibleStateImageBehavior = false;
            listViewPatients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Фамилия";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Имя";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Отчество";
            columnHeader4.Width = 200;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Дата рождения";
            columnHeader12.Width = 150;
            // 
            // listViewDoctors
            // 
            listViewDoctors.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader10, columnHeader11, columnHeader9 });
            listViewDoctors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listViewDoctors.Location = new Point(628, 160);
            listViewDoctors.MultiSelect = false;
            listViewDoctors.Name = "listViewDoctors";
            listViewDoctors.Size = new Size(770, 493);
            listViewDoctors.TabIndex = 1;
            listViewDoctors.UseCompatibleStateImageBehavior = false;
            listViewDoctors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ID";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Фамилия";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Имя";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Отчество";
            columnHeader8.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Специализация";
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Кабинет";
            columnHeader11.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Участок";
            columnHeader9.Width = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(628, 125);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 3;
            label2.Text = "Врачи";
            // 
            // buttAllPatients
            // 
            buttAllPatients.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllPatients.ForeColor = Color.Firebrick;
            buttAllPatients.Location = new Point(11, 327);
            buttAllPatients.Name = "buttAllPatients";
            buttAllPatients.Size = new Size(206, 42);
            buttAllPatients.TabIndex = 4;
            buttAllPatients.Text = "Обновить список";
            buttAllPatients.UseVisualStyleBackColor = true;
            buttAllPatients.Click += buttAllPatients_Click;
            // 
            // buttAllDoctors
            // 
            buttAllDoctors.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllDoctors.ForeColor = Color.Firebrick;
            buttAllDoctors.Location = new Point(1180, 659);
            buttAllDoctors.Name = "buttAllDoctors";
            buttAllDoctors.Size = new Size(218, 45);
            buttAllDoctors.TabIndex = 5;
            buttAllDoctors.Text = "Обновить список";
            buttAllDoctors.UseVisualStyleBackColor = true;
            buttAllDoctors.Click += buttAllDoctors_Click;
            // 
            // dateTimePickerDateOfAppointment
            // 
            dateTimePickerDateOfAppointment.CustomFormat = "dd.MM.yyyy - dddd";
            dateTimePickerDateOfAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDateOfAppointment.Format = DateTimePickerFormat.Custom;
            dateTimePickerDateOfAppointment.Location = new Point(914, 60);
            dateTimePickerDateOfAppointment.Name = "dateTimePickerDateOfAppointment";
            dateTimePickerDateOfAppointment.Size = new Size(333, 34);
            dateTimePickerDateOfAppointment.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(999, 15);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 7;
            label3.Text = "Дата приёма";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(288, 38);
            label5.TabIndex = 10;
            label5.Text = "Добавление записи";
            // 
            // comboBoxTypeOfAppointment
            // 
            comboBoxTypeOfAppointment.BackColor = Color.White;
            comboBoxTypeOfAppointment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeOfAppointment.Enabled = false;
            comboBoxTypeOfAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTypeOfAppointment.FormattingEnabled = true;
            comboBoxTypeOfAppointment.Location = new Point(619, 743);
            comboBoxTypeOfAppointment.Name = "comboBoxTypeOfAppointment";
            comboBoxTypeOfAppointment.Size = new Size(339, 36);
            comboBoxTypeOfAppointment.TabIndex = 11;
            comboBoxTypeOfAppointment.SelectedIndexChanged += comboBoxTypeOfAppointment_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(628, 690);
            label6.Name = "label6";
            label6.Size = new Size(138, 32);
            label6.TabIndex = 12;
            label6.Text = "Тип записи";
            // 
            // textPlace
            // 
            textPlace.BackColor = Color.White;
            textPlace.Enabled = false;
            textPlace.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPlace.Location = new Point(964, 749);
            textPlace.Multiline = true;
            textPlace.Name = "textPlace";
            textPlace.Size = new Size(411, 71);
            textPlace.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(964, 712);
            label7.Name = "label7";
            label7.Size = new Size(292, 28);
            label7.TabIndex = 14;
            label7.Text = "Место, где будет приём врача ";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttWorkingDoctors
            // 
            buttWorkingDoctors.BackColor = SystemColors.Window;
            buttWorkingDoctors.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttWorkingDoctors.ForeColor = Color.Firebrick;
            buttWorkingDoctors.Location = new Point(1312, 48);
            buttWorkingDoctors.Name = "buttWorkingDoctors";
            buttWorkingDoctors.Size = new Size(387, 55);
            buttWorkingDoctors.TabIndex = 15;
            buttWorkingDoctors.Text = "Врачи, работающие в указ. дату\r\n";
            buttWorkingDoctors.UseVisualStyleBackColor = false;
            buttWorkingDoctors.Click += buttWorkingDoctors_Click;
            // 
            // buttShowFreeTimeOfAppointment
            // 
            buttShowFreeTimeOfAppointment.Enabled = false;
            buttShowFreeTimeOfAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttShowFreeTimeOfAppointment.ForeColor = Color.Firebrick;
            buttShowFreeTimeOfAppointment.Location = new Point(1473, 524);
            buttShowFreeTimeOfAppointment.Name = "buttShowFreeTimeOfAppointment";
            buttShowFreeTimeOfAppointment.Size = new Size(276, 66);
            buttShowFreeTimeOfAppointment.TabIndex = 16;
            buttShowFreeTimeOfAppointment.Text = "Показать свободные часы приёма врача";
            buttShowFreeTimeOfAppointment.UseVisualStyleBackColor = true;
            buttShowFreeTimeOfAppointment.Click += buttShowFreeTimeOfAppointment_Click;
            // 
            // comboBoxFreeTimeOfAppointment
            // 
            comboBoxFreeTimeOfAppointment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFreeTimeOfAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFreeTimeOfAppointment.ForeColor = Color.Firebrick;
            comboBoxFreeTimeOfAppointment.FormattingEnabled = true;
            comboBoxFreeTimeOfAppointment.Location = new Point(1435, 596);
            comboBoxFreeTimeOfAppointment.Name = "comboBoxFreeTimeOfAppointment";
            comboBoxFreeTimeOfAppointment.Size = new Size(337, 36);
            comboBoxFreeTimeOfAppointment.TabIndex = 17;
            comboBoxFreeTimeOfAppointment.SelectedIndexChanged += comboBoxFreeTimeOfAppointment_SelectedIndexChanged;
            // 
            // errorNoTime
            // 
            errorNoTime.ContainerControl = this;
            // 
            // richTextBoxInfoAboutDoctor
            // 
            richTextBoxInfoAboutDoctor.BackColor = SystemColors.Window;
            richTextBoxInfoAboutDoctor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxInfoAboutDoctor.Location = new Point(1415, 211);
            richTextBoxInfoAboutDoctor.Name = "richTextBoxInfoAboutDoctor";
            richTextBoxInfoAboutDoctor.ReadOnly = true;
            richTextBoxInfoAboutDoctor.Size = new Size(365, 286);
            richTextBoxInfoAboutDoctor.TabIndex = 50;
            richTextBoxInfoAboutDoctor.Text = "";
            // 
            // buttAllDataAboutDoctor
            // 
            buttAllDataAboutDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllDataAboutDoctor.Location = new Point(1425, 160);
            buttAllDataAboutDoctor.Name = "buttAllDataAboutDoctor";
            buttAllDataAboutDoctor.Size = new Size(355, 45);
            buttAllDataAboutDoctor.TabIndex = 51;
            buttAllDataAboutDoctor.Text = "Все данные о выбранном враче";
            buttAllDataAboutDoctor.UseVisualStyleBackColor = true;
            buttAllDataAboutDoctor.Click += buttAllDataAboutDoctor_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(358, 62);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(96, 28);
            label8.TabIndex = 60;
            label8.Text = "Отчество";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(206, 63);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(51, 28);
            label9.TabIndex = 59;
            label9.Text = "Имя";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(13, 62);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(96, 28);
            label10.TabIndex = 58;
            label10.Text = "Фамилия";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Firebrick;
            label11.Location = new Point(11, 130);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(153, 28);
            label11.TabIndex = 57;
            label11.Text = "Дата рождения";
            // 
            // dateTimeDateOfBirth
            // 
            dateTimeDateOfBirth.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeDateOfBirth.CalendarTitleBackColor = Color.White;
            dateTimeDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeDateOfBirth.Location = new Point(13, 160);
            dateTimeDateOfBirth.Name = "dateTimeDateOfBirth";
            dateTimeDateOfBirth.Size = new Size(204, 34);
            dateTimeDateOfBirth.TabIndex = 56;
            // 
            // textPatr
            // 
            textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatr.Location = new Point(358, 94);
            textPatr.Name = "textPatr";
            textPatr.Size = new Size(204, 34);
            textPatr.TabIndex = 55;
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(206, 94);
            textName.Name = "textName";
            textName.Size = new Size(146, 34);
            textName.TabIndex = 54;
            // 
            // textSurname
            // 
            textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(13, 93);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(187, 34);
            textSurname.TabIndex = 53;
            // 
            // buttSearchPatient
            // 
            buttSearchPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttSearchPatient.ForeColor = Color.Firebrick;
            buttSearchPatient.Location = new Point(279, 153);
            buttSearchPatient.Name = "buttSearchPatient";
            buttSearchPatient.Size = new Size(175, 41);
            buttSearchPatient.TabIndex = 52;
            buttSearchPatient.Text = "Найти пациента";
            buttSearchPatient.UseVisualStyleBackColor = true;
            buttSearchPatient.Click += buttSearchPatient_Click;
            // 
            // errorNoName
            // 
            errorNoName.ContainerControl = this;
            // 
            // errorNoSurname
            // 
            errorNoSurname.ContainerControl = this;
            // 
            // errorWrongDate
            // 
            errorWrongDate.ContainerControl = this;
            // 
            // errorNoSelectedPatient
            // 
            errorNoSelectedPatient.ContainerControl = this;
            // 
            // errorWrongDoctor
            // 
            errorWrongDoctor.ContainerControl = this;
            // 
            // buttSaveChanges
            // 
            buttSaveChanges.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttSaveChanges.Location = new Point(1125, 826);
            buttSaveChanges.Name = "buttSaveChanges";
            buttSaveChanges.Size = new Size(250, 42);
            buttSaveChanges.TabIndex = 61;
            buttSaveChanges.Text = "Сохранить изменения";
            buttSaveChanges.UseVisualStyleBackColor = true;
            buttSaveChanges.Click += buttSaveChanges_Click;
            // 
            // errorNoPlace
            // 
            errorNoPlace.ContainerControl = this;
            // 
            // buttAddAppointment
            // 
            buttAddAppointment.BackColor = Color.FromArgb(255, 192, 192);
            buttAddAppointment.Enabled = false;
            buttAddAppointment.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttAddAppointment.ForeColor = Color.Firebrick;
            buttAddAppointment.Location = new Point(1435, 785);
            buttAddAppointment.Name = "buttAddAppointment";
            buttAddAppointment.Size = new Size(345, 71);
            buttAddAppointment.TabIndex = 62;
            buttAddAppointment.Text = "Создать запись на приём";
            buttAddAppointment.UseVisualStyleBackColor = false;
            buttAddAppointment.Click += buttAddAppointment_Click;
            // 
            // richTextBoxInfoAboutPatient
            // 
            richTextBoxInfoAboutPatient.BackColor = SystemColors.Window;
            richTextBoxInfoAboutPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxInfoAboutPatient.Location = new Point(223, 217);
            richTextBoxInfoAboutPatient.Name = "richTextBoxInfoAboutPatient";
            richTextBoxInfoAboutPatient.ReadOnly = true;
            richTextBoxInfoAboutPatient.Size = new Size(379, 152);
            richTextBoxInfoAboutPatient.TabIndex = 63;
            richTextBoxInfoAboutPatient.Text = "";
            // 
            // buttAllDataAboutPatient
            // 
            buttAllDataAboutPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllDataAboutPatient.Location = new Point(13, 217);
            buttAllDataAboutPatient.Name = "buttAllDataAboutPatient";
            buttAllDataAboutPatient.Size = new Size(205, 104);
            buttAllDataAboutPatient.TabIndex = 64;
            buttAllDataAboutPatient.Text = "Все данные о выбранном пациенте";
            buttAllDataAboutPatient.UseVisualStyleBackColor = true;
            buttAllDataAboutPatient.Click += buttAllDataAboutPatient_Click;
            // 
            // buttChange
            // 
            buttChange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttChange.Location = new Point(964, 826);
            buttChange.Name = "buttChange";
            buttChange.Size = new Size(115, 42);
            buttChange.TabIndex = 65;
            buttChange.Text = "Изменить";
            buttChange.UseVisualStyleBackColor = true;
            buttChange.Click += buttChange_Click;
            // 
            // checkNoCloseWindow
            // 
            checkNoCloseWindow.AutoSize = true;
            checkNoCloseWindow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkNoCloseWindow.ForeColor = Color.Black;
            checkNoCloseWindow.Location = new Point(1516, 745);
            checkNoCloseWindow.Name = "checkNoCloseWindow";
            checkNoCloseWindow.Size = new Size(213, 32);
            checkNoCloseWindow.TabIndex = 66;
            checkNoCloseWindow.Text = "Не закрывать окно ";
            checkNoCloseWindow.UseVisualStyleBackColor = true;
            // 
            // AddAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1792, 880);
            Controls.Add(checkNoCloseWindow);
            Controls.Add(buttChange);
            Controls.Add(buttAllDataAboutPatient);
            Controls.Add(richTextBoxInfoAboutPatient);
            Controls.Add(buttAddAppointment);
            Controls.Add(buttSaveChanges);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(dateTimeDateOfBirth);
            Controls.Add(textPatr);
            Controls.Add(textName);
            Controls.Add(textSurname);
            Controls.Add(buttSearchPatient);
            Controls.Add(buttAllDataAboutDoctor);
            Controls.Add(richTextBoxInfoAboutDoctor);
            Controls.Add(comboBoxFreeTimeOfAppointment);
            Controls.Add(buttShowFreeTimeOfAppointment);
            Controls.Add(buttWorkingDoctors);
            Controls.Add(label7);
            Controls.Add(textPlace);
            Controls.Add(label6);
            Controls.Add(comboBoxTypeOfAppointment);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(dateTimePickerDateOfAppointment);
            Controls.Add(buttAllDoctors);
            Controls.Add(buttAllPatients);
            Controls.Add(label2);
            Controls.Add(listViewDoctors);
            Controls.Add(listViewPatients);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARM_MedRegistrar";
            Load += AddAppointmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorNoTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorWrongDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSelectedPatient).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorWrongDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPlace).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewPatients;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listViewDoctors;
        private Label label2;
        private Button buttAllPatients;
        private Button buttAllDoctors;
        private DateTimePicker dateTimePickerDateOfAppointment;
        private Label label3;
        private Label label5;
        private ComboBox comboBoxTypeOfAppointment;
        private Label label6;
        private TextBox textPlace;
        private Label label7;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button buttWorkingDoctors;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader11;
        private Button buttShowFreeTimeOfAppointment;
        private ComboBox comboBoxFreeTimeOfAppointment;
        private ToolTip toolTipShowFreeTimeOfAppointment;
        private ErrorProvider errorNoTime;
        private RichTextBox richTextBoxInfoAboutDoctor;
        private Button buttAllDataAboutDoctor;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimeDateOfBirth;
        private TextBox textPatr;
        private TextBox textName;
        private TextBox textSurname;
        private Button buttSearchPatient;
        private ErrorProvider errorNoName;
        private ErrorProvider errorNoSurname;
        private ErrorProvider errorWrongDate;
        private ErrorProvider errorNoSelectedPatient;
        private ErrorProvider errorWrongDoctor;
        private Button buttSaveChanges;
        private ErrorProvider errorNoPlace;
        private Button buttAddAppointment;
        private RichTextBox richTextBoxInfoAboutPatient;
        private Button buttAllDataAboutPatient;
        private Button buttChange;
        private CheckBox checkNoCloseWindow;
    }
}