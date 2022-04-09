using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TasksApp
{
    public partial class AddNumber : MetroFramework.Forms.MetroForm
    {
        public int numberToAdd = -1;

        public AddNumber()
        {
            InitializeComponent();
        }

        public void submitBtn_Click(object sender, EventArgs e)
        {
            this.numberToAdd = (int)this.numberToAddNm.Value;
        }

        private void AddNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void numberToAddNm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.numberToAdd = (int)this.numberToAddNm.Value;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void AddNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void numberToAddNm_Enter(object sender, EventArgs e)
        {
            this.numberToAddNm.Select(0, this.numberToAddNm.Text.Length);
        }
    }
}
