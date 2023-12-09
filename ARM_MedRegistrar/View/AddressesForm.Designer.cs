namespace ARM_MedRegistrar.View
{
    partial class AddressesForm
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
            buttOpenFile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 31);
            label1.TabIndex = 0;
            label1.Text = "Адреса";
            // 
            // buttOpenFile
            // 
            buttOpenFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttOpenFile.ForeColor = Color.Firebrick;
            buttOpenFile.Location = new Point(599, 34);
            buttOpenFile.Name = "buttOpenFile";
            buttOpenFile.Size = new Size(229, 50);
            buttOpenFile.TabIndex = 1;
            buttOpenFile.Text = "Просмотреть файл";
            buttOpenFile.UseVisualStyleBackColor = true;
            // 
            // Addresses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(924, 540);
            Controls.Add(buttOpenFile);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Addresses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addresses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttOpenFile;
    }
}