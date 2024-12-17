using System;
using System.ComponentModel;
using System.Drawing;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000A1 RID: 161
	public class GradientButtonState : ButtonState
	{
		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000B53 RID: 2899 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
		[NotifyParentProperty(true)]
		[Description("The second fill color in a gradient mode")]
		public Color FillColor2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x040002AA RID: 682
		private Color color_4;
	}
}
