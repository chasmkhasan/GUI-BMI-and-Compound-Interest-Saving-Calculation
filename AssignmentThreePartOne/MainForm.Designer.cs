namespace AssignmentThreePartOne
{
    partial class MainForm
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
            lblHeight = new Label();
            txtName = new TextBox();
            txtCmFt = new TextBox();
            lblWeight = new Label();
            txtKgLbs = new TextBox();
            grpBMICalculator = new GroupBox();
            btnOK = new Button();
            label4 = new Label();
            label5 = new Label();
            lblBMIResult = new Label();
            lblWeightResult = new Label();
            grpResult = new GroupBox();
            rbtnMetricKGCM = new RadioButton();
            rbtnImperial = new RadioButton();
            grpUnit = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMonDep = new TextBox();
            txtPerYears = new TextBox();
            lblAmPaid = new Label();
            lblFinBalance = new Label();
            btnCalcSaving = new Button();
            grpSavPlan = new GroupBox();
            grpFutVal = new GroupBox();
            grpBMICalculator.SuspendLayout();
            grpResult.SuspendLayout();
            grpUnit.SuspendLayout();
            grpSavPlan.SuspendLayout();
            grpFutVal.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Your Name";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(20, 59);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(71, 15);
            lblHeight.TabIndex = 1;
            lblHeight.Text = "Height (cm)";
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 16);
            txtName.Name = "txtName";
            txtName.Size = new Size(162, 23);
            txtName.TabIndex = 2;
            // 
            // txtCmFt
            // 
            txtCmFt.Location = new Point(204, 50);
            txtCmFt.Name = "txtCmFt";
            txtCmFt.Size = new Size(100, 23);
            txtCmFt.TabIndex = 3;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(20, 94);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(69, 15);
            lblWeight.TabIndex = 4;
            lblWeight.Text = "Weight (kg)";
            // 
            // txtKgLbs
            // 
            txtKgLbs.Location = new Point(204, 91);
            txtKgLbs.Name = "txtKgLbs";
            txtKgLbs.Size = new Size(100, 23);
            txtKgLbs.TabIndex = 5;
            // 
            // grpBMICalculator
            // 
            grpBMICalculator.Controls.Add(txtKgLbs);
            grpBMICalculator.Controls.Add(lblWeight);
            grpBMICalculator.Controls.Add(txtCmFt);
            grpBMICalculator.Controls.Add(txtName);
            grpBMICalculator.Controls.Add(lblHeight);
            grpBMICalculator.Controls.Add(label1);
            grpBMICalculator.Location = new Point(31, 20);
            grpBMICalculator.Name = "grpBMICalculator";
            grpBMICalculator.Size = new Size(326, 135);
            grpBMICalculator.TabIndex = 6;
            grpBMICalculator.TabStop = false;
            grpBMICalculator.Text = "BMI Calculator";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(173, 174);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(162, 37);
            btnOK.TabIndex = 7;
            btnOK.Text = "Calculate BMI";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 22);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 8;
            label4.Text = "BMI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 51);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 9;
            label5.Text = "Weight Category";
            // 
            // lblBMIResult
            // 
            lblBMIResult.BorderStyle = BorderStyle.Fixed3D;
            lblBMIResult.Location = new Point(146, 14);
            lblBMIResult.Name = "lblBMIResult";
            lblBMIResult.Size = new Size(191, 23);
            lblBMIResult.TabIndex = 10;
            lblBMIResult.Text = "label6";
            lblBMIResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeightResult
            // 
            lblWeightResult.BorderStyle = BorderStyle.Fixed3D;
            lblWeightResult.Location = new Point(146, 43);
            lblWeightResult.Name = "lblWeightResult";
            lblWeightResult.Size = new Size(191, 23);
            lblWeightResult.TabIndex = 11;
            lblWeightResult.Text = "label6";
            lblWeightResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpResult
            // 
            grpResult.Controls.Add(lblWeightResult);
            grpResult.Controls.Add(lblBMIResult);
            grpResult.Controls.Add(label5);
            grpResult.Controls.Add(label4);
            grpResult.Location = new Point(27, 220);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(497, 176);
            grpResult.TabIndex = 12;
            grpResult.TabStop = false;
            grpResult.Text = "Results for";
            // 
            // rbtnMetricKGCM
            // 
            rbtnMetricKGCM.AutoSize = true;
            rbtnMetricKGCM.Location = new Point(23, 44);
            rbtnMetricKGCM.Name = "rbtnMetricKGCM";
            rbtnMetricKGCM.Size = new Size(106, 19);
            rbtnMetricKGCM.TabIndex = 13;
            rbtnMetricKGCM.TabStop = true;
            rbtnMetricKGCM.Text = "Metric (cm, kg)";
            rbtnMetricKGCM.UseVisualStyleBackColor = true;
            rbtnMetricKGCM.CheckedChanged += rbtnMetricKGCM_CheckedChanged;
            // 
            // rbtnImperial
            // 
            rbtnImperial.AutoSize = true;
            rbtnImperial.Location = new Point(23, 79);
            rbtnImperial.Name = "rbtnImperial";
            rbtnImperial.Size = new Size(108, 19);
            rbtnImperial.TabIndex = 14;
            rbtnImperial.TabStop = true;
            rbtnImperial.Text = "Imperial (ft, lbs)";
            rbtnImperial.UseVisualStyleBackColor = true;
            rbtnImperial.CheckedChanged += rbtnImperial_CheckedChanged;
            // 
            // grpUnit
            // 
            grpUnit.Controls.Add(rbtnImperial);
            grpUnit.Controls.Add(rbtnMetricKGCM);
            grpUnit.Location = new Point(363, 29);
            grpUnit.Name = "grpUnit";
            grpUnit.Size = new Size(161, 126);
            grpUnit.TabIndex = 15;
            grpUnit.TabStop = false;
            grpUnit.Text = "Unit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 38);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 16;
            label2.Text = "Monthly Deposit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 76);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 17;
            label3.Text = "Period (Years)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 68);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 18;
            label6.Text = "Amount Paid";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 105);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 19;
            label7.Text = "Final Balance";
            // 
            // txtMonDep
            // 
            txtMonDep.Location = new Point(215, 34);
            txtMonDep.Name = "txtMonDep";
            txtMonDep.Size = new Size(100, 23);
            txtMonDep.TabIndex = 20;
            // 
            // txtPerYears
            // 
            txtPerYears.Location = new Point(215, 82);
            txtPerYears.Name = "txtPerYears";
            txtPerYears.Size = new Size(100, 23);
            txtPerYears.TabIndex = 21;
            // 
            // lblAmPaid
            // 
            lblAmPaid.BorderStyle = BorderStyle.Fixed3D;
            lblAmPaid.Location = new Point(160, 64);
            lblAmPaid.Name = "lblAmPaid";
            lblAmPaid.Size = new Size(150, 23);
            lblAmPaid.TabIndex = 12;
            lblAmPaid.Text = "label6";
            lblAmPaid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFinBalance
            // 
            lblFinBalance.BorderStyle = BorderStyle.Fixed3D;
            lblFinBalance.Location = new Point(160, 101);
            lblFinBalance.Name = "lblFinBalance";
            lblFinBalance.Size = new Size(150, 23);
            lblFinBalance.TabIndex = 22;
            lblFinBalance.Text = "label6";
            lblFinBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalcSaving
            // 
            btnCalcSaving.Location = new Point(757, 174);
            btnCalcSaving.Name = "btnCalcSaving";
            btnCalcSaving.Size = new Size(162, 37);
            btnCalcSaving.TabIndex = 23;
            btnCalcSaving.Text = "Calculate Saving";
            btnCalcSaving.UseVisualStyleBackColor = true;
            btnCalcSaving.Click += button1_Click;
            // 
            // grpSavPlan
            // 
            grpSavPlan.Controls.Add(txtPerYears);
            grpSavPlan.Controls.Add(txtMonDep);
            grpSavPlan.Controls.Add(label3);
            grpSavPlan.Controls.Add(label2);
            grpSavPlan.Location = new Point(550, 29);
            grpSavPlan.Name = "grpSavPlan";
            grpSavPlan.Size = new Size(366, 123);
            grpSavPlan.TabIndex = 24;
            grpSavPlan.TabStop = false;
            grpSavPlan.Text = "Saving Plan";
            // 
            // grpFutVal
            // 
            grpFutVal.Controls.Add(lblFinBalance);
            grpFutVal.Controls.Add(lblAmPaid);
            grpFutVal.Controls.Add(label7);
            grpFutVal.Controls.Add(label6);
            grpFutVal.Location = new Point(581, 232);
            grpFutVal.Name = "grpFutVal";
            grpFutVal.Size = new Size(338, 164);
            grpFutVal.TabIndex = 25;
            grpFutVal.TabStop = false;
            grpFutVal.Text = "Future Value";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 450);
            Controls.Add(grpFutVal);
            Controls.Add(grpSavPlan);
            Controls.Add(btnCalcSaving);
            Controls.Add(grpUnit);
            Controls.Add(grpResult);
            Controls.Add(btnOK);
            Controls.Add(grpBMICalculator);
            Name = "MainForm";
            Text = "Super Calculator by";
            grpBMICalculator.ResumeLayout(false);
            grpBMICalculator.PerformLayout();
            grpResult.ResumeLayout(false);
            grpResult.PerformLayout();
            grpUnit.ResumeLayout(false);
            grpUnit.PerformLayout();
            grpSavPlan.ResumeLayout(false);
            grpSavPlan.PerformLayout();
            grpFutVal.ResumeLayout(false);
            grpFutVal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblHeight;
        private TextBox txtName;
        private TextBox txtCmFt;
        private Label lblWeight;
        private TextBox txtKgLbs;
        private GroupBox grpBMICalculator;
        private Button btnOK;
        private Label label4;
        private Label label5;
        private Label lblBMIResult;
        private Label lblWeightResult;
        private GroupBox grpResult;
        private RadioButton rbtnMetricKGCM;
        private RadioButton rbtnImperial;
        private GroupBox grpUnit;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private TextBox txtMonDep;
        private TextBox txtPerYears;
        private Label lblAmPaid;
        private Label lblFinBalance;
        private Button btnCalcSaving;
        private GroupBox grpSavPlan;
        private GroupBox grpFutVal;
    }
}