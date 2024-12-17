using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;

namespace ns2
{
	// Token: 0x020000CB RID: 203
	[ToolboxItem(false)]
	internal class Control3 : UIControl
	{
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001121 RID: 4385 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("Style the control's border sides.")]
		[Browsable(true)]
		public CustomizableEdges CustomizableEdges_0
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06001123 RID: 4387 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Browsable(true)]
		public Color Color_0
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00002136 File Offset: 0x00000336
		private bool method_1(Point e)
		{
			return false;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00002136 File Offset: 0x00000336
		private bool method_2(Point e)
		{
			return false;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseMove(MouseEventArgs e)
		{
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06001128 RID: 4392 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001129 RID: 4393 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler Event_0
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

		// Token: 0x0600112A RID: 4394 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnDownButtonChanged(EventArgs e)
		{
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x0600112B RID: 4395 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600112C RID: 4396 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler Event_1
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

		// Token: 0x0600112D RID: 4397 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnUpButtonChanged(EventArgs e)
		{
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_3()
		{
			return null;
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00002131 File Offset: 0x00000331
		private Bitmap method_4(Color color)
		{
			return null;
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06001131 RID: 4401 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001132 RID: 4402 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler Event_2
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

		// Token: 0x06001133 RID: 4403 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnCustomGotFocusChanged(EventArgs e)
		{
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x040004CA RID: 1226
		private CustomizableEdges customizableEdges_0;

		// Token: 0x040004CB RID: 1227
		private Color color_1;

		// Token: 0x040004CC RID: 1228
		private Point point_0;

		// Token: 0x040004CD RID: 1229
		[CompilerGenerated]
		private EventHandler DownButtonChanged;

		// Token: 0x040004CE RID: 1230
		[CompilerGenerated]
		private EventHandler UpButtonChanged;

		// Token: 0x040004CF RID: 1231
		[CompilerGenerated]
		private EventHandler CustomGotFocusChanged;
	}
}
