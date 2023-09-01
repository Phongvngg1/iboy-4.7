using System;
using System.IO;
using System.IO.Compression;

// Token: 0x02000025 RID: 37
internal class Class22
{
	// Token: 0x06000118 RID: 280 RVA: 0x00011AD0 File Offset: 0x0000FCD0
	public void method_0()
	{
		ZipFile.ExtractToDirectory(Class22.string_1, this.string_2);
	}

	// Token: 0x040000C1 RID: 193
	public static string string_0 = Directory.GetCurrentDirectory();

	// Token: 0x040000C2 RID: 194
	public static string string_1 = ".\\Backups\\0x00164966102b003a.zip";

	// Token: 0x040000C3 RID: 195
	private string string_2 = Environment.CurrentDirectory + "\\Backups\\0x00164966102b003a";
}
