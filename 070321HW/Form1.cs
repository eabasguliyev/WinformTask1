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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BakuBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                ChangeColorOfButton(btn, Color.Green);
                ChangeColorOfButton(LondonBtn, SystemColors.ActiveCaption);
                ChangeFormImage(Properties.Resources.baku);

                this.currentDateTimeLbl.Text = GetDateTime("Azerbaijan Standard Time").ToString("F");
                this.currentDateTimeLbl.Visible = true;
            }
        }

        private void LondonBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                ChangeColorOfButton(btn, Color.Green);
                ChangeColorOfButton(BakuBtn, SystemColors.ActiveCaption);
                ChangeFormImage(Properties.Resources.london);

                this.currentDateTimeLbl.Text = GetDateTime("Greenwich Standard Time").ToString("F");
                this.currentDateTimeLbl.Visible = true;
            }
        }

        #region Helper Methods

        private void ChangeColorOfButton(Button button, Color color)
        { 
            button.BackColor = color;
        }

        private void ChangeFormImage(Bitmap image)
        {
            this.BackgroundImage = image;
        }

        private DateTime GetDateTime(string id)
        {
            var info = TimeZoneInfo.FindSystemTimeZoneById(id);
            DateTimeOffset localServerTime = DateTimeOffset.Now;
            DateTimeOffset localTime = TimeZoneInfo.ConvertTime(localServerTime, info);

            return localTime.DateTime;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            BakuBtn.PerformClick();
        }
    }
}
