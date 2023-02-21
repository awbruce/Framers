Public Class clClearControls

    'clear textboxes
    Public Sub clearTextBox(ByVal cControls As Control.ControlCollection)
        Dim x As Control

        For Each x In cControls
            If TypeOf x Is TextBox Then
                CType(x, TextBox).Text = ""
            End If

            If x.Controls.Count > 0 Then clearTextBox(x.Controls)
        Next
    End Sub

    'clear masked textboxes
    Public Sub clearMaskedTextBox(ByVal cControls As Control.ControlCollection)
        Dim x As Control

        For Each x In cControls
            If TypeOf x Is MaskedTextBox Then
                CType(x, MaskedTextBox).Text = ""
            End If
            If x.Controls.Count > 0 Then clearMaskedTextBox(x.Controls)
        Next
    End Sub

    'clear radio buttons
    Public Sub clearRadioButton(ByVal cControls As Control.ControlCollection)
        Dim x As Control

        For Each x In cControls
            If TypeOf x Is RadioButton Then
                CType(x, RadioButton).Checked = False
            End If
            If x.Controls.Count > 0 Then clearRadioButton(x.Controls)
        Next
    End Sub

    'clear combo box
    Public Sub clearComboBox(ByVal cControls As Control.ControlCollection)
        Dim x As Control

        For Each x In cControls
            If TypeOf x Is ComboBox Then
                CType(x, ComboBox).SelectedIndex = -1
            End If
            If x.Controls.Count > 0 Then clearComboBox(x.Controls)
        Next
    End Sub

    'clear check box
    Public Sub clearCheckBox(ByVal cControls As Control.ControlCollection)
        Dim x As Control

        For Each x In cControls
            If TypeOf x Is CheckBox Then
                CType(x, CheckBox).Checked = False
            End If
            If x.Controls.Count > 0 Then clearCheckBox(x.Controls)
        Next
    End Sub

    'clear list view
    Public Sub clearListView(ByVal cControls As Control.ControlCollection)
        Dim x As Control

        For Each x In cControls
            If TypeOf x Is ListView Then
                CType(x, ListView).Items.Clear()
            End If
            If x.Controls.Count > 0 Then clearListView(x.Controls)
        Next
    End Sub

    'clear data grid view
    Public Sub clearDataGridView(ByVal cControls As Control.ControlCollection)
        Dim x As Control

        For Each x In cControls
            If TypeOf x Is DataGridView Then
                CType(x, DataGridView).Rows.Clear()
            End If
            If x.Controls.Count > 0 Then clearDataGridView(x.Controls)
        Next
    End Sub

    'clear list box
    Public Sub clearListBox(ByVal cControls As Control.ControlCollection)
        Dim x As Control

        For Each x In cControls
            If TypeOf x Is ListBox Then
                CType(x, ListBox).Items.Clear()
            End If
            If x.Controls.Count > 0 Then clearListBox(x.Controls)
        Next
    End Sub

    'clear picture box
    Public Sub clearPictureBox(ByVal cControls As Control.ControlCollection)
        Dim x As Control

        For Each x In cControls
            If TypeOf x Is PictureBox Then
                CType(x, PictureBox).Image = My.Resources.default_photo
            End If
            If x.Controls.Count > 0 Then clearPictureBox(x.Controls)
        Next
    End Sub
End Class

