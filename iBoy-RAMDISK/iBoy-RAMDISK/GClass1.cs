using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

// Token: 0x02000011 RID: 17
public class GClass1
{
	// Token: 0x06000055 RID: 85 RVA: 0x000075E4 File Offset: 0x000057E4
	private string method_0(string string_1, string string_2, bool bool_0 = false)
	{
		string text;
		if (bool_0)
		{
			text = string.Format("uninstall --inf=\"{0}\"", string_2);
		}
		else
		{
			text = string.Format("install --inf=\"{0}\"", string_2);
		}
		Process process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				UseShellExecute = false,
				CreateNoWindow = true,
				FileName = string_1,
				Verb = "runas",
				Arguments = text,
				WorkingDirectory = Path.GetDirectoryName(string_1),
				RedirectStandardOutput = true,
				RedirectStandardError = true
			}
		};
		process.Start();
		return process.StandardOutput.ReadToEnd() + process.StandardError.ReadToEnd();
	}

	// Token: 0x06000056 RID: 86 RVA: 0x0000768C File Offset: 0x0000588C
	private void method_1(bool bool_0 = false, bool bool_1 = false)
	{
		try
		{
			if (bool_0)
			{
				this.method_9("irecovery");
			}
			if (bool_1)
			{
				this.method_9("gaster");
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000076CC File Offset: 0x000058CC
	public bool method_2(string string_1 = "-q")
	{
		this.method_1(true, false);
		string text = this.method_8(this.method_10(), string_1);
		if (string.IsNullOrEmpty(text))
		{
			throw new Exception("Not Found .");
		}
		if (text.Contains("Unable to connect to device"))
		{
			throw new Exception("Unable to connect to devic");
		}
		string[] array = Regex.Split(text, "\n");
		for (int i = 0; i < array.Count<string>(); i++)
		{
			string[] array2 = Regex.Split(array[i], ":");
			if (array2[0] == "PWND")
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x0000776C File Offset: 0x0000596C
	public void method_3(string string_1 = "-q")
	{
		this.method_1(true, false);
		string text = this.method_8(this.method_10(), string_1);
		if (string.IsNullOrEmpty(text))
		{
			throw new Exception("Not Found .");
		}
		if (text.Contains("Unable to connect to device"))
		{
			throw new Exception("Unable to connect to devices");
		}
		string[] array = Regex.Split(text, "\n");
		for (int i = 0; i < array.Count<string>(); i++)
		{
			string[] array2 = Regex.Split(array[i], ":");
			if (array2[0] == "PWND")
			{
				return;
			}
		}
		throw new Exception("Fail");
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00007808 File Offset: 0x00005A08
	public void method_4(string string_1 = "-q")
	{
		this.method_1(true, false);
		string text = this.method_8(this.method_10(), string_1);
		if (string.IsNullOrEmpty(text))
		{
			throw new Exception("Not Found .");
		}
		if (!text.Contains("Unable to connect to device"))
		{
			string[] array = Regex.Split(text, "\n");
			for (int i = 0; i < array.Count<string>(); i++)
			{
				string[] array2 = Regex.Split(array[i], ":");
				if (array2[0] == "MODE" && array2[1].Substring(1, 3) != "DFU")
				{
					throw new Exception("Please connect device to DFU mode ..");
				}
			}
			return;
		}
		throw new Exception("Unable to connect to devices");
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000078C0 File Offset: 0x00005AC0
	public void method_5()
	{
		if (!GClass1.GClass2.smethod_0())
		{
			this.method_7("drivers\\install_x86.exe", "Apple_Mobile_Device_(DFU_Mode).inf", false);
		}
		else
		{
			this.method_7("drivers\\install_x64.exe", "Apple_Mobile_Device_(DFU_Mode).inf", false);
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x000078F8 File Offset: 0x00005AF8
	public void method_6()
	{
		if (GClass1.GClass2.smethod_0())
		{
			this.method_7("drivers\\install_x64.exe", "Apple_Mobile_Device_(DFU_Mode).inf", true);
		}
		else
		{
			this.method_7("drivers\\install_x86.exe", "Apple_Mobile_Device_(DFU_Mode).inf", true);
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00007930 File Offset: 0x00005B30
	private void method_7(string string_1, string string_2, bool bool_0 = false)
	{
		if (bool_0)
		{
		}
		if (!File.Exists(string_1))
		{
			throw new Exception("Process data not found ");
		}
		try
		{
			this.method_0(string_1, string_2, bool_0);
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00007980 File Offset: 0x00005B80
	private string method_8(string string_1, string string_2)
	{
		string text;
		try
		{
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					UseShellExecute = false,
					CreateNoWindow = true,
					FileName = string_1,
					Verb = "runas",
					Arguments = string_2,
					WorkingDirectory = Path.GetDirectoryName(string_1),
					RedirectStandardOutput = true,
					RedirectStandardError = true
				}
			};
			process.Start();
			text = process.StandardOutput.ReadToEnd() + process.StandardError.ReadToEnd();
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
		return text;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00007A24 File Offset: 0x00005C24
	public void method_9(string string_1)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName.ToLower().Contains(string_1))
				{
					process.Kill();
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00007A7C File Offset: 0x00005C7C
	private string method_10()
	{
		if (!File.Exists(this.string_0))
		{
			throw new Exception("iData not found ! Please reinstall app.");
		}
		return this.string_0;
	}

	// Token: 0x04000038 RID: 56
	private string string_0 = "files\\irecovery.exe";

	// Token: 0x02000012 RID: 18
	public static class GClass2
	{
		// Token: 0x06000061 RID: 97
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetCurrentProcess();

		// Token: 0x06000062 RID: 98
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetModuleHandle(string string_0);

		// Token: 0x06000063 RID: 99
		[DllImport("kernel32")]
		private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

		// Token: 0x06000064 RID: 100
		[DllImport("kernel32.dll")]
		private static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

		// Token: 0x06000065 RID: 101 RVA: 0x00007ACC File Offset: 0x00005CCC
		public static bool smethod_0()
		{
			bool flag2;
			if (IntPtr.Size != 8)
			{
				IntPtr moduleHandle = GClass1.GClass2.GetModuleHandle("kernel32");
				if (moduleHandle != IntPtr.Zero)
				{
					IntPtr procAddress = GClass1.GClass2.GetProcAddress(moduleHandle, "IsWow64Process");
					bool flag;
					if (procAddress != IntPtr.Zero && (GClass1.GClass2.IsWow64Process(GClass1.GClass2.GetCurrentProcess(), out flag) && flag))
					{
						return true;
					}
				}
				flag2 = false;
			}
			else
			{
				flag2 = true;
			}
			return flag2;
		}
	}
}
