using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace com.winne.MusicDown
{
	public static class UrlEncodeHtmlHelp
	{
		private static char[] _htmlEntityEndingChars = new char[]
		{
			';',
			'&'
		};

		public static string UrlEncode(string str)
		{
			if (str == null)
			{
				return null;
			}
			Encoding uTF = Encoding.UTF8;
			return Encoding.ASCII.GetString(UrlEncodeHtmlHelp.UrlEncodeToBytes(str, uTF));
		}

		public static byte[] UrlEncodeToBytes(string str, Encoding e)
		{
			if (str == null)
			{
				return null;
			}
			byte[] bytes = e.GetBytes(str);
			return UrlEncodeHtmlHelp.UrlEncode(bytes, 0, bytes.Length);
		}

		private static byte[] UrlEncode(byte[] bytes, int offset, int count)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < count; i++)
			{
				char c = (char)bytes[offset + i];
				if (c == ' ')
				{
					num++;
				}
				else if (!UrlEncodeHtmlHelp.IsUrlSafeChar(c))
				{
					num2++;
				}
			}
			if (num == 0 && num2 == 0)
			{
				return bytes;
			}
			byte[] array = new byte[count + num2 * 2];
			int num3 = 0;
			for (int j = 0; j < count; j++)
			{
				byte b = bytes[offset + j];
				char c2 = (char)b;
				if (UrlEncodeHtmlHelp.IsUrlSafeChar(c2))
				{
					array[num3++] = b;
				}
				else if (c2 == ' ')
				{
					array[num3++] = 43;
				}
				else
				{
					array[num3++] = 37;
					array[num3++] = (byte)UrlEncodeHtmlHelp.IntToHex(b >> 4 & 15);
					array[num3++] = (byte)UrlEncodeHtmlHelp.IntToHex((int)(b & 15));
				}
			}
			return array;
		}

		public static bool IsUrlSafeChar(char ch)
		{
			if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9'))
			{
				return true;
			}
			if (ch != '!')
			{
				switch (ch)
				{
				case '(':
				case ')':
				case '*':
				case '-':
				case '.':
					return true;
				case '+':
				case ',':
					break;
				default:
					if (ch == '_')
					{
						return true;
					}
					break;
				}
				return false;
			}
			return true;
		}

		public static char IntToHex(int n)
		{
			if (n <= 9)
			{
				return (char)(n + 48);
			}
			return (char)(n - 10 + 97);
		}

		public static string UrlDecode(string value)
		{
			if (value == null)
			{
				return null;
			}
			Encoding uTF = Encoding.UTF8;
			int length = value.Length;
			UrlDecoder urlDecoder = new UrlDecoder(length, uTF);
			int i = 0;
			while (i < length)
			{
				char c = value[i];
				if (c == '+')
				{
					c = ' ';
					goto IL_117;
				}
				if (c != '%' || i >= length - 2)
				{
					goto IL_117;
				}
				if (value[i + 1] == 'u' && i < length - 5)
				{
					int num = UrlEncodeHtmlHelp.HexToInt(value[i + 2]);
					int num2 = UrlEncodeHtmlHelp.HexToInt(value[i + 3]);
					int num3 = UrlEncodeHtmlHelp.HexToInt(value[i + 4]);
					int num4 = UrlEncodeHtmlHelp.HexToInt(value[i + 5]);
					if (num < 0 || num2 < 0 || num3 < 0 || num4 < 0)
					{
						goto IL_117;
					}
					c = (char)(num << 12 | num2 << 8 | num3 << 4 | num4);
					i += 5;
					urlDecoder.AddChar(c);
				}
				else
				{
					int num5 = UrlEncodeHtmlHelp.HexToInt(value[i + 1]);
					int num6 = UrlEncodeHtmlHelp.HexToInt(value[i + 2]);
					if (num5 < 0 || num6 < 0)
					{
						goto IL_117;
					}
					byte b = (byte)(num5 << 4 | num6);
					i += 2;
					urlDecoder.AddByte(b);
				}
				IL_134:
				i++;
				continue;
				IL_117:
				if ((c & 'ﾀ') == '\0')
				{
					urlDecoder.AddByte((byte)c);
					goto IL_134;
				}
				urlDecoder.AddChar(c);
				goto IL_134;
			}
			return urlDecoder.GetString();
		}

		public static int HexToInt(char h)
		{
			if (h >= '0' && h <= '9')
			{
				return (int)(h - '0');
			}
			if (h >= 'a' && h <= 'f')
			{
				return (int)(h - 'a' + '\n');
			}
			if (h >= 'A' && h <= 'F')
			{
				return (int)(h - 'A' + '\n');
			}
			return -1;
		}

		public static string HtmlEncode(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return value;
			}
			StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
			UrlEncodeHtmlHelp.HtmlEncode(value, stringWriter);
			return stringWriter.ToString();
		}

		public unsafe static void HtmlEncode(string value, TextWriter output)
		{
			if (value != null)
			{
				if (output == null)
				{
					throw new ArgumentNullException("output");
				}
				int num = UrlEncodeHtmlHelp.IndexOfHtmlEncodingChars(value, 0);
				if (num == -1)
				{
					output.Write(value);
					return;
				}
				int num2 = value.Length - num;
				fixed (char* ptr = value.ToCharArray())
				{
					char* ptr2 = ptr;
					char* ptr3 = ptr2;
					while (num-- > 0)
					{
						ptr3++;
						output.Write(*ptr3);
					}
					while (num2-- > 0)
					{
						ptr3++;
						char c = *ptr3;
						if (c <= '>')
						{
							char c2 = c;
							if (c2 != '"')
							{
								switch (c2)
								{
								case '&':
									output.Write("&amp;");
									break;
								case '\'':
									output.Write("'");
									break;
								default:
									switch (c2)
									{
									case '<':
										output.Write("&lt;");
										continue;
									case '>':
										output.Write("&gt;");
										continue;
									}
									output.Write(c);
									break;
								}
							}
							else
							{
								output.Write("&quot;");
							}
						}
						else if (c >= '\u00a0' && c < 'Ā')
						{
							output.Write("&#");
							output.Write(c.ToString(NumberFormatInfo.InvariantInfo));
							output.Write(';');
						}
						else
						{
							output.Write(c);
						}
					}
				}
			}
		}

		public static string HtmlDecode(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return value;
			}
			StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
			UrlEncodeHtmlHelp.HtmlDecode(value, stringWriter);
			return stringWriter.ToString();
		}

		public static void HtmlDecode(string value, TextWriter output)
		{
			if (value != null)
			{
				if (output == null)
				{
					throw new ArgumentNullException("output");
				}
				if (value.IndexOf('&') < 0)
				{
					output.Write(value);
					return;
				}
				int length = value.Length;
				int i = 0;
				while (i < length)
				{
					char c = value[i];
					if (c != '&')
					{
						goto IL_112;
					}
					int num = value.IndexOfAny(UrlEncodeHtmlHelp._htmlEntityEndingChars, i + 1);
					if (num <= 0 || value[num] != ';')
					{
						goto IL_112;
					}
					string text = value.Substring(i + 1, num - i - 1);
					if (text.Length > 1 && text[0] == '#')
					{
						ushort num2;
						if (text[1] == 'x' || text[1] == 'X')
						{
							ushort.TryParse(text.Substring(2), NumberStyles.AllowHexSpecifier, NumberFormatInfo.InvariantInfo, out num2);
						}
						else
						{
							ushort.TryParse(text.Substring(1), NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out num2);
						}
						if (num2 != 0)
						{
							c = (char)num2;
							i = num;
							goto IL_112;
						}
						goto IL_112;
					}
					else
					{
						i = num;
						char c2 = HtmlEntities.Lookup(text);
						if (c2 != '\0')
						{
							c = c2;
							goto IL_112;
						}
						output.Write('&');
						output.Write(text);
						output.Write(';');
					}
					IL_119:
					i++;
					continue;
					IL_112:
					output.Write(c);
					goto IL_119;
				}
			}
		}

		private unsafe static int IndexOfHtmlEncodingChars(string s, int startPos)
		{
			int i = s.Length - startPos;
			try
			{
				fixed (char* ptr = s.ToCharArray())
				{
					char* ptr2 = ptr;
					char* ptr3 = ptr2 + startPos;
					while (i > 0)
					{
						char c = *ptr3;
						if (c <= '>')
						{
							char c2 = c;
							if (c2 != '"')
							{
								switch (c2)
								{
								case '&':
								case '\'':
									break;
								default:
									switch (c2)
									{
									case '<':
									case '>':
										break;
									case '=':
										goto IL_9C;
									default:
										goto IL_9C;
									}
									break;
								}
							}
							int result = s.Length - i;
							return result;
						}
						if (c >= '\u00a0' && c < 'Ā')
						{
							int result = s.Length - i;
							return result;
						}
						IL_9C:
						ptr3++;
						i--;
					}
				}
			}
			finally
			{
				char* ptr = null;
			}
			return -1;
		}
	}
}
