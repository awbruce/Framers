<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.prgBar = New MetroFramework.Controls.MetroProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.msmMain = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.lblStatus = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.ErrorImage = CType(resources.GetObject("LogoPictureBox.ErrorImage"), System.Drawing.Image)
        Me.LogoPictureBox.Image = Global.Farmers.My.Resources.Resources.e_ADAPP_logo_23
        Me.LogoPictureBox.InitialImage = CType(resources.GetObject("LogoPictureBox.InitialImage"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(103, 78)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(295, 110)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 49
        Me.LogoPictureBox.TabStop = False
        '
        'prgBar
        '
        Me.prgBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.prgBar.Location = New System.Drawing.Point(27, 508)
        Me.prgBar.Margin = New System.Windows.Forms.Padding(4)
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(453, 21)
        Me.prgBar.TabIndex = 394
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'msmMain
        '
        Me.msmMain.Owner = Me
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(30, 484)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(44, 20)
        Me.lblStatus.TabIndex = 590
        Me.lblStatus.Text = "status"
        Me.lblStatus.UseStyleColors = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = Global.Farmers.My.Resources.Resources._3sdclTHE_2
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(157, 205)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 591
        Me.PictureBox1.TabStop = False
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(507, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.prgBar)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStart"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents prgBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents msmMain As MetroFramework.Components.MetroStyleManager
    Friend WithEvents lblStatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
