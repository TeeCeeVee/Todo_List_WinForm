using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxApp
{
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
   
            
            //once add button gets clicked
            //add the input from the textbox to display on the listbox
            LstBox.Items.Add(TxtInput.Text);

            TxtInput.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //once clear is clicked, inputbox gets emptied
            LstBox.Items.Clear();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

            // check the item selected, then remove
            // -1 means none of the index were selected
            if (LstBox.SelectedIndex != -1)
            {
                LstBox.Items.RemoveAt(LstBox.SelectedIndex);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
