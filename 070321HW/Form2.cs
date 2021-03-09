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

        private int _time = 31;

        private Timer _timer = new Timer();

        public Form2()
        {
            InitializeComponent();
        }

        private void MoleBtn_MouseHover(object sender, EventArgs e)
        {
            var x = _random.Next(0, this.Width - MoleBtn.Width);
            var y = _random.Next(0, this.Height - MoleBtn.Height * 2);
            MoleBtn.Location = new Point(x, y);
        }

        private void MoleBtn_Click(object sender, EventArgs e)
        {
            _timer.Stop();

            MessageBox.Show("You win!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var status = MessageBox.Show("Do you want to new Game?", "Info", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (status == DialogResult.No)
                Application.Exit();

            NewGame();

            _timer.Start();
        }

        private void NewGame()
        {
            _time = 31;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _timer.Tick += Timer_Tick;
            _timer.Interval = 1000;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _time--;
            TimeLbl.Text = $"left {_time.ToString()} seconds";
            if (_time != 0)
                return;

            _timer.Stop();
            MessageBox.Show("You lose!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var status = MessageBox.Show("Do you want to try again?", "Info", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (status == DialogResult.No)
                Application.Exit();

            NewGame();

            _timer.Start();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            this.HammerPctB.Location = e.Location;
        }
    }
}
