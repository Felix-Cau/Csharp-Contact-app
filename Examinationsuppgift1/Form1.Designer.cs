namespace Examinationsuppgift1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSearchField = new TextBox();
            label4 = new Label();
            cmdSearch = new Button();
            lstSearchResult = new ListBox();
            label5 = new Label();
            txtFirstName = new TextBox();
            label6 = new Label();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtPostalCode = new TextBox();
            txtCity = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            cmdSaveToDb = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "Kontaktsamling";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(460, 20);
            label2.TabIndex = 1;
            label2.Text = "I denna applikation kan du samla dina kontakter samt redigera dem.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(736, 34);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Sökfunktion";
            // 
            // txtSearchField
            // 
            txtSearchField.Font = new Font("Segoe UI", 11F);
            txtSearchField.Location = new Point(736, 57);
            txtSearchField.Name = "txtSearchField";
            txtSearchField.Size = new Size(322, 27);
            txtSearchField.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(736, 127);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 5;
            label4.Text = "Sökresultat";
            // 
            // cmdSearch
            // 
            cmdSearch.Font = new Font("Segoe UI", 11F);
            cmdSearch.Location = new Point(963, 86);
            cmdSearch.Name = "cmdSearch";
            cmdSearch.Size = new Size(95, 36);
            cmdSearch.TabIndex = 6;
            cmdSearch.Text = "Sök";
            cmdSearch.UseVisualStyleBackColor = true;
            cmdSearch.Click += cmdSearch_Click;
            // 
            // lstSearchResult
            // 
            lstSearchResult.Font = new Font("Segoe UI", 11F);
            lstSearchResult.FormattingEnabled = true;
            lstSearchResult.ItemHeight = 20;
            lstSearchResult.Location = new Point(736, 150);
            lstSearchResult.Name = "lstSearchResult";
            lstSearchResult.Size = new Size(322, 304);
            lstSearchResult.TabIndex = 7;
            lstSearchResult.SelectedIndexChanged += lstSearchResult_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 86);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 8;
            label5.Text = "Kontaktuppgifter";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11F);
            txtFirstName.Location = new Point(12, 150);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(308, 27);
            txtFirstName.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 132);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "Förnamn";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11F);
            txtLastName.Location = new Point(12, 207);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(308, 27);
            txtLastName.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(12, 260);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(308, 27);
            txtAddress.TabIndex = 12;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Font = new Font("Segoe UI", 11F);
            txtPostalCode.Location = new Point(12, 313);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(308, 27);
            txtPostalCode.TabIndex = 13;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 11F);
            txtCity.Location = new Point(12, 366);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(308, 27);
            txtCity.TabIndex = 14;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 11F);
            txtPhoneNumber.Location = new Point(12, 419);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(308, 27);
            txtPhoneNumber.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(12, 473);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(308, 27);
            txtEmail.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 189);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 17;
            label7.Text = "Efternamn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 242);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 18;
            label8.Text = "Adress";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 295);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 19;
            label9.Text = "Postnummer";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 348);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 20;
            label10.Text = "Stad";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 401);
            label11.Name = "label11";
            label11.Size = new Size(91, 15);
            label11.TabIndex = 21;
            label11.Text = "Telefonnummer";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 455);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 22;
            label12.Text = "E-post";
            // 
            // cmdSaveToDb
            // 
            cmdSaveToDb.Font = new Font("Segoe UI", 11F);
            cmdSaveToDb.Location = new Point(12, 506);
            cmdSaveToDb.Name = "cmdSaveToDb";
            cmdSaveToDb.Size = new Size(95, 36);
            cmdSaveToDb.TabIndex = 23;
            cmdSaveToDb.Text = "Spara";
            cmdSaveToDb.UseVisualStyleBackColor = true;
            cmdSaveToDb.Click += cmdSaveToDb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 757);
            Controls.Add(cmdSaveToDb);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCity);
            Controls.Add(txtPostalCode);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(label6);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(lstSearchResult);
            Controls.Add(cmdSearch);
            Controls.Add(label4);
            Controls.Add(txtSearchField);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSearchField;
        private Label label4;
        private Button cmdSearch;
        private ListBox lstSearchResult;
        private Label label5;
        private TextBox txtFirstName;
        private Label label6;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtPostalCode;
        private TextBox txtCity;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button cmdSaveToDb;
    }
}
