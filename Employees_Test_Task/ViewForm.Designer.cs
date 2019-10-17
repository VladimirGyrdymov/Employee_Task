namespace Employees_Test_Task
{
    partial class ViewForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.depLabel = new System.Windows.Forms.Label();
            this.empLabel = new System.Windows.Forms.Label();
            this.addDepButton = new System.Windows.Forms.Button();
            this.editDepButton = new System.Windows.Forms.Button();
            this.addEmpButton = new System.Windows.Forms.Button();
            this.editEmpButton = new System.Windows.Forms.Button();
            this.depDataGridView = new System.Windows.Forms.DataGridView();
            this.empDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshDepButton = new System.Windows.Forms.Button();
            this.refreshEmpButton = new System.Windows.Forms.Button();
            this.deleteDepButton = new System.Windows.Forms.Button();
            this.deleteEmpButton = new System.Windows.Forms.Button();
            this.alertTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.depDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // depLabel
            // 
            this.depLabel.AutoSize = true;
            this.depLabel.Location = new System.Drawing.Point(12, 10);
            this.depLabel.Name = "depLabel";
            this.depLabel.Size = new System.Drawing.Size(87, 13);
            this.depLabel.TabIndex = 2;
            this.depLabel.Text = "Подразделения";
            // 
            // empLabel
            // 
            this.empLabel.AutoSize = true;
            this.empLabel.Location = new System.Drawing.Point(373, 10);
            this.empLabel.Name = "empLabel";
            this.empLabel.Size = new System.Drawing.Size(66, 13);
            this.empLabel.TabIndex = 3;
            this.empLabel.Text = "Сотрудники";
            // 
            // addDepButton
            // 
            this.addDepButton.Location = new System.Drawing.Point(12, 282);
            this.addDepButton.Name = "addDepButton";
            this.addDepButton.Size = new System.Drawing.Size(210, 23);
            this.addDepButton.TabIndex = 6;
            this.addDepButton.Text = "Добавить подразделение";
            this.addDepButton.UseVisualStyleBackColor = true;
            this.addDepButton.Click += new System.EventHandler(this.addDepButton_Click);
            // 
            // editDepButton
            // 
            this.editDepButton.Location = new System.Drawing.Point(12, 312);
            this.editDepButton.Name = "editDepButton";
            this.editDepButton.Size = new System.Drawing.Size(210, 23);
            this.editDepButton.TabIndex = 7;
            this.editDepButton.Text = "Редактировать подразделение";
            this.editDepButton.UseVisualStyleBackColor = true;
            this.editDepButton.Click += new System.EventHandler(this.editDepButton_Click);
            // 
            // addEmpButton
            // 
            this.addEmpButton.Location = new System.Drawing.Point(376, 282);
            this.addEmpButton.Name = "addEmpButton";
            this.addEmpButton.Size = new System.Drawing.Size(210, 23);
            this.addEmpButton.TabIndex = 8;
            this.addEmpButton.Text = "Добавить сотрудника";
            this.addEmpButton.UseVisualStyleBackColor = true;
            this.addEmpButton.Click += new System.EventHandler(this.addEmpButton_Click);
            // 
            // editEmpButton
            // 
            this.editEmpButton.Location = new System.Drawing.Point(376, 312);
            this.editEmpButton.Name = "editEmpButton";
            this.editEmpButton.Size = new System.Drawing.Size(210, 23);
            this.editEmpButton.TabIndex = 9;
            this.editEmpButton.Text = "Редактировать сотрудника";
            this.editEmpButton.UseVisualStyleBackColor = true;
            this.editEmpButton.Click += new System.EventHandler(this.editEmpButton_Click);
            // 
            // depDataGridView
            // 
            this.depDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depDataGridView.Location = new System.Drawing.Point(12, 36);
            this.depDataGridView.MultiSelect = false;
            this.depDataGridView.Name = "depDataGridView";
            this.depDataGridView.ReadOnly = true;
            this.depDataGridView.Size = new System.Drawing.Size(316, 230);
            this.depDataGridView.TabIndex = 10;
            // 
            // empDataGridView
            // 
            this.empDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDataGridView.Location = new System.Drawing.Point(376, 36);
            this.empDataGridView.MultiSelect = false;
            this.empDataGridView.Name = "empDataGridView";
            this.empDataGridView.ReadOnly = true;
            this.empDataGridView.Size = new System.Drawing.Size(505, 230);
            this.empDataGridView.TabIndex = 11;
            // 
            // refreshDepButton
            // 
            this.refreshDepButton.Location = new System.Drawing.Point(253, 7);
            this.refreshDepButton.Name = "refreshDepButton";
            this.refreshDepButton.Size = new System.Drawing.Size(75, 23);
            this.refreshDepButton.TabIndex = 12;
            this.refreshDepButton.Text = "Обновить";
            this.refreshDepButton.UseVisualStyleBackColor = true;
            this.refreshDepButton.Click += new System.EventHandler(this.refreshDepButton_Click);
            // 
            // refreshEmpButton
            // 
            this.refreshEmpButton.Location = new System.Drawing.Point(806, 5);
            this.refreshEmpButton.Name = "refreshEmpButton";
            this.refreshEmpButton.Size = new System.Drawing.Size(75, 23);
            this.refreshEmpButton.TabIndex = 13;
            this.refreshEmpButton.Text = "Обновить";
            this.refreshEmpButton.UseVisualStyleBackColor = true;
            this.refreshEmpButton.Click += new System.EventHandler(this.refreshEmpButton_Click);
            // 
            // deleteDepButton
            // 
            this.deleteDepButton.Location = new System.Drawing.Point(12, 341);
            this.deleteDepButton.Name = "deleteDepButton";
            this.deleteDepButton.Size = new System.Drawing.Size(210, 23);
            this.deleteDepButton.TabIndex = 14;
            this.deleteDepButton.Text = "Удалить подразделение";
            this.deleteDepButton.UseVisualStyleBackColor = true;
            this.deleteDepButton.Click += new System.EventHandler(this.deleteDepButton_Click);
            // 
            // deleteEmpButton
            // 
            this.deleteEmpButton.Location = new System.Drawing.Point(376, 341);
            this.deleteEmpButton.Name = "deleteEmpButton";
            this.deleteEmpButton.Size = new System.Drawing.Size(210, 23);
            this.deleteEmpButton.TabIndex = 15;
            this.deleteEmpButton.Text = "Удалить сотрудника";
            this.deleteEmpButton.UseVisualStyleBackColor = true;
            this.deleteEmpButton.Click += new System.EventHandler(this.deleteEmpButton_Click);
            // 
            // alertTextBox
            // 
            this.alertTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alertTextBox.Location = new System.Drawing.Point(592, 343);
            this.alertTextBox.Name = "alertTextBox";
            this.alertTextBox.ReadOnly = true;
            this.alertTextBox.Size = new System.Drawing.Size(234, 20);
            this.alertTextBox.TabIndex = 16;
            this.alertTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alertTextBox.Visible = false;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 370);
            this.Controls.Add(this.alertTextBox);
            this.Controls.Add(this.deleteEmpButton);
            this.Controls.Add(this.deleteDepButton);
            this.Controls.Add(this.refreshEmpButton);
            this.Controls.Add(this.refreshDepButton);
            this.Controls.Add(this.empDataGridView);
            this.Controls.Add(this.depDataGridView);
            this.Controls.Add(this.editEmpButton);
            this.Controls.Add(this.addEmpButton);
            this.Controls.Add(this.editDepButton);
            this.Controls.Add(this.addDepButton);
            this.Controls.Add(this.empLabel);
            this.Controls.Add(this.depLabel);
            this.Name = "ViewForm";
            this.Text = "Приложение";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label depLabel;
        private System.Windows.Forms.Label empLabel;
        private System.Windows.Forms.Button addDepButton;
        private System.Windows.Forms.Button editDepButton;
        private System.Windows.Forms.Button addEmpButton;
        private System.Windows.Forms.Button editEmpButton;
        private System.Windows.Forms.DataGridView depDataGridView;
        private System.Windows.Forms.DataGridView empDataGridView;
        private System.Windows.Forms.Button refreshDepButton;
        private System.Windows.Forms.Button refreshEmpButton;
        private System.Windows.Forms.Button deleteDepButton;
        private System.Windows.Forms.Button deleteEmpButton;
        private System.Windows.Forms.TextBox alertTextBox;
    }
}

