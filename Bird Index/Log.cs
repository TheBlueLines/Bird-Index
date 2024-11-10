using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Index
{
	public partial class Log : Form
	{
		public Log()
		{
			InitializeComponent();
		}
		private void clearLog_Click(object sender, EventArgs e)
		{
			console.Clear();
		}
		public void ConsoleLog(string message)
		{
			console.AppendText($"{DateTime.Now:HH:mm:ss} - {message}\n");
		}
		private void saveLog_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new()
			{
				Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
			};
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveFileDialog.FileName, console.Text);
			}
		}
	}
}
