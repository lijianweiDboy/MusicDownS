using System;
using System.Collections.ObjectModel;

namespace com.winne.MusicDown
{
	public class SongSearcher
	{
		public ObservableCollection<SongInfo> Songlist;

		public string AlbumMID;

		public SongSearcher(ObservableCollection<SongInfo> si, string am)
		{
			this.Songlist = si;
			this.AlbumMID = am;
		}
	}
}
