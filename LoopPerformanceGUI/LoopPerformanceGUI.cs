using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopPerformanceGUI
{
    public partial class LoopPerformanceGUI : Form
    {
        public LoopPerformanceGUI()
        {
            InitializeComponent();
        }

        private void radInteger_Click(object sender, EventArgs e)
        {
            this.grdResults.Visible = false;
            this.txtObjectData.Visible = false;
        }

        private void radObject_Click(object sender, EventArgs e)
        {
            this.grdResults.Visible = false;
            this.txtObjectData.Visible = true;
            if (this.radObject.Checked == true && string.IsNullOrEmpty(this.txtObjectData.Text) == true)
                MessageBox.Show("Please enter a single JSON object, not an array.");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // set which radio button is selected as a boolean
            bool isInt = GetCheckedRadio(grpLoopType).Name == "radInteger" ? true : false;
            // get the loops entered by the user
            bool getLoops = long.TryParse(txtNumberOfLoops.Text, out long loops);
            // push the parsed value back to the form
            txtNumberOfLoops.Text = loops.ToString();
            // instantiate the results loop
            List<Output> loopResultes = new List<Output>();
            // instantiate data object
            dynamic data = null;
            if (isInt == false)
            {
                // handle JSON
                data = this.txtObjectData.Text.ConvertObjectToDynamic();
                if (data == null)
                {
                    MessageBox.Show("Your object is not a valid JSON object");
                    return;
                }
            }
            // check loop values for zero or max
            loops = isInt == true ? SetLoops(loops, 100000000) : SetLoops(loops, 50000000);
            // create objects and run the tests
            loopResultes = isInt == true ? LoopWork.Do<int>(loops, "Integer") : LoopWork.Do<dynamic>(loops, "JSON", data);
            // update the UI
            if (loopResultes.Count() > 0)
            {
                this.grdResults.DataSource = loopResultes;
                this.txtObjectData.Visible = false;
                this.grdResults.Columns[0].Width = 425;
                this.grdResults.Columns[1].Width = 114;
                this.grdResults.Visible = true;
                SetColors(loopResultes, grdResults);
            }
        }

        long SetLoops(long loops, long max)
        {
            if (loops == 0 || loops > max)
            {
                loops = max;
                this.txtNumberOfLoops.Text = loops.ToString();
                MessageBox.Show($"Too many or few loops. We will loop {loops} times");
            }
            return loops;
        }

        void SetColors(List<Output> output, DataGridView grid)
        {
            int opCount = output.Count();
            bool isOne = true;
            for (int i = 0; i < opCount; i++)
            {
                if (i % 3 == 0)
                    isOne = !isOne;

                DataGridViewRow row = grid.Rows[i];
                row.DefaultCellStyle.BackColor = isOne == true ? Color.LightSlateGray : Color.DarkSlateGray;
                row.DefaultCellStyle.ForeColor = isOne == true ? Color.Black : Color.White;
            }

            grid.Rows[0].Cells[0].Selected = false;
        }

        RadioButton GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }
            return null;
        }

        private void txtNumberOfLoops_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
