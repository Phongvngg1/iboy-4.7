using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Ionic.Zip;

// Token: 0x02000014 RID: 20
internal class Class8
{
	// Token: 0x06000067 RID: 103 RVA: 0x00007B34 File Offset: 0x00005D34
	public void method_0()
	{
		this.method_6();
		this.method_3(1);
		if (!File.Exists(string.Concat(new string[]
		{
			".\\Data\\ramdisk\\",
			Class19.string_4,
			"-",
			Class19.string_0,
			".zip"
		})))
		{
			new Class17();
			MessageBox.Show(string.Concat(new string[]
			{
				"Bootchain Not Found Please Download ",
				Class19.string_4,
				"-",
				Class19.string_0,
				".zip"
			}), "WARNING !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Console.WriteLine("File Notfound then Download");
		}
		else
		{
			Console.WriteLine("File Found in Directory");
		}
		this.method_4(Class19.string_4 + "-" + Class19.string_0 + ".zip");
		this.method_3(1);
		this.method_2();
		this.method_6();
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00007C1C File Offset: 0x00005E1C
	public void method_1()
	{
		string string_ = Class19.string_4;
		string text = string_;
		uint num = Class27.smethod_0(text);
		if (num <= 977265701U)
		{
			if (num <= 268341164U)
			{
				if (num <= 201230688U)
				{
					if (num == 13713525U)
					{
						if (text == "iPad6,4")
						{
							this.method_0();
							return;
						}
					}
					else if (num != 80824001U)
					{
						if (num == 201230688U)
						{
							if (text == "iPad7,2")
							{
								this.method_0();
								return;
							}
						}
					}
					else if (text == "iPad6,8")
					{
						this.method_0();
						return;
					}
				}
				else if (num <= 240921132U)
				{
					if (num != 218008307U)
					{
						if (num == 240921132U && text == "iPad6,12")
						{
							this.method_0();
							return;
						}
					}
					else if (text == "iPad7,3")
					{
						this.method_0();
						return;
					}
				}
				else if (num != 251563545U)
				{
					if (num == 268341164U && text == "iPad7,6")
					{
						this.method_0();
						return;
					}
				}
				else if (text == "iPad7,1")
				{
					this.method_0();
					return;
				}
			}
			else if (num > 876599987U)
			{
				if (num > 926932844U)
				{
					if (num != 960488082U)
					{
						if (num == 977265701U)
						{
							if (text == "iPhone9,2")
							{
								this.method_0();
								return;
							}
						}
					}
					else if (text == "iPhone9,3")
					{
						this.method_0();
						return;
					}
				}
				else if (num != 897947417U)
				{
					if (num == 926932844U)
					{
						if (text == "iPhone9,1")
						{
							this.method_0();
							return;
						}
					}
				}
				else if (text == "iPod9,1")
				{
					this.method_0();
					return;
				}
			}
			else if (num > 301896402U)
			{
				if (num == 318674021U)
				{
					if (text == "iPad7,5")
					{
						this.method_0();
						return;
					}
				}
				else if (num == 876599987U)
				{
					if (text == "iPhone9,4")
					{
						this.method_0();
						return;
					}
				}
			}
			else if (num != 291253989U)
			{
				if (num == 301896402U)
				{
					if (text == "iPad7,4")
					{
						this.method_0();
						return;
					}
				}
			}
			else if (text == "iPad6,11")
			{
				this.method_0();
				return;
			}
		}
		else if (num <= 2320541943U)
		{
			if (num > 1134978372U)
			{
				if (num <= 2286986705U)
				{
					if (num != 2270209086U)
					{
						if (num == 2286986705U)
						{
							if (text == "iPhone10,4")
							{
								this.method_0();
								return;
							}
						}
					}
					else if (text == "iPhone10,5")
					{
						this.method_0();
						return;
					}
				}
				else if (num != 2303764324U)
				{
					if (num == 2320541943U)
					{
						if (text == "iPhone10,2")
						{
							this.method_0();
							return;
						}
					}
				}
				else if (text == "iPhone10,3")
				{
					this.method_0();
					return;
				}
			}
			else if (num > 1101423134U)
			{
				if (num != 1118200753U)
				{
					if (num == 1134978372U)
					{
						if (text == "iPad5,4")
						{
							this.method_0();
							return;
						}
					}
				}
				else if (text == "iPad5,3")
				{
					this.method_0();
					return;
				}
			}
			else if (num == 1084645515U)
			{
				if (text == "iPad5,1")
				{
					this.method_0();
					return;
				}
			}
			else if (num == 1101423134U && text == "iPad5,2")
			{
				this.method_0();
				return;
			}
		}
		else if (num > 3579376904U)
		{
			if (num > 3680042618U)
			{
				if (num != 4191237488U)
				{
					if (num == 4258347964U)
					{
						if (text == "iPad6,7")
						{
							this.method_0();
							return;
						}
					}
				}
				else if (text == "iPad6,3")
				{
					this.method_0();
					return;
				}
			}
			else if (num != 3663264999U)
			{
				if (num == 3680042618U && text == "iPhone8,2")
				{
					this.method_0();
					return;
				}
			}
			else if (text == "iPhone8,1")
			{
				this.method_0();
				return;
			}
		}
		else if (num <= 3266955512U)
		{
			if (num != 2337319562U)
			{
				if (num == 3266955512U)
				{
					if (text == "iPad7,11")
					{
						this.method_0();
						return;
					}
				}
			}
			else if (text == "iPhone10,1")
			{
				this.method_0();
				return;
			}
		}
		else if (num == 3317288369U)
		{
			if (text == "iPad7,12")
			{
				this.method_0();
				return;
			}
		}
		else if (num == 3579376904U)
		{
			if (text == "iPhone8,4")
			{
				this.method_0();
				return;
			}
		}
		MessageBox.Show("Sorry " + Class19.string_4 + " Not Supported For Now", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00008140 File Offset: 0x00006340
	public void method_2()
	{
		this.method_5(10, "==> Sending Boot Stage 1 <==");
		Class8.smethod_0(".\\files\\irecovery -f .\\files\\tmp\\iBSS.img4");
		Class8.smethod_0(".\\files\\irecovery -f .\\files\\tmp\\iBSS.img4");
		File.Delete(".\\files\\tmp\\iBSS.img4");
		this.method_3(2);
		this.method_5(30, "==> Sending Boot Stage 2 <==");
		if (!(Class19.string_9 == "8010") && !(Class19.string_9 == "8015") && !(Class19.string_9 == "8011") && !(Class19.string_9 == "8012"))
		{
			Class8.smethod_0(".\\files\\irecovery -f .\\files\\tmp\\iBEC.img4");
		}
		else
		{
			Console.WriteLine("Skip IBEC");
		}
		this.method_3(3);
		Class8.smethod_0(".\\files\\irecovery -c \"setenv oblit-inprogress 5\"");
		this.method_5(70, "==> Setting Boot Args");
		this.method_3(3);
		Class8.smethod_0(".\\files\\irecovery -c \"saveenv\"");
		this.method_3(4);
		Console.WriteLine("Done");
		Class8.smethod_0(".\\files\\irecovery -c reset");
		this.method_5(100, "Device Successfully Erase in Next Boot");
		this.method_3(6);
		this.method_6();
		Console.WriteLine("==> Sending Done done");
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00008254 File Offset: 0x00006454
	public void method_3(int int_0)
	{
		int num = int_0 * 1000;
		Thread.Sleep(num);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00008270 File Offset: 0x00006470
	public void method_4(string string_3)
	{
		try
		{
			Console.WriteLine("==>> Started Extract Bootchain.ZIP <==\n");
			this.method_5(50, "==> Extracting Bootchain <==");
			this.method_6();
			string text = Class8.string_0 + "/files/tmp/";
			using (ZipFile zipFile = ZipFile.Read(Class8.string_0 + "/data/ramdisk/" + string_3))
			{
				zipFile.Password = "iBoyRamdisk123!@#";
				zipFile.ExtractSelectedEntries("name=iBSS.img4", null, text, ExtractExistingFileAction.OverwriteSilently);
			}
			this.method_5(100, "==> Extracting Bootchain <==");
			Console.WriteLine("=>> iBSS Boot Extracted <==");
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "WARNING !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00008334 File Offset: 0x00006534
	private static void smethod_0(string string_3)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/c " + string_3);
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
		string text = process.StandardOutput.ReadToEnd();
		Console.WriteLine(text);
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00008394 File Offset: 0x00006594
	public void method_5(int int_0, string string_3 = "")
	{
		Class8.Class9 @class = new Class8.Class9();
		@class.int_0 = int_0;
		@class.frm_iBoy_0 = (FRM_iBoy)Application.OpenForms["FRM_iBoy"];
		@class.frm_iBoy_0.Invoke(new MethodInvoker(@class.method_0));
		if (Class19.bool_0)
		{
			Console.WriteLine(@class.int_0.ToString() + string_3);
		}
		@class.frm_iBoy_0.method_6(string_3);
	}

	// Token: 0x0600006E RID: 110 RVA: 0x0000840C File Offset: 0x0000660C
	public void method_6()
	{
		try
		{
			if (Directory.Exists(Class8.string_1))
			{
				Directory.Delete(Class8.string_1, true);
			}
			Thread.Sleep(1000);
			Directory.CreateDirectory(Class8.string_1);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x04000039 RID: 57
	public static string string_0 = Environment.CurrentDirectory;

	// Token: 0x0400003A RID: 58
	public static string string_1 = Class8.string_0 + "\\files\\tmp\\";

	// Token: 0x0400003B RID: 59
	public static string string_2 = string.Concat(new string[]
	{
		"https://mahapala.unnes.ac.id/hardi/",
		Class19.string_4,
		"-",
		Class19.string_0,
		".zip"
	});

	// Token: 0x02000015 RID: 21
	[CompilerGenerated]
	private sealed class Class9
	{
		// Token: 0x06000072 RID: 114 RVA: 0x000084C0 File Offset: 0x000066C0
		internal void method_0()
		{
			this.frm_iBoy_0.method_7(this.int_0, this.int_0.ToString());
		}

		// Token: 0x0400003C RID: 60
		public FRM_iBoy frm_iBoy_0;

		// Token: 0x0400003D RID: 61
		public int int_0;
	}
}
