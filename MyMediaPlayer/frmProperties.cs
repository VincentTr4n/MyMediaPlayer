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
using System.Security.Cryptography;
using HundredMilesSoftware.UltraID3Lib;
using NAudio.Wave;

namespace MyMediaPlayer
{
	public partial class frmProperties : Form
	{
		ListViewItem liv;
		FileInfo fi;
		UltraID3 myMp3 = new UltraID3();

		public frmProperties(IWMPMedia media)
		{
			InitializeComponent();
			myMp3.Read(media.sourceURL);
			this.Text = "Properties - "+media.name;
			fi = new FileInfo(media.sourceURL);
			//File name
			setItem("File name", fi.Name, 0);
			//Folder name
			setItem("Folder name", fi.DirectoryName, 0);
			//File path
			setItem("File Path", fi.FullName, 0);
			//Size
			setItem("Size", String.Format("{0:0.00}", fi.Length * 0.000001) + " MB " + "(" + fi.Length.ToString("### ### ### ###") + " bytes)", 0);
			//Last moddified
			setItem("Last moddified", fi.LastWriteTimeUtc.ToString(), 0);
			//Duration
			setItem("Duration", media.durationString + " (" + media.duration.ToString() + " samples)", 1);
			//Bitrate
			setItem("Bitrate", Convert.ToInt32(media.getItemInfo("BitRate")) / 1000 + " kbps", 1);
			//Title
			setItem("Title", media.getItemInfo("title"), 1);
			//Genre
			setItem("Genre",myMp3.Genre, 1);
			//Album
			setItem("Album", media.getItemInfo("album"), 1);
			//Artist
			setItem("Artist", media.getItemInfo("artist"), 1);
			//Copyright
			setItem("Copyright", media.getItemInfo("copyright"), 1);
			//Track number
			setItem("Track number", myMp3.TrackNum.ToString(), 1);
			//MD5
			setItem("Audio MD5", GetMD5HashFromFile(media.sourceURL), 1);
		}
		private void setItem(string name,string value,int gr)
		{
			liv = new ListViewItem(name);
			liv.SubItems.Add(value);
			liv.Group = lvPro.Groups[gr];
			lvPro.Items.Add(liv);
		}
		private void btOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private string GetMD5HashFromFile(string path)
		{
			using (var md5 = MD5.Create())
			{
				using (var stream = File.OpenRead(path))
				{
					return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
				}
			}
		}

	}
}
