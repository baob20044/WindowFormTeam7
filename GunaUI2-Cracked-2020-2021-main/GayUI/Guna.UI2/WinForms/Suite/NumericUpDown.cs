using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Interfaces;
using ns0;
using ns2;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000B4 RID: 180
	[DefaultEvent("ValueChanged")]
	[ToolboxItem(false)]
	public class NumericUpDown : UserControl, ISupportInitialize, IControl
	{
		// Token: 0x06000E75 RID: 3701 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00002134 File Offset: 0x00000334
		protected bool DefaultIndicateFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected NumericUpDownState DefaultFocusedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected NumericUpDownState DefaultDisabledState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultUpDownButtonBorderVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultUpDownButtonFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultUpDownButtonForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected DashStyle DefaultBorderStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		protected ShadowDecoration DefaultShadowDecoration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultBorderThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultBorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Point DefaultTextOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultUseTransparentBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(Graphics G)
		{
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_2()
		{
			return null;
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00002134 File Offset: 0x00000334
		public void BeginInit()
		{
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00002134 File Offset: 0x00000334
		public void DownButton()
		{
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00002134 File Offset: 0x00000334
		public void EndInit()
		{
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00002134 File Offset: 0x00000334
		public void UpButton()
		{
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public NumericUpDownAccelerationCollection Accelerations
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		public int DecimalPlaces
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		public bool Hexadecimal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x000033F4 File Offset: 0x000015F4
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(decimal), "1")]
		public decimal Increment
		{
			get
			{
				return 0m;
			}
			set
			{
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x000033F4 File Offset: 0x000015F4
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(decimal), "100")]
		[RefreshProperties(RefreshProperties.All)]
		public decimal Maximum
		{
			get
			{
				return 0m;
			}
			set
			{
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x000033F4 File Offset: 0x000015F4
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(decimal), "0")]
		[RefreshProperties(RefreshProperties.All)]
		public decimal Minimum
		{
			get
			{
				return 0m;
			}
			set
			{
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x00002134 File Offset: 0x00000334
		[Bindable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public override string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Localizable(true)]
		public bool ThousandsSeparator
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x000033F4 File Offset: 0x000015F4
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(decimal), "0")]
		[Bindable(true)]
		public decimal Value
		{
			get
			{
				return 0m;
			}
			set
			{
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06000EB3 RID: 3763 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000EB4 RID: 3764 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new event EventHandler TextChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06000EB5 RID: 3765 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000EB6 RID: 3766 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler ValueChanged
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

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnValueChanged(EventArgs e)
		{
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(object sender, EventArgs e)
		{
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Options")]
		[DefaultValue(typeof(Color), "125, 137, 149")]
		[Browsable(true)]
		[Description("Sets the TextBox's foreground color.")]
		public new Color ForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000EBC RID: 3772 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets the font of the text displayed by the control.")]
		public new Font Font
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value indicating whether the control has input focus")]
		public new bool Focused
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(bool e)
		{
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00002134 File Offset: 0x00000334
		internal void method_7()
		{
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8()
		{
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06000EC1 RID: 3777 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000EC2 RID: 3778 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06000EC3 RID: 3779 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000EC4 RID: 3780 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10(object sender, EventArgs e)
		{
		}

		// Token: 0x040003C5 RID: 965
		private Control3 control3_0;

		// Token: 0x040003C6 RID: 966
		private Class0 class0_0;

		// Token: 0x040003C7 RID: 967
		private Class11 class11_0;

		// Token: 0x040003C8 RID: 968
		private IContainer icontainer_0;

		// Token: 0x040003C9 RID: 969
		private CustomizableEdges customizableEdges_0;

		// Token: 0x040003CA RID: 970
		private bool bool_0;

		// Token: 0x040003CB RID: 971
		private NumericUpDownState numericUpDownState_0;

		// Token: 0x040003CC RID: 972
		private NumericUpDownState numericUpDownState_1;

		// Token: 0x040003CD RID: 973
		private bool bool_1;

		// Token: 0x040003CE RID: 974
		private Color color_0;

		// Token: 0x040003CF RID: 975
		private Color color_1;

		// Token: 0x040003D0 RID: 976
		private DashStyle dashStyle_0;

		// Token: 0x040003D1 RID: 977
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x040003D2 RID: 978
		private Color color_2;

		// Token: 0x040003D3 RID: 979
		private Color color_3;

		// Token: 0x040003D4 RID: 980
		private int int_0;

		// Token: 0x040003D5 RID: 981
		private int int_1;

		// Token: 0x040003D6 RID: 982
		private Point point_0;

		// Token: 0x040003D7 RID: 983
		private bool bool_2;

		// Token: 0x040003D9 RID: 985
		private Padding padding_0;

		// Token: 0x040003DA RID: 986
		private bool bool_3;
	}
}
