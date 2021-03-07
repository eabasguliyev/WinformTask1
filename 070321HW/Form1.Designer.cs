
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LondonBtn = new System.Windows.Forms.Button();
            this.BakuBtn = new System.Windows.Forms.Button();
            this.currentDateTimeLbl = new System.Windows.Forms.Label();
            this.WallpaperPB = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WallpaperPB)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LondonBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BakuBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 389);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 77);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // LondonBtn
            // 
            this.LondonBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LondonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LondonBtn.Location = new System.Drawing.Point(412, 3);
            this.LondonBtn.Name = "LondonBtn";
            this.LondonBtn.Size = new System.Drawing.Size(404, 71);
            this.LondonBtn.TabIndex = 1;
            this.LondonBtn.Text = "London";
            this.LondonBtn.UseVisualStyleBackColor = true;
            this.LondonBtn.Click += new System.EventHandler(this.LondonBtn_Click);
            // 
            // BakuBtn
            // 
            this.BakuBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BakuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BakuBtn.Location = new System.Drawing.Point(3, 3);
            this.BakuBtn.Name = "BakuBtn";
            this.BakuBtn.Size = new System.Drawing.Size(403, 71);
            this.BakuBtn.TabIndex = 0;
            this.BakuBtn.Text = "Baku";
            this.BakuBtn.UseVisualStyleBackColor = true;
            this.BakuBtn.Click += new System.EventHandler(this.BakuBtn_Click);
            // 
            // currentDateTimeLbl
            // 
            this.currentDateTimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentDateTimeLbl.AutoSize = true;
            this.currentDateTimeLbl.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateTimeLbl.Location = new System.Drawing.Point(0, 3);
            this.currentDateTimeLbl.Name = "currentDateTimeLbl";
            this.currentDateTimeLbl.Size = new System.Drawing.Size(50, 23);
            this.currentDateTimeLbl.TabIndex = 4;
            this.currentDateTimeLbl.Text = "Date:";
            this.currentDateTimeLbl.Visible = false;
            // 
            // WallpaperPB
            // 
            this.WallpaperPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WallpaperPB.Location = new System.Drawing.Point(0, 30);
            this.WallpaperPB.Name = "WallpaperPB";
            this.WallpaperPB.Size = new System.Drawing.Size(819, 359);
            this.WallpaperPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WallpaperPB.TabIndex = 0;
            this.WallpaperPB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 465);
            this.Controls.Add(this.currentDateTimeLbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.WallpaperPB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(835, 512);
            this.Name = "Form1";
            this.Text = "Task1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WallpaperPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WallpaperPB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LondonBtn;
        private System.Windows.Forms.Button BakuBtn;
        private System.Windows.Forms.Label currentDateTimeLbl;
    }
}

