Public Class UserControl13
    Public Shared ans13 As Integer
    Private Sub CheckBoxq13A_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq13A.CheckedChanged
        If Me.CheckBoxq13A.Checked = True Then
            If Me.CheckBoxq13B.Checked = True Then
                Me.CheckBoxq13B.Checked = False
            End If
            If Me.CheckBoxq13C.Checked = True Then
                Me.CheckBoxq13C.Checked = False
            End If
            If Me.CheckBoxq13D.Checked = True Then
                Me.CheckBoxq13D.Checked = False
            End If
            ans13 = 0
        End If
    End Sub

    Private Sub CheckBoxq13C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq13C.CheckedChanged
        If Me.CheckBoxq13C.Checked = True Then
            If Me.CheckBoxq13B.Checked = True Then
                Me.CheckBoxq13B.Checked = False
            End If
            If Me.CheckBoxq13A.Checked = True Then
                Me.CheckBoxq13A.Checked = False
            End If
            If Me.CheckBoxq13D.Checked = True Then
                Me.CheckBoxq13D.Checked = False
            End If
            ans13 = 0
        End If
    End Sub

    Private Sub CheckBoxq13B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq13B.CheckedChanged
        If Me.CheckBoxq13B.Checked = True Then
            If Me.CheckBoxq13A.Checked = True Then
                Me.CheckBoxq13A.Checked = False
            End If
            If Me.CheckBoxq13C.Checked = True Then
                Me.CheckBoxq13C.Checked = False
            End If
            If Me.CheckBoxq13D.Checked = True Then
                Me.CheckBoxq13D.Checked = False
            End If
            ans13 = 1
        End If
    End Sub

    Private Sub CheckBoxq13D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq13D.CheckedChanged
        If Me.CheckBoxq13D.Checked = True Then
            If Me.CheckBoxq13B.Checked = True Then
                Me.CheckBoxq13B.Checked = False
            End If
            If Me.CheckBoxq13C.Checked = True Then
                Me.CheckBoxq13C.Checked = False
            End If
            If Me.CheckBoxq13A.Checked = True Then
                Me.CheckBoxq13A.Checked = False
            End If
            ans13 = 0
        End If
    End Sub
End Class
