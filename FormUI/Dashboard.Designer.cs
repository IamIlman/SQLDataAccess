namespace FormUI
{
    partial class Dashboard
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
            this.peopleFound = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsLabel = new System.Windows.Forms.Label();
            this.PhoneNumberInsText = new System.Windows.Forms.TextBox();
            this.EmailAdressInsLabel = new System.Windows.Forms.Label();
            this.EmailAdressInsText = new System.Windows.Forms.TextBox();
            this.LastNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.InsertData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFound
            // 
            this.peopleFound.FormattingEnabled = true;
            this.peopleFound.Location = new System.Drawing.Point(32, 99);
            this.peopleFound.Name = "peopleFound";
            this.peopleFound.Size = new System.Drawing.Size(279, 160);
            this.peopleFound.TabIndex = 0;
            this.peopleFound.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(211, 44);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(100, 20);
            this.LastNameText.TabIndex = 1;
            this.LastNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(147, 51);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(236, 70);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(397, 113);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(100, 20);
            this.firstNameInsText.TabIndex = 4;
            this.firstNameInsText.TextChanged += new System.EventHandler(this.firstNameInsText_TextChanged);
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(333, 120);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameInsLabel.TabIndex = 5;
            this.firstNameInsLabel.Text = "First Name";
            this.firstNameInsLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // phoneNumberInsLabel
            // 
            this.phoneNumberInsLabel.AutoSize = true;
            this.phoneNumberInsLabel.Location = new System.Drawing.Point(333, 198);
            this.phoneNumberInsLabel.Name = "phoneNumberInsLabel";
            this.phoneNumberInsLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneNumberInsLabel.TabIndex = 7;
            this.phoneNumberInsLabel.Text = "Phone";
            // 
            // PhoneNumberInsText
            // 
            this.PhoneNumberInsText.Location = new System.Drawing.Point(397, 191);
            this.PhoneNumberInsText.Name = "PhoneNumberInsText";
            this.PhoneNumberInsText.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumberInsText.TabIndex = 6;
            // 
            // EmailAdressInsLabel
            // 
            this.EmailAdressInsLabel.AutoSize = true;
            this.EmailAdressInsLabel.Location = new System.Drawing.Point(333, 172);
            this.EmailAdressInsLabel.Name = "EmailAdressInsLabel";
            this.EmailAdressInsLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailAdressInsLabel.TabIndex = 9;
            this.EmailAdressInsLabel.Text = "Email";
            this.EmailAdressInsLabel.Click += new System.EventHandler(this.EmailAdressInsLabel_Click);
            // 
            // EmailAdressInsText
            // 
            this.EmailAdressInsText.Location = new System.Drawing.Point(397, 165);
            this.EmailAdressInsText.Name = "EmailAdressInsText";
            this.EmailAdressInsText.Size = new System.Drawing.Size(100, 20);
            this.EmailAdressInsText.TabIndex = 8;
            // 
            // LastNameInsLabel
            // 
            this.LastNameInsLabel.AutoSize = true;
            this.LastNameInsLabel.Location = new System.Drawing.Point(333, 146);
            this.LastNameInsLabel.Name = "LastNameInsLabel";
            this.LastNameInsLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameInsLabel.TabIndex = 11;
            this.LastNameInsLabel.Text = "Last Name";
            this.LastNameInsLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(397, 139);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(100, 20);
            this.lastNameInsText.TabIndex = 10;
            // 
            // InsertData
            // 
            this.InsertData.Location = new System.Drawing.Point(336, 236);
            this.InsertData.Name = "InsertData";
            this.InsertData.Size = new System.Drawing.Size(75, 23);
            this.InsertData.TabIndex = 12;
            this.InsertData.Text = "Insert";
            this.InsertData.UseVisualStyleBackColor = true;
            this.InsertData.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 297);
            this.Controls.Add(this.InsertData);
            this.Controls.Add(this.LastNameInsLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.EmailAdressInsLabel);
            this.Controls.Add(this.EmailAdressInsText);
            this.Controls.Add(this.phoneNumberInsLabel);
            this.Controls.Add(this.PhoneNumberInsText);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.peopleFound);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFound;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.Label phoneNumberInsLabel;
        private System.Windows.Forms.TextBox PhoneNumberInsText;
        private System.Windows.Forms.Label EmailAdressInsLabel;
        private System.Windows.Forms.TextBox EmailAdressInsText;
        private System.Windows.Forms.Label LastNameInsLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Button InsertData;
    }
}

