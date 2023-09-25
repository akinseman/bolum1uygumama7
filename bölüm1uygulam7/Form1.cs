using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bölüm1uygulam7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSepete_ekle_Click(object sender, EventArgs e)
        {
            lboxMeyveller.Items.Add(txtmeyve.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lboxMeyveller.Items.Clear();
        }

        private void btensil_Click(object sender, EventArgs e)
        {
            lboxMeyveller.Items.Remove(lboxMeyveller.SelectedItem);
        }
    }
}
