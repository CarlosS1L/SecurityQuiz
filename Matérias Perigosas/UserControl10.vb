Public Class UserControl10
    Public Shared ans10 As Integer
    Private Sub CheckBoxA_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq10A.CheckedChanged
        If Me.CheckBoxq10A.Checked = True Then
            If Me.CheckBoxq10B.Checked = True Then
                Me.CheckBoxq10B.Checked = False
            End If
            If Me.CheckBoxq10C.Checked = True Then
                Me.CheckBoxq10C.Checked = False
            End If
            If Me.CheckBoxq10D.Checked = True Then
                Me.CheckBoxq10D.Checked = False
            End If
            ans10 = 0
        End If
    End Sub

    Private Sub CheckBoxC_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq10C.CheckedChanged
        If Me.CheckBoxq10C.Checked = True Then
            If Me.CheckBoxq10B.Checked = True Then
                Me.CheckBoxq10B.Checked = False
            End If
            If Me.CheckBoxq10A.Checked = True Then
                Me.CheckBoxq10A.Checked = False
            End If
            If Me.CheckBoxq10D.Checked = True Then
                Me.CheckBoxq10D.Checked = False
            End If
            ans10 = 1
        End If
    End Sub

    Private Sub CheckBoxB_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq10B.CheckedChanged
        If Me.CheckBoxq10B.Checked = True Then
            If Me.CheckBoxq10A.Checked = True Then
                Me.CheckBoxq10A.Checked = False
            End If
            If Me.CheckBoxq10C.Checked = True Then
                Me.CheckBoxq10C.Checked = False
            End If
            If Me.CheckBoxq10D.Checked = True Then
                Me.CheckBoxq10D.Checked = False
            End If
            ans10 = 0
        End If
    End Sub

    Private Sub CheckBoxD_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq10D.CheckedChanged
        If Me.CheckBoxq10D.Checked = True Then
            If Me.CheckBoxq10B.Checked = True Then
                Me.CheckBoxq10B.Checked = False
            End If
            If Me.CheckBoxq10C.Checked = True Then
                Me.CheckBoxq10C.Checked = False
            End If
            If Me.CheckBoxq10A.Checked = True Then
                Me.CheckBoxq10A.Checked = False
            End If
            ans10 = 0
        End If
    End Sub


End Class
