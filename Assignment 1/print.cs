using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class print : Form
    {
        public InitialForm previousForm { get; set; }
        public print()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
    }
}
