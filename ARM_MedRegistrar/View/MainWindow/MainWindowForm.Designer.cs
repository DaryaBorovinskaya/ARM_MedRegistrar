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
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
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
            buttAddresses = new Button();
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
            textDocumentSeries = new TextBox();
            textDocumentNumber = new TextBox();
            dateTimeDateOfBirth = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            buttDoctors = new Button();
            buttRemovePatient = new Button();
            buttAllPatients = new Button();
            buttAllDataAboutPatient = new Button();
            richTextBoxInfoAboutPatient = new RichTextBox();
            toolTipAllDataAboutPatients = new ToolTip(components);
            errorNoName = new ErrorProvider(components);
            errorNoSurname = new ErrorProvider(components);
            errorNoDocumentSeries = new ErrorProvider(components);
            errorNoDocumentNumber = new ErrorProvider(components);
            errorWrongDate = new ErrorProvider(components);
            toolTipRemovePatient = new ToolTip(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoDocumentSeries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoDocumentNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorWrongDate).BeginInit();
            SuspendLayout();
            // 
            // buttAddPatient
            // 
            buttAddPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAddPatient.ForeColor = Color.Firebrick;
            buttAddPatient.Location = new Point(215, 79);
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
            label1.Location = new Point(760, 623);
            label1.Name = "label1";
            label1.Size = new Size(309, 41);
            label1.TabIndex = 5;
            label1.Text = "Расписание записей";
            // 
            // listViewSchedule
            // 
            listViewSchedule.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader13, columnHeader9, columnHeader10, columnHeader11, columnHeader14, columnHeader16, columnHeader17, columnHeader18 });
            listViewSchedule.Location = new Point(12, 686);
            listViewSchedule.Name = "listViewSchedule";
            listViewSchedule.Size = new Size(1878, 328);
            listViewSchedule.Sorting = SortOrder.Ascending;
            listViewSchedule.TabIndex = 6;
            listViewSchedule.UseCompatibleStateImageBehavior = false;
            listViewSchedule.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Дата и время";
            columnHeader7.Width = 250;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Номер кабинета или адрес";
            columnHeader8.Width = 300;
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
            buttSearchPatient.Location = new Point(1196, 196);
            buttSearchPatient.Name = "buttSearchPatient";
            buttSearchPatient.Size = new Size(186, 101);
            buttSearchPatient.TabIndex = 9;
            buttSearchPatient.Text = "Найти пациента";
            buttSearchPatient.UseVisualStyleBackColor = true;
            buttSearchPatient.Click += buttSearchPatient_Click;
            // 
            // buttAddAppointment
            // 
            buttAddAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttAddAppointment.ForeColor = Color.Firebrick;
            buttAddAppointment.Location = new Point(1590, 615);
            buttAddAppointment.Name = "buttAddAppointment";
            buttAddAppointment.Size = new Size(147, 65);
            buttAddAppointment.TabIndex = 11;
            buttAddAppointment.Text = "Добавить запись";
            buttAddAppointment.UseVisualStyleBackColor = true;
            // 
            // buttRemoveAppointment
            // 
            buttRemoveAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttRemoveAppointment.ForeColor = Color.Firebrick;
            buttRemoveAppointment.Location = new Point(1743, 615);
            buttRemoveAppointment.Name = "buttRemoveAppointment";
            buttRemoveAppointment.Size = new Size(147, 65);
            buttRemoveAppointment.TabIndex = 13;
            buttRemoveAppointment.Text = "Удалить запись\r\n";
            buttRemoveAppointment.UseVisualStyleBackColor = true;
            // 
            // buttAddresses
            // 
            buttAddresses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttAddresses.ForeColor = Color.Firebrick;
            buttAddresses.Location = new Point(1237, 643);
            buttAddresses.Name = "buttAddresses";
            buttAddresses.Size = new Size(300, 37);
            buttAddresses.TabIndex = 18;
            buttAddresses.Text = "Прикреплённые улицы";
            buttAddresses.UseVisualStyleBackColor = true;
            buttAddresses.Click += buttAddresses_Click;
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
            listViewPatients.Location = new Point(12, 315);
            listViewPatients.MultiSelect = false;
            listViewPatients.Name = "listViewPatients";
            listViewPatients.Size = new Size(1466, 235);
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
            textSurname.Location = new Point(12, 196);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(328, 34);
            textSurname.TabIndex = 21;
            textSurname.KeyPress += textBox_SpacePress;
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(12, 264);
            textName.Name = "textName";
            textName.Size = new Size(328, 34);
            textName.TabIndex = 23;
            textName.KeyPress += textBox_SpacePress;
            // 
            // textPatr
            // 
            textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatr.Location = new Point(387, 196);
            textPatr.Name = "textPatr";
            textPatr.Size = new Size(328, 34);
            textPatr.TabIndex = 24;
            textPatr.KeyPress += textBox_SpacePress;
            // 
            // textDocumentSeries
            // 
            textDocumentSeries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDocumentSeries.Location = new Point(760, 196);
            textDocumentSeries.Name = "textDocumentSeries";
            textDocumentSeries.Size = new Size(375, 34);
            textDocumentSeries.TabIndex = 25;
            textDocumentSeries.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // textDocumentNumber
            // 
            textDocumentNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDocumentNumber.Location = new Point(760, 264);
            textDocumentNumber.Name = "textDocumentNumber";
            textDocumentNumber.Size = new Size(375, 34);
            textDocumentNumber.TabIndex = 26;
            textDocumentNumber.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // dateTimeDateOfBirth
            // 
            dateTimeDateOfBirth.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeDateOfBirth.CalendarTitleBackColor = Color.White;
            dateTimeDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeDateOfBirth.Location = new Point(387, 265);
            dateTimeDateOfBirth.Name = "dateTimeDateOfBirth";
            dateTimeDateOfBirth.Size = new Size(328, 34);
            dateTimeDateOfBirth.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(387, 233);
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
            label3.Location = new Point(12, 165);
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
            label4.Location = new Point(12, 233);
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
            label6.Location = new Point(387, 165);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 40;
            label6.Text = "Отчество";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(760, 166);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(375, 28);
            label7.TabIndex = 41;
            label7.Text = "Серия документа, подтвержд. личность";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(760, 233);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(381, 28);
            label8.TabIndex = 42;
            label8.Text = "Номер документа, подтвержд. личность";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(12, 75);
            label9.Name = "label9";
            label9.Size = new Size(168, 41);
            label9.TabIndex = 43;
            label9.Text = "Пациенты";
            // 
            // buttDoctors
            // 
            buttDoctors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttDoctors.ForeColor = Color.Firebrick;
            buttDoctors.Location = new Point(1573, 51);
            buttDoctors.Name = "buttDoctors";
            buttDoctors.Size = new Size(266, 65);
            buttDoctors.TabIndex = 44;
            buttDoctors.Text = "Врачи";
            buttDoctors.UseVisualStyleBackColor = true;
            buttDoctors.Click += buttDoctors_Click;
            // 
            // buttRemovePatient
            // 
            buttRemovePatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttRemovePatient.ForeColor = Color.Firebrick;
            buttRemovePatient.Location = new Point(12, 558);
            buttRemovePatient.Name = "buttRemovePatient";
            buttRemovePatient.Size = new Size(186, 45);
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
            buttAllDataAboutPatient.Location = new Point(1513, 264);
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
            richTextBoxInfoAboutPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxInfoAboutPatient.Location = new Point(1500, 315);
            richTextBoxInfoAboutPatient.Name = "richTextBoxInfoAboutPatient";
            richTextBoxInfoAboutPatient.ReadOnly = true;
            richTextBoxInfoAboutPatient.Size = new Size(379, 235);
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
            // errorNoDocumentSeries
            // 
            errorNoDocumentSeries.ContainerControl = this;
            // 
            // errorNoDocumentNumber
            // 
            errorNoDocumentNumber.ContainerControl = this;
            // 
            // errorWrongDate
            // 
            errorWrongDate.ContainerControl = this;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1590, 556);
            button1.Name = "button1";
            button1.Size = new Size(289, 36);
            button1.TabIndex = 49;
            button1.Text = "Сохранить изменения";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainWindowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button1);
            Controls.Add(richTextBoxInfoAboutPatient);
            Controls.Add(buttAllDataAboutPatient);
            Controls.Add(buttAllPatients);
            Controls.Add(buttRemovePatient);
            Controls.Add(buttDoctors);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(dateTimeDateOfBirth);
            Controls.Add(textDocumentNumber);
            Controls.Add(textDocumentSeries);
            Controls.Add(textPatr);
            Controls.Add(textName);
            Controls.Add(textSurname);
            Controls.Add(listViewPatients);
            Controls.Add(buttInfoAboutUser);
            Controls.Add(buttAddresses);
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
            Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoDocumentSeries).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoDocumentNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorWrongDate).EndInit();
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
        private Button buttAddresses;
        private Button buttInfoAboutUser;
        private ListView listViewPatients;
        private TextBox textSurname;
        private TextBox textName;
        private TextBox textPatr;
        private TextBox textDocumentSeries;
        private TextBox textDocumentNumber;
        private DateTimePicker dateTimeDateOfBirth;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
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
        private ErrorProvider errorNoDocumentSeries;
        private ErrorProvider errorNoDocumentNumber;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader19;
        private ErrorProvider errorWrongDate;
        private ToolTip toolTipRemovePatient;
        private Button button1;
    }
}