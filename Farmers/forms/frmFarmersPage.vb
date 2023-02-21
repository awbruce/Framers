Imports System.IO
Imports Farmers.theSaint
Imports MetroFramework.Controls

Public Class frmFarmersPage
    ReadOnly cl As New clClearControls
    Public pPhotoName As String = ""
    Public IsImageChanged As Boolean = False

    Private Sub cleardetails()
        With cl
            .clearComboBox(Me.Controls)
            .clearTextBox(Me.Controls)
            .clearPictureBox(Me.Controls)
            .clearMaskedTextBox(Me.Controls)
        End With
    End Sub

    Private Sub mtlExit_Click(sender As Object, e As EventArgs) Handles mtlExit.Click
        closeForm(Me)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cleardetails()
    End Sub

    Private Sub lnkUpload_Click(sender As Object, e As EventArgs) Handles lnkUpload.Click
        Try
            ofdPicture.FileName = ""
            ofdPicture.FilterIndex = 1
            ofdPicture.DefaultExt = "jpg"
            ofdPicture.Multiselect = False
            ofdPicture.Title = "Select Picture"
            ofdPicture.Filter = "JPEG Files|*.jpg|Bitmap Files|*.bmp|Gif Files|*.gif"

            ofdPicture.ShowDialog()

            If String.IsNullOrEmpty(ofdPicture.FileName) Then
                'pctImage.Image = Global.Farmers.My.Resources.Resources.default_photo
            Else
                pctImage.Image = Image.FromFile(ofdPicture.FileName)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lnkTakePhoto_Click(sender As Object, e As EventArgs) Handles lnkTakePhoto.Click
        Try
            Dim k As New frmCamera
            k.ShowDialog()
            If TempFileNames2.Length > 0 Then

                'pctImage.Image = Image.FromFile(TempFileNames2)
                pPhotoName = TempFileNames2
                IsImageChanged = True

                If String.IsNullOrEmpty(TempFileNames2) Then
                    pctImage.Image = Global.Farmers.My.Resources.Resources.default_photo
                Else
                    pctImage.Image = Image.FromFile(TempFileNames2)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmFarmersPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = msmChild
        applyThemeStyle(msmChild)
    End Sub
End Class