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
            textOldLog = new TextBox();
            buttChangeData = new Button();
            textPatr = new TextBox();
            textName = new TextBox();
            textSurname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorNoOldLog = new ErrorProvider(components);
            errorNoPost = new ErrorProvider(components);
            errorNoSurname = new ErrorProvider(components);
            errorNoName = new ErrorProvider(components);
            label4 = new Label();
            textNewLog = new TextBox();
            textNewPassword = new TextBox();
            checkViewNewPassword = new CheckBox();
            errorNoNewLog = new ErrorProvider(components);
            errorNoNewPassword = new ErrorProvider(components);
            label5 = new Label();
            label6 = new Label();
            comboBoxPost = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            buttSearch = new Button();
            label8 = new Label();
            textPhoneNumber = new TextBox();
            errorNoPhoneNumber = new ErrorProvider(components);
            buttRemoveUser = new Button();
            textPost = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorNoOldLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNewLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNewPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Underline, GraphicsUnit.Point);
            labelName.ForeColor = Color.Firebrick;
            labelName.Location = new Point(11, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(398, 32);
            labelName.TabIndex = 7;
            labelName.Text = "Смена данных пользователя";
            // 
            // textOldLog
            // 
            textOldLog.BackColor = Color.White;
            textOldLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textOldLog.Location = new Point(360, 82);
            textOldLog.Name = "textOldLog";
            textOldLog.Size = new Size(278, 34);
            textOldLog.TabIndex = 10;
            // 
            // buttChangeData
            // 
            buttChangeData.BackColor = Color.FromArgb(255, 192, 192);
            buttChangeData.Enabled = false;
            buttChangeData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttChangeData.ForeColor = Color.Firebrick;
            buttChangeData.Location = new Point(262, 597);
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
            textPatr.Location = new Point(38, 403);
            textPatr.Name = "textPatr";
            textPatr.Size = new Size(329, 34);
            textPatr.TabIndex = 17;
            // 
            // textName
            // 
            textName.BackColor = Color.White;
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(38, 305);
            textName.Name = "textName";
            textName.Size = new Size(329, 34);
            textName.TabIndex = 18;
            // 
            // textSurname
            // 
            textSurname.BackColor = Color.White;
            textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(38, 204);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(329, 34);
            textSurname.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(38, 372);
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
            label2.Location = new Point(38, 274);
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
            label3.Location = new Point(38, 173);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 22;
            label3.Text = "Фамилия";
            // 
            // errorNoOldLog
            // 
            errorNoOldLog.ContainerControl = this;
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
            // 
            // textNewLog
            // 
            textNewLog.BackColor = Color.White;
            textNewLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textNewLog.Location = new Point(395, 353);
            textNewLog.Name = "textNewLog";
            textNewLog.Size = new Size(329, 34);
            textNewLog.TabIndex = 27;
            // 
            // textNewPassword
            // 
            textNewPassword.BackColor = Color.White;
            textNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textNewPassword.Location = new Point(395, 495);
            textNewPassword.Name = "textNewPassword";
            textNewPassword.Size = new Size(329, 34);
            textNewPassword.TabIndex = 28;
            textNewPassword.UseSystemPasswordChar = true;
            // 
            // checkViewNewPassword
            // 
            checkViewNewPassword.AutoSize = true;
            checkViewNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkViewNewPassword.ForeColor = Color.Firebrick;
            checkViewNewPassword.Location = new Point(395, 535);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(395, 312);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 34;
            label5.Text = "Логин";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(395, 464);
            label6.Name = "label6";
            label6.Size = new Size(81, 28);
            label6.TabIndex = 35;
            label6.Text = "Пароль";
            // 
            // comboBoxPost
            // 
            comboBoxPost.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPost.ForeColor = Color.Firebrick;
            comboBoxPost.FormattingEnabled = true;
            comboBoxPost.Location = new Point(395, 267);
            comboBoxPost.Name = "comboBoxPost";
            comboBoxPost.Size = new Size(329, 36);
            comboBoxPost.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(395, 173);
            label9.Name = "label9";
            label9.Size = new Size(115, 28);
            label9.TabIndex = 37;
            label9.Text = "Должность";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(191, 82);
            label7.Name = "label7";
            label7.Size = new Size(149, 28);
            label7.TabIndex = 102;
            label7.Text = "Введите логин:\r\n";
            // 
            // buttSearch
            // 
            buttSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttSearch.Location = new Point(655, 78);
            buttSearch.Name = "buttSearch";
            buttSearch.Size = new Size(103, 43);
            buttSearch.TabIndex = 104;
            buttSearch.Text = "Найти";
            buttSearch.UseVisualStyleBackColor = true;
            buttSearch.Click += buttSearch_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(38, 464);
            label8.Name = "label8";
            label8.Size = new Size(166, 28);
            label8.TabIndex = 106;
            label8.Text = "Номер телефона";
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.BackColor = Color.White;
            textPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPhoneNumber.Location = new Point(38, 495);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(329, 34);
            textPhoneNumber.TabIndex = 105;
            // 
            // errorNoPhoneNumber
            // 
            errorNoPhoneNumber.ContainerControl = this;
            // 
            // buttRemoveUser
            // 
            buttRemoveUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttRemoveUser.Location = new Point(507, 129);
            buttRemoveUser.Name = "buttRemoveUser";
            buttRemoveUser.Size = new Size(261, 41);
            buttRemoveUser.TabIndex = 107;
            buttRemoveUser.Text = "Удалить пользователя";
            buttRemoveUser.UseVisualStyleBackColor = true;
            buttRemoveUser.Click += buttRemoveUser_Click;
            // 
            // textPost
            // 
            textPost.BackColor = Color.White;
            textPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPost.Location = new Point(395, 204);
            textPost.Name = "textPost";
            textPost.Size = new Size(329, 34);
            textPost.TabIndex = 108;
            // 
            // ChangeDataOfUserForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(780, 695);
            Controls.Add(textPost);
            Controls.Add(buttRemoveUser);
            Controls.Add(label8);
            Controls.Add(textPhoneNumber);
            Controls.Add(buttSearch);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(comboBoxPost);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(checkViewNewPassword);
            Controls.Add(textNewPassword);
            Controls.Add(textNewLog);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSurname);
            Controls.Add(textName);
            Controls.Add(textPatr);
            Controls.Add(buttChangeData);
            Controls.Add(textOldLog);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChangeDataOfUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARM_MedRegistrar";
            ((System.ComponentModel.ISupportInitialize)errorNoOldLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPost).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNewLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoNewPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPhoneNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        #endregion

        private Label labelName;
        private TextBox textOldLog;
        private Button buttChangeData;
        private TextBox textPatr;
        private TextBox textName;
        private TextBox textSurname;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorNoOldLog;
        private ErrorProvider errorNoPost;
        private ErrorProvider errorNoSurname;
        private ErrorProvider errorNoName;
        private Label label4;
        private TextBox textNewPassword;
        private TextBox textNewLog;
        private CheckBox checkViewNewPassword;
        private ErrorProvider errorNoNewLog;
        private ErrorProvider errorNoNewPassword;
        private Label label6;
        private Label label5;
        private Label label9;
        private ComboBox comboBoxPost;
        private Label label7;
        private Button buttSearch;
        private Label label8;
        private TextBox textPhoneNumber;
        private ErrorProvider errorNoPhoneNumber;
        private Button buttRemoveUser;
        private TextBox textPost;
    }
}