using AbsenceTrackerLibrary.Models;

namespace AbsenceTrackerUI.Forms
{
    partial class AbsenceTrackerDashboard
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
            this.components = new System.ComponentModel.Container();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.AbsencesDataGridView = new System.Windows.Forms.DataGridView();
            this.absenceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AbsencesLabel = new System.Windows.Forms.Label();
            this.DaysOffBalanceLabel = new System.Windows.Forms.Label();
            this.DaysOffBalanceTextBox = new System.Windows.Forms.TextBox();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.NewAbsenceButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.absenceModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AbsenceTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectiveFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiresOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysWorkedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AbsencesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceModelBindingSource)).BeginInit();
            this.LoginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absenceModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Enabled = false;
            this.FullNameTextBox.Location = new System.Drawing.Point(172, 151);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(313, 32);
            this.FullNameTextBox.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(12, 154);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(97, 25);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Full Name";
            // 
            // AbsencesDataGridView
            // 
            this.AbsencesDataGridView.AllowUserToAddRows = false;
            this.AbsencesDataGridView.AutoGenerateColumns = false;
            this.AbsencesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.AbsencesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbsencesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AbsenceTypeColumn,
            this.EffectiveFromColumn,
            this.ExpiresOnColumn,
            this.DaysTotal,
            this.DaysWorkedColumn,
            this.DetailsButtonColumn,
            this.RemoveButtonColumn});
            this.AbsencesDataGridView.DataSource = this.absenceModelBindingSource;
            this.AbsencesDataGridView.Location = new System.Drawing.Point(17, 247);
            this.AbsencesDataGridView.Name = "AbsencesDataGridView";
            this.AbsencesDataGridView.RowHeadersWidth = 51;
            this.AbsencesDataGridView.Size = new System.Drawing.Size(821, 294);
            this.AbsencesDataGridView.TabIndex = 4;
            this.AbsencesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AbsencesDataGridView_CellContentClick);
            // 
            // absenceModelBindingSource
            // 
            this.absenceModelBindingSource.DataSource = typeof(AbsenceTrackerLibrary.Models.AbsenceModel);
            // 
            // AbsencesLabel
            // 
            this.AbsencesLabel.AutoSize = true;
            this.AbsencesLabel.Location = new System.Drawing.Point(12, 219);
            this.AbsencesLabel.Name = "AbsencesLabel";
            this.AbsencesLabel.Size = new System.Drawing.Size(91, 25);
            this.AbsencesLabel.TabIndex = 2;
            this.AbsencesLabel.Text = "Absences";
            // 
            // DaysOffBalanceLabel
            // 
            this.DaysOffBalanceLabel.AutoSize = true;
            this.DaysOffBalanceLabel.Location = new System.Drawing.Point(12, 187);
            this.DaysOffBalanceLabel.Name = "DaysOffBalanceLabel";
            this.DaysOffBalanceLabel.Size = new System.Drawing.Size(154, 25);
            this.DaysOffBalanceLabel.TabIndex = 2;
            this.DaysOffBalanceLabel.Text = "Days Off Balance";
            // 
            // DaysOffBalanceTextBox
            // 
            this.DaysOffBalanceTextBox.Enabled = false;
            this.DaysOffBalanceTextBox.Location = new System.Drawing.Point(172, 184);
            this.DaysOffBalanceTextBox.Name = "DaysOffBalanceTextBox";
            this.DaysOffBalanceTextBox.Size = new System.Drawing.Size(83, 32);
            this.DaysOffBalanceTextBox.TabIndex = 3;
            // 
            // EditPersonalDataButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(512, 149);
            this.EditUserButton.Name = "EditPersonalDataButton";
            this.EditUserButton.Size = new System.Drawing.Size(189, 34);
            this.EditUserButton.TabIndex = 5;
            this.EditUserButton.Text = "Edit Personal Data";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // NewAbsenceButton
            // 
            this.NewAbsenceButton.Location = new System.Drawing.Point(512, 189);
            this.NewAbsenceButton.Name = "NewAbsenceButton";
            this.NewAbsenceButton.Size = new System.Drawing.Size(189, 34);
            this.NewAbsenceButton.TabIndex = 6;
            this.NewAbsenceButton.Text = "New Absence";
            this.NewAbsenceButton.UseVisualStyleBackColor = true;
            this.NewAbsenceButton.Click += new System.EventHandler(this.NewAbsenceButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AbsenceType";
            this.dataGridViewTextBoxColumn1.HeaderText = "Type";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(25, 32);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(97, 25);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(106, 29);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(242, 32);
            this.UsernameTextBox.TabIndex = 8;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(354, 63);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 27);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.PasswordTextBox);
            this.LoginGroupBox.Controls.Add(this.PasswordLabel);
            this.LoginGroupBox.Controls.Add(this.UsernameLabel);
            this.LoginGroupBox.Controls.Add(this.LoginButton);
            this.LoginGroupBox.Controls.Add(this.UsernameTextBox);
            this.LoginGroupBox.Location = new System.Drawing.Point(12, 12);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(458, 114);
            this.LoginGroupBox.TabIndex = 10;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Log in";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(106, 63);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(242, 32);
            this.PasswordTextBox.TabIndex = 11;
            this.PasswordTextBox.Text = "to be implemented";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(25, 66);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(91, 25);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password";
            // 
            // absenceModelBindingSource1
            // 
            this.absenceModelBindingSource1.DataSource = typeof(AbsenceTrackerLibrary.Models.AbsenceModel);
            // 
            // AbsenceTypeColumn
            // 
            this.AbsenceTypeColumn.DataPropertyName = "AbsenceType";
            this.AbsenceTypeColumn.HeaderText = "Type";
            this.AbsenceTypeColumn.MinimumWidth = 6;
            this.AbsenceTypeColumn.Name = "AbsenceTypeColumn";
            this.AbsenceTypeColumn.ReadOnly = true;
            this.AbsenceTypeColumn.Width = 125;
            // 
            // EffectiveFromColumn
            // 
            this.EffectiveFromColumn.DataPropertyName = "EffectiveFrom";
            this.EffectiveFromColumn.HeaderText = "Effective From";
            this.EffectiveFromColumn.MinimumWidth = 6;
            this.EffectiveFromColumn.Name = "EffectiveFromColumn";
            this.EffectiveFromColumn.ReadOnly = true;
            this.EffectiveFromColumn.Width = 125;
            // 
            // ExpiresOnColumn
            // 
            this.ExpiresOnColumn.DataPropertyName = "ExpiresOn";
            this.ExpiresOnColumn.HeaderText = "Expires On";
            this.ExpiresOnColumn.MinimumWidth = 6;
            this.ExpiresOnColumn.Name = "ExpiresOnColumn";
            this.ExpiresOnColumn.ReadOnly = true;
            this.ExpiresOnColumn.Width = 125;
            // 
            // DaysTotal
            // 
            this.DaysTotal.DataPropertyName = "DaysTotal";
            this.DaysTotal.HeaderText = "Days Total";
            this.DaysTotal.MinimumWidth = 6;
            this.DaysTotal.Name = "DaysTotal";
            this.DaysTotal.ReadOnly = true;
            this.DaysTotal.Width = 125;
            // 
            // DaysWorkedColumn
            // 
            this.DaysWorkedColumn.DataPropertyName = "DaysWorkedOnHolidays";
            this.DaysWorkedColumn.HeaderText = "Days Worked";
            this.DaysWorkedColumn.MinimumWidth = 6;
            this.DaysWorkedColumn.Name = "DaysWorkedColumn";
            this.DaysWorkedColumn.ReadOnly = true;
            this.DaysWorkedColumn.Width = 125;
            // 
            // DetailsButtonColumn
            // 
            this.DetailsButtonColumn.HeaderText = "";
            this.DetailsButtonColumn.MinimumWidth = 6;
            this.DetailsButtonColumn.Name = "DetailsButtonColumn";
            this.DetailsButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DetailsButtonColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DetailsButtonColumn.Text = "Details";
            this.DetailsButtonColumn.UseColumnTextForButtonValue = true;
            this.DetailsButtonColumn.Width = 70;
            // 
            // RemoveButtonColumn
            // 
            this.RemoveButtonColumn.HeaderText = "";
            this.RemoveButtonColumn.MinimumWidth = 6;
            this.RemoveButtonColumn.Name = "RemoveButtonColumn";
            this.RemoveButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RemoveButtonColumn.Text = "Remove";
            this.RemoveButtonColumn.UseColumnTextForButtonValue = true;
            this.RemoveButtonColumn.Width = 70;
            // 
            // AbsenceTrackerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 557);
            this.Controls.Add(this.LoginGroupBox);
            this.Controls.Add(this.NewAbsenceButton);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.AbsencesDataGridView);
            this.Controls.Add(this.DaysOffBalanceTextBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.DaysOffBalanceLabel);
            this.Controls.Add(this.AbsencesLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AbsenceTrackerDashboard";
            this.Text = "Absence Tracker Dashboard";
            this.Activated += new System.EventHandler(this.AbsenceTrackerDashboard_Activated);
            this.Load += new System.EventHandler(this.AbsenceTrackerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AbsencesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceModelBindingSource)).EndInit();
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absenceModelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.DataGridView AbsencesDataGridView;
        private System.Windows.Forms.Label AbsencesLabel;
        private System.Windows.Forms.Label DaysOffBalanceLabel;
        private System.Windows.Forms.TextBox DaysOffBalanceTextBox;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Button NewAbsenceButton;
        private System.Windows.Forms.BindingSource absenceModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbsenceTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveFromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiresOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysWorkedColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DetailsButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveButtonColumn;
        private System.Windows.Forms.BindingSource absenceModelBindingSource1;
    }
}

