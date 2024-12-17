using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200005E RID: 94
	[Description("Represents a Windows control that displays a frame around a group of controls with an optional caption")]
	[ToolboxItem(true)]
	public class Guna2GroupBox : Guna.UI2.WinForms.Suite.GroupBox
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("If true, the border on the control is rounded off automatically")]
		[DefaultValue(false)]
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

		// Token: 0x0600068B RID: 1675 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "White")]
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

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "213, 218, 223")]
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

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "213, 218, 223")]
		public Color CustomBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Padding), "0, 40, 0, 0")]
		[Browsable(true)]
		public Padding CustomBorderThickness
		{
			get
			{
				return default(Padding);
			}
			set
			{
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(0)]
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

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(5)]
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

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Browsable(true)]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return HorizontalAlignment.Left;
			}
			set
			{
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
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

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Browsable(true)]
		public TextTransform TextTransform
		{
			get
			{
				return TextTransform.None;
			}
			set
			{
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Options")]
		[Localizable(true)]
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

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Point), "0, 0")]
		public Point TextOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(false)]
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

		// Token: 0x04000150 RID: 336
		private bool bool_1;

		// Token: 0x04000151 RID: 337
		private int int_2;
	}
}
