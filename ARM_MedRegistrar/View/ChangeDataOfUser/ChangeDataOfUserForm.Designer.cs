using System.Diagnostics;

namespace ARM_MedRegistrar
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    partial class ChangeDataOfUserForm
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
            labelName = new Label();
            labelLog = new Label();
            labelPassword = new Label();
            textOldLog = new TextBox();
            textOldPassword = new TextBox();
            buttChangeData = new Button();
            textPatr = new TextBox();
            textName = new TextBox();
            textSurname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorNoOldLog = new ErrorProvider(components);
            errorNoOldPassword = new ErrorProvider(components);
            errorNoPost = new ErrorProvider(components);
            errorNoSurname = new ErrorProvider(components);
            errorNoName = new ErrorProvider(components);
            label4 = new Label();
            checkViewOldPassword = new CheckBox();
            textNewLog = new TextBox();
            textNewPassword = new TextBox();
            checkViewNewPassword = new CheckBox();
            errorNoNewLog = new ErrorProvider(components);
            errorNoNewPassword = new ErrorProvider(components);
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxPost = new ComboBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorNoOldLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoOldPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNewLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNewPassword).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Underline, GraphicsUnit.Point);
            labelName.ForeColor = Color.Firebrick;
            labelName.Location = new Point(12, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(398, 32);
            labelName.TabIndex = 7;
            labelName.Text = "Смена данных пользователя";
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLog.ForeColor = Color.Firebrick;
            labelLog.Location = new Point(93, 134);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(140, 28);
            labelLog.TabIndex = 8;
            labelLog.Text = "Старый логин\r\n";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.Firebrick;
            labelPassword.Location = new Point(96, 243);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(152, 28);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Старый пароль\r\n";
            // 
            // textOldLog
            // 
            textOldLog.BackColor = Color.White;
            textOldLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textOldLog.Location = new Point(11, 179);
            textOldLog.Name = "textOldLog";
            textOldLog.Size = new Size(329, 34);
            textOldLog.TabIndex = 10;
            textOldLog.KeyPress += textBox_SpacePress;
            // 
            // textOldPassword
            // 
            textOldPassword.BackColor = Color.White;
            textOldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textOldPassword.Location = new Point(11, 282);
            textOldPassword.Name = "textOldPassword";
            textOldPassword.Size = new Size(329, 34);
            textOldPassword.TabIndex = 11;
            textOldPassword.UseSystemPasswordChar = true;
            textOldPassword.KeyPress += textBox_SpacePress;
            // 
            // buttChangeData
            // 
            buttChangeData.BackColor = Color.FromArgb(255, 192, 192);
            buttChangeData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttChangeData.ForeColor = Color.Firebrick;
            buttChangeData.Location = new Point(84, 545);
            buttChangeData.Name = "buttChangeData";
            buttChangeData.Size = new Size(214, 76);
            buttChangeData.TabIndex = 14;
            buttChangeData.Text = "Обновить данные";
            buttChangeData.UseVisualStyleBackColor = false;
            buttChangeData.Click += buttChangeData_Click;
            // 
            // textPatr
            // 
            textPatr.BackColor = Color.White;
            textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatr.Location = new Point(526, 295);
            textPatr.Name = "textPatr";
            textPatr.Size = new Size(329, 34);
            textPatr.TabIndex = 17;
            textPatr.KeyPress += textBox_SpacePress;
            // 
            // textName
            // 
            textName.BackColor = Color.White;
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(928, 179);
            textName.Name = "textName";
            textName.Size = new Size(329, 34);
            textName.TabIndex = 18;
            textName.KeyPress += textBox_SpacePress;
            // 
            // textSurname
            // 
            textSurname.BackColor = Color.White;
            textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(526, 179);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(329, 34);
            textSurname.TabIndex = 19;
            textSurname.KeyPress += textBox_SpacePress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(584, 243);
            label1.Name = "label1";
            label1.Size = new Size(234, 28);
            label1.TabIndex = 20;
            label1.Text = "Отчество (при наличии)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(1072, 134);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 21;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(639, 134);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 22;
            label3.Text = "Фамилия";
            // 
            // errorNoOldLog
            // 
            errorNoOldLog.ContainerControl = this;
            // 
            // errorNoOldPassword
            // 
            errorNoOldPassword.ContainerControl = this;
            // 
            // errorNoPost
            // 
            errorNoPost.ContainerControl = this;
            // 
            // errorNoSurname
            // 
            errorNoSurname.ContainerControl = this;
            // 
            // errorNoName
            // 
            errorNoName.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(409, 112);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 24;
            label4.Click += label4_Click;
            // 
            // checkViewOldPassword
            // 
            checkViewOldPassword.AutoSize = true;
            checkViewOldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkViewOldPassword.ForeColor = Color.Firebrick;
            checkViewOldPassword.Location = new Point(84, 347);
            checkViewOldPassword.Name = "checkViewOldPassword";
            checkViewOldPassword.Size = new Size(189, 32);
            checkViewOldPassword.TabIndex = 26;
            checkViewOldPassword.Text = "Показать пароль";
            checkViewOldPassword.UseVisualStyleBackColor = true;
            checkViewOldPassword.CheckedChanged += checkViewOldPassword_CheckedChanged_1;
            // 
            // textNewLog
            // 
            textNewLog.BackColor = Color.White;
            textNewLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textNewLog.Location = new Point(723, 422);
            textNewLog.Name = "textNewLog";
            textNewLog.Size = new Size(329, 34);
            textNewLog.TabIndex = 27;
            textNewLog.KeyPress += textBox_SpacePress;
            // 
            // textNewPassword
            // 
            textNewPassword.BackColor = Color.White;
            textNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textNewPassword.Location = new Point(723, 534);
            textNewPassword.Name = "textNewPassword";
            textNewPassword.Size = new Size(329, 34);
            textNewPassword.TabIndex = 28;
            textNewPassword.UseSystemPasswordChar = true;
            textNewPassword.TextChanged += textNewPassword_TextChanged;
            textNewPassword.KeyPress += textBox_SpacePress;
            // 
            // checkViewNewPassword
            // 
            checkViewNewPassword.AutoSize = true;
            checkViewNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkViewNewPassword.ForeColor = Color.Firebrick;
            checkViewNewPassword.Location = new Point(798, 599);
            checkViewNewPassword.Name = "checkViewNewPassword";
            checkViewNewPassword.Size = new Size(189, 32);
            checkViewNewPassword.TabIndex = 31;
            checkViewNewPassword.Text = "Показать пароль";
            checkViewNewPassword.UseVisualStyleBackColor = true;
            checkViewNewPassword.CheckedChanged += checkViewNewPassword_CheckedChanged;
            // 
            // errorNoNewLog
            // 
            errorNoNewLog.ContainerControl = this;
            // 
            // errorNoNewPassword
            // 
            errorNoNewPassword.ContainerControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(84, 86);
            label7.Name = "label7";
            label7.Size = new Size(182, 27);
            label7.TabIndex = 32;
            label7.Text = "СТАРЫЕ ДАННЫЕ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(815, 86);
            label8.Name = "label8";
            label8.Size = new Size(172, 27);
            label8.TabIndex = 33;
            label8.Text = "НОВЫЕ ДАННЫЕ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(815, 369);
            label5.Name = "label5";
            label5.Size = new Size(135, 28);
            label5.TabIndex = 34;
            label5.Text = "Новый логин";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(815, 484);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 35;
            label6.Text = "Новый пароль";
            // 
            // comboBoxPost
            // 
            comboBoxPost.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPost.ForeColor = Color.Firebrick;
            comboBoxPost.FormattingEnabled = true;
            comboBoxPost.Location = new Point(928, 295);
            comboBoxPost.Name = "comboBoxPost";
            comboBoxPost.Size = new Size(329, 36);
            comboBoxPost.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(1045, 243);
            label9.Name = "label9";
            label9.Size = new Size(115, 28);
            label9.TabIndex = 37;
            label9.Text = "Должность";
            // 
            // ChangeDataOfUserForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1269, 695);
            Controls.Add(label9);
            Controls.Add(comboBoxPost);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(checkViewNewPassword);
            Controls.Add(textNewPassword);
            Controls.Add(textNewLog);
            Controls.Add(checkViewOldPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSurname);
            Controls.Add(textName);
            Controls.Add(textPatr);
            Controls.Add(buttChangeData);
            Controls.Add(textOldPassword);
            Controls.Add(textOldLog);
            Controls.Add(labelPassword);
            Controls.Add(labelLog);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChangeDataOfUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARM_MedRegistrar";
            Load += Registration_Load_1;
            ((System.ComponentModel.ISupportInitialize)errorNoOldLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoOldPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPost).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNewLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNewPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        #endregion

        private Label labelName;
        private Label labelLog;
        private Label labelPassword;
        private TextBox textOldLog;
        private TextBox textOldPassword;
        private Button buttChangeData;
        private TextBox textPatr;
        private TextBox textName;
        private TextBox textSurname;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorNoOldLog;
        private ErrorProvider errorNoOldPassword;
        private ErrorProvider errorNoPost;
        private ErrorProvider errorNoSurname;
        private ErrorProvider errorNoName;
        private Label label4;
        private CheckBox checkViewOldPassword;
        private TextBox textNewPassword;
        private TextBox textNewLog;
        private CheckBox checkViewNewPassword;
        private ErrorProvider errorNoNewLog;
        private ErrorProvider errorNoNewPassword;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label9;
        private ComboBox comboBoxPost;
    }
}