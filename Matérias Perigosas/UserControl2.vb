Public Class UserControl2
    Public Shared ans2 As Integer
    Private Sub CheckBoxq2C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq2C.CheckedChanged
        If Me.CheckBoxq2C.Checked = True Then
            If Me.CheckBoxq2B.Checked = True Then
                Me.CheckBoxq2B.Checked = False
            End If
            If Me.CheckBoxq2A.Checked = True Then
                Me.CheckBoxq2A.Checked = False
            End If
            If Me.CheckBoxq2D.Checked = True Then
                Me.CheckBoxq2D.Checked = False
            End If
            ans2 = 0
        End If
    End Sub

    Private Sub CheckBoxq2B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq2B.CheckedChanged
        If Me.CheckBoxq2B.Checked = True Then
            If Me.CheckBoxq2A.Checked = True Then
                Me.CheckBoxq2A.Checked = False
            End If
            If Me.CheckBoxq2C.Checked = True Then
                Me.CheckBoxq2C.Checked = False
            End If
            If Me.CheckBoxq2D.Checked = True Then
                Me.CheckBoxq2D.Checked = False
            End If
            ans2 = 0
        End If
    End Sub

    Private Sub CheckBoxq2D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq2D.CheckedChanged
        If Me.CheckBoxq2D.Checked = True Then
            If Me.CheckBoxq2B.Checked = True Then
                Me.CheckBoxq2B.Checked = False
            End If
            If Me.CheckBoxq2C.Checked = True Then
                Me.CheckBoxq2C.Checked = False
            End If
            If Me.CheckBoxq2A.Checked = True Then
                Me.CheckBoxq2A.Checked = False
            End If
            ans2 = 0
        End If
    End Sub

    Private Sub CheckBoxq2A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq2A.CheckedChanged
        If Me.CheckBoxq2A.Checked = True Then
            If Me.CheckBoxq2B.Checked = True Then
                Me.CheckBoxq2B.Checked = False
            End If
            If Me.CheckBoxq2C.Checked = True Then
                Me.CheckBoxq2C.Checked = False
            End If
            If Me.CheckBoxq2D.Checked = True Then
                Me.CheckBoxq2D.Checked = False
            End If
            ans2 = 1
        End If
    End Sub
End Class
