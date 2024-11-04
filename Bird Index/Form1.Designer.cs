namespace Bird_Index
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			birdList = new ListBox();
			propertyGrid1 = new PropertyGrid();
			ffts = new PictureBox();
			wave = new PictureBox();
			audioButton = new Button();
			download = new Button();
			((System.ComponentModel.ISupportInitialize)ffts).BeginInit();
			((System.ComponentModel.ISupportInitialize)wave).BeginInit();
			SuspendLayout();
			// 
			// birdList
			// 
			birdList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			birdList.FormattingEnabled = true;
			birdList.ItemHeight = 15;
			birdList.Location = new Point(12, 12);
			birdList.Name = "birdList";
			birdList.Size = new Size(480, 169);
			birdList.TabIndex = 0;
			birdList.SelectedIndexChanged += birdList_SelectedIndexChanged;
			// 
			// propertyGrid1
			// 
			propertyGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			propertyGrid1.Enabled = false;
			propertyGrid1.Location = new Point(498, 12);
			propertyGrid1.Name = "propertyGrid1";
			propertyGrid1.Size = new Size(290, 368);
			propertyGrid1.TabIndex = 1;
			// 
			// ffts
			// 
			ffts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			ffts.BackColor = SystemColors.ControlLight;
			ffts.BorderStyle = BorderStyle.FixedSingle;
			ffts.Location = new Point(12, 187);
			ffts.Name = "ffts";
			ffts.Size = new Size(480, 160);
			ffts.TabIndex = 2;
			ffts.TabStop = false;
			// 
			// wave
			// 
			wave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			wave.BackColor = SystemColors.ControlLight;
			wave.BorderStyle = BorderStyle.FixedSingle;
			wave.Location = new Point(12, 358);
			wave.Name = "wave";
			wave.Size = new Size(480, 80);
			wave.TabIndex = 3;
			wave.TabStop = false;
			// 
			// audioButton
			// 
			audioButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			audioButton.Enabled = false;
			audioButton.Location = new Point(498, 415);
			audioButton.Name = "audioButton";
			audioButton.Size = new Size(290, 23);
			audioButton.TabIndex = 4;
			audioButton.Text = "Play Audio";
			audioButton.UseVisualStyleBackColor = true;
			audioButton.Click += audioButton_Click;
			// 
			// download
			// 
			download.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			download.Enabled = false;
			download.Location = new Point(498, 386);
			download.Name = "download";
			download.Size = new Size(290, 23);
			download.TabIndex = 5;
			download.Text = "Download";
			download.UseVisualStyleBackColor = true;
			download.Click += download_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(download);
			Controls.Add(audioButton);
			Controls.Add(wave);
			Controls.Add(ffts);
			Controls.Add(propertyGrid1);
			Controls.Add(birdList);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "Bird Index";
			((System.ComponentModel.ISupportInitialize)ffts).EndInit();
			((System.ComponentModel.ISupportInitialize)wave).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private ListBox birdList;
		private PropertyGrid propertyGrid1;
		private PictureBox ffts;
		private PictureBox wave;
		private Button audioButton;
		private Button download;
	}
}
