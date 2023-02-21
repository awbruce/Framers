Imports Farmers.theSaint

Public Class frmCamera
    Public CamMgr As TouchlessLib.TouchlessMgr

    Private Sub frmCamera_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Timer1.Enabled = False
            CamMgr.CurrentCamera.Dispose()
            CamMgr.Cameras.Item(cboCamera.SelectedIndex).Dispose()
            CamMgr.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmCamera_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            Me.StyleManager = msmChild
            applyThemeStyle(msmChild)

            cmdSave.Enabled = True
            CamMgr = New TouchlessLib.TouchlessMgr
            TempFileNames2 = ""

            For i As Integer = 0 To CamMgr.Cameras.Count - 1
                cboCamera.Items.Add(CamMgr.Cameras(i).ToString)
            Next

            If cboCamera.Items.Count > 0 Then
                cboCamera.SelectedIndex = 0
                Timer1.Enabled = True
            Else
                MsgBox("There is no Camera...")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboCamera_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCamera.SelectedIndexChanged
        Try
            CamMgr.CurrentCamera = CamMgr.Cameras.ElementAt(cboCamera.SelectedIndex)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        picFeed.Image = CamMgr.CurrentCamera.GetCurrentImage()
    End Sub

    Private Sub cmdCapture_Click(sender As Object, e As EventArgs) Handles cmdCapture.Click
        picPreview.Image = CamMgr.CurrentCamera.GetCurrentImage()
        cmdSave.Enabled = True
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Try
            Dim sTempFileName As String = System.IO.Path.GetTempFileName()
            TempFileNames2 = sTempFileName

            Dim b As Bitmap = picPreview.Image
            b.Save(sTempFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            Timer1.Enabled = False

            CamMgr.CurrentCamera.Dispose()
            CamMgr.Cameras.Item(cboCamera.SelectedIndex).Dispose()
            CamMgr.Dispose()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mtlExit_Click(sender As Object, e As EventArgs) Handles mtlExit.Click
        Me.Close()
    End Sub
End Class
