using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.HtmlRenderer.Core;
using Guna.UI2.HtmlRenderer.Core.Entities;
using Guna.UI2.HtmlRenderer.WinForms;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000045 RID: 69
	[ToolboxBitmap(typeof(Label))]
	[DebuggerStepThrough]
	[ToolboxItem(true)]
	[Description("Label control that supports html tags. See our YouTube tutorials to learn more")]
	public class Guna2HtmlLabel : Control
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060003D9 RID: 985 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060003DA RID: 986 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Property Changed")]
		public event EventHandler BorderStyleChanged
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

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060003DB RID: 987 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060003DC RID: 988 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler LoadComplete
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

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060003DD RID: 989 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060003DE RID: 990 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060003DF RID: 991 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060003E0 RID: 992 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060003E1 RID: 993 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060003E2 RID: 994 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060003E3 RID: 995 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060003E4 RID: 996 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Behavior")]
		[Description("If anti-aliasing should be avoided for geometry like backgrounds and borders")]
		[DefaultValue(false)]
		public virtual bool AvoidGeometryAntialias
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If to use GDI+ text rendering to measure/draw text, false - use GDI")]
		[DefaultValue(false)]
		[EditorBrowsable(EditorBrowsableState.Always)]
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

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(TextRenderingHint.SystemDefault)]
		[Description("The text rendering hint to be used for text rendering.")]
		[Category("Behavior")]
		[EditorBrowsable(EditorBrowsableState.Always)]
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

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If to use cursors defined by the operating system or .NET cursors")]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Category("Behavior")]
		[DefaultValue(false)]
		public bool UseSystemCursors
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x000038E8 File Offset: 0x00001AE8
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Appearance")]
		[DefaultValue(typeof(BorderStyle), "None")]
		public virtual BorderStyle BorderStyle
		{
			get
			{
				return BorderStyle.None;
			}
			set
			{
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("Is content selection is enabled for the rendered html.")]
		[Category("Behavior")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public virtual bool IsSelectionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Behavior")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Description("Is the build-in context menu enabled and will be shown on mouse right click.")]
		[Browsable(true)]
		[DefaultValue(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public virtual bool IsContextMenuEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00002134 File Offset: 0x00000334
		[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[Browsable(true)]
		[Description("Set base stylesheet to be used by html rendered in the control.")]
		[Category("Appearance")]
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

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[DefaultValue(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Description("Automatically sets the size of the label by content size.")]
		[Browsable(true)]
		public override bool AutoSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Browsable(true)]
		[Description("Automatically sets the height of the label by content height (width is not effected)")]
		[Category("Layout")]
		public virtual bool AutoSizeHeightOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If AutoSize or AutoSizeHeightOnly is set this will restrict the max size of the control (0 is not restricted)")]
		public override Size MaximumSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If AutoSize or AutoSizeHeightOnly is set this will restrict the min size of the control (0 is not restricted)")]
		public override Size MinimumSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Sets the html of this control.")]
		[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
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

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00003900 File Offset: 0x00001B00
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DisplayName("TextAlign")]
		[Description("Determines the position of the text within the label. Referred to as 'TextAlignment' when using it in code.")]
		[DefaultValue(ContentAlignment.TopLeft)]
		public ContentAlignment TextAlignment
		{
			get
			{
				return (ContentAlignment)0;
			}
			set
			{
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets the foreground color of the control")]
		[Browsable(true)]
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

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Gets or sets the font of the text displayed by the control")]
		public new Font Font
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(false)]
		public virtual string SelectedText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00002131 File Offset: 0x00000331
		[Browsable(false)]
		public virtual string SelectedHtml
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002131 File Offset: 0x00000331
		public virtual string GetHtml()
		{
			return null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00003918 File Offset: 0x00001B18
		public virtual RectangleF? GetElementRectangle(string elementId)
		{
			return null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002134 File Offset: 0x00000334
		public void ClearSelection()
		{
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002131 File Offset: 0x00000331
		public string ColorToHtml(Color color)
		{
			return null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002131 File Offset: 0x00000331
		private string method_0(Color color)
		{
			return null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00002131 File Offset: 0x00000331
		protected override CreateParams CreateParams
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLayout(LayoutEventArgs levent)
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseMove(MouseEventArgs e)
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDoubleClick(MouseEventArgs e)
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnBorderStyleChanged(EventArgs e)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnLoadComplete(EventArgs e)
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnLinkClicked(HtmlLinkClickedEventArgs e)
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnRenderError(HtmlRenderErrorEventArgs e)
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnStylesheetLoad(HtmlStylesheetLoadEventArgs e)
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnImageLoad(HtmlImageLoadEventArgs e)
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnRefresh(HtmlRefreshEventArgs e)
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002134 File Offset: 0x00000334
		[DebuggerStepThrough]
		protected override void WndProc(ref Message m)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, HtmlLinkClickedEventArgs e)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender, HtmlRenderErrorEventArgs e)
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(object sender, HtmlStylesheetLoadEventArgs e)
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(object sender, HtmlImageLoadEventArgs e)
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7(object sender, HtmlRefreshEventArgs e)
		{
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public override bool AllowDrop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x000038B8 File Offset: 0x00001AB8
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public override RightToLeft RightToLeft
		{
			get
			{
				return RightToLeft.No;
			}
			set
			{
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public override Cursor Cursor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public new bool UseWaitCursor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x040000ED RID: 237
		protected HtmlContainer _htmlContainer;

		// Token: 0x040000EE RID: 238
		protected BorderStyle _borderStyle;

		// Token: 0x040000EF RID: 239
		protected string _baseRawCssData;

		// Token: 0x040000F0 RID: 240
		protected CssData _baseCssData;

		// Token: 0x040000F1 RID: 241
		protected string _text;

		// Token: 0x040000F2 RID: 242
		protected bool _autoSizeHight;

		// Token: 0x040000F3 RID: 243
		protected bool _useSystemCursors;

		// Token: 0x040000F4 RID: 244
		protected TextRenderingHint _textRenderingHint;

		// Token: 0x040000F5 RID: 245
		private bool bool_0;

		// Token: 0x040000FC RID: 252
		private ContentAlignment contentAlignment_0;
	}
}
