using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Ionic.Zip;

// Token: 0x02000020 RID: 32
internal class Class17
{
	// Token: 0x060000E7 RID: 231 RVA: 0x0000DD8C File Offset: 0x0000BF8C
	public void method_0()
	{
		string string_ = Class19.string_4;
		string text = string_;
		uint num = Class27.smethod_0(text);
		if (num <= 1134978372U)
		{
			if (num <= 318674021U)
			{
				if (num > 240921132U)
				{
					if (num != 268341164U)
					{
						if (num != 291253989U)
						{
							if (num == 318674021U)
							{
								if (text == "iPad7,5")
								{
									this.method_15();
									this.method_13(1);
									this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
									this.method_13(1);
									this.method_1();
									return;
								}
							}
						}
						else if (text == "iPad6,11")
						{
							this.method_15();
							this.method_13(1);
							this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
							this.method_13(1);
							this.method_2();
							return;
						}
					}
					else if (text == "iPad7,6")
					{
						this.method_15();
						this.method_13(1);
						this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
						this.method_13(1);
						this.method_1();
						return;
					}
				}
				else if (num == 13713525U)
				{
					if (text == "iPad6,4")
					{
						this.method_15();
						this.method_13(1);
						this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
						this.method_13(1);
						this.method_2();
						return;
					}
				}
				else if (num == 240921132U)
				{
					if (text == "iPad6,12")
					{
						this.method_15();
						this.method_13(1);
						this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
						this.method_13(1);
						this.method_2();
						return;
					}
				}
			}
			else if (num > 960488082U)
			{
				if (num != 977265701U)
				{
					if (num != 1118200753U)
					{
						if (num == 1134978372U && text == "iPad5,4")
						{
							this.method_15();
							this.method_13(1);
							this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
							this.method_13(1);
							this.method_2();
							return;
						}
					}
					else if (text == "iPad5,3")
					{
						this.method_15();
						this.method_13(1);
						this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
						this.method_13(1);
						this.method_2();
						return;
					}
				}
				else if (text == "iPhone9,2")
				{
					this.method_15();
					this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
					this.method_13(1);
					this.method_1();
					this.method_13(1);
					return;
				}
			}
			else if (num != 876599987U)
			{
				if (num == 926932844U)
				{
					if (text == "iPhone9,1")
					{
						this.method_15();
						this.method_13(1);
						this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
						this.method_13(1);
						this.method_1();
						this.method_13(1);
						return;
					}
				}
				else if (num == 960488082U && text == "iPhone9,3")
				{
					this.method_15();
					this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
					this.method_13(1);
					this.method_1();
					this.method_13(1);
					return;
				}
			}
			else if (text == "iPhone9,4")
			{
				this.method_15();
				this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
				this.method_13(1);
				this.method_1();
				this.method_13(1);
				return;
			}
		}
		else if (num > 2337319562U)
		{
			if (num <= 3579376904U)
			{
				if (num == 3266955512U)
				{
					if (text == "iPad7,11")
					{
						this.method_15();
						this.method_13(1);
						this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
						this.method_13(1);
						this.method_1();
						return;
					}
				}
				else if (num != 3317288369U)
				{
					if (num == 3579376904U)
					{
						if (text == "iPhone8,4")
						{
							MessageBox.Show("Device Type : " + Class19.string_4 + " Not Supported Without DCSD!", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
					}
				}
				else if (text == "iPad7,12")
				{
					this.method_15();
					this.method_13(1);
					this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
					this.method_13(1);
					this.method_1();
					return;
				}
			}
			else if (num != 3663264999U)
			{
				if (num == 3680042618U)
				{
					if (text == "iPhone8,2")
					{
						this.method_15();
						this.method_13(1);
						this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
						this.method_13(1);
						this.method_2();
						this.method_13(1);
						return;
					}
				}
				else if (num == 4191237488U && text == "iPad6,3")
				{
					this.method_15();
					this.method_13(1);
					this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
					this.method_13(1);
					this.method_2();
					return;
				}
			}
			else if (text == "iPhone8,1")
			{
				this.method_15();
				this.method_13(1);
				this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
				this.method_13(1);
				this.method_2();
				this.method_13(1);
				return;
			}
		}
		else if (num <= 2286986705U)
		{
			if (num == 2253431467U)
			{
				if (text == "iPhone10,6")
				{
					this.method_15();
					this.method_13(1);
					this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
					this.method_13(1);
					this.method_1();
					return;
				}
			}
			else if (num == 2270209086U)
			{
				if (text == "iPhone10,5")
				{
					this.method_15();
					this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
					this.method_13(1);
					this.method_1();
					this.method_13(1);
					return;
				}
			}
			else if (num == 2286986705U)
			{
				if (text == "iPhone10,4")
				{
					this.method_15();
					this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
					this.method_13(1);
					this.method_1();
					this.method_13(1);
					return;
				}
			}
		}
		else if (num == 2303764324U)
		{
			if (text == "iPhone10,3")
			{
				this.method_15();
				this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
				this.method_13(1);
				this.method_1();
				this.method_13(1);
				return;
			}
		}
		else if (num != 2320541943U)
		{
			if (num == 2337319562U && text == "iPhone10,1")
			{
				this.method_15();
				this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
				this.method_13(1);
				this.method_1();
				this.method_13(1);
				return;
			}
		}
		else if (text == "iPhone10,2")
		{
			this.method_15();
			this.method_12(Class19.string_4 + "-" + Class19.string_0 + ".zip");
			this.method_13(1);
			this.method_1();
			this.method_13(1);
			return;
		}
		MessageBox.Show("Device Type : " + Class19.string_4 + " Not Supported!\n Please Use Magiccfg !!", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x0000E5EC File Offset: 0x0000C7EC
	public void method_1()
	{
		this.method_14(10, "==> Sending Boot Stage 1 <==");
		Class17.smethod_0(".\\files\\irecovery -f .\\files\\tmp\\iBoot.img4");
		this.method_13(1);
		this.method_14(30, "==> Sending Boot Stage 2 <==");
		Class17.smethod_0(".\\files\\irecovery -f .\\files\\tmp\\iBoot.img4");
		File.Delete(".\\files\\tmp\\iBoot.img4");
		this.method_13(3);
		this.method_14(50, "==> Sending Boot Stage 3 <==");
		Class17.smethod_0(".\\files\\irecovery -f .\\files\\tmp\\diag.img4");
		File.Delete(".\\files\\tmp\\iBoot.img4");
		this.method_13(3);
		Class17.smethod_0(".\\files\\irecovery -c \"setenv boot-args usbserial=enabled\"");
		this.method_14(70, "==> Setting Boot Args");
		this.method_13(3);
		Class17.smethod_0(".\\files\\irecovery -c \"saveenv\"");
		this.method_13(4);
		Console.WriteLine("Done");
		Class17.smethod_0(".\\files\\irecovery -c go");
		this.method_14(90, "==> Go Purple");
		this.method_13(6);
		this.method_15();
		Console.WriteLine("==> purple done");
		this.method_11();
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
	public void method_2()
	{
		this.method_14(10, "==> Sending Boot Stage 1 <==");
		Class17.smethod_0(".\\files\\irecovery -f .\\files\\tmp\\iBSS.img4");
		Class17.smethod_0(".\\files\\irecovery -f .\\files\\tmp\\iBSS.img4");
		this.method_13(1);
		this.method_14(30, "==> Sending Boot Stage 2 <==");
		Class17.smethod_0(".\\files\\irecovery -f .\\files\\tmp\\iBEC.img4");
		File.Delete(".\\files\\tmp\\iBoot.img4");
		this.method_13(3);
		this.method_14(50, "==> Sending Boot Stage 3 <==");
		Class17.smethod_0(".\\files\\irecovery -f .\\files\\tmp\\diag.img4");
		File.Delete(".\\files\\tmp\\iBoot.img4");
		this.method_13(3);
		Class17.smethod_0(".\\files\\irecovery -c \"clearenv boot-args\"");
		this.method_14(70, "==> Setting Boot Args");
		this.method_13(3);
		Class17.smethod_0(".\\files\\irecovery -c \"clearenv 1\"");
		this.method_13(4);
		Console.WriteLine("Done");
		Class17.smethod_0(".\\files\\irecovery -c go");
		this.method_14(90, "==> Go Purple");
		this.method_13(6);
		this.method_15();
		Console.WriteLine("==> purple done");
		this.method_11();
	}

	// Token: 0x060000EA RID: 234 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
	public void method_3()
	{
		string string_ = Class19.string_4;
		string text = string_;
		uint num = Class27.smethod_0(text);
		if (num <= 1101423134U)
		{
			if (num <= 291253989U)
			{
				if (num <= 218008307U)
				{
					if (num > 80824001U)
					{
						if (num == 201230688U)
						{
							if (text == "iPad7,2")
							{
								this.method_4();
								return;
							}
						}
						else if (num == 218008307U && text == "iPad7,3")
						{
							this.method_4();
							return;
						}
					}
					else if (num != 13713525U)
					{
						if (num == 80824001U)
						{
							if (text == "iPad6,8")
							{
								this.method_4();
								return;
							}
						}
					}
					else if (text == "iPad6,4")
					{
						this.method_4();
						return;
					}
				}
				else if (num > 251563545U)
				{
					if (num == 268341164U)
					{
						if (text == "iPad7,6")
						{
							this.method_4();
							return;
						}
					}
					else if (num == 291253989U)
					{
						if (text == "iPad6,11")
						{
							this.method_4();
							return;
						}
					}
				}
				else if (num == 240921132U)
				{
					if (text == "iPad6,12")
					{
						this.method_4();
						return;
					}
				}
				else if (num == 251563545U)
				{
					if (text == "iPad7,1")
					{
						this.method_4();
						return;
					}
				}
			}
			else if (num > 897947417U)
			{
				if (num <= 960488082U)
				{
					if (num == 926932844U)
					{
						if (text == "iPhone9,1")
						{
							this.method_4();
							return;
						}
					}
					else if (num == 960488082U)
					{
						if (text == "iPhone9,3")
						{
							this.method_4();
							return;
						}
					}
				}
				else if (num == 977265701U)
				{
					if (text == "iPhone9,2")
					{
						this.method_4();
						return;
					}
				}
				else if (num == 1084645515U)
				{
					if (text == "iPad5,1")
					{
						this.method_4();
						return;
					}
				}
				else if (num == 1101423134U && text == "iPad5,2")
				{
					this.method_4();
					return;
				}
			}
			else if (num > 318674021U)
			{
				if (num != 876599987U)
				{
					if (num == 897947417U && text == "iPod9,1")
					{
						this.method_4();
						return;
					}
				}
				else if (text == "iPhone9,4")
				{
					this.method_4();
					return;
				}
			}
			else if (num != 301896402U)
			{
				if (num == 318674021U)
				{
					if (text == "iPad7,5")
					{
						this.method_4();
						return;
					}
				}
			}
			else if (text == "iPad7,4")
			{
				this.method_4();
				return;
			}
		}
		else if (num <= 2303764324U)
		{
			if (num <= 1760014814U)
			{
				if (num <= 1134978372U)
				{
					if (num != 1118200753U)
					{
						if (num == 1134978372U && text == "iPad5,4")
						{
							this.method_4();
							return;
						}
					}
					else if (text == "iPad5,3")
					{
						this.method_4();
						return;
					}
				}
				else if (num == 1743237195U)
				{
					if (text == "iPhone7,2")
					{
						this.method_4();
						return;
					}
				}
				else if (num == 1760014814U && text == "iPhone7,1")
				{
					this.method_4();
					return;
				}
			}
			else if (num > 2270209086U)
			{
				if (num == 2286986705U)
				{
					if (text == "iPhone10,4")
					{
						this.method_4();
						return;
					}
				}
				else if (num == 2303764324U && text == "iPhone10,3")
				{
					this.method_4();
					return;
				}
			}
			else if (num != 2253431467U)
			{
				if (num == 2270209086U && text == "iPhone10,5")
				{
					this.method_4();
					return;
				}
			}
			else if (text == "iPhone10,6")
			{
				this.method_4();
				return;
			}
		}
		else if (num > 3317288369U)
		{
			if (num <= 3663264999U)
			{
				if (num != 3579376904U)
				{
					if (num == 3663264999U)
					{
						if (text == "iPhone8,1")
						{
							this.method_4();
							return;
						}
					}
				}
				else if (text == "iPhone8,4")
				{
					this.method_4();
					return;
				}
			}
			else if (num != 3680042618U)
			{
				if (num == 4191237488U)
				{
					if (text == "iPad6,3")
					{
						this.method_4();
						return;
					}
				}
				else if (num == 4258347964U && text == "iPad6,7")
				{
					this.method_4();
					return;
				}
			}
			else if (text == "iPhone8,2")
			{
				this.method_4();
				return;
			}
		}
		else if (num > 2337319562U)
		{
			if (num != 3266955512U)
			{
				if (num == 3317288369U)
				{
					if (text == "iPad7,12")
					{
						this.method_4();
						return;
					}
				}
			}
			else if (text == "iPad7,11")
			{
				this.method_4();
				return;
			}
		}
		else if (num != 2320541943U)
		{
			if (num == 2337319562U && text == "iPhone10,1")
			{
				this.method_4();
				return;
			}
		}
		else if (text == "iPhone10,2")
		{
			this.method_4();
			return;
		}
		MessageBox.Show("Device Type : " + Class19.string_4 + " Not Supported!", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	// Token: 0x060000EB RID: 235 RVA: 0x0000ED5C File Offset: 0x0000CF5C
	public void method_4()
	{
		this.method_15();
		this.method_13(1);
		if (!File.Exists(string.Concat(new string[]
		{
			".\\Data\\ramdisk\\",
			Class19.string_4,
			"-",
			Class19.string_0,
			".zip"
		})))
		{
			MessageBox.Show(string.Concat(new string[]
			{
				"Ramdisk Not Found Please Download ",
				Class19.string_4,
				"-",
				Class19.string_0,
				".zip\nAnd put files to ",
				Class17.string_0,
				"/Data/ramdisk/"
			}), "WARNING !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Console.WriteLine("File Notfound then Download");
		}
		else
		{
			Console.WriteLine("Ada File");
			this.method_9(Class19.string_4 + "-" + Class19.string_0 + ".zip");
			this.method_13(1);
			this.method_8();
		}
		this.method_15();
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0000EE4C File Offset: 0x0000D04C
	public void method_5()
	{
		string string_ = Class19.string_4;
		string text = string_;
		uint num = Class27.smethod_0(text);
		if (num <= 318674021U)
		{
			if (num <= 240921132U)
			{
				if (num > 80824001U)
				{
					if (num == 201230688U)
					{
						if (text == "iPad7,2")
						{
							this.method_6();
							return;
						}
					}
					else if (num != 218008307U)
					{
						if (num == 240921132U)
						{
							if (text == "iPad6,12")
							{
								this.method_6();
								return;
							}
						}
					}
					else if (text == "iPad7,3")
					{
						this.method_6();
						return;
					}
				}
				else if (num == 13713525U)
				{
					if (text == "iPad6,4")
					{
						this.method_6();
						return;
					}
				}
				else if (num == 80824001U)
				{
					if (text == "iPad6,8")
					{
						this.method_6();
						return;
					}
				}
			}
			else if (num > 268341164U)
			{
				if (num == 291253989U)
				{
					if (text == "iPad6,11")
					{
						this.method_6();
						return;
					}
				}
				else if (num != 301896402U)
				{
					if (num == 318674021U)
					{
						if (text == "iPad7,5")
						{
							this.method_6();
							return;
						}
					}
				}
				else if (text == "iPad7,4")
				{
					this.method_6();
					return;
				}
			}
			else if (num == 251563545U)
			{
				if (text == "iPad7,1")
				{
					this.method_6();
					return;
				}
			}
			else if (num == 268341164U)
			{
				if (text == "iPad7,6")
				{
					this.method_6();
					return;
				}
			}
		}
		else if (num <= 2320541943U)
		{
			if (num <= 2270209086U)
			{
				if (num != 2253431467U)
				{
					if (num == 2270209086U)
					{
						if (text == "iPhone10,5")
						{
							this.method_6();
							return;
						}
					}
				}
				else if (text == "iPhone10,6")
				{
					this.method_6();
					return;
				}
			}
			else if (num != 2286986705U)
			{
				if (num != 2303764324U)
				{
					if (num == 2320541943U && text == "iPhone10,2")
					{
						this.method_6();
						return;
					}
				}
				else if (text == "iPhone10,3")
				{
					this.method_6();
					return;
				}
			}
			else if (text == "iPhone10,4")
			{
				this.method_6();
				return;
			}
		}
		else if (num > 3266955512U)
		{
			if (num != 3317288369U)
			{
				if (num != 4191237488U)
				{
					if (num == 4258347964U && text == "iPad6,7")
					{
						this.method_6();
						return;
					}
				}
				else if (text == "iPad6,3")
				{
					this.method_6();
					return;
				}
			}
			else if (text == "iPad7,12")
			{
				this.method_6();
				return;
			}
		}
		else if (num != 2337319562U)
		{
			if (num == 3266955512U)
			{
				if (text == "iPad7,11")
				{
					this.method_6();
					return;
				}
			}
		}
		else if (text == "iPhone10,1")
		{
			this.method_6();
			return;
		}
		MessageBox.Show("Device not supported!!", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	// Token: 0x060000ED RID: 237 RVA: 0x0000F178 File Offset: 0x0000D378
	public void method_6()
	{
		this.method_15();
		this.method_13(1);
		if (File.Exists(string.Concat(new string[]
		{
			".\\Data\\ramdisk\\",
			Class19.string_4,
			"-",
			Class19.string_0,
			"-16.x.zip"
		})))
		{
			Console.WriteLine("Ada File");
			this.method_9(Class19.string_4 + "-" + Class19.string_0 + "-16.x.zip");
			this.method_13(1);
			this.method_7();
		}
		else
		{
			MessageBox.Show(string.Concat(new string[]
			{
				"Ramdisk Not Found Please Download ",
				Class19.string_4,
				"-",
				Class19.string_0,
				"-16.x.zip"
			}), "WARNING !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Console.WriteLine("File Notfound then Download");
		}
		this.method_15();
	}

	// Token: 0x060000EE RID: 238 RVA: 0x0000F258 File Offset: 0x0000D458
	public void method_7()
	{
		try
		{
			this.method_14(10, "Starting Boot Patch");
			Class17.smethod_0(string.Concat(new string[]
			{
				".\\files\\irecovery -f ",
				Class17.string_2,
				".\\files\\shsh\\",
				Class19.string_9,
				".shsh"
			}));
			this.method_14(20, "Sending iBSS");
			Class17.smethod_0(string.Concat(new string[]
			{
				".\\files\\irecovery -f ",
				Class17.string_2,
				".\\files\\shsh\\",
				Class19.string_9,
				".shsh"
			}));
			File.Delete(Class17.string_2 + ".\\files\\tmp\\shsh.shsh");
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\iBSS.img4");
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\iBSS.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\iBSS.img4");
			Class17.smethod_0(".\\files\\irecovery -f .\\files\\tmp\\iBEC.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\iBEC.img4");
			this.method_13(3);
			if (!(Class19.string_9 == "0x8010") && !(Class19.string_9 == "0x8015") && !(Class19.string_9 == "0x8011") && !(Class19.string_9 == "0x8012"))
			{
				Console.WriteLine("Skip Loader");
			}
			else
			{
				Class17.smethod_0(".\\files\\irecovery -c go");
			}
			this.method_14(30, "Sending Logo");
			Class17.smethod_0(".\\files\\irecovery -f .\\files\\shsh\\" + Class19.string_9);
			File.Delete(Class17.string_2 + ".\\files\\tmp\\logo.img4");
			Class17.smethod_0(".\\files\\irecovery  -c \"setpicture 0\"");
			Class17.smethod_0(".\\files\\irecovery  -c \"bgcolor 0 0 0\"");
			this.method_14(40, "Sending DeviceTree");
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\devicetree.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\devicetree.img4");
			Class17.smethod_0(".\\files\\irecovery -c devicetree");
			this.method_13(2);
			this.method_14(65, "Sending Ramdisk");
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\ramdisk.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\ramdisk.img4");
			Class17.smethod_0(".\\files\\irecovery -c ramdisk");
			this.method_13(2);
			this.method_14(65, "Sending SEP");
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\sep-fw.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\sep-fw.img4");
			Class17.smethod_0(".\\files\\irecovery -c rsepfirmware");
			this.method_13(2);
			this.method_14(75, "Sending Trustcache");
			this.method_13(3);
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\trustcache.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\trustcache.img4");
			Class17.smethod_0(".\\files\\irecovery -c firmware");
			this.method_13(2);
			this.method_14(90, "Sending Kernel");
			this.method_13(3);
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\kernelcache.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\kernelcache.img4");
			Class17.smethod_0(".\\files\\irecovery -c bootx");
			this.method_15();
			this.method_13(5);
			this.method_10();
		}
		catch (Exception ex)
		{
			this.method_15();
			MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
	public void method_8()
	{
		try
		{
			this.method_14(10, "Starting Boot Patch");
			this.method_14(20, "Sending iBSS");
			Class17.smethod_0(".\\files\\irecovery -f .\\files\\shsh\\" + Class19.string_9 + ".shsh");
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\iBSS.img4");
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\iBSS.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\iBSS.img4");
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\iBEC.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\iBEC.img4");
			this.method_13(3);
			this.method_14(30, "Sending Logo");
			Class17.smethod_0(".\\files\\irecovery -f .\\files\\shsh\\" + Class19.string_9);
			File.Delete(Class17.string_2 + ".\\files\\tmp\\logo.img4");
			Class17.smethod_0(".\\files\\irecovery  -c \"setpicture 0\"");
			Class17.smethod_0(".\\files\\irecovery  -c \"bgcolor 0 0 0\"");
			this.method_14(50, "Sending Ramdisk");
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\ramdisk.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\ramdisk.img4");
			Class17.smethod_0(".\\files\\irecovery -c ramdisk");
			this.method_13(2);
			this.method_14(65, "Sending DeviceTree");
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\devicetree.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\devicetree.img4");
			Class17.smethod_0(".\\files\\irecovery -c devicetree");
			this.method_13(2);
			this.method_14(75, "Sending Trustcache");
			this.method_13(3);
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\trustcache.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\trustcache.img4");
			Class17.smethod_0(".\\files\\irecovery -c firmware");
			this.method_13(2);
			this.method_14(90, "Sending Kernel");
			this.method_13(3);
			Class17.smethod_0(".\\files\\irecovery -f " + Class17.string_2 + ".\\files\\tmp\\kernelcache.img4");
			File.Delete(Class17.string_2 + ".\\files\\tmp\\kernelcache.img4");
			Class17.smethod_0(".\\files\\irecovery -c bootx");
			this.method_15();
			this.method_13(5);
			this.method_10();
		}
		catch (Exception ex)
		{
			this.method_15();
			MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0000F868 File Offset: 0x0000DA68
	public void method_9(string string_4)
	{
		try
		{
			this.method_14(50, "==> Extracting Bootchain <==");
			this.method_15();
			string text = Class17.string_2 + "\\files\\tmp\\";
			using (ZipFile zipFile = ZipFile.Read(Class17.string_0 + "/data/ramdisk/" + string_4))
			{
				zipFile.Password = "iBoyRamdisk123!@#";
				foreach (ZipEntry zipEntry in zipFile)
				{
					zipEntry.Extract(text, ExtractExistingFileAction.OverwriteSilently);
				}
			}
			this.method_14(100, "==> Ramdisk Successfull Extracted <==");
			Console.WriteLine("=>> Ramdisk Succeccfull Extracted <==");
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "WARNING !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x0000F954 File Offset: 0x0000DB54
	public void method_10()
	{
		try
		{
			using (Process process = new Process())
			{
				process.StartInfo.FileName = Class17.string_0 + ".\\files\\irecovery.exe";
				process.StartInfo.Arguments = "-m";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				StreamReader standardOutput = process.StandardOutput;
				string text = standardOutput.ReadToEnd();
				process.WaitForExit();
				Class19.string_10 = text;
				bool flag = text.Contains("Recovery");
				bool flag2 = text.Contains("DFU");
				bool flag3 = text.Contains("ERROR:");
				if (!flag)
				{
					if (flag2)
					{
						this.method_14(99, "Device in DFU MODE, Boot Ramdisk FAIL !");
						MessageBox.Show("Device Not boot to SSH RAMDISK, Put it back in IPWNDFU, Check Your Drivers and Try Again!", "iBoy Ramdisk ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else if (flag3)
					{
						this.method_14(100, "DEVICE BOOTED SUCCESSFULLY!");
						MessageBox.Show("Your Device Booted Successfully! Now Click on Connect SSH", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						this.method_14(100, "DEVICE BOOTED SUCCESSFULLY!");
						MessageBox.Show("Your Device Booted Successfully! Now Click on Connect SSH", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else
				{
					this.method_14(99, "Device in RECOVERY MODE, Boot Ramdisk FAIL !");
					MessageBox.Show("Device Not boot to SSH RAMDISK, Put it back in IPWNDFU, Check Your Drivers and Try Again!", "iBoy Ramdisk ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}
		catch (Exception ex)
		{
			this.method_15();
			MessageBox.Show(ex.Message);
		}
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
	public void method_11()
	{
		try
		{
			using (Process process = new Process())
			{
				process.StartInfo.FileName = Class17.string_0 + ".\\files\\irecovery.exe";
				process.StartInfo.Arguments = "-m";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				StreamReader standardOutput = process.StandardOutput;
				string text = standardOutput.ReadToEnd();
				process.WaitForExit();
				Class19.string_10 = text;
				bool flag = text.Contains("Recovery");
				bool flag2 = text.Contains("DFU");
				bool flag3 = text.Contains("ERROR:");
				if (flag)
				{
					this.method_14(99, "ERROR DEVICE NOT BOOTED BAD DRIVERS!");
					MessageBox.Show("Device Not boot to PURPLE MODE, Put it back in IPWNDFU, Check Your Drivers and Try Again!", "iBoy Ramdisk ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (flag2)
				{
					this.method_14(99, "ERROR DEVICE NOT BOOTED");
					MessageBox.Show("Device Not boot to PURPLE MODE, Put it back in IPWNDFU, Check Your Drivers and Try Again!", "iBoy Ramdisk ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (flag3)
				{
					this.method_14(100, "DEVICE BOOTED SUCCESSFULLY!");
					MessageBox.Show("Your Device Booted Successfully! Now Check Install DIAG CDC Driver From Device Manager \n Some Device didn't show Purple Screen, but Successfully in Diag Mode \niPhone 6s - 6plus need DCSD Cable", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					this.method_14(100, "DEVICE BOOTED SUCCESSFULLY!");
					MessageBox.Show("Your Device Booted Successfully! Now Check Install DIAG CDC Driver From Device Manager\n Some Device didn't show Purple Screen, but Successfully in Diag Mode \niPhone 6s - 6plus need DCSD Cable", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}
		catch (Exception ex)
		{
			this.method_15();
			MessageBox.Show(ex.Message);
		}
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x0000FC94 File Offset: 0x0000DE94
	public void method_12(string string_4)
	{
		try
		{
			Console.WriteLine("==>> Started Extract Bootchain.ZIP <==\n");
			this.method_14(50, "==> Extracting Bootchain <==");
			this.method_15();
			string text = Class17.string_0 + "/files/tmp/";
			using (ZipFile zipFile = ZipFile.Read(Class17.string_0 + "/data/purple/" + string_4))
			{
				zipFile.Password = "iBoyRamdisk123!@#";
				foreach (ZipEntry zipEntry in zipFile)
				{
					zipEntry.Extract(text, ExtractExistingFileAction.OverwriteSilently);
				}
			}
			this.method_14(100, "==> Extracting Purple <==");
			Console.WriteLine("=>> Purple Boot Extracted <==");
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "WARNING !", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00008254 File Offset: 0x00006454
	public void method_13(int int_0)
	{
		int num = int_0 * 1000;
		Thread.Sleep(num);
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00008334 File Offset: 0x00006534
	private static void smethod_0(string string_4)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/c " + string_4);
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
		string text = process.StandardOutput.ReadToEnd();
		Console.WriteLine(text);
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x0000FD88 File Offset: 0x0000DF88
	public void method_14(int int_0, string string_4 = "")
	{
		Class17.Class18 @class = new Class17.Class18();
		@class.int_0 = int_0;
		@class.frm_iBoy_0 = (FRM_iBoy)Application.OpenForms["FRM_iBoy"];
		@class.frm_iBoy_0.Invoke(new MethodInvoker(@class.method_0));
		if (Class19.bool_0)
		{
			Console.WriteLine(@class.int_0.ToString() + string_4);
		}
		@class.frm_iBoy_0.method_6(string_4);
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x0000FE00 File Offset: 0x0000E000
	public void method_15()
	{
		try
		{
			if (Directory.Exists(Class17.string_1))
			{
				Directory.Delete(Class17.string_1, true);
			}
			Thread.Sleep(1000);
			Directory.CreateDirectory(Class17.string_1);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x0000FE50 File Offset: 0x0000E050
	public void method_16()
	{
		try
		{
			if (Directory.Exists(Class17.string_2))
			{
				Directory.Delete(Class17.string_2, true);
			}
			Thread.Sleep(1000);
			Directory.CreateDirectory(Class17.string_2);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
	public void method_17(string string_4, string string_5)
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += this.method_18;
			webClient.Headers.Add("User-Agent: Other");
			webClient.DownloadFileAsync(new Uri(string_4), Class17.string_0 + "/Data/ramdisk/" + string_5);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + " 404 Result = RamDisk No exist in the Server", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060000FA RID: 250 RVA: 0x0000FF28 File Offset: 0x0000E128
	public void method_18(object sender, DownloadProgressChangedEventArgs e)
	{
		double num = double.Parse(e.BytesReceived.ToString());
		double num2 = double.Parse(e.TotalBytesToReceive.ToString());
		double num3 = num / num2 * 100.0;
		this.method_14(int.Parse(Math.Truncate(num3).ToString()), "Downloaded Ramdisk Data : " + string.Format(" {0} MB / {1} MB", ((double)e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), ((double)e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00")));
	}

	// Token: 0x04000098 RID: 152
	public static string string_0 = Environment.CurrentDirectory;

	// Token: 0x04000099 RID: 153
	public static string string_1 = Class17.string_0 + "\\files\\swp\\";

	// Token: 0x0400009A RID: 154
	public static string string_2 = "C:\\Windows\\apppatch\\Apple\\";

	// Token: 0x0400009B RID: 155
	public static string string_3 = string.Concat(new string[]
	{
		"https://mahapala.unnes.ac.id/hardi/",
		Class19.string_4,
		"-",
		Class19.string_0,
		".zip"
	});

	// Token: 0x02000021 RID: 33
	[CompilerGenerated]
	private sealed class Class18
	{
		// Token: 0x060000FE RID: 254 RVA: 0x0001005C File Offset: 0x0000E25C
		internal void method_0()
		{
			this.frm_iBoy_0.method_7(this.int_0, this.int_0.ToString());
		}

		// Token: 0x0400009C RID: 156
		public FRM_iBoy frm_iBoy_0;

		// Token: 0x0400009D RID: 157
		public int int_0;
	}
}
