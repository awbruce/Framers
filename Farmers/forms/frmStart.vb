Imports Farmers.theSaint

Public Class frmStart

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            prgBar.Visible = True
            prgBar.Value = prgBar.Value + 2

            If (prgBar.Value = 10) Then
                lblStatus.Text = "reading modules.."
            ElseIf (prgBar.Value = 20) Then
                lblStatus.Text = "turning on modules."
            ElseIf (prgBar.Value = 40) Then
                lblStatus.Text = "starting modules.."
            ElseIf (prgBar.Value = 60) Then
                lblStatus.Text = "loading modules.."
            ElseIf (prgBar.Value = 80) Then
                lblStatus.Text = "done loading modules.."
            ElseIf (prgBar.Value = 100) Then
                Me.Hide()

                frmMain.Show()
                Timer1.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = msmMain
        applyThemeStyle(msmMain)
    End Sub
End Class