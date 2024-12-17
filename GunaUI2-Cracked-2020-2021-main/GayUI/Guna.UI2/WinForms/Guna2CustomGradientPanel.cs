using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000052 RID: 82
	[ToolboxBitmap(typeof(System.Windows.Forms.Panel))]
	[Description("Advanced panel control that supports gradient colors")]
	[ToolboxItem(true)]
	[DebuggerStepThrough]
	public class Guna2CustomGradientPanel : CustomGradientPanel
	{
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The BackColor that will fill the control")]
		[DefaultValue(typeof(Color), "White")]
		[Browsable(true)]
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

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The second BackColor that will fill the control in a gradient mode")]
		[DefaultValue(typeof(Color), "White")]
		[Browsable(true)]
		public Color FillColor2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The third BackColor that will fill the control in a gradient mode")]
		[DefaultValue(typeof(Color), "White")]
		[Browsable(true)]
		public Color FillColor3
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The fourth BackColor that will fill the control in a gradient mode")]
		[DefaultValue(typeof(Color), "White")]
		[Browsable(true)]
		public Color FillColor4
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Quality")]
		[DefaultValue(10)]
		public int Quality
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The css-like style of the border. You can customize the border to meet your design needs")]
		[DefaultValue(DashStyle.Solid)]
		public new DashStyle BorderStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Shadow property of the control to add and customize a control's shadow")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
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

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
		[Description("The border color")]
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

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The border thickness. The higher the value, the thicker the border")]
		[Browsable(true)]
		[DefaultValue(0)]
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

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(typeof(Color), "")]
		[Description("The border custom color")]
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

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x000033DC File Offset: 0x000015DC
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The border thickness. The higher the value, the thicker the border")]
		[DefaultValue(typeof(Padding), "0, 0, 0, 0")]
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

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Description("The curve angle of the control on all angles")]
		[Browsable(true)]
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
	}
}
