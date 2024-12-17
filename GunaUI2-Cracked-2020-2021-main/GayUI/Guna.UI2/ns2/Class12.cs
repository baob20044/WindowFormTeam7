using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Internal;

namespace ns2
{
	// Token: 0x020000C7 RID: 199
	[ToolboxItem(false)]
	internal class Class12 : TextBox
	{
		// Token: 0x14000045 RID: 69
		// (add) Token: 0x060010E8 RID: 4328 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060010E9 RID: 4329 RVA: 0x00002134 File Offset: 0x00000334
		public event Class12.FocusChangedEventHandler Event_0
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

		// Token: 0x060010EA RID: 4330 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnFocusChanged(bool e)
		{
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnLostFocus(EventArgs e)
		{
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x00002134 File Offset: 0x00000334
		public HorizontalAlignment HorizontalAlignment_0
		{
			get
			{
				return HorizontalAlignment.Left;
			}
			set
			{
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnRightToLeftChanged(EventArgs e)
		{
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public bool Boolean_0
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The placeholder associated with the control.")]
		[DefaultValue("Enter Text")]
		[Category("Placeholder")]
		public string String_0
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x00002134 File Offset: 0x00000334
		[Category("Appearance")]
		[DefaultValue(typeof(Color), "InactiveCaption")]
		[Description("The foreground color of this component, which is used to display the placeholder.")]
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

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x00002134 File Offset: 0x00000334
		[Description("The foreground color of this component, which is used to display text.")]
		[DefaultValue(typeof(Color), "WindowText")]
		[Category("Appearance")]
		public Color Color_1
		{
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x000032EC File Offset: 0x000014EC
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x00002134 File Offset: 0x00000334
		[Browsable(false)]
		public override Color ForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x00002136 File Offset: 0x00000336
		public override int TextLength
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06001100 RID: 4352 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x06001101 RID: 4353 RVA: 0x00002134 File Offset: 0x00000334
		[Description("Occurs when the value of the IsPlaceholderInside property has changed.")]
		public event EventHandler<PlaceholderActiveChangedEventArgs> Event_1
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

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x00002134 File Offset: 0x00000334
		public char Char_0
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x00002134 File Offset: 0x00000334
		public bool Boolean_1
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00002134 File Offset: 0x00000334
		public void method_0()
		{
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00002134 File Offset: 0x00000334
		private void method_1(Guna.UI2.WinForms.Internal.Action act)
		{
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x00002134 File Offset: 0x00000334
		[DefaultValue(32767)]
		public int Int32_0
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00002134 File Offset: 0x00000334
		private void method_2()
		{
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnCreateControl()
		{
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnTextChanged(EventArgs e)
		{
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00002134 File Offset: 0x00000334
		protected override void WndProc(ref Message m)
		{
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnKeyDown(KeyEventArgs e)
		{
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00002134 File Offset: 0x00000334
		protected virtual void OnPlaceholderActiveChanged(bool newValue)
		{
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00002134 File Offset: 0x00000334
		protected override void OnGotFocus(EventArgs e)
		{
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00002134 File Offset: 0x00000334
		private void method_3()
		{
		}

		// Token: 0x040004BA RID: 1210
		[CompilerGenerated]
		private Class12.FocusChangedEventHandler FocusChanged;

		// Token: 0x040004BB RID: 1211
		private bool bool_0;

		// Token: 0x040004BC RID: 1212
		internal MouseState mouseState_0;

		// Token: 0x040004BD RID: 1213
		private string string_0;

		// Token: 0x040004BE RID: 1214
		private bool bool_1;

		// Token: 0x040004BF RID: 1215
		private Color color_0;

		// Token: 0x040004C0 RID: 1216
		[CompilerGenerated]
		private Color color_1;

		// Token: 0x040004C1 RID: 1217
		[CompilerGenerated]
		private EventHandler<PlaceholderActiveChangedEventArgs> PlaceholderActiveChanged;

		// Token: 0x040004C2 RID: 1218
		private char char_0;

		// Token: 0x040004C3 RID: 1219
		public bool bool_2;

		// Token: 0x040004C4 RID: 1220
		private const string string_1 = "Enter Text";

		// Token: 0x040004C5 RID: 1221
		private const int int_0 = 177;

		// Token: 0x040004C6 RID: 1222
		private bool bool_3;

		// Token: 0x040004C7 RID: 1223
		private int int_1;

		// Token: 0x040004C8 RID: 1224
		private bool bool_4;

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x06001115 RID: 4373
		public delegate void FocusChangedEventHandler(bool e);
	}
}
