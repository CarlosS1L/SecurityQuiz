Public Class UserControl14
    Public Shared ans14 As Integer
    Private Sub CheckBoxq14A_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq14A.CheckedChanged
        If Me.CheckBoxq14A.Checked = True Then
            If Me.CheckBoxq14B.Checked = True Then
                Me.CheckBoxq14B.Checked = False
            End If
            If Me.CheckBoxq14C.Checked = True Then
                Me.CheckBoxq14C.Checked = False
            End If
            If Me.CheckBoxq14D.Checked = True Then
                Me.CheckBoxq14D.Checked = False
            End If
            ans14 = 0
        End If
    End Sub

    Private Sub CheckBoxq14C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq14C.CheckedChanged
        If Me.CheckBoxq14C.Checked = True Then
            If Me.CheckBoxq14B.Checked = True Then
                Me.CheckBoxq14B.Checked = False
            End If
            If Me.CheckBoxq14A.Checked = True Then
                Me.CheckBoxq14A.Checked = False
            End If
            If Me.CheckBoxq14D.Checked = True Then
                Me.CheckBoxq14D.Checked = False
            End If
            ans14 = 1
        End If
    End Sub

    Private Sub CheckBoxq14B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq14B.CheckedChanged
        If Me.CheckBoxq14B.Checked = True Then
            If Me.CheckBoxq14A.Checked = True Then
                Me.CheckBoxq14A.Checked = False
            End If
            If Me.CheckBoxq14C.Checked = True Then
                Me.CheckBoxq14C.Checked = False
            End If
            If Me.CheckBoxq14D.Checked = True Then
                Me.CheckBoxq14D.Checked = False
            End If
            ans14 = 0
        End If
    End Sub

    Private Sub CheckBoxq14D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq14D.CheckedChanged
        If Me.CheckBoxq14D.Checked = True Then
            If Me.CheckBoxq14B.Checked = True Then
                Me.CheckBoxq14B.Checked = False
            End If
            If Me.CheckBoxq14C.Checked = True Then
                Me.CheckBoxq14C.Checked = False
            End If
            If Me.CheckBoxq14A.Checked = True Then
                Me.CheckBoxq14A.Checked = False
            End If
            ans14 = 0
        End If
    End Sub
End Class
