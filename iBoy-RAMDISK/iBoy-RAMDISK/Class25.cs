using System;
using System.IO;
using System.Net;
using System.Text;

// Token: 0x02000028 RID: 40
internal class Class25
{
	// Token: 0x0600011E RID: 286 RVA: 0x00011BD8 File Offset: 0x0000FDD8
	public bool method_0(string string_0, string string_1)
	{
		uint num = Class27.smethod_0(string_0);
		if (num > 2065103420U)
		{
			if (num <= 3499401685U)
			{
				if (num == 2192567781U)
				{
					if (string_0 == "eraser")
					{
						return this.method_1(string_1);
					}
				}
				else if (num == 3499401685U && string_0 == "boot")
				{
					return this.method_1(string_1);
				}
			}
			else if (num == 3782165653U)
			{
				if (string_0 == "gaster")
				{
					return this.method_1(string_1);
				}
			}
			else if (num == 4199289758U)
			{
				if (string_0 == "activatebackup")
				{
					return this.method_1(string_1);
				}
			}
		}
		else if (num != 850372319U)
		{
			if (num == 1090182821U)
			{
				if (string_0 == "boot2")
				{
					return this.method_1(string_1);
				}
			}
			else if (num == 2065103420U && string_0 == "boot_purple")
			{
				return this.method_1(string_1);
			}
		}
		else if (string_0 == "backup")
		{
			return this.method_1(string_1);
		}
		return false;
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00011CF8 File Offset: 0x0000FEF8
	private bool method_1(string string_0)
	{
		bool flag;
		try
		{
			string text = "http://pentaboy.my.id/ramdisk/api.php?ecid=" + string_0;
			HttpWebRequest httpWebRequest = WebRequest.CreateHttp(text);
			httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			httpWebRequest.Timeout = -1;
			string text2;
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
				{
					text2 = streamReader.ReadToEnd();
				}
			}
			flag = text2 == "AUTHORIZED";
		}
		catch
		{
			flag = false;
		}
		return flag;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00011DA4 File Offset: 0x0000FFA4
	public string method_2()
	{
		string string_ = Class19.string_2;
		HttpWebRequest httpWebRequest = WebRequest.CreateHttp("http://pentaboy.my.id/ramdisk/api.php?ecid=" + string_);
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		httpWebRequest.Timeout = 7000;
		string text;
		using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
		{
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
			{
				text = streamReader.ReadToEnd();
			}
		}
		return text;
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00011E30 File Offset: 0x00010030
	public string method_3(string string_0, Encoding encoding_0 = null)
	{
		string text;
		if (string_0 != null)
		{
			encoding_0 = encoding_0 ?? Encoding.UTF8;
			byte[] bytes = encoding_0.GetBytes(string_0);
			text = Convert.ToBase64String(bytes);
		}
		else
		{
			text = null;
		}
		return text;
	}
}
