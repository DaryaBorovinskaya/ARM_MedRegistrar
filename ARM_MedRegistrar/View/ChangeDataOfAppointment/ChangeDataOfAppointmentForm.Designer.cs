namespace ARM_MedRegistrar.View.ChangeDataOfAppointment
{
    partial class ChangeDataOfAppointmentForm
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
            dateTimePickerDateOfAppointment = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            label7 = new Label();
            textPlace = new TextBox();
            label6 = new Label();
            comboBoxTypeOfAppointment = new ComboBox();
            checkNoCloseWindow = new CheckBox();
            buttSaveChanges = new Button();
            buttSearch = new Button();
            textId = new TextBox();
            label2 = new Label();
            label4 = new Label();
            textPatientId = new TextBox();
            textDoctorId = new TextBox();
            label5 = new Label();
            label8 = new Label();
            textPatientFullName = new TextBox();
            textDoctorFullName = new TextBox();
            errorWrongDate = new ErrorProvider(components);
            errorNoPlace = new ErrorProvider(components);
            errorWrongDoctor = new ErrorProvider(components);
            errorNoId = new ErrorProvider(components);
            comboBoxFreeTimeOfAppointment = new ComboBox();
            textTimeOfAppointment = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorWrongDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPlace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorWrongDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoId).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerDateOfAppointment
            // 
            dateTimePickerDateOfAppointment.CustomFormat = "dd.MM.yyyy - dddd";
            dateTimePickerDateOfAppointment.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDateOfAppointment.Format = DateTimePickerFormat.Custom;
            dateTimePickerDateOfAppointment.Location = new Point(12, 147);
            dateTimePickerDateOfAppointment.Name = "dateTimePickerDateOfAppointment";
            dateTimePickerDateOfAppointment.Size = new Size(333, 39);
            dateTimePickerDateOfAppointment.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 134;
            label3.Text = "Дата приёма";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(558, 102);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 135;
            label1.Text = "Время приёма";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(452, 342);
            label7.Name = "label7";
            label7.Size = new Size(358, 32);
            label7.TabIndex = 139;
            label7.Text = "Место, где будет приём врача ";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // textPlace
            // 
            textPlace.BackColor = Color.White;
            textPlace.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPlace.Location = new Point(422, 395);
            textPlace.Multiline = true;
            textPlace.Name = "textPlace";
            textPlace.Size = new Size(411, 71);
            textPlace.TabIndex = 138;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(12, 342);
            label6.Name = "label6";
            label6.Size = new Size(138, 32);
            label6.TabIndex = 137;
            label6.Text = "Тип записи";
            // 
            // comboBoxTypeOfAppointment
            // 
            comboBoxTypeOfAppointment.BackColor = Color.White;
            comboBoxTypeOfAppointment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeOfAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTypeOfAppointment.FormattingEnabled = true;
            comboBoxTypeOfAppointment.Location = new Point(3, 395);
            comboBoxTypeOfAppointment.Name = "comboBoxTypeOfAppointment";
            comboBoxTypeOfAppointment.Size = new Size(339, 36);
            comboBoxTypeOfAppointment.TabIndex = 136;
            comboBoxTypeOfAppointment.SelectedIndexChanged += comboBoxTypeOfAppointment_SelectedIndexChanged;
            // 
            // checkNoCloseWindow
            // 
            checkNoCloseWindow.AutoSize = true;
            checkNoCloseWindow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkNoCloseWindow.Location = new Point(627, 514);
            checkNoCloseWindow.Name = "checkNoCloseWindow";
            checkNoCloseWindow.Size = new Size(206, 32);
            checkNoCloseWindow.TabIndex = 141;
            checkNoCloseWindow.Text = "не закрывать окно";
            checkNoCloseWindow.UseVisualStyleBackColor = true;
            // 
            // buttSaveChanges
            // 
            buttSaveChanges.BackColor = Color.FromArgb(255, 192, 192);
            buttSaveChanges.Enabled = false;
            buttSaveChanges.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttSaveChanges.ForeColor = Color.Firebrick;
            buttSaveChanges.Location = new Point(231, 505);
            buttSaveChanges.Margin = new Padding(4);
            buttSaveChanges.Name = "buttSaveChanges";
            buttSaveChanges.Size = new Size(369, 47);
            buttSaveChanges.TabIndex = 140;
            buttSaveChanges.Text = "Сохранить изменения";
            buttSaveChanges.UseVisualStyleBackColor = false;
            buttSaveChanges.Click += buttSaveChanges_Click;
            // 
            // buttSearch
            // 
            buttSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttSearch.Location = new Point(759, 35);
            buttSearch.Name = "buttSearch";
            buttSearch.Size = new Size(103, 43);
            buttSearch.TabIndex = 145;
            buttSearch.Text = "Найти";
            buttSearch.UseVisualStyleBackColor = true;
            buttSearch.Click += buttSearch_Click;
            // 
            // textId
            // 
            textId.BackColor = Color.White;
            textId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(608, 39);
            textId.Name = "textId";
            textId.Size = new Size(125, 34);
            textId.TabIndex = 144;
            textId.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(388, 42);
            label2.Name = "label2";
            label2.Size = new Size(182, 28);
            label2.TabIndex = 143;
            label2.Text = "Введите ID записи:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(12, 23);
            label4.Name = "label4";
            label4.Size = new Size(335, 32);
            label4.TabIndex = 142;
            label4.Text = "Изменение данных записи";
            // 
            // textPatientId
            // 
            textPatientId.BackColor = Color.White;
            textPatientId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatientId.Location = new Point(455, 258);
            textPatientId.Name = "textPatientId";
            textPatientId.ReadOnly = true;
            textPatientId.Size = new Size(55, 34);
            textPatientId.TabIndex = 146;
            // 
            // textDoctorId
            // 
            textDoctorId.BackColor = Color.White;
            textDoctorId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDoctorId.Location = new Point(12, 258);
            textDoctorId.Name = "textDoctorId";
            textDoctorId.ReadOnly = true;
            textDoctorId.Size = new Size(55, 34);
            textDoctorId.TabIndex = 147;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(12, 223);
            label5.Name = "label5";
            label5.Size = new Size(95, 32);
            label5.TabIndex = 148;
            label5.Text = "Доктор";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(452, 223);
            label8.Name = "label8";
            label8.Size = new Size(108, 32);
            label8.TabIndex = 149;
            label8.Text = "Пациент";
            // 
            // textPatientFullName
            // 
            textPatientFullName.BackColor = Color.White;
            textPatientFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatientFullName.Location = new Point(531, 258);
            textPatientFullName.Multiline = true;
            textPatientFullName.Name = "textPatientFullName";
            textPatientFullName.ReadOnly = true;
            textPatientFullName.Size = new Size(256, 56);
            textPatientFullName.TabIndex = 150;
            // 
            // textDoctorFullName
            // 
            textDoctorFullName.BackColor = Color.White;
            textDoctorFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDoctorFullName.Location = new Point(86, 258);
            textDoctorFullName.Multiline = true;
            textDoctorFullName.Name = "textDoctorFullName";
            textDoctorFullName.ReadOnly = true;
            textDoctorFullName.Size = new Size(299, 69);
            textDoctorFullName.TabIndex = 151;
            // 
            // errorWrongDate
            // 
            errorWrongDate.ContainerControl = this;
            // 
            // errorNoPlace
            // 
            errorNoPlace.ContainerControl = this;
            // 
            // errorWrongDoctor
            // 
            errorWrongDoctor.ContainerControl = this;
            // 
            // errorNoId
            // 
            errorNoId.ContainerControl = this;
            // 
            // comboBoxFreeTimeOfAppointment
            // 
            comboBoxFreeTimeOfAppointment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFreeTimeOfAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFreeTimeOfAppointment.ForeColor = Color.Firebrick;
            comboBoxFreeTimeOfAppointment.FormattingEnabled = true;
            comboBoxFreeTimeOfAppointment.Location = new Point(553, 147);
            comboBoxFreeTimeOfAppointment.Name = "comboBoxFreeTimeOfAppointment";
            comboBoxFreeTimeOfAppointment.Size = new Size(337, 36);
            comboBoxFreeTimeOfAppointment.TabIndex = 152;
            // 
            // textTimeOfAppointment
            // 
            textTimeOfAppointment.BackColor = Color.White;
            textTimeOfAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textTimeOfAppointment.Location = new Point(401, 149);
            textTimeOfAppointment.Name = "textTimeOfAppointment";
            textTimeOfAppointment.ReadOnly = true;
            textTimeOfAppointment.Size = new Size(146, 34);
            textTimeOfAppointment.TabIndex = 153;
            // 
            // ChangeDataOfAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(895, 585);
            Controls.Add(textTimeOfAppointment);
            Controls.Add(comboBoxFreeTimeOfAppointment);
            Controls.Add(textDoctorFullName);
            Controls.Add(textPatientFullName);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(textDoctorId);
            Controls.Add(textPatientId);
            Controls.Add(buttSearch);
            Controls.Add(textId);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(checkNoCloseWindow);
            Controls.Add(buttSaveChanges);
            Controls.Add(label7);
            Controls.Add(textPlace);
            Controls.Add(label6);
            Controls.Add(comboBoxTypeOfAppointment);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dateTimePickerDateOfAppointment);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChangeDataOfAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARM_MedRegistrar";
            ((System.ComponentModel.ISupportInitialize)errorWrongDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPlace).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorWrongDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerDateOfAppointment;
        private Label label3;
        private Label label1;
        private Label label7;
        private TextBox textPlace;
        private Label label6;
        private ComboBox comboBoxTypeOfAppointment;
        private CheckBox checkNoCloseWindow;
        private Button buttSaveChanges;
        private Button buttSearch;
        private TextBox textId;
        private Label label2;
        private Label label4;
        private TextBox textPatientId;
        private TextBox textDoctorId;
        private Label label5;
        private Label label8;
        private TextBox textPatientFullName;
        private TextBox textDoctorFullName;
        private ErrorProvider errorWrongDate;
        private ErrorProvider errorNoPlace;
        private ErrorProvider errorWrongDoctor;
        private ErrorProvider errorNoId;
        private ComboBox comboBoxFreeTimeOfAppointment;
        private TextBox textTimeOfAppointment;
    }
}