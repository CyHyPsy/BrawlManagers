﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrawlManagerLib;

namespace BrawlSongManager {
	[DefaultEvent("ValueChanged")]
	public partial class CustomSongVolumeEditor : UserControl {
		private CustomSongVolume _csv;
		public CustomSongVolume CSV {
			get {
				return _csv;
			}
			set {
				_csv = value;
				reload();
			}
		}
		private Song _song;
		private ushort? _idReqested;
		public Song Song {
			get {
				return _song;
			}
			set {
				_idReqested = value == null ? (ushort?)null : value.ID;
				_song = value;
				reload();
			}
		}
		public ushort ID {
			set {
				_idReqested = value;
				Song = SongIDMap.Songs.Where(s => s.ID == value).FirstOrDefault();
			}
		}

		public byte Value {
			get {
				return (byte)nudVolume.Value;
			}
			set {
				nudVolume.Value = value;
			}
		}

		public Image VolumeIcon {
			get {
				return pictureBox1.BackgroundImage;
			}
			set {
				pictureBox1.BackgroundImage = value == null ? value : BitmapUtilities.Resize(value, pictureBox1.Size);
			}
		}

		public string VolumeToolTip {
			set {
				toolTip1.SetToolTip(pictureBox1, value);
			}
		}

		public event EventHandler ValueChanged;

		public CustomSongVolumeEditor() {
			InitializeComponent();
		}

		public void SetBasename(string basename) {
			Song = basename == null
				? null
				: SongIDMap.Songs.Where(s => s.Filename == basename).FirstOrDefault();
		}

		private void reload() {
			lblSongID.Text = _idReqested == null ? ""
				: Song == null ? "Playback volume:"
				: Song.ID.ToString("X4");
			if (_idReqested == null) {
				this.VolumeToolTip = null;
				this.VolumeIcon = null;

				btnAdd.Text = "Add";
				btnAdd.Visible = false;
				nudVolume.Visible = false;
				nudVolume.Enabled = false;
			} else if (Song == null) {
				this.VolumeToolTip = "Filename not recognized - volume will only affect playback in this program and will not be saved";
				this.VolumeIcon = SystemIcons.Warning.ToBitmap();

				btnAdd.Text = "Add";
				btnAdd.Visible = false;
				nudVolume.Visible = true;
				nudVolume.Enabled = true;
				nudVolume.Value = 80;
			} else if (CSV != null && CSV.Settings.ContainsKey(Song.ID)) {
				this.VolumeToolTip = "Custom Song Volume code set";
				this.VolumeIcon = SystemIcons.Information.ToBitmap();

				btnAdd.Text = "Remove";
				btnAdd.Visible = true;
				nudVolume.Visible = true;
				nudVolume.Enabled = true;
				nudVolume.Value = CSV.Settings[Song.ID];
			} else if (Song.DefaultVolume == null) {
				//this.VolumeToolTip = "Default volume unknown";
				this.VolumeIcon = SystemIcons.Warning.ToBitmap();

				btnAdd.Text = "Add";
				btnAdd.Visible = true;
				nudVolume.Visible = false;
				nudVolume.Enabled = false;
				nudVolume.Value = 80;
			} else {
				this.VolumeToolTip = null;
				this.VolumeIcon = null;

				btnAdd.Text = "Add";
				btnAdd.Visible = true;
				nudVolume.Visible = true;
				nudVolume.Enabled = false;
				nudVolume.Value = Song.DefaultVolume ?? 0;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			if (CSV.Settings.ContainsKey(Song.ID)) {
				CSV.Settings.Remove(Song.ID);
			} else {
				CSV.Settings.Add(Song.ID, (byte)nudVolume.Value);
			}
			reload();
		}

		private void nudVolume_ValueChanged(object sender, EventArgs e) {
			// Don't update the CSV code if the song is unknown (in which case the number spinner acts only as a playback control)
			if (nudVolume.Enabled && Song != null) CSV.Settings[Song.ID] = Value;
			if (ValueChanged != null) ValueChanged(this, new EventArgs());
		}
	}
}
