namespace ARM_MedRegistrar
{
    partial class MainWindow
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
            buttAddPatient = new Button();
            buttAddDoctor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(72, 55);
            label1.Name = "label1";
            label1.Size = new Size(212, 28);
            label1.TabIndex = 0;
            label1.Text = "ВВОД ДАННЫХ";
            label1.Click += label1_Click;
            // 
            // buttAddPatient
            // 
            buttAddPatient.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttAddPatient.ForeColor = Color.Firebrick;
            buttAddPatient.Location = new Point(354, 37);
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
            buttAddDoctor.Location = new Point(555, 37);
            buttAddDoctor.Name = "buttAddDoctor";
            buttAddDoctor.Size = new Size(147, 65);
            buttAddDoctor.TabIndex = 3;
            buttAddDoctor.Text = "Добавить врача";
            buttAddDoctor.UseVisualStyleBackColor = true;
            buttAddDoctor.Click += buttAddDoctor_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttAddDoctor);
            Controls.Add(buttAddPatient);
            Controls.Add(label1);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttAddPatient;
        private Button buttAddDoctor;
    }
}