Public Class UserControl19
    Public Shared ans19 As Integer

    Private Sub CheckBoxq19C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq19C.CheckedChanged
        If Me.CheckBoxq19C.Checked = True Then
            If Me.CheckBoxq19B.Checked = True Then
                Me.CheckBoxq19B.Checked = False
            End If
            If Me.CheckBoxq19A.Checked = True Then
                Me.CheckBoxq19A.Checked = False
            End If
            If Me.CheckBoxq19D.Checked = True Then
                Me.CheckBoxq19D.Checked = False
            End If
            ans19 = 1
        End If
    End Sub

    Private Sub CheckBoxq19B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq19B.CheckedChanged
        If Me.CheckBoxq19B.Checked = True Then
            If Me.CheckBoxq19A.Checked = True Then
                Me.CheckBoxq19A.Checked = False
            End If
            If Me.CheckBoxq19C.Checked = True Then
                Me.CheckBoxq19C.Checked = False
            End If
            If Me.CheckBoxq19D.Checked = True Then
                Me.CheckBoxq19D.Checked = False
            End If
            ans19 = 0
        End If
    End Sub

    Private Sub CheckBoxq19D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq19D.CheckedChanged
        If Me.CheckBoxq19D.Checked = True Then
            If Me.CheckBoxq19B.Checked = True Then
                Me.CheckBoxq19B.Checked = False
            End If
            If Me.CheckBoxq19C.Checked = True Then
                Me.CheckBoxq19C.Checked = False
            End If
            If Me.CheckBoxq19A.Checked = True Then
                Me.CheckBoxq19A.Checked = False
            End If
            ans19 = 0
        End If
    End Sub

    Private Sub CheckBoxq19A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq19A.CheckedChanged
        If Me.CheckBoxq19A.Checked = True Then
            If Me.CheckBoxq19B.Checked = True Then
                Me.CheckBoxq19B.Checked = False
            End If
            If Me.CheckBoxq19C.Checked = True Then
                Me.CheckBoxq19C.Checked = False
            End If
            If Me.CheckBoxq19D.Checked = True Then
                Me.CheckBoxq19D.Checked = False
            End If
            ans19 = 0
        End If
    End Sub
End Class
