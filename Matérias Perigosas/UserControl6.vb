Public Class UserControl6
    Public Shared ans6 As Integer
    Private Sub CheckBoxq6C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq6C.CheckedChanged
        If Me.CheckBoxq6C.Checked = True Then
            If Me.CheckBoxq6B.Checked = True Then
                Me.CheckBoxq6B.Checked = False
            End If
            If Me.CheckBoxq6A.Checked = True Then
                Me.CheckBoxq6A.Checked = False
            End If
            If Me.CheckBoxq6D.Checked = True Then
                Me.CheckBoxq6D.Checked = False
            End If
            ans6 = 0
        End If
    End Sub

    Private Sub CheckBoxq6B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq6B.CheckedChanged
        If Me.CheckBoxq6B.Checked = True Then
            If Me.CheckBoxq6A.Checked = True Then
                Me.CheckBoxq6A.Checked = False
            End If
            If Me.CheckBoxq6C.Checked = True Then
                Me.CheckBoxq6C.Checked = False
            End If
            If Me.CheckBoxq6D.Checked = True Then
                Me.CheckBoxq6D.Checked = False
            End If
            ans6 = 0
        End If
    End Sub

    Private Sub CheckBoxq6D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq6D.CheckedChanged
        If Me.CheckBoxq6D.Checked = True Then
            If Me.CheckBoxq6B.Checked = True Then
                Me.CheckBoxq6B.Checked = False
            End If
            If Me.CheckBoxq6C.Checked = True Then
                Me.CheckBoxq6C.Checked = False
            End If
            If Me.CheckBoxq6A.Checked = True Then
                Me.CheckBoxq6A.Checked = False
            End If
            ans6 = 1
        End If
    End Sub

    Private Sub CheckBoxq6A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq6A.CheckedChanged
        If Me.CheckBoxq6A.Checked = True Then
            If Me.CheckBoxq6B.Checked = True Then
                Me.CheckBoxq6B.Checked = False
            End If
            If Me.CheckBoxq6C.Checked = True Then
                Me.CheckBoxq6C.Checked = False
            End If
            If Me.CheckBoxq6D.Checked = True Then
                Me.CheckBoxq6D.Checked = False
            End If
            ans6 = 0
        End If
    End Sub
End Class
