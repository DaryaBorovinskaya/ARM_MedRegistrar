namespace ARM_MedRegistrar.View.PaidMedServices
{
    partial class PaidMedServicesForm
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
            listViewPaidMedServices = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            buttAddPaidMedService = new Button();
            buttRemoveMedService = new Button();
            textTotalPrice = new TextBox();
            label2 = new Label();
            buttCalculateTotalPrice = new Button();
            textSearchingTitle = new TextBox();
            label3 = new Label();
            buttSearchPaidMedService = new Button();
            errorNoTitle = new ErrorProvider(components);
            label4 = new Label();
            textTitle = new TextBox();
            label5 = new Label();
            buttAllPaidMedServices = new Button();
            label6 = new Label();
            errorNoPrice = new ErrorProvider(components);
            numericPrice = new NumericUpDown();
            checkIsMultiSelect = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)errorNoTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(430, 38);
            label1.TabIndex = 0;
            label1.Text = "Платные медицинские услуги";
            // 
            // listViewPaidMedServices
            // 
            listViewPaidMedServices.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader1, columnHeader2 });
            listViewPaidMedServices.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listViewPaidMedServices.Location = new Point(12, 233);
            listViewPaidMedServices.MultiSelect = false;
            listViewPaidMedServices.Name = "listViewPaidMedServices";
            listViewPaidMedServices.Size = new Size(755, 321);
            listViewPaidMedServices.TabIndex = 1;
            listViewPaidMedServices.UseCompatibleStateImageBehavior = false;
            listViewPaidMedServices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ID";
            columnHeader3.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Наименование услуги";
            columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Цена";
            columnHeader2.Width = 150;
            // 
            // buttAddPaidMedService
            // 
            buttAddPaidMedService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAddPaidMedService.ForeColor = Color.Firebrick;
            buttAddPaidMedService.Location = new Point(942, 332);
            buttAddPaidMedService.Name = "buttAddPaidMedService";
            buttAddPaidMedService.Size = new Size(220, 44);
            buttAddPaidMedService.TabIndex = 2;
            buttAddPaidMedService.Text = "Добавить услугу";
            buttAddPaidMedService.UseVisualStyleBackColor = true;
            buttAddPaidMedService.Click += buttAddPaidMedService_Click;
            // 
            // buttRemoveMedService
            // 
            buttRemoveMedService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttRemoveMedService.ForeColor = Color.Firebrick;
            buttRemoveMedService.Location = new Point(12, 570);
            buttRemoveMedService.Name = "buttRemoveMedService";
            buttRemoveMedService.Size = new Size(220, 44);
            buttRemoveMedService.TabIndex = 3;
            buttRemoveMedService.Text = "Удалить услугу";
            buttRemoveMedService.UseVisualStyleBackColor = true;
            buttRemoveMedService.Click += buttRemoveMedService_Click;
            // 
            // textTotalPrice
            // 
            textTotalPrice.BackColor = Color.White;
            textTotalPrice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textTotalPrice.Location = new Point(942, 660);
            textTotalPrice.Name = "textTotalPrice";
            textTotalPrice.ReadOnly = true;
            textTotalPrice.Size = new Size(182, 39);
            textTotalPrice.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(993, 613);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 5;
            label2.Text = "Итого:";
            // 
            // buttCalculateTotalPrice
            // 
            buttCalculateTotalPrice.BackColor = Color.White;
            buttCalculateTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttCalculateTotalPrice.ForeColor = Color.Firebrick;
            buttCalculateTotalPrice.Location = new Point(534, 655);
            buttCalculateTotalPrice.Name = "buttCalculateTotalPrice";
            buttCalculateTotalPrice.Size = new Size(371, 44);
            buttCalculateTotalPrice.TabIndex = 6;
            buttCalculateTotalPrice.Text = "Посчитать итоговую стоимость";
            buttCalculateTotalPrice.UseVisualStyleBackColor = false;
            buttCalculateTotalPrice.Click += buttCalculateTotalPrice_Click;
            // 
            // textSearchingTitle
            // 
            textSearchingTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textSearchingTitle.Location = new Point(12, 166);
            textSearchingTitle.Name = "textSearchingTitle";
            textSearchingTitle.Size = new Size(313, 39);
            textSearchingTitle.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(216, 28);
            label3.TabIndex = 9;
            label3.Text = "Наименование услуги";
            // 
            // buttSearchPaidMedService
            // 
            buttSearchPaidMedService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttSearchPaidMedService.ForeColor = Color.Firebrick;
            buttSearchPaidMedService.Location = new Point(362, 161);
            buttSearchPaidMedService.Name = "buttSearchPaidMedService";
            buttSearchPaidMedService.Size = new Size(220, 44);
            buttSearchPaidMedService.TabIndex = 10;
            buttSearchPaidMedService.Text = "Найти";
            buttSearchPaidMedService.UseVisualStyleBackColor = true;
            buttSearchPaidMedService.Click += buttSearchPaidMedService_Click;
            // 
            // errorNoTitle
            // 
            errorNoTitle.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Snow;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(874, 39);
            label4.Name = "label4";
            label4.Size = new Size(358, 31);
            label4.TabIndex = 11;
            label4.Text = "Добавление платной мед. услуги";
            // 
            // textTitle
            // 
            textTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textTitle.Location = new Point(896, 148);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(313, 39);
            textTitle.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(896, 107);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 13;
            label5.Text = "Наименование ";
            // 
            // buttAllPaidMedServices
            // 
            buttAllPaidMedServices.BackColor = Color.MistyRose;
            buttAllPaidMedServices.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllPaidMedServices.ForeColor = Color.Firebrick;
            buttAllPaidMedServices.Location = new Point(511, 570);
            buttAllPaidMedServices.Name = "buttAllPaidMedServices";
            buttAllPaidMedServices.Size = new Size(256, 44);
            buttAllPaidMedServices.TabIndex = 15;
            buttAllPaidMedServices.Text = "Обновить список услуг";
            buttAllPaidMedServices.UseVisualStyleBackColor = false;
            buttAllPaidMedServices.Click += buttAllPaidMedServices_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(896, 228);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 16;
            label6.Text = "Цена";
            // 
            // errorNoPrice
            // 
            errorNoPrice.ContainerControl = this;
            // 
            // numericPrice
            // 
            numericPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericPrice.Location = new Point(902, 259);
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(150, 34);
            numericPrice.TabIndex = 17;
            numericPrice.ValueChanged += numericPrice_ValueChanged;
            // 
            // checkIsMultiSelect
            // 
            checkIsMultiSelect.AutoSize = true;
            checkIsMultiSelect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkIsMultiSelect.ForeColor = Color.Firebrick;
            checkIsMultiSelect.Location = new Point(253, 577);
            checkIsMultiSelect.Name = "checkIsMultiSelect";
            checkIsMultiSelect.Size = new Size(258, 32);
            checkIsMultiSelect.TabIndex = 18;
            checkIsMultiSelect.Text = "Выбор нескольких услуг";
            checkIsMultiSelect.UseVisualStyleBackColor = true;
            checkIsMultiSelect.CheckedChanged += checkIsMultiSelect_CheckedChanged;
            // 
            // PaidMedServicesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1309, 750);
            Controls.Add(checkIsMultiSelect);
            Controls.Add(numericPrice);
            Controls.Add(label6);
            Controls.Add(buttAllPaidMedServices);
            Controls.Add(label5);
            Controls.Add(textTitle);
            Controls.Add(label4);
            Controls.Add(buttSearchPaidMedService);
            Controls.Add(label3);
            Controls.Add(textSearchingTitle);
            Controls.Add(buttCalculateTotalPrice);
            Controls.Add(label2);
            Controls.Add(textTotalPrice);
            Controls.Add(buttRemoveMedService);
            Controls.Add(buttAddPaidMedService);
            Controls.Add(listViewPaidMedServices);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PaidMedServicesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaidMedServicesForm";
            ((System.ComponentModel.ISupportInitialize)errorNoTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNoPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewPaidMedServices;
        private Button buttAddPaidMedService;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button buttRemoveMedService;
        private TextBox textTotalPrice;
        private Label label2;
        private Button buttCalculateTotalPrice;
        private TextBox textSearchingTitle;
        private Label label3;
        private Button buttSearchPaidMedService;
        private ErrorProvider errorNoTitle;
        private Label label4;
        private Label label6;
        private Button buttAllPaidMedServices;
        private Label label5;
        private TextBox textTitle;
        private ErrorProvider errorNoPrice;
        private NumericUpDown numericPrice;
        private ColumnHeader columnHeader3;
        private CheckBox checkIsMultiSelect;
    }
}