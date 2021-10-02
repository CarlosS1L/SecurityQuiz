Public Class UserControl20

    Public Shared ans20 As Double = -1

    Private Sub CheckBoxq20C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq20C.CheckedChanged
        If Me.CheckBoxq20C.Checked = True Then
            If Me.CheckBoxq20B.Checked = True Then
                Me.CheckBoxq20B.Checked = False
            End If
            If Me.CheckBoxq20A.Checked = True Then
                Me.CheckBoxq20A.Checked = False
            End If
            If Me.CheckBoxq20D.Checked = True Then
                Me.CheckBoxq20D.Checked = False
            End If
            ans20 = 0
        End If
    End Sub

    Private Sub CheckBoxq20B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq20B.CheckedChanged
        If Me.CheckBoxq20B.Checked = True Then
            If Me.CheckBoxq20A.Checked = True Then
                Me.CheckBoxq20A.Checked = False
            End If
            If Me.CheckBoxq20C.Checked = True Then
                Me.CheckBoxq20C.Checked = False
            End If
            If Me.CheckBoxq20D.Checked = True Then
                Me.CheckBoxq20D.Checked = False
            End If
            ans20 = 0.5
        End If

    End Sub

    Private Sub CheckBoxq20D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq20D.CheckedChanged
        If Me.CheckBoxq20D.Checked = True Then
            If Me.CheckBoxq20B.Checked = True Then
                Me.CheckBoxq20B.Checked = False
            End If
            If Me.CheckBoxq20C.Checked = True Then
                Me.CheckBoxq20C.Checked = False
            End If
            If Me.CheckBoxq20A.Checked = True Then
                Me.CheckBoxq20A.Checked = False
            End If
            ans20 = -1
        End If
    End Sub

    Private Sub CheckBoxq20A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq20A.CheckedChanged
        If Me.CheckBoxq20A.Checked = True Then
            If Me.CheckBoxq20B.Checked = True Then
                Me.CheckBoxq20B.Checked = False
            End If
            If Me.CheckBoxq20C.Checked = True Then
                Me.CheckBoxq20C.Checked = False
            End If
            If Me.CheckBoxq20D.Checked = True Then
                Me.CheckBoxq20D.Checked = False
            End If
            ans20 = 1
        End If
    End Sub
End Class
