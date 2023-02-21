<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTheme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTheme))
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.cboTheme = New MetroFramework.Controls.MetroComboBox()
        Me.mtlRed = New MetroFramework.Controls.MetroTile()
        Me.mtlPurple = New MetroFramework.Controls.MetroTile()
        Me.mtlMagenta = New MetroFramework.Controls.MetroTile()
        Me.mtlBrown = New MetroFramework.Controls.MetroTile()
        Me.mtlOrange = New MetroFramework.Controls.MetroTile()
        Me.mtlTeal = New MetroFramework.Controls.MetroTile()
        Me.mtlLime = New MetroFramework.Controls.MetroTile()
        Me.mtlGreen = New MetroFramework.Controls.MetroTile()
        Me.mtlBlue = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mtlBlack = New MetroFramework.Controls.MetroTile()
        Me.msmMain = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.mtlExit = New MetroFramework.Controls.MetroLink()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Location = New System.Drawing.Point(10, 10)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(140, 24)
        Me.MetroLabel6.TabIndex = 583
        Me.MetroLabel6.Text = "theme"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cboTheme
        '
        Me.cboTheme.FormattingEnabled = True
        Me.cboTheme.ItemHeight = 24
        Me.cboTheme.Items.AddRange(New Object() {"Default", "Light", "Dark"})
        Me.cboTheme.Location = New System.Drawing.Point(10, 37)
        Me.cboTheme.Name = "cboTheme"
        Me.cboTheme.Size = New System.Drawing.Size(258, 30)
        Me.cboTheme.TabIndex = 582
        Me.cboTheme.UseSelectable = True
        '
        'mtlRed
        '
        Me.mtlRed.ActiveControl = Nothing
        Me.mtlRed.Location = New System.Drawing.Point(222, 151)
        Me.mtlRed.Margin = New System.Windows.Forms.Padding(4)
        Me.mtlRed.Name = "mtlRed"
        Me.mtlRed.Size = New System.Drawing.Size(46, 41)
        Me.mtlRed.Style = MetroFramework.MetroColorStyle.Red
        Me.mtlRed.TabIndex = 581
        Me.mtlRed.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtlRed.UseSelectable = True
        Me.mtlRed.UseTileImage = True
        '
        'mtlPurple
        '
        Me.mtlPurple.ActiveControl = Nothing
        Me.mtlPurple.Location = New System.Drawing.Point(169, 151)
        Me.mtlPurple.Margin = New System.Windows.Forms.Padding(4)
        Me.mtlPurple.Name = "mtlPurple"
        Me.mtlPurple.Size = New System.Drawing.Size(46, 41)
        Me.mtlPurple.Style = MetroFramework.MetroColorStyle.Purple
        Me.mtlPurple.TabIndex = 580
        Me.mtlPurple.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtlPurple.UseSelectable = True
        Me.mtlPurple.UseTileImage = True
        '
        'mtlMagenta
        '
        Me.mtlMagenta.ActiveControl = Nothing
        Me.mtlMagenta.Location = New System.Drawing.Point(116, 151)
        Me.mtlMagenta.Margin = New System.Windows.Forms.Padding(4)
        Me.mtlMagenta.Name = "mtlMagenta"
        Me.mtlMagenta.Size = New System.Drawing.Size(46, 41)
        Me.mtlMagenta.Style = MetroFramework.MetroColorStyle.Magenta
        Me.mtlMagenta.TabIndex = 579
        Me.mtlMagenta.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtlMagenta.UseSelectable = True
        Me.mtlMagenta.UseTileImage = True
        '
        'mtlBrown
        '
        Me.mtlBrown.ActiveControl = Nothing
        Me.mtlBrown.Location = New System.Drawing.Point(63, 151)
        Me.mtlBrown.Margin = New System.Windows.Forms.Padding(4)
        Me.mtlBrown.Name = "mtlBrown"
        Me.mtlBrown.Size = New System.Drawing.Size(46, 41)
        Me.mtlBrown.Style = MetroFramework.MetroColorStyle.Brown
        Me.mtlBrown.TabIndex = 578
        Me.mtlBrown.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtlBrown.UseSelectable = True
        Me.mtlBrown.UseTileImage = True
        '
        'mtlOrange
        '
        Me.mtlOrange.ActiveControl = Nothing
        Me.mtlOrange.Location = New System.Drawing.Point(10, 151)
        Me.mtlOrange.Margin = New System.Windows.Forms.Padding(4)
        Me.mtlOrange.Name = "mtlOrange"
        Me.mtlOrange.Size = New System.Drawing.Size(46, 41)
        Me.mtlOrange.Style = MetroFramework.MetroColorStyle.Orange
        Me.mtlOrange.TabIndex = 577
        Me.mtlOrange.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtlOrange.UseSelectable = True
        Me.mtlOrange.UseTileImage = True
        '
        'mtlTeal
        '
        Me.mtlTeal.ActiveControl = Nothing
        Me.mtlTeal.Location = New System.Drawing.Point(222, 102)
        Me.mtlTeal.Margin = New System.Windows.Forms.Padding(4)
        Me.mtlTeal.Name = "mtlTeal"
        Me.mtlTeal.Size = New System.Drawing.Size(46, 41)
        Me.mtlTeal.Style = MetroFramework.MetroColorStyle.Teal
        Me.mtlTeal.TabIndex = 576
        Me.mtlTeal.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtlTeal.UseSelectable = True
        Me.mtlTeal.UseTileImage = True
        '
        'mtlLime
        '
        Me.mtlLime.ActiveControl = Nothing
        Me.mtlLime.Location = New System.Drawing.Point(169, 102)
        Me.mtlLime.Margin = New System.Windows.Forms.Padding(4)
        Me.mtlLime.Name = "mtlLime"
        Me.mtlLime.Size = New System.Drawing.Size(46, 41)
        Me.mtlLime.Style = MetroFramework.MetroColorStyle.Lime
        Me.mtlLime.TabIndex = 575
        Me.mtlLime.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtlLime.UseSelectable = True
        Me.mtlLime.UseTileImage = True
        '
        'mtlGreen
        '
        Me.mtlGreen.ActiveControl = Nothing
        Me.mtlGreen.Location = New System.Drawing.Point(116, 102)
        Me.mtlGreen.Margin = New System.Windows.Forms.Padding(4)
        Me.mtlGreen.Name = "mtlGreen"
        Me.mtlGreen.Size = New System.Drawing.Size(46, 41)
        Me.mtlGreen.Style = MetroFramework.MetroColorStyle.Green
        Me.mtlGreen.TabIndex = 574
        Me.mtlGreen.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtlGreen.UseSelectable = True
        Me.mtlGreen.UseTileImage = True
        '
        'mtlBlue
        '
        Me.mtlBlue.ActiveControl = Nothing
        Me.mtlBlue.Location = New System.Drawing.Point(63, 102)
        Me.mtlBlue.Margin = New System.Windows.Forms.Padding(4)
        Me.mtlBlue.Name = "mtlBlue"
        Me.mtlBlue.Size = New System.Drawing.Size(46, 41)
        Me.mtlBlue.TabIndex = 573
        Me.mtlBlue.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtlBlue.UseSelectable = True
        Me.mtlBlue.UseTileImage = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Location = New System.Drawing.Point(10, 73)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(140, 24)
        Me.MetroLabel3.TabIndex = 572
        Me.MetroLabel3.Text = "colour"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'mtlBlack
        '
        Me.mtlBlack.ActiveControl = Nothing
        Me.mtlBlack.Location = New System.Drawing.Point(10, 102)
        Me.mtlBlack.Margin = New System.Windows.Forms.Padding(4)
        Me.mtlBlack.Name = "mtlBlack"
        Me.mtlBlack.Size = New System.Drawing.Size(46, 41)
        Me.mtlBlack.Style = MetroFramework.MetroColorStyle.Black
        Me.mtlBlack.TabIndex = 571
        Me.mtlBlack.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtlBlack.UseSelectable = True
        Me.mtlBlack.UseTileImage = True
        '
        'msmMain
        '
        Me.msmMain.Owner = Me
        '
        'mtlExit
        '
        Me.mtlExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtlExit.Image = Global.Farmers.My.Resources.Resources.back_exit_icon
        Me.mtlExit.ImageSize = 30
        Me.mtlExit.Location = New System.Drawing.Point(295, 12)
        Me.mtlExit.Margin = New System.Windows.Forms.Padding(4, 11, 4, 11)
        Me.mtlExit.Name = "mtlExit"
        Me.mtlExit.NoFocusImage = Global.Farmers.My.Resources.Resources.back_exit_icon_faded
        Me.mtlExit.Size = New System.Drawing.Size(37, 35)
        Me.mtlExit.TabIndex = 584
        Me.mtlExit.UseSelectable = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(27, 74)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(286, 241)
        Me.MetroTabControl1.TabIndex = 585
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage1.Controls.Add(Me.cboTheme)
        Me.MetroTabPage1.Controls.Add(Me.mtlBlack)
        Me.MetroTabPage1.Controls.Add(Me.mtlRed)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.mtlPurple)
        Me.MetroTabPage1.Controls.Add(Me.mtlBlue)
        Me.MetroTabPage1.Controls.Add(Me.mtlMagenta)
        Me.MetroTabPage1.Controls.Add(Me.mtlGreen)
        Me.MetroTabPage1.Controls.Add(Me.mtlBrown)
        Me.MetroTabPage1.Controls.Add(Me.mtlLime)
        Me.MetroTabPage1.Controls.Add(Me.mtlOrange)
        Me.MetroTabPage1.Controls.Add(Me.mtlTeal)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(278, 199)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'frmTheme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(340, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.mtlExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTheme"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboTheme As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mtlRed As MetroFramework.Controls.MetroTile
    Friend WithEvents mtlPurple As MetroFramework.Controls.MetroTile
    Friend WithEvents mtlMagenta As MetroFramework.Controls.MetroTile
    Friend WithEvents mtlBrown As MetroFramework.Controls.MetroTile
    Friend WithEvents mtlOrange As MetroFramework.Controls.MetroTile
    Friend WithEvents mtlTeal As MetroFramework.Controls.MetroTile
    Friend WithEvents mtlLime As MetroFramework.Controls.MetroTile
    Friend WithEvents mtlGreen As MetroFramework.Controls.MetroTile
    Friend WithEvents mtlBlue As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtlBlack As MetroFramework.Controls.MetroTile
    Friend WithEvents msmMain As MetroFramework.Components.MetroStyleManager
    Friend WithEvents mtlExit As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
End Class
