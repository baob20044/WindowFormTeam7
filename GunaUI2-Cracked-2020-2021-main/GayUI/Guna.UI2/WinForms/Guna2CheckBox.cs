using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Suite;
using ns0;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200003C RID: 60
	[Description("Provides enhanced visual support for checked and unchecked states.")]
	[Designer(typeof(Guna2CheckBoxDesigner))]
	[ToolboxBitmap(typeof(CheckBox))]
	public class Guna2CheckBox : CheckBox
	{
		// Token: 0x0600033A RID: 826 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(false)]
		public new FlatButtonAppearance FlatAppearance
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00003828 File Offset: 0x00001A28
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(FlatStyle.Standard)]
		[Browsable(false)]
		public new FlatStyle FlatStyle
		{
			get
			{
				return FlatStyle.Flat;
			}
			set
			{
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(5)]
		[Description("This property allows you to change how text is printed onto the control.")]
		[Browsable(true)]
		public TextRenderingHint TextRenderingHint
		{
			get
			{
				return TextRenderingHint.SystemDefault;
			}
			set
			{
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Description("If true, the control will be animated while interacting with the mouse.")]
		[Browsable(true)]
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

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000343 RID: 835 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(DashStyle.Solid)]
		[Browsable(true)]
		[Description("The css-like style of the border. You can customize the border to meet your design needs.")]
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

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Allows you to define the color of the tick icon of the checkbox.")]
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

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the control is in an unchecked state.")]
		[Browsable(true)]
		public CustomCheckBoxState UncheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("The properties that will be applied when the control is in a checked state.")]
		public CustomCheckBoxState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnCheckedChanged(EventArgs e)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs pevent)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600034F RID: 847 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000350 RID: 848 RVA: 0x00002134 File Offset: 0x00000334
		public new event EventHandler LostFocus
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000351 RID: 849 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000352 RID: 850 RVA: 0x00002134 File Offset: 0x00000334
		public new event EventHandler GotFocus
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(object sender, EventArgs e)
		{
		}

		// Token: 0x040000BB RID: 187
		private Guna2CustomCheckBox guna2CustomCheckBox_0;

		// Token: 0x040000BC RID: 188
		private Class0 class0_0;

		// Token: 0x040000BD RID: 189
		private IContainer icontainer_0;

		// Token: 0x040000BE RID: 190
		private TextRenderingHint textRenderingHint_0;
	}
}
