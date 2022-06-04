using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWork
{
    public partial class Form2 : Form
    {
        int[] evaluations;

        public Form2(int[] eevaluations)
        {
            evaluations = eevaluations;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = evaluations.Max().ToString();
            label4.Text = evaluations.Min().ToString();
            label6.Text = evaluations.Average().ToString();
        }
    }
}
