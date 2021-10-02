Public Class UserControl5
    Public Shared ans5 As Integer
    Private Sub CheckBoxq5C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq5C.CheckedChanged
        If Me.CheckBoxq5C.Checked = True Then
            If Me.CheckBoxq5B.Checked = True Then
                Me.CheckBoxq5B.Checked = False
            End If
            If Me.CheckBoxq5A.Checked = True Then
                Me.CheckBoxq5A.Checked = False
            End If
            If Me.CheckBoxq5D.Checked = True Then
                Me.CheckBoxq5D.Checked = False
            End If
            ans5 = 1
        End If
    End Sub

    Private Sub CheckBoxq5B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq5B.CheckedChanged
        If Me.CheckBoxq5B.Checked = True Then
            If Me.CheckBoxq5A.Checked = True Then
                Me.CheckBoxq5A.Checked = False
            End If
            If Me.CheckBoxq5C.Checked = True Then
                Me.CheckBoxq5C.Checked = False
            End If
            If Me.CheckBoxq5D.Checked = True Then
                Me.CheckBoxq5D.Checked = False
            End If
            ans5 = 0
        End If
    End Sub

    Private Sub CheckBoxq5D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq5D.CheckedChanged
        If Me.CheckBoxq5D.Checked = True Then
            If Me.CheckBoxq5B.Checked = True Then
                Me.CheckBoxq5B.Checked = False
            End If
            If Me.CheckBoxq5C.Checked = True Then
                Me.CheckBoxq5C.Checked = False
            End If
            If Me.CheckBoxq5A.Checked = True Then
                Me.CheckBoxq5A.Checked = False
            End If
            ans5 = 0
        End If
    End Sub

    Private Sub CheckBoxq5A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq5A.CheckedChanged
        If Me.CheckBoxq5A.Checked = True Then
            If Me.CheckBoxq5B.Checked = True Then
                Me.CheckBoxq5B.Checked = False
            End If
            If Me.CheckBoxq5C.Checked = True Then
                Me.CheckBoxq5C.Checked = False
            End If
            If Me.CheckBoxq5D.Checked = True Then
                Me.CheckBoxq5D.Checked = False
            End If
            ans5 = 0
        End If
    End Sub
End Class
