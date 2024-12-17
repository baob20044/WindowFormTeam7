using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.HtmlRenderer.Adapters.Entities;
using Guna.UI2.HtmlRenderer.Core;
using Guna.UI2.HtmlRenderer.Core.Entities;

namespace Guna.UI2.HtmlRenderer.WinForms
{
	// Token: 0x020000FB RID: 251
	public sealed class HtmlContainer : IDisposable
	{
		// Token: 0x1400004C RID: 76
		// (add) Token: 0x0600119E RID: 4510 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x0600119F RID: 4511 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler LoadComplete
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x060011A0 RID: 4512 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060011A1 RID: 4513 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlLinkClickedEventArgs> LinkClicked
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x060011A2 RID: 4514 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060011A3 RID: 4515 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlRefreshEventArgs> Refresh
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x060011A4 RID: 4516 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060011A5 RID: 4517 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlScrollEventArgs> ScrollChange
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x060011A6 RID: 4518 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060011A7 RID: 4519 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlRenderErrorEventArgs> RenderError
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x060011A8 RID: 4520 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060011A9 RID: 4521 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlStylesheetLoadEventArgs> StylesheetLoad
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x060011AA RID: 4522 RVA: 0x00002134 File Offset: 0x00000334
		// (remove) Token: 0x060011AB RID: 4523 RVA: 0x00002134 File Offset: 0x00000334
		public event EventHandler<HtmlImageLoadEventArgs> ImageLoad
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00002131 File Offset: 0x00000331
		public HtmlContainerInt HtmlContainerInt
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x00002134 File Offset: 0x00000334
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

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x00002131 File Offset: 0x00000331
		public CssData CssData
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x00002134 File Offset: 0x00000334
		public bool AvoidGeometryAntialias
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x00002134 File Offset: 0x00000334
		public bool AvoidAsyncImagesLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x00002134 File Offset: 0x00000334
		public bool AvoidImagesLateLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x00002134 File Offset: 0x00000334
		public bool IsSelectionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x00002134 File Offset: 0x00000334
		public bool IsContextMenuEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x0000337C File Offset: 0x0000157C
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x00002134 File Offset: 0x00000334
		public Point ScrollOffset
		{
			get
			{
				return default(Point);
			}
			set
			{
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x00003BB4 File Offset: 0x00001DB4
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x00002134 File Offset: 0x00000334
		public PointF Location
		{
			get
			{
				return default(PointF);
			}
			set
			{
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x00003BCC File Offset: 0x00001DCC
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x00002134 File Offset: 0x00000334
		public SizeF MaxSize
		{
			get
			{
				return default(SizeF);
			}
			set
			{
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00003BCC File Offset: 0x00001DCC
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x00002134 File Offset: 0x00000334
		public SizeF ActualSize
		{
			get
			{
				return default(SizeF);
			}
			internal set
			{
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00002131 File Offset: 0x00000331
		public string SelectedText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x00002131 File Offset: 0x00000331
		public string SelectedHtml
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00002134 File Offset: 0x00000334
		public void ClearSelection()
		{
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00002134 File Offset: 0x00000334
		public void SetHtml(string htmlSource, CssData baseCssData = null)
		{
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00002131 File Offset: 0x00000331
		public string GetHtml(HtmlGenerationStyle styleGen = HtmlGenerationStyle.Inline)
		{
			return null;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00002131 File Offset: 0x00000331
		public string GetAttributeAt(Point location, string attribute)
		{
			return null;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00002131 File Offset: 0x00000331
		public List<LinkElementData<RectangleF>> GetLinks()
		{
			return null;
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00002131 File Offset: 0x00000331
		public string GetLinkAt(Point location)
		{
			return null;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00003918 File Offset: 0x00001B18
		public RectangleF? GetElementRectangle(string elementId)
		{
			return null;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00002134 File Offset: 0x00000334
		public void PerformLayout(Graphics g)
		{
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00002134 File Offset: 0x00000334
		public void PerformPaint(Graphics g)
		{
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00002134 File Offset: 0x00000334
		public void HandleMouseDown(Control parent, MouseEventArgs e)
		{
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00002134 File Offset: 0x00000334
		public void HandleMouseUp(Control parent, MouseEventArgs e)
		{
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00002134 File Offset: 0x00000334
		public void HandleMouseDoubleClick(Control parent, MouseEventArgs e)
		{
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00002134 File Offset: 0x00000334
		public void HandleMouseMove(Control parent, MouseEventArgs e)
		{
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00002134 File Offset: 0x00000334
		public void HandleMouseLeave(Control parent)
		{
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00002134 File Offset: 0x00000334
		public void HandleKeyDown(Control parent, KeyEventArgs e)
		{
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00002134 File Offset: 0x00000334
		public void Dispose()
		{
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00002131 File Offset: 0x00000331
		private static RMouseEvent smethod_0(MouseEventArgs e)
		{
			return null;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00002131 File Offset: 0x00000331
		private static RKeyEvent smethod_1(KeyEventArgs e)
		{
			return null;
		}

		// Token: 0x040006A4 RID: 1700
		private readonly HtmlContainerInt htmlContainerInt_0;

		// Token: 0x040006A5 RID: 1701
		private bool bool_0;
	}
}
