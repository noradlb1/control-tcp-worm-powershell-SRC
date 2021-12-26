<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.L1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenUrlToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunFileFromLinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ii = New System.Windows.Forms.ImageList(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Textb = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.L1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.L1.FullRowSelect = True
        Me.L1.GridLines = True
        Me.L1.Location = New System.Drawing.Point(0, 0)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(722, 277)
        Me.L1.SmallImageList = Me.ii
        Me.L1.TabIndex = 2
        Me.L1.UseCompatibleStateImageBehavior = False
        Me.L1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID/Victime"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IP"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Username"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PcName"
        Me.ColumnHeader4.Width = 128
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "OS"
        Me.ColumnHeader5.Width = 111
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "AV"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DotNet 2.0"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunToolStripMenuItem, Me.ServerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(107, 48)
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenUrlToolStripMenuItem1, Me.RunFileFromLinkToolStripMenuItem})
        Me.RunToolStripMenuItem.Image = Global.Control_Test.My.Resources.Resources.ok
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'OpenUrlToolStripMenuItem1
        '
        Me.OpenUrlToolStripMenuItem1.Image = Global.Control_Test.My.Resources.Resources.app
        Me.OpenUrlToolStripMenuItem1.Name = "OpenUrlToolStripMenuItem1"
        Me.OpenUrlToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.OpenUrlToolStripMenuItem1.Text = "Open url"
        '
        'RunFileFromLinkToolStripMenuItem
        '
        Me.RunFileFromLinkToolStripMenuItem.Image = Global.Control_Test.My.Resources.Resources._7
        Me.RunFileFromLinkToolStripMenuItem.Name = "RunFileFromLinkToolStripMenuItem"
        Me.RunFileFromLinkToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RunFileFromLinkToolStripMenuItem.Text = "Run file from link"
        '
        'ServerToolStripMenuItem
        '
        Me.ServerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisconnectToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ServerToolStripMenuItem.Image = Global.Control_Test.My.Resources.Resources.shut
        Me.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem"
        Me.ServerToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.ServerToolStripMenuItem.Text = "Server"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Image = Global.Control_Test.My.Resources.Resources.greendot
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = Global.Control_Test.My.Resources.Resources.err
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ii
        '
        Me.ii.ImageStream = CType(resources.GetObject("ii.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ii.TransparentColor = System.Drawing.Color.Transparent
        Me.ii.Images.SetKeyName(0, "F15-Sniper.png")
        Me.ii.Images.SetKeyName(1, "1.gif")
        Me.ii.Images.SetKeyName(2, "2.gif")
        Me.ii.Images.SetKeyName(3, "3.gif")
        Me.ii.Images.SetKeyName(4, "4.gif")
        Me.ii.Images.SetKeyName(5, "5.gif")
        Me.ii.Images.SetKeyName(6, "6.gif")
        Me.ii.Images.SetKeyName(7, "7.gif")
        Me.ii.Images.SetKeyName(8, "8.gif")
        Me.ii.Images.SetKeyName(9, "9.gif")
        Me.ii.Images.SetKeyName(10, "10.gif")
        Me.ii.Images.SetKeyName(11, "11.gif")
        Me.ii.Images.SetKeyName(12, "12.gif")
        Me.ii.Images.SetKeyName(13, "13.gif")
        Me.ii.Images.SetKeyName(14, "14.gif")
        Me.ii.Images.SetKeyName(15, "15.gif")
        Me.ii.Images.SetKeyName(16, "16.gif")
        Me.ii.Images.SetKeyName(17, "17.gif")
        Me.ii.Images.SetKeyName(18, "18.gif")
        Me.ii.Images.SetKeyName(19, "19.gif")
        Me.ii.Images.SetKeyName(20, "20.gif")
        Me.ii.Images.SetKeyName(21, "21.gif")
        Me.ii.Images.SetKeyName(22, "22.gif")
        Me.ii.Images.SetKeyName(23, "23.gif")
        Me.ii.Images.SetKeyName(24, "24.gif")
        Me.ii.Images.SetKeyName(25, "25.gif")
        Me.ii.Images.SetKeyName(26, "26.gif")
        Me.ii.Images.SetKeyName(27, "27.gif")
        Me.ii.Images.SetKeyName(28, "28.gif")
        Me.ii.Images.SetKeyName(29, "29.gif")
        Me.ii.Images.SetKeyName(30, "30.gif")
        Me.ii.Images.SetKeyName(31, "31.gif")
        Me.ii.Images.SetKeyName(32, "32.gif")
        Me.ii.Images.SetKeyName(33, "33.gif")
        Me.ii.Images.SetKeyName(34, "34.gif")
        Me.ii.Images.SetKeyName(35, "35.gif")
        Me.ii.Images.SetKeyName(36, "36.gif")
        Me.ii.Images.SetKeyName(37, "37.gif")
        Me.ii.Images.SetKeyName(38, "38.gif")
        Me.ii.Images.SetKeyName(39, "39.gif")
        Me.ii.Images.SetKeyName(40, "40.gif")
        Me.ii.Images.SetKeyName(41, "41.gif")
        Me.ii.Images.SetKeyName(42, "42.gif")
        Me.ii.Images.SetKeyName(43, "43.gif")
        Me.ii.Images.SetKeyName(44, "44.gif")
        Me.ii.Images.SetKeyName(45, "45.gif")
        Me.ii.Images.SetKeyName(46, "46.gif")
        Me.ii.Images.SetKeyName(47, "47.gif")
        Me.ii.Images.SetKeyName(48, "48.gif")
        Me.ii.Images.SetKeyName(49, "49.gif")
        Me.ii.Images.SetKeyName(50, "50.gif")
        Me.ii.Images.SetKeyName(51, "51.gif")
        Me.ii.Images.SetKeyName(52, "52.gif")
        Me.ii.Images.SetKeyName(53, "53.gif")
        Me.ii.Images.SetKeyName(54, "54.gif")
        Me.ii.Images.SetKeyName(55, "55.gif")
        Me.ii.Images.SetKeyName(56, "56.gif")
        Me.ii.Images.SetKeyName(57, "57.gif")
        Me.ii.Images.SetKeyName(58, "58.gif")
        Me.ii.Images.SetKeyName(59, "59.gif")
        Me.ii.Images.SetKeyName(60, "60.gif")
        Me.ii.Images.SetKeyName(61, "61.gif")
        Me.ii.Images.SetKeyName(62, "62.gif")
        Me.ii.Images.SetKeyName(63, "63.gif")
        Me.ii.Images.SetKeyName(64, "64.gif")
        Me.ii.Images.SetKeyName(65, "65.gif")
        Me.ii.Images.SetKeyName(66, "66.gif")
        Me.ii.Images.SetKeyName(67, "67.gif")
        Me.ii.Images.SetKeyName(68, "68.gif")
        Me.ii.Images.SetKeyName(69, "69.gif")
        Me.ii.Images.SetKeyName(70, "70.gif")
        Me.ii.Images.SetKeyName(71, "71.gif")
        Me.ii.Images.SetKeyName(72, "72.gif")
        Me.ii.Images.SetKeyName(73, "73.gif")
        Me.ii.Images.SetKeyName(74, "74.gif")
        Me.ii.Images.SetKeyName(75, "75.gif")
        Me.ii.Images.SetKeyName(76, "76.gif")
        Me.ii.Images.SetKeyName(77, "77.gif")
        Me.ii.Images.SetKeyName(78, "78.gif")
        Me.ii.Images.SetKeyName(79, "79.gif")
        Me.ii.Images.SetKeyName(80, "80.gif")
        Me.ii.Images.SetKeyName(81, "81.gif")
        Me.ii.Images.SetKeyName(82, "82.gif")
        Me.ii.Images.SetKeyName(83, "83.gif")
        Me.ii.Images.SetKeyName(84, "84.gif")
        Me.ii.Images.SetKeyName(85, "85.gif")
        Me.ii.Images.SetKeyName(86, "86.gif")
        Me.ii.Images.SetKeyName(87, "87.gif")
        Me.ii.Images.SetKeyName(88, "88.gif")
        Me.ii.Images.SetKeyName(89, "89.gif")
        Me.ii.Images.SetKeyName(90, "90.gif")
        Me.ii.Images.SetKeyName(91, "91.gif")
        Me.ii.Images.SetKeyName(92, "92.gif")
        Me.ii.Images.SetKeyName(93, "93.gif")
        Me.ii.Images.SetKeyName(94, "94.gif")
        Me.ii.Images.SetKeyName(95, "95.gif")
        Me.ii.Images.SetKeyName(96, "96.gif")
        Me.ii.Images.SetKeyName(97, "97.gif")
        Me.ii.Images.SetKeyName(98, "98.gif")
        Me.ii.Images.SetKeyName(99, "99.gif")
        Me.ii.Images.SetKeyName(100, "100.gif")
        Me.ii.Images.SetKeyName(101, "101.gif")
        Me.ii.Images.SetKeyName(102, "102.gif")
        Me.ii.Images.SetKeyName(103, "103.gif")
        Me.ii.Images.SetKeyName(104, "104.gif")
        Me.ii.Images.SetKeyName(105, "105.gif")
        Me.ii.Images.SetKeyName(106, "106.gif")
        Me.ii.Images.SetKeyName(107, "107.gif")
        Me.ii.Images.SetKeyName(108, "108.gif")
        Me.ii.Images.SetKeyName(109, "109.gif")
        Me.ii.Images.SetKeyName(110, "110.gif")
        Me.ii.Images.SetKeyName(111, "111.gif")
        Me.ii.Images.SetKeyName(112, "112.gif")
        Me.ii.Images.SetKeyName(113, "113.gif")
        Me.ii.Images.SetKeyName(114, "114.gif")
        Me.ii.Images.SetKeyName(115, "115.gif")
        Me.ii.Images.SetKeyName(116, "116.gif")
        Me.ii.Images.SetKeyName(117, "117.gif")
        Me.ii.Images.SetKeyName(118, "118.gif")
        Me.ii.Images.SetKeyName(119, "119.gif")
        Me.ii.Images.SetKeyName(120, "120.gif")
        Me.ii.Images.SetKeyName(121, "121.gif")
        Me.ii.Images.SetKeyName(122, "122.gif")
        Me.ii.Images.SetKeyName(123, "123.gif")
        Me.ii.Images.SetKeyName(124, "124.gif")
        Me.ii.Images.SetKeyName(125, "125.gif")
        Me.ii.Images.SetKeyName(126, "126.gif")
        Me.ii.Images.SetKeyName(127, "127.gif")
        Me.ii.Images.SetKeyName(128, "128.gif")
        Me.ii.Images.SetKeyName(129, "129.gif")
        Me.ii.Images.SetKeyName(130, "130.gif")
        Me.ii.Images.SetKeyName(131, "131.gif")
        Me.ii.Images.SetKeyName(132, "132.gif")
        Me.ii.Images.SetKeyName(133, "133.gif")
        Me.ii.Images.SetKeyName(134, "134.gif")
        Me.ii.Images.SetKeyName(135, "135.gif")
        Me.ii.Images.SetKeyName(136, "136.gif")
        Me.ii.Images.SetKeyName(137, "137.gif")
        Me.ii.Images.SetKeyName(138, "138.gif")
        Me.ii.Images.SetKeyName(139, "139.gif")
        Me.ii.Images.SetKeyName(140, "140.gif")
        Me.ii.Images.SetKeyName(141, "141.gif")
        Me.ii.Images.SetKeyName(142, "142.gif")
        Me.ii.Images.SetKeyName(143, "143.gif")
        Me.ii.Images.SetKeyName(144, "144.gif")
        Me.ii.Images.SetKeyName(145, "145.gif")
        Me.ii.Images.SetKeyName(146, "146.gif")
        Me.ii.Images.SetKeyName(147, "147.gif")
        Me.ii.Images.SetKeyName(148, "148.gif")
        Me.ii.Images.SetKeyName(149, "149.gif")
        Me.ii.Images.SetKeyName(150, "150.gif")
        Me.ii.Images.SetKeyName(151, "151.gif")
        Me.ii.Images.SetKeyName(152, "152.gif")
        Me.ii.Images.SetKeyName(153, "153.gif")
        Me.ii.Images.SetKeyName(154, "154.gif")
        Me.ii.Images.SetKeyName(155, "155.gif")
        Me.ii.Images.SetKeyName(156, "156.gif")
        Me.ii.Images.SetKeyName(157, "157.gif")
        Me.ii.Images.SetKeyName(158, "158.gif")
        Me.ii.Images.SetKeyName(159, "159.gif")
        Me.ii.Images.SetKeyName(160, "160.gif")
        Me.ii.Images.SetKeyName(161, "161.gif")
        Me.ii.Images.SetKeyName(162, "162.gif")
        Me.ii.Images.SetKeyName(163, "163.gif")
        Me.ii.Images.SetKeyName(164, "164.gif")
        Me.ii.Images.SetKeyName(165, "165.gif")
        Me.ii.Images.SetKeyName(166, "166.gif")
        Me.ii.Images.SetKeyName(167, "167.gif")
        Me.ii.Images.SetKeyName(168, "168.gif")
        Me.ii.Images.SetKeyName(169, "169.gif")
        Me.ii.Images.SetKeyName(170, "170.gif")
        Me.ii.Images.SetKeyName(171, "171.gif")
        Me.ii.Images.SetKeyName(172, "172.gif")
        Me.ii.Images.SetKeyName(173, "173.gif")
        Me.ii.Images.SetKeyName(174, "174.gif")
        Me.ii.Images.SetKeyName(175, "175.gif")
        Me.ii.Images.SetKeyName(176, "176.gif")
        Me.ii.Images.SetKeyName(177, "177.gif")
        Me.ii.Images.SetKeyName(178, "178.gif")
        Me.ii.Images.SetKeyName(179, "179.gif")
        Me.ii.Images.SetKeyName(180, "180.gif")
        Me.ii.Images.SetKeyName(181, "181.gif")
        Me.ii.Images.SetKeyName(182, "182.gif")
        Me.ii.Images.SetKeyName(183, "183.gif")
        Me.ii.Images.SetKeyName(184, "184.gif")
        Me.ii.Images.SetKeyName(185, "185.gif")
        Me.ii.Images.SetKeyName(186, "186.gif")
        Me.ii.Images.SetKeyName(187, "187.gif")
        Me.ii.Images.SetKeyName(188, "188.gif")
        Me.ii.Images.SetKeyName(189, "189.gif")
        Me.ii.Images.SetKeyName(190, "190.gif")
        Me.ii.Images.SetKeyName(191, "191.gif")
        Me.ii.Images.SetKeyName(192, "192.gif")
        Me.ii.Images.SetKeyName(193, "193.gif")
        Me.ii.Images.SetKeyName(194, "194.gif")
        Me.ii.Images.SetKeyName(195, "195.gif")
        Me.ii.Images.SetKeyName(196, "196.gif")
        Me.ii.Images.SetKeyName(197, "197.gif")
        Me.ii.Images.SetKeyName(198, "198.gif")
        Me.ii.Images.SetKeyName(199, "199.gif")
        Me.ii.Images.SetKeyName(200, "200.gif")
        Me.ii.Images.SetKeyName(201, "201.gif")
        Me.ii.Images.SetKeyName(202, "202.gif")
        Me.ii.Images.SetKeyName(203, "203.gif")
        Me.ii.Images.SetKeyName(204, "204.gif")
        Me.ii.Images.SetKeyName(205, "205.gif")
        Me.ii.Images.SetKeyName(206, "206.gif")
        Me.ii.Images.SetKeyName(207, "207.jpg")
        Me.ii.Images.SetKeyName(208, "208.gif")
        Me.ii.Images.SetKeyName(209, "209.gif")
        Me.ii.Images.SetKeyName(210, "210.gif")
        Me.ii.Images.SetKeyName(211, "211.gif")
        Me.ii.Images.SetKeyName(212, "212.gif")
        Me.ii.Images.SetKeyName(213, "213.gif")
        Me.ii.Images.SetKeyName(214, "214.gif")
        Me.ii.Images.SetKeyName(215, "215.gif")
        Me.ii.Images.SetKeyName(216, "216.gif")
        Me.ii.Images.SetKeyName(217, "217.gif")
        Me.ii.Images.SetKeyName(218, "218.gif")
        Me.ii.Images.SetKeyName(219, "219.gif")
        Me.ii.Images.SetKeyName(220, "220.gif")
        Me.ii.Images.SetKeyName(221, "221.gif")
        Me.ii.Images.SetKeyName(222, "222.gif")
        Me.ii.Images.SetKeyName(223, "223.gif")
        Me.ii.Images.SetKeyName(224, "224.gif")
        Me.ii.Images.SetKeyName(225, "225.gif")
        Me.ii.Images.SetKeyName(226, "226.gif")
        Me.ii.Images.SetKeyName(227, "227.gif")
        Me.ii.Images.SetKeyName(228, "228.gif")
        Me.ii.Images.SetKeyName(229, "229.gif")
        Me.ii.Images.SetKeyName(230, "230.gif")
        Me.ii.Images.SetKeyName(231, "231.gif")
        Me.ii.Images.SetKeyName(232, "232.gif")
        Me.ii.Images.SetKeyName(233, "233.gif")
        Me.ii.Images.SetKeyName(234, "234.gif")
        Me.ii.Images.SetKeyName(235, "235.gif")
        Me.ii.Images.SetKeyName(236, "236.gif")
        Me.ii.Images.SetKeyName(237, "237.gif")
        Me.ii.Images.SetKeyName(238, "238.gif")
        Me.ii.Images.SetKeyName(239, "239.gif")
        Me.ii.Images.SetKeyName(240, "240.gif")
        Me.ii.Images.SetKeyName(241, "241.gif")
        Me.ii.Images.SetKeyName(242, "basic.png")
        Me.ii.Images.SetKeyName(243, "connections.png")
        Me.ii.Images.SetKeyName(244, "group.png")
        Me.ii.Images.SetKeyName(245, "misc.png")
        Me.ii.Images.SetKeyName(246, "user.png")
        Me.ii.Images.SetKeyName(247, "user_gray.png")
        Me.ii.Images.SetKeyName(248, "bug_go.png")
        Me.ii.Images.SetKeyName(249, "bullet_feed.png")
        Me.ii.Images.SetKeyName(250, "bullet_star.png")
        Me.ii.Images.SetKeyName(251, "cog.png")
        Me.ii.Images.SetKeyName(252, "computer.png")
        Me.ii.Images.SetKeyName(253, "transmit.png")
        Me.ii.Images.SetKeyName(254, "Record Button.png")
        Me.ii.Images.SetKeyName(255, "14.ico")
        Me.ii.Images.SetKeyName(256, "52.ico")
        Me.ii.Images.SetKeyName(257, "5.ico")
        Me.ii.Images.SetKeyName(258, "55.ico")
        Me.ii.Images.SetKeyName(259, "12.ico")
        Me.ii.Images.SetKeyName(260, "94.ico")
        Me.ii.Images.SetKeyName(261, "5.ico")
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Visible = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 278)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(724, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.BuildToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "Builder"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Control_Test.My.Resources.Resources.aboutdown
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.Control_Test.My.Resources.Resources.configdown
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'BuildToolStripMenuItem
        '
        Me.BuildToolStripMenuItem.Image = Global.Control_Test.My.Resources.Resources.optionsdown
        Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
        Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.BuildToolStripMenuItem.Text = "Build"
        '
        'Textb
        '
        Me.Textb.Location = New System.Drawing.Point(21, 381)
        Me.Textb.Name = "Textb"
        Me.Textb.Size = New System.Drawing.Size(476, 20)
        Me.Textb.TabIndex = 6
        Me.Textb.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 300)
        Me.Controls.Add(Me.Textb)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.L1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control(Worm_powershell)"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ii As System.Windows.Forms.ImageList
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenUrlToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunFileFromLinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Textb As System.Windows.Forms.TextBox

End Class
