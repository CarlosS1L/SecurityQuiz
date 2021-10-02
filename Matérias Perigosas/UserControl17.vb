Public Class UserControl17
    Public Shared ans17 As Integer
    Private Sub CheckBoxq17C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq17C.CheckedChanged
        If Me.CheckBoxq17C.Checked = True Then
            If Me.CheckBoxq17B.Checked = True Then
                Me.CheckBoxq17B.Checked = False
            End If
            If Me.CheckBoxq17A.Checked = True Then
                Me.CheckBoxq17A.Checked = False
            End If
            If Me.CheckBoxq17D.Checked = True Then
                Me.CheckBoxq17D.Checked = False
            End If
            ans17 = 0
        End If
    End Sub

    Private Sub CheckBoxq17B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq17B.CheckedChanged
        If Me.CheckBoxq17B.Checked = True Then
            If Me.CheckBoxq17A.Checked = True Then
                Me.CheckBoxq17A.Checked = False
            End If
            If Me.CheckBoxq17C.Checked = True Then
                Me.CheckBoxq17C.Checked = False
            End If
            If Me.CheckBoxq17D.Checked = True Then
                Me.CheckBoxq17D.Checked = False
            End If
            ans17 = 0
        End If
    End Sub

    Private Sub CheckBoxq17D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq17D.CheckedChanged
        If Me.CheckBoxq17D.Checked = True Then
            If Me.CheckBoxq17B.Checked = True Then
                Me.CheckBoxq17B.Checked = False
            End If
            If Me.CheckBoxq17C.Checked = True Then
                Me.CheckBoxq17C.Checked = False
            End If
            If Me.CheckBoxq17A.Checked = True Then
                Me.CheckBoxq17A.Checked = False
            End If
            ans17 = 1
        End If
    End Sub

    Private Sub CheckBoxq17A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq17A.CheckedChanged
        If Me.CheckBoxq17A.Checked = True Then
            If Me.CheckBoxq17B.Checked = True Then
                Me.CheckBoxq17B.Checked = False
            End If
            If Me.CheckBoxq17C.Checked = True Then
                Me.CheckBoxq17C.Checked = False
            End If
            If Me.CheckBoxq17D.Checked = True Then
                Me.CheckBoxq17D.Checked = False
            End If
            ans17 = 0
        End If
    End Sub
End Class
