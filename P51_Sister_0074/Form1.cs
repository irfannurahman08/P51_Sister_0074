using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P51_Sister_0074
{
    public partial class Form1 : Form
    {
        LayananKonversi.Service MyServices;
        double CtoR, CtoF, CtoK;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyServices = new LayananKonversi.Service();
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            CtoR = MyServices.CelciusToReamur(int.Parse(textBoxSuhuC.Text));
            CtoF = MyServices.CelciusToFahrenhet(int.Parse(textBoxSuhuC.Text));
            CtoK = MyServices.CelciusToKelvin(int.Parse(textBoxSuhuC.Text));

            textBoxReamur.Text = CtoR.ToString() + " R";
            textBoxFahrenheit.Text = CtoF.ToString() + " F";
            textBoxKelvin.Text = CtoK.ToString() + " K";
        }

    }
}
