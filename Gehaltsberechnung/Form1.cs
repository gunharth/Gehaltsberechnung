using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gehaltsberechnung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double brutto, sv, steuer, bg, netto;

        private void CmdBerechnen_Click(object sender, EventArgs e)
        {

            try
            {
                brutto = Convert.ToDouble(TxtBrutto.Text);
                sv = brutto * 27.68 / 100;
                bg = brutto - sv;

                if (bg > 915)
                {
                    steuer = bg * 25 / 100;
                }
                else
                {
                    steuer = 0;
                }

                netto = bg - steuer;

                LblAnzeige.Text = "Brutto: " + string.Format("{0:C2}", brutto) + "\n"
                    + "SV: \t\t\t" + string.Format("{0:C2}", sv) + "\n"
                    + "Steuer: " + string.Format("{0:C2}", steuer) + "\n"
                    + "Netto: " + string.Format("{0:C2}", netto);
            } catch(Exception ex)
            {
                LblAnzeige.Text = "Fehler: " + ex;
            }

            
        }
    }
}
