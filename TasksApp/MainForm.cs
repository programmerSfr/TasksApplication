using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksApp
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void maxProdBtn_Click(object sender, EventArgs e)
        {
            MaximumProduct prodForm = new MaximumProduct();
            prodForm.ShowDialog();

            //int[] valuesArr = { 6, 8, 8, 7, 2, 5 };
            //int multipleOf = 3;

            //entityservice.Calcs cals = new entityservice.Calcs();
            //(int, int, int) result = cals.GetMaximumProductMultiple(valuesArr, multipleOf);

            //if (result.Item1 != -1)
            //{
            //    MessageBox.Show("Maximum product is " + result.Item1 + ". Product of " + result.Item2 + " and " + result.Item3, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else MessageBox.Show("Any product multiple of " + multipleOf + " found in array", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }
    }
}
