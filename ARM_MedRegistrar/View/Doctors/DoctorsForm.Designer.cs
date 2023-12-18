namespace ARM_MedRegistrar.View.Doctors
{
    partial class DoctorsForm
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
            listViewDoctors = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label2 = new Label();
            buttAddDoctor = new Button();
            buttSearchAndRemoveDoctor = new Button();
            SuspendLayout();
            // 
            // listViewDoctors
            // 
            listViewDoctors.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader1, columnHeader2, columnHeader3, columnHeader6, columnHeader4, columnHeader5 });
            listViewDoctors.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            listViewDoctors.Location = new Point(12, 70);
            listViewDoctors.MultiSelect = false;
            listViewDoctors.Name = "listViewDoctors";
            listViewDoctors.Size = new Size(1056, 377);
            listViewDoctors.TabIndex = 39;
            listViewDoctors.UseCompatibleStateImageBehavior = false;
            listViewDoctors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ID";
            columnHeader7.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Фамилия";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Имя";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Отчество";
            columnHeader3.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Специализация";
            columnHeader6.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Кабинет";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Участок";
            columnHeader5.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 40;
            label2.Text = "Врачи";
            // 
            // buttAddDoctor
            // 
            buttAddDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAddDoctor.ForeColor = Color.Firebrick;
            buttAddDoctor.Location = new Point(100, 501);
            buttAddDoctor.Name = "buttAddDoctor";
            buttAddDoctor.Size = new Size(147, 65);
            buttAddDoctor.TabIndex = 41;
            buttAddDoctor.Text = "Добавить врача";
            buttAddDoctor.UseVisualStyleBackColor = true;
            buttAddDoctor.Click += buttAddDoctor_Click;
            // 
            // buttSearchAndRemoveDoctor
            // 
            buttSearchAndRemoveDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttSearchAndRemoveDoctor.ForeColor = Color.Firebrick;
            buttSearchAndRemoveDoctor.Location = new Point(662, 501);
            buttSearchAndRemoveDoctor.Name = "buttSearchAndRemoveDoctor";
            buttSearchAndRemoveDoctor.Size = new Size(158, 65);
            buttSearchAndRemoveDoctor.TabIndex = 42;
            buttSearchAndRemoveDoctor.Text = "Найти +\r\n удалить врача\r\n";
            buttSearchAndRemoveDoctor.UseVisualStyleBackColor = true;
            buttSearchAndRemoveDoctor.Click += buttSearchAndRemoveDoctor_Click;
            // 
            // DoctorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1080, 641);
            Controls.Add(buttSearchAndRemoveDoctor);
            Controls.Add(buttAddDoctor);
            Controls.Add(label2);
            Controls.Add(listViewDoctors);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DoctorsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorsForm";
            Load += DoctorsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewDoctors;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label2;
        private Button buttAddDoctor;
        private Button buttSearchAndRemoveDoctor;
    }
}