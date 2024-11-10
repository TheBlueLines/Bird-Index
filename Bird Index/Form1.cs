using System.Media;
using TTMC.Bird;

namespace Bird_Index
{
	public partial class Form1 : Form
	{
		SoundPlayer soundPlayer = new();
		API api;
		Recordings recordings;
		Recording? recording = null;
		private readonly string audioDir = "Audio";
		public Form1()
		{
			api = new();
			recordings = api.GetRecordings();
			if (!Directory.Exists(audioDir))
			{
				Directory.CreateDirectory(audioDir);
			}
			InitializeComponent();
			LoadBirdList();
		}
		private void LoadBirdList()
		{
			if (recordings.recordings != null)
			{
				foreach (Recording recording in recordings.recordings)
				{
					birdList.Items.Add(recording.en ?? "NULL");
				}
			}
		}
		private void birdList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (birdList.SelectedIndex >= 0 && recordings.recordings != null)
			{
				soundPlayer.Stop();
				audioButton.Text = "Play Audio";
				recording = recordings.recordings[birdList.SelectedIndex];
				propertyGrid1.SelectedObject = recording;
				if (recording.sono != null && !string.IsNullOrEmpty(recording.sono.med))
				{
					ffts.Image = DownloadImage("https:" + recording.sono.med);
				}
				if (recording.osci != null && !string.IsNullOrEmpty(recording.osci.med))
				{
					wave.Image = DownloadImage("https:" + recording.osci.med);
				}
				propertyGrid1.Enabled = true;
				audioButton.Enabled = true;
				download.Enabled = true;
			}
			else
			{
				recording = null;
				propertyGrid1.SelectedObject = null;
				propertyGrid1.Enabled = false;
				audioButton.Enabled = false;
				download.Enabled = false;
			}
		}
		private Image DownloadImage(string url)
		{
			HttpClient client = new();
			Stream stream = client.GetStreamAsync(url).Result;
			return Image.FromStream(stream);
		}
		private void audioButton_Click(object sender, EventArgs e)
		{
			if (audioButton.Text == "Stop Audio")
			{
				soundPlayer.Stop();
				audioButton.Text = "Play Audio";
			}
			else if (recording != null && !string.IsNullOrEmpty(recording.file) && audioButton.Text == "Play Audio")
			{
				string path = audioDir + Path.DirectorySeparatorChar + recording.fileName;
				DownloadAudio(recording.file, path);
				if (path.EndsWith(".wav"))
				{
					soundPlayer.SoundLocation = path;
					audioButton.Text = "Stop Audio";
					soundPlayer.Play();
				}
				else
				{
					MessageBox.Show("Only WAV files are supported.");
				}
			}
		}
		private void download_Click(object sender, EventArgs e)
		{
			if (recording != null && !string.IsNullOrEmpty(recording.file))
			{
				string path = audioDir + Path.DirectorySeparatorChar + recording.fileName;
				DownloadAudio(recording.file, path);
			}
		}
		private void DownloadAudio(string url, string path)
		{
			HttpClient client = new();
			Stream stream = client.GetStreamAsync(url).Result;
			FileStream file = File.Open(path, FileMode.Create);
			stream.CopyTo(file);
			file.Close();
			stream.Close();
		}
		private void gameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Game game = new();
			game.Show();
		}
	}
}
