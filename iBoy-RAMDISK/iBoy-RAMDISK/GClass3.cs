using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// Token: 0x0200001C RID: 28
public class GClass3
{
	// Token: 0x060000C4 RID: 196 RVA: 0x0000CCC8 File Offset: 0x0000AEC8
	private string method_0(string string_2)
	{
		return string.Join("", Encoding.GetEncoding("BIG5").GetBytes(string_2).Select(new Func<byte, string>(GClass3.Class14.<>9.method_0)));
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x0000CD18 File Offset: 0x0000AF18
	private byte[] method_1(string string_2)
	{
		if (string_2.Length % 2 == 0)
		{
			byte[] array = new byte[string_2.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				string text = string_2.Substring(i * 2, 2);
				array[i] = byte.Parse(text, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
			}
			return array;
		}
		throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", string_2));
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x0000CD8C File Offset: 0x0000AF8C
	private string method_2(string string_2)
	{
		byte[] array = new byte[0];
		if (string_2.Contains("0x"))
		{
			array = this.method_1(Regex.Replace(string_2, "0x|[ ,]", string.Empty).Normalize().Trim());
		}
		else
		{
			array = this.method_1(Regex.Replace(string_2, " ", string.Empty).Normalize().Trim());
		}
		return Encoding.ASCII.GetString(array);
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000CE00 File Offset: 0x0000B000
	// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000CE14 File Offset: 0x0000B014
	private string String_0 { get; set; }

	// Token: 0x060000C9 RID: 201 RVA: 0x00007A24 File Offset: 0x00005C24
	private void method_3(string string_2)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName.ToLower().Contains(string_2))
				{
					process.Kill();
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x060000CA RID: 202 RVA: 0x0000CE28 File Offset: 0x0000B028
	public void method_4()
	{
		this.method_3("gaster");
		try
		{
			if (Directory.Exists(this.String_0))
			{
				Directory.Delete(this.String_0, true);
			}
		}
		catch
		{
		}
	}

	// Token: 0x060000CB RID: 203 RVA: 0x0000CE70 File Offset: 0x0000B070
	public void method_5()
	{
		try
		{
			this.method_3("gaster");
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					UseShellExecute = false,
					CreateNoWindow = true,
					FileName = this.String_1,
					Verb = "runas",
					Arguments = "pwn",
					WorkingDirectory = Path.GetDirectoryName(this.String_1),
					RedirectStandardOutput = true,
					RedirectStandardError = true
				}
			};
			process.Start();
			process.WaitForExit();
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x060000CC RID: 204 RVA: 0x0000CF18 File Offset: 0x0000B118
	// (set) Token: 0x060000CD RID: 205 RVA: 0x0000CF2C File Offset: 0x0000B12C
	private string String_1 { get; set; }

	// Token: 0x060000CE RID: 206 RVA: 0x0000CF40 File Offset: 0x0000B140
	public void method_6()
	{
		try
		{
			this.method_3("gaster");
			byte[] byte_ = Class6.Byte_0;
			byte[] byte_2 = Class6.Byte_1;
			byte[] byte_3 = Class6.Byte_2;
			byte[] byte_4 = Class6.Byte_3;
			byte[] byte_5 = Class6.Byte_4;
			this.String_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), this.method_0(SystemInformation.ComputerName));
			if (Directory.Exists(this.String_0))
			{
				Directory.Delete(this.String_0, true);
			}
			if (!Directory.Exists(this.String_0))
			{
				Directory.CreateDirectory(this.String_0);
			}
			this.String_1 = Path.Combine(this.String_0, "gaster.exe");
			string text = Path.Combine(this.String_0, "gaster.exe");
			string text2 = Path.Combine(this.String_0, "libcrypto-1_1-x64.dll");
			string text3 = Path.Combine(this.String_0, "libssl-1_1-x64.dll");
			string text4 = Path.Combine(this.String_0, "libusb-1.0.dll");
			string text5 = Path.Combine(this.String_0, "openssl.exe");
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, byte_);
			}
			if (!File.Exists(text2))
			{
				File.WriteAllBytes(text2, byte_2);
			}
			if (!File.Exists(text3))
			{
				File.WriteAllBytes(text3, byte_3);
			}
			if (!File.Exists(text4))
			{
				File.WriteAllBytes(text4, byte_4);
			}
			if (!File.Exists(text5))
			{
				File.WriteAllBytes(text5, byte_5);
			}
		}
		catch
		{
			try
			{
				this.method_6();
			}
			catch
			{
				throw new Exception("database output error ");
			}
		}
	}

	// Token: 0x0400008F RID: 143
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_0;

	// Token: 0x04000090 RID: 144
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string string_1;

	// Token: 0x0200001D RID: 29
	[CompilerGenerated]
	[Serializable]
	private sealed class Class14
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x0000D104 File Offset: 0x0000B304
		internal string method_0(byte byte_0)
		{
			return string.Format("{0:X2}", byte_0);
		}

		// Token: 0x04000091 RID: 145
		public static readonly GClass3.Class14 <>9 = new GClass3.Class14();

		// Token: 0x04000092 RID: 146
		public static Func<byte, string> <>9__0_0;
	}
}
