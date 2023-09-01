using System;
using System.Runtime.CompilerServices;

// Token: 0x0200002B RID: 43
[CompilerGenerated]
internal sealed class Class27
{
	// Token: 0x0600012A RID: 298 RVA: 0x00011F18 File Offset: 0x00010118
	internal static uint smethod_0(string string_0)
	{
		uint num;
		if (string_0 != null)
		{
			num = 2166136261U;
			for (int i = 0; i < string_0.Length; i++)
			{
				num = ((uint)string_0[i] ^ num) * 16777619U;
			}
		}
		return num;
	}
}
