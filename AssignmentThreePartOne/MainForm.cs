namespace AssignmentThreePartOne
{
    public partial class MainForm : Form
    {
        private string name = string.Empty;
        private BMICalculator bmiCalc = new BMICalculator();
        private SavingCalculator savCalc = new SavingCalculator();

        public MainForm()
        {
            InitializeComponent();
            //Begin my code.

            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text += " Md Kamrul Hasan";
            lblBMIResult.Text = string.Empty;
            lblWeightResult.Text = string.Empty;
            rbtnMetricKGCM.Checked = true;

            lblAmPaid.Text = string.Empty;
            lblFinBalance.Text = string.Empty;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            //1. Read Input.
            bool ok = ReadInputBMI();

            //2. Calculate.
            if (ok)
            {
                CalculateAndDisplayResults();
            }
            //3. Show Results.
        }

        private void CalculateAndDisplayResults()
        {
            double bmi = bmiCalc.CalculateBMI();
            lblBMIResult.Text = bmi.ToString("f2");
            lblWeightResult.Text = bmiCalc.BmiWeightCategory();
        }

        private bool ReadInputBMI()
        {
            ReadName();
            bool heightOK = ReadHeight();
            bool weightOK = ReadWeight();
            ReadUnit();

            return heightOK && weightOK;
        }

        private void ReadUnit()
        {
            if (rbtnMetricKGCM.Checked)
                bmiCalc.SetUnit(UnitType.Metric);
            else
                bmiCalc.SetUnit(UnitType.Imperial);
        }
        private void ReadName()
        {
            name = txtName.Text;
            name = name.Trim();
            grpResult.Text = name;
        }
        private bool ReadHeight()
        {
            double height = 0.0;

            //try parse
            bool ok = double.TryParse(txtCmFt.Text, out height);
            if (!ok) // ok == false
            {
                MessageBox.Show("The height Value is invalid!", "Error");
            }

            // cm --> m, ft --> in
            if (bmiCalc.GetUnit() == UnitType.Metric)
                height = height / 100.0; // cm --> m
            else
                height = height * 12.0;

            bmiCalc.SetHeight(height);

            return ok;
        }

        private bool ReadWeight()
        {
            double weight = 0.0;

            //try parse
            bool ok = double.TryParse(txtKgLbs.Text, out weight);
            if (!ok) // ok == false
            {
                MessageBox.Show("The weight Value is invalid!", "Error");
            }

            bmiCalc.SetWeight(weight);
            return ok;
        }
        private void UpdateHeightText()
        {
            if (rbtnMetricKGCM.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
            }
            else
            {
                lblHeight.Text = "Height (foot & inch)";
                lblWeight.Text = "Weight (pounds or lbs)";
            }
        }

        private void rbtnMetricKGCM_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
        }

        private void rbtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.Read Input.
            bool ok = ReadSavingInput();

            //2. Calculate.
            if (ok)
            {
                CalculationOfSavingResult();
            }
            //3.Show Results.
        }

        private void CalculationOfSavingResult()
        {
            double savingCalc = savCalc.AmountPaidCalculation();
            lblAmPaid.Text = savingCalc.ToString();

            double finalBalCalc = savCalc.FinalBalanceCalculation();
            lblFinBalance.Text = finalBalCalc.ToString("f2");
        }

        private bool ReadSavingInput()
        {
            bool savingOK = ReadMonthlyDeposit();
            bool periodOK = ReadPeriodsYear();

            return savingOK && periodOK;
        }


        private bool ReadMonthlyDeposit()
        {

            double deposit = 0.0;

            bool ok = double.TryParse(txtMonDep.Text, out deposit);
            if (!ok)
            {
                MessageBox.Show("Invalid Input! Only Number Accepetd!", "Error");
            }

            savCalc.SetDeposit(deposit);
            return ok;
        }

        private bool ReadPeriodsYear()
        {

            double year = 0.0;

            bool ok = double.TryParse(txtPerYears.Text, out year);
            if (!ok)
            {
                MessageBox.Show("Invalid Input! Only Number Accepetd", "Error");
            }

            savCalc.SetPeriod(year);
            return ok;
        }
    }
}