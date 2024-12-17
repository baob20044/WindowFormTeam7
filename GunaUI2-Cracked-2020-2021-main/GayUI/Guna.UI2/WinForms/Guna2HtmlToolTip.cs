using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.HtmlRenderer.Core;
using Guna.UI2.HtmlRenderer.Core.Entities;
using Guna.UI2.HtmlRenderer.WinForms;

namespace Guna.UI2.WinForms
{
	// Token: 0x0200007D RID: 125
	[Description("A tooltip control")]
	[ToolboxItem(true)]
	[ToolboxBitmap(typeof(ToolTip))]
	[DebuggerStepThrough]
	public class Guna2HtmlToolTip : ToolTip
	{
		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "125, 137, 149")]
		[Browsable(true)]
		[Description("The tooltip ForeColor")]
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

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "White")]
		[Description("The tooltip BackColor")]
		[Browsable(true)]
		public new Color BackColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The tooltip BorderColor")]
		[DefaultValue(typeof(Color), "213, 218, 223")]
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

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The tooltip font style")]
		[DefaultValue(typeof(Font), "Segoe UI, 9pt")]
		[Browsable(true)]
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

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Font), "Segoe UI, 9pt, style=Bold")]
		[Description("The tooltip title font style")]
		[Browsable(true)]
		public Font TitleFont
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The tooltip title ForeColor")]
		[DefaultValue(typeof(Color), "94, 148, 255")]
		[Browsable(true)]
		public Color TitleForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[Description("If true, the tooltip will draw itself")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new bool OwnerDraw
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600094F RID: 2383 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000950 RID: 2384 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlLinkClickedEventArgs> LinkClicked
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

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000951 RID: 2385 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000952 RID: 2386 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlRenderErrorEventArgs> RenderError
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

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000953 RID: 2387 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000954 RID: 2388 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlStylesheetLoadEventArgs> StylesheetLoad
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

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000955 RID: 2389 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000956 RID: 2390 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlImageLoadEventArgs> ImageLoad
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

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(false)]
		[Description("If to use GDI+ text rendering to measure/draw text, false - use GDI")]
		[Category("Behavior")]
		public bool UseGdiPlusTextRendering
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Behavior")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[DefaultValue(TextRenderingHint.SystemDefault)]
		[Description("The text rendering hint to be used for text rendering.")]
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

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Set base stylesheet to be used by html rendered in the tooltip.")]
		[Browsable(false)]
		[Category("Appearance")]
		[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		internal virtual string BaseStylesheet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[Description("The CSS class used for tooltip html root div.")]
		[Category("Appearance")]
		internal virtual string TooltipCssClass
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If to handle links in the tooltip.")]
		[DefaultValue(false)]
		[Category("Behavior")]
		[Browsable(true)]
		public virtual bool AllowLinksHandling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Layout")]
		[Browsable(true)]
		[Description("Restrict the max size of the shown tooltip (0 is not restricted)")]
		public virtual Size MaximumSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00002131 File Offset: 0x00000331
		public string ColorToHtml(Color color)
		{
			return null;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00002131 File Offset: 0x00000331
		internal string method_0(Color color)
		{
			return null;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(string text, string title)
		{
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnToolTipPopup(PopupEventArgs e)
		{
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnToolTipDraw(DrawToolTipEventArgs e)
		{
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void AdjustTooltipPosition(Control associatedControl, Size size)
		{
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnLinkClicked(HtmlLinkClickedEventArgs e)
		{
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnRenderError(HtmlRenderErrorEventArgs e)
		{
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnStylesheetLoad(HtmlStylesheetLoadEventArgs e)
		{
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnImageLoad(HtmlImageLoadEventArgs e)
		{
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnLinkHandlingTimerTick(EventArgs e)
		{
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnToolTipDisposed(EventArgs e)
		{
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, PopupEventArgs e)
		{
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, DrawToolTipEventArgs e)
		{
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender, HtmlRenderErrorEventArgs e)
		{
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(object sender, HtmlStylesheetLoadEventArgs e)
		{
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(object sender, HtmlImageLoadEventArgs e)
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7(object sender, HtmlLinkClickedEventArgs e)
		{
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8(object sender, EventArgs e)
		{
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9(object sender, EventArgs e)
		{
		}

		// Token: 0x040001E5 RID: 485
		protected HtmlContainer _htmlContainer;

		// Token: 0x040001E6 RID: 486
		protected string _baseRawCssData;

		// Token: 0x040001E7 RID: 487
		protected CssData _baseCssData;

		// Token: 0x040001E8 RID: 488
		protected TextRenderingHint _textRenderingHint;

		// Token: 0x040001E9 RID: 489
		private string string_0;

		// Token: 0x040001EA RID: 490
		private Control control_0;

		// Token: 0x040001EB RID: 491
		private Timer timer_0;

		// Token: 0x040001EC RID: 492
		private IntPtr intptr_0;

		// Token: 0x040001ED RID: 493
		private bool bool_0;

		// Token: 0x040001EE RID: 494
		private Color color_0;

		// Token: 0x040001EF RID: 495
		private Font font_0;

		// Token: 0x040001F0 RID: 496
		private Font font_1;

		// Token: 0x040001F1 RID: 497
		private Color color_1;

		// Token: 0x040001F2 RID: 498
		[CompilerGenerated]
		private bool bool_1;
	}
}
