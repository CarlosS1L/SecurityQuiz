Public Class UserControl9
    Public Shared ans9 As Integer
    Private Sub CheckBoxq9C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq9C.CheckedChanged
        If Me.CheckBoxq9C.Checked = True Then
            If Me.CheckBoxq9B.Checked = True Then
                Me.CheckBoxq9B.Checked = False
            End If
            If Me.CheckBoxq9A.Checked = True Then
                Me.CheckBoxq9A.Checked = False
            End If
            If Me.CheckBoxq9D.Checked = True Then
                Me.CheckBoxq9D.Checked = False
            End If
            ans9 = 0
        End If
    End Sub

    Private Sub CheckBoxq9B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq9B.CheckedChanged
        If Me.CheckBoxq9B.Checked = True Then
            If Me.CheckBoxq9A.Checked = True Then
                Me.CheckBoxq9A.Checked = False
            End If
            If Me.CheckBoxq9C.Checked = True Then
                Me.CheckBoxq9C.Checked = False
            End If
            If Me.CheckBoxq9D.Checked = True Then
                Me.CheckBoxq9D.Checked = False
            End If
            ans9 = 1
        End If
    End Sub

    Private Sub CheckBoxq9D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq9D.CheckedChanged
        If Me.CheckBoxq9D.Checked = True Then
            If Me.CheckBoxq9B.Checked = True Then
                Me.CheckBoxq9B.Checked = False
            End If
            If Me.CheckBoxq9C.Checked = True Then
                Me.CheckBoxq9C.Checked = False
            End If
            If Me.CheckBoxq9A.Checked = True Then
                Me.CheckBoxq9A.Checked = False
            End If
            ans9 = 0
        End If
    End Sub

    Private Sub CheckBoxq9A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq9A.CheckedChanged
        If Me.CheckBoxq9A.Checked = True Then
            If Me.CheckBoxq9B.Checked = True Then
                Me.CheckBoxq9B.Checked = False
            End If
            If Me.CheckBoxq9C.Checked = True Then
                Me.CheckBoxq9C.Checked = False
            End If
            If Me.CheckBoxq9D.Checked = True Then
                Me.CheckBoxq9D.Checked = False
            End If
            ans9 = 0
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
