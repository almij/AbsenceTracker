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
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.AbsencesDataGridView = new System.Windows.Forms.DataGridView();
            this.AbsenceTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectiveFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiresOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysWorkedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AbsencesLabel = new System.Windows.Forms.Label();
            this.DaysOffBalanceLabel = new System.Windows.Forms.Label();
            this.DaysOffBalanceTextBox = new System.Windows.Forms.TextBox();
            this.EditPersonalDataButton = new System.Windows.Forms.Button();
            this.NewAbsenceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AbsencesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Enabled = false;
            this.FullNameTextBox.Location = new System.Drawing.Point(155, 12);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(313, 27);
            this.FullNameTextBox.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(12, 15);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(76, 20);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Full Name";
            this.FullNameLabel.Click += new System.EventHandler(this.FirstNameLabel_Click);
            // 
            // AbsencesDataGridView
            // 
            this.AbsencesDataGridView.AllowUserToAddRows = false;
            this.AbsencesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.AbsencesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbsencesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AbsenceTypeColumn,
            this.EffectiveFromColumn,
            this.ExpiresOnColumn,
            this.DaysWorkedColumn,
            this.DetailsButtonColumn,
            this.RemoveButtonColumn});
            this.AbsencesDataGridView.Location = new System.Drawing.Point(12, 103);
            this.AbsencesDataGridView.Name = "AbsencesDataGridView";
            this.AbsencesDataGridView.Size = new System.Drawing.Size(644, 294);
            this.AbsencesDataGridView.TabIndex = 4;
            this.AbsencesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // AbsenceTypeColumn
            // 
            this.AbsenceTypeColumn.HeaderText = "Type";
            this.AbsenceTypeColumn.Name = "AbsenceTypeColumn";
            this.AbsenceTypeColumn.ReadOnly = true;
            // 
            // EffectiveFromColumn
            // 
            this.EffectiveFromColumn.HeaderText = "Effective From";
            this.EffectiveFromColumn.Name = "EffectiveFromColumn";
            this.EffectiveFromColumn.ReadOnly = true;
            // 
            // ExpiresOnColumn
            // 
            this.ExpiresOnColumn.HeaderText = "Expires On";
            this.ExpiresOnColumn.Name = "ExpiresOnColumn";
            this.ExpiresOnColumn.ReadOnly = true;
            // 
            // DaysWorkedColumn
            // 
            this.DaysWorkedColumn.HeaderText = "Days Worked";
            this.DaysWorkedColumn.Name = "DaysWorkedColumn";
            this.DaysWorkedColumn.ReadOnly = true;
            // 
            // DetailsButtonColumn
            // 
            this.DetailsButtonColumn.HeaderText = "Details";
            this.DetailsButtonColumn.Name = "DetailsButtonColumn";
            this.DetailsButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailsButtonColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RemoveButtonColumn
            // 
            this.RemoveButtonColumn.HeaderText = "Remove";
            this.RemoveButtonColumn.Name = "RemoveButtonColumn";
            // 
            // AbsencesLabel
            // 
            this.AbsencesLabel.AutoSize = true;
            this.AbsencesLabel.Location = new System.Drawing.Point(12, 80);
            this.AbsencesLabel.Name = "AbsencesLabel";
            this.AbsencesLabel.Size = new System.Drawing.Size(71, 20);
            this.AbsencesLabel.TabIndex = 2;
            this.AbsencesLabel.Text = "Absences";
            this.AbsencesLabel.Click += new System.EventHandler(this.FirstNameLabel_Click);
            // 
            // DaysOffBalanceLabel
            // 
            this.DaysOffBalanceLabel.AutoSize = true;
            this.DaysOffBalanceLabel.Location = new System.Drawing.Point(12, 48);
            this.DaysOffBalanceLabel.Name = "DaysOffBalanceLabel";
            this.DaysOffBalanceLabel.Size = new System.Drawing.Size(122, 20);
            this.DaysOffBalanceLabel.TabIndex = 2;
            this.DaysOffBalanceLabel.Text = "Days Off Balance";
            this.DaysOffBalanceLabel.Click += new System.EventHandler(this.FirstNameLabel_Click);
            // 
            // DaysOffBalanceTextBox
            // 
            this.DaysOffBalanceTextBox.Enabled = false;
            this.DaysOffBalanceTextBox.Location = new System.Drawing.Point(155, 45);
            this.DaysOffBalanceTextBox.Name = "DaysOffBalanceTextBox";
            this.DaysOffBalanceTextBox.Size = new System.Drawing.Size(83, 27);
            this.DaysOffBalanceTextBox.TabIndex = 3;
            // 
            // EditPersonalDataButton
            // 
            this.EditPersonalDataButton.Location = new System.Drawing.Point(515, 8);
            this.EditPersonalDataButton.Name = "EditPersonalDataButton";
            this.EditPersonalDataButton.Size = new System.Drawing.Size(139, 34);
            this.EditPersonalDataButton.TabIndex = 5;
            this.EditPersonalDataButton.Text = "Edit Personal Data";
            this.EditPersonalDataButton.UseVisualStyleBackColor = true;
            this.EditPersonalDataButton.Click += new System.EventHandler(this.EditPersonalDataButton_Click);
            // 
            // NewAbsenceButton
            // 
            this.NewAbsenceButton.Location = new System.Drawing.Point(515, 48);
            this.NewAbsenceButton.Name = "NewAbsenceButton";
            this.NewAbsenceButton.Size = new System.Drawing.Size(139, 34);
            this.NewAbsenceButton.TabIndex = 6;
            this.NewAbsenceButton.Text = "New Absence";
            this.NewAbsenceButton.UseVisualStyleBackColor = true;
            this.NewAbsenceButton.Click += new System.EventHandler(this.NewAbsenceButton_Click);
            // 
            // AbsenceTrackerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 409);
            this.Controls.Add(this.NewAbsenceButton);
            this.Controls.Add(this.EditPersonalDataButton);
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
            this.Load += new System.EventHandler(this.AbsenceTrackerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AbsencesDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn AbsenceTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveFromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiresOnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysWorkedColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DetailsButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveButtonColumn;
        private System.Windows.Forms.Button EditPersonalDataButton;
        private System.Windows.Forms.Button NewAbsenceButton;
    }
}

