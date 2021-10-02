Public Class UserControl3
    Public Shared ans3 As Integer

    Private Sub CheckBoxq3C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq3C.CheckedChanged
        If Me.CheckBoxq3C.Checked = True Then
            If Me.CheckBoxq3B.Checked = True Then
                Me.CheckBoxq3B.Checked = False
            End If
            If Me.CheckBoxq3A.Checked = True Then
                Me.CheckBoxq3A.Checked = False
            End If
            If Me.CheckBoxq3D.Checked = True Then
                Me.CheckBoxq3D.Checked = False
            End If
            ans3 = 1
        End If
    End Sub

    Private Sub CheckBoxq3B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq3B.CheckedChanged
        If Me.CheckBoxq3B.Checked = True Then
            If Me.CheckBoxq3A.Checked = True Then
                Me.CheckBoxq3A.Checked = False
            End If
            If Me.CheckBoxq3C.Checked = True Then
                Me.CheckBoxq3C.Checked = False
            End If
            If Me.CheckBoxq3D.Checked = True Then
                Me.CheckBoxq3D.Checked = False
            End If
            ans3 = 0
        End If
    End Sub

    Private Sub CheckBoxq3D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq3D.CheckedChanged
        If Me.CheckBoxq3D.Checked = True Then
            If Me.CheckBoxq3B.Checked = True Then
                Me.CheckBoxq3B.Checked = False
            End If
            If Me.CheckBoxq3C.Checked = True Then
                Me.CheckBoxq3C.Checked = False
            End If
            If Me.CheckBoxq3A.Checked = True Then
                Me.CheckBoxq3A.Checked = False
            End If
            ans3 = 0
        End If
    End Sub

    Private Sub CheckBoxq3A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq3A.CheckedChanged
        If Me.CheckBoxq3A.Checked = True Then
            If Me.CheckBoxq3B.Checked = True Then
                Me.CheckBoxq3B.Checked = False
            End If
            If Me.CheckBoxq3C.Checked = True Then
                Me.CheckBoxq3C.Checked = False
            End If
            If Me.CheckBoxq3D.Checked = True Then
                Me.CheckBoxq3D.Checked = False
            End If
            ans3 = 0
        End If
    End Sub
End Class
