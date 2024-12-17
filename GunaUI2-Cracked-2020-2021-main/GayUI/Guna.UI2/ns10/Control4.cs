using System;
using System.Windows.Forms;
using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.HtmlRenderer.Adapters.Entities;

namespace ns10
{
	// Token: 0x02000106 RID: 262
	internal sealed class Control4 : RControl
	{
		// Token: 0x06001228 RID: 4648 RVA: 0x000023F6 File Offset: 0x000005F6
		public Control4(Control control, bool useGdiPlusTextRendering) : base(null)
		{
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x00002131 File Offset: 0x00000331
		public Control Control_0
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x00003BE4 File Offset: 0x00001DE4
		public override RPoint MouseLocation
		{
			get
			{
				return default(RPoint);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x00002136 File Offset: 0x00000336
		public override bool LeftMouseButton
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00002136 File Offset: 0x00000336
		public override bool RightMouseButton
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00002134 File Offset: 0x00000334
		public override void SetCursorDefault()
		{
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00002134 File Offset: 0x00000334
		public override void SetCursorHand()
		{
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00002134 File Offset: 0x00000334
		public override void SetCursorIBeam()
		{
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00002134 File Offset: 0x00000334
		public override void DoDragDropCopy(object dragDropData)
		{
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00002134 File Offset: 0x00000334
		public override void MeasureString(string str, RFont font, double maxWidth, out int charFit, out double charFitWidth)
		{
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00002134 File Offset: 0x00000334
		public override void Invalidate()
		{
		}

		// Token: 0x040006DE RID: 1758
		private readonly Control control_0;

		// Token: 0x040006DF RID: 1759
		private readonly bool bool_0;
	}
}
