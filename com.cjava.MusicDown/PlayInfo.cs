using System;
using System.Collections.ObjectModel;

namespace com.winne.MusicDown
{
	public class PlayInfo
	{
		public string SongUrl
		{
			get;
			set;
		}

		public ObservableCollection<Lyric> Lyrics
		{
			get;
			set;
		}
	}
}
