using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (var i = 100; i <= 1000; i += 100)
                    ddlMonthlyInvestment.Items.Add(i.ToString());
            }
        }


        private double CalculateFutureValue(decimal installment, decimal r, int n)
        {
            var FVA = ((Math.Pow(1 + (double)r, n) - 1) / (double)r) * (double)installment;
            return FVA;
        }

        protected void btnCalculate_Click1(object sender, EventArgs e)
        {
            var monthlyInvestment =
                Convert.ToInt32(ddlMonthlyInvestment.SelectedValue);
            var yearlyInterestRate =
                Convert.ToDecimal(txtAnnualRate.Text);
            var years =
                Convert.ToInt32(txtNumYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            var futureValue = CalculateFutureValue(monthlyInvestment,
                monthlyInterestRate, months);

            lblCalcValue.Text = futureValue.ToString("c");
        }

        protected void btnClear_Click1(object sender, EventArgs e)
        {
            txtAnnualRate.Text = "";
            txtNumYears.Text = "";
            lblCalcValue.Text = "";
        }
    }
}