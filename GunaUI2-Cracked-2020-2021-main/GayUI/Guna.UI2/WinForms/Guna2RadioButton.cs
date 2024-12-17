using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Suite;
using ns0;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000042 RID: 66
	[ToolboxBitmap(typeof(RadioButton))]
	[Description("Guna RadioButton Control")]
	[Designer(typeof(Guna2RadioButtonDesigner))]
	public class Guna2RadioButton : RadioButton
	{
		// Token: 0x060003B6 RID: 950 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x000038B8 File Offset: 0x00001AB8
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(RightToLeft.No)]
		[Description("Gets or sets value indicating whether control's elements are aligned to support locales using right-to-left fonts.")]
		public new RightToLeft RightToLeft
		{
			get
			{
				return RightToLeft.No;
			}
			set
			{
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0000346C File Offset: 0x0000166C
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(5)]
		[Description("This property allows you to change how text is printed onto the control")]
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

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00002134 File Offset: 0x00000334
		[Description("If true, the control will be animated while interacting with the mouse")]
		[Browsable(true)]
		[DefaultValue(false)]
		public bool Animated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00002131 File Offset: 0x00000331
		[Description("The properties that will be applied when the control is in a checked state")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		public CustomRadionButtonState CheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(true)]
		[Description("The properties that will be applied when the control is in an unchecked state")]
		public CustomRadionButtonState UncheckedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The css-like style of the border. You can customize the border to meet your design needs")]
		[DefaultValue(DashStyle.Solid)]
		[Browsable(true)]
		public DashStyle BorderStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnCheckedChanged(EventArgs e)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2()
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs pevent)
		{
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060003C8 RID: 968 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060003C9 RID: 969 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060003CA RID: 970 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060003CB RID: 971 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x060003CC RID: 972 RVA: 0x00002134 File Offset: 0x00000334
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002134 File Offset: 0x00000334
		private void method_5(object sender, EventArgs e)
		{
		}

		// Token: 0x040000D9 RID: 217
		private Guna2CustomRadioButton guna2CustomRadioButton_0;

		// Token: 0x040000DA RID: 218
		private IContainer icontainer_0;

		// Token: 0x040000DB RID: 219
		private Class0 class0_0;

		// Token: 0x040000DC RID: 220
		private TextRenderingHint textRenderingHint_0;
	}
}
