using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace MyMediaPlayer
{
	public partial class frmMain : Form
	{
		WindowsMediaPlayer wp = new WindowsMediaPlayer();
		IWMPPlaylist playlist;
		FileInfo fi;
		Analyzer analyzer;
		public frmMain()
		{
			InitializeComponent();
			wp.CurrentItemChange += (e) => { updatePlaylist(wp.currentMedia); };
			timer1.Enabled = true;
		}
		//Update playing
		void updatePlaylist(IWMPMedia media)
		{
			ListViewItem lvi;
			int i = 0;
			for (; i < wp.currentPlaylist.count; i++)
			{
				if (media.sourceURL.Equals(wp.currentPlaylist.Item[i].sourceURL)) break;
			}
			for (int j = 0; j < lvPlaylist.Items.Count; j++)
			{
				if (j == i)
				{
					lvi = lvPlaylist.Items[j];
					lvi.SubItems[0].Text = "-->";
				}
				else
				{
					lvi = lvPlaylist.Items[j];
					lvi.SubItems[0].Text = "";
				}
				lbPlaying.Text = "Playing : " + media.name;
				hScrollBar1.Value = 0;
				hScrollBar1.Maximum = Convert.ToInt16(media.duration);
				lbCurrDuration.Text = setDuration();
			}
		}

		//Add playlist
		private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			getPlaylist();
			if (playlist.count < 1)
			{
				MessageBox.Show("Can't find *.mp3 or *.wav file");
				lbName.Text = lbDuration.Text = lbBirate.Text = lbFilePath.Text = lbSize.Text = "";
				hScrollBar1.Enabled = false;
			}
		}
		//Set default application
		private void Form1_Load(object sender, EventArgs e)
		{
			tbVolume.Value = 70;
			try
			{
				showPlaylist(Properties.Settings.Default.MyPath);
				showInfor(wp.currentPlaylist.Item[0]);
			}
			catch { hScrollBar1.Enabled = false; }
			wp.controls.stop();
			analyzer = new Analyzer(pbLeft, pbRight, spectrum1, comboBox1, chart1);
			analyzer.Enable = false;
			analyzer.DisplayEnable = false;
			label4.Image = Properties.Resources.volume_on;
		}

		//Scroll play 
		private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			if (hScrollBar1.Value == hScrollBar1.Maximum)
			{
				wp.controls.currentPosition = hScrollBar1.Value;
				return;
			}
			try
			{
				lbCurrDuration.Text = setDuration();
			}
			catch
			{
				return;
			}
			//If stoped -> Re-Run
			if (wp.playState == WMPPlayState.wmppsStopped)
			{
				wp.controls.play();
				wp.controls.currentPosition = hScrollBar1.Value;
				lbCurrDuration.Text = setDuration();
			}
			else
			{
				wp.controls.currentPosition = hScrollBar1.Value;
				lbCurrDuration.Text = setDuration();
			}
			toolTip1.SetToolTip(hScrollBar1, setDuration());
		}
		// Set duration for lable 
		public string setDuration()
		{
			int m = hScrollBar1.Value / 60;
			int s = hScrollBar1.Value % 60;
			return (m < 10 ? "0" + m : m.ToString()) + " : " + (s < 10 ? "0" + s : s.ToString());
		}
		//Open file mp3
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			timer3.Stop();
			OpenFileDialog op = new OpenFileDialog();
			op.Filter = "(*.mp3)|*.mp3|(*.wav)|*.wav";
			//op.InitialDirectory = @"D:\My favorite\Music";
			if (op.ShowDialog() == DialogResult.OK)
			{
				wp.controls.stop();
				lvPlaylist.SelectedItems.Clear();
				wp.URL = op.FileName;
				hScrollBar1.Enabled = true;
				timer2.Start();
				timer3.Start();
			}
		}
		// Show file information
		private void timer2_Tick(object sender, EventArgs e)
		{
			if (wp.openState == WMPOpenState.wmposMediaOpen)
			{
				timer2.Stop();
				hScrollBar1.Maximum = Convert.ToInt16(wp.currentMedia.duration);
				showInfor(wp.currentMedia);
			}
		}
		//Show file infor playing...
		void showInfor(IWMPMedia media)
		{
			lbName.Text = media.name;
			lbDuration.Text = media.durationString + " ( " + media.duration + " samples)";
			lbFilePath.Text = media.sourceURL;
			fi = new FileInfo(media.sourceURL);
			lbSize.Text = String.Format("{0:0.00}", fi.Length * 0.000001) + " MB";
			lbBirate.Text = Convert.ToInt32(media.getItemInfo("BitRate")) / 1000 + " kbps";
		}
		//Button Play
		private void btPlay_Click(object sender, EventArgs e)
		{
			if (lvPlaylist.SelectedItems.Count > 0 && wp.playState != WMPPlayState.wmppsPaused)
			{
				int index = lvPlaylist.SelectedIndices[0];
				wp.controls.playItem(wp.currentPlaylist.Item[index]);
			}
			else wp.controls.play();
			timer3.Start();
			analyzer.Enable = true;
			analyzer.DisplayEnable = true;

		}
		//Button Pause
		private void btPause_Click(object sender, EventArgs e)
		{
			wp.controls.pause();
			timer3.Stop();
			analyzer.Enable = false;
			analyzer.DisplayEnable = false;
		}
		//Tooltip duration
		private void hScrollBar1_ValueChanged(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(hScrollBar1, setDuration());
		}
		//Create playlist
		void getPlaylist()
		{
			FolderBrowserDialog fb = new FolderBrowserDialog();
			if (fb.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(fb.SelectedPath))
			{
				showPlaylist(fb.SelectedPath);
			}
		}


		void showPlaylist(string path)
		{
			//Save selected path in setting
			Properties.Settings.Default.MyPath = path;
			Properties.Settings.Default.Save();
			//Create playlist
			playlist = wp.playlistCollection.newPlaylist("MyPlaylist");
			foreach (string s in Directory.GetFiles(Properties.Settings.Default.MyPath, "*.*").Where(s => s.EndsWith(".mp3") || s.EndsWith(".wav")))
			{
				var temp = wp.newMedia(s);
				playlist.appendItem(temp);
			}
			lvPlaylist.Items.Clear();
			showListView(playlist);
			wp.currentPlaylist = playlist;
		}

		void showListView(IWMPPlaylist list)
		{
			if (list.count > 0)
			{
				//Add playlist in list view
				for (int i = 0; i < playlist.count; i++)
				{
					ListViewItem lvi = new ListViewItem("");
					lvi.SubItems.Add(playlist.Item[i].name);
					lvi.SubItems.Add(playlist.Item[i].durationString);
					lvi.SubItems.Add(Convert.ToInt32(playlist.Item[i].getItemInfo("bitRate")) / 1000 + " kbps");
					lvPlaylist.Items.Add(lvi);
					hScrollBar1.Enabled = true;
				}
			}
		}

		//Seleted item
		private void lvPlaylist_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvPlaylist.SelectedItems.Count > 0)
			{
				try
				{
					showInfor(wp.currentPlaylist.Item[lvPlaylist.SelectedIndices[0]]);
					if (wp.playState == WMPPlayState.wmppsPlaying) return;
				}
				catch
				{
					wp.currentPlaylist = playlist;
					showInfor(wp.currentPlaylist.Item[lvPlaylist.SelectedIndices[0]]);
					wp.controls.playItem(wp.currentPlaylist.Item[lvPlaylist.SelectedIndices[0]]);
				}
				wp.controls.pause();
				analyzer.Enable = false;
				analyzer.DisplayEnable = false;
			}
		}
		//Play next
		private void btNext_Click(object sender, EventArgs e)
		{
			wp.controls.next();
			timer3.Start();
		}
		//Running....
		private void timer3_Tick(object sender, EventArgs e)
		{
			try
			{
				if (wp.playState != WMPPlayState.wmppsStopped)
				{
					if (wp.playState == WMPPlayState.wmppsStopped) { timer3.Stop(); lbCurrDuration.Text = lbDuration.Text; return; }
					hScrollBar1.Value = Convert.ToInt16(wp.controls.currentPosition);
					lbCurrDuration.Text = setDuration();
				}
			}
			catch
			{
				return;
			}
		}
		//Play previous 
		private void btPrevious_Click(object sender, EventArgs e)
		{
			wp.controls.previous();
			timer3.Start();
		}
		//Show properties current media
		private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (lvPlaylist.SelectedItems.Count > 0)
			{
				IWMPMedia media = wp.currentPlaylist.Item[lvPlaylist.SelectedIndices[0]];
				frmProperties fp = new frmProperties(media);
				fp.Show();
			}
		}
		//Dark theme
		private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			setColor(Color.Black, Color.FromArgb(0, 192, 0));
			Properties.Settings.Default.backColor = Color.Black;
			Properties.Settings.Default.foreColor = Color.FromArgb(0, 192, 0);
			Properties.Settings.Default.Save();
		}
		//Default
		private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
		{
			setColor(Color.White, Color.Black);
			Properties.Settings.Default.backColor = Color.White;
			Properties.Settings.Default.foreColor = Color.Black;
			Properties.Settings.Default.Save();
		}
		//Set color -- Color.FromArgb(0, 192, 0);
		private void setColor(Color backColor, Color foreColor)
		{
			this.BackColor = lvPlaylist.BackColor = elementHost1.BackColor = chart1.BackColor = backColor;
			foreach (Control c in groupBox1.Controls) c.ForeColor = foreColor;
			foreach (Control c in this.Controls) c.ForeColor = foreColor;
			tabControl1.TabPages[0].ForeColor = foreColor;
			tabControl1.TabPages[1].ForeColor = foreColor;
		}
		//Strip Menu - play
		private void playToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int index = lvPlaylist.SelectedIndices[0];
			wp.controls.playItem(wp.currentPlaylist.Item[index]);
			timer3.Start();
			analyzer.Enable = true;
			analyzer.DisplayEnable = true;
		}

		private void lvPlaylist_DragDrop(object sender, DragEventArgs e)
		{
			string[] list = (string[])e.Data.GetData(DataFormats.FileDrop);
			IWMPMedia media = wp.newMedia(list[0]);
			wp.currentPlaylist.appendItem(media);
			lvPlaylist.Items.Clear();
			showListView(wp.currentPlaylist);
		}

		private void lvPlaylist_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private void tbVolume_Scroll(object sender, ScrollEventArgs e)
		{
			wp.settings.volume = tbVolume.Value;
			lblVolume.Text = tbVolume.Value.ToString();
			toolTip1.SetToolTip(tbVolume, tbVolume.Value.ToString());
			if (tbVolume.Value == 0) label4.Image = Properties.Resources.volume_off;
			else if (tbVolume.Value <= 50 && tbVolume.Value > 0) label4.Image = Properties.Resources.volume_down;
			else label4.Image = Properties.Resources.volume_on;
		}
	}
}
