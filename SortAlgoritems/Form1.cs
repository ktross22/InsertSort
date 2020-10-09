using Algorithm;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgoritems
{
    public partial class Form1 : Form
    {
        List<int> items = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                items.Add(value);

            }
            AddTextBox.Text = "";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {

            if (int.TryParse(FillTextBox.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    items.Add(rnd.Next());
                }


            }
            AddTextBox.Text = "";
        }
    }
}
