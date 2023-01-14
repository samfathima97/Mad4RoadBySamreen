namespace Mad4RoadBySamreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EnterPasswordLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.LoanAmtTextBox = new System.Windows.Forms.TextBox();
            this.LoanAmtLabel = new System.Windows.Forms.Label();
            this.DetailsListBox = new System.Windows.Forms.ListBox();
            this.LoanClearButton = new System.Windows.Forms.Button();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.ClientGroupBox = new System.Windows.Forms.GroupBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumLabel = new System.Windows.Forms.Label();
            this.PostCodeLabel = new System.Windows.Forms.Label();
            this.TxnNumValueLabel = new System.Windows.Forms.Label();
            this.TxnNumLabel = new System.Windows.Forms.Label();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhNumTextBox = new System.Windows.Forms.TextBox();
            this.PostCodeTextBox = new System.Windows.Forms.TextBox();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.Label_AvgDuration = new System.Windows.Forms.Label();
            this.Label_AvgAmtBorrowed = new System.Windows.Forms.Label();
            this.Label_Totalinterest = new System.Windows.Forms.Label();
            this.Label_TotalAmtBorrowed = new System.Windows.Forms.Label();
            this.OutputAvgDurationTextBox = new System.Windows.Forms.TextBox();
            this.SummaryClearButton = new System.Windows.Forms.Button();
            this.OutputAvgAmtBorrowedTextBox = new System.Windows.Forms.TextBox();
            this.OutputTotalInterestTextBox = new System.Windows.Forms.TextBox();
            this.OutputTotalAmtBorrowedTextBox = new System.Windows.Forms.TextBox();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchResultTextBox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchEnterLabel = new System.Windows.Forms.Label();
            this.LoanCalculatorGroupBox = new System.Windows.Forms.GroupBox();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.ClientGroupBox.SuspendLayout();
            this.SummaryGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.LoanCalculatorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mad4RoadBySamreen.Properties.Resources.M4M_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(19, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EnterPasswordLabel
            // 
            this.EnterPasswordLabel.AutoSize = true;
            this.EnterPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterPasswordLabel.Location = new System.Drawing.Point(323, 44);
            this.EnterPasswordLabel.Name = "EnterPasswordLabel";
            this.EnterPasswordLabel.Size = new System.Drawing.Size(62, 15);
            this.EnterPasswordLabel.TabIndex = 1;
            this.EnterPasswordLabel.Text = "Password:";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.PassTextBox);
            this.LoginPanel.Controls.Add(this.EnterPasswordLabel);
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Location = new System.Drawing.Point(140, 142);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(574, 150);
            this.LoginPanel.TabIndex = 2;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.PowderBlue;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(416, 75);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(96, 28);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "&Login";
            this.toolTip1.SetToolTip(this.LoginButton, "Click to login");
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PassTextBox
            // 
            this.PassTextBox.AllowDrop = true;
            this.PassTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassTextBox.Location = new System.Drawing.Point(398, 39);
            this.PassTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.ShortcutsEnabled = false;
            this.PassTextBox.Size = new System.Drawing.Size(140, 27);
            this.PassTextBox.TabIndex = 2;
            this.PassTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.Color.PowderBlue;
            this.DisplayButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayButton.Location = new System.Drawing.Point(340, 34);
            this.DisplayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(82, 22);
            this.DisplayButton.TabIndex = 3;
            this.DisplayButton.Text = "&Display";
            this.toolTip1.SetToolTip(this.DisplayButton, "Click to display Loan Options");
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // LoanAmtTextBox
            // 
            this.LoanAmtTextBox.AllowDrop = true;
            this.LoanAmtTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoanAmtTextBox.Location = new System.Drawing.Point(156, 38);
            this.LoanAmtTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoanAmtTextBox.Name = "LoanAmtTextBox";
            this.LoanAmtTextBox.Size = new System.Drawing.Size(140, 27);
            this.LoanAmtTextBox.TabIndex = 2;
            this.LoanAmtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoanAmtLabel
            // 
            this.LoanAmtLabel.AutoSize = true;
            this.LoanAmtLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoanAmtLabel.Location = new System.Drawing.Point(8, 38);
            this.LoanAmtLabel.Name = "LoanAmtLabel";
            this.LoanAmtLabel.Size = new System.Drawing.Size(132, 19);
            this.LoanAmtLabel.TabIndex = 1;
            this.LoanAmtLabel.Text = "Enter Loan Amount:";
            // 
            // DetailsListBox
            // 
            this.DetailsListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetailsListBox.FormattingEnabled = true;
            this.DetailsListBox.ItemHeight = 15;
            this.DetailsListBox.Location = new System.Drawing.Point(8, 115);
            this.DetailsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DetailsListBox.Name = "DetailsListBox";
            this.DetailsListBox.Size = new System.Drawing.Size(453, 79);
            this.DetailsListBox.TabIndex = 4;
            // 
            // LoanClearButton
            // 
            this.LoanClearButton.BackColor = System.Drawing.Color.PowderBlue;
            this.LoanClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoanClearButton.Location = new System.Drawing.Point(378, 234);
            this.LoanClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoanClearButton.Name = "LoanClearButton";
            this.LoanClearButton.Size = new System.Drawing.Size(82, 22);
            this.LoanClearButton.TabIndex = 3;
            this.LoanClearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.LoanClearButton, "Click to clear list box");
            this.LoanClearButton.UseVisualStyleBackColor = false;
            this.LoanClearButton.Click += new System.EventHandler(this.LoanClearButton_Click);
            // 
            // ProceedButton
            // 
            this.ProceedButton.BackColor = System.Drawing.Color.PowderBlue;
            this.ProceedButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProceedButton.Location = new System.Drawing.Point(378, 197);
            this.ProceedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(82, 22);
            this.ProceedButton.TabIndex = 3;
            this.ProceedButton.Text = "&Proceed";
            this.toolTip1.SetToolTip(this.ProceedButton, "Click to proceed to enter client infomration");
            this.ProceedButton.UseVisualStyleBackColor = false;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // ClientGroupBox
            // 
            this.ClientGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientGroupBox.Controls.Add(this.EmailLabel);
            this.ClientGroupBox.Controls.Add(this.PhoneNumLabel);
            this.ClientGroupBox.Controls.Add(this.PostCodeLabel);
            this.ClientGroupBox.Controls.Add(this.TxnNumValueLabel);
            this.ClientGroupBox.Controls.Add(this.TxnNumLabel);
            this.ClientGroupBox.Controls.Add(this.ClientNameLabel);
            this.ClientGroupBox.Controls.Add(this.SubmitButton);
            this.ClientGroupBox.Controls.Add(this.EmailTextBox);
            this.ClientGroupBox.Controls.Add(this.PhNumTextBox);
            this.ClientGroupBox.Controls.Add(this.PostCodeTextBox);
            this.ClientGroupBox.Controls.Add(this.ClientNameTextBox);
            this.ClientGroupBox.Enabled = false;
            this.ClientGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientGroupBox.Location = new System.Drawing.Point(10, 280);
            this.ClientGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientGroupBox.Name = "ClientGroupBox";
            this.ClientGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientGroupBox.Size = new System.Drawing.Size(319, 242);
            this.ClientGroupBox.TabIndex = 5;
            this.ClientGroupBox.TabStop = false;
            this.ClientGroupBox.Text = "Client Information";
            this.ClientGroupBox.Visible = false;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(17, 142);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(86, 15);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "E-mail Address";
            // 
            // PhoneNumLabel
            // 
            this.PhoneNumLabel.AutoSize = true;
            this.PhoneNumLabel.Location = new System.Drawing.Point(17, 112);
            this.PhoneNumLabel.Name = "PhoneNumLabel";
            this.PhoneNumLabel.Size = new System.Drawing.Size(88, 15);
            this.PhoneNumLabel.TabIndex = 1;
            this.PhoneNumLabel.Text = "Phone Number";
            // 
            // PostCodeLabel
            // 
            this.PostCodeLabel.AutoSize = true;
            this.PostCodeLabel.Location = new System.Drawing.Point(17, 80);
            this.PostCodeLabel.Name = "PostCodeLabel";
            this.PostCodeLabel.Size = new System.Drawing.Size(56, 15);
            this.PostCodeLabel.TabIndex = 1;
            this.PostCodeLabel.Text = "Postcode";
            // 
            // TxnNumValueLabel
            // 
            this.TxnNumValueLabel.AutoSize = true;
            this.TxnNumValueLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxnNumValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxnNumValueLabel.Location = new System.Drawing.Point(156, 181);
            this.TxnNumValueLabel.Name = "TxnNumValueLabel";
            this.TxnNumValueLabel.Size = new System.Drawing.Size(44, 17);
            this.TxnNumValueLabel.TabIndex = 1;
            this.TxnNumValueLabel.Text = "00000";
            // 
            // TxnNumLabel
            // 
            this.TxnNumLabel.AutoSize = true;
            this.TxnNumLabel.Location = new System.Drawing.Point(15, 181);
            this.TxnNumLabel.Name = "TxnNumLabel";
            this.TxnNumLabel.Size = new System.Drawing.Size(115, 15);
            this.TxnNumLabel.TabIndex = 1;
            this.TxnNumLabel.Text = "Transaction Number";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(17, 46);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(72, 15);
            this.ClientNameLabel.TabIndex = 1;
            this.ClientNameLabel.Text = "Client Name";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.PowderBlue;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.Location = new System.Drawing.Point(118, 208);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(82, 22);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "&Submit";
            this.toolTip1.SetToolTip(this.SubmitButton, "Click to submit details");
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(140, 137);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(156, 23);
            this.EmailTextBox.TabIndex = 3;
            this.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhNumTextBox
            // 
            this.PhNumTextBox.Location = new System.Drawing.Point(140, 110);
            this.PhNumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhNumTextBox.Name = "PhNumTextBox";
            this.PhNumTextBox.Size = new System.Drawing.Size(156, 23);
            this.PhNumTextBox.TabIndex = 2;
            this.PhNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PostCodeTextBox
            // 
            this.PostCodeTextBox.Location = new System.Drawing.Point(140, 77);
            this.PostCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PostCodeTextBox.Name = "PostCodeTextBox";
            this.PostCodeTextBox.Size = new System.Drawing.Size(156, 23);
            this.PostCodeTextBox.TabIndex = 1;
            this.PostCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(140, 44);
            this.ClientNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(156, 23);
            this.ClientNameTextBox.TabIndex = 0;
            this.ClientNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.SummaryGroupBox.Controls.Add(this.SummaryButton);
            this.SummaryGroupBox.Controls.Add(this.Label_AvgDuration);
            this.SummaryGroupBox.Controls.Add(this.Label_AvgAmtBorrowed);
            this.SummaryGroupBox.Controls.Add(this.Label_Totalinterest);
            this.SummaryGroupBox.Controls.Add(this.Label_TotalAmtBorrowed);
            this.SummaryGroupBox.Controls.Add(this.OutputAvgDurationTextBox);
            this.SummaryGroupBox.Controls.Add(this.SummaryClearButton);
            this.SummaryGroupBox.Controls.Add(this.OutputAvgAmtBorrowedTextBox);
            this.SummaryGroupBox.Controls.Add(this.OutputTotalInterestTextBox);
            this.SummaryGroupBox.Controls.Add(this.OutputTotalAmtBorrowedTextBox);
            this.SummaryGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SummaryGroupBox.Location = new System.Drawing.Point(492, 9);
            this.SummaryGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SummaryGroupBox.Size = new System.Drawing.Size(373, 260);
            this.SummaryGroupBox.TabIndex = 6;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Summary";
            this.SummaryGroupBox.Visible = false;
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.Color.PowderBlue;
            this.SummaryButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SummaryButton.Location = new System.Drawing.Point(136, 197);
            this.SummaryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(82, 22);
            this.SummaryButton.TabIndex = 3;
            this.SummaryButton.Text = "&Summary";
            this.toolTip1.SetToolTip(this.SummaryButton, "Click to show summary information");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // Label_AvgDuration
            // 
            this.Label_AvgDuration.AutoSize = true;
            this.Label_AvgDuration.Location = new System.Drawing.Point(5, 155);
            this.Label_AvgDuration.Name = "Label_AvgDuration";
            this.Label_AvgDuration.Size = new System.Drawing.Size(146, 15);
            this.Label_AvgDuration.TabIndex = 1;
            this.Label_AvgDuration.Text = "Average Duration of Loan:";
            // 
            // Label_AvgAmtBorrowed
            // 
            this.Label_AvgAmtBorrowed.AutoSize = true;
            this.Label_AvgAmtBorrowed.Location = new System.Drawing.Point(6, 116);
            this.Label_AvgAmtBorrowed.Name = "Label_AvgAmtBorrowed";
            this.Label_AvgAmtBorrowed.Size = new System.Drawing.Size(154, 15);
            this.Label_AvgAmtBorrowed.TabIndex = 1;
            this.Label_AvgAmtBorrowed.Text = "Average Amount Borrowed:";
            // 
            // Label_Totalinterest
            // 
            this.Label_Totalinterest.AutoSize = true;
            this.Label_Totalinterest.Location = new System.Drawing.Point(6, 80);
            this.Label_Totalinterest.Name = "Label_Totalinterest";
            this.Label_Totalinterest.Size = new System.Drawing.Size(82, 15);
            this.Label_Totalinterest.TabIndex = 1;
            this.Label_Totalinterest.Text = "Total Interest: ";
            // 
            // Label_TotalAmtBorrowed
            // 
            this.Label_TotalAmtBorrowed.AutoSize = true;
            this.Label_TotalAmtBorrowed.Location = new System.Drawing.Point(5, 46);
            this.Label_TotalAmtBorrowed.Name = "Label_TotalAmtBorrowed";
            this.Label_TotalAmtBorrowed.Size = new System.Drawing.Size(140, 15);
            this.Label_TotalAmtBorrowed.TabIndex = 1;
            this.Label_TotalAmtBorrowed.Text = "Total Amount Borrowed: ";
            // 
            // OutputAvgDurationTextBox
            // 
            this.OutputAvgDurationTextBox.AllowDrop = true;
            this.OutputAvgDurationTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OutputAvgDurationTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputAvgDurationTextBox.Location = new System.Drawing.Point(211, 152);
            this.OutputAvgDurationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputAvgDurationTextBox.Name = "OutputAvgDurationTextBox";
            this.OutputAvgDurationTextBox.ReadOnly = true;
            this.OutputAvgDurationTextBox.Size = new System.Drawing.Size(133, 26);
            this.OutputAvgDurationTextBox.TabIndex = 2;
            this.OutputAvgDurationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SummaryClearButton
            // 
            this.SummaryClearButton.BackColor = System.Drawing.Color.PowderBlue;
            this.SummaryClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SummaryClearButton.Location = new System.Drawing.Point(136, 234);
            this.SummaryClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SummaryClearButton.Name = "SummaryClearButton";
            this.SummaryClearButton.Size = new System.Drawing.Size(82, 22);
            this.SummaryClearButton.TabIndex = 3;
            this.SummaryClearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.SummaryClearButton, "Click to clear summary information");
            this.SummaryClearButton.UseVisualStyleBackColor = false;
            this.SummaryClearButton.Click += new System.EventHandler(this.SummaryClearButton_Click);
            // 
            // OutputAvgAmtBorrowedTextBox
            // 
            this.OutputAvgAmtBorrowedTextBox.AllowDrop = true;
            this.OutputAvgAmtBorrowedTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OutputAvgAmtBorrowedTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputAvgAmtBorrowedTextBox.Location = new System.Drawing.Point(211, 116);
            this.OutputAvgAmtBorrowedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputAvgAmtBorrowedTextBox.Name = "OutputAvgAmtBorrowedTextBox";
            this.OutputAvgAmtBorrowedTextBox.ReadOnly = true;
            this.OutputAvgAmtBorrowedTextBox.Size = new System.Drawing.Size(133, 26);
            this.OutputAvgAmtBorrowedTextBox.TabIndex = 2;
            this.OutputAvgAmtBorrowedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputTotalInterestTextBox
            // 
            this.OutputTotalInterestTextBox.AllowDrop = true;
            this.OutputTotalInterestTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OutputTotalInterestTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputTotalInterestTextBox.Location = new System.Drawing.Point(211, 80);
            this.OutputTotalInterestTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputTotalInterestTextBox.Name = "OutputTotalInterestTextBox";
            this.OutputTotalInterestTextBox.ReadOnly = true;
            this.OutputTotalInterestTextBox.Size = new System.Drawing.Size(133, 26);
            this.OutputTotalInterestTextBox.TabIndex = 0;
            this.OutputTotalInterestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputTotalAmtBorrowedTextBox
            // 
            this.OutputTotalAmtBorrowedTextBox.AllowDrop = true;
            this.OutputTotalAmtBorrowedTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OutputTotalAmtBorrowedTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputTotalAmtBorrowedTextBox.Location = new System.Drawing.Point(211, 42);
            this.OutputTotalAmtBorrowedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputTotalAmtBorrowedTextBox.Name = "OutputTotalAmtBorrowedTextBox";
            this.OutputTotalAmtBorrowedTextBox.ReadOnly = true;
            this.OutputTotalAmtBorrowedTextBox.Size = new System.Drawing.Size(133, 26);
            this.OutputTotalAmtBorrowedTextBox.TabIndex = 0;
            this.OutputTotalAmtBorrowedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.SearchGroupBox.Controls.Add(this.SearchResultTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchButton);
            this.SearchGroupBox.Controls.Add(this.SearchEnterLabel);
            this.SearchGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchGroupBox.Location = new System.Drawing.Point(346, 280);
            this.SearchGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchGroupBox.Size = new System.Drawing.Size(519, 242);
            this.SearchGroupBox.TabIndex = 7;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search Transactions";
            this.SearchGroupBox.Visible = false;
            // 
            // SearchResultTextBox
            // 
            this.SearchResultTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchResultTextBox.Location = new System.Drawing.Point(18, 60);
            this.SearchResultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchResultTextBox.Multiline = true;
            this.SearchResultTextBox.Name = "SearchResultTextBox";
            this.SearchResultTextBox.ReadOnly = true;
            this.SearchResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SearchResultTextBox.Size = new System.Drawing.Size(484, 170);
            this.SearchResultTextBox.TabIndex = 0;
            this.SearchResultTextBox.WordWrap = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(256, 25);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(138, 23);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.PowderBlue;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(419, 24);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(82, 22);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "&Search";
            this.toolTip1.SetToolTip(this.SearchButton, "Click to search transaction records");
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchEnterLabel
            // 
            this.SearchEnterLabel.AutoSize = true;
            this.SearchEnterLabel.Location = new System.Drawing.Point(18, 27);
            this.SearchEnterLabel.Name = "SearchEnterLabel";
            this.SearchEnterLabel.Size = new System.Drawing.Size(207, 15);
            this.SearchEnterLabel.TabIndex = 1;
            this.SearchEnterLabel.Text = "Enter Transaction Number or Email ID";
            // 
            // LoanCalculatorGroupBox
            // 
            this.LoanCalculatorGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.LoanCalculatorGroupBox.Controls.Add(this.MessageTextBox);
            this.LoanCalculatorGroupBox.Controls.Add(this.textBox2);
            this.LoanCalculatorGroupBox.Controls.Add(this.DetailsListBox);
            this.LoanCalculatorGroupBox.Controls.Add(this.LoanAmtTextBox);
            this.LoanCalculatorGroupBox.Controls.Add(this.LoanAmtLabel);
            this.LoanCalculatorGroupBox.Controls.Add(this.DisplayButton);
            this.LoanCalculatorGroupBox.Controls.Add(this.LoanClearButton);
            this.LoanCalculatorGroupBox.Controls.Add(this.ProceedButton);
            this.LoanCalculatorGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoanCalculatorGroupBox.Location = new System.Drawing.Point(10, 9);
            this.LoanCalculatorGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoanCalculatorGroupBox.Name = "LoanCalculatorGroupBox";
            this.LoanCalculatorGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoanCalculatorGroupBox.Size = new System.Drawing.Size(466, 260);
            this.LoanCalculatorGroupBox.TabIndex = 8;
            this.LoanCalculatorGroupBox.TabStop = false;
            this.LoanCalculatorGroupBox.Text = "Loan Repayment Calculator";
            this.LoanCalculatorGroupBox.Visible = false;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(217)))), ((int)(((byte)(251)))));
            this.MessageTextBox.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MessageTextBox.Location = new System.Drawing.Point(8, 197);
            this.MessageTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ReadOnly = true;
            this.MessageTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MessageTextBox.Size = new System.Drawing.Size(365, 60);
            this.MessageTextBox.TabIndex = 9;
            this.MessageTextBox.Text = "\nLoans of  over 5 or more years receive free AA road side assitance for the durat" +
    "ion of the loan\n ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(217)))), ((int)(((byte)(251)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(8, 72);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(453, 39);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Term       Interest Rate             Monthly                  Total              " +
    "     Total \r\n                         %                   Repayment             " +
    "Interest             Repayment\r\n";
            this.textBox2.WordWrap = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.PowderBlue;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(312, 542);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(91, 32);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "&Clear All";
            this.toolTip1.SetToolTip(this.ClearButton, "Click to reset all values on screen");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Visible = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.PowderBlue;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(425, 542);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(92, 32);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "&Exit";
            this.toolTip1.SetToolTip(this.ExitButton, "Click to close application");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(886, 589);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.LoanCalculatorGroupBox);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.ClientGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Mad4Road";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ClientGroupBox.ResumeLayout(false);
            this.ClientGroupBox.PerformLayout();
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.LoanCalculatorGroupBox.ResumeLayout(false);
            this.LoanCalculatorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label EnterPasswordLabel;
        private Panel LoginPanel;
        private TextBox PassTextBox;
        private Button LoginButton;
        private Button DisplayButton;
        private TextBox LoanAmtTextBox;
        private Label LoanAmtLabel;
        private ListBox DetailsListBox;
        private Button LoanClearButton;
        private Button ProceedButton;
        private GroupBox ClientGroupBox;
        private Label EmailLabel;
        private Label PhoneNumLabel;
        private Label PostCodeLabel;
        private Label ClientNameLabel;
        private TextBox ClientNameTextBox;
        private TextBox EmailTextBox;
        private TextBox PhNumTextBox;
        private TextBox PostCodeTextBox;
        private Label TxnNumValueLabel;
        private Label TxnNumLabel;
        private Button SubmitButton;
        private GroupBox SummaryGroupBox;
        private Button SummaryButton;
        private GroupBox SearchGroupBox;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private TextBox SearchResultTextBox;
        private Label Label_AvgDuration;
        private Label Label_AvgAmtBorrowed;
        private Label Label_Totalinterest;
        private Label Label_TotalAmtBorrowed;
        private TextBox OutputAvgDurationTextBox;
        private TextBox OutputAvgAmtBorrowedTextBox;
        private TextBox OutputTotalInterestTextBox;
        private TextBox OutputTotalAmtBorrowedTextBox;
        private GroupBox LoanCalculatorGroupBox;
        private TextBox textBox2;
        private Button SummaryClearButton;
        private Label SearchEnterLabel;
        private RichTextBox MessageTextBox;
        private Button ClearButton;
        private Button ExitButton;
        private ToolTip toolTip1;
    }
}