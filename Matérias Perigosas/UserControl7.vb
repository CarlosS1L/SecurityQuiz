Public Class UserControl7
    Public Shared ans7 As Integer
    Private Sub CheckBoxq7C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq7C.CheckedChanged
        If Me.CheckBoxq7C.Checked = True Then
            If Me.CheckBoxq7B.Checked = True Then
                Me.CheckBoxq7B.Checked = False
            End If
            If Me.CheckBoxq7A.Checked = True Then
                Me.CheckBoxq7A.Checked = False
            End If
            If Me.CheckBoxq7D.Checked = True Then
                Me.CheckBoxq7D.Checked = False
            End If
            ans7 = 1
        End If
    End Sub

    Private Sub CheckBoxq7B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq7B.CheckedChanged
        If Me.CheckBoxq7B.Checked = True Then
            If Me.CheckBoxq7A.Checked = True Then
                Me.CheckBoxq7A.Checked = False
            End If
            If Me.CheckBoxq7C.Checked = True Then
                Me.CheckBoxq7C.Checked = False
            End If
            If Me.CheckBoxq7D.Checked = True Then
                Me.CheckBoxq7D.Checked = False
            End If
            ans7 = 0
        End If
    End Sub

    Private Sub CheckBoxq7D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq7D.CheckedChanged
        If Me.CheckBoxq7D.Checked = True Then
            If Me.CheckBoxq7B.Checked = True Then
                Me.CheckBoxq7B.Checked = False
            End If
            If Me.CheckBoxq7C.Checked = True Then
                Me.CheckBoxq7C.Checked = False
            End If
            If Me.CheckBoxq7A.Checked = True Then
                Me.CheckBoxq7A.Checked = False
            End If
            ans7 = 0
        End If
    End Sub

    Private Sub CheckBoxq7A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq7A.CheckedChanged
        If Me.CheckBoxq7A.Checked = True Then
            If Me.CheckBoxq7B.Checked = True Then
                Me.CheckBoxq7B.Checked = False
            End If
            If Me.CheckBoxq7C.Checked = True Then
                Me.CheckBoxq7C.Checked = False
            End If
            If Me.CheckBoxq7D.Checked = True Then
                Me.CheckBoxq7D.Checked = False
            End If
            ans7 = 0
        End If
    End Sub
End Class
