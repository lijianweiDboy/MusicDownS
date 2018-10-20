using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace com.winne.MusicDown
{     
	public static class HttpHelper
	{
		[CompilerGenerated]
		private static class o__SiteContainer0
		{
			public static CallSite<Func<CallSite, object, IEnumerable>> p__Site1;

			public static CallSite<Func<CallSite, object, object>> p__Site2;

			public static CallSite<Func<CallSite, object, object>> p__Site3;

			public static CallSite<Func<CallSite, object, object>> p__Site4;

			public static CallSite<Func<CallSite, object, string>> p__Site5;

			public static CallSite<Func<CallSite, object, string, object>> p__Site6;

			public static CallSite<Func<CallSite, object, string>> p__Site7;

			public static CallSite<Func<CallSite, object, string, object>> p__Site8;

			public static CallSite<Func<CallSite, object, string, object>> p__Site9;

			public static CallSite<Func<CallSite, object, string>> p__Sitea;

			public static CallSite<Func<CallSite, object, bool>> p__Siteb;

			public static CallSite<Func<CallSite, object, int, object>> p__Sitec;

			public static CallSite<Func<CallSite, object, object>> p__Sited;

			public static CallSite<Func<CallSite, object, string, object>> p__Sitee;

			public static CallSite<Func<CallSite, object, string, object>> p__Sitef;

			public static CallSite<Func<CallSite, object, int, object>> p__Site10;

			public static CallSite<Func<CallSite, object, string, object>> p__Site11;

			public static CallSite<Func<CallSite, object, string>> p__Site12;

			public static CallSite<Func<CallSite, object, string, object>> p__Site13;

			public static CallSite<Func<CallSite, object, string, object>> p__Site14;

			public static CallSite<Func<CallSite, object, string>> p__Site15;

			public static CallSite<Func<CallSite, object, string, object>> p__Site16;

			public static CallSite<Func<CallSite, object, string, object>> p__Site17;

			public static CallSite<Func<CallSite, object, string>> p__Site18;

			public static CallSite<Func<CallSite, Type, object, object>> p__Site19;

			public static CallSite<Func<CallSite, object, string, object>> p__Site1a;

			public static CallSite<Func<CallSite, object, double>> p__Site1b;

			public static CallSite<Func<CallSite, Type, object, object>> p__Site1c;

			public static CallSite<Func<CallSite, object, string, object>> p__Site1d;

			public static CallSite<Func<CallSite, object, string, object>> p__Site1e;

			public static CallSite<Func<CallSite, object, double>> p__Site1f;

			public static CallSite<Func<CallSite, Type, object, object>> p__Site20;

			public static CallSite<Func<CallSite, object, string, object>> p__Site21;

			public static CallSite<Func<CallSite, object, string, object>> p__Site22;

			public static CallSite<Func<CallSite, object, double>> p__Site23;

			public static CallSite<Func<CallSite, Type, object, object>> p__Site24;

			public static CallSite<Func<CallSite, object, bool>> p__Site25;

			public static CallSite<Func<CallSite, object, int, object>> p__Site26;

			public static CallSite<Func<CallSite, object, string, object>> p__Site27;

			public static CallSite<Func<CallSite, object, string, object>> p__Site28;

			public static CallSite<Func<CallSite, object, string, object>> p__Site29;

			public static CallSite<Func<CallSite, object, string, object>> p__Site2a;

			public static CallSite<Func<CallSite, object, string, object>> p__Site2b;

			public static CallSite<Func<CallSite, object, string, object>> p__Site2c;

			public static CallSite<Func<CallSite, object, string>> p__Site2d;

			public static CallSite<Func<CallSite, object, int, object>> p__Site2e;

			public static CallSite<Func<CallSite, object, string, object>> p__Site2f;

			public static CallSite<Func<CallSite, object, string, object>> p__Site30;

			public static CallSite<Func<CallSite, object, string, object>> p__Site31;
		}

		[CompilerGenerated]
		private static class SiteContainer36
		{
			public static CallSite<Func<CallSite, object, IEnumerable>> p__Site37;

			public static CallSite<Func<CallSite, object, object>> p__Site38;

			public static CallSite<Func<CallSite, object, string>> p__Site39;

			public static CallSite<Func<CallSite, object, string, object>> p__Site3a;

			public static CallSite<Func<CallSite, object, string, object>> p__Site3b;

			public static CallSite<Func<CallSite, object, string>> p__Site3c;

			public static CallSite<Func<CallSite, object, string, object>> p__Site3d;

			public static CallSite<Func<CallSite, object, string, object>> p__Site3e;

			public static CallSite<Func<CallSite, object, string>> p__Site3f;

			public static CallSite<Func<CallSite, object, bool>> p__Site40;

			public static CallSite<Func<CallSite, object, int, object>> p__Site41;

			public static CallSite<Func<CallSite, object, object>> p__Site42;

			public static CallSite<Func<CallSite, object, string, object>> p__Site43;

			public static CallSite<Func<CallSite, object, string, object>> p__Site44;

			public static CallSite<Func<CallSite, object, string, object>> p__Site45;

			public static CallSite<Func<CallSite, object, int, object>> p__Site46;

			public static CallSite<Func<CallSite, object, string, object>> p__Site47;

			public static CallSite<Func<CallSite, object, string, object>> p__Site48;

			public static CallSite<Func<CallSite, object, string>> p__Site49;

			public static CallSite<Func<CallSite, object, string, object>> p__Site4a;

			public static CallSite<Func<CallSite, object, string, object>> p__Site4b;

			public static CallSite<Func<CallSite, object, string>> p__Site4c;

			public static CallSite<Func<CallSite, object, string, object>> p__Site4d;

			public static CallSite<Func<CallSite, object, string, object>> p__Site4e;

			public static CallSite<Func<CallSite, object, string>> p__Site4f;

			public static CallSite<Func<CallSite, Type, object, object>> p__Site50;

			public static CallSite<Func<CallSite, object, string, object>> p__Site51;

			public static CallSite<Func<CallSite, object, string, object>> p__Site52;

			public static CallSite<Func<CallSite, object, double>> p__Site53;

			public static CallSite<Func<CallSite, Type, object, object>> p__Site54;

			public static CallSite<Func<CallSite, object, string, object>> p__Site55;

			public static CallSite<Func<CallSite, object, string, object>> p__Site56;

			public static CallSite<Func<CallSite, object, double>> p__Site57;

			public static CallSite<Func<CallSite, Type, object, object>> p__Site58;

			public static CallSite<Func<CallSite, object, string, object>> p__Site59;

			public static CallSite<Func<CallSite, object, string, object>> p__Site5a;

			public static CallSite<Func<CallSite, object, double>> p__Site5b;

			public static CallSite<Func<CallSite, Type, object, object>> p__Site5c;

			public static CallSite<Func<CallSite, object, bool>> p__Site5d;

			public static CallSite<Func<CallSite, object, int, object>> p__Site5e;

			public static CallSite<Func<CallSite, object, string, object>> p__Site5f;

			public static CallSite<Func<CallSite, object, string, object>> p__Site60;

			public static CallSite<Func<CallSite, object, string, object>> p__Site61;

			public static CallSite<Func<CallSite, object, string, object>> p__Site62;

			public static CallSite<Func<CallSite, object, string, object>> p__Site63;

			public static CallSite<Func<CallSite, object, string, object>> p__Site64;

			public static CallSite<Func<CallSite, object, string>> p__Site65;

			public static CallSite<Func<CallSite, object, int, object>> p__Site66;

			public static CallSite<Func<CallSite, object, string, object>> p__Site67;

			public static CallSite<Func<CallSite, object, string, object>> p__Site68;

			public static CallSite<Func<CallSite, object, string, object>> p__Site69;
		}

		[CompilerGenerated]
		private static class o__SiteContainer6e
		{
			public static CallSite<Func<CallSite, object, string>> p__Site6f;

			public static CallSite<Func<CallSite, object, string, object>> p__Site70;

			public static CallSite<Func<CallSite, object, int, object>> p__Site71;

			public static CallSite<Func<CallSite, object, object>> p__Site72;

			public static CallSite<Func<CallSite, object, object>> p__Site73;
		}

		[CompilerGenerated]
		private static class SiteContainer74
		{
			public static CallSite<Func<CallSite, object, string>> p__Site75;

			public static CallSite<Func<CallSite, object, string, object>> p__Site76;

			public static CallSite<Func<CallSite, object, int, object>> p__Site77;

			public static CallSite<Func<CallSite, object, object>> p__Site78;

			public static CallSite<Func<CallSite, object, string>> p__Site79;

			public static CallSite<Func<CallSite, object, object>> p__Site7a;

			public static CallSite<Func<CallSite, object, object>> p__Site7b;
		}

		[CompilerGenerated]
		private static class SiteContainer7c
		{
			public static CallSite<Func<CallSite, object, ObservableCollection<Lyric>>> p__Site7d;

			public static CallSite<Func<CallSite, Type, object, object>> p__Site7e;

			public static CallSite<Func<CallSite, object, string, object>> p__Site7f;

			public static CallSite<Func<CallSite, object, int, object>> p__Site80;

			public static CallSite<Func<CallSite, object, object>> p__Site81;

			public static CallSite<Func<CallSite, object, string>> p__Site82;

			public static CallSite<Func<CallSite, object, string, object>> p__Site83;

			public static CallSite<Func<CallSite, object, int, object>> p__Site84;

			public static CallSite<Func<CallSite, object, object>> p__Site85;
		}

		[CompilerGenerated]
		private static class SiteContainer86
		{
			public static CallSite<Func<CallSite, object, byte[]>> p__Site87;

			public static CallSite<Func<CallSite, Type, object, object>> p__Site88;

			public static CallSite<Func<CallSite, object, object>> p__Site89;
		}

		[CompilerGenerated]
		private static class SiteContainer8a
		{
			public static CallSite<Func<CallSite, object, int>> p__Site8b;

			public static CallSite<Func<CallSite, object, int, object>> p__Site8c;

			public static CallSite<Func<CallSite, object, object>> p__Site8d;

			public static CallSite<Func<CallSite, object, object>> p__Site8e;

			public static CallSite<Func<CallSite, object, bool>> p__Site8f;

			public static CallSite<Func<CallSite, object, int, object>> p__Site90;

			public static CallSite<Func<CallSite, object, object>> p__Site91;

			public static CallSite<Func<CallSite, object, string, object>> p__Site92;

			public static CallSite<Func<CallSite, object, int, object>> p__Site93;

			public static CallSite<Func<CallSite, object, object>> p__Site94;

			public static CallSite<Func<CallSite, object, string>> p__Site95;

			public static CallSite<Func<CallSite, object, int, object>> p__Site96;

			public static CallSite<Func<CallSite, object, string, object>> p__Site97;

			public static CallSite<Func<CallSite, object, int, object>> p__Site98;

			public static CallSite<Func<CallSite, object, object>> p__Site99;
		}

		[CompilerGenerated]
		private static class SiteContainer9a
		{
			public static CallSite<Func<CallSite, object, Version>> p__Site9b;

			public static CallSite<Func<CallSite, Type, object, object>> p__Site9c;

			public static CallSite<Func<CallSite, object, object>> p__Site9d;

			public static CallSite<Func<CallSite, object, string>> p__Site9e;

			public static CallSite<Func<CallSite, object, object, object>> p__Site9f;

			public static CallSite<Func<CallSite, object, string, object>> p__Sitea0;

			public static CallSite<Func<CallSite, object, object>> p__Sitea1;

			public static CallSite<Func<CallSite, object, object>> p__Sitea2;

			public static CallSite<Func<CallSite, object, IEnumerable>> p__Sitea3;

			public static CallSite<Func<CallSite, object, object>> p__Sitea4;

			public static CallSite<Action<CallSite, object, string>> p__Sitea5;

			public static CallSite<Func<CallSite, StringBuilder, object, object>> p__Sitea6;
		}

		private static string vkey = string.Empty;

		public static ObservableCollection<SongInfo> GetSongInfoFromNet(string interfaceUrl, string keyWord)
		{
			ObservableCollection<SongInfo> observableCollection = new ObservableCollection<SongInfo>();
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			string uriString = "http://c.y.qq.com/soso/fcgi-bin/client_search_cp?ct=24&qqmusic_ver=1298&new_json=1&remoteplace=txt.yqq.center&t=0&aggr=1&cr=1&catZhida=1&lossless=0&flag_qc=0&p=1&n=100&w=" + UrlEncodeHtmlHelp.UrlEncode(keyWord) + "&&jsonpCallback=searchCallbacksong2020&format=jsonp&inCharset=utf8&outCharset=utf-8&notice=0&platform=yqq&needNewCode=0";
			try
			{
				webClient.DownloadDataAsync(new Uri(uriString), new SongSearcher(observableCollection, null));
				webClient.DownloadDataCompleted += new DownloadDataCompletedEventHandler(HttpHelper.wc_DownloadDataCompleted);
			}
			catch (Exception)
			{
			}
			return observableCollection;
		}

		private static void wc_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
		{
			try
			{
				string @string = Encoding.UTF8.GetString(e.Result);
				SongSearcher songSearcher = e.UserState as SongSearcher;
				ObservableCollection<SongInfo> songlist = songSearcher.Songlist;
				string albumMID = songSearcher.AlbumMID;
				Regex regex = new Regex("{.*}", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Singleline);
				Match match = regex.Match(@string);
				object arg = HttpHelper.ConvertJson(match.Value);
				if (HttpHelper.o__SiteContainer0.p__Site1 == null)
				{
					HttpHelper.o__SiteContainer0.p__Site1 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(HttpHelper)));
				}
				Func<CallSite, object, IEnumerable> arg_188_0 = HttpHelper.o__SiteContainer0.p__Site1.Target;
				CallSite arg_188_1 = HttpHelper.o__SiteContainer0.p__Site1;
				if (HttpHelper.o__SiteContainer0.p__Site2 == null)
				{
					HttpHelper.o__SiteContainer0.p__Site2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "list", typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_183_0 = HttpHelper.o__SiteContainer0.p__Site2.Target;
				CallSite arg_183_1 = HttpHelper.o__SiteContainer0.p__Site2;
				if (HttpHelper.o__SiteContainer0.p__Site3 == null)
				{
					HttpHelper.o__SiteContainer0.p__Site3 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "song", typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_17E_0 = HttpHelper.o__SiteContainer0.p__Site3.Target;
				CallSite arg_17E_1 = HttpHelper.o__SiteContainer0.p__Site3;
				if (HttpHelper.o__SiteContainer0.p__Site4 == null)
				{
					HttpHelper.o__SiteContainer0.p__Site4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "data", typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				foreach (object current in arg_188_0(arg_188_1, arg_183_0(arg_183_1, arg_17E_0(arg_17E_1, HttpHelper.o__SiteContainer0.p__Site4.Target(HttpHelper.o__SiteContainer0.p__Site4, arg)))))
				{
					SongInfo songInfo = new SongInfo();
					SongInfo arg_246_0 = songInfo;
					if (HttpHelper.o__SiteContainer0.p__Site5 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site5 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_241_0 = HttpHelper.o__SiteContainer0.p__Site5.Target;
					CallSite arg_241_1 = HttpHelper.o__SiteContainer0.p__Site5;
					if (HttpHelper.o__SiteContainer0.p__Site6 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_246_0.Name = arg_241_0(arg_241_1, HttpHelper.o__SiteContainer0.p__Site6.Target(HttpHelper.o__SiteContainer0.p__Site6, current, "name"));
					SongInfo arg_342_0 = songInfo;
					if (HttpHelper.o__SiteContainer0.p__Site7 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site7 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_33D_0 = HttpHelper.o__SiteContainer0.p__Site7.Target;
					CallSite arg_33D_1 = HttpHelper.o__SiteContainer0.p__Site7;
					if (HttpHelper.o__SiteContainer0.p__Site8 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site8 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_338_0 = HttpHelper.o__SiteContainer0.p__Site8.Target;
					CallSite arg_338_1 = HttpHelper.o__SiteContainer0.p__Site8;
					if (HttpHelper.o__SiteContainer0.p__Site9 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site9 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_342_0.Mid = arg_33D_0(arg_33D_1, arg_338_0(arg_338_1, HttpHelper.o__SiteContainer0.p__Site9.Target(HttpHelper.o__SiteContainer0.p__Site9, current, "file"), "media_mid"));
					SongInfo arg_5EF_0 = songInfo;
					if (HttpHelper.o__SiteContainer0.p__Sitea == null)
					{
						HttpHelper.o__SiteContainer0.p__Sitea = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_5EA_0 = HttpHelper.o__SiteContainer0.p__Sitea.Target;
					CallSite arg_5EA_1 = HttpHelper.o__SiteContainer0.p__Sitea;
					if (HttpHelper.o__SiteContainer0.p__Siteb == null)
					{
						HttpHelper.o__SiteContainer0.p__Siteb = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> arg_4CD_0 = HttpHelper.o__SiteContainer0.p__Siteb.Target;
					CallSite arg_4CD_1 = HttpHelper.o__SiteContainer0.p__Siteb;
					if (HttpHelper.o__SiteContainer0.p__Sitec == null)
					{
						HttpHelper.o__SiteContainer0.p__Sitec = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.GreaterThan, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, int, object> arg_4C8_0 = HttpHelper.o__SiteContainer0.p__Sitec.Target;
					CallSite arg_4C8_1 = HttpHelper.o__SiteContainer0.p__Sitec;
					if (HttpHelper.o__SiteContainer0.p__Sited == null)
					{
						HttpHelper.o__SiteContainer0.p__Sited = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Count", typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> arg_4C2_0 = HttpHelper.o__SiteContainer0.p__Sited.Target;
					CallSite arg_4C2_1 = HttpHelper.o__SiteContainer0.p__Sited;
					if (HttpHelper.o__SiteContainer0.p__Sitee == null)
					{
						HttpHelper.o__SiteContainer0.p__Sitee = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					object arg_5EA_2;
					if (!arg_4CD_0(arg_4CD_1, arg_4C8_0(arg_4C8_1, arg_4C2_0(arg_4C2_1, HttpHelper.o__SiteContainer0.p__Sitee.Target(HttpHelper.o__SiteContainer0.p__Sitee, current, "singer")), 0)))
					{
						arg_5EA_2 = "";
					}
					else
					{
						if (HttpHelper.o__SiteContainer0.p__Sitef == null)
						{
							HttpHelper.o__SiteContainer0.p__Sitef = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> arg_5E5_0 = HttpHelper.o__SiteContainer0.p__Sitef.Target;
						CallSite arg_5E5_1 = HttpHelper.o__SiteContainer0.p__Sitef;
						if (HttpHelper.o__SiteContainer0.p__Site10 == null)
						{
							HttpHelper.o__SiteContainer0.p__Site10 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, int, object> arg_5DB_0 = HttpHelper.o__SiteContainer0.p__Site10.Target;
						CallSite arg_5DB_1 = HttpHelper.o__SiteContainer0.p__Site10;
						if (HttpHelper.o__SiteContainer0.p__Site11 == null)
						{
							HttpHelper.o__SiteContainer0.p__Site11 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						arg_5EA_2 = arg_5E5_0(arg_5E5_1, arg_5DB_0(arg_5DB_1, HttpHelper.o__SiteContainer0.p__Site11.Target(HttpHelper.o__SiteContainer0.p__Site11, current, "singer"), 0), "name");
					}
					arg_5EF_0.SingerName = arg_5EA_0(arg_5EA_1, arg_5EA_2);
					SongInfo arg_6EB_0 = songInfo;
					if (HttpHelper.o__SiteContainer0.p__Site12 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site12 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_6E6_0 = HttpHelper.o__SiteContainer0.p__Site12.Target;
					CallSite arg_6E6_1 = HttpHelper.o__SiteContainer0.p__Site12;
					if (HttpHelper.o__SiteContainer0.p__Site13 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site13 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_6E1_0 = HttpHelper.o__SiteContainer0.p__Site13.Target;
					CallSite arg_6E1_1 = HttpHelper.o__SiteContainer0.p__Site13;
					if (HttpHelper.o__SiteContainer0.p__Site14 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site14 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_6EB_0.AlbumName = arg_6E6_0(arg_6E6_1, arg_6E1_0(arg_6E1_1, HttpHelper.o__SiteContainer0.p__Site14.Target(HttpHelper.o__SiteContainer0.p__Site14, current, "album"), "name"));
					SongInfo arg_7E7_0 = songInfo;
					if (HttpHelper.o__SiteContainer0.p__Site15 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site15 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_7E2_0 = HttpHelper.o__SiteContainer0.p__Site15.Target;
					CallSite arg_7E2_1 = HttpHelper.o__SiteContainer0.p__Site15;
					if (HttpHelper.o__SiteContainer0.p__Site16 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site16 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_7DD_0 = HttpHelper.o__SiteContainer0.p__Site16.Target;
					CallSite arg_7DD_1 = HttpHelper.o__SiteContainer0.p__Site16;
					if (HttpHelper.o__SiteContainer0.p__Site17 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site17 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_7E7_0.AlbumMID = arg_7E2_0(arg_7E2_1, arg_7DD_0(arg_7DD_1, HttpHelper.o__SiteContainer0.p__Site17.Target(HttpHelper.o__SiteContainer0.p__Site17, current, "album"), "mid"));
					SongInfo arg_8EF_0 = songInfo;
					if (HttpHelper.o__SiteContainer0.p__Site18 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site18 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_8EA_0 = HttpHelper.o__SiteContainer0.p__Site18.Target;
					CallSite arg_8EA_1 = HttpHelper.o__SiteContainer0.p__Site18;
					if (HttpHelper.o__SiteContainer0.p__Site19 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site19 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "IntToTimeString", null, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object> arg_8E5_0 = HttpHelper.o__SiteContainer0.p__Site19.Target;
					CallSite arg_8E5_1 = HttpHelper.o__SiteContainer0.p__Site19;
					Type arg_8E5_2 = typeof(CommonHelper);
					if (HttpHelper.o__SiteContainer0.p__Site1a == null)
					{
						HttpHelper.o__SiteContainer0.p__Site1a = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_8EF_0.ContinuedTime = arg_8EA_0(arg_8EA_1, arg_8E5_0(arg_8E5_1, arg_8E5_2, HttpHelper.o__SiteContainer0.p__Site1a.Target(HttpHelper.o__SiteContainer0.p__Site1a, current, "interval")));
					SongInfo arg_A51_0 = songInfo;
					if (HttpHelper.o__SiteContainer0.p__Site1b == null)
					{
						HttpHelper.o__SiteContainer0.p__Site1b = CallSite<Func<CallSite, object, double>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(double), typeof(HttpHelper)));
					}
					Func<CallSite, object, double> arg_A4C_0 = HttpHelper.o__SiteContainer0.p__Site1b.Target;
					CallSite arg_A4C_1 = HttpHelper.o__SiteContainer0.p__Site1b;
					if (HttpHelper.o__SiteContainer0.p__Site1c == null)
					{
						HttpHelper.o__SiteContainer0.p__Site1c = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ConvertToMB", null, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object> arg_A47_0 = HttpHelper.o__SiteContainer0.p__Site1c.Target;
					CallSite arg_A47_1 = HttpHelper.o__SiteContainer0.p__Site1c;
					Type arg_A47_2 = typeof(CommonHelper);
					if (HttpHelper.o__SiteContainer0.p__Site1d == null)
					{
						HttpHelper.o__SiteContainer0.p__Site1d = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_A42_0 = HttpHelper.o__SiteContainer0.p__Site1d.Target;
					CallSite arg_A42_1 = HttpHelper.o__SiteContainer0.p__Site1d;
					if (HttpHelper.o__SiteContainer0.p__Site1e == null)
					{
						HttpHelper.o__SiteContainer0.p__Site1e = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_A51_0.ApeSize = arg_A4C_0(arg_A4C_1, arg_A47_0(arg_A47_1, arg_A47_2, arg_A42_0(arg_A42_1, HttpHelper.o__SiteContainer0.p__Site1e.Target(HttpHelper.o__SiteContainer0.p__Site1e, current, "file"), "size_ape")));
					SongInfo arg_BB3_0 = songInfo;
					if (HttpHelper.o__SiteContainer0.p__Site1f == null)
					{
						HttpHelper.o__SiteContainer0.p__Site1f = CallSite<Func<CallSite, object, double>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(double), typeof(HttpHelper)));
					}
					Func<CallSite, object, double> arg_BAE_0 = HttpHelper.o__SiteContainer0.p__Site1f.Target;
					CallSite arg_BAE_1 = HttpHelper.o__SiteContainer0.p__Site1f;
					if (HttpHelper.o__SiteContainer0.p__Site20 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site20 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ConvertToMB", null, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object> arg_BA9_0 = HttpHelper.o__SiteContainer0.p__Site20.Target;
					CallSite arg_BA9_1 = HttpHelper.o__SiteContainer0.p__Site20;
					Type arg_BA9_2 = typeof(CommonHelper);
					if (HttpHelper.o__SiteContainer0.p__Site21 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site21 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_BA4_0 = HttpHelper.o__SiteContainer0.p__Site21.Target;
					CallSite arg_BA4_1 = HttpHelper.o__SiteContainer0.p__Site21;
					if (HttpHelper.o__SiteContainer0.p__Site22 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site22 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_BB3_0.FlacSize = arg_BAE_0(arg_BAE_1, arg_BA9_0(arg_BA9_1, arg_BA9_2, arg_BA4_0(arg_BA4_1, HttpHelper.o__SiteContainer0.p__Site22.Target(HttpHelper.o__SiteContainer0.p__Site22, current, "file"), "size_flac")));
					SongInfo arg_F2F_0 = songInfo;
					if (HttpHelper.o__SiteContainer0.p__Site23 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site23 = CallSite<Func<CallSite, object, double>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(double), typeof(HttpHelper)));
					}
					Func<CallSite, object, double> arg_F2A_0 = HttpHelper.o__SiteContainer0.p__Site23.Target;
					CallSite arg_F2A_1 = HttpHelper.o__SiteContainer0.p__Site23;
					if (HttpHelper.o__SiteContainer0.p__Site24 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site24 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ConvertToMB", null, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object> arg_F25_0 = HttpHelper.o__SiteContainer0.p__Site24.Target;
					CallSite arg_F25_1 = HttpHelper.o__SiteContainer0.p__Site24;
					Type arg_F25_2 = typeof(CommonHelper);
					if (HttpHelper.o__SiteContainer0.p__Site25 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site25 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> arg_DAA_0 = HttpHelper.o__SiteContainer0.p__Site25.Target;
					CallSite arg_DAA_1 = HttpHelper.o__SiteContainer0.p__Site25;
					if (HttpHelper.o__SiteContainer0.p__Site26 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site26 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, int, object> arg_DA5_0 = HttpHelper.o__SiteContainer0.p__Site26.Target;
					CallSite arg_DA5_1 = HttpHelper.o__SiteContainer0.p__Site26;
					if (HttpHelper.o__SiteContainer0.p__Site27 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site27 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_D9F_0 = HttpHelper.o__SiteContainer0.p__Site27.Target;
					CallSite arg_D9F_1 = HttpHelper.o__SiteContainer0.p__Site27;
					if (HttpHelper.o__SiteContainer0.p__Site28 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site28 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					object arg_F25_3;
					if (!arg_DAA_0(arg_DAA_1, arg_DA5_0(arg_DA5_1, arg_D9F_0(arg_D9F_1, HttpHelper.o__SiteContainer0.p__Site28.Target(HttpHelper.o__SiteContainer0.p__Site28, current, "file"), "size_320"), 0)))
					{
						if (HttpHelper.o__SiteContainer0.p__Site2b == null)
						{
							HttpHelper.o__SiteContainer0.p__Site2b = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> arg_E65_0 = HttpHelper.o__SiteContainer0.p__Site2b.Target;
						CallSite arg_E65_1 = HttpHelper.o__SiteContainer0.p__Site2b;
						if (HttpHelper.o__SiteContainer0.p__Site2c == null)
						{
							HttpHelper.o__SiteContainer0.p__Site2c = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						arg_F25_3 = arg_E65_0(arg_E65_1, HttpHelper.o__SiteContainer0.p__Site2c.Target(HttpHelper.o__SiteContainer0.p__Site2c, current, "file"), "size_320");
					}
					else
					{
						if (HttpHelper.o__SiteContainer0.p__Site29 == null)
						{
							HttpHelper.o__SiteContainer0.p__Site29 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> arg_F20_0 = HttpHelper.o__SiteContainer0.p__Site29.Target;
						CallSite arg_F20_1 = HttpHelper.o__SiteContainer0.p__Site29;
						if (HttpHelper.o__SiteContainer0.p__Site2a == null)
						{
							HttpHelper.o__SiteContainer0.p__Site2a = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						arg_F25_3 = arg_F20_0(arg_F20_1, HttpHelper.o__SiteContainer0.p__Site2a.Target(HttpHelper.o__SiteContainer0.p__Site2a, current, "file"), "size_128");
					}
					arg_F2F_0.Mp3Size = arg_F2A_0(arg_F2A_1, arg_F25_0(arg_F25_1, arg_F25_2, arg_F25_3));
					SongInfo arg_10E2_0 = songInfo;
					if (HttpHelper.o__SiteContainer0.p__Site2d == null)
					{
						HttpHelper.o__SiteContainer0.p__Site2d = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_10DD_0 = HttpHelper.o__SiteContainer0.p__Site2d.Target;
					CallSite arg_10DD_1 = HttpHelper.o__SiteContainer0.p__Site2d;
					if (HttpHelper.o__SiteContainer0.p__Site2e == null)
					{
						HttpHelper.o__SiteContainer0.p__Site2e = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> arg_10D8_0 = HttpHelper.o__SiteContainer0.p__Site2e.Target;
					CallSite arg_10D8_1 = HttpHelper.o__SiteContainer0.p__Site2e;
					if (HttpHelper.o__SiteContainer0.p__Site2f == null)
					{
						HttpHelper.o__SiteContainer0.p__Site2f = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_10CD_0 = HttpHelper.o__SiteContainer0.p__Site2f.Target;
					CallSite arg_10CD_1 = HttpHelper.o__SiteContainer0.p__Site2f;
					if (HttpHelper.o__SiteContainer0.p__Site30 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site30 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_10C3_0 = HttpHelper.o__SiteContainer0.p__Site30.Target;
					CallSite arg_10C3_1 = HttpHelper.o__SiteContainer0.p__Site30;
					if (HttpHelper.o__SiteContainer0.p__Site31 == null)
					{
						HttpHelper.o__SiteContainer0.p__Site31 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_10E2_0.MV = arg_10DD_0(arg_10DD_1, arg_10D8_0(arg_10D8_1, arg_10CD_0(arg_10CD_1, arg_10C3_0(arg_10C3_1, HttpHelper.o__SiteContainer0.p__Site31.Target(HttpHelper.o__SiteContainer0.p__Site31, current, "mv"), "vid"), ":"), songlist.Count));
					songInfo.PD = new ProcessData();
					songlist.Add(songInfo);
				}
				if (albumMID != null)
				{
					List<SongInfo> list = (from s in songlist
					where s.AlbumMID == albumMID
					select s).ToList<SongInfo>();
					songlist.Clear();
					foreach (SongInfo current2 in list)
					{
						songlist.Add(current2);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		public static ObservableCollection<SongInfo> GetAlbumSongs(string albumName, string albumMID)
		{
			ObservableCollection<SongInfo> observableCollection = new ObservableCollection<SongInfo>();
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			string uriString = "https://c.y.qq.com/soso/fcgi-bin/client_search_cp?ct=24&qqmusic_ver=1298&new_json=1&remoteplace=txt.yqq.center&searchid=53514811514824113&t=0&aggr=1&cr=1&catZhida=1&lossless=0&flag_qc=0&p=1&n=300&w=" + UrlEncodeHtmlHelp.UrlEncode(albumName) + "&g_tk=5381&jsonpCallback=MusicJsonCallback25729637942415806&loginUin=0&hostUin=0&format=jsonp&inCharset=utf8&outCharset=utf-8&notice=0&platform=yqq&needNewCode=0";
			try
			{
				webClient.DownloadDataAsync(new Uri(uriString), new SongSearcher(observableCollection, albumMID));
				webClient.DownloadDataCompleted += new DownloadDataCompletedEventHandler(HttpHelper.wc_DownloadDataCompleted);
			}
			catch (Exception)
			{
			}
			return observableCollection;
		}

		public static ObservableCollection<SongInfo> GetHotTop(int songNum)
		{
			GregorianCalendar gregorianCalendar = new GregorianCalendar();
			int weekOfYear = gregorianCalendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("https://c.y.qq.com/v8/fcg-bin/fcg_v8_toplist_cp.fcg?tpl=3&page=detail&date=");
			stringBuilder.Append(DateTime.Now.Year);
			stringBuilder.Append("_");
			stringBuilder.Append(weekOfYear - 1);
			stringBuilder.Append("&topid=26&type=top&song_begin=0&song_num=");
			stringBuilder.Append(songNum);
			stringBuilder.Append("&g_tk=5381&jsonpCallback=MusicJsonCallbacktoplist&loginUin=0&hostUin=0&format=jsonp&inCharset=utf8&outCharset=utf-8&notice=0&platform=yqq&needNewCode=0");
			ObservableCollection<SongInfo> observableCollection = new ObservableCollection<SongInfo>();
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			try
			{
				webClient.DownloadDataAsync(new Uri(stringBuilder.ToString()), new SongSearcher(observableCollection, null));
				webClient.DownloadDataCompleted += new DownloadDataCompletedEventHandler(HttpHelper.wc_DownloadDataCompletedHot);
			}
			catch (Exception)
			{
			}
			return observableCollection;
		}

		private static void wc_DownloadDataCompletedHot(object sender, DownloadDataCompletedEventArgs e)
		{
			try
			{
				string @string = Encoding.UTF8.GetString(e.Result);
				SongSearcher songSearcher = e.UserState as SongSearcher;
				ObservableCollection<SongInfo> songlist = songSearcher.Songlist;
				string albumMID = songSearcher.AlbumMID;
				Regex regex = new Regex("{.*}", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Singleline);
				Match match = regex.Match(@string);
				object arg = HttpHelper.ConvertJson(match.Value);
				if (HttpHelper.SiteContainer36.p__Site37 == null)
				{
					HttpHelper.SiteContainer36.p__Site37 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(HttpHelper)));
				}
				Func<CallSite, object, IEnumerable> arg_EA_0 = HttpHelper.SiteContainer36.p__Site37.Target;
				CallSite arg_EA_1 = HttpHelper.SiteContainer36.p__Site37;
				if (HttpHelper.SiteContainer36.p__Site38 == null)
				{
					HttpHelper.SiteContainer36.p__Site38 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "songlist", typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				foreach (object current in arg_EA_0(arg_EA_1, HttpHelper.SiteContainer36.p__Site38.Target(HttpHelper.SiteContainer36.p__Site38, arg)))
				{
					SongInfo songInfo = new SongInfo();
					SongInfo arg_202_0 = songInfo;
					if (HttpHelper.SiteContainer36.p__Site39 == null)
					{
						HttpHelper.SiteContainer36.p__Site39 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_1FD_0 = HttpHelper.SiteContainer36.p__Site39.Target;
					CallSite arg_1FD_1 = HttpHelper.SiteContainer36.p__Site39;
					if (HttpHelper.SiteContainer36.p__Site3a == null)
					{
						HttpHelper.SiteContainer36.p__Site3a = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_1F8_0 = HttpHelper.SiteContainer36.p__Site3a.Target;
					CallSite arg_1F8_1 = HttpHelper.SiteContainer36.p__Site3a;
					if (HttpHelper.SiteContainer36.p__Site3b == null)
					{
						HttpHelper.SiteContainer36.p__Site3b = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_202_0.Name = arg_1FD_0(arg_1FD_1, arg_1F8_0(arg_1F8_1, HttpHelper.SiteContainer36.p__Site3b.Target(HttpHelper.SiteContainer36.p__Site3b, current, "data"), "songname"));
					SongInfo arg_2FE_0 = songInfo;
					if (HttpHelper.SiteContainer36.p__Site3c == null)
					{
						HttpHelper.SiteContainer36.p__Site3c = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_2F9_0 = HttpHelper.SiteContainer36.p__Site3c.Target;
					CallSite arg_2F9_1 = HttpHelper.SiteContainer36.p__Site3c;
					if (HttpHelper.SiteContainer36.p__Site3d == null)
					{
						HttpHelper.SiteContainer36.p__Site3d = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_2F4_0 = HttpHelper.SiteContainer36.p__Site3d.Target;
					CallSite arg_2F4_1 = HttpHelper.SiteContainer36.p__Site3d;
					if (HttpHelper.SiteContainer36.p__Site3e == null)
					{
						HttpHelper.SiteContainer36.p__Site3e = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_2FE_0.Mid = arg_2F9_0(arg_2F9_1, arg_2F4_0(arg_2F4_1, HttpHelper.SiteContainer36.p__Site3e.Target(HttpHelper.SiteContainer36.p__Site3e, current, "data"), "songmid"));
					SongInfo arg_65F_0 = songInfo;
					if (HttpHelper.SiteContainer36.p__Site3f == null)
					{
						HttpHelper.SiteContainer36.p__Site3f = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_65A_0 = HttpHelper.SiteContainer36.p__Site3f.Target;
					CallSite arg_65A_1 = HttpHelper.SiteContainer36.p__Site3f;
					if (HttpHelper.SiteContainer36.p__Site40 == null)
					{
						HttpHelper.SiteContainer36.p__Site40 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> arg_4E3_0 = HttpHelper.SiteContainer36.p__Site40.Target;
					CallSite arg_4E3_1 = HttpHelper.SiteContainer36.p__Site40;
					if (HttpHelper.SiteContainer36.p__Site41 == null)
					{
						HttpHelper.SiteContainer36.p__Site41 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.GreaterThan, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, int, object> arg_4DE_0 = HttpHelper.SiteContainer36.p__Site41.Target;
					CallSite arg_4DE_1 = HttpHelper.SiteContainer36.p__Site41;
					if (HttpHelper.SiteContainer36.p__Site42 == null)
					{
						HttpHelper.SiteContainer36.p__Site42 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Count", typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> arg_4D8_0 = HttpHelper.SiteContainer36.p__Site42.Target;
					CallSite arg_4D8_1 = HttpHelper.SiteContainer36.p__Site42;
					if (HttpHelper.SiteContainer36.p__Site43 == null)
					{
						HttpHelper.SiteContainer36.p__Site43 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_4D3_0 = HttpHelper.SiteContainer36.p__Site43.Target;
					CallSite arg_4D3_1 = HttpHelper.SiteContainer36.p__Site43;
					if (HttpHelper.SiteContainer36.p__Site44 == null)
					{
						HttpHelper.SiteContainer36.p__Site44 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					object arg_65A_2;
					if (!arg_4E3_0(arg_4E3_1, arg_4DE_0(arg_4DE_1, arg_4D8_0(arg_4D8_1, arg_4D3_0(arg_4D3_1, HttpHelper.SiteContainer36.p__Site44.Target(HttpHelper.SiteContainer36.p__Site44, current, "data"), "singer")), 0)))
					{
						arg_65A_2 = "";
					}
					else
					{
						if (HttpHelper.SiteContainer36.p__Site45 == null)
						{
							HttpHelper.SiteContainer36.p__Site45 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> arg_655_0 = HttpHelper.SiteContainer36.p__Site45.Target;
						CallSite arg_655_1 = HttpHelper.SiteContainer36.p__Site45;
						if (HttpHelper.SiteContainer36.p__Site46 == null)
						{
							HttpHelper.SiteContainer36.p__Site46 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, int, object> arg_64B_0 = HttpHelper.SiteContainer36.p__Site46.Target;
						CallSite arg_64B_1 = HttpHelper.SiteContainer36.p__Site46;
						if (HttpHelper.SiteContainer36.p__Site47 == null)
						{
							HttpHelper.SiteContainer36.p__Site47 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> arg_645_0 = HttpHelper.SiteContainer36.p__Site47.Target;
						CallSite arg_645_1 = HttpHelper.SiteContainer36.p__Site47;
						if (HttpHelper.SiteContainer36.p__Site48 == null)
						{
							HttpHelper.SiteContainer36.p__Site48 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						arg_65A_2 = arg_655_0(arg_655_1, arg_64B_0(arg_64B_1, arg_645_0(arg_645_1, HttpHelper.SiteContainer36.p__Site48.Target(HttpHelper.SiteContainer36.p__Site48, current, "data"), "singer"), 0), "name");
					}
					arg_65F_0.SingerName = arg_65A_0(arg_65A_1, arg_65A_2);
					SongInfo arg_75B_0 = songInfo;
					if (HttpHelper.SiteContainer36.p__Site49 == null)
					{
						HttpHelper.SiteContainer36.p__Site49 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_756_0 = HttpHelper.SiteContainer36.p__Site49.Target;
					CallSite arg_756_1 = HttpHelper.SiteContainer36.p__Site49;
					if (HttpHelper.SiteContainer36.p__Site4a == null)
					{
						HttpHelper.SiteContainer36.p__Site4a = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_751_0 = HttpHelper.SiteContainer36.p__Site4a.Target;
					CallSite arg_751_1 = HttpHelper.SiteContainer36.p__Site4a;
					if (HttpHelper.SiteContainer36.p__Site4b == null)
					{
						HttpHelper.SiteContainer36.p__Site4b = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_75B_0.AlbumName = arg_756_0(arg_756_1, arg_751_0(arg_751_1, HttpHelper.SiteContainer36.p__Site4b.Target(HttpHelper.SiteContainer36.p__Site4b, current, "data"), "albumname"));
					SongInfo arg_857_0 = songInfo;
					if (HttpHelper.SiteContainer36.p__Site4c == null)
					{
						HttpHelper.SiteContainer36.p__Site4c = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_852_0 = HttpHelper.SiteContainer36.p__Site4c.Target;
					CallSite arg_852_1 = HttpHelper.SiteContainer36.p__Site4c;
					if (HttpHelper.SiteContainer36.p__Site4d == null)
					{
						HttpHelper.SiteContainer36.p__Site4d = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_84D_0 = HttpHelper.SiteContainer36.p__Site4d.Target;
					CallSite arg_84D_1 = HttpHelper.SiteContainer36.p__Site4d;
					if (HttpHelper.SiteContainer36.p__Site4e == null)
					{
						HttpHelper.SiteContainer36.p__Site4e = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_857_0.AlbumMID = arg_852_0(arg_852_1, arg_84D_0(arg_84D_1, HttpHelper.SiteContainer36.p__Site4e.Target(HttpHelper.SiteContainer36.p__Site4e, current, "data"), "albummid"));
					SongInfo arg_9B9_0 = songInfo;
					if (HttpHelper.SiteContainer36.p__Site4f == null)
					{
						HttpHelper.SiteContainer36.p__Site4f = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_9B4_0 = HttpHelper.SiteContainer36.p__Site4f.Target;
					CallSite arg_9B4_1 = HttpHelper.SiteContainer36.p__Site4f;
					if (HttpHelper.SiteContainer36.p__Site50 == null)
					{
						HttpHelper.SiteContainer36.p__Site50 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "IntToTimeString", null, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object> arg_9AF_0 = HttpHelper.SiteContainer36.p__Site50.Target;
					CallSite arg_9AF_1 = HttpHelper.SiteContainer36.p__Site50;
					Type arg_9AF_2 = typeof(CommonHelper);
					if (HttpHelper.SiteContainer36.p__Site51 == null)
					{
						HttpHelper.SiteContainer36.p__Site51 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_9AA_0 = HttpHelper.SiteContainer36.p__Site51.Target;
					CallSite arg_9AA_1 = HttpHelper.SiteContainer36.p__Site51;
					if (HttpHelper.SiteContainer36.p__Site52 == null)
					{
						HttpHelper.SiteContainer36.p__Site52 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_9B9_0.ContinuedTime = arg_9B4_0(arg_9B4_1, arg_9AF_0(arg_9AF_1, arg_9AF_2, arg_9AA_0(arg_9AA_1, HttpHelper.SiteContainer36.p__Site52.Target(HttpHelper.SiteContainer36.p__Site52, current, "data"), "interval")));
					SongInfo arg_B1B_0 = songInfo;
					if (HttpHelper.SiteContainer36.p__Site53 == null)
					{
						HttpHelper.SiteContainer36.p__Site53 = CallSite<Func<CallSite, object, double>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(double), typeof(HttpHelper)));
					}
					Func<CallSite, object, double> arg_B16_0 = HttpHelper.SiteContainer36.p__Site53.Target;
					CallSite arg_B16_1 = HttpHelper.SiteContainer36.p__Site53;
					if (HttpHelper.SiteContainer36.p__Site54 == null)
					{
						HttpHelper.SiteContainer36.p__Site54 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ConvertToMB", null, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object> arg_B11_0 = HttpHelper.SiteContainer36.p__Site54.Target;
					CallSite arg_B11_1 = HttpHelper.SiteContainer36.p__Site54;
					Type arg_B11_2 = typeof(CommonHelper);
					if (HttpHelper.SiteContainer36.p__Site55 == null)
					{
						HttpHelper.SiteContainer36.p__Site55 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_B0C_0 = HttpHelper.SiteContainer36.p__Site55.Target;
					CallSite arg_B0C_1 = HttpHelper.SiteContainer36.p__Site55;
					if (HttpHelper.SiteContainer36.p__Site56 == null)
					{
						HttpHelper.SiteContainer36.p__Site56 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_B1B_0.ApeSize = arg_B16_0(arg_B16_1, arg_B11_0(arg_B11_1, arg_B11_2, arg_B0C_0(arg_B0C_1, HttpHelper.SiteContainer36.p__Site56.Target(HttpHelper.SiteContainer36.p__Site56, current, "data"), "sizeape")));
					SongInfo arg_C7D_0 = songInfo;
					if (HttpHelper.SiteContainer36.p__Site57 == null)
					{
						HttpHelper.SiteContainer36.p__Site57 = CallSite<Func<CallSite, object, double>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(double), typeof(HttpHelper)));
					}
					Func<CallSite, object, double> arg_C78_0 = HttpHelper.SiteContainer36.p__Site57.Target;
					CallSite arg_C78_1 = HttpHelper.SiteContainer36.p__Site57;
					if (HttpHelper.SiteContainer36.p__Site58 == null)
					{
						HttpHelper.SiteContainer36.p__Site58 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ConvertToMB", null, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object> arg_C73_0 = HttpHelper.SiteContainer36.p__Site58.Target;
					CallSite arg_C73_1 = HttpHelper.SiteContainer36.p__Site58;
					Type arg_C73_2 = typeof(CommonHelper);
					if (HttpHelper.SiteContainer36.p__Site59 == null)
					{
						HttpHelper.SiteContainer36.p__Site59 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_C6E_0 = HttpHelper.SiteContainer36.p__Site59.Target;
					CallSite arg_C6E_1 = HttpHelper.SiteContainer36.p__Site59;
					if (HttpHelper.SiteContainer36.p__Site5a == null)
					{
						HttpHelper.SiteContainer36.p__Site5a = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_C7D_0.FlacSize = arg_C78_0(arg_C78_1, arg_C73_0(arg_C73_1, arg_C73_2, arg_C6E_0(arg_C6E_1, HttpHelper.SiteContainer36.p__Site5a.Target(HttpHelper.SiteContainer36.p__Site5a, current, "data"), "sizeflac")));
					SongInfo arg_FF9_0 = songInfo;
					if (HttpHelper.SiteContainer36.p__Site5b == null)
					{
						HttpHelper.SiteContainer36.p__Site5b = CallSite<Func<CallSite, object, double>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(double), typeof(HttpHelper)));
					}
					Func<CallSite, object, double> arg_FF4_0 = HttpHelper.SiteContainer36.p__Site5b.Target;
					CallSite arg_FF4_1 = HttpHelper.SiteContainer36.p__Site5b;
					if (HttpHelper.SiteContainer36.p__Site5c == null)
					{
						HttpHelper.SiteContainer36.p__Site5c = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ConvertToMB", null, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object> arg_FEF_0 = HttpHelper.SiteContainer36.p__Site5c.Target;
					CallSite arg_FEF_1 = HttpHelper.SiteContainer36.p__Site5c;
					Type arg_FEF_2 = typeof(CommonHelper);
					if (HttpHelper.SiteContainer36.p__Site5d == null)
					{
						HttpHelper.SiteContainer36.p__Site5d = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> arg_E74_0 = HttpHelper.SiteContainer36.p__Site5d.Target;
					CallSite arg_E74_1 = HttpHelper.SiteContainer36.p__Site5d;
					if (HttpHelper.SiteContainer36.p__Site5e == null)
					{
						HttpHelper.SiteContainer36.p__Site5e = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, int, object> arg_E6F_0 = HttpHelper.SiteContainer36.p__Site5e.Target;
					CallSite arg_E6F_1 = HttpHelper.SiteContainer36.p__Site5e;
					if (HttpHelper.SiteContainer36.p__Site5f == null)
					{
						HttpHelper.SiteContainer36.p__Site5f = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_E69_0 = HttpHelper.SiteContainer36.p__Site5f.Target;
					CallSite arg_E69_1 = HttpHelper.SiteContainer36.p__Site5f;
					if (HttpHelper.SiteContainer36.p__Site60 == null)
					{
						HttpHelper.SiteContainer36.p__Site60 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					object arg_FEF_3;
					if (!arg_E74_0(arg_E74_1, arg_E6F_0(arg_E6F_1, arg_E69_0(arg_E69_1, HttpHelper.SiteContainer36.p__Site60.Target(HttpHelper.SiteContainer36.p__Site60, current, "data"), "size320"), 0)))
					{
						if (HttpHelper.SiteContainer36.p__Site63 == null)
						{
							HttpHelper.SiteContainer36.p__Site63 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> arg_F2F_0 = HttpHelper.SiteContainer36.p__Site63.Target;
						CallSite arg_F2F_1 = HttpHelper.SiteContainer36.p__Site63;
						if (HttpHelper.SiteContainer36.p__Site64 == null)
						{
							HttpHelper.SiteContainer36.p__Site64 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						arg_FEF_3 = arg_F2F_0(arg_F2F_1, HttpHelper.SiteContainer36.p__Site64.Target(HttpHelper.SiteContainer36.p__Site64, current, "data"), "size320");
					}
					else
					{
						if (HttpHelper.SiteContainer36.p__Site61 == null)
						{
							HttpHelper.SiteContainer36.p__Site61 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> arg_FEA_0 = HttpHelper.SiteContainer36.p__Site61.Target;
						CallSite arg_FEA_1 = HttpHelper.SiteContainer36.p__Site61;
						if (HttpHelper.SiteContainer36.p__Site62 == null)
						{
							HttpHelper.SiteContainer36.p__Site62 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						arg_FEF_3 = arg_FEA_0(arg_FEA_1, HttpHelper.SiteContainer36.p__Site62.Target(HttpHelper.SiteContainer36.p__Site62, current, "data"), "size128");
					}
					arg_FF9_0.Mp3Size = arg_FF4_0(arg_FF4_1, arg_FEF_0(arg_FEF_1, arg_FEF_2, arg_FEF_3));
					SongInfo arg_11AC_0 = songInfo;
					if (HttpHelper.SiteContainer36.p__Site65 == null)
					{
						HttpHelper.SiteContainer36.p__Site65 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_11A7_0 = HttpHelper.SiteContainer36.p__Site65.Target;
					CallSite arg_11A7_1 = HttpHelper.SiteContainer36.p__Site65;
					if (HttpHelper.SiteContainer36.p__Site66 == null)
					{
						HttpHelper.SiteContainer36.p__Site66 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					Func<CallSite, object, int, object> arg_11A2_0 = HttpHelper.SiteContainer36.p__Site66.Target;
					CallSite arg_11A2_1 = HttpHelper.SiteContainer36.p__Site66;
					if (HttpHelper.SiteContainer36.p__Site67 == null)
					{
						HttpHelper.SiteContainer36.p__Site67 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_1197_0 = HttpHelper.SiteContainer36.p__Site67.Target;
					CallSite arg_1197_1 = HttpHelper.SiteContainer36.p__Site67;
					if (HttpHelper.SiteContainer36.p__Site68 == null)
					{
						HttpHelper.SiteContainer36.p__Site68 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_118D_0 = HttpHelper.SiteContainer36.p__Site68.Target;
					CallSite arg_118D_1 = HttpHelper.SiteContainer36.p__Site68;
					if (HttpHelper.SiteContainer36.p__Site69 == null)
					{
						HttpHelper.SiteContainer36.p__Site69 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					arg_11AC_0.MV = arg_11A7_0(arg_11A7_1, arg_11A2_0(arg_11A2_1, arg_1197_0(arg_1197_1, arg_118D_0(arg_118D_1, HttpHelper.SiteContainer36.p__Site69.Target(HttpHelper.SiteContainer36.p__Site69, current, "data"), "vid"), ":"), songlist.Count));
					songInfo.PD = new ProcessData();
					songlist.Add(songInfo);
				}
				if (albumMID != null)
				{
					List<SongInfo> list = (from s in songlist
					where s.AlbumMID == albumMID
					select s).ToList<SongInfo>();
					songlist.Clear();
					foreach (SongInfo current2 in list)
					{
						songlist.Add(current2);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private static void GetVkey()
		{
			WebClient webClient = new WebClient();
			byte[] bytes = webClient.DownloadData("http://c.y.qq.com/base/fcgi-bin/fcg_music_express_mobile3.fcg?g_tk=0&loginUin=1008611&hostUin=0&format=json&inCharset=utf8&outCharset=utf-8&notice=0&platform=yqq&needNewCode=0&cid=205361747&uin=1008611&songmid=003a1tne1nSz1Y&filename=C400003a1tne1nSz1Y.m4a&guid=1234567890");
			string @string = Encoding.Default.GetString(bytes);
			object arg = HttpHelper.ConvertJson(@string);
			if (HttpHelper.o__SiteContainer6e.p__Site6f == null)
			{
				HttpHelper.o__SiteContainer6e.p__Site6f = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
			}
			Func<CallSite, object, string> arg_1AF_0 = HttpHelper.o__SiteContainer6e.p__Site6f.Target;
			CallSite arg_1AF_1 = HttpHelper.o__SiteContainer6e.p__Site6f;
			if (HttpHelper.o__SiteContainer6e.p__Site70 == null)
			{
				HttpHelper.o__SiteContainer6e.p__Site70 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> arg_1AA_0 = HttpHelper.o__SiteContainer6e.p__Site70.Target;
			CallSite arg_1AA_1 = HttpHelper.o__SiteContainer6e.p__Site70;
			if (HttpHelper.o__SiteContainer6e.p__Site71 == null)
			{
				HttpHelper.o__SiteContainer6e.p__Site71 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> arg_1A0_0 = HttpHelper.o__SiteContainer6e.p__Site71.Target;
			CallSite arg_1A0_1 = HttpHelper.o__SiteContainer6e.p__Site71;
			if (HttpHelper.o__SiteContainer6e.p__Site72 == null)
			{
				HttpHelper.o__SiteContainer6e.p__Site72 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "items", typeof(HttpHelper), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object> arg_19A_0 = HttpHelper.o__SiteContainer6e.p__Site72.Target;
			CallSite arg_19A_1 = HttpHelper.o__SiteContainer6e.p__Site72;
			if (HttpHelper.o__SiteContainer6e.p__Site73 == null)
			{
				HttpHelper.o__SiteContainer6e.p__Site73 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "data", typeof(HttpHelper), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			HttpHelper.vkey = arg_1AF_0(arg_1AF_1, arg_1AA_0(arg_1AA_1, arg_1A0_0(arg_1A0_1, arg_19A_0(arg_19A_1, HttpHelper.o__SiteContainer6e.p__Site73.Target(HttpHelper.o__SiteContainer6e.p__Site73, arg)), 0), "vkey"));
		}

		public static string GetSongUrl(string OSongurl, string interfaceUrl, string songFormat)
		{
			string result;
			if (songFormat == "mp3")
			{
				try
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.sinsyth.com/yyjx/");
					httpWebRequest.Method = "POST";
					httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
					httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
					httpWebRequest.Referer = "https://www.sinsyth.com/yyjx/?url=https%3A%2F%2Fy.qq.com%2Fn%2Fyqq%2Fsong%2F0032gzUn1AUkbT.html";
					httpWebRequest.Host = "www.sinsyth.com";
					httpWebRequest.Headers.Add("Origin", "https://www.sinsyth.com");
					httpWebRequest.Headers.Add("Cookie", "Hm_lvt_71f7e7ab75dac7ce96aaa4a664d32ea8=1522232894,1522747294");
					httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
					string s = string.Format("input={0}&filter=url&type=_&page=1", OSongurl);
					byte[] bytes = Encoding.UTF8.GetBytes(s);
					httpWebRequest.ContentLength = (long)bytes.Length;
					Stream requestStream = httpWebRequest.GetRequestStream();
					requestStream.Write(bytes, 0, bytes.Length);
					requestStream.Close();
					HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
					string json = streamReader.ReadToEnd();
					object arg = HttpHelper.ConvertJson(json);
					if (HttpHelper.SiteContainer74.p__Site75 == null)
					{
						HttpHelper.SiteContainer74.p__Site75 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_23E_0 = HttpHelper.SiteContainer74.p__Site75.Target;
					CallSite arg_23E_1 = HttpHelper.SiteContainer74.p__Site75;
					if (HttpHelper.SiteContainer74.p__Site76 == null)
					{
						HttpHelper.SiteContainer74.p__Site76 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_239_0 = HttpHelper.SiteContainer74.p__Site76.Target;
					CallSite arg_239_1 = HttpHelper.SiteContainer74.p__Site76;
					if (HttpHelper.SiteContainer74.p__Site77 == null)
					{
						HttpHelper.SiteContainer74.p__Site77 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, int, object> arg_22F_0 = HttpHelper.SiteContainer74.p__Site77.Target;
					CallSite arg_22F_1 = HttpHelper.SiteContainer74.p__Site77;
					if (HttpHelper.SiteContainer74.p__Site78 == null)
					{
						HttpHelper.SiteContainer74.p__Site78 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "data", typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					result = arg_23E_0(arg_23E_1, arg_239_0(arg_239_1, arg_22F_0(arg_22F_1, HttpHelper.SiteContainer74.p__Site78.Target(HttpHelper.SiteContainer74.p__Site78, arg), 0), "url"));
					return result;
				}
				catch
				{
					result = "";
					return result;
				}
			}
			try
			{
				HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(interfaceUrl);
				httpWebRequest2.Method = "POST";
				httpWebRequest2.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
				httpWebRequest2.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";
				string s2 = string.Format("surl={0}&type=" + songFormat + "&strkey=yqq_18analyze", OSongurl);
				byte[] bytes2 = Encoding.UTF8.GetBytes(s2);
				httpWebRequest2.ContentLength = (long)bytes2.Length;
				Stream requestStream2 = httpWebRequest2.GetRequestStream();
				requestStream2.Write(bytes2, 0, bytes2.Length);
				requestStream2.Close();
				HttpWebResponse httpWebResponse2 = (HttpWebResponse)httpWebRequest2.GetResponse();
				StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream(), Encoding.UTF8);
				string json2 = streamReader2.ReadToEnd();
				object arg2 = HttpHelper.ConvertJson(json2);
				streamReader2.Close();
				streamReader2.Dispose();
				requestStream2.Close();
				requestStream2.Dispose();
				if (HttpHelper.SiteContainer74.p__Site79 == null)
				{
					HttpHelper.SiteContainer74.p__Site79 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
				}
				Func<CallSite, object, string> arg_401_0 = HttpHelper.SiteContainer74.p__Site79.Target;
				CallSite arg_401_1 = HttpHelper.SiteContainer74.p__Site79;
				if (HttpHelper.SiteContainer74.p__Site7a == null)
				{
					HttpHelper.SiteContainer74.p__Site7a = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Song", typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> arg_3FC_0 = HttpHelper.SiteContainer74.p__Site7a.Target;
				CallSite arg_3FC_1 = HttpHelper.SiteContainer74.p__Site7a;
				if (HttpHelper.SiteContainer74.p__Site7b == null)
				{
					HttpHelper.SiteContainer74.p__Site7b = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Rendata", typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				result = arg_401_0(arg_401_1, arg_3FC_0(arg_3FC_1, HttpHelper.SiteContainer74.p__Site7b.Target(HttpHelper.SiteContainer74.p__Site7b, arg2)));
			}
			catch
			{
				result = null;
			}
			return result;
		}

		public static string GetSongUrl(string songMid, string songFormat)
		{
			if (HttpHelper.vkey == string.Empty)
			{
				HttpHelper.GetVkey();
			}
			string text = songFormat.Substring(0, 1).ToUpper();
			if (text == "M")
			{
				text += "800";
			}
			else
			{
				text += "000";
			}
			return string.Concat(new string[]
			{
				"http://streamoc.music.tc.qq.com/",
				text,
				songMid,
				".",
				songFormat,
				"?vkey=",
				HttpHelper.vkey,
				"&guid=1234567890&uin=1008611&fromtag=8"
			});
		}

		public static PlayInfo GetTextListen(object song)
		{
			PlayInfo result;
			try
			{
				SongInfo songInfo = song as SongInfo;
				string str = "https://y.qq.com/n/yqq/song/" + songInfo.Mid + ".html";
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.sinsyth.com/yyjx/");
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
				httpWebRequest.Referer = "https://www.sinsyth.com/yyjx/?url=https%3A%2F%2Fy.qq.com%2Fn%2Fyqq%2Fsong%2F0032gzUn1AUkbT.html";
				httpWebRequest.Host = "www.sinsyth.com";
				httpWebRequest.Headers.Add("Origin", "https://www.sinsyth.com");
				httpWebRequest.Headers.Add("Cookie", "Hm_lvt_71f7e7ab75dac7ce96aaa4a664d32ea8=1522232894,1522747294");
				httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
				string s = string.Format("input={0}&filter=url&type=_&page=1", UrlEncodeHtmlHelp.UrlEncode(str));
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				httpWebRequest.ContentLength = (long)bytes.Length;
				Stream requestStream = httpWebRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
				string json = streamReader.ReadToEnd();
				object arg = HttpHelper.ConvertJson(json);
				if (HttpHelper.SiteContainer7c.p__Site7d == null)
				{
					HttpHelper.SiteContainer7c.p__Site7d = CallSite<Func<CallSite, object, ObservableCollection<Lyric>>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(ObservableCollection<Lyric>), typeof(HttpHelper)));
				}
				Func<CallSite, object, ObservableCollection<Lyric>> arg_2BD_0 = HttpHelper.SiteContainer7c.p__Site7d.Target;
				CallSite arg_2BD_1 = HttpHelper.SiteContainer7c.p__Site7d;
				if (HttpHelper.SiteContainer7c.p__Site7e == null)
				{
					HttpHelper.SiteContainer7c.p__Site7e = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ResolveLyric", null, typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, Type, object, object> arg_2B8_0 = HttpHelper.SiteContainer7c.p__Site7e.Target;
				CallSite arg_2B8_1 = HttpHelper.SiteContainer7c.p__Site7e;
				Type arg_2B8_2 = typeof(HttpHelper);
				if (HttpHelper.SiteContainer7c.p__Site7f == null)
				{
					HttpHelper.SiteContainer7c.p__Site7f = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_2B3_0 = HttpHelper.SiteContainer7c.p__Site7f.Target;
				CallSite arg_2B3_1 = HttpHelper.SiteContainer7c.p__Site7f;
				if (HttpHelper.SiteContainer7c.p__Site80 == null)
				{
					HttpHelper.SiteContainer7c.p__Site80 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> arg_2A9_0 = HttpHelper.SiteContainer7c.p__Site80.Target;
				CallSite arg_2A9_1 = HttpHelper.SiteContainer7c.p__Site80;
				if (HttpHelper.SiteContainer7c.p__Site81 == null)
				{
					HttpHelper.SiteContainer7c.p__Site81 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "data", typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				ObservableCollection<Lyric> lyrics = arg_2BD_0(arg_2BD_1, arg_2B8_0(arg_2B8_1, arg_2B8_2, arg_2B3_0(arg_2B3_1, arg_2A9_0(arg_2A9_1, HttpHelper.SiteContainer7c.p__Site81.Target(HttpHelper.SiteContainer7c.p__Site81, arg), 0), "lrc")));
				PlayInfo playInfo = new PlayInfo();
				PlayInfo arg_40E_0 = playInfo;
				if (HttpHelper.SiteContainer7c.p__Site82 == null)
				{
					HttpHelper.SiteContainer7c.p__Site82 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
				}
				Func<CallSite, object, string> arg_409_0 = HttpHelper.SiteContainer7c.p__Site82.Target;
				CallSite arg_409_1 = HttpHelper.SiteContainer7c.p__Site82;
				if (HttpHelper.SiteContainer7c.p__Site83 == null)
				{
					HttpHelper.SiteContainer7c.p__Site83 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> arg_404_0 = HttpHelper.SiteContainer7c.p__Site83.Target;
				CallSite arg_404_1 = HttpHelper.SiteContainer7c.p__Site83;
				if (HttpHelper.SiteContainer7c.p__Site84 == null)
				{
					HttpHelper.SiteContainer7c.p__Site84 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> arg_3FA_0 = HttpHelper.SiteContainer7c.p__Site84.Target;
				CallSite arg_3FA_1 = HttpHelper.SiteContainer7c.p__Site84;
				if (HttpHelper.SiteContainer7c.p__Site85 == null)
				{
					HttpHelper.SiteContainer7c.p__Site85 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "data", typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				arg_40E_0.SongUrl = arg_409_0(arg_409_1, arg_404_0(arg_404_1, arg_3FA_0(arg_3FA_1, HttpHelper.SiteContainer7c.p__Site85.Target(HttpHelper.SiteContainer7c.p__Site85, arg), 0), "url"));
				playInfo.Lyrics = lyrics;
				result = playInfo;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		public static PlayInfo GetSongListenNew(object song)
		{
			SongInfo songInfo = song as SongInfo;
			PlayInfo playInfo = new PlayInfo();
			playInfo.SongUrl = HttpHelper.GetSongUrl(songInfo.Mid, "mp3");
			string lyric = HttpHelper.GetLyric(songInfo);
			if (lyric != null)
			{
				playInfo.Lyrics = HttpHelper.ResolveLyric(lyric);
			}
			return playInfo;
		}

		public static string GetLyric(SongInfo si)
		{
			string requestUriString = "https://c.y.qq.com/lyric/fcgi-bin/fcg_query_lyric_new.fcg?callback=MusicJsonCallback_lrc&pcachetime=1494070301711&songmid=" + si.Mid + "&g_tk=5381&jsonpCallback=MusicJsonCallback_lrc&loginUin=0&hostUin=0&format=jsonp&inCharset=utf8&outCharset=utf-8¬ice=0&platform=yqq&needNewCode=0";
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.Method = "GET";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
			httpWebRequest.Referer = "https://y.qq.com/portal/player.html";
			httpWebRequest.Host = "c.y.qq.com";
			httpWebRequest.Headers.Add("Cookie", "pgv_pvid=8455821612; ts_uid=1596880404; pgv_pvi=9708980224; yq_index=0; pgv_si=s3191448576; pgv_info=ssid=s8059271672; ts_refer=ADTAGmyqq; yq_playdata=s; ts_last=y.qq.com/portal/player.html; yqq_stat=0; yq_playschange=0; player_exist=1; qqmusic_fromtag=66; yplayer_open=1");
			string result;
			try
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
				string input = streamReader.ReadToEnd();
				Regex regex = new Regex("{.*}", RegexOptions.IgnoreCase | RegexOptions.Multiline);
				Match match = regex.Match(input);
				if (match.Success)
				{
					object arg = HttpHelper.ConvertJson(match.Value);
					if (HttpHelper.SiteContainer86.p__Site87 == null)
					{
						HttpHelper.SiteContainer86.p__Site87 = CallSite<Func<CallSite, object, byte[]>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(byte[]), typeof(HttpHelper)));
					}
					Func<CallSite, object, byte[]> arg_1B6_0 = HttpHelper.SiteContainer86.p__Site87.Target;
					CallSite arg_1B6_1 = HttpHelper.SiteContainer86.p__Site87;
					if (HttpHelper.SiteContainer86.p__Site88 == null)
					{
						HttpHelper.SiteContainer86.p__Site88 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "FromBase64String", null, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object> arg_1B1_0 = HttpHelper.SiteContainer86.p__Site88.Target;
					CallSite arg_1B1_1 = HttpHelper.SiteContainer86.p__Site88;
					Type arg_1B1_2 = typeof(Convert);
					if (HttpHelper.SiteContainer86.p__Site89 == null)
					{
						HttpHelper.SiteContainer86.p__Site89 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "lyric", typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					byte[] bytes = arg_1B6_0(arg_1B6_1, arg_1B1_0(arg_1B1_1, arg_1B1_2, HttpHelper.SiteContainer86.p__Site89.Target(HttpHelper.SiteContainer86.p__Site89, arg)));
					string @string = Encoding.UTF8.GetString(bytes);
					result = @string;
				}
				else
				{
					result = null;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		public static string GetMvFileAddress(string mvID)
		{
			string requestUriString = "https://u.y.qq.com/cgi-bin/musicu.fcg?data={\"getMvUrl\":{\"module\":\"gosrf.Stream.MvUrlProxy\",\"method\":\"GetMvUrls\",\"param\":{\"vids\":[\"" + mvID + "\"],\"request_typet\":10001}}}&g_tk=5381&callback=jQuery112305949063878897483_1535229284749&loginUin=0&hostUin=0&format=jsonp&inCharset=utf8&outCharset=GB2312&notice=0&platform=yqq&needNewCode=0";
			string result;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
				httpWebRequest.Method = "GET";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
				httpWebRequest.Host = "u.y.qq.com";
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
				string input = streamReader.ReadToEnd();
				Regex regex = new Regex("\"mp4\":\\s*\\[.*\\]", RegexOptions.IgnoreCase | RegexOptions.Multiline);
				Match match = regex.Match(input);
				if (match.Success)
				{
					object arg = HttpHelper.ConvertJson("{" + match.Value + "}");
					if (HttpHelper.SiteContainer8a.p__Site8b == null)
					{
						HttpHelper.SiteContainer8a.p__Site8b = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(HttpHelper)));
					}
					Func<CallSite, object, int> arg_1E1_0 = HttpHelper.SiteContainer8a.p__Site8b.Target;
					CallSite arg_1E1_1 = HttpHelper.SiteContainer8a.p__Site8b;
					if (HttpHelper.SiteContainer8a.p__Site8c == null)
					{
						HttpHelper.SiteContainer8a.p__Site8c = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Subtract, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, int, object> arg_1DC_0 = HttpHelper.SiteContainer8a.p__Site8c.Target;
					CallSite arg_1DC_1 = HttpHelper.SiteContainer8a.p__Site8c;
					if (HttpHelper.SiteContainer8a.p__Site8d == null)
					{
						HttpHelper.SiteContainer8a.p__Site8d = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Count", typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> arg_1D6_0 = HttpHelper.SiteContainer8a.p__Site8d.Target;
					CallSite arg_1D6_1 = HttpHelper.SiteContainer8a.p__Site8d;
					if (HttpHelper.SiteContainer8a.p__Site8e == null)
					{
						HttpHelper.SiteContainer8a.p__Site8e = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "mp4", typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					for (int i = arg_1E1_0(arg_1E1_1, arg_1DC_0(arg_1DC_1, arg_1D6_0(arg_1D6_1, HttpHelper.SiteContainer8a.p__Site8e.Target(HttpHelper.SiteContainer8a.p__Site8e, arg)), 1)); i > -1; i--)
					{
						if (HttpHelper.SiteContainer8a.p__Site8f == null)
						{
							HttpHelper.SiteContainer8a.p__Site8f = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> arg_3DE_0 = HttpHelper.SiteContainer8a.p__Site8f.Target;
						CallSite arg_3DE_1 = HttpHelper.SiteContainer8a.p__Site8f;
						if (HttpHelper.SiteContainer8a.p__Site90 == null)
						{
							HttpHelper.SiteContainer8a.p__Site90 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.GreaterThan, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, int, object> arg_3D9_0 = HttpHelper.SiteContainer8a.p__Site90.Target;
						CallSite arg_3D9_1 = HttpHelper.SiteContainer8a.p__Site90;
						if (HttpHelper.SiteContainer8a.p__Site91 == null)
						{
							HttpHelper.SiteContainer8a.p__Site91 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Count", typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> arg_3D3_0 = HttpHelper.SiteContainer8a.p__Site91.Target;
						CallSite arg_3D3_1 = HttpHelper.SiteContainer8a.p__Site91;
						if (HttpHelper.SiteContainer8a.p__Site92 == null)
						{
							HttpHelper.SiteContainer8a.p__Site92 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> arg_3CE_0 = HttpHelper.SiteContainer8a.p__Site92.Target;
						CallSite arg_3CE_1 = HttpHelper.SiteContainer8a.p__Site92;
						if (HttpHelper.SiteContainer8a.p__Site93 == null)
						{
							HttpHelper.SiteContainer8a.p__Site93 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Func<CallSite, object, int, object> arg_3C4_0 = HttpHelper.SiteContainer8a.p__Site93.Target;
						CallSite arg_3C4_1 = HttpHelper.SiteContainer8a.p__Site93;
						if (HttpHelper.SiteContainer8a.p__Site94 == null)
						{
							HttpHelper.SiteContainer8a.p__Site94 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "mp4", typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						if (arg_3DE_0(arg_3DE_1, arg_3D9_0(arg_3D9_1, arg_3D3_0(arg_3D3_1, arg_3CE_0(arg_3CE_1, arg_3C4_0(arg_3C4_1, HttpHelper.SiteContainer8a.p__Site94.Target(HttpHelper.SiteContainer8a.p__Site94, arg), i), "freeflow_url")), 0)))
						{
							if (HttpHelper.SiteContainer8a.p__Site95 == null)
							{
								HttpHelper.SiteContainer8a.p__Site95 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
							}
							Func<CallSite, object, string> arg_57B_0 = HttpHelper.SiteContainer8a.p__Site95.Target;
							CallSite arg_57B_1 = HttpHelper.SiteContainer8a.p__Site95;
							if (HttpHelper.SiteContainer8a.p__Site96 == null)
							{
								HttpHelper.SiteContainer8a.p__Site96 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							Func<CallSite, object, int, object> arg_576_0 = HttpHelper.SiteContainer8a.p__Site96.Target;
							CallSite arg_576_1 = HttpHelper.SiteContainer8a.p__Site96;
							if (HttpHelper.SiteContainer8a.p__Site97 == null)
							{
								HttpHelper.SiteContainer8a.p__Site97 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							Func<CallSite, object, string, object> arg_570_0 = HttpHelper.SiteContainer8a.p__Site97.Target;
							CallSite arg_570_1 = HttpHelper.SiteContainer8a.p__Site97;
							if (HttpHelper.SiteContainer8a.p__Site98 == null)
							{
								HttpHelper.SiteContainer8a.p__Site98 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(HttpHelper), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
								}));
							}
							Func<CallSite, object, int, object> arg_566_0 = HttpHelper.SiteContainer8a.p__Site98.Target;
							CallSite arg_566_1 = HttpHelper.SiteContainer8a.p__Site98;
							if (HttpHelper.SiteContainer8a.p__Site99 == null)
							{
								HttpHelper.SiteContainer8a.p__Site99 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "mp4", typeof(HttpHelper), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							result = arg_57B_0(arg_57B_1, arg_576_0(arg_576_1, arg_570_0(arg_570_1, arg_566_0(arg_566_1, HttpHelper.SiteContainer8a.p__Site99.Target(HttpHelper.SiteContainer8a.p__Site99, arg), i), "freeflow_url"), 0));
							return result;
						}
					}
				}
				result = "获取失败";
			}
			catch
			{
				result = "获取失败";
			}
			return result;
		}

		public static string GetNewVersion(Version currentVer)
		{
			string requestUriString = "http://39.104.93.113/updateversion.json";
			string result;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
				httpWebRequest.Method = "GET";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
				string json = streamReader.ReadToEnd();
				object arg = HttpHelper.ConvertJson(json);
				if (HttpHelper.SiteContainer9a.p__Site9b == null)
				{
					HttpHelper.SiteContainer9a.p__Site9b = CallSite<Func<CallSite, object, Version>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Version), typeof(HttpHelper)));
				}
				Func<CallSite, object, Version> arg_152_0 = HttpHelper.SiteContainer9a.p__Site9b.Target;
				CallSite arg_152_1 = HttpHelper.SiteContainer9a.p__Site9b;
				if (HttpHelper.SiteContainer9a.p__Site9c == null)
				{
					HttpHelper.SiteContainer9a.p__Site9c = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Parse", null, typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, Type, object, object> arg_14D_0 = HttpHelper.SiteContainer9a.p__Site9c.Target;
				CallSite arg_14D_1 = HttpHelper.SiteContainer9a.p__Site9c;
				Type arg_14D_2 = typeof(Version);
				if (HttpHelper.SiteContainer9a.p__Site9d == null)
				{
					HttpHelper.SiteContainer9a.p__Site9d = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "NewestVersion", typeof(HttpHelper), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Version v = arg_152_0(arg_152_1, arg_14D_0(arg_14D_1, arg_14D_2, HttpHelper.SiteContainer9a.p__Site9d.Target(HttpHelper.SiteContainer9a.p__Site9d, arg)));
				if (currentVer == v)
				{
					result = "当前已经是最新版";
				}
				else
				{
					if (HttpHelper.SiteContainer9a.p__Site9e == null)
					{
						HttpHelper.SiteContainer9a.p__Site9e = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(HttpHelper)));
					}
					Func<CallSite, object, string> arg_2FC_0 = HttpHelper.SiteContainer9a.p__Site9e.Target;
					CallSite arg_2FC_1 = HttpHelper.SiteContainer9a.p__Site9e;
					if (HttpHelper.SiteContainer9a.p__Site9f == null)
					{
						HttpHelper.SiteContainer9a.p__Site9f = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object, object> arg_2F7_0 = HttpHelper.SiteContainer9a.p__Site9f.Target;
					CallSite arg_2F7_1 = HttpHelper.SiteContainer9a.p__Site9f;
					if (HttpHelper.SiteContainer9a.p__Sitea0 == null)
					{
						HttpHelper.SiteContainer9a.p__Sitea0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> arg_2A1_0 = HttpHelper.SiteContainer9a.p__Sitea0.Target;
					CallSite arg_2A1_1 = HttpHelper.SiteContainer9a.p__Sitea0;
					if (HttpHelper.SiteContainer9a.p__Sitea1 == null)
					{
						HttpHelper.SiteContainer9a.p__Sitea1 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "DownloadUrl", typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object arg_2F7_2 = arg_2A1_0(arg_2A1_1, HttpHelper.SiteContainer9a.p__Sitea1.Target(HttpHelper.SiteContainer9a.p__Sitea1, arg), ";");
					if (HttpHelper.SiteContainer9a.p__Sitea2 == null)
					{
						HttpHelper.SiteContainer9a.p__Sitea2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "DownLoadPWD", typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					string text = arg_2FC_0(arg_2FC_1, arg_2F7_0(arg_2F7_1, arg_2F7_2, HttpHelper.SiteContainer9a.p__Sitea2.Target(HttpHelper.SiteContainer9a.p__Sitea2, arg)));
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(";");
					if (HttpHelper.SiteContainer9a.p__Sitea3 == null)
					{
						HttpHelper.SiteContainer9a.p__Sitea3 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(HttpHelper)));
					}
					Func<CallSite, object, IEnumerable> arg_3A2_0 = HttpHelper.SiteContainer9a.p__Sitea3.Target;
					CallSite arg_3A2_1 = HttpHelper.SiteContainer9a.p__Sitea3;
					if (HttpHelper.SiteContainer9a.p__Sitea4 == null)
					{
						HttpHelper.SiteContainer9a.p__Sitea4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "UpdateMessage", typeof(HttpHelper), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					foreach (object current in arg_3A2_0(arg_3A2_1, HttpHelper.SiteContainer9a.p__Sitea4.Target(HttpHelper.SiteContainer9a.p__Sitea4, arg)))
					{
						if (HttpHelper.SiteContainer9a.p__Sitea5 == null)
						{
							HttpHelper.SiteContainer9a.p__Sitea5 = CallSite<Action<CallSite, object, string>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Append", null, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Action<CallSite, object, string> arg_47A_0 = HttpHelper.SiteContainer9a.p__Sitea5.Target;
						CallSite arg_47A_1 = HttpHelper.SiteContainer9a.p__Sitea5;
						if (HttpHelper.SiteContainer9a.p__Sitea6 == null)
						{
							HttpHelper.SiteContainer9a.p__Sitea6 = CallSite<Func<CallSite, StringBuilder, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Append", null, typeof(HttpHelper), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						arg_47A_0(arg_47A_1, HttpHelper.SiteContainer9a.p__Sitea6.Target(HttpHelper.SiteContainer9a.p__Sitea6, stringBuilder, current), Environment.NewLine);
					}
					text += stringBuilder.ToString();
					result = text;
				}
			}
			catch
			{
				result = "版本检测出错,请反馈作者";
			}
			return result;
		}

		public static void DownFile(string fileUrl, string savePath, ProcessData pd)
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(HttpHelper.wc_DownloadMusicCompleted);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(HttpHelper.wc_DownloadProgressChanged);
			webClient.DownloadFileAsync(new Uri(fileUrl), savePath, new FileDownMsg
			{
				PD = pd,
				FilePath = savePath
			});
		}

		private static void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			FileDownMsg fileDownMsg = e.UserState as FileDownMsg;
			if (fileDownMsg != null)
			{
				ProcessData pD = fileDownMsg.PD;
				pD.MaxValue = e.TotalBytesToReceive;
				pD.CurrentValue = e.BytesReceived;
				pD.DownPercent = e.ProgressPercentage.ToString() + "%";
			}
		}

		private static void wc_DownloadMusicCompleted(object sender, AsyncCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				FileDownMsg fileDownMsg = e.UserState as FileDownMsg;
				if (fileDownMsg != null)
				{
					ProcessData pD = fileDownMsg.PD;
					pD.DownPercent = "请切换格式重试";
					try
					{
						File.Delete(fileDownMsg.FilePath);
					}
					catch
					{
					}
				}
			}
		}

		private static dynamic ConvertJson(string json)
		{
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
			javaScriptSerializer.RegisterConverters(new JavaScriptConverter[]
			{
				new DynamicJsonConverter()
			});
			return javaScriptSerializer.Deserialize(json, typeof(object));
		}

		public static void DownLrc(SongInfo si, ref List<Lyric> lrc)
		{
			if (si == null)
			{
				return;
			}
			WebClient webClient = new WebClient();
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36");
			Uri requestUri = new Uri(CommonHelper.LrcSearch + UrlEncodeHtmlHelp.UrlEncode(si.Name + " " + si.SingerName) + "&radio=0");
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";
			string s = string.Format("", new object[0]);
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			httpWebRequest.ContentLength = (long)bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
			string input = streamReader.ReadToEnd();
			Regex regex = new Regex(CommonHelper.DownHrefRegexJiuKu, RegexOptions.IgnoreCase | RegexOptions.Singleline);
			MatchCollection matchCollection = regex.Matches(input);
			if (matchCollection.Count > 0)
			{
				Regex regex2 = new Regex("<a title=\"" + si.SingerName, RegexOptions.IgnoreCase | RegexOptions.Singleline);
				foreach (Match match in matchCollection)
				{
					if (regex2.IsMatch(match.Value))
					{
						Regex regex3 = new Regex("class=\"adw\" href=\"(lrc/.*\\.lrc)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
						string tempPath = Path.GetTempPath();
						string str = si.Name + "-" + si.SingerName + ".lrc";
						if (File.Exists(tempPath + str))
						{
							HttpHelper.ResolveLyric(lrc, tempPath + str);
						}
						else
						{
							Uri address = new Uri(CommonHelper.LrcDownHeader + regex3.Match(match.Value).Groups[1].Value);
							webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(HttpHelper.wc_DownloadFileCompleted);
							webClient.DownloadFileAsync(address, tempPath + str, new LrcData
							{
								FileName = tempPath + str,
								lrcResult = lrc
							});
						}
					}
				}
			}
		}

		private static void ResolveLyric(List<Lyric> lrc, string fileName)
		{
			try
			{
				string[] array = File.ReadAllLines(fileName, Encoding.Default);
				Regex regex = new Regex(CommonHelper.LyricLineRegex, RegexOptions.IgnoreCase | RegexOptions.Multiline);
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					string input = array2[i];
					if (regex.IsMatch(input))
					{
						Match match = regex.Match(input);
						lrc.Add(new Lyric
						{
							Text = match.Groups[2].Value,
							Time = TimeSpan.Parse("00:" + match.Groups[1].Value)
						});
					}
				}
			}
			catch
			{
			}
		}

		private static ObservableCollection<Lyric> ResolveLyric(string lyricString)
		{
			ObservableCollection<Lyric> observableCollection = new ObservableCollection<Lyric>();
			Regex regex = new Regex("\\[(\\d+:\\d+\\.\\d+)\\](.*?)(?=\\n)", RegexOptions.IgnoreCase);
			MatchCollection matchCollection = regex.Matches(lyricString);
			foreach (Match match in matchCollection)
			{
				observableCollection.Add(new Lyric
				{
					Text = match.Groups[2].Value,
					Time = TimeSpan.Parse("00:" + match.Groups[1].Value)
				});
			}
			return observableCollection;
		}

		private static void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			LrcData lrcData = e.UserState as LrcData;
			if (lrcData != null)
			{
				if (e.Error != null)
				{
					try
					{
						File.Delete(e.UserState.ToString());
					}
					catch
					{
					}
					return;
				}
				HttpHelper.ResolveLyric(lrcData.lrcResult, lrcData.FileName);
			}
		}
	}
}
