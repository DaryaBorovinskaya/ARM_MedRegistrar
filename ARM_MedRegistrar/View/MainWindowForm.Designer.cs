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
            listViewPatients = new ListView();
            listViewDoctors = new ListView();
            label2 = new Label();
            label3 = new Label();
            buttAddresses = new Button();
            SuspendLayout();
            // 
            // buttAddPatient
            // 
            buttAddPatient.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttAddPatient.ForeColor = Color.Firebrick;
            buttAddPatient.Location = new Point(743, 135);
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
            textFullNameOfRegistr.Size = new Size(317, 34);
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
            buttRemovePatient.Location = new Point(743, 311);
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
            buttSearchPatient.Location = new Point(743, 222);
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
            buttSearchDoctor.Click += buttSearchDoctor_Click;
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
            // listViewPatients
            // 
            listViewPatients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listViewPatients.Location = new Point(239, 135);
            listViewPatients.Name = "listViewPatients";
            listViewPatients.Size = new Size(488, 241);
            listViewPatients.Sorting = SortOrder.Ascending;
            listViewPatients.TabIndex = 14;
            listViewPatients.UseCompatibleStateImageBehavior = false;
            // 
            // listViewDoctors
            // 
            listViewDoctors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listViewDoctors.Location = new Point(1119, 135);
            listViewDoctors.Name = "listViewDoctors";
            listViewDoctors.Size = new Size(488, 241);
            listViewDoctors.TabIndex = 15;
            listViewDoctors.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(388, 95);
            label2.Name = "label2";
            label2.Size = new Size(193, 28);
            label2.TabIndex = 16;
            label2.Text = "Список пациентов";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(1313, 95);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 17;
            label3.Text = "Список врачей";
            // 
            // buttAddresses
            // 
            buttAddresses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttAddresses.ForeColor = Color.Firebrick;
            buttAddresses.Location = new Point(22, 58);
            buttAddresses.Name = "buttAddresses";
            buttAddresses.Size = new Size(291, 37);
            buttAddresses.TabIndex = 18;
            buttAddresses.Text = "Прикреплённые улицы";
            buttAddresses.UseVisualStyleBackColor = true;
            buttAddresses.Click += buttAddresses_Click;
            // 
            // MainWindowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttAddresses);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listViewDoctors);
            Controls.Add(listViewPatients);
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
        private ListView listViewPatients;
        private ListView listViewDoctors;
        private Label label2;
        private Label label3;
        private Button buttAddresses;
    }
}