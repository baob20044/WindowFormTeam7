using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;

namespace Guna.UI2.WinForms
{
	// Token: 0x02000071 RID: 113
	[ToolboxItem(true)]
	[DebuggerStepThrough]
	[Description("A textbox control")]
	[ToolboxBitmap(typeof(System.Windows.Forms.TextBox))]
	[Designer(typeof(Guna2TextBoxDesigner))]
	public class Guna2TextBox : Guna.UI2.WinForms.Suite.TextBox
	{
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("If true, the border on the control is rounded off automatically")]
		[DefaultValue(false)]
		public bool AutoRoundedCorners
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00002134 File Offset: 0x00000334
		private void method_24()
		{
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x00002131 File Offset: 0x00000331
		[Description("The properties that will be applied when the cursor is over the control")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public TextBoxState HoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00002131 File Offset: 0x00000331
		[Description("The properties that will be applied when the control is focused")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public TextBoxState FocusedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x00002131 File Offset: 0x00000331
		[Description("The properties that will be applied when the cursor is in a disabled state")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public TextBoxState DisabledState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00003978 File Offset: 0x00001B78
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Gets or Sets the style of the textbox")]
		[DefaultValue(TextBoxStyle.Default)]
		public TextBoxStyle Style
		{
			get
			{
				return TextBoxStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("If true, the control will be animated while interacting with the mouse")]
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

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The control's text position")]
		[DefaultValue(typeof(Point), "0, 0")]
		public Point TextOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Options")]
		[Browsable(true)]
		[Description("The control's placeholder text")]
		public string PlaceholderText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "193, 200, 207")]
		[Description("The control's placeholder text ForeColor")]
		[Browsable(true)]
		public Color PlaceholderForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(0)]
		[Description("Sets the TextBox's border radius.")]
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

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("The control's css-like border style")]
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

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "213, 218, 223")]
		[Browsable(true)]
		[Description("Gets or sets the control border color.")]
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

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(1)]
		[Browsable(true)]
		[Description("Gets or sets the control border size.")]
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

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Shadow property of the control to add and customize a control's shadow")]
		[Browsable(true)]
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

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Sets the TextBox's left icon.")]
		[Browsable(true)]
		[DefaultValue(typeof(Image), "")]
		public Image IconLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Size), "20, 20")]
		[Description("Sets TextBox's left icon size.")]
		[Browsable(true)]
		public Size IconLeftSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Cursor), "Default")]
		[Browsable(true)]
		[Description("Sets TextBox's left icon cursor.")]
		public Cursor IconLeftCursor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Point), "0, 0")]
		[Description("Sets TextBox's left icon offset (Point).")]
		[Browsable(true)]
		public Point IconLeftOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Sets the TextBox's right icon.")]
		[DefaultValue(typeof(Image), "")]
		public Image IconRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Sets TextBox's right icon size.")]
		[DefaultValue(typeof(Size), "20, 20")]
		[Browsable(true)]
		public Size IconRightSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Sets TextBox's right icon cursor.")]
		[DefaultValue(typeof(Cursor), "Default")]
		public Cursor IconRightCursor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Point), "0, 0")]
		[Browsable(true)]
		[Description("Sets TextBox's right icon offset (Point).")]
		public Point IconRightOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "White")]
		[Browsable(true)]
		[Description("Sets the TextBox's fill color or inner-background color.")]
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

		// Token: 0x060008B0 RID: 2224 RVA: 0x00002134 File Offset: 0x00000334
		private void method_25()
		{
		}

		// Token: 0x040001C3 RID: 451
		private bool bool_2;

		// Token: 0x040001C4 RID: 452
		private int int_2;
	}
}
