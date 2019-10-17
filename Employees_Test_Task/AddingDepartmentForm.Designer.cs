namespace Employees_Test_Task
{
    partial class AddingDepartmentForm
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
            this.inputDepNameTextBox = new System.Windows.Forms.TextBox();
            this.inputDepNameLabel = new System.Windows.Forms.Label();
            this.choiceHeadEmpLable = new System.Windows.Forms.Label();
            this.headEmpComboBox = new System.Windows.Forms.ComboBox();
            this.createDepButton = new System.Windows.Forms.Button();
            this.alertTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputDepNameTextBox
            // 
            this.inputDepNameTextBox.Location = new System.Drawing.Point(42, 24);
            this.inputDepNameTextBox.Name = "inputDepNameTextBox";
            this.inputDepNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.inputDepNameTextBox.TabIndex = 0;
            // 
            // inputDepNameLabel
            // 
            this.inputDepNameLabel.AutoSize = true;
            this.inputDepNameLabel.Location = new System.Drawing.Point(62, 7);
            this.inputDepNameLabel.Name = "inputDepNameLabel";
            this.inputDepNameLabel.Size = new System.Drawing.Size(181, 13);
            this.inputDepNameLabel.TabIndex = 1;
            this.inputDepNameLabel.Text = "Введите название подразделения";
            // 
            // choiceHeadEmpLable
            // 
            this.choiceHeadEmpLable.AutoSize = true;
            this.choiceHeadEmpLable.Location = new System.Drawing.Point(68, 59);
            this.choiceHeadEmpLable.Name = "choiceHeadEmpLable";
            this.choiceHeadEmpLable.Size = new System.Drawing.Size(168, 13);
            this.choiceHeadEmpLable.TabIndex = 2;
            this.choiceHeadEmpLable.Text = "Выберите руководителя отдела";
            // 
            // headEmpComboBox
            // 
            this.headEmpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.headEmpComboBox.FormattingEnabled = true;
            this.headEmpComboBox.Location = new System.Drawing.Point(42, 78);
            this.headEmpComboBox.Name = "headEmpComboBox";
            this.headEmpComboBox.Size = new System.Drawing.Size(220, 21);
            this.headEmpComboBox.TabIndex = 3;
            // 
            // createDepButton
            // 
            this.createDepButton.Location = new System.Drawing.Point(42, 134);
            this.createDepButton.Name = "createDepButton";
            this.createDepButton.Size = new System.Drawing.Size(220, 23);
            this.createDepButton.TabIndex = 4;
            this.createDepButton.Text = "Создать подразделение";
            this.createDepButton.UseVisualStyleBackColor = true;
            this.createDepButton.Click += new System.EventHandler(this.createDepButton_Click);
            // 
            // alertTextBox
            // 
            this.alertTextBox.Location = new System.Drawing.Point(42, 107);
            this.alertTextBox.Name = "alertTextBox";
            this.alertTextBox.ReadOnly = true;
            this.alertTextBox.Size = new System.Drawing.Size(220, 20);
            this.alertTextBox.TabIndex = 5;
            this.alertTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alertTextBox.Visible = false;
            // 
            // AddingDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 162);
            this.Controls.Add(this.alertTextBox);
            this.Controls.Add(this.createDepButton);
            this.Controls.Add(this.headEmpComboBox);
            this.Controls.Add(this.choiceHeadEmpLable);
            this.Controls.Add(this.inputDepNameLabel);
            this.Controls.Add(this.inputDepNameTextBox);
            this.Name = "AddingDepartmentForm";
            this.Text = "Создание подразделения";
            this.Load += new System.EventHandler(this.AddingDepartmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputDepNameTextBox;
        private System.Windows.Forms.Label inputDepNameLabel;
        private System.Windows.Forms.Label choiceHeadEmpLable;
        private System.Windows.Forms.ComboBox headEmpComboBox;
        private System.Windows.Forms.Button createDepButton;
        private System.Windows.Forms.TextBox alertTextBox;
    }
}