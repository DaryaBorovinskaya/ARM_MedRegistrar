namespace ARM_MedRegistrar.View.SearchAndRemoveDoctor
{
    partial class SearchAndRemoveDoctorForm
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
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Firebrick;
            button2.Location = new Point(490, 353);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(172, 53);
            button2.TabIndex = 41;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Firebrick;
            button1.Location = new Point(68, 277);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(172, 53);
            button1.TabIndex = 42;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = false;
            // 
            // SearchAndRemoveDoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "SearchAndRemoveDoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchAndRemoveDoctorForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
    }
}