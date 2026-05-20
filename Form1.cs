using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaySlipGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
        private void btncalculate_Click(object sender, EventArgs e)
        {
            if (txtBasicPayBox.Text == "" ||
    txtMealCoupon.Text == "" ||
    txtInsurance.Text == "" ||
    txtProfessionalTax.Text == "" ||
    txtSudexoDeduction.Text == "" ||
    txtbankaccount.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            {
                decimal basicPay = Convert.ToDecimal(txtBasicPayBox.Text);
                decimal annualSalary = basicPay * 12;

                decimal annualTax = 0;

                if (annualSalary <= 400000)
                {
                    annualTax = 0;
                }
                else if (annualSalary <= 800000)
                {
                    annualTax = annualSalary * 0.05m;
                }
                else if (annualSalary <= 1200000)
                {
                    annualTax = annualSalary * 0.10m;
                }
                else if (annualSalary <= 1600000)
                {
                    annualTax = annualSalary * 0.15m;
                }
                else if (annualSalary <= 2000000)
                {
                    annualTax = annualSalary * 0.20m;
                }
                else if (annualSalary <= 2400000)
                {
                    annualTax = annualSalary * 0.25m;
                }
                else
                {
                    annualTax = annualSalary * 0.30m;
                }

                decimal monthlyTax = annualTax / 12;

                txtIncomeTax.Text = monthlyTax.ToString("F2");
                decimal mealCoupon = Convert.ToDecimal(txtMealCoupon.Text);
                decimal incomeTax = Convert.ToDecimal(txtIncomeTax.Text);
                decimal insurance = Convert.ToDecimal(txtInsurance.Text);
                decimal professionalTax = Convert.ToDecimal(txtProfessionalTax.Text);
                decimal sodexo = Convert.ToDecimal(txtSudexoDeduction.Text);

                decimal hra = basicPay * 0.20m;

                decimal pfContribution = basicPay * 0.12m;

                decimal totalEarnings = basicPay + hra + mealCoupon;

                decimal totalTax = incomeTax;

                decimal totalDeductions =
                    pfContribution +
                    professionalTax +
                    insurance +
                    sodexo +
                    totalTax;

                decimal netPay =
                    totalEarnings - totalDeductions;

                txtHRA.Text = hra.ToString("F2");

                txtPFContribution.Text = pfContribution.ToString("F2");

                txtTotalEarnings.Text = totalEarnings.ToString("F2");

                TxtTotalTax.Text = totalTax.ToString("F2");

                txtTotalDeductions.Text = totalDeductions.ToString();

                txtNetPay.Text = netPay.ToString("F2");

                MessageBox.Show("Payslip Generated Successfully");
            }
            //{
            //    Form2 form2 = new Form2();
            //    form2.txtPersNo.Text = txtPersNo.Text;
            //    form2.txtPAN.Text = txtPAN.Text;
            //    form2.txtPaidDays.Text = txtPaidDays.Text;
            //    form2.txtUAN.Text = txtUAN.Text;

            //    form2.txtPFNo.Text = txtPFNo.Text;

            //    form2.txtMealCoupon.Text = txtMealCoupon.Text;

            //    form2.txtPFContribution.Text = txtPFContribution.Text;
            //    form2.txtProfessionalTax.Text = txtProfessionalTax.Text;
            //    form2.txtInsurance.Text = txtInsurance.Text;
            //    form2.txtSudexoDeduction.Text = txtSudexoDeduction.Text;

            //    form2.TxtTotalTax.Text = TxtTotalTax.Text;

            //    form2.txtEmployeeName.Text = txtEmployeeName.Text;
            //    form2.txtDesignation.Text = txtDesignation.Text;
            //    form2.txtDepartment.Text = txtDepartment.Text;

            //    form2.txtBasicPayBox.Text = txtBasicPayBox.Text;
            //    form2.txtHRA.Text = txtHRA.Text;
            //    form2.txtTotalEarnings.Text = txtTotalEarnings.Text;

            //    form2.txtTotalDeductions.Text = txtTotalDeductions.Text;
            //    form2.txtIncomeTax.Text = txtIncomeTax.Text;
            //    form2.txtNetPay.Text = txtNetPay.Text;
            //    form2.dateTimePicker1.Value = dateTimePicker1.Value;
            //    form2.dateTimePicker2.Value = dateTimePicker2.Value;
            //    form2.BankAccount = txtbankaccount.Text;
            //    form2.cmbBankName.Text = cmbBankName.Text;
               

            //    form2.Show();
            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Employee Details
            txtEmployeeName.Clear();
            txtDesignation.Clear();
            txtDepartment.Clear();
            txtPFNo.Clear();
            txtPersNo.Clear();
            txtPAN.Clear();
            txtUAN.Clear();

            // Earnings
            txtBasicPayBox.Clear();
            txtHRA.Clear();
            txtMealCoupon.Clear();
            txtTotalEarnings.Clear();

            // Monthly Earnings
            txtMonthlyBasics.Clear();
            txtMonthlyGross.Clear();
            txtMonthlyTax.Clear();
            txtMonthlyNet.Clear();

            // Yearly Earnings
            txtYearlyBasic.Clear();
            txtYearlyGross.Clear();
            txtYearlyTax.Clear();
            txtYearlyNet.Clear();

            // Pay Period Earnings
            txtPeriodBasic.Clear();
            txtPeriodGross.Clear();
            txtPeriodTax.Clear();
            txtPeriodNet.Clear();

            // Tax
            txtIncomeTax.Clear();
            TxtTotalTax.Clear();

            // Deductions
            txtPFContribution.Clear();
            txtProfessionalTax.Clear();
            txtSudexoDeduction.Clear();
            txtInsurance.Clear();
            txtSeniorCitizenInsurance.Clear();
            txtTotalDeductions.Clear();

            // Bank Details
            txtbankaccount.Clear();

            // ComboBox
            cmbBankName.SelectedIndex = -1;

            // Paid Days
            txtPaidDays.Clear();

            // Reset Dates
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker3.Value = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtEmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtDesignation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPaidDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtPAN.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (txtbankaccount.Text.Length >= 12 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        
        {
            CalculatePaidDays();
        }
        private void CalculatePaidDays()
        {
            int days = (dateTimePicker2.Value - dateTimePicker1.Value).Days + 1;

            if (days >= 0)
            {
                txtPaidDays.Text = days.ToString();
            }
            else
            {
                txtPaidDays.Text = "0";
            }
        }
        private void txtPaidDays_TextChanged(object sender, EventArgs e)
        
        {
            CalculatePaidDays();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CalculatePaidDays();
        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }
        private void CalculatePayslip()
        {
            if (txtBasicPayBox.Text == "")
                return;

            decimal basic = Convert.ToDecimal(txtBasicPayBox.Text);

            decimal hra = basic * 0.20m;
            txtHRA.Text = hra.ToString();

            decimal meal = 0;

            if (txtMealCoupon.Text != "")
            {
                meal = Convert.ToDecimal(txtMealCoupon.Text);
            }

            decimal totalEarnings = basic + hra + meal;
            txtTotalEarnings.Text = totalEarnings.ToString();

            decimal pf = basic * 0.12m;
            txtPFContribution.Text = pf.ToString();

            decimal professionalTax = 200;
            txtProfessionalTax.Text = professionalTax.ToString();

            decimal insurance = 500;
            txtInsurance.Text = insurance.ToString();

            decimal sodexo = 300;
            txtSudexoDeduction.Text = sodexo.ToString();

            decimal incomeTax = basic * 0.05m;
            txtIncomeTax.Text = incomeTax.ToString();

            TxtTotalTax.Text = incomeTax.ToString();

            decimal seniorInsurance = 0;

            if (txtSeniorCitizenInsurance.Text != "")
            {
                seniorInsurance =
                    Convert.ToDecimal(txtSeniorCitizenInsurance.Text);
            }

            decimal totalDeductions =
                pf +
                professionalTax +
                insurance +
                sodexo +
                seniorInsurance;

            txtTotalDeductions.Text =
                totalDeductions.ToString();

            decimal netPay =
                totalEarnings - totalDeductions - incomeTax;
            int paidDays = 0;

            if (txtPaidDays.Text != "")
            {
                paidDays = Convert.ToInt32(txtPaidDays.Text);
            }

            int totalDaysInMonth =
                DateTime.DaysInMonth(
                    dateTimePicker1.Value.Year,
                    dateTimePicker1.Value.Month);

            decimal dailyBasic =
                basic / totalDaysInMonth;

            decimal periodBasic =
                dailyBasic * paidDays;

            decimal dailyGross =
                totalEarnings / totalDaysInMonth;

            decimal periodGross =
                dailyGross * paidDays;

            decimal dailyTax =
                incomeTax / totalDaysInMonth;

            decimal periodTax =
                dailyTax * paidDays;

            decimal dailyNet =
                netPay / totalDaysInMonth;

            decimal periodNet =
                dailyNet * paidDays;

            txtPeriodBasic.Text =
                periodBasic.ToString("0.00");

            txtPeriodGross.Text =
                periodGross.ToString("0.00");

            txtPeriodTax.Text =
                periodTax.ToString("0.00");

            txtPeriodNet.Text =
                periodNet.ToString("0.00");

            txtNetPay.Text = netPay.ToString();

            // MONTHLY
            txtMonthlyBasics.Text = basic.ToString();
            txtMonthlyGross.Text = totalEarnings.ToString();
            txtMonthlyTax.Text = incomeTax.ToString();
            txtMonthlyNet.Text = netPay.ToString();

            // YEARLY
            txtYearlyBasic.Text = (basic * 12).ToString();
            txtYearlyGross.Text = (totalEarnings * 12).ToString();
            txtYearlyTax.Text = (incomeTax * 12).ToString();
            txtYearlyNet.Text = (netPay * 12).ToString();
        }

        private void txtBasicPayBox_TextChanged(object sender, EventArgs e)
        {
            CalculatePayslip();
        }

        private void txtMealCoupon_TextChanged(object sender, EventArgs e)
        {
            CalculatePayslip();
        }

        private void txtUAN_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtUAN.Text.Length >= 12 &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPFNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtPFNo.Text.Length >= 22 &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSeniorCitizenInsurance_TextChanged(object sender, EventArgs e)
        {
            CalculatePayslip();
        }
    }
    }
    
    







