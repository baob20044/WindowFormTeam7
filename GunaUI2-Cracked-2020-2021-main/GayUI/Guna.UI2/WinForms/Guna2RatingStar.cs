using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Interfaces;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000069 RID: 105
	[ToolboxItem(true)]
	[DefaultEvent("ValueChanged")]
	[Description("A Rating Control")]
	[DebuggerStepThrough]
	public class Guna2RatingStar : Control, IControl
	{
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00002136 File Offset: 0x00000336
		protected override bool ProcessDialogKey(Keys keyData)
		{
			return false;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00002131 File Offset: 0x00000331
		private PointF[] method_0(PointF Orig, float outerradius, float innerradius)
		{
			return null;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00002131 File Offset: 0x00000331
		private PointF[] method_1(PointF location, float size)
		{
			return null;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00002145 File Offset: 0x00000345
		private float method_2()
		{
			return 0f;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00002145 File Offset: 0x00000345
		private float method_3(int i)
		{
			return 0f;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00002145 File Offset: 0x00000345
		private float method_4(int i)
		{
			return 0f;
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060007E0 RID: 2016 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060007E1 RID: 2017 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x060007E2 RID: 2018 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnKeyUp(KeyEventArgs e)
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The rating control's font style")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new Font Font
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

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The rating control's text")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new string Text
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

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The rating control's ForeColor")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new string ForeColor
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

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00002145 File Offset: 0x00000345
		[DefaultValue(0f)]
		[Description("The rating control's minimum value")]
		public float Minimum
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00002145 File Offset: 0x00000345
		[DefaultValue(5f)]
		[Description("The rating control's maximum value")]
		public float Maximum
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The rating control's current value")]
		[DefaultValue(0f)]
		public float Value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The rating control's fill color")]
		[DefaultValue(typeof(Color), "")]
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

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "113, 208, 255")]
		[Description("The rating control's color")]
		public Color RatingColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "193, 200, 207")]
		[Description("The rating control's border color")]
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

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(2)]
		[Description("The rating control's border thickness")]
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

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "")]
		[Description("The rating control's color when focused")]
		public Color FocusedColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(Graphics G)
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x04000184 RID: 388
		[CompilerGenerated]
		private Font font_0;

		// Token: 0x04000185 RID: 389
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000186 RID: 390
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000187 RID: 391
		private float float_0;

		// Token: 0x04000188 RID: 392
		private Color color_0;

		// Token: 0x04000189 RID: 393
		private Color color_1;

		// Token: 0x0400018A RID: 394
		private Color color_2;

		// Token: 0x0400018B RID: 395
		private int int_0;

		// Token: 0x0400018C RID: 396
		private Color color_3;
	}
}
