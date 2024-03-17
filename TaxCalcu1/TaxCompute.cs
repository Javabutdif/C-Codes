using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalcu1
{
    internal class TaxCompute
    {
        private double sss = 900;
        private double philHealth = 800;
        private double pagIbig = 100;
        private double totalContributions = 0;
        private double monthlyPercentage = 0;
        private double incomeTax = 0;
        private double incomeTaxPercentage = 0;
        private double totalDeductions = 0;
        private double netPay = 0;

      
        public TaxCompute(double salary)
        {
            this.totalContributions = this.sss + this.philHealth + this.pagIbig;

            if (salary >= 25000)
            {

                this.incomeTaxPercentage = 0.15;
                this.incomeTax = (salary * 0.15) - this.totalContributions;
                this.monthlyPercentage = this.incomeTax / salary;
            }

            this.totalDeductions = this.totalContributions + this.incomeTax;


            this.netPay = salary - this.totalDeductions;

        }


        public string getOuput()
        {
            return "\n Tax Computation\n   Income Tax Amount per month: P" +
                this.incomeTax + "\n   Income Tax Percentage per month: " + this.monthlyPercentage + "%"
                + "\n\n Monthly Contributions\n   SSS amount: P" + this.sss +
                "\n   PhilHealth amount: P" + this.philHealth +
                "\n   Pag-IBIG amount: P" + this.pagIbig + "\n   Total Contribution Amount: P" + this.totalContributions
                + "\n Total Deductions\n   Total Deduction Amount: P" + this.totalDeductions
                + "\n   Net Pay after Deductions: P" + netPay + "\n\n Salary:   Net Salary Amount: P" + this.netPay;

        }
    }
}
