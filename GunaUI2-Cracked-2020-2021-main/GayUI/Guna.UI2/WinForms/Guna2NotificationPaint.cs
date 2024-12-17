using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000035 RID: 53
	public class Guna2NotificationPaint : Component
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2NotificationPaint()
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2NotificationPaint(Control control)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000214C File Offset: 0x0000034C
		public Guna2NotificationPaint(IContainer container)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The BackColor that will fill the control")]
		[Browsable(true)]
		[DefaultValue(typeof(Color), "255, 128, 0")]
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

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060002DB RID: 731 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The curve angle of the control on all angles")]
		[DefaultValue(4)]
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

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "White")]
		[Description("The border color")]
		[Browsable(true)]
		public Color BorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "White")]
		[Description("The fore color")]
		[Browsable(true)]
		public Color ForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue("0")]
		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The border thickness. The higher the value, the thicker the border")]
		[DefaultValue(1)]
		[Browsable(true)]
		public int BorderThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(true)]
		public bool Visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Point), "0, 0")]
		public Point Location
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Size), "18, 18")]
		public Size Size
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000343C File Offset: 0x0000163C
		private Rectangle Rectangle_0
		{
			get
			{
				return default(Rectangle);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Font), "Segoe UI, 8.23pt, style=Bold")]
		public Font Font
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The target control to apply curves to the edges")]
		[DefaultValue(typeof(Control), "")]
		[Browsable(true)]
		public Control TargetControl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00003454 File Offset: 0x00001654
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(CustomContentAlignment.Custom)]
		public CustomContentAlignment Alignment
		{
			get
			{
				return CustomContentAlignment.MiddleLeft;
			}
			set
			{
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Point), "0, 0")]
		public Point Offset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000337C File Offset: 0x0000157C
		private Point method_1()
		{
			return default(Point);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2()
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002136 File Offset: 0x00000336
		private int method_3()
		{
			return 0;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002136 File Offset: 0x00000336
		private int method_4()
		{
			return 0;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002136 File Offset: 0x00000336
		private int method_5()
		{
			return 0;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002136 File Offset: 0x00000336
		private int method_6()
		{
			return 0;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x04000078 RID: 120
		private IContainer icontainer_0;

		// Token: 0x04000079 RID: 121
		private Color color_0;

		// Token: 0x0400007A RID: 122
		private int int_0;

		// Token: 0x0400007B RID: 123
		private Color color_1;

		// Token: 0x0400007C RID: 124
		private Color color_2;

		// Token: 0x0400007D RID: 125
		private string string_0;

		// Token: 0x0400007E RID: 126
		private int int_1;

		// Token: 0x0400007F RID: 127
		private bool bool_0;

		// Token: 0x04000080 RID: 128
		private Point point_0;

		// Token: 0x04000081 RID: 129
		private Size size_0;

		// Token: 0x04000082 RID: 130
		private Font font_0;

		// Token: 0x04000083 RID: 131
		private Control control_0;

		// Token: 0x04000084 RID: 132
		private CustomContentAlignment customContentAlignment_0;

		// Token: 0x04000085 RID: 133
		private Point point_1;
	}
}
