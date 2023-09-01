using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000029 RID: 41
[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal class Class26
{
	// Token: 0x06000123 RID: 291 RVA: 0x000053E8 File Offset: 0x000035E8
	internal Class26()
	{
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000124 RID: 292 RVA: 0x00011E64 File Offset: 0x00010064
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class26.resourceManager_0 == null)
			{
				ResourceManager resourceManager = new ResourceManager("h:#)J)O'hEc<\\*Yi--mKN:_Xu\\,", typeof(Class26).Assembly);
				Class26.resourceManager_0 = resourceManager;
			}
			return Class26.resourceManager_0;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000125 RID: 293 RVA: 0x00011EA4 File Offset: 0x000100A4
	// (set) Token: 0x06000126 RID: 294 RVA: 0x00011EB8 File Offset: 0x000100B8
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class26.cultureInfo_0;
		}
		set
		{
			Class26.cultureInfo_0 = value;
		}
	}

	// Token: 0x040000C5 RID: 197
	private static ResourceManager resourceManager_0;

	// Token: 0x040000C6 RID: 198
	private static CultureInfo cultureInfo_0;
}
