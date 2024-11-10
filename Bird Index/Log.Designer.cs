namespace Bird_Index
{
	partial class Log
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
			console = new RichTextBox();
			clearLog = new Button();
			saveLog = new Button();
			SuspendLayout();
			// 
			// console
			// 
			console.BorderStyle = BorderStyle.FixedSingle;
			console.Location = new Point(12, 12);
			console.Name = "console";
			console.ReadOnly = true;
			console.Size = new Size(776, 397);
			console.TabIndex = 0;
			console.Text = "";
			// 
			// clearLog
			// 
			clearLog.Location = new Point(12, 415);
			clearLog.Name = "clearLog";
			clearLog.Size = new Size(385, 23);
			clearLog.TabIndex = 1;
			clearLog.Text = "Clear Log";
			clearLog.UseVisualStyleBackColor = true;
			clearLog.Click += clearLog_Click;
			// 
			// saveLog
			// 
			saveLog.Location = new Point(403, 415);
			saveLog.Name = "saveLog";
			saveLog.Size = new Size(385, 23);
			saveLog.TabIndex = 2;
			saveLog.Text = "Save Log";
			saveLog.UseVisualStyleBackColor = true;
			saveLog.Click += saveLog_Click;
			// 
			// Log
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(saveLog);
			Controls.Add(clearLog);
			Controls.Add(console);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Log";
			Text = "Log";
			ResumeLayout(false);
		}

		#endregion

		private RichTextBox console;
		private Button clearLog;
		private Button saveLog;
	}
}