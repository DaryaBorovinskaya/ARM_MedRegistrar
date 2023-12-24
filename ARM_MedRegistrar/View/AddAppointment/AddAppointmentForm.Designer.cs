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
            label1 = new Label();
            label2 = new Label();
            buttAllPatients = new Button();
            buttAllDoctors = new Button();
            dateTimePickerDateOfAppointment = new DateTimePicker();
            label3 = new Label();
            dateTimePickerTimeOfAppointment = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            comboBoxCabinetOrHome = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)errorNoTime).BeginInit();
            SuspendLayout();
            // 
            // listViewPatients
            // 
            listViewPatients.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader12 });
            listViewPatients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listViewPatients.Location = new Point(13, 160);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(13, 106);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 2;
            label1.Text = "Пациенты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(628, 106);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 3;
            label2.Text = "Врачи";
            // 
            // buttAllPatients
            // 
            buttAllPatients.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllPatients.ForeColor = Color.Firebrick;
            buttAllPatients.Location = new Point(386, 659);
            buttAllPatients.Name = "buttAllPatients";
            buttAllPatients.Size = new Size(218, 42);
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
            dateTimePickerDateOfAppointment.Location = new Point(770, 57);
            dateTimePickerDateOfAppointment.Name = "dateTimePickerDateOfAppointment";
            dateTimePickerDateOfAppointment.Size = new Size(333, 34);
            dateTimePickerDateOfAppointment.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(770, 15);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 7;
            label3.Text = "Дата приёма";
            // 
            // dateTimePickerTimeOfAppointment
            // 
            dateTimePickerTimeOfAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerTimeOfAppointment.Format = DateTimePickerFormat.Time;
            dateTimePickerTimeOfAppointment.Location = new Point(1145, 57);
            dateTimePickerTimeOfAppointment.Name = "dateTimePickerTimeOfAppointment";
            dateTimePickerTimeOfAppointment.ShowUpDown = true;
            dateTimePickerTimeOfAppointment.Size = new Size(156, 34);
            dateTimePickerTimeOfAppointment.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(1145, 9);
            label4.Name = "label4";
            label4.Size = new Size(175, 32);
            label4.TabIndex = 9;
            label4.Text = "Время приёма";
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
            // comboBoxCabinetOrHome
            // 
            comboBoxCabinetOrHome.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCabinetOrHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCabinetOrHome.FormattingEnabled = true;
            comboBoxCabinetOrHome.Location = new Point(12, 737);
            comboBoxCabinetOrHome.Name = "comboBoxCabinetOrHome";
            comboBoxCabinetOrHome.Size = new Size(339, 36);
            comboBoxCabinetOrHome.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(12, 702);
            label6.Name = "label6";
            label6.Size = new Size(138, 32);
            label6.TabIndex = 12;
            label6.Text = "Тип записи";
            // 
            // textPlace
            // 
            textPlace.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPlace.Location = new Point(476, 731);
            textPlace.Multiline = true;
            textPlace.Name = "textPlace";
            textPlace.Size = new Size(425, 58);
            textPlace.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(386, 738);
            label7.Name = "label7";
            label7.Size = new Size(84, 32);
            label7.TabIndex = 14;
            label7.Text = "Место";
            // 
            // buttWorkingDoctors
            // 
            buttWorkingDoctors.BackColor = SystemColors.Window;
            buttWorkingDoctors.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttWorkingDoctors.ForeColor = Color.Firebrick;
            buttWorkingDoctors.Location = new Point(1372, 22);
            buttWorkingDoctors.Name = "buttWorkingDoctors";
            buttWorkingDoctors.Size = new Size(346, 72);
            buttWorkingDoctors.TabIndex = 15;
            buttWorkingDoctors.Text = "Врачи, работающие в указ. дату и время";
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
            // AddAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1792, 880);
            Controls.Add(buttAllDataAboutDoctor);
            Controls.Add(richTextBoxInfoAboutDoctor);
            Controls.Add(comboBoxFreeTimeOfAppointment);
            Controls.Add(buttShowFreeTimeOfAppointment);
            Controls.Add(buttWorkingDoctors);
            Controls.Add(label7);
            Controls.Add(textPlace);
            Controls.Add(label6);
            Controls.Add(comboBoxCabinetOrHome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePickerTimeOfAppointment);
            Controls.Add(label3);
            Controls.Add(dateTimePickerDateOfAppointment);
            Controls.Add(buttAllDoctors);
            Controls.Add(buttAllPatients);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewDoctors);
            Controls.Add(listViewPatients);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAppointmentForm";
            ((System.ComponentModel.ISupportInitialize)errorNoTime).EndInit();
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
        private Label label1;
        private Label label2;
        private Button buttAllPatients;
        private Button buttAllDoctors;
        private DateTimePicker dateTimePickerDateOfAppointment;
        private Label label3;
        private DateTimePicker dateTimePickerTimeOfAppointment;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxCabinetOrHome;
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
    }
}