using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _070321HW
{
    public partial class Form2 : Form
    {
        private Random _random = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                var x = _random.Next(0, this.Width - 50);
                var y = _random.Next(0, this.Height - 50);
                btn.Location = new Point(x, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                var r = _random.Next(0, 256);
                var g = _random.Next(0, 256);
                var b = _random.Next(0, 256);

                this.BackColor = Color.FromArgb(r, g, b);
            }
        }
    }
}
