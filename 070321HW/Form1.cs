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
                ChangeColorOfButton(LondonBtn, Color.Transparent);
                ChangePictureBoxImage(WallpaperPB, Properties.Resources.baku);

                this.currentDateTimeLbl.Text = GetDateTime("Azerbaijan Standard Time").ToString("F");
                this.currentDateTimeLbl.Visible = true;
            }
        }

        private void LondonBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                ChangeColorOfButton(btn, Color.Green);
                ChangeColorOfButton(BakuBtn, Color.Transparent);
                ChangePictureBoxImage(WallpaperPB, Properties.Resources.london);

                this.currentDateTimeLbl.Text = GetDateTime("Greenwich Standard Time").ToString("F");
                this.currentDateTimeLbl.Visible = true;
            }
        }

        #region Helper Methods

        private void ChangeColorOfButton(Button button, Color color)
        { 
            button.BackColor = color;
        }

        private void ChangePictureBoxImage(PictureBox pb, Bitmap image)
        {
            pb.Image = image;
        }

        private DateTime GetDateTime(string id)
        {
            var info = TimeZoneInfo.FindSystemTimeZoneById(id);
            DateTimeOffset localServerTime = DateTimeOffset.Now;
            DateTimeOffset localTime = TimeZoneInfo.ConvertTime(localServerTime, info);

            return localTime.DateTime;
        }
        #endregion
    }
}
