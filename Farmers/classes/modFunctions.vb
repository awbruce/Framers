

Namespace theSaint
    Module modFunctions
        Dim rnd As New Random
        Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

        Public Sub numbersOnly(e As Windows.Forms.KeyPressEventArgs)
            If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."c Then
                e.Handled = True
            End If
        End Sub

        Public Sub minimizeAll(parentForm As Form)
            For Each childForm As Form In parentForm.MdiChildren
                childForm.WindowState = FormWindowState.Minimized
            Next
        End Sub

        Public Sub closeAllForms()
            For Each chlFrm As Form In frmMain.MdiChildren
                chlFrm.Close()
            Next
        End Sub

        Public Sub closeForm(ByVal pForm As Form)
            pForm.Close()
        End Sub

        Public Function IsOpen(ByVal nameForm As String) As Boolean
            Dim isFound As Boolean = False

            For Each frm As Form In My.Application.OpenForms
                If frm.Name.Equals(nameForm) Then
                    isFound = True
                End If
            Next

            Return isFound
        End Function

        Sub manageFormLoad(ByVal pForm As MetroFramework.Forms.MetroForm, ByVal pFormName As String, ByVal pFormDescription As String, Optional ByVal pShowDialog As Boolean = False, Optional ByVal pVariable As Object = Nothing, Optional ByVal pUseOriginalSize As Boolean = True, Optional ByVal pMaximumSize As Boolean = True)
            Try
                pForm.Tag = pVariable
                pForm.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle

                If IsOpen(pFormName) = True Then Exit Sub

                With pForm
                    .Tag = pVariable
                    .Name = pFormName
                    .Text = pFormDescription
                    .ShowIcon = False
                    .ControlBox = False
                    .ShowInTaskbar = False

                    If pShowDialog = True Then
                        .StartPosition = FormStartPosition.CenterScreen
                        .MdiParent = frmMain

                        .Show()
                    Else
                        .MdiParent = frmMain
                        .StartPosition = FormStartPosition.CenterScreen

                        .Show()
                    End If

                End With
            Catch ex As Exception
            End Try
        End Sub

#Region "form style & theme"
        Public Sub applyThemeStyle(ByVal pMsM As MetroFramework.Components.MetroStyleManager)
            Dim th = GetSetting("Microsoft-Farmers", "settings", "theme")
            Dim st = GetSetting("Microsoft-Farmers", "settings", "style")

            If th Is "" Then
                sys_settings.SYSTEM_theme = 0
                SaveSetting("Microsoft-Farmers", "settings", "theme", sys_settings.SYSTEM_theme)
            End If

            If st Is "" Then
                sys_settings.SYSTEM_style = 0
                SaveSetting("Microsoft-Farmers", "settings", "style", sys_settings.SYSTEM_style)
            End If

            sys_settings.SYSTEM_theme = CInt(GetSetting("Microsoft-Farmers", "settings", "theme"))
            sys_settings.SYSTEM_style = CInt(GetSetting("Microsoft-Farmers", "settings", "style"))

            pMsM.Theme = DirectCast(Convert.ToInt32(sys_settings.SYSTEM_theme), MetroFramework.MetroThemeStyle)
            pMsM.Style = DirectCast(Convert.ToInt32(sys_settings.SYSTEM_style), MetroFramework.MetroColorStyle)

            SaveSetting("Microsoft-Farmers", "settings", "theme", sys_settings.SYSTEM_theme)
            SaveSetting("Microsoft-Farmers", "settings", "style", sys_settings.SYSTEM_style)
        End Sub
#End Region

    End Module

End Namespace
