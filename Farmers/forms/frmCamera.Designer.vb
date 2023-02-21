<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCamera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCamera))
        Me.picPreview = New System.Windows.Forms.PictureBox()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.picFeed = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cboCamera = New MetroFramework.Controls.MetroComboBox()
        Me.cmdSave = New MetroFramework.Controls.MetroButton()
        Me.cmdCapture = New MetroFramework.Controls.MetroButton()
        Me.mtlExit = New MetroFramework.Controls.MetroLink()
        Me.msmChild = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.msmChild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPreview
        '
        Me.picPreview.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPreview.Location = New System.Drawing.Point(262, 13)
        Me.picPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(250, 265)
        Me.picPreview.TabIndex = 10
        Me.picPreview.TabStop = False
        '
        'picFeed
        '
        Me.picFeed.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFeed.Location = New System.Drawing.Point(4, 13)
        Me.picFeed.Margin = New System.Windows.Forms.Padding(4)
        Me.picFeed.Name = "picFeed"
        Me.picFeed.Size = New System.Drawing.Size(250, 265)
        Me.picFeed.TabIndex = 6
        Me.picFeed.TabStop = False
        '
        'Timer1
        '
        '
        'cboCamera
        '
        Me.cboCamera.FormattingEnabled = True
        Me.cboCamera.ItemHeight = 24
        Me.cboCamera.Location = New System.Drawing.Point(295, 74)
        Me.cboCamera.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCamera.Name = "cboCamera"
        Me.cboCamera.PromptText = "choose camera"
        Me.cboCamera.Size = New System.Drawing.Size(248, 30)
        Me.cboCamera.TabIndex = 565
        Me.cboCamera.UseSelectable = True
        '
        'cmdSave
        '
        Me.cmdSave.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.cmdSave.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.cmdSave.Location = New System.Drawing.Point(262, 285)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(250, 30)
        Me.cmdSave.TabIndex = 574
        Me.cmdSave.Text = "save"
        Me.cmdSave.UseSelectable = True
        Me.cmdSave.UseStyleColors = True
        '
        'cmdCapture
        '
        Me.cmdCapture.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.cmdCapture.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.cmdCapture.Location = New System.Drawing.Point(4, 285)
        Me.cmdCapture.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCapture.Name = "cmdCapture"
        Me.cmdCapture.Size = New System.Drawing.Size(250, 30)
        Me.cmdCapture.TabIndex = 573
        Me.cmdCapture.Text = "capture"
        Me.cmdCapture.UseSelectable = True
        Me.cmdCapture.UseStyleColors = True
        '
        'mtlExit
        '
        Me.mtlExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtlExit.Image = Global.Farmers.My.Resources.Resources.back_exit_icon
        Me.mtlExit.ImageSize = 36
        Me.mtlExit.Location = New System.Drawing.Point(532, 13)
        Me.mtlExit.Margin = New System.Windows.Forms.Padding(4, 13, 4, 13)
        Me.mtlExit.Name = "mtlExit"
        Me.mtlExit.NoFocusImage = Global.Farmers.My.Resources.Resources.back_exit_icon_faded
        Me.mtlExit.Size = New System.Drawing.Size(40, 40)
        Me.mtlExit.TabIndex = 575
        Me.MetroToolTip1.SetToolTip(Me.mtlExit, "close")
        Me.mtlExit.UseSelectable = True
        '
        'msmChild
        '
        Me.msmChild.Owner = Me
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(27, 74)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(525, 368)
        Me.MetroTabControl1.TabIndex = 576
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.cmdSave)
        Me.MetroTabPage1.Controls.Add(Me.picPreview)
        Me.MetroTabPage1.Controls.Add(Me.picFeed)
        Me.MetroTabPage1.Controls.Add(Me.cmdCapture)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(517, 326)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.[Default]
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'frmCamera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(579, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboCamera)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.mtlExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCamera"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "webcam"
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.msmChild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents picPreview As System.Windows.Forms.PictureBox
    Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents picFeed As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cboCamera As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmdSave As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdCapture As MetroFramework.Controls.MetroButton
    Friend WithEvents mtlExit As MetroFramework.Controls.MetroLink
    Friend WithEvents msmChild As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
