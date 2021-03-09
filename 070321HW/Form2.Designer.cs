
namespace _070321HW
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HammerPctB = new System.Windows.Forms.PictureBox();
            this.MoleBtn = new System.Windows.Forms.Button();
            this.TimeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HammerPctB)).BeginInit();
            this.SuspendLayout();
            // 
            // HammerPctB
            // 
            this.HammerPctB.Image = global::_070321HW.Properties.Resources.hammer;
            this.HammerPctB.Location = new System.Drawing.Point(414, 136);
            this.HammerPctB.Name = "HammerPctB";
            this.HammerPctB.Size = new System.Drawing.Size(205, 206);
            this.HammerPctB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HammerPctB.TabIndex = 2;
            this.HammerPctB.TabStop = false;
            // 
            // MoleBtn
            // 
            this.MoleBtn.BackColor = System.Drawing.Color.Transparent;
            this.MoleBtn.BackgroundImage = global::_070321HW.Properties.Resources.mole;
            this.MoleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoleBtn.ForeColor = System.Drawing.Color.Transparent;
            this.MoleBtn.Location = new System.Drawing.Point(224, 136);
            this.MoleBtn.Name = "MoleBtn";
            this.MoleBtn.Size = new System.Drawing.Size(115, 79);
            this.MoleBtn.TabIndex = 0;
            this.MoleBtn.UseVisualStyleBackColor = false;
            this.MoleBtn.Click += new System.EventHandler(this.MoleBtn_Click);
            this.MoleBtn.MouseHover += new System.EventHandler(this.MoleBtn_MouseHover);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TimeLbl.Location = new System.Drawing.Point(12, 9);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(150, 24);
            this.TimeLbl.TabIndex = 3;
            this.TimeLbl.Text = "left 30 seconds";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 533);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.MoleBtn);
            this.Controls.Add(this.HammerPctB);
            this.MinimumSize = new System.Drawing.Size(920, 580);
            this.Name = "Form2";
            this.Text = "Catch the Mole";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.HammerPctB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoleBtn;
        private System.Windows.Forms.PictureBox HammerPctB;
        private System.Windows.Forms.Label TimeLbl;
    }
}