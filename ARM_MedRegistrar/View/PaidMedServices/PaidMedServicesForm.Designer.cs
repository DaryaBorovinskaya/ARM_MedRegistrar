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
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(458, 41);
            label1.TabIndex = 0;
            label1.Text = "Платные медицинские услуги";
            // 
            // listViewPaidMedServices
            // 
            listViewPaidMedServices.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader1, columnHeader2 });
            listViewPaidMedServices.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listViewPaidMedServices.Location = new Point(28, 317);
            listViewPaidMedServices.MultiSelect = false;
            listViewPaidMedServices.Name = "listViewPaidMedServices";
            listViewPaidMedServices.Size = new Size(1303, 443);
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
            columnHeader1.Width = 1000;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Цена";
            columnHeader2.Width = 200;
            // 
            // buttAddPaidMedService
            // 
            buttAddPaidMedService.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttAddPaidMedService.ForeColor = Color.Firebrick;
            buttAddPaidMedService.Location = new Point(1446, 429);
            buttAddPaidMedService.Name = "buttAddPaidMedService";
            buttAddPaidMedService.Size = new Size(271, 83);
            buttAddPaidMedService.TabIndex = 2;
            buttAddPaidMedService.Text = "Добавить услугу";
            buttAddPaidMedService.UseVisualStyleBackColor = true;
            buttAddPaidMedService.Click += buttAddPaidMedService_Click;
            // 
            // buttRemoveMedService
            // 
            buttRemoveMedService.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttRemoveMedService.ForeColor = Color.Firebrick;
            buttRemoveMedService.Location = new Point(28, 783);
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
            textTotalPrice.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textTotalPrice.Location = new Point(1575, 918);
            textTotalPrice.Name = "textTotalPrice";
            textTotalPrice.ReadOnly = true;
            textTotalPrice.Size = new Size(208, 43);
            textTotalPrice.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(1575, 873);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 5;
            label2.Text = "Итого:";
            // 
            // buttCalculateTotalPrice
            // 
            buttCalculateTotalPrice.BackColor = Color.White;
            buttCalculateTotalPrice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttCalculateTotalPrice.ForeColor = Color.Firebrick;
            buttCalculateTotalPrice.Location = new Point(1051, 918);
            buttCalculateTotalPrice.Name = "buttCalculateTotalPrice";
            buttCalculateTotalPrice.Size = new Size(440, 55);
            buttCalculateTotalPrice.TabIndex = 6;
            buttCalculateTotalPrice.Text = "Посчитать итоговую стоимость";
            buttCalculateTotalPrice.UseVisualStyleBackColor = false;
            buttCalculateTotalPrice.Click += buttCalculateTotalPrice_Click;
            // 
            // textSearchingTitle
            // 
            textSearchingTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textSearchingTitle.Location = new Point(101, 230);
            textSearchingTitle.Name = "textSearchingTitle";
            textSearchingTitle.Size = new Size(313, 43);
            textSearchingTitle.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(115, 166);
            label3.Name = "label3";
            label3.Size = new Size(259, 32);
            label3.TabIndex = 9;
            label3.Text = "Наименование услуги";
            // 
            // buttSearchPaidMedService
            // 
            buttSearchPaidMedService.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttSearchPaidMedService.ForeColor = Color.Firebrick;
            buttSearchPaidMedService.Location = new Point(648, 212);
            buttSearchPaidMedService.Name = "buttSearchPaidMedService";
            buttSearchPaidMedService.Size = new Size(273, 61);
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
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(1357, 80);
            label4.Name = "label4";
            label4.Size = new Size(426, 37);
            label4.TabIndex = 11;
            label4.Text = "Добавление платной мед. услуги";
            // 
            // textTitle
            // 
            textTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textTitle.Location = new Point(1440, 183);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(313, 39);
            textTitle.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(1440, 142);
            label5.Name = "label5";
            label5.Size = new Size(188, 32);
            label5.TabIndex = 13;
            label5.Text = "Наименование ";
            // 
            // buttAllPaidMedServices
            // 
            buttAllPaidMedServices.BackColor = Color.MistyRose;
            buttAllPaidMedServices.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttAllPaidMedServices.ForeColor = Color.Firebrick;
            buttAllPaidMedServices.Location = new Point(1023, 766);
            buttAllPaidMedServices.Name = "buttAllPaidMedServices";
            buttAllPaidMedServices.Size = new Size(308, 61);
            buttAllPaidMedServices.TabIndex = 15;
            buttAllPaidMedServices.Text = "Обновить список услуг";
            buttAllPaidMedServices.UseVisualStyleBackColor = false;
            buttAllPaidMedServices.Click += buttAllPaidMedServices_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(1440, 263);
            label6.Name = "label6";
            label6.Size = new Size(71, 32);
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
            numericPrice.Location = new Point(1446, 294);
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(150, 34);
            numericPrice.TabIndex = 17;
            numericPrice.ValueChanged += numericPrice_ValueChanged;
            // 
            // checkIsMultiSelect
            // 
            checkIsMultiSelect.AutoSize = true;
            checkIsMultiSelect.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkIsMultiSelect.ForeColor = Color.Firebrick;
            checkIsMultiSelect.Location = new Point(550, 783);
            checkIsMultiSelect.Name = "checkIsMultiSelect";
            checkIsMultiSelect.Size = new Size(306, 36);
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
            ClientSize = new Size(1902, 1033);
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
            Name = "PaidMedServicesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARM_MedRegistrar";
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