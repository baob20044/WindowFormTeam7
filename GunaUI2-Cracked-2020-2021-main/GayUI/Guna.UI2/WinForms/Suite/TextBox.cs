using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.Material.Animation;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;
using ns0;
using ns2;

namespace Guna.UI2.WinForms.Suite
{
	// Token: 0x020000BF RID: 191
	[DefaultEvent("TextChanged")]
	[ToolboxItem(false)]
	public class TextBox : UserControl, IControl
	{
		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value that indicates whether the Component is currently in design mode.")]
		[Browsable(false)]
		public bool IsDesignMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Description("Style the control's border sides.")]
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

		// Token: 0x06000FBA RID: 4026 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00002134 File Offset: 0x00000334
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00002134 File Offset: 0x00000334
		private void method_0()
		{
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1()
		{
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2(object sender)
		{
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3(object sender)
		{
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06000FC2 RID: 4034 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000FC3 RID: 4035 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Occurs when the property 'Text' changes.")]
		[Browsable(true)]
		public new event EventHandler TextChanged
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

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected new virtual void OnTextChanged(EventArgs e)
		{
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06000FC5 RID: 4037 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000FC6 RID: 4038 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler IconLeftClick
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

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnIconLeftClick(EventArgs e)
		{
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06000FC8 RID: 4040 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06000FC9 RID: 4041 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler IconRightClick
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

		// Token: 0x06000FCA RID: 4042 RVA: 0x00002134 File Offset: 0x00000334
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnIconRightClick(EventArgs e)
		{
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnClick(EventArgs e)
		{
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected TextBoxState DefaultHoverState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected TextBoxState DefaultFocusedState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00002131 File Offset: 0x00000331
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected TextBoxState DefaultDisabledState
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00003978 File Offset: 0x00001B78
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected TextBoxStyle DefaultStyle
		{
			get
			{
				return TextBoxStyle.Default;
			}
			set
			{
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected string DefaultPlaceholderText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultPlaceholderForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultBorderRadius
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected DashStyle DefaultBorderStyle
		{
			get
			{
				return DashStyle.Solid;
			}
			set
			{
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Color DefaultBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected int DefaultBorderThickness
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		protected ShadowDecoration DefaultShadowDecoration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Image DefaultIconLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Size DefaultIconLeftSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Cursor DefaultIconLeftCursor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Point DefaultIconLeftOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Image DefaultIconRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x00003364 File Offset: 0x00001564
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Size DefaultIconRightSize
		{
			get
			{
				return default(Size);
			}
			set
			{
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Cursor DefaultIconRightCursor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		protected Point DefaultIconRightOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		[Description("Gets or sets the text associated with this control.")]
		public new string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
		[Description("Sets the text input.")]
		[DisplayName("Text")]
		public virtual string DefaultText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00002136 File Offset: 0x00000336
		private bool method_4(Point e)
		{
			return false;
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00002136 File Offset: 0x00000336
		private bool method_5(Point e)
		{
			return false;
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseMove(MouseEventArgs e)
		{
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00002134 File Offset: 0x00000334
		private void method_6(MouseState m, MouseState m2)
		{
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00002134 File Offset: 0x00000334
		private void method_7(bool m, bool m2)
		{
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00002134 File Offset: 0x00000334
		public void AppendText(string text)
		{
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00002134 File Offset: 0x00000334
		public void Clear()
		{
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00002134 File Offset: 0x00000334
		public void ClearUndo()
		{
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00002134 File Offset: 0x00000334
		public void Cut()
		{
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00002134 File Offset: 0x00000334
		public void DeselectAll()
		{
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00002134 File Offset: 0x00000334
		public void SelectAll()
		{
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00002134 File Offset: 0x00000334
		public void Paste()
		{
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00002134 File Offset: 0x00000334
		public new void Focus()
		{
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00002134 File Offset: 0x00000334
		public new void Select()
		{
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00002134 File Offset: 0x00000334
		public override void ResetText()
		{
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00002134 File Offset: 0x00000334
		public void ScrollToCaret()
		{
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00002134 File Offset: 0x00000334
		public void Select(int start, int length)
		{
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00002131 File Offset: 0x00000331
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00002134 File Offset: 0x00000334
		public void Undo()
		{
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(false)]
		[Category("Behavior")]
		[Browsable(true)]
		[Description("Gets or sets a value indicating whether pressing ENTER in a multiline TextBox control creates a new line of text in the control or activates the default button for the form.")]
		public bool AcceptsReturn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(false)]
		[Category("Behavior")]
		[Description("Gets or sets a value indicating whether pressing the TAB key in a multiline text box control types a TAB character in the control instead of moving the focus to the next control in the tab order.")]
		public bool AcceptsTab
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x00002134 File Offset: 0x00000334
		[Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
		[Description("Gets or sets a custom System.Collections.Specialized.StringCollection to use when the AutoCompleteSource property is set to CustomSource.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public AutoCompleteStringCollection AutoCompleteCustomSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x00003B3C File Offset: 0x00001D3C
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets an option that controls how automatic completion works for the TextBox.")]
		[DefaultValue(AutoCompleteMode.None)]
		[Browsable(true)]
		public AutoCompleteMode AutoCompleteMode
		{
			get
			{
				return AutoCompleteMode.None;
			}
			set
			{
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00003B54 File Offset: 0x00001D54
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(AutoCompleteSource.None)]
		[Description("Gets or sets a value specifying the source of complete strings used for automatic completion.")]
		[Browsable(true)]
		public AutoCompleteSource AutoCompleteSource
		{
			get
			{
				return (AutoCompleteSource)0;
			}
			set
			{
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value indicating whether the user can undo the previous operation in a text box control.")]
		[Browsable(false)]
		public bool CanUndo
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x0600101C RID: 4124 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(typeof(Color), "125, 137, 149")]
		[Description("Sets the TextBox's foreground color.")]
		[Browsable(true)]
		[Category("Options")]
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

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x00003B6C File Offset: 0x00001D6C
		// (set) Token: 0x0600101E RID: 4126 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(CharacterCasing.Normal)]
		[Description("Gets or sets whether the TextBox control modifies the case of characters as they are typed.")]
		[Browsable(true)]
		[Category("Behavior")]
		public CharacterCasing CharacterCasing
		{
			get
			{
				return CharacterCasing.Normal;
			}
			set
			{
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001020 RID: 4128 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets the font of the text displayed by the control.")]
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

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x00002136 File Offset: 0x00000336
		[Description("Gets a value indicating whether the control has input focus")]
		public new bool Focused
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(true)]
		[Description("Gets or sets a value indicating whether the selected text in the text box control remains highlighted when the control loses focus.")]
		[Category("Behavior")]
		public bool HideSelection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Appearance")]
		[Editor("System.Windows.Forms.Design.StringArrayEditor, System.Design, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
		[Description("Gets or sets the lines of text in a text box control.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MergableProperty(false)]
		[Localizable(true)]
		[Browsable(true)]
		public string[] Lines
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Behavior")]
		[DefaultValue(32767)]
		[Browsable(true)]
		[Description("Gets or sets the maximum number of characters the user can type or paste into the text box control.")]
		public int MaxLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Category("Behavior")]
		[Description("Gets or sets a value that indicates that the text box control has been modified by the user since the control was created or its contents were last set.")]
		[DefaultValue(false)]
		public bool Modified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Behavior")]
		[Description("Gets or sets a value indicating whether this is a multiline TextBox control.")]
		[Browsable(true)]
		[DefaultValue(false)]
		public bool Multiline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Behavior")]
		[Browsable(true)]
		[Description("Gets or sets the character used to mask characters of a password in a single-line TextBox control.")]
		public char PasswordChar
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x00002136 File Offset: 0x00000336
		[Category("Behavior")]
		[Description("Gets the preferred height for a text box.")]
		[Browsable(false)]
		public int PreferredHeight
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Behavior")]
		[DefaultValue(false)]
		[Description("Gets or sets a value indicating whether text in the text box is read-only.")]
		[Browsable(true)]
		public bool ReadOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Category("Behavior")]
		[Description("Gets or sets a value indicating the currently selected text in the control.")]
		public string SelectedText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets the number of characters selected in the text box.")]
		[Browsable(true)]
		[Category("Behavior")]
		[DefaultValue(0)]
		public int SelectionLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(0)]
		[Browsable(true)]
		[Description("Gets or sets the starting point of text selected in the text box.")]
		[Category("Behavior")]
		public int SelectionStart
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Gets or sets a value indicating whether the defined shortcuts are enabled.")]
		[Browsable(true)]
		[Category("Behavior")]
		[DefaultValue(true)]
		public bool ShortcutsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[Description("Gets or sets how text is aligned in a TextBox control.")]
		[DefaultValue(HorizontalAlignment.Left)]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return HorizontalAlignment.Left;
			}
			set
			{
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x00002136 File Offset: 0x00000336
		[Category("Behavior")]
		[Description("Gets the length of text in the control.")]
		[Browsable(false)]
		public int TextLength
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(true)]
		[DefaultValue(false)]
		[Category("Behavior")]
		[Description("Gets or sets a value indicating whether the text in the TextBox control should appear as the default password character.")]
		public bool UseSystemPasswordChar
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Behavior")]
		[DefaultValue(true)]
		[Description("Indicates whether a multiline text box control automatically wraps words to the beginning of the next line when necessary.")]
		[Browsable(true)]
		public bool WordWrap
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00002134 File Offset: 0x00000334
		protected void UpdateBaseTextBoxPosition()
		{
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00002134 File Offset: 0x00000334
		private void method_8()
		{
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00002134 File Offset: 0x00000334
		private void method_9(Graphics G)
		{
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00002134 File Offset: 0x00000334
		private void method_10(object sender, EventArgs e)
		{
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00002134 File Offset: 0x00000334
		private void method_11(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00002134 File Offset: 0x00000334
		private void method_12(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00002134 File Offset: 0x00000334
		private void method_13(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00002134 File Offset: 0x00000334
		private void method_14(object sender, EventArgs e)
		{
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00002134 File Offset: 0x00000334
		private void method_15(object sender, EventArgs e)
		{
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00002134 File Offset: 0x00000334
		private void method_16(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00002134 File Offset: 0x00000334
		private void method_17(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00002134 File Offset: 0x00000334
		private void method_18(bool e)
		{
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00002134 File Offset: 0x00000334
		private void method_19(object sender, EventArgs e)
		{
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00002134 File Offset: 0x00000334
		private void method_20(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00002134 File Offset: 0x00000334
		private void method_21(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06001051 RID: 4177 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001052 RID: 4178 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06001053 RID: 4179 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001054 RID: 4180 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x06001055 RID: 4181 RVA: 0x00002134 File Offset: 0x00000334
		private void method_22(object sender, EventArgs e)
		{
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00002134 File Offset: 0x00000334
		private void method_23(object sender, EventArgs e)
		{
		}

		// Token: 0x0400045E RID: 1118
		private CustomizableEdges customizableEdges_0;

		// Token: 0x0400045F RID: 1119
		private Class0 class0_0;

		// Token: 0x04000460 RID: 1120
		private IContainer icontainer_0;

		// Token: 0x04000461 RID: 1121
		private Class12 class12_0;

		// Token: 0x04000462 RID: 1122
		private AnimationManager animationManager_0;

		// Token: 0x04000463 RID: 1123
		private AnimationManager animationManager_1;

		// Token: 0x04000467 RID: 1127
		private TextBoxState textBoxState_0;

		// Token: 0x04000468 RID: 1128
		private TextBoxState textBoxState_1;

		// Token: 0x04000469 RID: 1129
		private TextBoxState textBoxState_2;

		// Token: 0x0400046A RID: 1130
		private bool bool_0;

		// Token: 0x0400046B RID: 1131
		private TextBoxStyle textBoxStyle_0;

		// Token: 0x0400046C RID: 1132
		private Point point_0;

		// Token: 0x0400046D RID: 1133
		private int int_0;

		// Token: 0x0400046E RID: 1134
		private DashStyle dashStyle_0;

		// Token: 0x0400046F RID: 1135
		private Color color_0;

		// Token: 0x04000470 RID: 1136
		private int int_1;

		// Token: 0x04000471 RID: 1137
		private ShadowDecoration shadowDecoration_0;

		// Token: 0x04000472 RID: 1138
		private Image image_0;

		// Token: 0x04000473 RID: 1139
		private Size size_0;

		// Token: 0x04000474 RID: 1140
		private Cursor cursor_0;

		// Token: 0x04000475 RID: 1141
		private Point point_1;

		// Token: 0x04000476 RID: 1142
		private Image image_1;

		// Token: 0x04000477 RID: 1143
		private Size size_1;

		// Token: 0x04000478 RID: 1144
		private Cursor cursor_1;

		// Token: 0x04000479 RID: 1145
		private Point point_2;

		// Token: 0x0400047A RID: 1146
		private Color color_1;

		// Token: 0x0400047B RID: 1147
		private Point point_3;

		// Token: 0x0400047C RID: 1148
		private bool bool_1;

		// Token: 0x0400047D RID: 1149
		internal MouseState mouseState_0;

		// Token: 0x0400047E RID: 1150
		private Padding padding_0;
	}
}
