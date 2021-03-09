
namespace _070321HW
{
    partial class Form1
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
            this.LondonBtn = new System.Windows.Forms.Button();
            this.BakuBtn = new System.Windows.Forms.Button();
            this.currentDateTimeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LondonBtn
            // 
            this.LondonBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LondonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LondonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LondonBtn.Location = new System.Drawing.Point(448, 366);
            this.LondonBtn.Name = "LondonBtn";
            this.LondonBtn.Size = new System.Drawing.Size(188, 71);
            this.LondonBtn.TabIndex = 1;
            this.LondonBtn.Text = "London";
            this.LondonBtn.UseVisualStyleBackColor = false;
            this.LondonBtn.Click += new System.EventHandler(this.LondonBtn_Click);
            // 
            // BakuBtn
            // 
            this.BakuBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BakuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BakuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BakuBtn.Location = new System.Drawing.Point(145, 366);
            this.BakuBtn.Name = "BakuBtn";
            this.BakuBtn.Size = new System.Drawing.Size(178, 71);
            this.BakuBtn.TabIndex = 0;
            this.BakuBtn.Text = "Baku";
            this.BakuBtn.UseVisualStyleBackColor = false;
            this.BakuBtn.Click += new System.EventHandler(this.BakuBtn_Click);
            // 
            // currentDateTimeLbl
            // 
            this.currentDateTimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentDateTimeLbl.AutoSize = true;
            this.currentDateTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.currentDateTimeLbl.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateTimeLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.currentDateTimeLbl.Location = new System.Drawing.Point(12, 9);
            this.currentDateTimeLbl.Name = "currentDateTimeLbl";
            this.currentDateTimeLbl.Size = new System.Drawing.Size(87, 38);
            this.currentDateTimeLbl.TabIndex = 4;
            this.currentDateTimeLbl.Text = "Date:";
            this.currentDateTimeLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_070321HW.Properties.Resources.baku;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 465);
            this.Controls.Add(this.LondonBtn);
            this.Controls.Add(this.BakuBtn);
            this.Controls.Add(this.currentDateTimeLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(835, 512);
            this.Name = "Form1";
            this.Text = "Task1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LondonBtn;
        private System.Windows.Forms.Button BakuBtn;
        private System.Windows.Forms.Label currentDateTimeLbl;
    }
}

