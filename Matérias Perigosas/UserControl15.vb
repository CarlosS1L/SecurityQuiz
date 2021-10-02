Public Class UserControl15
    Public Shared ans15 As Integer
    Private Sub CheckBoxq15A_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq15A.CheckedChanged
        If Me.CheckBoxq15A.Checked = True Then
            If Me.CheckBoxq15B.Checked = True Then
                Me.CheckBoxq15B.Checked = False
            End If
            If Me.CheckBoxq15C.Checked = True Then
                Me.CheckBoxq15C.Checked = False
            End If
            If Me.CheckBoxq15D.Checked = True Then
                Me.CheckBoxq15D.Checked = False
            End If
            ans15 = 0
        End If
    End Sub

    Private Sub CheckBoxq15C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq15C.CheckedChanged
        If Me.CheckBoxq15C.Checked = True Then
            If Me.CheckBoxq15B.Checked = True Then
                Me.CheckBoxq15B.Checked = False
            End If
            If Me.CheckBoxq15A.Checked = True Then
                Me.CheckBoxq15A.Checked = False
            End If
            If Me.CheckBoxq15D.Checked = True Then
                Me.CheckBoxq15D.Checked = False
            End If
            ans15 = 1
        End If
    End Sub

    Private Sub CheckBoxq15B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq15B.CheckedChanged
        If Me.CheckBoxq15B.Checked = True Then
            If Me.CheckBoxq15A.Checked = True Then
                Me.CheckBoxq15A.Checked = False
            End If
            If Me.CheckBoxq15C.Checked = True Then
                Me.CheckBoxq15C.Checked = False
            End If
            If Me.CheckBoxq15D.Checked = True Then
                Me.CheckBoxq15D.Checked = False
            End If
            ans15 = 0
        End If
    End Sub

    Private Sub CheckBoxq15D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq15D.CheckedChanged
        If Me.CheckBoxq15D.Checked = True Then
            If Me.CheckBoxq15B.Checked = True Then
                Me.CheckBoxq15B.Checked = False
            End If
            If Me.CheckBoxq15C.Checked = True Then
                Me.CheckBoxq15C.Checked = False
            End If
            If Me.CheckBoxq15A.Checked = True Then
                Me.CheckBoxq15A.Checked = False
            End If
            ans15 = 0
        End If
    End Sub
End Class
