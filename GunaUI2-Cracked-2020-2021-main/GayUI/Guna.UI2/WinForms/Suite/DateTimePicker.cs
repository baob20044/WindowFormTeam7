using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.Material.Animation;
using Guna.UI2.WinForms.Enums;
using ns0;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000AB RID: 171
	[ToolboxItem(false)]
	[DefaultEvent("ValueChanged")]
	public class DateTimePicker : UIDefaultControl
	{
		// Token: 0x06000CF3 RID: 3315 RVA: 0x00002134 File Offset: 0x00000334
		public void PerformClick()
		{
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00002134 File Offset: 0x00000334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("Style the control's border sides.")]
		[Browsable(true)]
		public CustomizableEdges CustomizableEdges
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender)
		{
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender)
		{
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000CFA RID: 3322 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000CFB RID: 3323 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler CheckedChanged
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

		// Token: 0x06000CFC RID: 3324 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnCheckedChanged(EventArgs e)
		{
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected DateTimePickerState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected DateTimePickerState DefaultCheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultFocusedColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Point DefaultTextOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected HorizontalAlignment DefaultTextAlign
		{
			get
			{
				return HorizontalAlignment.Left;
			}
			set
			{
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected TextRenderingHint DefaultTextRenderingHint
		{
			get
			{
				return TextRenderingHint.SystemDefault;
			}
			set
			{
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected TextTransform DefaultTextTransform
		{
			get
			{
				return TextTransform.None;
			}
			set
			{
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultAnimated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected bool DefaultChecked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00002134 File Offset: 0x00000334
		protected bool DefaultIndicateFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseMove(MouseEventArgs e)
		{
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnKeyDown(KeyEventArgs kevent)
		{
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00002131 File Offset: 0x00000331
		private Image method_4()
		{
			return null;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_5()
		{
			return default(Color);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_6()
		{
			return default(Color);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_7()
		{
			return default(Color);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_8()
		{
			return default(Color);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_9()
		{
			return default(Color);
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x000032EC File Offset: 0x000014EC
		private Color method_10()
		{
			return default(Color);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00002131 File Offset: 0x00000331
		private Bitmap method_11(Color color)
		{
			return null;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00002134 File Offset: 0x00000334
		private void method_12(Graphics G)
		{
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00002134 File Offset: 0x00000334
		private void method_13()
		{
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x00002134 File Offset: 0x00000334
		[Localizable(true)]
		[RefreshProperties(RefreshProperties.Repaint)]
		[DefaultValue(null)]
		public string CustomFormat
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x00003AF4 File Offset: 0x00001CF4
		// (set) Token: 0x06000D28 RID: 3368 RVA: 0x00002134 File Offset: 0x00000334
		[RefreshProperties(RefreshProperties.Repaint)]
		public DateTimePickerFormat Format
		{
			get
			{
				return (DateTimePickerFormat)0;
			}
			set
			{
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x00003B0C File Offset: 0x00001D0C
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x00002134 File Offset: 0x00000334
		public DateTime MaxDate
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00003B0C File Offset: 0x00001D0C
		public static DateTime MaximumDateTime
		{
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00003B0C File Offset: 0x00001D0C
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x00002134 File Offset: 0x00000334
		public DateTime MinDate
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x00003B0C File Offset: 0x00001D0C
		public static DateTime MinimumDateTime
		{
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00002136 File Offset: 0x00000336
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int PreferredHeight
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(false)]
		public bool ShowCheckBox
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[DefaultValue(false)]
		public bool ShowUpDown
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
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

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x00003B0C File Offset: 0x00001D0C
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x00002134 File Offset: 0x00000334
		[Bindable(true)]
		[RefreshProperties(RefreshProperties.All)]
		public DateTime Value
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00002134 File Offset: 0x00000334
		private void method_14()
		{
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000D3A RID: 3386 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000D3B RID: 3387 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06000D3C RID: 3388 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnValueChanged(EventArgs e)
		{
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000D3D RID: 3389 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000D3E RID: 3390 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler FormatChanged
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

		// Token: 0x06000D3F RID: 3391 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnFormatChanged(EventArgs e)
		{
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000D40 RID: 3392 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000D41 RID: 3393 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler DropDown
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

		// Token: 0x06000D42 RID: 3394 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnDropDown(EventArgs e)
		{
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000D43 RID: 3395 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000D44 RID: 3396 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler CloseUp
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

		// Token: 0x06000D45 RID: 3397 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnCloseUp(EventArgs e)
		{
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00002134 File Offset: 0x00000334
		private void method_15(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00002134 File Offset: 0x00000334
		private void method_16(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00002134 File Offset: 0x00000334
		private void method_17(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00002134 File Offset: 0x00000334
		private void method_18(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnClick(EventArgs e)
		{
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00002134 File Offset: 0x00000334
		private void method_19(object sender, EventArgs e)
		{
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000D4C RID: 3404 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000D4D RID: 3405 RVA: 0x00002134 File Offset: 0x00000334
		public new event EventHandler LostFocus
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

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06000D4E RID: 3406 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000D4F RID: 3407 RVA: 0x00002134 File Offset: 0x00000334
		public new event EventHandler GotFocus
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

		// Token: 0x06000D50 RID: 3408 RVA: 0x00002134 File Offset: 0x00000334
		private void method_20(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00002134 File Offset: 0x00000334
		private void method_21(object sender, EventArgs e)
		{
		}

		// Token: 0x04000345 RID: 837
		private CustomizableEdges customizableEdges_0;

		// Token: 0x04000346 RID: 838
		private AnimationManager animationManager_0;

		// Token: 0x04000347 RID: 839
		private Timer timer_0;

		// Token: 0x04000348 RID: 840
		private IContainer icontainer_0;

		// Token: 0x04000349 RID: 841
		private Class0 class0_0;

		// Token: 0x0400034A RID: 842
		private AnimationManager animationManager_1;

		// Token: 0x0400034C RID: 844
		private DateTimePickerState dateTimePickerState_0;

		// Token: 0x0400034D RID: 845
		private DateTimePickerState dateTimePickerState_1;

		// Token: 0x0400034E RID: 846
		private Color color_1;

		// Token: 0x0400034F RID: 847
		private Point point_0;

		// Token: 0x04000350 RID: 848
		private HorizontalAlignment horizontalAlignment_0;

		// Token: 0x04000351 RID: 849
		private TextRenderingHint textRenderingHint_0;

		// Token: 0x04000352 RID: 850
		private TextTransform textTransform_0;

		// Token: 0x04000353 RID: 851
		private bool bool_5;

		// Token: 0x04000354 RID: 852
		private bool bool_6;

		// Token: 0x04000355 RID: 853
		private Color color_2;

		// Token: 0x04000356 RID: 854
		private bool bool_7;

		// Token: 0x04000357 RID: 855
		private Point point_1;

		// Token: 0x04000358 RID: 856
		private Image image_0;

		// Token: 0x04000359 RID: 857
		private GraphicsPath graphicsPath_0;

		// Token: 0x0400035A RID: 858
		private DateTimePicker dateTimePicker_0;
	}
}
