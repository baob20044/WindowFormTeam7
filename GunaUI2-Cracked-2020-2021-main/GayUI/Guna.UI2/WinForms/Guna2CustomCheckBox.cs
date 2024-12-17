using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000051 RID: 81
	[Description("Advanced CheckBox Control")]
	[ToolboxBitmap(typeof(CheckBox))]
	[ToolboxItem(true)]
	[Designer(typeof(Guna2CustomCheckBoxDesigner))]
	[DebuggerStepThrough]
	public class Guna2CustomCheckBox : CustomCheckBox
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00002131 File Offset: 0x00000331
		[Description("The properties that will be applied when the control is in a checked state")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public CustomCheckBoxState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("The properties that will be applied when the control is in an unchecked state")]
		public CustomCheckBoxState UncheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's font style")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new Font Font
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Description("The control's text")]
		public new string Text
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Description("The control's ForeColor")]
		public new string ForeColor
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Browsable(true)]
		[Description("If true, the control will be animated while interacting with the mouse")]
		public bool Animated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The css-like style of the border. You can customize the border to meet your design needs")]
		[DefaultValue(DashStyle.Solid)]
		public DashStyle BorderStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Allows you to define the color of the tick icon of the checkbox.")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "White")]
		public Color CheckMarkColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the control will be in a checked state")]
		[Browsable(true)]
		[DefaultValue(false)]
		public bool Checked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x000039C0 File Offset: 0x00001BC0
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(CheckState.Unchecked)]
		[Description("This property returns the check state of the control")]
		[Browsable(true)]
		public CheckState CheckState
		{
			get
			{
				return CheckState.Unchecked;
			}
			set
			{
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Shadow property of the control to add and customize a control's shadow")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
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

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the background will allow a transparent color")]
		[DefaultValue(false)]
		[Browsable(true)]
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

		// Token: 0x04000121 RID: 289
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x04000122 RID: 290
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000123 RID: 291
		[CompilerGenerated]
		private string string_1;
	}
}
