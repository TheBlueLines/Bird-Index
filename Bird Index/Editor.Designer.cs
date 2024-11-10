namespace Bird_Index
{
	partial class Editor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
			selectedRound = new NumericUpDown();
			label1 = new Label();
			save = new Button();
			chosenBird = new TextBox();
			label2 = new Label();
			label3 = new Label();
			audioA = new TextBox();
			audioB = new TextBox();
			audioC = new TextBox();
			audioD = new TextBox();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			startRound = new NumericUpDown();
			endRound = new NumericUpDown();
			soundLength = new NumericUpDown();
			waitBefore = new NumericUpDown();
			label8 = new Label();
			label9 = new Label();
			waitAfter = new NumericUpDown();
			label10 = new Label();
			label11 = new Label();
			((System.ComponentModel.ISupportInitialize)selectedRound).BeginInit();
			((System.ComponentModel.ISupportInitialize)startRound).BeginInit();
			((System.ComponentModel.ISupportInitialize)endRound).BeginInit();
			((System.ComponentModel.ISupportInitialize)soundLength).BeginInit();
			((System.ComponentModel.ISupportInitialize)waitBefore).BeginInit();
			((System.ComponentModel.ISupportInitialize)waitAfter).BeginInit();
			SuspendLayout();
			// 
			// selectedRound
			// 
			selectedRound.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			selectedRound.Location = new Point(268, 12);
			selectedRound.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			selectedRound.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			selectedRound.Name = "selectedRound";
			selectedRound.Size = new Size(520, 43);
			selectedRound.TabIndex = 0;
			selectedRound.Value = new decimal(new int[] { 1, 0, 0, 0 });
			selectedRound.ValueChanged += selectedRound_ValueChanged;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 20F);
			label1.Location = new Point(12, 12);
			label1.Name = "label1";
			label1.Size = new Size(250, 43);
			label1.TabIndex = 1;
			label1.Text = "Selected round:";
			// 
			// save
			// 
			save.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
			save.Location = new Point(12, 551);
			save.Name = "save";
			save.Size = new Size(776, 43);
			save.TabIndex = 2;
			save.Text = "Save";
			save.UseVisualStyleBackColor = true;
			save.Click += save_Click;
			// 
			// chosenBird
			// 
			chosenBird.Font = new Font("Segoe UI", 20F);
			chosenBird.Location = new Point(268, 61);
			chosenBird.Name = "chosenBird";
			chosenBird.Size = new Size(520, 43);
			chosenBird.TabIndex = 3;
			// 
			// label2
			// 
			label2.Font = new Font("Segoe UI", 20F);
			label2.Location = new Point(12, 61);
			label2.Name = "label2";
			label2.Size = new Size(250, 43);
			label2.TabIndex = 4;
			label2.Text = "Chosen bird:";
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 20F);
			label3.Location = new Point(12, 110);
			label3.Name = "label3";
			label3.Size = new Size(250, 43);
			label3.TabIndex = 5;
			label3.Text = "Audio A:";
			// 
			// audioA
			// 
			audioA.Font = new Font("Segoe UI", 20F);
			audioA.Location = new Point(268, 110);
			audioA.Name = "audioA";
			audioA.Size = new Size(520, 43);
			audioA.TabIndex = 6;
			// 
			// audioB
			// 
			audioB.Font = new Font("Segoe UI", 20F);
			audioB.Location = new Point(268, 159);
			audioB.Name = "audioB";
			audioB.Size = new Size(520, 43);
			audioB.TabIndex = 7;
			// 
			// audioC
			// 
			audioC.Font = new Font("Segoe UI", 20F);
			audioC.Location = new Point(268, 208);
			audioC.Name = "audioC";
			audioC.Size = new Size(520, 43);
			audioC.TabIndex = 8;
			// 
			// audioD
			// 
			audioD.Font = new Font("Segoe UI", 20F);
			audioD.Location = new Point(268, 257);
			audioD.Name = "audioD";
			audioD.Size = new Size(520, 43);
			audioD.TabIndex = 9;
			// 
			// label4
			// 
			label4.Font = new Font("Segoe UI", 20F);
			label4.Location = new Point(12, 159);
			label4.Name = "label4";
			label4.Size = new Size(250, 43);
			label4.TabIndex = 10;
			label4.Text = "Audio B:";
			// 
			// label5
			// 
			label5.Font = new Font("Segoe UI", 20F);
			label5.Location = new Point(12, 208);
			label5.Name = "label5";
			label5.Size = new Size(250, 43);
			label5.TabIndex = 11;
			label5.Text = "Audio C:";
			// 
			// label6
			// 
			label6.Font = new Font("Segoe UI", 20F);
			label6.Location = new Point(12, 257);
			label6.Name = "label6";
			label6.Size = new Size(250, 43);
			label6.TabIndex = 12;
			label6.Text = "Audio D:";
			// 
			// label7
			// 
			label7.Font = new Font("Segoe UI", 20F);
			label7.Location = new Point(12, 306);
			label7.Name = "label7";
			label7.Size = new Size(250, 43);
			label7.TabIndex = 13;
			label7.Text = "Start Round:";
			// 
			// startRound
			// 
			startRound.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			startRound.Location = new Point(268, 306);
			startRound.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			startRound.Name = "startRound";
			startRound.Size = new Size(520, 43);
			startRound.TabIndex = 14;
			startRound.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// endRound
			// 
			endRound.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			endRound.Location = new Point(268, 355);
			endRound.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			endRound.Name = "endRound";
			endRound.Size = new Size(520, 43);
			endRound.TabIndex = 15;
			endRound.Value = new decimal(new int[] { 10, 0, 0, 0 });
			// 
			// soundLength
			// 
			soundLength.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			soundLength.Location = new Point(268, 404);
			soundLength.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
			soundLength.Name = "soundLength";
			soundLength.Size = new Size(520, 43);
			soundLength.TabIndex = 16;
			soundLength.Value = new decimal(new int[] { 10000, 0, 0, 0 });
			// 
			// waitBefore
			// 
			waitBefore.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			waitBefore.Location = new Point(268, 453);
			waitBefore.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
			waitBefore.Name = "waitBefore";
			waitBefore.Size = new Size(520, 43);
			waitBefore.TabIndex = 17;
			waitBefore.Value = new decimal(new int[] { 2000, 0, 0, 0 });
			// 
			// label8
			// 
			label8.Font = new Font("Segoe UI", 20F);
			label8.Location = new Point(12, 355);
			label8.Name = "label8";
			label8.Size = new Size(250, 43);
			label8.TabIndex = 18;
			label8.Text = "End Round:";
			// 
			// label9
			// 
			label9.Font = new Font("Segoe UI", 20F);
			label9.Location = new Point(12, 404);
			label9.Name = "label9";
			label9.Size = new Size(250, 43);
			label9.TabIndex = 19;
			label9.Text = "Sound Length:";
			// 
			// waitAfter
			// 
			waitAfter.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
			waitAfter.Location = new Point(268, 502);
			waitAfter.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
			waitAfter.Name = "waitAfter";
			waitAfter.Size = new Size(520, 43);
			waitAfter.TabIndex = 20;
			waitAfter.Value = new decimal(new int[] { 3000, 0, 0, 0 });
			// 
			// label10
			// 
			label10.Font = new Font("Segoe UI", 20F);
			label10.Location = new Point(12, 453);
			label10.Name = "label10";
			label10.Size = new Size(250, 43);
			label10.TabIndex = 21;
			label10.Text = "Wait Before:";
			// 
			// label11
			// 
			label11.Font = new Font("Segoe UI", 20F);
			label11.Location = new Point(12, 502);
			label11.Name = "label11";
			label11.Size = new Size(250, 43);
			label11.TabIndex = 22;
			label11.Text = "Wait After:";
			// 
			// Editor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 606);
			Controls.Add(label11);
			Controls.Add(label10);
			Controls.Add(waitAfter);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(waitBefore);
			Controls.Add(soundLength);
			Controls.Add(endRound);
			Controls.Add(startRound);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(audioD);
			Controls.Add(audioC);
			Controls.Add(audioB);
			Controls.Add(audioA);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(chosenBird);
			Controls.Add(save);
			Controls.Add(label1);
			Controls.Add(selectedRound);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Editor";
			Text = "Editor";
			FormClosing += Editor_FormClosing;
			((System.ComponentModel.ISupportInitialize)selectedRound).EndInit();
			((System.ComponentModel.ISupportInitialize)startRound).EndInit();
			((System.ComponentModel.ISupportInitialize)endRound).EndInit();
			((System.ComponentModel.ISupportInitialize)soundLength).EndInit();
			((System.ComponentModel.ISupportInitialize)waitBefore).EndInit();
			((System.ComponentModel.ISupportInitialize)waitAfter).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NumericUpDown selectedRound;
		private Label label1;
		private Button save;
		private TextBox chosenBird;
		private Label label2;
		private Label label3;
		private TextBox audioA;
		private TextBox audioB;
		private TextBox audioC;
		private TextBox audioD;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private NumericUpDown startRound;
		private NumericUpDown endRound;
		private NumericUpDown soundLength;
		private NumericUpDown waitBefore;
		private Label label8;
		private Label label9;
		private NumericUpDown waitAfter;
		private Label label10;
		private Label label11;
	}
}