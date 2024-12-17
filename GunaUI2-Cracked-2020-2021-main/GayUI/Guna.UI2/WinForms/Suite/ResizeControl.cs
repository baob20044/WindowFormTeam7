using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000B8 RID: 184
	[ToolboxItem(false)]
	public class ResizeControl : Control, IControl
	{
		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Control DefaultTargetControl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000F32 RID: 3890 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0(Graphics G)
		{
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnForeColorChanged(EventArgs e)
		{
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x04000403 RID: 1027
		private Control control_0;

		// Token: 0x04000404 RID: 1028
		private Size size_0;

		// Token: 0x04000405 RID: 1029
		private Color color_0;

		// Token: 0x04000406 RID: 1030
		private bool bool_0;
	}
}
