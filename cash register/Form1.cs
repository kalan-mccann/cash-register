using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace cash_register
{ 
    public partial class Form1 : Form
    {
        double glombs;
        double glombsPrice = 3.50;

        double glacks;
        double glacksprice = 2.50;

        double tax;
        double taxrate = 0.13;
        double pretax;
        double Total;



        public Form1()
        {

            InitializeComponent();
        }

        private void taxmoney_Click(object sender, EventArgs e)
        {

        }

        private void premoney_Click(object sender, EventArgs e)
        {

        }

        private void totalmoney_Click(object sender, EventArgs e)
        {

        }

        private void glombsinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void glackinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceReveal_Click(object sender, EventArgs e)
        {
            try
            {



                //math

                glombs = Convert.ToDouble(glombsinput.Text);
                glacks = Convert.ToDouble(glackinput.Text);

                pretax = (glombs * glombsPrice) + (glacks * glacksprice);

                tax = pretax * taxrate;


                Total = pretax + tax;

                premoney.Text = $"{pretax.ToString("C")}";
                taxmoney.Text = $"{tax.ToString("C")}";
                totalmoney.Text = $"{Total.ToString("C")}";
              
            }
            catch {
                premoney.Text = "STOOOOOOOPPPPPPPPPPPPPPP";
                REPCIPTE.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOH";


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            glombs = Convert.ToDouble(glombsinput.Text);
            glacks = Convert.ToDouble(glackinput.Text);

            pretax = (glombs * glombsPrice) + (glacks * glacksprice);

            tax = pretax * taxrate;


            Total = pretax + tax;



            REPCIPTE.Text = $"THE SHOP";
            Refresh();
            Thread.Sleep(1000);

            REPCIPTE.Text += $"\n subtotal : {pretax.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            REPCIPTE.Text += $"\n tax : {tax.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            REPCIPTE.Text += $"\n TOTAL : {Total.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);

            REPCIPTE.Text += $"\n HAVE A BNUICE EADUYGGHH";
        }
    }
}
