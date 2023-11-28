using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class SecondForm : Form
    {
        private string MyProperty { get; set; }
        public SecondForm()
        {
            InitializeComponent();
        }
        public SecondForm(string message) : this()
        {
            label1.Text = message;
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {

        }
        public void UdateMessage(string message)
        {
            MyProperty = message;
            label1.Text = message;
        }
    }
}
