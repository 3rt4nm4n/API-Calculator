using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int n1;
        public int n2;
        public int result;

        private void Button_Calc_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(TextBox_Int1.Text);
            n2 = int.Parse(TextBox_Int2.Text);
            
                try
                {
                    using (ServiceReference1.CalculatorSoapClient service = new ServiceReference1.CalculatorSoapClient { })
                    {
                    if (RButton_Add.Checked)
                        result = service.Add(n1, n2);
                    else if (RButton_Subtract.Checked)
                        result = service.Subtract(n1, n2);
                    else if (RButton_Multiply.Checked)
                        result = service.Multiply(n1, n2);
                    else if (RButton_Divide.Checked)
                        result = service.Divide(n1, n2);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            
           
         

            TextBox_Result.Text = result.ToString();
            
        }
    }
}
