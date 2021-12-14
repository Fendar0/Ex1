namespace Ex1
{
    partial class FormADD
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
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.tbPnonenumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btApply = new System.Windows.Forms.Button();
            this.tbDisableAuthor = new System.Windows.Forms.TextBox();
            this.ckDisable = new System.Windows.Forms.CheckBox();
            this.dtDateBirth = new System.Windows.Forms.DateTimePicker();
            this.dtDisableDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(12, 12);
            this.tbSurname.Multiline = true;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(180, 34);
            this.tbSurname.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(12, 52);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 34);
            this.tbName.TabIndex = 1;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPatronymic.Location = new System.Drawing.Point(12, 92);
            this.tbPatronymic.Multiline = true;
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(180, 34);
            this.tbPatronymic.TabIndex = 2;
            // 
            // tbPnonenumber
            // 
            this.tbPnonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPnonenumber.Location = new System.Drawing.Point(12, 132);
            this.tbPnonenumber.Multiline = true;
            this.tbPnonenumber.Name = "tbPnonenumber";
            this.tbPnonenumber.Size = new System.Drawing.Size(180, 35);
            this.tbPnonenumber.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.Location = new System.Drawing.Point(12, 208);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(180, 34);
            this.tbEmail.TabIndex = 5;
            // 
            // btApply
            // 
            this.btApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btApply.Location = new System.Drawing.Point(212, 324);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(133, 33);
            this.btApply.TabIndex = 8;
            this.btApply.Text = "Apply";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // tbDisableAuthor
            // 
            this.tbDisableAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDisableAuthor.Location = new System.Drawing.Point(12, 318);
            this.tbDisableAuthor.Multiline = true;
            this.tbDisableAuthor.Name = "tbDisableAuthor";
            this.tbDisableAuthor.Size = new System.Drawing.Size(180, 34);
            this.tbDisableAuthor.TabIndex = 11;
            // 
            // ckDisable
            // 
            this.ckDisable.AutoSize = true;
            this.ckDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ckDisable.Location = new System.Drawing.Point(13, 249);
            this.ckDisable.Name = "ckDisable";
            this.ckDisable.Size = new System.Drawing.Size(91, 28);
            this.ckDisable.TabIndex = 12;
            this.ckDisable.Text = "Disable";
            this.ckDisable.UseVisualStyleBackColor = true;
            // 
            // dtDateBirth
            // 
            this.dtDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDateBirth.Location = new System.Drawing.Point(12, 173);
            this.dtDateBirth.Name = "dtDateBirth";
            this.dtDateBirth.Size = new System.Drawing.Size(179, 29);
            this.dtDateBirth.TabIndex = 17;
            // 
            // dtDisableDate
            // 
            this.dtDisableDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDisableDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtDisableDate.Location = new System.Drawing.Point(12, 283);
            this.dtDisableDate.Name = "dtDisableDate";
            this.dtDisableDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDisableDate.Size = new System.Drawing.Size(179, 29);
            this.dtDisableDate.TabIndex = 18;
            // 
            // FormADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 369);
            this.Controls.Add(this.dtDisableDate);
            this.Controls.Add(this.dtDateBirth);
            this.Controls.Add(this.ckDisable);
            this.Controls.Add(this.tbDisableAuthor);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPnonenumber);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Name = "FormADD";
            this.Text = "FormADD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.TextBox tbPnonenumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.TextBox tbDisableAuthor;
        private System.Windows.Forms.CheckBox ckDisable;
        private System.Windows.Forms.DateTimePicker dtDateBirth;
        private System.Windows.Forms.DateTimePicker dtDisableDate;
    }
}