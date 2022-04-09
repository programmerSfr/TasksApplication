using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TasksApp
{
    public partial class MaximumProduct : MetroFramework.Forms.MetroForm
    {

        public List<int> numbersArr = new List<int>();

        public MaximumProduct()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddNumber addForm = new AddNumber();
            if(addForm.ShowDialog() == DialogResult.OK)
            {
                this.numbersLB.Items.Add(addForm.numberToAdd);
                this.numbersArr.Add(addForm.numberToAdd);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if(this.numbersLB.SelectedIndex >= 0)
            {
                this.numbersArr.RemoveAt(this.numbersLB.SelectedIndex);
                this.numbersLB.Items.RemoveAt(this.numbersLB.SelectedIndex);
            }
        }

        private void MaximumProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (this.numbersLB.Items.Count > 1)
            {
                //int[] valuesArr = { 6, 8, 8, 7, 2, 5 };
                //int multipleOf = 3;

                int multipleOf = (int)this.multipleOfNm.Value;

                if (multipleOf > 0)
                {
                    entityservice.Calcs calcs = new entityservice.Calcs();
                    (int, int, int) result = calcs.GetMaximumProductMultiple(this.numbersArr.ToArray(), multipleOf);

                    if (result.Item1 != -1)
                    {
                        MessageBox.Show("Maximum product is " + result.Item1 + ". Product of " + result.Item2 + " and " + result.Item3, "RESULT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Any product multiple of " + multipleOf + " found in array", "RESULT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Number to be mutiple of should be greater than zero!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("No numbers to calculate product!","WARNING",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void multipleOfNm_Enter(object sender, EventArgs e)
        {
            this.multipleOfNm.Select(0, this.multipleOfNm.Text.Length);
        }
    }
}
