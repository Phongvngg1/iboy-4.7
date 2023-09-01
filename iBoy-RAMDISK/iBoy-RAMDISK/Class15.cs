using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

// Token: 0x0200001E RID: 30
internal class Class15
{
	// Token: 0x060000D3 RID: 211 RVA: 0x0000D124 File Offset: 0x0000B324
	public void method_0(string string_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string_1);
		File.AppendAllText(".\\iRecovery_log.txt", stringBuilder.ToString());
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x0000D150 File Offset: 0x0000B350
	public void method_1(string string_1, string string_2, string string_3)
	{
		if (string_1 != "")
		{
			string text = "CD Resources\\tmp\\" + string_1 + "\n..\\..\\..\\files\\irecovery.exe";
			string text2 = string.Concat(new string[] { "@ECHO OFF\n", text, " ", string_2, " ", string_3 });
			File.WriteAllText("del.cmd", text2);
			try
			{
				this.process_0 = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "del.cmd",
						UseShellExecute = false,
						RedirectStandardOutput = true,
						CreateNoWindow = true
					}
				};
				this.process_0.Start();
				StreamReader standardOutput = this.process_0.StandardOutput;
				standardOutput.ReadToEnd();
				this.process_0.WaitForExit();
				goto IL_173;
			}
			catch (Exception)
			{
				goto IL_173;
			}
		}
		string text3 = ".\\files\\irecovery.exe";
		string text4 = string.Concat(new string[] { "@ECHO OFF\n", text3, " ", string_2, " ", string_3 });
		File.WriteAllText("del.cmd", text4);
		try
		{
			this.process_0 = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "del.cmd",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				}
			};
			this.process_0.Start();
			StreamReader standardOutput2 = this.process_0.StandardOutput;
			standardOutput2.ReadToEnd();
			this.process_0.WaitForExit();
		}
		catch (Exception)
		{
		}
		IL_173:
		this.method_5("del.cmd");
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x0000D2F8 File Offset: 0x0000B4F8
	public void method_2(string string_1)
	{
		this.process_0 = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = ".\\files\\curl.exe",
				Arguments = string_1,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}
		};
		this.process_0.Start();
		this.process_0.WaitForExit();
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x0000D35C File Offset: 0x0000B55C
	public void method_3(string string_1)
	{
		this.process_0 = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = ".\\files\\ex3cution3r.exe",
				Arguments = string_1,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}
		};
		this.process_0.Start();
		this.process_0.WaitForExit();
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
	public string method_4(string string_1)
	{
		string text3;
		try
		{
			string text = "@echo off\n" + string_1;
			File.WriteAllText("temp.cmd", text);
			this.process_0 = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "temp.cmd",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				}
			};
			this.process_0.Start();
			StreamReader standardOutput = this.process_0.StandardOutput;
			string text2 = standardOutput.ReadToEnd();
			this.process_0.WaitForExit();
			this.method_5("temp.cmd");
			text3 = text2;
		}
		catch
		{
			text3 = "ERROR";
		}
		return text3;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x0000D470 File Offset: 0x0000B670
	public void method_5(string string_1)
	{
		if (File.Exists(string_1))
		{
			File.Delete(string_1);
		}
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x0000D48C File Offset: 0x0000B68C
	public string method_6(string string_1)
	{
		string text = "@echo off\nfiles\\ideviceinfo.exe | files\\grep.exe -w " + string_1 + " | files\\awk.exe '{printf $NF}'";
		File.WriteAllText("Info.cmd", text);
		this.process_1 = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = "Info.cmd",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}
		};
		this.process_1.Start();
		StreamReader standardOutput = this.process_1.StandardOutput;
		string text2 = standardOutput.ReadToEnd();
		this.method_5("Info.cmd");
		return text2;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x0000D518 File Offset: 0x0000B718
	public void method_7()
	{
		if (this.method_6("UniqueDeviceID") == "")
		{
			MessageBox.Show("Device Not Detected!", "ERROR");
		}
		else if (this.method_6("SerialNumber") == "F97SF2AQFFGD")
		{
			this.method_9();
		}
		else
		{
			MessageBox.Show("You Need To Change Your Serial Number : F97SF2AQFFGD \n\nHow To Change Serial Number \n 1. Reboot Device to DFU Mode \n 2. PWNDFU Using CHECKM8 Flashdisk/MAC \n 3. Click Read DFU Mode \n 4. Click Change SN & Then Boot Purple", "SERIAL NUMBER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060000DB RID: 219 RVA: 0x0000D580 File Offset: 0x0000B780
	public void method_8()
	{
		string text = Directory.GetCurrentDirectory() + ".\\ActivationFiles\\" + this.string_0;
		try
		{
			this.method_10();
			if (!File.Exists(text))
			{
				Directory.CreateDirectory(text);
				this.method_13();
			}
			else
			{
				this.method_13();
			}
			MessageBox.Show("INFORMATION:\nFiles Generated Successfully !\nNow Enter Device in PWNDFU And Activated Your Device", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch
		{
			MessageBox.Show("Failed to generate the files, please try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060000DC RID: 220 RVA: 0x0000D604 File Offset: 0x0000B804
	public void method_9()
	{
		string text = Directory.GetCurrentDirectory() + ".\\ActivationFiles\\" + this.string_0;
		try
		{
			this.method_11();
			if (File.Exists(text))
			{
				this.method_12();
			}
			else
			{
				Directory.CreateDirectory(text);
				this.method_12();
			}
			MessageBox.Show("INFORMATION:\nFiles Generated Successfully !\nNow Enter Device in PWNDFU And Activated Your Device", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch
		{
			MessageBox.Show("Failed to generate the files, please try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060000DD RID: 221 RVA: 0x0000D688 File Offset: 0x0000B888
	public string method_10()
	{
		string text = string.Concat(new string[]
		{
			"https://idappleinfo.com/activation/activation_pwn.php?udid=",
			this.method_14("UniqueDeviceID").Trim(),
			"&sn=",
			this.method_14("SerialNumber").Trim(),
			"&ucid=",
			this.method_14("UniqueChipID").Trim()
		});
		HttpWebRequest httpWebRequest = WebRequest.CreateHttp(text);
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		httpWebRequest.Timeout = 12000;
		string text2;
		using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
		{
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
			{
				text2 = streamReader.ReadToEnd();
			}
		}
		return text2;
	}

	// Token: 0x060000DE RID: 222 RVA: 0x0000D768 File Offset: 0x0000B968
	public string method_11()
	{
		string text = string.Concat(new string[]
		{
			"https://pentaboy.my.id/ios/iOS16Act.php?udid=",
			this.method_14("UniqueDeviceID").Trim(),
			"&bv=",
			this.method_14("BuildVersion").Trim(),
			"&dc=",
			this.method_14("DeviceClass").Trim(),
			"&dv=",
			this.method_14("DeviceVariant").Trim(),
			"&mn=",
			this.method_14("ModelNumber").Trim(),
			"&ot=",
			this.method_14("OSType").Trim(),
			"&pt=",
			this.method_14("ProductType").Trim(),
			"&pv=",
			this.method_14("ProductVersion").Trim(),
			"&rmn=",
			this.method_14("RegulatoryModelNumber").Trim(),
			"&ucid=",
			this.method_14("UniqueChipID").Trim()
		});
		HttpWebRequest httpWebRequest = WebRequest.CreateHttp(text);
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		httpWebRequest.Timeout = 12000;
		string text2;
		using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
		{
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
			{
				text2 = streamReader.ReadToEnd();
			}
		}
		return text2;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x0000D910 File Offset: 0x0000BB10
	private void method_12()
	{
		try
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadFile("https://pentaboy.my.id/ios/" + this.method_14("UniqueDeviceID").Trim() + "/activation_record.plist", Directory.GetCurrentDirectory() + ".\\ActivationFiles\\" + this.string_0 + "\\activation_record.plist");
				webClient.DownloadFile("https://pentaboy.my.id/ios/" + this.method_14("UniqueDeviceID").Trim() + "/IC-Info.sisv", Directory.GetCurrentDirectory() + ".\\ActivationFiles\\" + this.string_0 + "\\IC-Info.sisv");
				webClient.DownloadFile("https://pentaboy.my.id/ios/" + this.method_14("UniqueDeviceID").Trim() + "/Wildcard.der", Directory.GetCurrentDirectory() + ".\\ActivationFiles\\" + this.string_0 + "\\Wildcard.der");
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + " 404 Result = files No exist in the Server", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x0000DA2C File Offset: 0x0000BC2C
	private void method_13()
	{
		try
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadFile("https://idappleinfo.com/activation/Devices/activation_records/" + Class19.string_7 + "/activation_record.plist", Directory.GetCurrentDirectory() + ".\\ActivationFiles\\" + this.string_0 + "\\activation_record.plist");
				webClient.DownloadFile("https://idappleinfo.com/activation/Devices/activation_records/" + Class19.string_7 + "/IC-Info.sisv", Directory.GetCurrentDirectory() + ".\\ActivationFiles\\" + this.string_0 + "\\IC-Info.sisv");
				webClient.DownloadFile("https://idappleinfo.com/activation/Devices/activation_records/" + Class19.string_7 + "/Wildcard.der", Directory.GetCurrentDirectory() + ".\\ActivationFiles\\" + this.string_0 + "\\Wildcard.der");
				webClient.DownloadFile("https://idappleinfo.com/activation/Devices/activation_records/" + Class19.string_7 + "/com.apple.commcenter.device_specific_nobackup.plist", Directory.GetCurrentDirectory() + ".\\ActivationFiles\\" + this.string_0 + "\\com.apple.commcenter.device_specific_nobackup.plist");
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + " 404 Result = files No exist in the Server", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x0000DB5C File Offset: 0x0000BD5C
	public string method_14(string string_1)
	{
		string text = "@echo off\nfiles\\ideviceinfo.exe -k " + string_1;
		File.WriteAllText(".\\files\\swp\\Info.cmd", text);
		Process process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = ".\\files\\swp\\Info.cmd",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}
		};
		process.Start();
		StreamReader standardOutput = process.StandardOutput;
		string text2 = standardOutput.ReadToEnd();
		text2.Replace("\n", "");
		process.WaitForExit();
		return text2;
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x0000DBE4 File Offset: 0x0000BDE4
	public string method_15()
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
		if (text == "AUTHORIZED")
		{
			Class20 @class = new Class20();
			@class.method_6();
		}
		if (text == "NOT_AUTHORIZED")
		{
			MessageBox.Show("ECID Not Register, Please Contact The Admin And Register Your Serial ECID");
		}
		return text;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x0000DCAC File Offset: 0x0000BEAC
	public void method_16(int int_0, string string_1 = "")
	{
		Class15.Class16 @class = new Class15.Class16();
		@class.int_0 = int_0;
		@class.frm_iBoy_0 = (FRM_iBoy)Application.OpenForms["FRM_iBoy"];
		@class.frm_iBoy_0.Invoke(new MethodInvoker(@class.method_0));
		if (Class19.bool_0)
		{
			Console.WriteLine(@class.int_0.ToString() + string_1);
		}
		@class.frm_iBoy_0.method_6(string_1);
	}

	// Token: 0x04000093 RID: 147
	private Process process_0 = new Process();

	// Token: 0x04000094 RID: 148
	public Process process_1 = new Process();

	// Token: 0x04000095 RID: 149
	public string string_0 = File.ReadAllText("ssl\\udid.pl");

	// Token: 0x0200001F RID: 31
	[CompilerGenerated]
	private sealed class Class16
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x0000DD60 File Offset: 0x0000BF60
		internal void method_0()
		{
			this.frm_iBoy_0.method_7(this.int_0, this.int_0.ToString());
		}

		// Token: 0x04000096 RID: 150
		public FRM_iBoy frm_iBoy_0;

		// Token: 0x04000097 RID: 151
		public int int_0;
	}
}
