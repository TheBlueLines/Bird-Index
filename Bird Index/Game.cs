using System.Media;
using TTMC.Auram;

namespace Bird_Index
{
	public partial class Game : Form
	{
		bool runGame = false;
		Log log;
		Landscape landscape;
		Task? task = null;
		Task? download = null;
		SoundPlayer soundPlayer = new();
		Database database = new();
		public Game()
		{
			landscape = new();
			landscape.FormClosed += Landscape_FormClosed;
			log = new();
			InitializeComponent();
			landscape.Show();
			newRound.Enabled = true;
			if (Directory.Exists("Assets"))
			{
				downloadAssets.Enabled = false;
				deleteAssets.Enabled = true;
			}
			else
			{
				downloadAssets.Enabled = true;
				deleteAssets.Enabled = false;
			}
			openLog.Enabled = true;
			gameEditor.Enabled = true;
		}
		private void Landscape_FormClosed(object? sender, FormClosedEventArgs e)
		{
			clearRound_Click(null, null);
			openLandscape.Enabled = true;
		}
		private void newRound_Click(object sender, EventArgs e)
		{
			if (!File.Exists("Game.auram"))
			{
				MessageBox.Show("No game file found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			runGame = false;
			soundPlayer.Stop();
			landscape.UpdateRound(0);
			landscape.PlayLetter(0);
			landscape.NewRound();
			database.Clear();
			database.Load("Game.auram");
			landscape.currentRound = database.Get<ushort>("startRound");
			landscape.maxRound = database.Get<ushort>("endRound");
			startRound.Enabled = true;
			clearRound.Enabled = true;
			task = new(Automatize);
		}
		private void Automatize()
		{
			Thread.Sleep(1000);
			for (ushort i = landscape.currentRound; i <= landscape.maxRound && runGame; i++)
			{
				string chosenBird = database.Get<string>(i + "/chosenBird");
				string[] audios = { database.Get<string>(i + "/audioA"), database.Get<string>(i + "/audioB"), database.Get<string>(i + "/audioC"), database.Get<string>(i + "/audioD") };
				ushort soundLength = database.Get<ushort>(i + "/soundLength");
				ushort waitBefore = database.Get<ushort>(i + "/waitBefore");
				ushort waitAfter = database.Get<ushort>(i + "/waitAfter");
				landscape.currentRound = i;
				landscape.UpdateRound(i);
				landscape.SetBirdName(chosenBird);
				for (byte j = 1; j <= 4 && runGame; j++)
				{
					landscape.PlayLetter(j);
					Thread.Sleep(waitBefore);
					if (runGame)
					{
						PlaySound(audios[j - 1], soundLength);
					}
					Thread.Sleep(waitAfter);
				}
			}
			clearRound_Click(null, null);
		}
		private void startRound_Click(object sender, EventArgs e)
		{
			if (task != null)
			{
				startRound.Enabled = false;
				runGame = true;
				task.Start();
				stopRound.Enabled = true;
			}
		}
		private void clearRound_Click(object? sender, EventArgs? e)
		{
			clearRound.Enabled = false;
			newRound.Enabled = true;
			startRound.Enabled = false;
			stopRound.Enabled = false;
			runGame = false;
			soundPlayer.Stop();
			database.Clear();
			database.Close();
			landscape.NewRound(false);
		}
		private void stopRound_Click(object sender, EventArgs e)
		{
			stopRound.Enabled = false;
			runGame = false;
			soundPlayer.Stop();
			newRound.Enabled = true;
		}
		private void downloadAssets_Click(object sender, EventArgs e)
		{
			download = new(DownloadAssets);
			download.Start();
		}
		private void deleteAssets_Click(object sender, EventArgs e)
		{
			deleteAssets.Enabled = false;
			Directory.Delete("Assets", true);
			ConsoleLog("Assets deleted!");
			downloadAssets.Enabled = true;
		}
		private void PlaySound(string fileName, ushort soundLength = 10000)
		{
			soundPlayer.SoundLocation = $"Assets\\{fileName}.wav";
			soundPlayer.Play();
			Thread.Sleep(soundLength);
			soundPlayer.Stop();
		}
		private void DownloadAssets()
		{
			downloadAssets.Enabled = false;
			Directory.CreateDirectory("Assets");
			HttpClient httpClient = new() { BaseAddress = new("https://europamadarai.hu") };
			string[] lines = { "wp-content/uploads/2013/12/apacalud.mp3", "wp-content/uploads/2014/08/apropartfuto.mp3", "wp-content/uploads/2013/11/eszaki_buvar.mp3", "wp-content/uploads/2013/10/Gavia_immer.mp3", "wp-content/uploads/2013/11/Gavia_arctica.mp3", "wp-content/uploads/2013/11/bubos_vocsok.mp3", "wp-content/uploads/2013/11/feketenyaku_vocsok.mp3", "wp-content/uploads/2013/11/fules_vocsok.mp3", "wp-content/uploads/2013/11/kis_vocsok.mp3", "wp-content/uploads/2013/11/vorosnyaku_vocsok.mp3", "wp-content/uploads/2013/11/rozsas_godeny.mp3", "wp-content/uploads/2013/11/Pelecanus_crispus_song.mp3", "wp-content/uploads/2013/11/karokatona.mp3", "wp-content/uploads/2013/11/kis_karokatona.mp3", "wp-content/uploads/2013/11/bakcso.mp3", "wp-content/uploads/2013/11/bolombika.mp3", "wp-content/uploads/2013/11/kis_kocsag.mp3", "wp-content/uploads/2013/11/nagy_kocsag.mp3", "wp-content/uploads/2013/11/szurke_gem.mp3", "wp-content/uploads/2013/11/torpegem.mp3", "wp-content/uploads/2013/11/ustokosgem.mp3", "wp-content/uploads/2013/11/voros_gem.mp3", "wp-content/uploads/2013/11/feher_golya_hangja.mp3", "wp-content/uploads/2013/11/feher_golya_kelepeles.mp3", "wp-content/uploads/2013/11/feketegolya.mp3", "wp-content/uploads/2013/11/kanalasgem.mp3", "wp-content/uploads/2013/11/batla.mp3", "wp-content/uploads/2013/12/butykoshattyu.mp3", "wp-content/uploads/2013/12/enekeshattyu.mp3", "wp-content/uploads/2013/12/nagylilik.mp3", "wp-content/uploads/2013/12/kishattyu.mp3", "wp-content/uploads/2013/12/nyarilud.mp3", "wp-content/uploads/2013/12/vetesilud.mp3", "wp-content/uploads/2013/12/kislilik.mp3", "wp-content/uploads/2013/12/vorosnyakulud.mp3", "wp-content/uploads/2013/12/vorosasolud.mp3", "wp-content/uploads/2013/12/butykosasolud.mp3", "wp-content/uploads/2013/12/butykosasolud1.mp3", "wp-content/uploads/2013/12/kanadailud.mp3", "wp-content/uploads/2013/12/tokesrece.mp3", "wp-content/uploads/2013/12/orvoslud.mp3", "wp-content/uploads/2013/12/baratrece.mp3", "wp-content/uploads/2013/12/ciganyrece.mp3", "wp-content/uploads/2013/12/kendermagosrece.mp3", "wp-content/uploads/2013/12/futyulorece.mp3", "wp-content/uploads/2013/12/csorgorece.mp3", "wp-content/uploads/2013/12/bojtirece.mp3", "wp-content/uploads/2013/12/nyilfarkurece.mp3", "wp-content/uploads/2013/12/kanalasrece.mp3", "wp-content/uploads/2013/12/kontyosrece.mp3", "wp-content/uploads/2013/12/hegyirece.mp3", "wp-content/uploads/2013/12/ustokosrece.mp3", "wp-content/uploads/2013/12/mandarinrece.mp3", "wp-content/uploads/2013/12/kercerece.mp3", "wp-content/uploads/2013/12/pehelyrece.mp3", "wp-content/uploads/2013/12/nagybuko.mp3", "wp-content/uploads/2013/12/kisbuko.mp3", "wp-content/uploads/2013/12/orvosbuko.mp3", "wp-content/uploads/2013/12/halaszsas.mp3", "wp-content/uploads/2013/12/retisas.mp3", "wp-content/uploads/2014/01/daru.mp3", "wp-content/uploads/2014/01/guvat.mp3", "wp-content/uploads/2014/01/kisvizicsibe.mp3", "wp-content/uploads/2014/01/pettyesvizicsibe.mp3", "wp-content/uploads/2014/01/torpevizicsibe.mp3", "wp-content/uploads/2014/01/vizityuk.mp3", "wp-content/uploads/2014/01/szarcsa.mp3", "wp-content/uploads/2014/01/butykosszarcsa.mp3", "wp-content/uploads/2014/01/kekfu.mp3", "wp-content/uploads/2014/01/csigaforgato.mp3", "wp-content/uploads/2014/01/gulipan.mp3", "wp-content/uploads/2014/01/golyatocs.mp3", "wp-content/uploads/2014/01/kislile.mp3", "wp-content/uploads/2014/01/szekilile.mp3", "wp-content/uploads/2014/01/partilile.mp3", "wp-content/uploads/2014/03/vekonycsoru_viztaposo.mp3", "wp-content/uploads/2014/03/laposcsoru_víztaposo.mp3", "wp-content/uploads/2014/06/sarkipartfuto.mp3", "wp-content/uploads/2014/08/sarlospartfuto.mp3", "wp-content/uploads/2014/01/ezustlile.mp3", "wp-content/uploads/2015/03/bubosbanka.mp3", "wp-content/uploads/2022/01/facan-hangja.mp3", "wp-content/uploads/2021/11/fulemule-hangja.mp3", "wp-content/uploads/2021/11/fenyorigo-eneke.mp3", "wp-content/uploads/2021/11/fenyorigo-hangja.mp3", "wp-content/uploads/2021/10/fekete-rigo-hangja2.mp3", "wp-content/uploads/2021/10/fekete-rigo-hangja.mp3", "wp-content/uploads/2021/09/fekete-harkaly-hangja.mp3" };
			foreach (string url in lines)
			{
				string fileName = url[(url.LastIndexOf('/') + 1)..];
				string path = "Assets\\" + fileName;
				Stream stream = httpClient.GetStreamAsync(url).Result;
				FileStream fileStream = File.OpenWrite(path);
				stream.CopyTo(fileStream);
				fileStream.Close();
				stream.Close();
				ConsoleLog(fileName + " downloaded!");
			}
			deleteAssets.Enabled = true;
			ConsoleLog("Assets downloaded!");
		}
		private void ConsoleLog(string message)
		{
			info.Text = message;
			log.ConsoleLog(message);
		}
		private void openLog_Click(object sender, EventArgs e)
		{
			log.Show();
		}
		private void openLandscape_Click(object sender, EventArgs e)
		{
			landscape = new();
			landscape.FormClosed += Landscape_FormClosed;
			landscape.Show();
			openLandscape.Enabled = false;
		}
		private void gameEditor_Click(object sender, EventArgs e)
		{
			Editor editor = new();
			editor.ShowDialog();
		}
	}
}