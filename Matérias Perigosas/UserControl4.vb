Public Class UserControl4
    Public Shared ans4 As Integer
    Private Sub CheckBoxq4C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq4C.CheckedChanged
        If Me.CheckBoxq4C.Checked = True Then
            If Me.CheckBoxq4B.Checked = True Then
                Me.CheckBoxq4B.Checked = False
            End If
            If Me.CheckBoxq4A.Checked = True Then
                Me.CheckBoxq4A.Checked = False
            End If
            If Me.CheckBoxq4D.Checked = True Then
                Me.CheckBoxq4D.Checked = False
            End If
            ans4 = 0
        End If
    End Sub

    Private Sub CheckBoxq4B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq4B.CheckedChanged
        If Me.CheckBoxq4B.Checked = True Then
            If Me.CheckBoxq4A.Checked = True Then
                Me.CheckBoxq4A.Checked = False
            End If
            If Me.CheckBoxq4C.Checked = True Then
                Me.CheckBoxq4C.Checked = False
            End If
            If Me.CheckBoxq4D.Checked = True Then
                Me.CheckBoxq4D.Checked = False
            End If
            ans4 = 1
        End If
    End Sub

    Private Sub CheckBoxq4D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq4D.CheckedChanged
        If Me.CheckBoxq4D.Checked = True Then
            If Me.CheckBoxq4B.Checked = True Then
                Me.CheckBoxq4B.Checked = False
            End If
            If Me.CheckBoxq4C.Checked = True Then
                Me.CheckBoxq4C.Checked = False
            End If
            If Me.CheckBoxq4A.Checked = True Then
                Me.CheckBoxq4A.Checked = False
            End If
            ans4 = 0
        End If
    End Sub

    Private Sub CheckBoxq4A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq4A.CheckedChanged
        If Me.CheckBoxq4A.Checked = True Then
            If Me.CheckBoxq4B.Checked = True Then
                Me.CheckBoxq4B.Checked = False
            End If
            If Me.CheckBoxq4C.Checked = True Then
                Me.CheckBoxq4C.Checked = False
            End If
            If Me.CheckBoxq4D.Checked = True Then
                Me.CheckBoxq4D.Checked = False
            End If
            ans4 = 0
        End If
    End Sub
End Class
