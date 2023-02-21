namespace CEA
	{
	partial class frmSplash
		{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
			{
			if (disposing && (components != null))
				{
				components.Dispose ();
				}
			base.Dispose (disposing);
			}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
			{
			this.components = new System.ComponentModel.Container ();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (frmSplash));
			this.label1 = new System.Windows.Forms.Label ();
			this.pictureBox1 = new System.Windows.Forms.PictureBox ();
			this.timer1 = new System.Windows.Forms.Timer (this.components);
			this.timer2 = new System.Windows.Forms.Timer (this.components);
			this.label2 = new System.Windows.Forms.Label ();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit ();
			this.SuspendLayout ();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font ("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point (111, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size (162, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "CEA2006";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject ("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point (12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size (93, 93);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler (this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler (this.timer2_Tick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font ("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point (111, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size (162, 64);
			this.label2.TabIndex = 2;
			this.label2.Text = "Maj Steve Burns\r\n317 OSS/OSK - Dyess AFB, TX";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmSplash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size (285, 117);
			this.Controls.Add (this.label2);
			this.Controls.Add (this.pictureBox1);
			this.Controls.Add (this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSplash";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit ();
			this.ResumeLayout (false);

			}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label label2;
		}
	}