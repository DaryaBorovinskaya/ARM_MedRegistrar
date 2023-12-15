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
            buttExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(249, 28);
            label1.TabIndex = 0;
            label1.Text = "Данные о пользователе";
            // 
            // textSurname
            // 
            textSurname.BackColor = Color.White;
            textSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(12, 111);
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
            label3.Location = new Point(12, 80);
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
            label2.Location = new Point(12, 173);
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
            label4.Location = new Point(12, 274);
            label4.Name = "label4";
            label4.Size = new Size(234, 28);
            label4.TabIndex = 25;
            label4.Text = "Отчество (при наличии)";
            // 
            // textName
            // 
            textName.BackColor = Color.White;
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(12, 204);
            textName.Name = "textName";
            textName.ReadOnly = true;
            textName.Size = new Size(375, 34);
            textName.TabIndex = 26;
            // 
            // textPatr
            // 
            textPatr.BackColor = Color.White;
            textPatr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPatr.Location = new Point(12, 305);
            textPatr.Name = "textPatr";
            textPatr.ReadOnly = true;
            textPatr.Size = new Size(375, 34);
            textPatr.TabIndex = 27;
            // 
            // buttExit
            // 
            buttExit.BackColor = Color.FromArgb(255, 192, 192);
            buttExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttExit.ForeColor = Color.Firebrick;
            buttExit.Location = new Point(12, 372);
            buttExit.Name = "buttExit";
            buttExit.Size = new Size(164, 53);
            buttExit.TabIndex = 28;
            buttExit.Text = "Выйти";
            buttExit.UseVisualStyleBackColor = false;
            // 
            // InfoAboutUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(452, 450);
            Controls.Add(buttExit);
            Controls.Add(textPatr);
            Controls.Add(textName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textSurname);
            Controls.Add(label1);
            Location = new Point(12, 12);
            Name = "InfoAboutUserForm";
            StartPosition = FormStartPosition.Manual;
            Text = "InfoAboutUserForm";
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
        private Button buttExit;
    }
}