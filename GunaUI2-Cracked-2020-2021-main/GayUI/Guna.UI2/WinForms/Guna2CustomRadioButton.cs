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
	// Token: 0x02000053 RID: 83
	[Description("Advanced RadioButton Control")]
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(RadioButton))]
	[DebuggerStepThrough]
	[Designer(typeof(Guna2CustomRadioButtonDesigner))]
	public class Guna2CustomRadioButton : CustomRadioButton
	{
		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the control is in a checked state")]
		[Browsable(true)]
		public CustomRadionButtonState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the control is in an unchecked state")]
		[Browsable(true)]
		public CustomRadionButtonState UncheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Description("The control's font")]
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

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
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

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's ForeColor")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
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

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The properties that will be applied when the control is checked")]
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

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("If true, the control will be animated while interacting with the mouse")]
		[DefaultValue(false)]
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

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x04000124 RID: 292
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x04000125 RID: 293
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000126 RID: 294
		[CompilerGenerated]
		private string string_1;
	}
}
