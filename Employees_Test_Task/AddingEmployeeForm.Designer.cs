namespace Employees_Test_Task
{
    partial class AddingEmployeeForm
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
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.empComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.dayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.alertTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(100, 44);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(57, 12);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(196, 16);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "Введите данные сотрудника";
            // 
            // empComboBox
            // 
            this.empComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empComboBox.FormattingEnabled = true;
            this.empComboBox.Location = new System.Drawing.Point(100, 174);
            this.empComboBox.Name = "empComboBox";
            this.empComboBox.Size = new System.Drawing.Size(198, 21);
            this.empComboBox.TabIndex = 7;
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Location = new System.Drawing.Point(38, 47);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(56, 13);
            this.lastNameLable.TabIndex = 11;
            this.lastNameLable.Text = "Фамилия";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(65, 73);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.firstNameLabel.TabIndex = 12;
            this.firstNameLabel.Text = "Имя";
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(40, 99);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(54, 13);
            this.secondNameLabel.TabIndex = 13;
            this.secondNameLabel.Text = "Отчество";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(8, 125);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(86, 13);
            this.birthdayLabel.TabIndex = 14;
            this.birthdayLabel.Text = "Дата рождения";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(67, 151);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(27, 13);
            this.sexLabel.TabIndex = 18;
            this.sexLabel.Text = "Пол";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(7, 177);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(87, 13);
            this.departmentLabel.TabIndex = 19;
            this.departmentLabel.Text = "Подразделение";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(100, 70);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(100, 96);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.secondNameTextBox.TabIndex = 2;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(122, 122);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(31, 20);
            this.yearTextBox.TabIndex = 3;
            this.yearTextBox.Text = "2000";
            this.yearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearTextBox_KeyPress);
            // 
            // sexComboBox
            // 
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(100, 148);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(198, 21);
            this.sexComboBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(100, 227);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(198, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Добавить сотрудника";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(195, 122);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(31, 20);
            this.monthTextBox.TabIndex = 4;
            this.monthTextBox.Text = "1";
            this.monthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.monthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthTextBox_KeyPress);
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(267, 122);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(31, 20);
            this.dayTextBox.TabIndex = 5;
            this.dayTextBox.Text = "1";
            this.dayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dayTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dayTextBox_KeyPress);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(228, 125);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(39, 13);
            this.dayLabel.TabIndex = 17;
            this.dayLabel.Text = "Число";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(155, 125);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 16;
            this.monthLabel.Text = "Месяц";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(97, 125);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(25, 13);
            this.yearLabel.TabIndex = 15;
            this.yearLabel.Text = "Год";
            // 
            // alertTextBox
            // 
            this.alertTextBox.Location = new System.Drawing.Point(99, 201);
            this.alertTextBox.Name = "alertTextBox";
            this.alertTextBox.ReadOnly = true;
            this.alertTextBox.Size = new System.Drawing.Size(198, 20);
            this.alertTextBox.TabIndex = 8;
            this.alertTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alertTextBox.Visible = false;
            // 
            // AddingEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 257);
            this.Controls.Add(this.alertTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.addButton);
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
            this.Name = "AddingEmployeeForm";
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.AddingEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ComboBox empComboBox;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox alertTextBox;
    }
}