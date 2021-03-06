﻿namespace Employees_Test_Task
{
    partial class EditingEmployeeForm
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
            this.alertTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.empComboBox = new System.Windows.Forms.ComboBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // alertTextBox
            // 
            this.alertTextBox.Location = new System.Drawing.Point(99, 198);
            this.alertTextBox.Name = "alertTextBox";
            this.alertTextBox.ReadOnly = true;
            this.alertTextBox.Size = new System.Drawing.Size(198, 20);
            this.alertTextBox.TabIndex = 39;
            this.alertTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alertTextBox.Visible = false;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(97, 122);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(25, 13);
            this.yearLabel.TabIndex = 38;
            this.yearLabel.Text = "Год";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(155, 122);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 37;
            this.monthLabel.Text = "Месяц";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(228, 122);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(39, 13);
            this.dayLabel.TabIndex = 36;
            this.dayLabel.Text = "Число";
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(267, 119);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(31, 20);
            this.dayTextBox.TabIndex = 5;
            this.dayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(195, 119);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(31, 20);
            this.monthTextBox.TabIndex = 4;
            this.monthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(100, 224);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(198, 23);
            this.saveChangesButton.TabIndex = 8;
            this.saveChangesButton.Text = "Сохранить изменения";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // sexComboBox
            // 
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(100, 145);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(198, 21);
            this.sexComboBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(122, 119);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(31, 20);
            this.yearTextBox.TabIndex = 3;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(100, 93);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.secondNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(100, 67);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(7, 174);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(87, 13);
            this.departmentLabel.TabIndex = 28;
            this.departmentLabel.Text = "Подразделение";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(67, 148);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(27, 13);
            this.sexLabel.TabIndex = 27;
            this.sexLabel.Text = "Пол";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(8, 122);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(86, 13);
            this.birthdayLabel.TabIndex = 26;
            this.birthdayLabel.Text = "Дата рождения";
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(40, 96);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(54, 13);
            this.secondNameLabel.TabIndex = 25;
            this.secondNameLabel.Text = "Отчество";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(65, 70);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.firstNameLabel.TabIndex = 24;
            this.firstNameLabel.Text = "Имя";
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Location = new System.Drawing.Point(38, 44);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(56, 13);
            this.lastNameLable.TabIndex = 23;
            this.lastNameLable.Text = "Фамилия";
            // 
            // empComboBox
            // 
            this.empComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empComboBox.FormattingEnabled = true;
            this.empComboBox.Location = new System.Drawing.Point(100, 171);
            this.empComboBox.Name = "empComboBox";
            this.empComboBox.Size = new System.Drawing.Size(198, 21);
            this.empComboBox.TabIndex = 7;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(57, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(240, 16);
            this.infoLabel.TabIndex = 21;
            this.infoLabel.Text = "Введите новые данные сотрудника";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(100, 41);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // EditingEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 257);
            this.Controls.Add(this.alertTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLable);
            this.Controls.Add(this.empComboBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Name = "EditingEmployeeForm";
            this.Text = "Редактирование сотрудника";
            this.Load += new System.EventHandler(this.EditingEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alertTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.ComboBox empComboBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
    }
}