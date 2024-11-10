namespace Bird_Index
{
	partial class Landscape
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landscape));
			round = new Label();
			letterA = new Label();
			letterB = new Label();
			letterC = new Label();
			letterD = new Label();
			birdName = new Label();
			ttmcPicture = new PictureBox();
			puskasPicture = new PictureBox();
			((System.ComponentModel.ISupportInitialize)ttmcPicture).BeginInit();
			((System.ComponentModel.ISupportInitialize)puskasPicture).BeginInit();
			SuspendLayout();
			// 
			// round
			// 
			round.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			round.BackColor = Color.Transparent;
			round.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
			round.Location = new Point(12, 9);
			round.Name = "round";
			round.Size = new Size(778, 100);
			round.TabIndex = 0;
			round.Text = "Round: 0/10";
			round.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// letterA
			// 
			letterA.Anchor = AnchorStyles.Top;
			letterA.BackColor = Color.Transparent;
			letterA.BorderStyle = BorderStyle.FixedSingle;
			letterA.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 238);
			letterA.ForeColor = Color.DimGray;
			letterA.Location = new Point(0, 150);
			letterA.Name = "letterA";
			letterA.Size = new Size(200, 200);
			letterA.TabIndex = 1;
			letterA.Text = "A";
			letterA.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// letterB
			// 
			letterB.Anchor = AnchorStyles.Top;
			letterB.BackColor = Color.Transparent;
			letterB.BorderStyle = BorderStyle.FixedSingle;
			letterB.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 238);
			letterB.ForeColor = Color.DimGray;
			letterB.Location = new Point(200, 150);
			letterB.Name = "letterB";
			letterB.Size = new Size(200, 200);
			letterB.TabIndex = 2;
			letterB.Text = "B";
			letterB.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// letterC
			// 
			letterC.Anchor = AnchorStyles.Top;
			letterC.BackColor = Color.Transparent;
			letterC.BorderStyle = BorderStyle.FixedSingle;
			letterC.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 238);
			letterC.ForeColor = Color.DimGray;
			letterC.Location = new Point(400, 150);
			letterC.Name = "letterC";
			letterC.Size = new Size(200, 200);
			letterC.TabIndex = 3;
			letterC.Text = "C";
			letterC.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// letterD
			// 
			letterD.Anchor = AnchorStyles.Top;
			letterD.BackColor = Color.Transparent;
			letterD.BorderStyle = BorderStyle.FixedSingle;
			letterD.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 238);
			letterD.ForeColor = Color.DimGray;
			letterD.Location = new Point(600, 150);
			letterD.Name = "letterD";
			letterD.Size = new Size(200, 200);
			letterD.TabIndex = 4;
			letterD.Text = "D";
			letterD.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// birdName
			// 
			birdName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			birdName.BackColor = Color.Transparent;
			birdName.Font = new Font("Segoe UI", 72F, FontStyle.Italic, GraphicsUnit.Point, 238);
			birdName.Location = new Point(12, 291);
			birdName.Name = "birdName";
			birdName.Size = new Size(778, 150);
			birdName.TabIndex = 5;
			birdName.Text = "Madár neve";
			birdName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// ttmcPicture
			// 
			ttmcPicture.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			ttmcPicture.BackgroundImageLayout = ImageLayout.Stretch;
			ttmcPicture.Image = Properties.Resources.TTMC_ICON_BLACK;
			ttmcPicture.Location = new Point(12, 291);
			ttmcPicture.Name = "ttmcPicture";
			ttmcPicture.Size = new Size(150, 150);
			ttmcPicture.SizeMode = PictureBoxSizeMode.StretchImage;
			ttmcPicture.TabIndex = 6;
			ttmcPicture.TabStop = false;
			// 
			// puskasPicture
			// 
			puskasPicture.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			puskasPicture.BackgroundImageLayout = ImageLayout.Stretch;
			puskasPicture.Image = Properties.Resources.puskas_icon;
			puskasPicture.Location = new Point(640, 291);
			puskasPicture.Name = "puskasPicture";
			puskasPicture.Size = new Size(150, 150);
			puskasPicture.SizeMode = PictureBoxSizeMode.StretchImage;
			puskasPicture.TabIndex = 7;
			puskasPicture.TabStop = false;
			// 
			// Landscape
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImageLayout = ImageLayout.Center;
			ClientSize = new Size(802, 450);
			Controls.Add(puskasPicture);
			Controls.Add(ttmcPicture);
			Controls.Add(birdName);
			Controls.Add(round);
			Controls.Add(letterD);
			Controls.Add(letterC);
			Controls.Add(letterB);
			Controls.Add(letterA);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Landscape";
			Text = "Landscape";
			Resize += Landscape_Resize;
			((System.ComponentModel.ISupportInitialize)ttmcPicture).EndInit();
			((System.ComponentModel.ISupportInitialize)puskasPicture).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label round;
		private Label letterA;
		private Label letterB;
		private Label letterC;
		private Label letterD;
		private Label birdName;
		private PictureBox ttmcPicture;
		private PictureBox puskasPicture;
	}
}