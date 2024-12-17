using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;

namespace Guna.UI2.Native
{
	// Token: 0x020000E0 RID: 224
	[SuppressUnmanagedCodeSecurity]
	public static class WinApi
	{
		// Token: 0x06001143 RID: 4419
		[DllImport("Gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06001144 RID: 4420
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

		// Token: 0x06001145 RID: 4421
		[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern WinApi.Bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref WinApi.POINT pptDst, ref WinApi.SIZE psize, IntPtr hdcSrc, ref WinApi.POINT pprSrc, int crKey, ref WinApi.BLENDFUNCTION pblend, int dwFlags);

		// Token: 0x06001146 RID: 4422
		[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetDC(IntPtr hWnd);

		// Token: 0x06001147 RID: 4423
		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

		// Token: 0x06001148 RID: 4424
		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern WinApi.Bool DeleteDC(IntPtr hdc);

		// Token: 0x06001149 RID: 4425
		[DllImport("gdi32.dll", ExactSpelling = true)]
		public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

		// Token: 0x0600114A RID: 4426
		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern WinApi.Bool DeleteObject(IntPtr hObject);

		// Token: 0x0600114B RID: 4427
		[DllImport("user32.dll", SetLastError = true)]
		public static extern uint GetWindowLong(IntPtr hWnd, int nIndex);

		// Token: 0x0600114C RID: 4428
		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

		// Token: 0x0600114D RID: 4429
		[DllImport("user32.dll")]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int W, int H, uint uFlags);

		// Token: 0x0600114E RID: 4430
		[DllImport("user32.dll")]
		public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

		// Token: 0x0600114F RID: 4431
		[DllImport("user32.dll")]
		public static extern int GetMenuItemCount(IntPtr hMenu);

		// Token: 0x06001150 RID: 4432
		[DllImport("user32.dll")]
		public static extern bool DrawMenuBar(IntPtr hWnd);

		// Token: 0x06001151 RID: 4433
		[DllImport("user32.dll")]
		public static extern bool RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);

		// Token: 0x06001152 RID: 4434
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06001153 RID: 4435
		[DllImport("user32.dll")]
		public static extern IntPtr SetCapture(IntPtr hWnd);

		// Token: 0x06001154 RID: 4436
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06001155 RID: 4437
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr wnd, int msg, bool param, int lparam);

		// Token: 0x06001156 RID: 4438
		[DllImport("shell32.dll", SetLastError = true)]
		public static extern IntPtr SHAppBarMessage(WinApi.ABM dwMessage, [In] ref WinApi.APPBARDATA pData);

		// Token: 0x06001157 RID: 4439
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06001158 RID: 4440
		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		// Token: 0x06001159 RID: 4441
		[DllImport("user32.dll")]
		public static extern IntPtr GetDCEx(IntPtr hwnd, IntPtr hrgnclip, uint fdwOptions);

		// Token: 0x0600115A RID: 4442
		[DllImport("user32.dll")]
		public static extern bool ShowScrollBar(IntPtr hWnd, int bar, int cmd);

