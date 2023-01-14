/* Student Name: Samreen Fathima
 * Student ID: 22101335
 * Date:8/11/2022
 * Assignment: 3
 * Assignment: Create a software that processes loan requests and stores transaction records to a file
 * and reads from the file to generate summary information.
 */

using System.IO;
namespace Mad4RoadBySamreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaring and assigning constant variables
        const decimal FIRST_TERM = 1m;
        const decimal SECOND_TERM = 3m;
        const decimal THIRD_TERM = 5m;
        const decimal FOURTH_TERM = 7m;
        const decimal INT_RATE11 = 6.00m; const decimal INT_RATE13 = 6.50m; const decimal INT_RATE15 = 7.00m;
        const decimal INT_RATE17 = 7.50m; const decimal INT_RATE23 = 8.50m; const decimal INT_RATE25 = 9.00m;
        const decimal INT_RATE27 = 9.50m;
        const decimal INT_RATE21 = 8.00m;
        const decimal INT_RATE31 = 8.50m; const decimal INT_RATE33 = 8.75m; const decimal INT_RATE35 = 9.10m;
        const decimal INT_RATE37 = 9.25m;
        const string PASS_WORD = "2Fast4U#";
        const decimal NumberOfMonths = 12;
        //initialzing login variable to allow only 2 attempts
        int LoginCount = 0;

        //Below variables declared for calculations and are called in multiple methods
        decimal MonthlyRepayment, LoanAmt, TotalInterest, NumberOfPayments, TotalRepayment;

        //Variable for random transaction number, called in multiple methods
        int TransNum;

        //Variables used to assign values after every calcuation method call
        decimal F_IntRate1, F_IntRate2, F_IntRate3, F_IntRate4;
        decimal F_MonthlyRepayment1, F_MonthlyRepayment2, F_MonthlyRepayment3, F_MonthlyRepayment4;
        decimal F_TotalInterest1, F_TotalInterest2, F_TotalInterest3, F_TotalInterest4;
        decimal F_TotalRepayment1, F_TotalRepayment2, F_TotalRepayment3, F_TotalRepayment4;

        //File name variable
        const string FILENAME = "TransactionRecords.txt";

        //Format string spacing in loan details list box
        String ListBoxFormatting = "{0,-20}{1,-25}{2,-25}{3,-20}{4,-20}";

        //Reader object globally declared as it's accessed by 2 methods/events
        StreamReader IpFile;

        //Variables used in switch case to assign depending on selected index in list box
        decimal Term_Conf, InterestRate_Conf, TotalInterest_Conf, MonthlyRepayment_Conf, TotalRepayment_Conf;




        private void CalcAndDisplay(decimal Term, decimal InterestRate, decimal Principal)
        {
            //Variable A is exponent part of the formula which is calculated separately and stored
            decimal MonthlyInterest = 0m; decimal A;


            //EMI calculation
            NumberOfPayments = Term * NumberOfMonths;
            MonthlyInterest = (InterestRate / NumberOfMonths) / 100;
            A = (decimal)(Math.Pow((double)(1 + MonthlyInterest), (double)NumberOfPayments));
            MonthlyRepayment = (Principal * MonthlyInterest * A) / (A - 1);
            //Total Repayment calculation 
            TotalRepayment = MonthlyRepayment * NumberOfPayments;
            //Total Interest calculation
            TotalInterest = TotalRepayment - Principal;

            //Display values to list box
            DetailsListBox.Items.Add(String.Format(ListBoxFormatting, Term.ToString(), InterestRate.ToString() + "%",
            MonthlyRepayment.ToString("C2"), TotalInterest.ToString("C2"), TotalRepayment.ToString("C2")));


        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchResultTextBox.Clear();
            string TransactionNumber; string Mail;
            bool RecordFound = false;
            int NumberOfLinesPerRecord = 11;


            //Check if textbox is empty
            if (!string.IsNullOrEmpty(SearchTextBox.Text))
            {
                if (CheckIfFileExists())
                {



                    try
                    {
                        //Open file to start reading
                        IpFile = File.OpenText(FILENAME);
                        while (!IpFile.EndOfStream)
                        {
                            //Assign line 1 to transaction number variable
                            TransactionNumber = IpFile.ReadLine();
                            //Assign line 2 to mail variable
                            
                            Mail = IpFile.ReadLine();
                            //Check if either of these values matched the value entered in search text box
                            if (Mail == SearchTextBox.Text || TransactionNumber == SearchTextBox.Text)
                            {
                                RecordFound = true;
                            }
                            if (RecordFound)
                            {
                                //Display values in read-only textbox
                                SearchResultTextBox.Text = "Transaction Number:\t" + TransactionNumber +
                                    "\r\nE-mail ID:\t\t\t" + Mail +
                                    "\r\nClient Name:\t\t" + IpFile.ReadLine() +
                                    "\r\nPhone Number:\t\t" + IpFile.ReadLine() +
                                    "\r\nPostal code:\t\t" + IpFile.ReadLine() +
                                    "\r\nInterest Rate:\t\t" + IpFile.ReadLine() + "%" +
                                    "\r\nMonthly Repayment:\t\t" + "€"+IpFile.ReadLine() +
                                    "\r\nTotal Repayment:\t\t" + "€"+IpFile.ReadLine() +
                                    "\r\nPrincipal Amount:\t\t" + "€"+IpFile.ReadLine() +
                                    "\r\nTerm:\t\t\t" + IpFile.ReadLine() +
                                    "\r\nTotal Interest:\t\t" + "€"+IpFile.ReadLine();
                            }
                            else
                            {
                                //if not matching, skip next 8 lines to avoid assigning on every line read
                                for (int LineNo = 3; LineNo <= NumberOfLinesPerRecord; LineNo++)
                                {
                                    IpFile.ReadLine();
                                }
                            }
                        }
                        if (RecordFound == false)
                        {
                            MessageBox.Show("Record not found", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("File does not exist", "No file found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Enter a search ID", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SearchTextBox.Focus();
            }
        }

        private int GenerateRandomNumber()
        {
            int Random_Number;
            //use method to generate random number
            Random RandNum = new Random();
            //first generate the number then check if it already exists in the file
            do
            {
                Random_Number = RandNum.Next(10000, 99999);
            } while (CheckIfTxnNumExists(Random_Number));//function is called and number is passed to verify if it already exists in the file

            return Random_Number;
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            //check if file exists by calling the method
            if (CheckIfFileExists())
            {


                //initialize summary variables
                int TotalNoOfTransactions_Summary = 0;
                decimal TotalAmtBorrowed_Summary = 0m; decimal TotalInterest_Summary = 0m;
                decimal AvgAmtBorrowed_Summary, AvgDurationInMonths_Summary, Term_Summary = 0m, TermInMonths;
                decimal LoanRecord, TermRecord, TotalInterestRecord;
                try
                {
                    IpFile = File.OpenText(FILENAME);
                    {
                        while (!IpFile.EndOfStream)
                        {
                            //Skips 8 lines which has values which are not considered for Summary Calc
                            for (int LineNo = 1; LineNo <= 8; LineNo++)
                            {
                                IpFile.ReadLine();
                            }
                            //Assign last 3 lines to variables accordingly
                            LoanRecord = decimal.Parse(IpFile.ReadLine());
                            TermRecord = decimal.Parse(IpFile.ReadLine());
                            TotalInterestRecord = decimal.Parse(IpFile.ReadLine());

                            TotalNoOfTransactions_Summary++;
                            //calculations performed
                            TotalAmtBorrowed_Summary += LoanRecord;
                            TotalInterest_Summary += TotalInterestRecord;
                            Term_Summary += TermRecord;



                        }

                    }
                    IpFile.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //calculations
                TermInMonths = Term_Summary * NumberOfMonths;
                AvgAmtBorrowed_Summary = TotalAmtBorrowed_Summary / TotalNoOfTransactions_Summary;
                AvgDurationInMonths_Summary = TermInMonths / TotalNoOfTransactions_Summary;

                //Output to Summary labels
                OutputTotalAmtBorrowedTextBox.Text = TotalAmtBorrowed_Summary.ToString("C2");
                OutputTotalInterestTextBox.Text = TotalInterest_Summary.ToString("C2");
                OutputAvgAmtBorrowedTextBox.Text = AvgAmtBorrowed_Summary.ToString("C2");
                OutputAvgDurationTextBox.Text = AvgDurationInMonths_Summary.ToString() + " months";


            }
            else
            {
                MessageBox.Show("File does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void LoanClearButton_Click(object sender, EventArgs e)
        {
            //clear listbox and input textbox
            DetailsListBox.Items.Clear();
            LoanAmtTextBox.Clear();
            ClientGroupBox.Enabled = false;
            TxnNumValueLabel.Text = "";


        }

        private void SummaryClearButton_Click(object sender, EventArgs e)
        {
            //clear summary output labels
            OutputTotalAmtBorrowedTextBox.Clear();
            OutputAvgDurationTextBox.Clear();
            OutputAvgAmtBorrowedTextBox.Clear();
            OutputTotalInterestTextBox.Clear();
        }

        //Num is random number passed from generate random number method to check if it already exists in the file
        private bool CheckIfTxnNumExists(int Num)
        {
            //assign a variable to false
            bool value = false;
            //It is first checked if the file exists, if true, below block is executed. Method is called for the same.
            if (CheckIfFileExists())
            {


                IpFile = File.OpenText(FILENAME);

                while (!IpFile.EndOfStream)
                {
                    if (Num.ToString() == IpFile.ReadLine())
                    {
                        value = true;

                    }
                }
                IpFile.Close();

            }

            return value;
        }
        private bool CheckIfFileExists()
        {
            bool IsFilePresent = false;
            string path = FILENAME;
            if (File.Exists(path))
            {
                IsFilePresent = true;
            }
            //returns true if file is present
            return IsFilePresent;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            if (LoginCount < 2)
            {
                //compare input string to password constant variable assigned
                if (PassTextBox.Text == PASS_WORD)
                {
                    //toggle visbility on successfull login
                    LoginPanel.Visible = false;
                    LoanCalculatorGroupBox.Visible = true;
                    LoanCalculatorGroupBox.Enabled = true;
                    ClientGroupBox.Visible = true;
                    SummaryGroupBox.Visible = true;
                    SearchGroupBox.Visible = true;
                    ClearButton.Visible = true;
                    ExitButton.Visible = true;
                    ProceedButton.Enabled = false;
                    SubmitButton.Enabled = false;

                }
                //check for empty string
                else if (PassTextBox.Text == null)
                {
                    MessageBox.Show("Please enter the password", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (PassTextBox.Text != PASS_WORD && LoginCount == 0)
                {
                    MessageBox.Show("Wrong Password, please re-enter the password, You have one more attempt left.", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (PassTextBox.Text != PASS_WORD && LoginCount == 1)
                {
                    MessageBox.Show("Wrong Password. You've reached maximum attempts. Application will close. Please try again later.", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            //Increment count so as to allow only 2 login attempts
            LoginCount++;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            //event handlers which are also methods are called to avoid redundant code statments
            LoanClearButton_Click(sender, e);
            SummaryClearButton_Click(sender, e);
            ClientNameTextBox.Clear();
            PostCodeTextBox.Clear();
            PhNumTextBox.Clear();
            EmailTextBox.Clear();
            TxnNumValueLabel.Text = "";
            SearchResultTextBox.Clear();
            ClientGroupBox.Enabled = false;

        }



        private void ProceedButton_Click(object sender, EventArgs e)
        {

            //check if a selection is made
            if (DetailsListBox.SelectedIndex != -1)
            {

                if (!ClientGroupBox.Enabled)
                {
                    ClientGroupBox.Enabled = true;
                }
                SubmitButton.Enabled = true;
                //method is called for random number generation
                TransNum = GenerateRandomNumber();
                ClientGroupBox.Enabled = true;
                //display output to label
                TxnNumValueLabel.Text = TransNum.ToString();

            }
            else
            {
                MessageBox.Show("Please make a selection", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string ClientName, PostCode, EmailID;
            int PhoneNum;
            //Take inputs from user on client informationd and assign to variables
            ClientName = ClientNameTextBox.Text;
            PostCode = PostCodeTextBox.Text;
            EmailID = EmailTextBox.Text;


            //Check if User inputs are empty
            if (string.IsNullOrEmpty(ClientNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Please enter Client Name");
            }
            else if (string.IsNullOrEmpty(PostCodeTextBox.Text.Trim()))
            {
                MessageBox.Show("Please Enter Postcode");
            }
            else if (string.IsNullOrEmpty(PhNumTextBox.Text.Trim()))
            {
                MessageBox.Show("Please Enter a Phone Number");
            }
            else if (string.IsNullOrEmpty(EmailTextBox.Text.Trim()))
            {
                MessageBox.Show("Please enter Email ID");
            }
            //Validating the inputs
            else
            {
                if (int.TryParse(PhNumTextBox.Text, out PhoneNum))
                {
                    if (EmailTextBox.Text.Contains('@') && EmailTextBox.Text.Contains("."))
                    {
                        //assign values to varaibles depending on selection index
                        switch (DetailsListBox.SelectedIndex)
                        {
                            case 0:
                                Term_Conf = FIRST_TERM;
                                InterestRate_Conf = F_IntRate1;
                                MonthlyRepayment_Conf = F_MonthlyRepayment1;
                                TotalInterest_Conf = F_TotalInterest1;
                                TotalRepayment_Conf = F_TotalRepayment1;
                                break;
                            case 1:
                                Term_Conf = SECOND_TERM;
                                InterestRate_Conf = F_IntRate2;
                                MonthlyRepayment_Conf = F_MonthlyRepayment2;
                                TotalInterest_Conf = F_TotalInterest2;
                                TotalRepayment_Conf = F_TotalRepayment2;
                                break;
                            case 2:
                                Term_Conf = THIRD_TERM;
                                InterestRate_Conf = F_IntRate3;
                                MonthlyRepayment_Conf = F_MonthlyRepayment3;
                                TotalInterest_Conf = F_TotalInterest3;
                                TotalRepayment_Conf = F_TotalRepayment3;
                                break;
                            case 3:
                                Term_Conf = FOURTH_TERM;
                                InterestRate_Conf = F_IntRate4;
                                MonthlyRepayment_Conf = F_MonthlyRepayment4;
                                TotalInterest_Conf = F_TotalInterest4;
                                TotalRepayment_Conf = F_TotalRepayment4;
                                break;


                        }

                        //confirmation message on click of submit button
                        string ConfirmationMessage = "Client Name:\t " + ClientName +
                        "\nPhone Number:\t " + PhoneNum +
                        "\nPostcode:\t\t " + PostCode +
                        "\nEmail ID:\t\t " + EmailID +
                        "\nLoan Amount:\t " + LoanAmt.ToString("C2") +
                        "\nTerm:\t\t " + Term_Conf +
                        "\nInterest Rate:\t " + InterestRate_Conf + "%" +
                        "\nMonthly EMI:\t " + MonthlyRepayment_Conf.ToString("C2") +
                        "\nTotal Interest:\t " + TotalInterest_Conf.ToString("C2") +
                        "\nTotal Repayment Amount:\t " + TotalRepayment_Conf.ToString("C2");


                        if (MessageBox.Show(ConfirmationMessage, "Mad4Road - Confirmation", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            
                            try
                            {
                                StreamWriter OpFile;
                                //open file and append records to it
                                OpFile = File.AppendText(FILENAME);
                                OpFile.WriteLine(TransNum);
                                OpFile.WriteLine(EmailID);
                                OpFile.WriteLine(ClientName);
                                OpFile.WriteLine(PhoneNum);
                                OpFile.WriteLine(PostCode);
                                OpFile.WriteLine(InterestRate_Conf);
                                OpFile.WriteLine(MonthlyRepayment_Conf.ToString("N2"));
                                OpFile.WriteLine(TotalRepayment_Conf.ToString("N2"));
                                OpFile.WriteLine(LoanAmt.ToString("N2"));
                                OpFile.WriteLine(Term_Conf);
                                OpFile.WriteLine(TotalInterest_Conf.ToString("N2"));
                                OpFile.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            MessageBox.Show("Your request has been submitted.", "Submission confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            SubmitButton.Enabled = false;
                            ProceedButton.Enabled = false;
                            DetailsListBox.Items.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid E-mail ID", "Invalid E-mail ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Phone Number", "Invalid Phone number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }



        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DetailsListBox.Items.Clear();

            try
            {
                LoanAmt = decimal.Parse(LoanAmtTextBox.Text);


                //only values between 10000 and 100000 are taken into consideration, else an error is thrown
                if (LoanAmt >= 10000 && LoanAmt <= 100000)
                {
                    ProceedButton.Enabled = true;
                    if (LoanAmt >= 10000 && LoanAmt <= 40000)
                    {
                        //call calcuation function and pass term, interest rate and loan amount to the function
                        CalcAndDisplay(FIRST_TERM, INT_RATE11, LoanAmt);
                        F_MonthlyRepayment1 = MonthlyRepayment;
                        F_IntRate1 = INT_RATE11;
                        F_TotalInterest1 = TotalInterest;
                        F_TotalRepayment1 = TotalRepayment;

                        CalcAndDisplay(SECOND_TERM, INT_RATE13, LoanAmt);
                        F_MonthlyRepayment2 = MonthlyRepayment;
                        F_IntRate2 = INT_RATE13;
                        F_TotalInterest2 = TotalInterest;
                        F_TotalRepayment2 = TotalRepayment;

                        CalcAndDisplay(THIRD_TERM, INT_RATE15, LoanAmt);
                        F_MonthlyRepayment3 = MonthlyRepayment;
                        F_IntRate3 = INT_RATE15;
                        F_TotalInterest3 = TotalInterest;
                        F_TotalRepayment3 = TotalRepayment;

                        CalcAndDisplay(FOURTH_TERM, INT_RATE17, LoanAmt);
                        F_MonthlyRepayment4 = MonthlyRepayment;
                        F_IntRate4 = INT_RATE17;
                        F_TotalInterest4 = TotalInterest;
                        F_TotalRepayment4 = TotalRepayment;


                    }
                    else if (LoanAmt > 40000 && LoanAmt <= 80000)
                    {
                        CalcAndDisplay(FIRST_TERM, INT_RATE21, LoanAmt);
                        F_MonthlyRepayment1 = MonthlyRepayment;
                        F_IntRate1 = INT_RATE21;
                        F_TotalInterest1 = TotalInterest;
                        F_TotalRepayment1 = TotalRepayment;
                        CalcAndDisplay(SECOND_TERM, INT_RATE23, LoanAmt);
                        F_MonthlyRepayment2 = MonthlyRepayment;
                        F_IntRate2 = INT_RATE23;
                        F_TotalInterest2 = TotalInterest;
                        F_TotalRepayment2 = TotalRepayment;
                        CalcAndDisplay(THIRD_TERM, INT_RATE25, LoanAmt);
                        F_MonthlyRepayment3 = MonthlyRepayment;
                        F_IntRate3 = INT_RATE25;
                        F_TotalInterest3 = TotalInterest;
                        F_TotalRepayment3 = TotalRepayment;
                        CalcAndDisplay(FOURTH_TERM, INT_RATE27, LoanAmt);
                        F_MonthlyRepayment4 = MonthlyRepayment;
                        F_IntRate4 = INT_RATE27;
                        F_TotalInterest4 = TotalInterest;
                        F_TotalRepayment4 = TotalRepayment;

                    }
                    else if (LoanAmt > 80000 && LoanAmt <= 100000)
                    {
                        CalcAndDisplay(FIRST_TERM, INT_RATE31, LoanAmt);
                        F_MonthlyRepayment1 = MonthlyRepayment;
                        F_IntRate1 = INT_RATE31;
                        F_TotalInterest1 = TotalInterest;
                        F_TotalRepayment1 = TotalRepayment;
                        CalcAndDisplay(SECOND_TERM, INT_RATE33, LoanAmt);
                        F_MonthlyRepayment2 = MonthlyRepayment;
                        F_IntRate2 = INT_RATE33;
                        F_TotalInterest2 = TotalInterest;
                        F_TotalRepayment2 = TotalRepayment;
                        CalcAndDisplay(THIRD_TERM, INT_RATE35, LoanAmt);
                        F_MonthlyRepayment3 = MonthlyRepayment;
                        F_IntRate3 = INT_RATE35;
                        F_TotalInterest3 = TotalInterest;
                        F_TotalRepayment3 = TotalRepayment;
                        CalcAndDisplay(FOURTH_TERM, INT_RATE37, LoanAmt);
                        F_MonthlyRepayment4 = MonthlyRepayment;
                        F_IntRate4 = INT_RATE37;
                        F_TotalInterest4 = TotalInterest;
                        F_TotalRepayment4 = TotalRepayment;

                    }

                }
                //throw exception is input value is out of the given range
                else
                {
                    MessageBox.Show("Please enter amount between 10000 and 100000", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Please enter numeric value","Invalid Input", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }




        }


    }
}