namespace Bird_Index
{
	partial class Game
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
			newRound = new Button();
			startRound = new Button();
			stopRound = new Button();
			clearRound = new Button();
			info = new Label();
			downloadAssets = new Button();
			deleteAssets = new Button();
			gameEditor = new Button();
			openLandscape = new Button();
			openLog = new Button();
			SuspendLayout();
			// 
			// newRound
			// 
			newRound.Enabled = false;
			newRound.Location = new Point(12, 12);
			newRound.Name = "newRound";
			newRound.Size = new Size(200, 50);
			newRound.TabIndex = 0;
			newRound.Text = "New Round";
			newRound.UseVisualStyleBackColor = true;
			newRound.Click += newRound_Click;
			// 
			// startRound
			// 
			startRound.Enabled = false;
			startRound.Location = new Point(218, 12);
			startRound.Name = "startRound";
			startRound.Size = new Size(200, 50);
			startRound.TabIndex = 1;
			startRound.Text = "Start Round";
			startRound.UseVisualStyleBackColor = true;
			startRound.Click += startRound_Click;
			// 
			// stopRound
			// 
			stopRound.Enabled = false;
			stopRound.Location = new Point(218, 68);
			stopRound.Name = "stopRound";
			stopRound.Size = new Size(200, 50);
			stopRound.TabIndex = 2;
			stopRound.Text = "Stop Round";
			stopRound.UseVisualStyleBackColor = true;
			stopRound.Click += stopRound_Click;
			// 
			// clearRound
			// 
			clearRound.Enabled = false;
			clearRound.Location = new Point(12, 68);
			clearRound.Name = "clearRound";
			clearRound.Size = new Size(200, 50);
			clearRound.TabIndex = 3;
			clearRound.Text = "Clear Round";
			clearRound.UseVisualStyleBackColor = true;
			clearRound.Click += clearRound_Click;
			// 
			// info
			// 
			info.Location = new Point(12, 177);
			info.Name = "info";
			info.Size = new Size(612, 20);
			info.TabIndex = 4;
			info.Text = "Game Control Panel";
			info.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// downloadAssets
			// 
			downloadAssets.Enabled = false;
			downloadAssets.Location = new Point(424, 12);
			downloadAssets.Name = "downloadAssets";
			downloadAssets.Size = new Size(200, 50);
			downloadAssets.TabIndex = 5;
			downloadAssets.Text = "Download Assets";
			downloadAssets.UseVisualStyleBackColor = true;
			downloadAssets.Click += downloadAssets_Click;
			// 
			// deleteAssets
			// 
			deleteAssets.Enabled = false;
			deleteAssets.Location = new Point(424, 68);
			deleteAssets.Name = "deleteAssets";
			deleteAssets.Size = new Size(200, 50);
			deleteAssets.TabIndex = 6;
			deleteAssets.Text = "Delete Assets";
			deleteAssets.UseVisualStyleBackColor = true;
			deleteAssets.Click += deleteAssets_Click;
			// 
			// gameEditor
			// 
			gameEditor.Enabled = false;
			gameEditor.Location = new Point(424, 124);
			gameEditor.Name = "gameEditor";
			gameEditor.Size = new Size(200, 50);
			gameEditor.TabIndex = 8;
			gameEditor.Text = "Game Editor";
			gameEditor.UseVisualStyleBackColor = true;
			gameEditor.Click += gameEditor_Click;
			// 
			// openLandscape
			// 
			openLandscape.Enabled = false;
			openLandscape.Location = new Point(218, 124);
			openLandscape.Name = "openLandscape";
			openLandscape.Size = new Size(200, 50);
			openLandscape.TabIndex = 7;
			openLandscape.Text = "Open Landscape";
			openLandscape.UseVisualStyleBackColor = true;
			openLandscape.Click += openLandscape_Click;
			// 
			// openLog
			// 
			openLog.Enabled = false;
			openLog.Location = new Point(12, 124);
			openLog.Name = "openLog";
			openLog.Size = new Size(200, 50);
			openLog.TabIndex = 9;
			openLog.Text = "Open Log";
			openLog.UseVisualStyleBackColor = true;
			openLog.Click += openLog_Click;
			// 
			// Game
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(636, 206);
			Controls.Add(openLog);
			Controls.Add(gameEditor);
			Controls.Add(openLandscape);
			Controls.Add(deleteAssets);
			Controls.Add(downloadAssets);
			Controls.Add(info);
			Controls.Add(clearRound);
			Controls.Add(stopRound);
			Controls.Add(startRound);
			Controls.Add(newRound);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Game";
			Text = "Game";
			ResumeLayout(false);
		}

		#endregion

		private Button newRound;
		private Button startRound;
		private Button stopRound;
		private Button clearRound;
		private Label info;
		private Button downloadAssets;
		private Button deleteAssets;
		private Button gameEditor;
		private Button openLandscape;
		private Button openLog;
	}
}