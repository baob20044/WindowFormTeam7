using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000073 RID: 115
	[ToolboxItem(true)]
	[Description("A ToggleSwitch Control")]
	[DebuggerStepThrough]
	public class Guna2ToggleSwitch : ToggleSwitch
	{
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Description("If true, the border on the control is rounded off automatically")]
		[Browsable(true)]
		public bool AutoRoundedCorners
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4()
		{
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the control is in a checked state")]
		[Browsable(true)]
		public ToggleSwitchState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("The properties that will be applied when the control is in an unchecked state")]
		public ToggleSwitchState UncheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Description("The toggle switch's font style")]
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

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		[Description("The toggle switch's text")]
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

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Description("The toggle switch's ForeColor")]
		[Browsable(false)]
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

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(false)]
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

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("Shadow property of the control to add and customize a control's shadow")]
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

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Description("If true, the background will allow a transparent color")]
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

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The properties that will be applied when the control is checked")]
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

		// Token: 0x040001C5 RID: 453
		private bool bool_6;

		// Token: 0x040001C6 RID: 454
		private int int_0;

		// Token: 0x040001C7 RID: 455
		private int int_1;

		// Token: 0x040001C8 RID: 456
		private int int_2;

		// Token: 0x040001C9 RID: 457
		private int int_3;

		// Token: 0x040001CA RID: 458
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x040001CB RID: 459
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040001CC RID: 460
		[CompilerGenerated]
		private string string_1;
	}
}
