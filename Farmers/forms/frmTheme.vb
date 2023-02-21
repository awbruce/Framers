Imports Farmers.theSaint

Public Class frmTheme
    Private Sub saveThemeStyle()
        Try
            msmMain.Theme = DirectCast(Convert.ToInt32(sys_settings.SYSTEM_theme), MetroFramework.MetroThemeStyle)
            msmMain.Style = DirectCast(Convert.ToInt32(sys_settings.SYSTEM_style), MetroFramework.MetroColorStyle)

            frmMain.msmMain.Theme = DirectCast(Convert.ToInt32(sys_settings.SYSTEM_theme), MetroFramework.MetroThemeStyle)
            frmMain.msmMain.Style = DirectCast(Convert.ToInt32(sys_settings.SYSTEM_style), MetroFramework.MetroColorStyle)

            Dim ctlMDI As MdiClient
            For Each ctl As Control In frmMain.Controls
                Try
                    ctlMDI = DirectCast(ctl, MdiClient)

                    If LCase(cboTheme.Text) = LCase("dark") Then
                        ctlMDI.BackColor = Color.Black
                    Else
                        ctlMDI.BackColor = Color.White
                    End If
                Catch exc As InvalidCastException
                End Try
            Next

            SaveSetting("Microsoft-Farmers", "settings", "theme", sys_settings.SYSTEM_theme)
            SaveSetting("Microsoft-Farmers", "settings", "style", sys_settings.SYSTEM_style)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboTheme_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTheme.SelectionChangeCommitted
        sys_settings.SYSTEM_theme = cboTheme.SelectedIndex
        saveThemeStyle()
    End Sub

    Private Sub mtlBlack_Click(sender As Object, e As EventArgs) Handles mtlBlack.Click
        sys_settings.SYSTEM_style = 1
        saveThemeStyle()
    End Sub

    Private Sub mtlBlue_Click(sender As Object, e As EventArgs) Handles mtlBlue.Click
        sys_settings.SYSTEM_style = 4
        saveThemeStyle()
    End Sub

    Private Sub mtlGreen_Click(sender As Object, e As EventArgs) Handles mtlGreen.Click
        sys_settings.SYSTEM_style = 5
        saveThemeStyle()
    End Sub

    Private Sub mtlLime_Click(sender As Object, e As EventArgs) Handles mtlLime.Click
        sys_settings.SYSTEM_style = 6
        saveThemeStyle()
    End Sub

    Private Sub mtlTeal_Click(sender As Object, e As EventArgs) Handles mtlTeal.Click
        sys_settings.SYSTEM_style = 7
        saveThemeStyle()
    End Sub

    Private Sub mtlOrange_Click(sender As Object, e As EventArgs) Handles mtlOrange.Click
        sys_settings.SYSTEM_style = 8
        saveThemeStyle()
    End Sub

    Private Sub mtlBrown_Click(sender As Object, e As EventArgs) Handles mtlBrown.Click
        sys_settings.SYSTEM_style = 9
        saveThemeStyle()
    End Sub

    Private Sub mtlMagenta_Click(sender As Object, e As EventArgs) Handles mtlMagenta.Click
        sys_settings.SYSTEM_style = 11
        saveThemeStyle()
    End Sub

    Private Sub mtlPurple_Click(sender As Object, e As EventArgs) Handles mtlPurple.Click
        sys_settings.SYSTEM_style = 12
        saveThemeStyle()
    End Sub

    Private Sub mtlRed_Click(sender As Object, e As EventArgs) Handles mtlRed.Click
        sys_settings.SYSTEM_style = 13
        saveThemeStyle()
    End Sub

    Private Sub frmTheme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = msmMain
        applyThemeStyle(msmMain)
    End Sub

    Private Sub mtlExit_Click(sender As Object, e As EventArgs) Handles mtlExit.Click
        Me.Close()
    End Sub
End Class