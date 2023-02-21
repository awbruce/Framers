Imports System.Threading
Imports Farmers.theSaint

Public Class frmMain
    Private Shared objMutex As Mutex = Nothing

    Private Sub setformAsMDI()
        Try
            Dim mdi = New MdiClient() With {
                 .Name = "mdi",
                 .BackColor = Color.White
            }

            Controls.AddRange(New Control() {mdi})
            IsMdiContainer = True

            Top = 0
            Left = 0
            Height = SystemInformation.WorkingArea.Height
            Width = SystemInformation.WorkingArea.Width
        Catch ex As Exception
        End Try
    End Sub

    Private Shared Sub SingleInstance()
        Try
            objMutex = New Mutex(False, "Farmers")
            If objMutex.WaitOne(0, False) = False Then
                objMutex.Close()
                objMutex = Nothing

                MetroFramework.MetroMessageBox.Show(frmMain, "Another instance is already running!", "", MessageBoxButtons.OK, MessageBoxIcon.Error, 200)
                End
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            CheckForIllegalCrossThreadCalls = False

            SingleInstance()

            Me.StyleManager = msmMain
            applyThemeStyle(msmMain)

            setformAsMDI()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mtlExit_Click(sender As Object, e As EventArgs) Handles mtlExit.Click
        cntxUserProfile.Show(mtlExit, 0, mtlExit.Height)
    End Sub

    Private Sub tsmContextExit_Click(sender As Object, e As EventArgs) Handles tsmContextExit.Click
        If MetroFramework.MetroMessageBox.Show(Me, "Shutdown" & "Farmers" & " ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 200) = Windows.Forms.DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub tsmExit_Click(sender As Object, e As EventArgs)
        If MetroFramework.MetroMessageBox.Show(Me, "Shutdown" & "Farmers" & " ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, 200) = Windows.Forms.DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub tsmMinimize_Click(sender As Object, e As EventArgs) Handles tsmMinimize.Click
        minimizeAll(Me)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles lnkTheme.Click
        manageFormLoad(New frmTheme, "_frmTheme", "theme", True)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lnkFarmers_Click(sender As Object, e As EventArgs) Handles lnkFarmers.Click
        manageFormLoad(New frmFarmersPage, "_frmFarmersPage", "", False)
    End Sub
End Class