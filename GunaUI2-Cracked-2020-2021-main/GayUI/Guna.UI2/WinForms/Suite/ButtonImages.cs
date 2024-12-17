using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x0200008F RID: 143
	[DebuggerStepThrough]
	[Description("ButtonCustomImages")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class ButtonImages
	{
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public CustomButtonBase Parent
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

		// Token: 0x06000A0F RID: 2575 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Image), "")]
		[Browsable(true)]
		[NotifyParentProperty(true)]
		[Description("Image")]
		public Image Image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[Description("The Image that will be applied when the cursor hovers over the control")]
		[DefaultValue(typeof(Image), "")]
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public Image HoveredImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Image), "")]
		[NotifyParentProperty(true)]
		[Description("The Image that will be applied when the control is checked")]
		[Browsable(true)]
		public Image CheckedImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Size), "20, 20")]
		[Description("The Image size")]
		[Browsable(true)]
		[NotifyParentProperty(true)]
		public Size ImageSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The Image positioning")]
		[DefaultValue(typeof(Point), "0, 0")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[NotifyParentProperty(true)]
		public Point ImageOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(1)]
		[Description("The Image location or horizontal-alignment on the control")]
		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[NotifyParentProperty(true)]
		public HorizontalAlignment ImageAlign
		{
			get
			{
				return HorizontalAlignment.Left;
			}
			set
			{
			}
		}

		// Token: 0x04000236 RID: 566
		[CompilerGenerated]
		private CustomButtonBase customButtonBase_0;

		// Token: 0x04000237 RID: 567
		private Image image_0;

		// Token: 0x04000238 RID: 568
		private Image image_1;

		// Token: 0x04000239 RID: 569
		private Image image_2;

		// Token: 0x0400023A RID: 570
		private Size size_0;

		// Token: 0x0400023B RID: 571
		private Point point_0;

		// Token: 0x0400023C RID: 572
		private HorizontalAlignment horizontalAlignment_0;
	}
}
