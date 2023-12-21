namespace ARM_MedRegistrar.View.ChangeDataOfDoctor
{
    partial class ChangeDataOfDoctorForm
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
            label6 = new Label();
            textId = new TextBox();
            buttSearch = new Button();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            textPatr = new TextBox();
            textName = new TextBox();
            textSurname = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label8 = new Label();
            comboBoxSpecializations = new ComboBox();
            label9 = new Label();
            textPhoneNumber = new TextBox();
            checkNoCloseWindow = new CheckBox();
            buttSaveChanges = new Button();
            errorNoId = new ErrorProvider(components);
            errorNoSurname = new ErrorProvider(components);
            errorNoName = new ErrorProvider(components);
            errorNoCabinet = new ErrorProvider(components);
            errorNoPhoneNumber = new ErrorProvider(components);
            errorNoSpecialization = new ErrorProvider(components);
            textCabinet = new TextBox();
            textPlotNumber = new TextBox();
            errorNoPlotNumber = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorNoId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCabinet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSpecialization).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPlotNumber).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(322, 32);
            label1.TabIndex = 2;
            label1.Text = "Изменение данных врача";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(392, 46);
            label6.Name = "label6";
            label6.Size = new Size(172, 28);
            label6.TabIndex = 102;
            label6.Text = "Введите ID врача:\r\n";
            // 
            // textId
            // 
            textId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(579, 46);
            textId.Name = "textId";
            textId.Size = new Size(125, 34);
            textId.TabIndex = 103;
            textId.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // buttSearch
            // 
            buttSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttSearch.Location = new Point(721, 42);
            buttSearch.Name = "buttSearch";
            buttSearch.Size = new Size(103, 43);
            buttSearch.TabIndex = 104;
            buttSearch.Text = "Найти";
            buttSearch.UseVisualStyleBackColor = true;
            buttSearch.Click += buttSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(25, 249);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(234, 28);
            label4.TabIndex = 110;
            label4.Text = "Отчество (при наличии)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(25, 182);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 109;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(25, 114);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 108;
            label3.Text = "Фамилия";
            // 
            // textPatr
            // 
            textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatr.Location = new Point(24, 280);
            textPatr.Name = "textPatr";
            textPatr.Size = new Size(289, 34);
            textPatr.TabIndex = 107;
            textPatr.KeyPress += textBox_SpacePress;
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(24, 210);
            textName.Name = "textName";
            textName.Size = new Size(289, 34);
            textName.TabIndex = 106;
            textName.KeyPress += textBox_SpacePress;
            // 
            // textSurname
            // 
            textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(24, 145);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(289, 34);
            textSurname.TabIndex = 105;
            textSurname.KeyPress += textBox_SpacePress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(498, 310);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 28);
            label7.TabIndex = 116;
            label7.Text = "Номер кабинета";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(498, 210);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 28);
            label5.TabIndex = 115;
            label5.Text = "Номер участка";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(498, 113);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(156, 28);
            label8.TabIndex = 114;
            label8.Text = "Специализация";
            // 
            // comboBoxSpecializations
            // 
            comboBoxSpecializations.BackColor = Color.White;
            comboBoxSpecializations.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecializations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSpecializations.ForeColor = Color.Firebrick;
            comboBoxSpecializations.FormattingEnabled = true;
            comboBoxSpecializations.Location = new Point(498, 159);
            comboBoxSpecializations.Margin = new Padding(4);
            comboBoxSpecializations.Name = "comboBoxSpecializations";
            comboBoxSpecializations.Size = new Size(252, 36);
            comboBoxSpecializations.TabIndex = 111;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(25, 328);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(166, 28);
            label9.TabIndex = 118;
            label9.Text = "Номер телефона\r\n";
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.BackColor = Color.White;
            textPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPhoneNumber.Location = new Point(24, 360);
            textPhoneNumber.Margin = new Padding(4);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(278, 34);
            textPhoneNumber.TabIndex = 117;
            textPhoneNumber.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // checkNoCloseWindow
            // 
            checkNoCloseWindow.AutoSize = true;
            checkNoCloseWindow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkNoCloseWindow.Location = new Point(580, 424);
            checkNoCloseWindow.Name = "checkNoCloseWindow";
            checkNoCloseWindow.Size = new Size(206, 32);
            checkNoCloseWindow.TabIndex = 120;
            checkNoCloseWindow.Text = "не закрывать окно";
            checkNoCloseWindow.UseVisualStyleBackColor = true;
            // 
            // buttSaveChanges
            // 
            buttSaveChanges.BackColor = Color.FromArgb(255, 192, 192);
            buttSaveChanges.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttSaveChanges.ForeColor = Color.Firebrick;
            buttSaveChanges.Location = new Point(184, 415);
            buttSaveChanges.Margin = new Padding(4);
            buttSaveChanges.Name = "buttSaveChanges";
            buttSaveChanges.Size = new Size(369, 47);
            buttSaveChanges.TabIndex = 119;
            buttSaveChanges.Text = "Сохранить изменения";
            buttSaveChanges.UseVisualStyleBackColor = false;
            buttSaveChanges.Click += buttSaveChanges_Click;
            // 
            // errorNoId
            // 
            errorNoId.ContainerControl = this;
            // 
            // errorNoSurname
            // 
            errorNoSurname.ContainerControl = this;
            // 
            // errorNoName
            // 
            errorNoName.ContainerControl = this;
            // 
            // errorNoCabinet
            // 
            errorNoCabinet.ContainerControl = this;
            // 
            // errorNoPhoneNumber
            // 
            errorNoPhoneNumber.ContainerControl = this;
            // 
            // errorNoSpecialization
            // 
            errorNoSpecialization.ContainerControl = this;
            // 
            // textCabinet
            // 
            textCabinet.BackColor = Color.White;
            textCabinet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textCabinet.Location = new Point(498, 360);
            textCabinet.Margin = new Padding(4);
            textCabinet.Name = "textCabinet";
            textCabinet.Size = new Size(198, 34);
            textCabinet.TabIndex = 123;
            textCabinet.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // textPlotNumber
            // 
            textPlotNumber.BackColor = Color.White;
            textPlotNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPlotNumber.Location = new Point(498, 258);
            textPlotNumber.Margin = new Padding(4);
            textPlotNumber.Name = "textPlotNumber";
            textPlotNumber.Size = new Size(198, 34);
            textPlotNumber.TabIndex = 122;
            textPlotNumber.KeyPress += textBox_ContainsExceptNumbers;
            // 
            // errorNoPlotNumber
            // 
            errorNoPlotNumber.ContainerControl = this;
            // 
            // ChangeDataOfDoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(863, 485);
            Controls.Add(textCabinet);
            Controls.Add(textPlotNumber);
            Controls.Add(checkNoCloseWindow);
            Controls.Add(buttSaveChanges);
            Controls.Add(label9);
            Controls.Add(textPhoneNumber);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(comboBoxSpecializations);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textPatr);
            Controls.Add(textName);
            Controls.Add(textSurname);
            Controls.Add(buttSearch);
            Controls.Add(textId);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChangeDataOfDoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeDataOfDoctorForm";
            ((System.ComponentModel.ISupportInitialize)errorNoId).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoCabinet).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSpecialization).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPlotNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private TextBox textId;
        private Button buttSearch;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox textPatr;
        private TextBox textName;
        private TextBox textSurname;
        private Label label7;
        private Label label5;
        private Label label8;
        private ComboBox comboBoxSpecializations;
        private Label label9;
        private TextBox textPhoneNumber;
        private CheckBox checkNoCloseWindow;
        private Button buttSaveChanges;
        private ErrorProvider errorNoId;
        private ErrorProvider errorNoSurname;
        private ErrorProvider errorNoName;
        private ErrorProvider errorNoCabinet;
        private ErrorProvider errorNoPhoneNumber;
        private ErrorProvider errorNoSpecialization;
        private TextBox textCabinet;
        private TextBox textPlotNumber;
        private ErrorProvider errorNoPlotNumber;
    }
}