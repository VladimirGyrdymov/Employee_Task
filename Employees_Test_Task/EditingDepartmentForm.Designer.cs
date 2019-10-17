namespace Employees_Test_Task
{
    partial class EditingDepartmentForm
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
            this.editDepTextBox = new System.Windows.Forms.TextBox();
            this.editDepComboBox = new System.Windows.Forms.ComboBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alertTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editDepTextBox
            // 
            this.editDepTextBox.Location = new System.Drawing.Point(42, 29);
            this.editDepTextBox.Name = "editDepTextBox";
            this.editDepTextBox.Size = new System.Drawing.Size(220, 20);
            this.editDepTextBox.TabIndex = 0;
            // 
            // editDepComboBox
            // 
            this.editDepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editDepComboBox.FormattingEnabled = true;
            this.editDepComboBox.Location = new System.Drawing.Point(42, 78);
            this.editDepComboBox.Name = "editDepComboBox";
            this.editDepComboBox.Size = new System.Drawing.Size(220, 21);
            this.editDepComboBox.TabIndex = 1;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(42, 129);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(220, 23);
            this.saveChangesButton.TabIndex = 2;
            this.saveChangesButton.Text = "Сохранить изменения";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите новое название подразделения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите нового руководителя подразделения";
            // 
            // alertTextBox
            // 
            this.alertTextBox.Location = new System.Drawing.Point(42, 103);
            this.alertTextBox.Name = "alertTextBox";
            this.alertTextBox.ReadOnly = true;
            this.alertTextBox.Size = new System.Drawing.Size(220, 20);
            this.alertTextBox.TabIndex = 5;
            this.alertTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alertTextBox.Visible = false;
            // 
            // EditingDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 162);
            this.Controls.Add(this.alertTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.editDepComboBox);
            this.Controls.Add(this.editDepTextBox);
            this.Name = "EditingDepartmentForm";
            this.Text = "Редактирование подразделения";
            this.Load += new System.EventHandler(this.EditingDepartmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editDepTextBox;
        private System.Windows.Forms.ComboBox editDepComboBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox alertTextBox;
    }
}