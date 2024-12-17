using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200004C RID: 76
	[Description("Advanced circle picturebox")]
	[DebuggerStepThrough]
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(System.Windows.Forms.PictureBox))]
	[Designer(typeof(Guna2CirclePictureBoxDesigner))]
	public class Guna2CirclePictureBox : CirclePictureBox
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Browsable(true)]
		[Description("If true, the background will allow a transparent color")]
		public bool UseTransparentBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The BackColor that will fill the control")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
		public Color FillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Shadow property of the control to add and customize a control's shadow")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		public ShadowDecoration ShadowDecoration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
