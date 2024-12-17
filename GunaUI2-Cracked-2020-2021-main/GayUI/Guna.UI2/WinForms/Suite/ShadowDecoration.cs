using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x0200009D RID: 157
	[DebuggerStepThrough]
	[Description("ShadowDecoration")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class ShadowDecoration
	{
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public Control Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_0(int radius)
		{
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_1(PaintValueEventArgs e)
		{
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002167 File Offset: 0x00000367
		public ShadowDecoration(IControl owner)
		{
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("Style the control's border sides.")]
		public CustomizableEdges CustomizableEdges
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Description("If true, the shadow decoration will be enabled")]
		[Browsable(true)]
		[NotifyParentProperty(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00003AC4 File Offset: 0x00001CC4
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[Description("The shadow decoration mode")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(ShadowMode.Custom)]
		[Browsable(true)]
		public ShadowMode Mode
		{
			get
			{
				return ShadowMode.Custom;
			}
			set
			{
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "Black")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[NotifyParentProperty(true)]
		[Description("The shadow decoration color")]
		[Browsable(true)]
		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[NotifyParentProperty(true)]
		[DefaultValue(30)]
		[Browsable(true)]
		[Description("The shadow decoration depth")]
		public int Depth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Padding), "5, 5, 5, 5")]
		[Description("The shadow decoration shadow")]
		[NotifyParentProperty(true)]
		public Padding Shadow
		{
			get
			{
				return default(Padding);
			}
			set
			{
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[NotifyParentProperty(true)]
		[Description("The shadow decoration border radius")]
		[DefaultValue(6)]
		public int BorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(bool e)
		{
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3()
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00002136 File Offset: 0x00000336
		private bool method_4()
		{
			return false;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5()
		{
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0000343C File Offset: 0x0000163C
		private Rectangle method_6()
		{
			return default(Rectangle);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00002136 File Offset: 0x00000336
		private int method_7()
		{
			return 0;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10(object sender, ControlEventArgs e)
		{
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00002134 File Offset: 0x00000334
		private void method_11(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002134 File Offset: 0x00000334
		private void method_12(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x04000286 RID: 646
		private Bitmap bitmap_0;

		// Token: 0x04000287 RID: 647
		private bool bool_0;

		// Token: 0x04000288 RID: 648
		private Control control_0;

		// Token: 0x04000289 RID: 649
		private int int_0;

		// Token: 0x0400028A RID: 650
		private Control control_1;

		// Token: 0x0400028B RID: 651
		private CustomizableEdges customizableEdges_0;

		// Token: 0x0400028C RID: 652
		private bool bool_1;

		// Token: 0x0400028D RID: 653
		private ShadowMode shadowMode_0;

		// Token: 0x0400028E RID: 654
		private Color color_0;

		// Token: 0x0400028F RID: 655
		private int int_1;

		// Token: 0x04000290 RID: 656
		private Padding padding_0;

		// Token: 0x04000291 RID: 657
		private int int_2;

		// Token: 0x04000292 RID: 658
		private int int_3;
	}
}
