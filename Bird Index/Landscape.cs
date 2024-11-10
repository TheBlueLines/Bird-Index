namespace Bird_Index
{
	public partial class Landscape : Form
	{
		public ushort maxRound = 10;
		public ushort currentRound = 0;
		private Color before = Color.Silver;
		private Color after = Color.DimGray;
		private Color current = Color.Green;
		public Landscape()
		{
			InitializeComponent();
			NewRound(false);
		}
		public void NewRound(bool mode = true)
		{
			BackgroundImage = mode ? null : Properties.Resources.puskas_icon;
			BackgroundImageLayout = mode ? ImageLayout.Tile : ImageLayout.Center;
			VisibleLabel(mode);
		}
		private void VisibleLabel(bool visible = true)
		{
			foreach (Label label in Controls.OfType<Label>())
			{
				label.Visible = visible;
			}
			ttmcPicture.Visible = visible;
			puskasPicture.Visible = visible;
		}
		private void Landscape_Resize(object sender, EventArgs e)
		{
			letterA.Width = (Width - 18) / 4;
			letterB.Width = (Width - 18) / 4;
			letterC.Width = (Width - 18) / 4;
			letterD.Width = (Width - 18) / 4;
			letterA.Location = new(0, 200);
			letterB.Location = new((Width - 18) / 4, 200);
			letterC.Location = new((Width - 18) / 2, 200);
			letterD.Location = new((int)((Width - 18) / (8f / 6f)), 200);
		}
		public void PlayLetter(byte num)
		{
			letterA.ForeColor = num > 1 ? before : num < 1 ? after : current;
			letterB.ForeColor = num > 2 ? before : num < 2 ? after : current;
			letterC.ForeColor = num > 3 ? before : num < 3 ? after : current;
			letterD.ForeColor = num > 4 ? before : num < 4 ? after : current;
		}
		public void UpdateRound(ushort num)
		{
			currentRound = num;
			round.Text = $"Round: {currentRound}/{maxRound}";
		}
		public void SetBirdName(string name)
		{
			birdName.Text = name;
		}
	}
}