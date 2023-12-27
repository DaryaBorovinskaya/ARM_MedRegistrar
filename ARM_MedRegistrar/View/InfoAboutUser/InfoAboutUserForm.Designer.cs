namespace ARM_MedRegistrar.View
{
    partial class InfoAboutUserForm
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
            label1 = new Label();
            textSurname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            textName = new TextBox();
            textPatr = new TextBox();
            textPost = new TextBox();
            textPhoneNumber = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(249, 28);
            label1.TabIndex = 0;
            label1.Text = "Данные о пользователе";
            // 
            // textSurname
            // 
            textSurname.BackColor = Color.White;
            textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(12, 92);
            textSurname.Name = "textSurname";
            textSurname.ReadOnly = true;
            textSurname.Size = new Size(375, 34);
            textSurname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 23;
            label3.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 24;
            label2.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(234, 28);
            label4.TabIndex = 25;
            label4.Text = "Отчество (при наличии)";
            // 
            // textName
            // 
            textName.BackColor = Color.White;
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(12, 170);
            textName.Name = "textName";
            textName.ReadOnly = true;
            textName.Size = new Size(375, 34);
            textName.TabIndex = 26;
            // 
            // textPatr
            // 
            textPatr.BackColor = Color.White;
            textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatr.Location = new Point(12, 255);
            textPatr.Name = "textPatr";
            textPatr.ReadOnly = true;
            textPatr.Size = new Size(375, 34);
            textPatr.TabIndex = 27;
            // 
            // textPost
            // 
            textPost.BackColor = Color.White;
            textPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPost.Location = new Point(431, 92);
            textPost.Name = "textPost";
            textPost.ReadOnly = true;
            textPost.Size = new Size(375, 34);
            textPost.TabIndex = 29;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.BackColor = Color.White;
            textPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPhoneNumber.Location = new Point(431, 170);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.ReadOnly = true;
            textPhoneNumber.Size = new Size(375, 34);
            textPhoneNumber.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(573, 61);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 31;
            label5.Text = "Должность";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(551, 139);
            label6.Name = "label6";
            label6.Size = new Size(166, 28);
            label6.TabIndex = 32;
            label6.Text = "Номер телефона";
            // 
            // InfoAboutUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(819, 317);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textPhoneNumber);
            Controls.Add(textPost);
            Controls.Add(textPatr);
            Controls.Add(textName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textSurname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(12, 12);
            MaximizeBox = false;
            Name = "InfoAboutUserForm";
            StartPosition = FormStartPosition.Manual;
            Text = "ARM_MedRegistrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textSurname;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textName;
        private TextBox textPatr;
        private TextBox textPost;
        private TextBox textPhoneNumber;
        private Label label5;
        private Label label6;
    }
}