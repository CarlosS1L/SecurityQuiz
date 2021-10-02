Public Class UserControl8
    Public Shared ans8 As Integer
    Private Sub CheckBoxq8C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq8C.CheckedChanged
        If Me.CheckBoxq8C.Checked = True Then
            If Me.CheckBoxq8B.Checked = True Then
                Me.CheckBoxq8B.Checked = False
            End If
            If Me.CheckBoxq8A.Checked = True Then
                Me.CheckBoxq8A.Checked = False
            End If
            If Me.CheckBoxq8D.Checked = True Then
                Me.CheckBoxq8D.Checked = False
            End If
            ans8 = 0
        End If
    End Sub

    Private Sub CheckBoxq8B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq8B.CheckedChanged
        If Me.CheckBoxq8B.Checked = True Then
            If Me.CheckBoxq8A.Checked = True Then
                Me.CheckBoxq8A.Checked = False
            End If
            If Me.CheckBoxq8C.Checked = True Then
                Me.CheckBoxq8C.Checked = False
            End If
            If Me.CheckBoxq8D.Checked = True Then
                Me.CheckBoxq8D.Checked = False
            End If
            ans8 = 0
        End If
    End Sub

    Private Sub CheckBoxq8D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq8D.CheckedChanged
        If Me.CheckBoxq8D.Checked = True Then
            If Me.CheckBoxq8B.Checked = True Then
                Me.CheckBoxq8B.Checked = False
            End If
            If Me.CheckBoxq8C.Checked = True Then
                Me.CheckBoxq8C.Checked = False
            End If
            If Me.CheckBoxq8A.Checked = True Then
                Me.CheckBoxq8A.Checked = False
            End If
            ans8 = 0
        End If
    End Sub

    Private Sub CheckBoxq8A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq8A.CheckedChanged
        If Me.CheckBoxq8A.Checked = True Then
            If Me.CheckBoxq8B.Checked = True Then
                Me.CheckBoxq8B.Checked = False
            End If
            If Me.CheckBoxq8C.Checked = True Then
                Me.CheckBoxq8C.Checked = False
            End If
            If Me.CheckBoxq8D.Checked = True Then
                Me.CheckBoxq8D.Checked = False
            End If
            ans8 = 1
        End If
    End Sub
End Class
