<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mtlExit = New MetroFramework.Controls.MetroLink()
        Me.cntxUserProfile = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmMinimize = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmContextExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtabDashboard = New MetroFramework.Controls.MetroTabControl()
        Me.tpgDashboard = New MetroFramework.Controls.MetroTabPage()
        Me.lnkSettings = New MetroFramework.Controls.MetroLink()
        Me.lnkReports = New MetroFramework.Controls.MetroLink()
        Me.lnkSynchronization = New MetroFramework.Controls.MetroLink()
        Me.lnkFarmers = New MetroFramework.Controls.MetroLink()
        Me.lnkStaff = New MetroFramework.Controls.MetroLink()
        Me.lnkDashboard = New MetroFramework.Controls.MetroLink()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.msmMain = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.pctAppLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lnkTheme = New MetroFramework.Controls.MetroLink()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.txtSearchBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.cntxUserProfile.SuspendLayout()
        Me.mtabDashboard.SuspendLayout()
        Me.tpgDashboard.SuspendLayout()
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAppLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtlExit
        '
        Me.mtlExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtlExit.BackColor = System.Drawing.Color.SteelBlue
        Me.mtlExit.Image = Global.Farmers.My.Resources.Resources.shutdown_icon
        Me.mtlExit.ImageSize = 28
        Me.mtlExit.Location = New System.Drawing.Point(1231, 15)
        Me.mtlExit.Name = "mtlExit"
        Me.mtlExit.NoFocusImage = Global.Farmers.My.Resources.Resources.shutdown_icon_faded
        Me.mtlExit.Size = New System.Drawing.Size(38, 36)
        Me.mtlExit.TabIndex = 407
        Me.mtlExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroToolTip1.SetToolTip(Me.mtlExit, "exit")
        Me.mtlExit.UseSelectable = True
        '
        'cntxUserProfile
        '
        Me.cntxUserProfile.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cntxUserProfile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmMinimize, Me.ToolStripSeparator2, Me.tsmContextExit})
        Me.cntxUserProfile.Name = "ctxMenu"
        Me.cntxUserProfile.ShowImageMargin = False
        Me.cntxUserProfile.Size = New System.Drawing.Size(115, 58)
        Me.cntxUserProfile.UseStyleColors = True
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(111, 6)
        '
        'tsmMinimize
        '
        Me.tsmMinimize.Name = "tsmMinimize"
        Me.tsmMinimize.Size = New System.Drawing.Size(114, 24)
        Me.tsmMinimize.Text = "minimize"
        '
        'tsmContextExit
        '
        Me.tsmContextExit.Name = "tsmContextExit"
        Me.tsmContextExit.Size = New System.Drawing.Size(114, 24)
        Me.tsmContextExit.Text = "exit"
        '
        'mtabDashboard
        '
        Me.mtabDashboard.Controls.Add(Me.tpgDashboard)
        Me.mtabDashboard.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtabDashboard.Location = New System.Drawing.Point(20, 60)
        Me.mtabDashboard.Name = "mtabDashboard"
        Me.mtabDashboard.SelectedIndex = 0
        Me.mtabDashboard.Size = New System.Drawing.Size(192, 587)
        Me.mtabDashboard.TabIndex = 414
        Me.mtabDashboard.UseSelectable = True
        '
        'tpgDashboard
        '
        Me.tpgDashboard.Controls.Add(Me.lnkSettings)
        Me.tpgDashboard.Controls.Add(Me.lnkReports)
        Me.tpgDashboard.Controls.Add(Me.lnkSynchronization)
        Me.tpgDashboard.Controls.Add(Me.lnkFarmers)
        Me.tpgDashboard.Controls.Add(Me.lnkStaff)
        Me.tpgDashboard.Controls.Add(Me.lnkDashboard)
        Me.tpgDashboard.Controls.Add(Me.Label1)
        Me.tpgDashboard.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpgDashboard.HorizontalScrollbarBarColor = True
        Me.tpgDashboard.HorizontalScrollbarHighlightOnWheel = False
        Me.tpgDashboard.HorizontalScrollbarSize = 10
        Me.tpgDashboard.Location = New System.Drawing.Point(4, 38)
        Me.tpgDashboard.Name = "tpgDashboard"
        Me.tpgDashboard.Size = New System.Drawing.Size(184, 545)
        Me.tpgDashboard.Style = MetroFramework.MetroColorStyle.Teal
        Me.tpgDashboard.TabIndex = 0
        Me.tpgDashboard.VerticalScrollbarBarColor = True
        Me.tpgDashboard.VerticalScrollbarHighlightOnWheel = False
        Me.tpgDashboard.VerticalScrollbarSize = 10
        '
        'lnkSettings
        '
        Me.lnkSettings.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.lnkSettings.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lnkSettings.Location = New System.Drawing.Point(5, 215)
        Me.lnkSettings.Name = "lnkSettings"
        Me.lnkSettings.Size = New System.Drawing.Size(147, 23)
        Me.lnkSettings.TabIndex = 20
        Me.lnkSettings.Text = "Settings"
        Me.lnkSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkSettings.UseSelectable = True
        Me.lnkSettings.UseStyleColors = True
        '
        'lnkReports
        '
        Me.lnkReports.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.lnkReports.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lnkReports.Location = New System.Drawing.Point(5, 244)
        Me.lnkReports.Name = "lnkReports"
        Me.lnkReports.Size = New System.Drawing.Size(147, 23)
        Me.lnkReports.TabIndex = 19
        Me.lnkReports.Text = "Reports"
        Me.lnkReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkReports.UseSelectable = True
        Me.lnkReports.UseStyleColors = True
        '
        'lnkSynchronization
        '
        Me.lnkSynchronization.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.lnkSynchronization.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lnkSynchronization.Location = New System.Drawing.Point(5, 186)
        Me.lnkSynchronization.Name = "lnkSynchronization"
        Me.lnkSynchronization.Size = New System.Drawing.Size(147, 23)
        Me.lnkSynchronization.TabIndex = 18
        Me.lnkSynchronization.Text = "Synchronization"
        Me.lnkSynchronization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkSynchronization.UseSelectable = True
        Me.lnkSynchronization.UseStyleColors = True
        '
        'lnkFarmers
        '
        Me.lnkFarmers.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.lnkFarmers.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lnkFarmers.Location = New System.Drawing.Point(5, 128)
        Me.lnkFarmers.Name = "lnkFarmers"
        Me.lnkFarmers.Size = New System.Drawing.Size(147, 23)
        Me.lnkFarmers.TabIndex = 17
        Me.lnkFarmers.Text = "Farmers"
        Me.lnkFarmers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkFarmers.UseSelectable = True
        Me.lnkFarmers.UseStyleColors = True
        '
        'lnkStaff
        '
        Me.lnkStaff.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.lnkStaff.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lnkStaff.Location = New System.Drawing.Point(5, 157)
        Me.lnkStaff.Name = "lnkStaff"
        Me.lnkStaff.Size = New System.Drawing.Size(147, 23)
        Me.lnkStaff.TabIndex = 16
        Me.lnkStaff.Text = "Staff"
        Me.lnkStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkStaff.UseSelectable = True
        Me.lnkStaff.UseStyleColors = True
        '
        'lnkDashboard
        '
        Me.lnkDashboard.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.lnkDashboard.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.lnkDashboard.Location = New System.Drawing.Point(5, 99)
        Me.lnkDashboard.Name = "lnkDashboard"
        Me.lnkDashboard.Size = New System.Drawing.Size(147, 23)
        Me.lnkDashboard.TabIndex = 15
        Me.lnkDashboard.Text = "Dashboard"
        Me.lnkDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkDashboard.UseSelectable = True
        Me.lnkDashboard.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "MAIN NAVIGATION"
        '
        'msmMain
        '
        Me.msmMain.Owner = Me
        '
        'pctAppLogo
        '
        Me.pctAppLogo.BackColor = System.Drawing.Color.Transparent
        Me.pctAppLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctAppLogo.ErrorImage = Nothing
        Me.pctAppLogo.Image = Global.Farmers.My.Resources.Resources.e_ADAPP_logo_23
        Me.pctAppLogo.InitialImage = Nothing
        Me.pctAppLogo.Location = New System.Drawing.Point(20, 11)
        Me.pctAppLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.pctAppLogo.Name = "pctAppLogo"
        Me.pctAppLogo.Size = New System.Drawing.Size(184, 77)
        Me.pctAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAppLogo.TabIndex = 565
        Me.pctAppLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.Farmers.My.Resources.Resources._3sdclTHE_2
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(262, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 567
        Me.PictureBox1.TabStop = False
        '
        'lnkTheme
        '
        Me.lnkTheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkTheme.BackColor = System.Drawing.Color.SteelBlue
        Me.lnkTheme.Image = Global.Farmers.My.Resources.Resources.lamp__1_
        Me.lnkTheme.ImageSize = 24
        Me.lnkTheme.Location = New System.Drawing.Point(912, 15)
        Me.lnkTheme.Name = "lnkTheme"
        Me.lnkTheme.NoFocusImage = Global.Farmers.My.Resources.Resources.lamp__2_
        Me.lnkTheme.Size = New System.Drawing.Size(38, 36)
        Me.lnkTheme.TabIndex = 568
        Me.lnkTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroToolTip1.SetToolTip(Me.lnkTheme, "theme")
        Me.lnkTheme.UseSelectable = True
        '
        'MetroLink2
        '
        Me.MetroLink2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLink2.BackColor = System.Drawing.Color.SteelBlue
        Me.MetroLink2.Image = Global.Farmers.My.Resources.Resources.language
        Me.MetroLink2.ImageSize = 24
        Me.MetroLink2.Location = New System.Drawing.Point(961, 15)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.NoFocusImage = Global.Farmers.My.Resources.Resources.language__1_
        Me.MetroLink2.Size = New System.Drawing.Size(38, 36)
        Me.MetroLink2.TabIndex = 569
        Me.MetroLink2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroToolTip1.SetToolTip(Me.MetroLink2, "language")
        Me.MetroLink2.UseSelectable = True
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtSearchBox.CustomButton.Image = Global.Farmers.My.Resources.Resources.search__2_
        Me.txtSearchBox.CustomButton.Location = New System.Drawing.Point(297, 1)
        Me.txtSearchBox.CustomButton.Name = ""
        Me.txtSearchBox.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtSearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchBox.CustomButton.TabIndex = 1
        Me.txtSearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchBox.CustomButton.UseSelectable = True
        Me.txtSearchBox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSearchBox.Icon = Global.Farmers.My.Resources.Resources.search__2_
        Me.txtSearchBox.Lines = New String(-1) {}
        Me.txtSearchBox.Location = New System.Drawing.Point(560, 16)
        Me.txtSearchBox.MaxLength = 32767
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBox.PromptText = "type to search"
        Me.txtSearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchBox.SelectedText = ""
        Me.txtSearchBox.SelectionLength = 0
        Me.txtSearchBox.SelectionStart = 0
        Me.txtSearchBox.ShortcutsEnabled = True
        Me.txtSearchBox.ShowButton = True
        Me.txtSearchBox.ShowClearButton = True
        Me.txtSearchBox.Size = New System.Drawing.Size(331, 35)
        Me.txtSearchBox.TabIndex = 570
        Me.txtSearchBox.UseSelectable = True
        Me.txtSearchBox.UseStyleColors = True
        Me.txtSearchBox.WaterMark = "type to search"
        Me.txtSearchBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchBox.WaterMarkFont = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.[Default]
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1300, 667)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSearchBox)
        Me.Controls.Add(Me.MetroLink2)
        Me.Controls.Add(Me.lnkTheme)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pctAppLogo)
        Me.Controls.Add(Me.mtabDashboard)
        Me.Controls.Add(Me.mtlExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.cntxUserProfile.ResumeLayout(False)
        Me.mtabDashboard.ResumeLayout(False)
        Me.tpgDashboard.ResumeLayout(False)
        Me.tpgDashboard.PerformLayout()
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAppLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mtlExit As MetroFramework.Controls.MetroLink
    Friend WithEvents cntxUserProfile As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents tsmMinimize As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmContextExit As ToolStripMenuItem
    Friend WithEvents mtabDashboard As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tpgDashboard As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mTileSent As MetroFramework.Controls.MetroTile
    Friend WithEvents msmMain As MetroFramework.Components.MetroStyleManager
    Friend WithEvents pctAppLogo As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkTheme As MetroFramework.Controls.MetroLink
    Friend WithEvents txtSearchBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lnkDashboard As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkSettings As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkReports As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkSynchronization As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkFarmers As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkStaff As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