		// Token: 0x0600115B RID: 4443
		[DllImport("User32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetWindowDC(IntPtr handle);

		// Token: 0x0600115C RID: 4444
		[DllImport("User32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr ReleaseDC(IntPtr handle, IntPtr hDC);

		// Token: 0x0600115D RID: 4445
		[DllImport("User32.dll", CharSet = CharSet.Auto)]
		public static extern int GetClassName(IntPtr hwnd, char[] className, int maxCount);

		// Token: 0x0600115E RID: 4446
		[DllImport("User32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetWindow(IntPtr hwnd, int uCmd);

		// Token: 0x0600115F RID: 4447
		[DllImport("User32.dll", CharSet = CharSet.Auto)]
		public static extern bool IsWindowVisible(IntPtr hwnd);

		// Token: 0x06001160 RID: 4448
		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern int GetClientRect(IntPtr hwnd, ref WinApi.RECT lpRect);

		// Token: 0x06001161 RID: 4449
		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern int GetClientRect(IntPtr hwnd, [In] [Out] ref Rectangle rect);

		// Token: 0x06001162 RID: 4450
		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern bool MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		// Token: 0x06001163 RID: 4451
		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern bool UpdateWindow(IntPtr hwnd);

		// Token: 0x06001164 RID: 4452
		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern bool InvalidateRect(IntPtr hwnd, ref Rectangle rect, bool bErase);

		// Token: 0x06001165 RID: 4453
		[DllImport("user32", CharSet = CharSet.Auto)]
		public static extern bool ValidateRect(IntPtr hwnd, ref Rectangle rect);

		// Token: 0x06001166 RID: 4454
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern bool GetWindowRect(IntPtr hWnd, [In] [Out] ref Rectangle rect);

		// Token: 0x06001167 RID: 4455 RVA: 0x00002136 File Offset: 0x00000336
		public static int LoWord(int dwValue)
		{
			return 0;
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00002136 File Offset: 0x00000336
		public static int HiWord(int dwValue)
		{
			return 0;
		}

		// Token: 0x0400053A RID: 1338
		public const int Autohide = 1;

		// Token: 0x0400053B RID: 1339
		public const int AlwaysOnTop = 2;

		// Token: 0x0400053C RID: 1340
		public const int MfByposition = 1024;

		// Token: 0x0400053D RID: 1341
		public const int MfRemove = 4096;

		// Token: 0x0400053E RID: 1342
		public const int TCM_HITTEST = 4883;

		// Token: 0x0400053F RID: 1343
		public const int ULW_COLORKEY = 1;

		// Token: 0x04000540 RID: 1344
		public const int ULW_ALPHA = 2;

		// Token: 0x04000541 RID: 1345
		public const int ULW_OPAQUE = 4;

		// Token: 0x04000542 RID: 1346
		public const byte AC_SRC_OVER = 0;

		// Token: 0x04000543 RID: 1347
		public const byte AC_SRC_ALPHA = 1;

		// Token: 0x04000544 RID: 1348
		public const int GW_HWNDFIRST = 0;

		// Token: 0x04000545 RID: 1349
		public const int GW_HWNDLAST = 1;

		// Token: 0x04000546 RID: 1350
		public const int GW_HWNDNEXT = 2;

		// Token: 0x04000547 RID: 1351
		public const int GW_HWNDPREV = 3;

		// Token: 0x04000548 RID: 1352
		public const int GW_OWNER = 4;

		// Token: 0x04000549 RID: 1353
		public const int GW_CHILD = 5;

		// Token: 0x0400054A RID: 1354
		public const int HC_ACTION = 0;

		// Token: 0x0400054B RID: 1355
		public const int WH_CALLWNDPROC = 4;

		// Token: 0x0400054C RID: 1356
		public const int GWL_WNDPROC = -4;

		// Token: 0x020000E1 RID: 225
		public struct POINT
		{
			// Token: 0x06001169 RID: 4457 RVA: 0x00002347 File Offset: 0x00000547
			public POINT(int x, int y)
			{
				this.x = x;
				this.y = y;
			}

			// Token: 0x0400054D RID: 1357
			public int x;

			// Token: 0x0400054E RID: 1358
			public int y;
		}

		// Token: 0x020000E2 RID: 226
		public struct SIZE
		{
			// Token: 0x0600116A RID: 4458 RVA: 0x00002357 File Offset: 0x00000557
			public SIZE(int cx, int cy)
			{
				this.cx = cx;
				this.cy = cy;
			}

			// Token: 0x0400054F RID: 1359
			public int cx;

			// Token: 0x04000550 RID: 1360
			public int cy;
		}

		// Token: 0x020000E3 RID: 227
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct ARGB
		{
			// Token: 0x04000551 RID: 1361
			public byte Blue;

			// Token: 0x04000552 RID: 1362
			public byte Green;

			// Token: 0x04000553 RID: 1363
			public byte Red;

			// Token: 0x04000554 RID: 1364
			public byte Alpha;
		}

		// Token: 0x020000E4 RID: 228
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct BLENDFUNCTION
		{
			// Token: 0x04000555 RID: 1365
			public byte BlendOp;

			// Token: 0x04000556 RID: 1366
			public byte BlendFlags;

			// Token: 0x04000557 RID: 1367
			public byte SourceConstantAlpha;

			// Token: 0x04000558 RID: 1368
			public byte AlphaFormat;
		}

		// Token: 0x020000E5 RID: 229
		public struct TCHITTESTINFO
		{
			// Token: 0x04000559 RID: 1369
			public Point pt;

			// Token: 0x0400055A RID: 1370
			public uint flags;
		}

		// Token: 0x020000E6 RID: 230
		public struct RECT
		{
			// Token: 0x0600116B RID: 4459 RVA: 0x00002367 File Offset: 0x00000567
			public RECT(Rectangle rc)
			{
				this.Left = rc.Left;
				this.Top = rc.Top;
				this.Right = rc.Right;
				this.Bottom = rc.Bottom;
			}

			// Token: 0x0600116C RID: 4460 RVA: 0x0000343C File Offset: 0x0000163C
			public Rectangle ToRectangle()
			{
				return default(Rectangle);
			}

			// Token: 0x0400055B RID: 1371
			public int Left;

			// Token: 0x0400055C RID: 1372
			public int Top;

			// Token: 0x0400055D RID: 1373
			public int Right;

			// Token: 0x0400055E RID: 1374
			public int Bottom;
		}

		// Token: 0x020000E7 RID: 231
		public struct NCCALCSIZE_PARAMS
		{
			// Token: 0x0400055F RID: 1375
			public WinApi.RECT rect0;

			// Token: 0x04000560 RID: 1376
			public WinApi.RECT rect1;

			// Token: 0x04000561 RID: 1377
			public WinApi.RECT rect2;

			// Token: 0x04000562 RID: 1378
			public IntPtr lppos;
		}

		// Token: 0x020000E8 RID: 232
		public struct MINMAXINFO
		{
			// Token: 0x04000563 RID: 1379
			public WinApi.POINT ptReserved;

			// Token: 0x04000564 RID: 1380
			public WinApi.POINT ptMaxSize;

			// Token: 0x04000565 RID: 1381
			public WinApi.POINT ptMaxPosition;

			// Token: 0x04000566 RID: 1382
			public WinApi.POINT ptMinTrackSize;

			// Token: 0x04000567 RID: 1383
			public WinApi.POINT ptMaxTrackSize;
		}

		// Token: 0x020000E9 RID: 233
		public struct APPBARDATA
		{
			// Token: 0x04000568 RID: 1384
			public uint cbSize;

			// Token: 0x04000569 RID: 1385
			public IntPtr hWnd;

			// Token: 0x0400056A RID: 1386
			public uint uCallbackMessage;

			// Token: 0x0400056B RID: 1387
			public WinApi.ABE uEdge;

			// Token: 0x0400056C RID: 1388
			public WinApi.RECT rc;

			// Token: 0x0400056D RID: 1389
			public int lParam;
		}

		// Token: 0x020000EA RID: 234
		public struct WindowPos
		{
			// Token: 0x0400056E RID: 1390
			public int hwnd;

			// Token: 0x0400056F RID: 1391
			public int hWndInsertAfter;

			// Token: 0x04000570 RID: 1392
			public int x;

			// Token: 0x04000571 RID: 1393
			public int y;

			// Token: 0x04000572 RID: 1394
			public int cx;

			// Token: 0x04000573 RID: 1395
			public int cy;

			// Token: 0x04000574 RID: 1396
			public int flags;
		}

		// Token: 0x020000EB RID: 235
		public enum ABM : uint
		{
			// Token: 0x04000576 RID: 1398
			New,
			// Token: 0x04000577 RID: 1399
			Remove,
			// Token: 0x04000578 RID: 1400
			QueryPos,
			// Token: 0x04000579 RID: 1401
			SetPos,
			// Token: 0x0400057A RID: 1402
			GetState,
			// Token: 0x0400057B RID: 1403
			GetTaskbarPos,
			// Token: 0x0400057C RID: 1404
			Activate,
			// Token: 0x0400057D RID: 1405
			GetAutoHideBar,
			// Token: 0x0400057E RID: 1406
			SetAutoHideBar,
			// Token: 0x0400057F RID: 1407
			WindowPosChanged,
			// Token: 0x04000580 RID: 1408
			SetState
		}

		// Token: 0x020000EC RID: 236
		public enum ABE : uint
		{
			// Token: 0x04000582 RID: 1410
			Left,
			// Token: 0x04000583 RID: 1411
			Top,
			// Token: 0x04000584 RID: 1412
			Right,
			// Token: 0x04000585 RID: 1413
			Bottom
		}

		// Token: 0x020000ED RID: 237
		public enum ScrollBar
		{
			// Token: 0x04000587 RID: 1415
			SB_HORZ,
			// Token: 0x04000588 RID: 1416
			SB_VERT,
			// Token: 0x04000589 RID: 1417
			SB_CTL,
			// Token: 0x0400058A RID: 1418
			SB_BOTH
		}

		// Token: 0x020000EE RID: 238
		public enum HitTest
		{
			// Token: 0x0400058C RID: 1420
			HTNOWHERE,
			// Token: 0x0400058D RID: 1421
			HTCLIENT,
			// Token: 0x0400058E RID: 1422
			HTCAPTION,
			// Token: 0x0400058F RID: 1423
			HTGROWBOX = 4,
			// Token: 0x04000590 RID: 1424
			HTSIZE = 4,
			// Token: 0x04000591 RID: 1425
			HTMINBUTTON = 8,
			// Token: 0x04000592 RID: 1426
			HTMAXBUTTON,
			// Token: 0x04000593 RID: 1427
			HTLEFT,
			// Token: 0x04000594 RID: 1428
			HTRIGHT,
			// Token: 0x04000595 RID: 1429
			HTTOP,
			// Token: 0x04000596 RID: 1430
			HTTOPLEFT,
			// Token: 0x04000597 RID: 1431
			HTTOPRIGHT,
			// Token: 0x04000598 RID: 1432
			HTBOTTOM,
			// Token: 0x04000599 RID: 1433
			HTBOTTOMLEFT,
			// Token: 0x0400059A RID: 1434
			HTBOTTOMRIGHT,
			// Token: 0x0400059B RID: 1435
			HTREDUCE = 8,
			// Token: 0x0400059C RID: 1436
			HTZOOM,
			// Token: 0x0400059D RID: 1437
			HTSIZEFIRST,
			// Token: 0x0400059E RID: 1438
			HTSIZELAST = 17,
			// Token: 0x0400059F RID: 1439
			HTTRANSPARENT = -1
		}

		// Token: 0x020000EF RID: 239
		public enum TabControlHitTest
		{
			// Token: 0x040005A1 RID: 1441
			TCHT_NOWHERE = 1
		}

		// Token: 0x020000F0 RID: 240
		public enum Messages : uint
		{
			// Token: 0x040005A3 RID: 1443
			WM_NULL,
			// Token: 0x040005A4 RID: 1444
			WM_CREATE,
			// Token: 0x040005A5 RID: 1445
			WM_DESTROY,
			// Token: 0x040005A6 RID: 1446
			WM_MOVE,
			// Token: 0x040005A7 RID: 1447
			WM_SIZE = 5u,
			// Token: 0x040005A8 RID: 1448
			WM_ACTIVATE,
			// Token: 0x040005A9 RID: 1449
			WM_SETFOCUS,
			// Token: 0x040005AA RID: 1450
			WM_KILLFOCUS,
			// Token: 0x040005AB RID: 1451
			WM_ENABLE = 10u,
			// Token: 0x040005AC RID: 1452
			WM_SETREDRAW,
			// Token: 0x040005AD RID: 1453
			WM_SETTEXT,
			// Token: 0x040005AE RID: 1454
			WM_GETTEXT,
			// Token: 0x040005AF RID: 1455
			WM_GETTEXTLENGTH,
			// Token: 0x040005B0 RID: 1456
			WM_PAINT,
			// Token: 0x040005B1 RID: 1457
			WM_CLOSE,
			// Token: 0x040005B2 RID: 1458
			WM_QUERYENDSESSION,
			// Token: 0x040005B3 RID: 1459
			WM_QUERYOPEN = 19u,
			// Token: 0x040005B4 RID: 1460
			WM_ENDSESSION = 22u,
			// Token: 0x040005B5 RID: 1461
			WM_QUIT = 18u,
			// Token: 0x040005B6 RID: 1462
			WM_ERASEBKGND = 20u,
			// Token: 0x040005B7 RID: 1463
			WM_SYSCOLORCHANGE,
			// Token: 0x040005B8 RID: 1464
			WM_SHOWWINDOW = 24u,
			// Token: 0x040005B9 RID: 1465
			WM_WININICHANGE = 26u,
			// Token: 0x040005BA RID: 1466
			WM_SETTINGCHANGE = 26u,
			// Token: 0x040005BB RID: 1467
			WM_DEVMODECHANGE,
			// Token: 0x040005BC RID: 1468
			WM_ACTIVATEAPP,
			// Token: 0x040005BD RID: 1469
			WM_FONTCHANGE,
			// Token: 0x040005BE RID: 1470
			WM_TIMECHANGE,
			// Token: 0x040005BF RID: 1471
			WM_CANCELMODE,
			// Token: 0x040005C0 RID: 1472
			WM_SETCURSOR,
			// Token: 0x040005C1 RID: 1473
			WM_MOUSEACTIVATE,
			// Token: 0x040005C2 RID: 1474
			WM_CHILDACTIVATE,
			// Token: 0x040005C3 RID: 1475
			WM_QUEUESYNC,
			// Token: 0x040005C4 RID: 1476
			WM_GETMINMAXINFO,
			// Token: 0x040005C5 RID: 1477
			WM_PAINTICON = 38u,
			// Token: 0x040005C6 RID: 1478
			WM_ICONERASEBKGND,
			// Token: 0x040005C7 RID: 1479
			WM_NEXTDLGCTL,
			// Token: 0x040005C8 RID: 1480
			WM_SPOOLERSTATUS = 42u,
			// Token: 0x040005C9 RID: 1481
			WM_DRAWITEM,
			// Token: 0x040005CA RID: 1482
			WM_MEASUREITEM,
			// Token: 0x040005CB RID: 1483
			WM_DELETEITEM,
			// Token: 0x040005CC RID: 1484
			WM_VKEYTOITEM,
			// Token: 0x040005CD RID: 1485
			WM_CHARTOITEM,
			// Token: 0x040005CE RID: 1486
			WM_SETFONT,
			// Token: 0x040005CF RID: 1487
			WM_GETFONT,
			// Token: 0x040005D0 RID: 1488
			WM_SETHOTKEY,
			// Token: 0x040005D1 RID: 1489
			WM_GETHOTKEY,
			// Token: 0x040005D2 RID: 1490
			WM_QUERYDRAGICON = 55u,
			// Token: 0x040005D3 RID: 1491
			WM_COMPAREITEM = 57u,
			// Token: 0x040005D4 RID: 1492
			WM_GETOBJECT = 61u,
			// Token: 0x040005D5 RID: 1493
			WM_COMPACTING = 65u,
			// Token: 0x040005D6 RID: 1494
			WM_COMMNOTIFY = 68u,
			// Token: 0x040005D7 RID: 1495
			WM_WINDOWPOSCHANGING = 70u,
			// Token: 0x040005D8 RID: 1496
			WM_WINDOWPOSCHANGED,
			// Token: 0x040005D9 RID: 1497
			WM_POWER,
			// Token: 0x040005DA RID: 1498
			WM_COPYDATA = 74u,
			// Token: 0x040005DB RID: 1499
			WM_CANCELJOURNAL,
			// Token: 0x040005DC RID: 1500
			WM_NOTIFY = 78u,
			// Token: 0x040005DD RID: 1501
			WM_INPUTLANGCHANGEREQUEST = 80u,
			// Token: 0x040005DE RID: 1502
			WM_INPUTLANGCHANGE,
			// Token: 0x040005DF RID: 1503
			WM_TCARD,
			// Token: 0x040005E0 RID: 1504
			WM_HELP,
			// Token: 0x040005E1 RID: 1505
			WM_USERCHANGED,
			// Token: 0x040005E2 RID: 1506
			WM_NOTIFYFORMAT,
			// Token: 0x040005E3 RID: 1507
			WM_CONTEXTMENU = 123u,
			// Token: 0x040005E4 RID: 1508
			WM_STYLECHANGING,
			// Token: 0x040005E5 RID: 1509
			WM_STYLECHANGED,
			// Token: 0x040005E6 RID: 1510
			WM_DISPLAYCHANGE,
			// Token: 0x040005E7 RID: 1511
			WM_GETICON,
			// Token: 0x040005E8 RID: 1512
			WM_SETICON,
			// Token: 0x040005E9 RID: 1513
			WM_NCCREATE,
			// Token: 0x040005EA RID: 1514
			WM_NCDESTROY,
			// Token: 0x040005EB RID: 1515
			WM_NCCALCSIZE,
			// Token: 0x040005EC RID: 1516
			WM_NCHITTEST,
			// Token: 0x040005ED RID: 1517
			WM_NCPAINT,
			// Token: 0x040005EE RID: 1518
			WM_NCACTIVATE,
			// Token: 0x040005EF RID: 1519
			WM_GETDLGCODE,
			// Token: 0x040005F0 RID: 1520
			WM_SYNCPAINT,
			// Token: 0x040005F1 RID: 1521
			WM_NCMOUSEMOVE = 160u,
			// Token: 0x040005F2 RID: 1522
			WM_NCLBUTTONDOWN,
			// Token: 0x040005F3 RID: 1523
			WM_NCLBUTTONUP,
			// Token: 0x040005F4 RID: 1524
			WM_NCLBUTTONDBLCLK,
			// Token: 0x040005F5 RID: 1525
			WM_NCRBUTTONDOWN,
			// Token: 0x040005F6 RID: 1526
			WM_NCRBUTTONUP,
			// Token: 0x040005F7 RID: 1527
			WM_NCRBUTTONDBLCLK,
			// Token: 0x040005F8 RID: 1528
			WM_NCMBUTTONDOWN,
			// Token: 0x040005F9 RID: 1529
			WM_NCMBUTTONUP,
			// Token: 0x040005FA RID: 1530
			WM_NCMBUTTONDBLCLK,
			// Token: 0x040005FB RID: 1531
			WM_NCXBUTTONDOWN = 171u,
			// Token: 0x040005FC RID: 1532
			WM_NCXBUTTONUP,
			// Token: 0x040005FD RID: 1533
			WM_NCXBUTTONDBLCLK,
			// Token: 0x040005FE RID: 1534
			WM_INPUT = 255u,
			// Token: 0x040005FF RID: 1535
			WM_KEYFIRST,
			// Token: 0x04000600 RID: 1536
			WM_KEYDOWN = 256u,
			// Token: 0x04000601 RID: 1537
			WM_KEYUP,
			// Token: 0x04000602 RID: 1538
			WM_CHAR,
			// Token: 0x04000603 RID: 1539
			WM_DEADCHAR,
			// Token: 0x04000604 RID: 1540
			WM_SYSKEYDOWN,
			// Token: 0x04000605 RID: 1541
			WM_SYSKEYUP,
			// Token: 0x04000606 RID: 1542
			WM_SYSCHAR,
			// Token: 0x04000607 RID: 1543
			WM_SYSDEADCHAR,
			// Token: 0x04000608 RID: 1544
			WM_UNICHAR = 265u,
			// Token: 0x04000609 RID: 1545
			WM_KEYLAST = 264u,
			// Token: 0x0400060A RID: 1546
			WM_IME_STARTCOMPOSITION = 269u,
			// Token: 0x0400060B RID: 1547
			WM_IME_ENDCOMPOSITION,
			// Token: 0x0400060C RID: 1548
			WM_IME_COMPOSITION,
			// Token: 0x0400060D RID: 1549
			WM_IME_KEYLAST = 271u,
			// Token: 0x0400060E RID: 1550
			WM_INITDIALOG,
			// Token: 0x0400060F RID: 1551
			WM_COMMAND,
			// Token: 0x04000610 RID: 1552
			WM_SYSCOMMAND,
			// Token: 0x04000611 RID: 1553
			WM_TIMER,
			// Token: 0x04000612 RID: 1554
			WM_HSCROLL,
			// Token: 0x04000613 RID: 1555
			WM_VSCROLL,
			// Token: 0x04000614 RID: 1556
			WM_INITMENU,
			// Token: 0x04000615 RID: 1557
			WM_INITMENUPOPUP,
			// Token: 0x04000616 RID: 1558
			WM_MENUSELECT = 287u,
			// Token: 0x04000617 RID: 1559
			WM_MENUCHAR,
			// Token: 0x04000618 RID: 1560
			WM_ENTERIDLE,
			// Token: 0x04000619 RID: 1561
			WM_MENURBUTTONUP,
			// Token: 0x0400061A RID: 1562
			WM_MENUDRAG,
			// Token: 0x0400061B RID: 1563
			WM_MENUGETOBJECT,
			// Token: 0x0400061C RID: 1564
			WM_UNINITMENUPOPUP,
			// Token: 0x0400061D RID: 1565
			WM_MENUCOMMAND,
			// Token: 0x0400061E RID: 1566
			WM_CHANGEUISTATE,
			// Token: 0x0400061F RID: 1567
			WM_UPDATEUISTATE,
			// Token: 0x04000620 RID: 1568
			WM_QUERYUISTATE,
			// Token: 0x04000621 RID: 1569
			WM_CTLCOLOR = 25u,
			// Token: 0x04000622 RID: 1570
			WM_CTLCOLORMSGBOX = 306u,
			// Token: 0x04000623 RID: 1571
			WM_CTLCOLOREDIT,
			// Token: 0x04000624 RID: 1572
			WM_CTLCOLORLISTBOX,
			// Token: 0x04000625 RID: 1573
			WM_CTLCOLORBTN,
			// Token: 0x04000626 RID: 1574
			WM_CTLCOLORDLG,
			// Token: 0x04000627 RID: 1575
			WM_CTLCOLORSCROLLBAR,
			// Token: 0x04000628 RID: 1576
			WM_CTLCOLORSTATIC,
			// Token: 0x04000629 RID: 1577
			WM_MOUSEFIRST = 512u,
			// Token: 0x0400062A RID: 1578
			WM_MOUSEMOVE = 512u,
			// Token: 0x0400062B RID: 1579
			WM_LBUTTONDOWN,
			// Token: 0x0400062C RID: 1580
			WM_LBUTTONUP,
			// Token: 0x0400062D RID: 1581
			WM_LBUTTONDBLCLK,
			// Token: 0x0400062E RID: 1582
			WM_RBUTTONDOWN,
			// Token: 0x0400062F RID: 1583
			WM_RBUTTONUP,
			// Token: 0x04000630 RID: 1584
			WM_RBUTTONDBLCLK,
			// Token: 0x04000631 RID: 1585
			WM_MBUTTONDOWN,
			// Token: 0x04000632 RID: 1586
			WM_MBUTTONUP,
			// Token: 0x04000633 RID: 1587
			WM_MBUTTONDBLCLK,
			// Token: 0x04000634 RID: 1588
			WM_MOUSEWHEEL,
			// Token: 0x04000635 RID: 1589
			WM_XBUTTONDOWN,
			// Token: 0x04000636 RID: 1590
			WM_XBUTTONUP,
			// Token: 0x04000637 RID: 1591
			WM_XBUTTONDBLCLK,
			// Token: 0x04000638 RID: 1592
			WM_MOUSELAST = 525u,
			// Token: 0x04000639 RID: 1593
			WM_PARENTNOTIFY = 528u,
			// Token: 0x0400063A RID: 1594
			WM_ENTERMENULOOP,
			// Token: 0x0400063B RID: 1595
			WM_EXITMENULOOP,
			// Token: 0x0400063C RID: 1596
			WM_NEXTMENU,
			// Token: 0x0400063D RID: 1597
			WM_SIZING,
			// Token: 0x0400063E RID: 1598
			WM_CAPTURECHANGED,
			// Token: 0x0400063F RID: 1599
			WM_MOVING,
			// Token: 0x04000640 RID: 1600
			WM_POWERBROADCAST = 536u,
			// Token: 0x04000641 RID: 1601
			WM_DEVICECHANGE,
			// Token: 0x04000642 RID: 1602
			WM_MDICREATE = 544u,
			// Token: 0x04000643 RID: 1603
			WM_MDIDESTROY,
			// Token: 0x04000644 RID: 1604
			WM_MDIACTIVATE,
			// Token: 0x04000645 RID: 1605
			WM_MDIRESTORE,
			// Token: 0x04000646 RID: 1606
			WM_MDINEXT,
			// Token: 0x04000647 RID: 1607
			WM_MDIMAXIMIZE,
			// Token: 0x04000648 RID: 1608
			WM_MDITILE,
			// Token: 0x04000649 RID: 1609
			WM_MDICASCADE,
			// Token: 0x0400064A RID: 1610
			WM_MDIICONARRANGE,
			// Token: 0x0400064B RID: 1611
			WM_MDIGETACTIVE,
			// Token: 0x0400064C RID: 1612
			WM_MDISETMENU = 560u,
			// Token: 0x0400064D RID: 1613
			WM_ENTERSIZEMOVE,
			// Token: 0x0400064E RID: 1614
			WM_EXITSIZEMOVE,
			// Token: 0x0400064F RID: 1615
			WM_DROPFILES,
			// Token: 0x04000650 RID: 1616
			WM_MDIREFRESHMENU,
			// Token: 0x04000651 RID: 1617
			WM_IME_SETCONTEXT = 641u,
			// Token: 0x04000652 RID: 1618
			WM_IME_NOTIFY,
			// Token: 0x04000653 RID: 1619
			WM_IME_CONTROL,
			// Token: 0x04000654 RID: 1620
			WM_IME_COMPOSITIONFULL,
			// Token: 0x04000655 RID: 1621
			WM_IME_SELECT,
			// Token: 0x04000656 RID: 1622
			WM_IME_CHAR,
			// Token: 0x04000657 RID: 1623
			WM_IME_REQUEST = 648u,
			// Token: 0x04000658 RID: 1624
			WM_IME_KEYDOWN = 656u,
			// Token: 0x04000659 RID: 1625
			WM_IME_KEYUP,
			// Token: 0x0400065A RID: 1626
			WM_MOUSEHOVER = 673u,
			// Token: 0x0400065B RID: 1627
			WM_MOUSELEAVE = 675u,
			// Token: 0x0400065C RID: 1628
			WM_NCMOUSELEAVE = 674u,
			// Token: 0x0400065D RID: 1629
			WM_WTSSESSION_CHANGE = 689u,
			// Token: 0x0400065E RID: 1630
			WM_TABLET_FIRST = 704u,
			// Token: 0x0400065F RID: 1631
			WM_TABLET_LAST = 735u,
			// Token: 0x04000660 RID: 1632
			WM_CUT = 768u,
			// Token: 0x04000661 RID: 1633
			WM_COPY,
			// Token: 0x04000662 RID: 1634
			WM_PASTE,
			// Token: 0x04000663 RID: 1635
			WM_CLEAR,
			// Token: 0x04000664 RID: 1636
			WM_UNDO,
			// Token: 0x04000665 RID: 1637
			WM_RENDERFORMAT,
			// Token: 0x04000666 RID: 1638
			WM_RENDERALLFORMATS,
			// Token: 0x04000667 RID: 1639
			WM_DESTROYCLIPBOARD,
			// Token: 0x04000668 RID: 1640
			WM_DRAWCLIPBOARD,
			// Token: 0x04000669 RID: 1641
			WM_PAINTCLIPBOARD,
			// Token: 0x0400066A RID: 1642
			WM_VSCROLLCLIPBOARD,
			// Token: 0x0400066B RID: 1643
			WM_SIZECLIPBOARD,
			// Token: 0x0400066C RID: 1644
			WM_ASKCBFORMATNAME,
			// Token: 0x0400066D RID: 1645
			WM_CHANGECBCHAIN,
			// Token: 0x0400066E RID: 1646
			WM_HSCROLLCLIPBOARD,
			// Token: 0x0400066F RID: 1647
			WM_QUERYNEWPALETTE,
			// Token: 0x04000670 RID: 1648
			WM_PALETTEISCHANGING,
			// Token: 0x04000671 RID: 1649
			WM_PALETTECHANGED,
			// Token: 0x04000672 RID: 1650
			WM_HOTKEY,
			// Token: 0x04000673 RID: 1651
			WM_PRINT = 791u,
			// Token: 0x04000674 RID: 1652
			WM_PRINTCLIENT,
			// Token: 0x04000675 RID: 1653
			WM_APPCOMMAND,
			// Token: 0x04000676 RID: 1654
			WM_THEMECHANGED,
			// Token: 0x04000677 RID: 1655
			WM_HANDHELDFIRST = 856u,
			// Token: 0x04000678 RID: 1656
			WM_HANDHELDLAST = 863u,
			// Token: 0x04000679 RID: 1657
			WM_AFXFIRST,
			// Token: 0x0400067A RID: 1658
			WM_AFXLAST = 895u,
			// Token: 0x0400067B RID: 1659
			WM_PENWINFIRST,
			// Token: 0x0400067C RID: 1660
			WM_PENWINLAST = 911u,
			// Token: 0x0400067D RID: 1661
			WM_USER = 1024u,
			// Token: 0x0400067E RID: 1662
			WM_REFLECT = 8192u,
			// Token: 0x0400067F RID: 1663
			WM_APP = 32768u,
			// Token: 0x04000680 RID: 1664
			WM_DWMCOMPOSITIONCHANGED = 798u,
			// Token: 0x04000681 RID: 1665
			SC_MOVE = 61456u,
			// Token: 0x04000682 RID: 1666
			SC_MINIMIZE = 61472u,
			// Token: 0x04000683 RID: 1667
			SC_MAXIMIZE = 61488u,
			// Token: 0x04000684 RID: 1668
			SC_RESTORE = 61728u
		}

		// Token: 0x020000F1 RID: 241
		public enum Bool
		{
			// Token: 0x04000686 RID: 1670
			False,
			// Token: 0x04000687 RID: 1671
			True
		}
	}
}
