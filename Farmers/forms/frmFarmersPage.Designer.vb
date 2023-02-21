<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFarmersPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFarmersPage))
        Me.ofdPicture = New System.Windows.Forms.OpenFileDialog()
        Me.pctImage = New System.Windows.Forms.PictureBox()
        Me.txtFirstName = New MetroFramework.Controls.MetroTextBox()
        Me.mtlExit = New MetroFramework.Controls.MetroLink()
        Me.mtabPersonalInfo = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage0 = New MetroFramework.Controls.MetroTabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMaritalStatus = New MetroFramework.Controls.MetroTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDistrict = New MetroFramework.Controls.MetroTextBox()
        Me.txtOccupation = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCommunity = New MetroFramework.Controls.MetroTextBox()
        Me.txtHouseNumber = New MetroFramework.Controls.MetroTextBox()
        Me.dtpDOB = New MetroFramework.Controls.MetroDateTime()
        Me.txtBirthPlace = New MetroFramework.Controls.MetroTextBox()
        Me.txtBio = New MetroFramework.Controls.MetroTextBox()
        Me.txtLastName = New MetroFramework.Controls.MetroTextBox()
        Me.lnkUpload = New MetroFramework.Controls.MetroLink()
        Me.lnkTakePhoto = New MetroFramework.Controls.MetroLink()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.cboRegion = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.msmChild = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        CType(Me.pctImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mtabPersonalInfo.SuspendLayout()
        Me.MetroTabPage0.SuspendLayout()
        CType(Me.msmChild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdPicture
        '
        Me.ofdPicture.FileName = "OpenFileDialog1"
        '
        'pctImage
        '
        Me.pctImage.ErrorImage = Global.Farmers.My.Resources.Resources.default_photo
        Me.pctImage.Image = Global.Farmers.My.Resources.Resources.default_photo
        Me.pctImage.InitialImage = Global.Farmers.My.Resources.Resources.default_photo
        Me.pctImage.Location = New System.Drawing.Point(32, 27)
        Me.pctImage.Name = "pctImage"
        Me.pctImage.Size = New System.Drawing.Size(185, 207)
        Me.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctImage.TabIndex = 579
        Me.pctImage.TabStop = False
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.White
        Me.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtFirstName.CustomButton.Image = Nothing
        Me.txtFirstName.CustomButton.Location = New System.Drawing.Point(259, 2)
        Me.txtFirstName.CustomButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtFirstName.CustomButton.Name = ""
        Me.txtFirstName.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFirstName.CustomButton.TabIndex = 1
        Me.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFirstName.CustomButton.UseSelectable = True
        Me.txtFirstName.CustomButton.Visible = False
        Me.txtFirstName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtFirstName.Lines = New String(-1) {}
        Me.txtFirstName.Location = New System.Drawing.Point(283, 53)
        Me.txtFirstName.MaxLength = 32767
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.SelectionLength = 0
        Me.txtFirstName.SelectionStart = 0
        Me.txtFirstName.ShortcutsEnabled = True
        Me.txtFirstName.ShowClearButton = True
        Me.txtFirstName.Size = New System.Drawing.Size(297, 40)
        Me.txtFirstName.TabIndex = 0
        Me.txtFirstName.UseSelectable = True
        Me.txtFirstName.UseStyleColors = True
        Me.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFirstName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtlExit
        '
        Me.mtlExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtlExit.Image = Global.Farmers.My.Resources.Resources.back_exit_icon
        Me.mtlExit.ImageSize = 36
        Me.mtlExit.Location = New System.Drawing.Point(1253, 13)
        Me.mtlExit.Margin = New System.Windows.Forms.Padding(4)
        Me.mtlExit.Name = "mtlExit"
        Me.mtlExit.NoFocusImage = Global.Farmers.My.Resources.Resources.back_exit_icon_faded
        Me.mtlExit.Size = New System.Drawing.Size(40, 40)
        Me.mtlExit.TabIndex = 467
        Me.MetroToolTip1.SetToolTip(Me.mtlExit, "close")
        Me.mtlExit.UseSelectable = True
        '
        'mtabPersonalInfo
        '
        Me.mtabPersonalInfo.Controls.Add(Me.MetroTabPage0)
        Me.mtabPersonalInfo.Controls.Add(Me.MetroTabPage1)
        Me.mtabPersonalInfo.Controls.Add(Me.MetroTabPage2)
        Me.mtabPersonalInfo.Controls.Add(Me.MetroTabPage3)
        Me.mtabPersonalInfo.Controls.Add(Me.MetroTabPage4)
        Me.mtabPersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mtabPersonalInfo.Location = New System.Drawing.Point(20, 60)
        Me.mtabPersonalInfo.Name = "mtabPersonalInfo"
        Me.mtabPersonalInfo.SelectedIndex = 0
        Me.mtabPersonalInfo.Size = New System.Drawing.Size(1260, 520)
        Me.mtabPersonalInfo.TabIndex = 14
        Me.mtabPersonalInfo.UseSelectable = True
        '
        'MetroTabPage0
        '
        Me.MetroTabPage0.Controls.Add(Me.MetroRadioButton2)
        Me.MetroTabPage0.Controls.Add(Me.Label13)
        Me.MetroTabPage0.Controls.Add(Me.MetroRadioButton1)
        Me.MetroTabPage0.Controls.Add(Me.Label12)
        Me.MetroTabPage0.Controls.Add(Me.txtMaritalStatus)
        Me.MetroTabPage0.Controls.Add(Me.Label11)
        Me.MetroTabPage0.Controls.Add(Me.Label9)
        Me.MetroTabPage0.Controls.Add(Me.Label10)
        Me.MetroTabPage0.Controls.Add(Me.txtDistrict)
        Me.MetroTabPage0.Controls.Add(Me.txtOccupation)
        Me.MetroTabPage0.Controls.Add(Me.Label8)
        Me.MetroTabPage0.Controls.Add(Me.Label7)
        Me.MetroTabPage0.Controls.Add(Me.Label6)
        Me.MetroTabPage0.Controls.Add(Me.Label5)
        Me.MetroTabPage0.Controls.Add(Me.Label4)
        Me.MetroTabPage0.Controls.Add(Me.Label3)
        Me.MetroTabPage0.Controls.Add(Me.Label2)
        Me.MetroTabPage0.Controls.Add(Me.txtCommunity)
        Me.MetroTabPage0.Controls.Add(Me.txtHouseNumber)
        Me.MetroTabPage0.Controls.Add(Me.dtpDOB)
        Me.MetroTabPage0.Controls.Add(Me.txtBirthPlace)
        Me.MetroTabPage0.Controls.Add(Me.txtBio)
        Me.MetroTabPage0.Controls.Add(Me.txtLastName)
        Me.MetroTabPage0.Controls.Add(Me.lnkUpload)
        Me.MetroTabPage0.Controls.Add(Me.lnkTakePhoto)
        Me.MetroTabPage0.Controls.Add(Me.btnSave)
        Me.MetroTabPage0.Controls.Add(Me.btnReset)
        Me.MetroTabPage0.Controls.Add(Me.txtFirstName)
        Me.MetroTabPage0.Controls.Add(Me.cboRegion)
        Me.MetroTabPage0.Controls.Add(Me.pctImage)
        Me.MetroTabPage0.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTabPage0.HorizontalScrollbarBarColor = True
        Me.MetroTabPage0.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage0.HorizontalScrollbarSize = 1
        Me.MetroTabPage0.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage0.Name = "MetroTabPage0"
        Me.MetroTabPage0.Size = New System.Drawing.Size(1252, 478)
        Me.MetroTabPage0.TabIndex = 10
        Me.MetroTabPage0.Text = "Item one   "
        Me.MetroTabPage0.VerticalScrollbarBarColor = True
        Me.MetroTabPage0.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage0.VerticalScrollbarSize = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(600, 358)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 26)
        Me.Label12.TabIndex = 605
        Me.Label12.Text = "Marital Status"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtMaritalStatus
        '
        Me.txtMaritalStatus.BackColor = System.Drawing.Color.White
        Me.txtMaritalStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtMaritalStatus.CustomButton.Image = Nothing
        Me.txtMaritalStatus.CustomButton.Location = New System.Drawing.Point(259, 2)
        Me.txtMaritalStatus.CustomButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtMaritalStatus.CustomButton.Name = ""
        Me.txtMaritalStatus.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtMaritalStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMaritalStatus.CustomButton.TabIndex = 1
        Me.txtMaritalStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMaritalStatus.CustomButton.UseSelectable = True
        Me.txtMaritalStatus.CustomButton.Visible = False
        Me.txtMaritalStatus.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMaritalStatus.Lines = New String(-1) {}
        Me.txtMaritalStatus.Location = New System.Drawing.Point(605, 387)
        Me.txtMaritalStatus.MaxLength = 32767
        Me.txtMaritalStatus.Name = "txtMaritalStatus"
        Me.txtMaritalStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaritalStatus.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMaritalStatus.SelectedText = ""
        Me.txtMaritalStatus.SelectionLength = 0
        Me.txtMaritalStatus.SelectionStart = 0
        Me.txtMaritalStatus.ShortcutsEnabled = True
        Me.txtMaritalStatus.ShowClearButton = True
        Me.txtMaritalStatus.Size = New System.Drawing.Size(297, 40)
        Me.txtMaritalStatus.TabIndex = 9
        Me.txtMaritalStatus.UseSelectable = True
        Me.txtMaritalStatus.UseStyleColors = True
        Me.txtMaritalStatus.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMaritalStatus.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(278, 358)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 26)
        Me.Label11.TabIndex = 603
        Me.Label11.Text = "Region"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(600, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 26)
        Me.Label9.TabIndex = 602
        Me.Label9.Text = "District"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(278, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 26)
        Me.Label10.TabIndex = 601
        Me.Label10.Text = "Occupation"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtDistrict
        '
        Me.txtDistrict.BackColor = System.Drawing.Color.White
        Me.txtDistrict.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtDistrict.CustomButton.Image = Nothing
        Me.txtDistrict.CustomButton.Location = New System.Drawing.Point(259, 2)
        Me.txtDistrict.CustomButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtDistrict.CustomButton.Name = ""
        Me.txtDistrict.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtDistrict.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDistrict.CustomButton.TabIndex = 1
        Me.txtDistrict.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDistrict.CustomButton.UseSelectable = True
        Me.txtDistrict.CustomButton.Visible = False
        Me.txtDistrict.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDistrict.Lines = New String(-1) {}
        Me.txtDistrict.Location = New System.Drawing.Point(605, 303)
        Me.txtDistrict.MaxLength = 32767
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDistrict.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDistrict.SelectedText = ""
        Me.txtDistrict.SelectionLength = 0
        Me.txtDistrict.SelectionStart = 0
        Me.txtDistrict.ShortcutsEnabled = True
        Me.txtDistrict.ShowClearButton = True
        Me.txtDistrict.Size = New System.Drawing.Size(297, 40)
        Me.txtDistrict.TabIndex = 7
        Me.txtDistrict.UseSelectable = True
        Me.txtDistrict.UseStyleColors = True
        Me.txtDistrict.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDistrict.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtOccupation
        '
        Me.txtOccupation.BackColor = System.Drawing.Color.White
        Me.txtOccupation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtOccupation.CustomButton.Image = Nothing
        Me.txtOccupation.CustomButton.Location = New System.Drawing.Point(259, 2)
        Me.txtOccupation.CustomButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtOccupation.CustomButton.Name = ""
        Me.txtOccupation.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtOccupation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOccupation.CustomButton.TabIndex = 1
        Me.txtOccupation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOccupation.CustomButton.UseSelectable = True
        Me.txtOccupation.CustomButton.Visible = False
        Me.txtOccupation.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtOccupation.Lines = New String(-1) {}
        Me.txtOccupation.Location = New System.Drawing.Point(283, 303)
        Me.txtOccupation.MaxLength = 32767
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOccupation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOccupation.SelectedText = ""
        Me.txtOccupation.SelectionLength = 0
        Me.txtOccupation.SelectionStart = 0
        Me.txtOccupation.ShortcutsEnabled = True
        Me.txtOccupation.ShowClearButton = True
        Me.txtOccupation.Size = New System.Drawing.Size(297, 40)
        Me.txtOccupation.TabIndex = 6
        Me.txtOccupation.UseSelectable = True
        Me.txtOccupation.UseStyleColors = True
        Me.txtOccupation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOccupation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(600, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 26)
        Me.Label8.TabIndex = 598
        Me.Label8.Text = "Community"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(278, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 26)
        Me.Label7.TabIndex = 597
        Me.Label7.Text = "House number"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(600, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 26)
        Me.Label6.TabIndex = 596
        Me.Label6.Text = "Date of birth"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(921, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 26)
        Me.Label5.TabIndex = 595
        Me.Label5.Text = "Bio"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(278, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 26)
        Me.Label4.TabIndex = 594
        Me.Label4.Text = "Birth place"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(600, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 26)
        Me.Label3.TabIndex = 593
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(278, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 26)
        Me.Label2.TabIndex = 469
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtCommunity
        '
        Me.txtCommunity.BackColor = System.Drawing.Color.White
        Me.txtCommunity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCommunity.CustomButton.Image = Nothing
        Me.txtCommunity.CustomButton.Location = New System.Drawing.Point(259, 2)
        Me.txtCommunity.CustomButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtCommunity.CustomButton.Name = ""
        Me.txtCommunity.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtCommunity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCommunity.CustomButton.TabIndex = 1
        Me.txtCommunity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCommunity.CustomButton.UseSelectable = True
        Me.txtCommunity.CustomButton.Visible = False
        Me.txtCommunity.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCommunity.Lines = New String(-1) {}
        Me.txtCommunity.Location = New System.Drawing.Point(605, 223)
        Me.txtCommunity.MaxLength = 32767
        Me.txtCommunity.Name = "txtCommunity"
        Me.txtCommunity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCommunity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCommunity.SelectedText = ""
        Me.txtCommunity.SelectionLength = 0
        Me.txtCommunity.SelectionStart = 0
        Me.txtCommunity.ShortcutsEnabled = True
        Me.txtCommunity.ShowClearButton = True
        Me.txtCommunity.Size = New System.Drawing.Size(297, 40)
        Me.txtCommunity.TabIndex = 5
        Me.txtCommunity.UseSelectable = True
        Me.txtCommunity.UseStyleColors = True
        Me.txtCommunity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCommunity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtHouseNumber
        '
        Me.txtHouseNumber.BackColor = System.Drawing.Color.White
        Me.txtHouseNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtHouseNumber.CustomButton.Image = Nothing
        Me.txtHouseNumber.CustomButton.Location = New System.Drawing.Point(259, 2)
        Me.txtHouseNumber.CustomButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtHouseNumber.CustomButton.Name = ""
        Me.txtHouseNumber.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtHouseNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtHouseNumber.CustomButton.TabIndex = 1
        Me.txtHouseNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtHouseNumber.CustomButton.UseSelectable = True
        Me.txtHouseNumber.CustomButton.Visible = False
        Me.txtHouseNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtHouseNumber.Lines = New String(-1) {}
        Me.txtHouseNumber.Location = New System.Drawing.Point(283, 223)
        Me.txtHouseNumber.MaxLength = 32767
        Me.txtHouseNumber.Name = "txtHouseNumber"
        Me.txtHouseNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHouseNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtHouseNumber.SelectedText = ""
        Me.txtHouseNumber.SelectionLength = 0
        Me.txtHouseNumber.SelectionStart = 0
        Me.txtHouseNumber.ShortcutsEnabled = True
        Me.txtHouseNumber.ShowClearButton = True
        Me.txtHouseNumber.Size = New System.Drawing.Size(297, 40)
        Me.txtHouseNumber.TabIndex = 4
        Me.txtHouseNumber.UseSelectable = True
        Me.txtHouseNumber.UseStyleColors = True
        Me.txtHouseNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtHouseNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(605, 136)
        Me.dtpDOB.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(297, 34)
        Me.dtpDOB.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtpDOB.TabIndex = 3
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.BackColor = System.Drawing.Color.White
        Me.txtBirthPlace.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtBirthPlace.CustomButton.Image = Nothing
        Me.txtBirthPlace.CustomButton.Location = New System.Drawing.Point(259, 2)
        Me.txtBirthPlace.CustomButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtBirthPlace.CustomButton.Name = ""
        Me.txtBirthPlace.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtBirthPlace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBirthPlace.CustomButton.TabIndex = 1
        Me.txtBirthPlace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBirthPlace.CustomButton.UseSelectable = True
        Me.txtBirthPlace.CustomButton.Visible = False
        Me.txtBirthPlace.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtBirthPlace.Lines = New String(-1) {}
        Me.txtBirthPlace.Location = New System.Drawing.Point(283, 134)
        Me.txtBirthPlace.MaxLength = 32767
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBirthPlace.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBirthPlace.SelectedText = ""
        Me.txtBirthPlace.SelectionLength = 0
        Me.txtBirthPlace.SelectionStart = 0
        Me.txtBirthPlace.ShortcutsEnabled = True
        Me.txtBirthPlace.ShowClearButton = True
        Me.txtBirthPlace.Size = New System.Drawing.Size(297, 40)
        Me.txtBirthPlace.TabIndex = 2
        Me.txtBirthPlace.UseSelectable = True
        Me.txtBirthPlace.UseStyleColors = True
        Me.txtBirthPlace.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBirthPlace.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBio
        '
        Me.txtBio.BackColor = System.Drawing.Color.White
        Me.txtBio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtBio.CustomButton.Image = Nothing
        Me.txtBio.CustomButton.Location = New System.Drawing.Point(149, 1)
        Me.txtBio.CustomButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtBio.CustomButton.Name = ""
        Me.txtBio.CustomButton.Size = New System.Drawing.Size(147, 147)
        Me.txtBio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBio.CustomButton.TabIndex = 1
        Me.txtBio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBio.CustomButton.UseSelectable = True
        Me.txtBio.CustomButton.Visible = False
        Me.txtBio.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtBio.Lines = New String(-1) {}
        Me.txtBio.Location = New System.Drawing.Point(926, 53)
        Me.txtBio.MaxLength = 32767
        Me.txtBio.Multiline = True
        Me.txtBio.Name = "txtBio"
        Me.txtBio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBio.PromptText = "Write a short introduction"
        Me.txtBio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBio.SelectedText = ""
        Me.txtBio.SelectionLength = 0
        Me.txtBio.SelectionStart = 0
        Me.txtBio.ShortcutsEnabled = True
        Me.txtBio.ShowClearButton = True
        Me.txtBio.Size = New System.Drawing.Size(297, 149)
        Me.txtBio.TabIndex = 10
        Me.txtBio.UseSelectable = True
        Me.txtBio.UseStyleColors = True
        Me.txtBio.WaterMark = "Write a short introduction"
        Me.txtBio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBio.WaterMarkFont = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.White
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtLastName.CustomButton.Image = Nothing
        Me.txtLastName.CustomButton.Location = New System.Drawing.Point(259, 2)
        Me.txtLastName.CustomButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtLastName.CustomButton.Name = ""
        Me.txtLastName.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLastName.CustomButton.TabIndex = 1
        Me.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLastName.CustomButton.UseSelectable = True
        Me.txtLastName.CustomButton.Visible = False
        Me.txtLastName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtLastName.Lines = New String(-1) {}
        Me.txtLastName.Location = New System.Drawing.Point(605, 53)
        Me.txtLastName.MaxLength = 32767
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.SelectionLength = 0
        Me.txtLastName.SelectionStart = 0
        Me.txtLastName.ShortcutsEnabled = True
        Me.txtLastName.ShowClearButton = True
        Me.txtLastName.Size = New System.Drawing.Size(297, 40)
        Me.txtLastName.TabIndex = 1
        Me.txtLastName.UseSelectable = True
        Me.txtLastName.UseStyleColors = True
        Me.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLastName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lnkUpload
        '
        Me.lnkUpload.Image = Global.Farmers.My.Resources.Resources.upload
        Me.lnkUpload.ImageSize = 36
        Me.lnkUpload.Location = New System.Drawing.Point(123, 241)
        Me.lnkUpload.Margin = New System.Windows.Forms.Padding(4)
        Me.lnkUpload.Name = "lnkUpload"
        Me.lnkUpload.NoFocusImage = Global.Farmers.My.Resources.Resources.upload
        Me.lnkUpload.Size = New System.Drawing.Size(94, 71)
        Me.lnkUpload.TabIndex = 582
        Me.lnkUpload.Text = "Upload Photo"
        Me.lnkUpload.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroToolTip1.SetToolTip(Me.lnkUpload, "close")
        Me.lnkUpload.UseSelectable = True
        '
        'lnkTakePhoto
        '
        Me.lnkTakePhoto.Image = Global.Farmers.My.Resources.Resources.camera
        Me.lnkTakePhoto.ImageSize = 36
        Me.lnkTakePhoto.Location = New System.Drawing.Point(23, 241)
        Me.lnkTakePhoto.Margin = New System.Windows.Forms.Padding(4)
        Me.lnkTakePhoto.Name = "lnkTakePhoto"
        Me.lnkTakePhoto.NoFocusImage = Global.Farmers.My.Resources.Resources.camera
        Me.lnkTakePhoto.Size = New System.Drawing.Size(92, 71)
        Me.lnkTakePhoto.TabIndex = 581
        Me.lnkTakePhoto.Text = "Take Photo"
        Me.lnkTakePhoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroToolTip1.SetToolTip(Me.lnkTakePhoto, "close")
        Me.lnkTakePhoto.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(1131, 433)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 35)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "save"
        Me.btnSave.UseCustomForeColor = True
        Me.btnSave.UseSelectable = True
        Me.btnSave.UseStyleColors = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnReset.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnReset.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(1036, 433)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(92, 35)
        Me.btnReset.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "reset"
        Me.btnReset.UseCustomBackColor = True
        Me.btnReset.UseCustomForeColor = True
        Me.btnReset.UseSelectable = True
        Me.btnReset.UseStyleColors = True
        '
        'cboRegion
        '
        Me.cboRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboRegion.FormattingEnabled = True
        Me.cboRegion.ItemHeight = 24
        Me.cboRegion.Items.AddRange(New Object() {"FEMALE", "MALE"})
        Me.cboRegion.Location = New System.Drawing.Point(283, 387)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(297, 30)
        Me.cboRegion.TabIndex = 8
        Me.cboRegion.UseSelectable = True
        Me.cboRegion.UseStyleColors = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 1
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1252, 447)
        Me.MetroTabPage1.TabIndex = 11
        Me.MetroTabPage1.Text = "Item two   "
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 2
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 1
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1252, 447)
        Me.MetroTabPage2.TabIndex = 12
        Me.MetroTabPage2.Text = "Item three   "
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 2
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 1
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(1252, 447)
        Me.MetroTabPage3.TabIndex = 13
        Me.MetroTabPage3.Text = "Item four   "
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 2
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.HorizontalScrollbarSize = 1
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(1252, 447)
        Me.MetroTabPage4.TabIndex = 14
        Me.MetroTabPage4.Text = "Item five   "
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.VerticalScrollbarSize = 2
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.[Default]
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'msmChild
        '
        Me.msmChild.Owner = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 36)
        Me.Label1.TabIndex = 468
        Me.Label1.Text = "Personal Details"
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.MetroRadioButton1.Location = New System.Drawing.Point(32, 388)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(58, 20)
        Me.MetroRadioButton1.TabIndex = 606
        Me.MetroRadioButton1.Text = "Male"
        Me.MetroRadioButton1.UseSelectable = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(27, 359)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 26)
        Me.Label13.TabIndex = 607
        Me.Label13.Text = "Gender"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.MetroRadioButton2.Location = New System.Drawing.Point(110, 388)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(73, 20)
        Me.MetroRadioButton2.TabIndex = 608
        Me.MetroRadioButton2.Text = "Female"
        Me.MetroRadioButton2.UseSelectable = True
        '
        'frmFarmersPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1300, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtabPersonalInfo)
        Me.Controls.Add(Me.mtlExit)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFarmersPage"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        CType(Me.pctImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mtabPersonalInfo.ResumeLayout(False)
        Me.MetroTabPage0.ResumeLayout(False)
        Me.MetroTabPage0.PerformLayout()
        CType(Me.msmChild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ofdPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pctImage As System.Windows.Forms.PictureBox
    Friend WithEvents txtFirstName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtlExit As MetroFramework.Controls.MetroLink
    Friend WithEvents mtabPersonalInfo As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents msmChild As MetroFramework.Components.MetroStyleManager
    Friend WithEvents cboRegion As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabPage0 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents lnkUpload As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkTakePhoto As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLastName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCommunity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtHouseNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtpDOB As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtBirthPlace As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMaritalStatus As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDistrict As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtOccupation As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
End Class
