using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using Guna.UI2.WinForms.Enums;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x02000097 RID: 151
	[DebuggerStepThrough]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Description("ImageControlState")]
	public class ImageControlState
	{
		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public UIDefaultControl Parent
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

		// Token: 0x06000A86 RID: 2694 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0000334C File Offset: 0x0000154C
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(0)]
		[Description("Flips the image to any given orientation. Supports both Vertical  and Horizontal orientation-flipping options.")]
		public FlipOrientation ImageFlip
		{
			get
			{
				return FlipOrientation.Normal;
			}
			set
			{
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[NotifyParentProperty(true)]
		[DefaultValue(typeof(float), "0")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("Sets the angle of rotation for the image. Please provide a value between 0 and 360.")]
		public float ImageRotate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x00002134 File Offset: 0x00000334
		[NotifyParentProperty(true)]
		[DefaultValue(typeof(Image), "")]
		[Description("The control's image")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
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

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[NotifyParentProperty(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(typeof(Size), "20, 20")]
		[Description("The control's image size")]
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

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Point), "0, 0")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("The control's image offset")]
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

		// Token: 0x04000265 RID: 613
		[CompilerGenerated]
		private UIDefaultControl uidefaultControl_0;

		// Token: 0x04000266 RID: 614
		private FlipOrientation flipOrientation_0;

		// Token: 0x04000267 RID: 615
		private float float_0;

		// Token: 0x04000268 RID: 616
		private Image image_0;

		// Token: 0x04000269 RID: 617
		private Size size_0;

		// Token: 0x0400026A RID: 618
		private Point point_0;
	}
}
