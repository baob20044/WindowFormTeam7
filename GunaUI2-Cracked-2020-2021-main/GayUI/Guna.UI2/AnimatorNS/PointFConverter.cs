using System;
using System.ComponentModel;
using System.Globalization;

namespace Guna.UI2.AnimatorNS
{
	// Token: 0x02000194 RID: 404
	public class PointFConverter : ExpandableObjectConverter
	{
		// Token: 0x0600184A RID: 6218 RVA: 0x00002136 File Offset: 0x00000336
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return false;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00002131 File Offset: 0x00000331
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00002131 File Offset: 0x00000331
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}
	}
}
