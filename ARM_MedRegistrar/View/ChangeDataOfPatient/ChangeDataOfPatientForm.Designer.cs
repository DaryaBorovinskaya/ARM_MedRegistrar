namespace ARM_MedRegistrar.View.ChangeDataOfPatient
{
    partial class ChangeDataOfPatientForm
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(364, 32);
            label1.TabIndex = 1;
            label1.Text = "Изменение данных пациента";
            // 
            // ChangeDataOfPatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "ChangeDataOfPatientForm";
            Text = "ChangeDataOfPatientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}