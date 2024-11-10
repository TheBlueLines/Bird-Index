using TTMC.Auram;

namespace Bird_Index
{
	public partial class Editor : Form
	{
		private Database database;
		private string path;
		public Editor(string path = "Game.auram")
		{
			this.path = path;
			InitializeComponent();
			database = new();
			if (File.Exists(path))
			{
				database.Load(path);
			}
			selectedRound_ValueChanged(null, null);
		}
		private void selectedRound_ValueChanged(object? sender, EventArgs? e)
		{
			ushort selected = (ushort)selectedRound.Value;
			Round? round = ReadFromDatabase(selected);
			chosenBird.Text = round != null ? round.chosenBird : string.Empty;
			audioA.Text = round != null ? round.audioA : string.Empty;
			audioB.Text = round != null ? round.audioB : string.Empty;
			audioC.Text = round != null ? round.audioC : string.Empty;
			audioD.Text = round != null ? round.audioD : string.Empty;
			startRound.Value = round != null ? round.startRound : 1;
			endRound.Value = round != null ? round.endRound : 10;
			soundLength.Value = round != null ? round.soundLength : 10000;
			waitBefore.Value = round != null ? round.waitBefore : 2000;
			waitAfter.Value = round != null ? round.waitAfter : 3000;
		}
		private void save_Click(object sender, EventArgs e)
		{
			ushort selected = (ushort)selectedRound.Value;
			Round round = new()
			{
				chosenBird = chosenBird.Text,
				audioA = audioA.Text,
				audioB = audioB.Text,
				audioC = audioC.Text,
				audioD = audioD.Text,
				startRound = (ushort)startRound.Value,
				endRound = (ushort)endRound.Value,
				soundLength = (ushort)soundLength.Value,
				waitBefore = (ushort)waitBefore.Value,
				waitAfter = (ushort)waitAfter.Value
			};
			WriteToDatabase(selected, round);
		}
		private void WriteToDatabase(ushort num, Round round)
		{
			if (!database.keys.Contains(num.ToString()))
			{
				database.Set(num.ToString(), new Guid());
			}
			database.Set(num.ToString() + "/chosenBird", round.chosenBird ?? string.Empty);
			database.Set(num.ToString() + "/audioA", round.audioA ?? string.Empty);
			database.Set(num.ToString() + "/audioB", round.audioB ?? string.Empty);
			database.Set(num.ToString() + "/audioC", round.audioC ?? string.Empty);
			database.Set(num.ToString() + "/audioD", round.audioD ?? string.Empty);
			database.Set(num.ToString() + "/soundLength", round.soundLength);
			database.Set(num.ToString() + "/waitBefore", round.waitBefore);
			database.Set(num.ToString() + "/waitAfter", round.waitAfter);
			database.Set("startRound", round.startRound);
			database.Set("endRound", round.endRound);
			database.Save(path);
		}
		private Round? ReadFromDatabase(ushort num)
		{
			if (database.keys.Contains(num.ToString()))
			{
				Round round = new()
				{
					chosenBird = database.Get<string>(num.ToString() + "/chosenBird"),
					audioA = database.Get<string>(num.ToString() + "/audioA"),
					audioB = database.Get<string>(num.ToString() + "/audioB"),
					audioC = database.Get<string>(num.ToString() + "/audioC"),
					audioD = database.Get<string>(num.ToString() + "/audioD"),
					soundLength = database.Get<ushort>(num.ToString() + "/soundLength"),
					waitBefore = database.Get<ushort>(num.ToString() + "/waitBefore"),
					waitAfter = database.Get<ushort>(num.ToString() + "/waitAfter"),
					startRound = database.Get<ushort>("startRound"),
					endRound = database.Get<ushort>("endRound")
				};
				return round;
			}
			return null;
		}
		private List<ushort> GetRoundsFromDatabase()
		{
			List<ushort> rounds = new List<ushort>();
			foreach (string key in database.keys.Where(x => !x.Contains("/")))
			{
				if (ushort.TryParse(key, out ushort num))
				{
					rounds.Add(num);
				}
			}
			return rounds;
		}
		private void Editor_FormClosing(object sender, FormClosingEventArgs e)
		{
			database.Close();
		}
	}
	public class Round()
	{
		public string? chosenBird { get; set; }
		public string? audioA { get; set; }
		public string? audioB { get; set; }
		public string? audioC { get; set; }
		public string? audioD { get; set; }
		public ushort startRound { get; set; }
		public ushort endRound { get; set; }
		public ushort soundLength { get; set; }
		public ushort waitBefore { get; set; }
		public ushort waitAfter { get; set; }
	}
}