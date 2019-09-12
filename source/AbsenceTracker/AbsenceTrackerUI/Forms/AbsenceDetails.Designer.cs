namespace AbsenceTrackerUI.Forms
{
    partial class AbsenceDetails
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
            this.AbsenceTypeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EffectiveFromLabel = new System.Windows.Forms.Label();
            this.EffectiveFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpiresOnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DaysWorkedOnHolidaysLabel = new System.Windows.Forms.Label();
            this.CancelChangesButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AbsenceTypeLabel
            // 
            this.AbsenceTypeLabel.AutoSize = true;
            this.AbsenceTypeLabel.Location = new System.Drawing.Point(13, 13);
            this.AbsenceTypeLabel.Name = "AbsenceTypeLabel";
            this.AbsenceTypeLabel.Size = new System.Drawing.Size(100, 20);
            this.AbsenceTypeLabel.TabIndex = 0;
            this.AbsenceTypeLabel.Text = "Absence Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // EffectiveFromLabel
            // 
            this.EffectiveFromLabel.AutoSize = true;
            this.EffectiveFromLabel.Location = new System.Drawing.Point(13, 50);
            this.EffectiveFromLabel.Name = "EffectiveFromLabel";
            this.EffectiveFromLabel.Size = new System.Drawing.Size(104, 20);
            this.EffectiveFromLabel.TabIndex = 2;
            this.EffectiveFromLabel.Text = "Effective From";
            // 
            // EffectiveFromDateTimePicker
            // 
            this.EffectiveFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EffectiveFromDateTimePicker.Location = new System.Drawing.Point(200, 45);
            this.EffectiveFromDateTimePicker.Name = "EffectiveFromDateTimePicker";
            this.EffectiveFromDateTimePicker.Size = new System.Drawing.Size(195, 27);
            this.EffectiveFromDateTimePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expires On";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ExpiresOnDateTimePicker
            // 
            this.ExpiresOnDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpiresOnDateTimePicker.Location = new System.Drawing.Point(200, 78);
            this.ExpiresOnDateTimePicker.Name = "ExpiresOnDateTimePicker";
            this.ExpiresOnDateTimePicker.Size = new System.Drawing.Size(195, 27);
            this.ExpiresOnDateTimePicker.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 27);
            this.textBox1.TabIndex = 4;
            // 
            // DaysWorkedOnHolidaysLabel
            // 
            this.DaysWorkedOnHolidaysLabel.AutoSize = true;
            this.DaysWorkedOnHolidaysLabel.Location = new System.Drawing.Point(13, 115);
            this.DaysWorkedOnHolidaysLabel.Name = "DaysWorkedOnHolidaysLabel";
            this.DaysWorkedOnHolidaysLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DaysWorkedOnHolidaysLabel.Size = new System.Drawing.Size(181, 20);
            this.DaysWorkedOnHolidaysLabel.TabIndex = 2;
            this.DaysWorkedOnHolidaysLabel.Text = "Days Worked On Holidays";
            this.DaysWorkedOnHolidaysLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // CancelChangesButton
            // 
            this.CancelChangesButton.Location = new System.Drawing.Point(183, 208);
            this.CancelChangesButton.Name = "CancelChangesButton";
            this.CancelChangesButton.Size = new System.Drawing.Size(155, 47);
            this.CancelChangesButton.TabIndex = 11;
            this.CancelChangesButton.Text = "Cancel";
            this.CancelChangesButton.UseVisualStyleBackColor = true;
            this.CancelChangesButton.Click += new System.EventHandler(this.CancelChangesButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(17, 208);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(155, 47);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AbsenceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 267);
            this.Controls.Add(this.CancelChangesButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExpiresOnDateTimePicker);
            this.Controls.Add(this.DaysWorkedOnHolidaysLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EffectiveFromDateTimePicker);
            this.Controls.Add(this.EffectiveFromLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AbsenceTypeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AbsenceDetails";
            this.Text = "Absence Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AbsenceTypeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label EffectiveFromLabel;
        private System.Windows.Forms.DateTimePicker EffectiveFromDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ExpiresOnDateTimePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DaysWorkedOnHolidaysLabel;
        private System.Windows.Forms.Button CancelChangesButton;
        private System.Windows.Forms.Button SaveButton;
    }
}