namespace CinemaBooking
{
    partial class FrmMovieDetail
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbdetail = new System.Windows.Forms.Label();
            this.cmbCinema = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMovieName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CinemaBooking.Properties.Resources.doraemon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(30, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 552);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbdetail
            // 
            this.lbdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdetail.Location = new System.Drawing.Point(506, 93);
            this.lbdetail.Name = "lbdetail";
            this.lbdetail.Size = new System.Drawing.Size(564, 223);
            this.lbdetail.TabIndex = 1;
            this.lbdetail.Text = "label1label1label1label1label1label1label1label1label1label1label1label1label1lab" +
    "el1label1label1label1label1label1";
            this.lbdetail.UseMnemonic = false;
            // 
            // cmbCinema
            // 
            this.cmbCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCinema.FormattingEnabled = true;
            this.cmbCinema.Location = new System.Drawing.Point(509, 416);
            this.cmbCinema.Name = "cmbCinema";
            this.cmbCinema.Size = new System.Drawing.Size(555, 33);
            this.cmbCinema.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(923, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tiếp tục";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(508, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 10);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(767, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn rạp và thời gian";
            // 
            // lbMovieName
            // 
            this.lbMovieName.AutoSize = true;
            this.lbMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovieName.Location = new System.Drawing.Point(507, 31);
            this.lbMovieName.Name = "lbMovieName";
            this.lbMovieName.Size = new System.Drawing.Size(79, 29);
            this.lbMovieName.TabIndex = 9;
            this.lbMovieName.Text = "label2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(510, 469);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(554, 34);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // FrmMovieDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 597);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbMovieName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbCinema);
            this.Controls.Add(this.lbdetail);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmMovieDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMovieDetail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbdetail;
        private System.Windows.Forms.ComboBox cmbCinema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMovieName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}