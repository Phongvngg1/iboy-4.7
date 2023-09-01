using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

// Token: 0x02000026 RID: 38
internal static class Class23
{
	// Token: 0x0600011B RID: 283 RVA: 0x00011B3C File Offset: 0x0000FD3C
	[STAThread]
	private static void smethod_0()
	{
		Class23.Class24 @class = new Class23.Class24();
		@class.class5_0 = new Class5();
		Task.Run(new Action(@class.method_0));
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Count<Process>() <= 1)
		{
			Application.Run(new FRM_iBoy());
		}
		else
		{
			MessageBox.Show("This Software is Already Running", "iBoy Ramdisk", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Process.GetCurrentProcess().Kill();
		}
	}

	// Token: 0x02000027 RID: 39
	[CompilerGenerated]
	private sealed class Class24
	{
		// Token: 0x0600011D RID: 285 RVA: 0x00011BC0 File Offset: 0x0000FDC0
		internal void method_0()
		{
			this.class5_0.method_2();
		}

		// Token: 0x040000C4 RID: 196
		public Class5 class5_0;
	}
}
