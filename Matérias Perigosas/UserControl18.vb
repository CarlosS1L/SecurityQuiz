Public Class UserControl18
    Public Shared ans18 As Integer
    Private Sub CheckBoxq18C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq18C.CheckedChanged
        If Me.CheckBoxq18C.Checked = True Then
            If Me.CheckBoxq18B.Checked = True Then
                Me.CheckBoxq18B.Checked = False
            End If
            If Me.CheckBoxq18A.Checked = True Then
                Me.CheckBoxq18A.Checked = False
            End If
            If Me.CheckBoxq18D.Checked = True Then
                Me.CheckBoxq18D.Checked = False
            End If
            ans18 = 0
        End If
    End Sub

    Private Sub CheckBoxq18B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq18B.CheckedChanged
        If Me.CheckBoxq18B.Checked = True Then
            If Me.CheckBoxq18A.Checked = True Then
                Me.CheckBoxq18A.Checked = False
            End If
            If Me.CheckBoxq18C.Checked = True Then
                Me.CheckBoxq18C.Checked = False
            End If
            If Me.CheckBoxq18D.Checked = True Then
                Me.CheckBoxq18D.Checked = False
            End If
            ans18 = 0
        End If
    End Sub

    Private Sub CheckBoxq18D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq18D.CheckedChanged
        If Me.CheckBoxq18D.Checked = True Then
            If Me.CheckBoxq18B.Checked = True Then
                Me.CheckBoxq18B.Checked = False
            End If
            If Me.CheckBoxq18C.Checked = True Then
                Me.CheckBoxq18C.Checked = False
            End If
            If Me.CheckBoxq18A.Checked = True Then
                Me.CheckBoxq18A.Checked = False
            End If
            ans18 = 0
        End If
    End Sub

    Private Sub CheckBoxq18A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq18A.CheckedChanged
        If Me.CheckBoxq18A.Checked = True Then
            If Me.CheckBoxq18B.Checked = True Then
                Me.CheckBoxq18B.Checked = False
            End If
            If Me.CheckBoxq18C.Checked = True Then
                Me.CheckBoxq18C.Checked = False
            End If
            If Me.CheckBoxq18D.Checked = True Then
                Me.CheckBoxq18D.Checked = False
            End If
            ans18 = 1
        End If
    End Sub
End Class
