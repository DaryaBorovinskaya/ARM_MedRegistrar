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
            buttAddPatient = new Button();
            textFullNameOfRegistr = new TextBox();
            label1 = new Label();
            listViewSchedule = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            buttSearchPatient = new Button();
            buttAddAppointment = new Button();
            buttRemoveAppointment = new Button();
            buttAddresses = new Button();
            buttInfoAboutUser = new Button();
            listView1 = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dateTimeDateOfBirth = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            buttDoctors = new Button();
            button1 = new Button();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
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
            textFullNameOfRegistr.TextChanged += textFullNameOfRegistr_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(760, 597);
            label1.Name = "label1";
            label1.Size = new Size(185, 41);
            label1.TabIndex = 5;
            label1.Text = "Расписание";
            // 
            // listViewSchedule
            // 
            listViewSchedule.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader13, columnHeader9, columnHeader10, columnHeader11, columnHeader14, columnHeader16, columnHeader17, columnHeader18 });
            listViewSchedule.Location = new Point(12, 652);
            listViewSchedule.Name = "listViewSchedule";
            listViewSchedule.Size = new Size(1878, 369);
            listViewSchedule.Sorting = SortOrder.Ascending;
            listViewSchedule.TabIndex = 6;
            listViewSchedule.UseCompatibleStateImageBehavior = false;
            listViewSchedule.View = System.Windows.Forms.View.Details;
            listViewSchedule.SelectedIndexChanged += listViewSchedule_SelectedIndexChanged;
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
            buttSearchPatient.Location = new Point(1196, 166);
            buttSearchPatient.Name = "buttSearchPatient";
            buttSearchPatient.Size = new Size(186, 101);
            buttSearchPatient.TabIndex = 9;
            buttSearchPatient.Text = "Найти пациента";
            buttSearchPatient.UseVisualStyleBackColor = true;
            // 
            // buttAddAppointment
            // 
            buttAddAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttAddAppointment.ForeColor = Color.Firebrick;
            buttAddAppointment.Location = new Point(1395, 581);
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
            buttRemoveAppointment.Location = new Point(1732, 581);
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
            buttAddresses.Location = new Point(12, 609);
            buttAddresses.Name = "buttAddresses";
            buttAddresses.Size = new Size(291, 37);
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
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(12, 315);
            listView1.Name = "listView1";
            listView1.Size = new Size(1466, 235);
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Отчество";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Дата рождения";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Серия докум.";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Номер докум.";
            columnHeader6.Width = 200;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 34);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 264);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(328, 34);
            textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(387, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(328, 34);
            textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(760, 196);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(375, 34);
            textBox4.TabIndex = 25;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(760, 264);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(375, 34);
            textBox5.TabIndex = 26;
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
            label3.Click += label3_Click;
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
            buttDoctors.Location = new Point(1711, 37);
            buttDoctors.Name = "buttDoctors";
            buttDoctors.Size = new Size(147, 65);
            buttDoctors.TabIndex = 44;
            buttDoctors.Text = "Врачи";
            buttDoctors.UseVisualStyleBackColor = true;
            buttDoctors.Click += buttDoctors_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Firebrick;
            button1.Location = new Point(1484, 376);
            button1.Name = "button1";
            button1.Size = new Size(186, 101);
            button1.TabIndex = 45;
            button1.Text = "Удалить пациента";
            button1.UseVisualStyleBackColor = true;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "ID врача";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "ID пациента";
            columnHeader14.Width = 100;
            // 
            // MainWindowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button1);
            Controls.Add(buttDoctors);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(dateTimeDateOfBirth);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listView1);
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
            Load += MainWindowForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private ListView listView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
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
        private Button button1;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
    }
}