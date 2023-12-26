namespace ARM_MedRegistrar
{
    partial class MainWindowForm
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
            buttAddPatient = new Button();
            textFullNameOfRegistr = new TextBox();
            label1 = new Label();
            listViewSchedule = new ListView();
            columnHeader20 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            buttSearchPatient = new Button();
            buttAddAppointment = new Button();
            buttRemoveAppointment = new Button();
            buttAttachedStreets = new Button();
            buttInfoAboutUser = new Button();
            listViewPatients = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            textSurname = new TextBox();
            textName = new TextBox();
            textPatr = new TextBox();
            dateTimeDateOfBirth = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label9 = new Label();
            buttDoctors = new Button();
            buttRemovePatient = new Button();
            buttAllPatients = new Button();
            buttAllDataAboutPatient = new Button();
            richTextBoxInfoAboutPatient = new RichTextBox();
            toolTipAllDataAboutPatients = new ToolTip(components);
            errorNoName = new ErrorProvider(components);
            errorNoSurname = new ErrorProvider(components);
            errorWrongDate = new ErrorProvider(components);
            toolTipRemovePatient = new ToolTip(components);
            buttChangeData = new Button();
            toolTipSaveData = new ToolTip(components);
            buttAllDataAboutAppointment = new Button();
            buttAllAppointments = new Button();
            buttSearchAppointment = new Button();
            buttPaidMedServices = new Button();
            checkIsMultiSelect = new CheckBox();
            errorMultiSelect = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorWrongDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorMultiSelect).BeginInit();
            SuspendLayout();
            // 
            // buttAddPatient
            // 
            buttAddPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAddPatient.ForeColor = Color.Firebrick;
            buttAddPatient.Location = new Point(214, 89);
            buttAddPatient.Name = "buttAddPatient";
            buttAddPatient.Size = new Size(413, 40);
            buttAddPatient.TabIndex = 1;
            buttAddPatient.Text = "Добавить пациента";
            buttAddPatient.UseVisualStyleBackColor = true;
            buttAddPatient.Click += buttAddPatient_Click;
            // 
            // textFullNameOfRegistr
            // 
            textFullNameOfRegistr.BackColor = Color.White;
            textFullNameOfRegistr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textFullNameOfRegistr.ForeColor = Color.Firebrick;
            textFullNameOfRegistr.Location = new Point(12, 12);
            textFullNameOfRegistr.Name = "textFullNameOfRegistr";
            textFullNameOfRegistr.ReadOnly = true;
            textFullNameOfRegistr.Size = new Size(322, 34);
            textFullNameOfRegistr.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(12, 627);
            label1.Name = "label1";
            label1.Size = new Size(309, 41);
            label1.TabIndex = 5;
            label1.Text = "Расписание записей";
            // 
            // listViewSchedule
            // 
            listViewSchedule.Columns.AddRange(new ColumnHeader[] { columnHeader20, columnHeader7, columnHeader22, columnHeader8, columnHeader21, columnHeader13, columnHeader9, columnHeader10, columnHeader11, columnHeader14, columnHeader16, columnHeader17, columnHeader18 });
            listViewSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listViewSchedule.Location = new Point(12, 680);
            listViewSchedule.MultiSelect = false;
            listViewSchedule.Name = "listViewSchedule";
            listViewSchedule.Size = new Size(1878, 341);
            listViewSchedule.Sorting = SortOrder.Ascending;
            listViewSchedule.TabIndex = 6;
            listViewSchedule.UseCompatibleStateImageBehavior = false;
            listViewSchedule.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "ID";
            columnHeader20.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Дата";
            columnHeader7.Width = 100;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Время";
            columnHeader22.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Место приёма";
            columnHeader8.Width = 300;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Тип записи";
            columnHeader21.Width = 150;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "ID врача";
            columnHeader13.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Фамилия врача";
            columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Имя врача";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Отчество врача";
            columnHeader11.Width = 200;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "ID пациента";
            columnHeader14.Width = 100;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Фамилия пациента";
            columnHeader16.Width = 200;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Имя пациента";
            columnHeader17.Width = 100;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Отчество пациента";
            columnHeader18.Width = 200;
            // 
            // buttSearchPatient
            // 
            buttSearchPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttSearchPatient.ForeColor = Color.Firebrick;
            buttSearchPatient.Location = new Point(1292, 189);
            buttSearchPatient.Name = "buttSearchPatient";
            buttSearchPatient.Size = new Size(186, 73);
            buttSearchPatient.TabIndex = 9;
            buttSearchPatient.Text = "Найти пациента";
            buttSearchPatient.UseVisualStyleBackColor = true;
            buttSearchPatient.Click += buttSearchPatient_Click;
            // 
            // buttAddAppointment
            // 
            buttAddAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAddAppointment.ForeColor = Color.Firebrick;
            buttAddAppointment.Location = new Point(448, 636);
            buttAddAppointment.Name = "buttAddAppointment";
            buttAddAppointment.Size = new Size(267, 37);
            buttAddAppointment.TabIndex = 11;
            buttAddAppointment.Text = "Добавить запись";
            buttAddAppointment.UseVisualStyleBackColor = true;
            buttAddAppointment.Click += buttAddAppointment_Click;
            // 
            // buttRemoveAppointment
            // 
            buttRemoveAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttRemoveAppointment.ForeColor = Color.Firebrick;
            buttRemoveAppointment.Location = new Point(1714, 637);
            buttRemoveAppointment.Name = "buttRemoveAppointment";
            buttRemoveAppointment.Size = new Size(176, 37);
            buttRemoveAppointment.TabIndex = 13;
            buttRemoveAppointment.Text = "Удалить запись\r\n";
            buttRemoveAppointment.UseVisualStyleBackColor = true;
            // 
            // buttAttachedStreets
            // 
            buttAttachedStreets.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAttachedStreets.ForeColor = Color.Firebrick;
            buttAttachedStreets.Location = new Point(1634, 51);
            buttAttachedStreets.Name = "buttAttachedStreets";
            buttAttachedStreets.Size = new Size(256, 65);
            buttAttachedStreets.TabIndex = 18;
            buttAttachedStreets.Text = "Прикреплённые улицы";
            buttAttachedStreets.UseVisualStyleBackColor = true;
            buttAttachedStreets.Click += buttAttachedStreets_Click;
            // 
            // buttInfoAboutUser
            // 
            buttInfoAboutUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttInfoAboutUser.ForeColor = Color.Firebrick;
            buttInfoAboutUser.Location = new Point(354, 12);
            buttInfoAboutUser.Name = "buttInfoAboutUser";
            buttInfoAboutUser.Size = new Size(170, 37);
            buttInfoAboutUser.TabIndex = 19;
            buttInfoAboutUser.Text = "Пользователь";
            buttInfoAboutUser.UseVisualStyleBackColor = true;
            buttInfoAboutUser.Click += buttInfoAboutUser_Click;
            // 
            // listViewPatients
            // 
            listViewPatients.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader15, columnHeader19, columnHeader5, columnHeader6 });
            listViewPatients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listViewPatients.Location = new Point(12, 284);
            listViewPatients.MultiSelect = false;
            listViewPatients.Name = "listViewPatients";
            listViewPatients.Size = new Size(1466, 262);
            listViewPatients.Sorting = SortOrder.Ascending;
            listViewPatients.TabIndex = 20;
            listViewPatients.UseCompatibleStateImageBehavior = false;
            listViewPatients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "ID";
            columnHeader12.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Фамилия";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Имя";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Отчество";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Дата рождения";
            columnHeader4.Width = 200;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Серия докум.";
            columnHeader15.Width = 140;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Номер докум.";
            columnHeader19.Width = 250;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Участок";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Амбул. карта";
            columnHeader6.Width = 200;
            // 
            // textSurname
            // 
            textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(13, 228);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(271, 34);
            textSurname.TabIndex = 21;
            textSurname.KeyPress += textBox_SpacePress;
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(318, 228);
            textName.Name = "textName";
            textName.Size = new Size(225, 34);
            textName.TabIndex = 23;
            textName.KeyPress += textBox_SpacePress;
            // 
            // textPatr
            // 
            textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatr.Location = new Point(586, 228);
            textPatr.Name = "textPatr";
            textPatr.Size = new Size(328, 34);
            textPatr.TabIndex = 24;
            textPatr.KeyPress += textBox_SpacePress;
            // 
            // dateTimeDateOfBirth
            // 
            dateTimeDateOfBirth.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeDateOfBirth.CalendarTitleBackColor = Color.White;
            dateTimeDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeDateOfBirth.Location = new Point(938, 226);
            dateTimeDateOfBirth.Name = "dateTimeDateOfBirth";
            dateTimeDateOfBirth.Size = new Size(328, 34);
            dateTimeDateOfBirth.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(938, 177);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(153, 28);
            label5.TabIndex = 37;
            label5.Text = "Дата рождения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(13, 177);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 38;
            label3.Text = "Фамилия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(318, 177);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 39;
            label4.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(586, 177);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 40;
            label6.Text = "Отчество";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(12, 89);
            label9.Name = "label9";
            label9.Size = new Size(168, 41);
            label9.TabIndex = 43;
            label9.Text = "Пациенты";
            // 
            // buttDoctors
            // 
            buttDoctors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttDoctors.ForeColor = Color.Firebrick;
            buttDoctors.Location = new Point(1175, 51);
            buttDoctors.Name = "buttDoctors";
            buttDoctors.Size = new Size(134, 65);
            buttDoctors.TabIndex = 44;
            buttDoctors.Text = "Врачи";
            buttDoctors.UseVisualStyleBackColor = true;
            buttDoctors.Click += buttDoctors_Click;
            // 
            // buttRemovePatient
            // 
            buttRemovePatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttRemovePatient.ForeColor = Color.Firebrick;
            buttRemovePatient.Location = new Point(12, 556);
            buttRemovePatient.Name = "buttRemovePatient";
            buttRemovePatient.Size = new Size(186, 36);
            buttRemovePatient.TabIndex = 45;
            buttRemovePatient.Text = "Удалить пациента";
            buttRemovePatient.UseVisualStyleBackColor = true;
            buttRemovePatient.Click += buttRemovePatient_Click;
            // 
            // buttAllPatients
            // 
            buttAllPatients.BackColor = Color.MistyRose;
            buttAllPatients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllPatients.ForeColor = Color.Firebrick;
            buttAllPatients.Location = new Point(1175, 556);
            buttAllPatients.Name = "buttAllPatients";
            buttAllPatients.Size = new Size(303, 36);
            buttAllPatients.TabIndex = 46;
            buttAllPatients.Text = "Обновить список пациентов\r\n";
            buttAllPatients.UseVisualStyleBackColor = false;
            buttAllPatients.Click += buttAllPatients_Click;
            // 
            // buttAllDataAboutPatient
            // 
            buttAllDataAboutPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllDataAboutPatient.Location = new Point(1513, 233);
            buttAllDataAboutPatient.Name = "buttAllDataAboutPatient";
            buttAllDataAboutPatient.Size = new Size(355, 45);
            buttAllDataAboutPatient.TabIndex = 47;
            buttAllDataAboutPatient.Text = "Все данные о выбранном пациенте";
            buttAllDataAboutPatient.UseVisualStyleBackColor = true;
            buttAllDataAboutPatient.Click += buttAllDataAboutPatient_Click;
            // 
            // richTextBoxInfoAboutPatient
            // 
            richTextBoxInfoAboutPatient.BackColor = SystemColors.Window;
            richTextBoxInfoAboutPatient.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxInfoAboutPatient.Location = new Point(1500, 284);
            richTextBoxInfoAboutPatient.Name = "richTextBoxInfoAboutPatient";
            richTextBoxInfoAboutPatient.ReadOnly = true;
            richTextBoxInfoAboutPatient.Size = new Size(379, 262);
            richTextBoxInfoAboutPatient.TabIndex = 48;
            richTextBoxInfoAboutPatient.Text = "";
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
            // buttChangeData
            // 
            buttChangeData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttChangeData.Location = new Point(1602, 556);
            buttChangeData.Name = "buttChangeData";
            buttChangeData.Size = new Size(277, 36);
            buttChangeData.TabIndex = 49;
            buttChangeData.Text = "Изменить данные пациента\r\n";
            buttChangeData.UseVisualStyleBackColor = true;
            buttChangeData.Click += buttChangeData_Click;
            // 
            // buttAllDataAboutAppointment
            // 
            buttAllDataAboutAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllDataAboutAppointment.ForeColor = Color.Firebrick;
            buttAllDataAboutAppointment.Location = new Point(1366, 637);
            buttAllDataAboutAppointment.Name = "buttAllDataAboutAppointment";
            buttAllDataAboutAppointment.Size = new Size(325, 37);
            buttAllDataAboutAppointment.TabIndex = 50;
            buttAllDataAboutAppointment.Text = "Все данные о выбранной записи";
            buttAllDataAboutAppointment.UseVisualStyleBackColor = true;
            // 
            // buttAllAppointments
            // 
            buttAllAppointments.BackColor = SystemColors.Window;
            buttAllAppointments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllAppointments.ForeColor = Color.Firebrick;
            buttAllAppointments.Location = new Point(760, 638);
            buttAllAppointments.Name = "buttAllAppointments";
            buttAllAppointments.Size = new Size(267, 36);
            buttAllAppointments.TabIndex = 51;
            buttAllAppointments.Text = "Обновить список записей\r\n\r\n";
            buttAllAppointments.UseVisualStyleBackColor = false;
            // 
            // buttSearchAppointment
            // 
            buttSearchAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttSearchAppointment.ForeColor = Color.Firebrick;
            buttSearchAppointment.Location = new Point(1062, 638);
            buttSearchAppointment.Name = "buttSearchAppointment";
            buttSearchAppointment.Size = new Size(267, 37);
            buttSearchAppointment.TabIndex = 52;
            buttSearchAppointment.Text = "Найти запись";
            buttSearchAppointment.UseVisualStyleBackColor = true;
            // 
            // buttPaidMedServices
            // 
            buttPaidMedServices.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttPaidMedServices.ForeColor = Color.Firebrick;
            buttPaidMedServices.Location = new Point(1353, 51);
            buttPaidMedServices.Name = "buttPaidMedServices";
            buttPaidMedServices.Size = new Size(246, 65);
            buttPaidMedServices.TabIndex = 53;
            buttPaidMedServices.Text = "Платные медицинские услуги";
            buttPaidMedServices.UseVisualStyleBackColor = true;
            buttPaidMedServices.Click += buttPaidMedServices_Click;
            // 
            // checkIsMultiSelect
            // 
            checkIsMultiSelect.AutoSize = true;
            checkIsMultiSelect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkIsMultiSelect.ForeColor = Color.Firebrick;
            checkIsMultiSelect.Location = new Point(842, 556);
            checkIsMultiSelect.Name = "checkIsMultiSelect";
            checkIsMultiSelect.Size = new Size(309, 32);
            checkIsMultiSelect.TabIndex = 54;
            checkIsMultiSelect.Text = "Выбор нескольких пациентов";
            checkIsMultiSelect.UseVisualStyleBackColor = true;
            checkIsMultiSelect.CheckedChanged += checkIsMultiSelect_CheckedChanged_1;
            // 
            // errorMultiSelect
            // 
            errorMultiSelect.ContainerControl = this;
            // 
            // MainWindowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1902, 1033);
            Controls.Add(checkIsMultiSelect);
            Controls.Add(buttPaidMedServices);
            Controls.Add(buttSearchAppointment);
            Controls.Add(buttAllAppointments);
            Controls.Add(buttAllDataAboutAppointment);
            Controls.Add(buttChangeData);
            Controls.Add(richTextBoxInfoAboutPatient);
            Controls.Add(buttAllDataAboutPatient);
            Controls.Add(buttAllPatients);
            Controls.Add(buttRemovePatient);
            Controls.Add(buttDoctors);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(dateTimeDateOfBirth);
            Controls.Add(textPatr);
            Controls.Add(textName);
            Controls.Add(textSurname);
            Controls.Add(listViewPatients);
            Controls.Add(buttInfoAboutUser);
            Controls.Add(buttAttachedStreets);
            Controls.Add(buttRemoveAppointment);
            Controls.Add(buttAddAppointment);
            Controls.Add(buttSearchPatient);
            Controls.Add(listViewSchedule);
            Controls.Add(label1);
            Controls.Add(textFullNameOfRegistr);
            Controls.Add(buttAddPatient);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainWindowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARM_MedRegistrar";
            Load += MainWindowForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorWrongDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorMultiSelect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextName_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button buttAddPatient;
        private TextBox textFullNameOfRegistr;
        private Label label1;
        private ListView listViewSchedule;
        private Button buttSearchPatient;
        private Button buttAddAppointment;
        private Button buttRemoveAppointment;
        private Button buttAttachedStreets;
        private Button buttInfoAboutUser;
        private ListView listViewPatients;
        private TextBox textSurname;
        private TextBox textName;
        private TextBox textPatr;
        private DateTimePicker dateTimeDateOfBirth;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label9;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader12;
        private Button buttDoctors;
        private Button buttRemovePatient;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Button buttAllPatients;
        private Button buttAllDataAboutPatient;
        private RichTextBox richTextBoxInfoAboutPatient;
        private ToolTip toolTipAllDataAboutPatients;
        private ErrorProvider errorNoName;
        private ErrorProvider errorNoSurname;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader19;
        private ErrorProvider errorWrongDate;
        private ToolTip toolTipRemovePatient;
        private Button buttChangeData;
        private ToolTip toolTipSaveData;
        private ColumnHeader columnHeader20;
        private Button buttAllDataAboutAppointment;
        private Button buttAllAppointments;
        private Button buttSearchAppointment;
        private Button buttPaidMedServices;
        private CheckBox checkIsMultiSelect;
        private ErrorProvider errorMultiSelect;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
    }
}