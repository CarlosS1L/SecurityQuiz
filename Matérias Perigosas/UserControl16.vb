Public Class UserControl16
    Public Shared ans16 As Integer
    Private Sub CheckBoxq16A_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq16A.CheckedChanged
        If Me.CheckBoxq16A.Checked = True Then
            If Me.CheckBoxq16B.Checked = True Then
                Me.CheckBoxq16B.Checked = False
            End If
            If Me.CheckBoxq16C.Checked = True Then
                Me.CheckBoxq16C.Checked = False
            End If
            If Me.CheckBoxq16D.Checked = True Then
                Me.CheckBoxq16D.Checked = False
            End If
            ans16 = 0
        End If
    End Sub

    Private Sub CheckBoxq16C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq16C.CheckedChanged
        If Me.CheckBoxq16C.Checked = True Then
            If Me.CheckBoxq16B.Checked = True Then
                Me.CheckBoxq16B.Checked = False
            End If
            If Me.CheckBoxq16A.Checked = True Then
                Me.CheckBoxq16A.Checked = False
            End If
            If Me.CheckBoxq16D.Checked = True Then
                Me.CheckBoxq16D.Checked = False
            End If
            ans16 = 1
        End If
    End Sub

    Private Sub CheckBoxq16B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq16B.CheckedChanged
        If Me.CheckBoxq16B.Checked = True Then
            If Me.CheckBoxq16A.Checked = True Then
                Me.CheckBoxq16A.Checked = False
            End If
            If Me.CheckBoxq16C.Checked = True Then
                Me.CheckBoxq16C.Checked = False
            End If
            If Me.CheckBoxq16D.Checked = True Then
                Me.CheckBoxq16D.Checked = False
            End If
            ans16 = 0
        End If
    End Sub

    Private Sub CheckBoxq16D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq16D.CheckedChanged
        If Me.CheckBoxq16D.Checked = True Then
            If Me.CheckBoxq16B.Checked = True Then
                Me.CheckBoxq16B.Checked = False
            End If
            If Me.CheckBoxq16C.Checked = True Then
                Me.CheckBoxq16C.Checked = False
            End If
            If Me.CheckBoxq16A.Checked = True Then
                Me.CheckBoxq16A.Checked = False
            End If
            ans16 = 0
        End If
    End Sub
End Class
