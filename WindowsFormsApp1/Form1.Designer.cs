namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_hamilton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_schumacher = new System.Windows.Forms.PictureBox();
            this.button_hamilton = new System.Windows.Forms.Button();
            this.button_schumacher = new System.Windows.Forms.Button();
            this.pictureBox_fangio = new System.Windows.Forms.PictureBox();
            this.button_fangio = new System.Windows.Forms.Button();
            this.pictureBox_prost = new System.Windows.Forms.PictureBox();
            this.button_prost = new System.Windows.Forms.Button();
            this.pictureBox_vettel = new System.Windows.Forms.PictureBox();
            this.button_vettel = new System.Windows.Forms.Button();
            this.pictureBox_senna = new System.Windows.Forms.PictureBox();
            this.button_senna = new System.Windows.Forms.Button();
            this.timer_f1 = new System.Windows.Forms.Timer(this.components);
            this.button_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hamilton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_schumacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fangio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_prost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vettel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_senna)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_hamilton
            // 
            this.pictureBox_hamilton.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_hamilton.Image")));
            this.pictureBox_hamilton.Location = new System.Drawing.Point(347, 126);
            this.pictureBox_hamilton.Name = "pictureBox_hamilton";
            this.pictureBox_hamilton.Size = new System.Drawing.Size(199, 207);
            this.pictureBox_hamilton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_hamilton.TabIndex = 0;
            this.pictureBox_hamilton.TabStop = false;
            this.pictureBox_hamilton.MouseEnter += new System.EventHandler(this.pictureBox_hamilton_MouseEnter);
            this.pictureBox_hamilton.MouseLeave += new System.EventHandler(this.pictureBox_hamilton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(856, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "F1 World Champions along the years";
            // 
            // pictureBox_schumacher
            // 
            this.pictureBox_schumacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_schumacher.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_schumacher.Image")));
            this.pictureBox_schumacher.Location = new System.Drawing.Point(32, 126);
            this.pictureBox_schumacher.Name = "pictureBox_schumacher";
            this.pictureBox_schumacher.Size = new System.Drawing.Size(184, 207);
            this.pictureBox_schumacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_schumacher.TabIndex = 2;
            this.pictureBox_schumacher.TabStop = false;
            this.pictureBox_schumacher.MouseEnter += new System.EventHandler(this.pictureBox_schumacher_MouseEnter);
            this.pictureBox_schumacher.MouseLeave += new System.EventHandler(this.pictureBox_schumacher_MouseLeave);
            // 
            // button_hamilton
            // 
            this.button_hamilton.Location = new System.Drawing.Point(411, 360);
            this.button_hamilton.Name = "button_hamilton";
            this.button_hamilton.Size = new System.Drawing.Size(75, 37);
            this.button_hamilton.TabIndex = 3;
            this.button_hamilton.Text = "Click for more Info";
            this.button_hamilton.UseVisualStyleBackColor = true;
            this.button_hamilton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_hamilton_MouseClick);
            // 
            // button_schumacher
            // 
            this.button_schumacher.Location = new System.Drawing.Point(82, 360);
            this.button_schumacher.Name = "button_schumacher";
            this.button_schumacher.Size = new System.Drawing.Size(75, 37);
            this.button_schumacher.TabIndex = 4;
            this.button_schumacher.Text = "Click for more Info";
            this.button_schumacher.UseVisualStyleBackColor = true;
            this.button_schumacher.Click += new System.EventHandler(this.button_schumacher_Click);
            // 
            // pictureBox_fangio
            // 
            this.pictureBox_fangio.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_fangio.Image")));
            this.pictureBox_fangio.Location = new System.Drawing.Point(682, 126);
            this.pictureBox_fangio.Name = "pictureBox_fangio";
            this.pictureBox_fangio.Size = new System.Drawing.Size(196, 207);
            this.pictureBox_fangio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_fangio.TabIndex = 5;
            this.pictureBox_fangio.TabStop = false;
            this.pictureBox_fangio.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox_fangio.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // button_fangio
            // 
            this.button_fangio.Location = new System.Drawing.Point(737, 360);
            this.button_fangio.Name = "button_fangio";
            this.button_fangio.Size = new System.Drawing.Size(75, 37);
            this.button_fangio.TabIndex = 6;
            this.button_fangio.Text = "Click for more Info";
            this.button_fangio.UseVisualStyleBackColor = true;
            this.button_fangio.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_prost
            // 
            this.pictureBox_prost.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_prost.Image")));
            this.pictureBox_prost.Location = new System.Drawing.Point(1019, 126);
            this.pictureBox_prost.Name = "pictureBox_prost";
            this.pictureBox_prost.Size = new System.Drawing.Size(202, 207);
            this.pictureBox_prost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_prost.TabIndex = 7;
            this.pictureBox_prost.TabStop = false;
            this.pictureBox_prost.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox_prost.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // button_prost
            // 
            this.button_prost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_prost.BackgroundImage")));
            this.button_prost.Location = new System.Drawing.Point(1086, 360);
            this.button_prost.Name = "button_prost";
            this.button_prost.Size = new System.Drawing.Size(75, 37);
            this.button_prost.TabIndex = 8;
            this.button_prost.Text = "Click for more Info";
            this.button_prost.UseVisualStyleBackColor = true;
            this.button_prost.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox_vettel
            // 
            this.pictureBox_vettel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_vettel.Image")));
            this.pictureBox_vettel.Location = new System.Drawing.Point(1358, 126);
            this.pictureBox_vettel.Name = "pictureBox_vettel";
            this.pictureBox_vettel.Size = new System.Drawing.Size(208, 207);
            this.pictureBox_vettel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_vettel.TabIndex = 9;
            this.pictureBox_vettel.TabStop = false;
            this.pictureBox_vettel.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox_vettel.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // button_vettel
            // 
            this.button_vettel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_vettel.BackgroundImage")));
            this.button_vettel.Location = new System.Drawing.Point(1428, 360);
            this.button_vettel.Name = "button_vettel";
            this.button_vettel.Size = new System.Drawing.Size(75, 37);
            this.button_vettel.TabIndex = 10;
            this.button_vettel.Text = "Click for more Info";
            this.button_vettel.UseVisualStyleBackColor = true;
            this.button_vettel.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox_senna
            // 
            this.pictureBox_senna.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_senna.Image")));
            this.pictureBox_senna.Location = new System.Drawing.Point(1684, 126);
            this.pictureBox_senna.Name = "pictureBox_senna";
            this.pictureBox_senna.Size = new System.Drawing.Size(208, 207);
            this.pictureBox_senna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_senna.TabIndex = 11;
            this.pictureBox_senna.TabStop = false;
            this.pictureBox_senna.MouseEnter += new System.EventHandler(this.pictureBox_senna_MouseEnter);
            // 
            // button_senna
            // 
            this.button_senna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_senna.BackgroundImage")));
            this.button_senna.Location = new System.Drawing.Point(1758, 360);
            this.button_senna.Name = "button_senna";
            this.button_senna.Size = new System.Drawing.Size(75, 37);
            this.button_senna.TabIndex = 12;
            this.button_senna.Text = "Click for more Info";
            this.button_senna.UseVisualStyleBackColor = true;
            this.button_senna.Click += new System.EventHandler(this.button_senna_Click);
            // 
            // timer_f1
            // 
            this.timer_f1.Interval = 10;
            this.timer_f1.Tick += new System.EventHandler(this.timer_f1_Tick);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(1781, 669);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(111, 63);
            this.button_refresh.TabIndex = 14;
            this.button_refresh.Text = "Try again";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1781, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 63);
            this.button1.TabIndex = 15;
            this.button1.Text = "Get a random Circuit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 909);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_senna);
            this.Controls.Add(this.pictureBox_senna);
            this.Controls.Add(this.button_vettel);
            this.Controls.Add(this.pictureBox_vettel);
            this.Controls.Add(this.button_prost);
            this.Controls.Add(this.pictureBox_prost);
            this.Controls.Add(this.button_fangio);
            this.Controls.Add(this.pictureBox_fangio);
            this.Controls.Add(this.button_schumacher);
            this.Controls.Add(this.button_hamilton);
            this.Controls.Add(this.pictureBox_schumacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_hamilton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hamilton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_schumacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fangio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_prost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vettel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_senna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_hamilton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_schumacher;
        private System.Windows.Forms.Button button_hamilton;
        private System.Windows.Forms.Button button_schumacher;
        private System.Windows.Forms.PictureBox pictureBox_fangio;
        private System.Windows.Forms.Button button_fangio;
        private System.Windows.Forms.PictureBox pictureBox_prost;
        private System.Windows.Forms.Button button_prost;
        private System.Windows.Forms.PictureBox pictureBox_vettel;
        private System.Windows.Forms.Button button_vettel;
        private System.Windows.Forms.PictureBox pictureBox_senna;
        private System.Windows.Forms.Button button_senna;
        private System.Windows.Forms.Timer timer_f1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button1;
    }
}

