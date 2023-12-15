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
            buttAddDoctor = new Button();
            textFullNameOfRegistr = new TextBox();
            label1 = new Label();
            listViewSchedule = new ListView();
            buttRemovePatient = new Button();
            buttRemoveDoctor = new Button();
            buttSearchPatient = new Button();
            buttSearchDoctor = new Button();
            buttAddAppointment = new Button();
            buttSearchAppointment = new Button();
            buttRemoveAppointment = new Button();
            buttAddresses = new Button();
            buttInfoAboutUser = new Button();
            SuspendLayout();
            // 
            // buttAddPatient
            // 
            buttAddPatient.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttAddPatient.ForeColor = Color.Firebrick;
            buttAddPatient.Location = new Point(1443, 135);
            buttAddPatient.Name = "buttAddPatient";
            buttAddPatient.Size = new Size(147, 65);
            buttAddPatient.TabIndex = 1;
            buttAddPatient.Text = "Добавить пациента";
            buttAddPatient.UseVisualStyleBackColor = true;
            buttAddPatient.Click += buttAddPatient_Click;
            // 
            // buttAddDoctor
            // 
            buttAddDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttAddDoctor.ForeColor = Color.Firebrick;
            buttAddDoctor.Location = new Point(1625, 135);
            buttAddDoctor.Name = "buttAddDoctor";
            buttAddDoctor.Size = new Size(147, 65);
            buttAddDoctor.TabIndex = 3;
            buttAddDoctor.Text = "Добавить врача";
            buttAddDoctor.UseVisualStyleBackColor = true;
            buttAddDoctor.Click += buttAddDoctor_Click;
            // 
            // textFullNameOfRegistr
            // 
            textFullNameOfRegistr.BackColor = Color.White;
            textFullNameOfRegistr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textFullNameOfRegistr.ForeColor = Color.Firebrick;
            textFullNameOfRegistr.Location = new Point(12, 12);
            textFullNameOfRegistr.Name = "textFullNameOfRegistr";
            textFullNameOfRegistr.ReadOnly = true;
            textFullNameOfRegistr.Size = new Size(400, 34);
            textFullNameOfRegistr.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(757, 477);
            label1.Name = "label1";
            label1.Size = new Size(185, 41);
            label1.TabIndex = 5;
            label1.Text = "Расписание";
            // 
            // listViewSchedule
            // 
            listViewSchedule.Location = new Point(80, 540);
            listViewSchedule.Name = "listViewSchedule";
            listViewSchedule.Size = new Size(1728, 423);
            listViewSchedule.Sorting = SortOrder.Ascending;
            listViewSchedule.TabIndex = 6;
            listViewSchedule.UseCompatibleStateImageBehavior = false;
            // 
            // buttRemovePatient
            // 
            buttRemovePatient.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttRemovePatient.ForeColor = Color.Firebrick;
            buttRemovePatient.Location = new Point(1472, 311);
            buttRemovePatient.Name = "buttRemovePatient";
            buttRemovePatient.Size = new Size(147, 65);
            buttRemovePatient.TabIndex = 7;
            buttRemovePatient.Text = " Удалить пациента";
            buttRemovePatient.UseVisualStyleBackColor = true;
            // 
            // buttRemoveDoctor
            // 
            buttRemoveDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttRemoveDoctor.ForeColor = Color.Firebrick;
            buttRemoveDoctor.Location = new Point(1625, 311);
            buttRemoveDoctor.Name = "buttRemoveDoctor";
            buttRemoveDoctor.Size = new Size(147, 65);
            buttRemoveDoctor.TabIndex = 8;
            buttRemoveDoctor.Text = "Удалить врача";
            buttRemoveDoctor.UseVisualStyleBackColor = true;
            // 
            // buttSearchPatient
            // 
            buttSearchPatient.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttSearchPatient.ForeColor = Color.Firebrick;
            buttSearchPatient.Location = new Point(1460, 222);
            buttSearchPatient.Name = "buttSearchPatient";
            buttSearchPatient.Size = new Size(147, 65);
            buttSearchPatient.TabIndex = 9;
            buttSearchPatient.Text = "Поиск пациента";
            buttSearchPatient.UseVisualStyleBackColor = true;
            // 
            // buttSearchDoctor
            // 
            buttSearchDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttSearchDoctor.ForeColor = Color.Firebrick;
            buttSearchDoctor.Location = new Point(1625, 222);
            buttSearchDoctor.Name = "buttSearchDoctor";
            buttSearchDoctor.Size = new Size(147, 65);
            buttSearchDoctor.TabIndex = 10;
            buttSearchDoctor.Text = "Поиск врача";
            buttSearchDoctor.UseVisualStyleBackColor = true;
            
            // 
            // buttAddAppointment
            // 
            buttAddAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttAddAppointment.ForeColor = Color.Firebrick;
            buttAddAppointment.Location = new Point(1237, 469);
            buttAddAppointment.Name = "buttAddAppointment";
            buttAddAppointment.Size = new Size(147, 65);
            buttAddAppointment.TabIndex = 11;
            buttAddAppointment.Text = "Добавить запись";
            buttAddAppointment.UseVisualStyleBackColor = true;
            // 
            // buttSearchAppointment
            // 
            buttSearchAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttSearchAppointment.ForeColor = Color.Firebrick;
            buttSearchAppointment.Location = new Point(1460, 469);
            buttSearchAppointment.Name = "buttSearchAppointment";
            buttSearchAppointment.Size = new Size(147, 65);
            buttSearchAppointment.TabIndex = 12;
            buttSearchAppointment.Text = "Поиск записи\r\n";
            buttSearchAppointment.UseVisualStyleBackColor = true;
            // 
            // buttRemoveAppointment
            // 
            buttRemoveAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttRemoveAppointment.ForeColor = Color.Firebrick;
            buttRemoveAppointment.Location = new Point(1661, 469);
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
            buttAddresses.Location = new Point(80, 483);
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
            buttInfoAboutUser.Location = new Point(12, 69);
            buttInfoAboutUser.Name = "buttInfoAboutUser";
            buttInfoAboutUser.Size = new Size(291, 37);
            buttInfoAboutUser.TabIndex = 19;
            buttInfoAboutUser.Text = "Пользователь";
            buttInfoAboutUser.UseVisualStyleBackColor = true;
            buttInfoAboutUser.Click += buttInfoAboutUser_Click;
            // 
            // MainWindowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttInfoAboutUser);
            Controls.Add(buttAddresses);
            Controls.Add(buttRemoveAppointment);
            Controls.Add(buttSearchAppointment);
            Controls.Add(buttAddAppointment);
            Controls.Add(buttSearchDoctor);
            Controls.Add(buttSearchPatient);
            Controls.Add(buttRemoveDoctor);
            Controls.Add(buttRemovePatient);
            Controls.Add(listViewSchedule);
            Controls.Add(label1);
            Controls.Add(textFullNameOfRegistr);
            Controls.Add(buttAddDoctor);
            Controls.Add(buttAddPatient);
            Name = "MainWindowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            Load += MainWindowForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttAddPatient;
        private Button buttAddDoctor;
        private TextBox textFullNameOfRegistr;
        private Label label1;
        private ListView listViewSchedule;
        private Button buttRemovePatient;
        private Button buttRemoveDoctor;
        private Button buttSearchPatient;
        private Button buttSearchDoctor;
        private Button buttAddAppointment;
        private Button buttSearchAppointment;
        private Button buttRemoveAppointment;
        private Button buttAddresses;
        private Button buttInfoAboutUser;
    }
}