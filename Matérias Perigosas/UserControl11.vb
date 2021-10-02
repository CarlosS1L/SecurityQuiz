Public Class UserControl11
    Public Shared ans11 As Integer
    Private Sub CheckBoxA_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq11A.CheckedChanged
        If Me.CheckBoxq11A.Checked = True Then
            If Me.CheckBoxq11B.Checked = True Then
                Me.CheckBoxq11B.Checked = False
            End If
            If Me.CheckBoxq11C.Checked = True Then
                Me.CheckBoxq11C.Checked = False
            End If
            If Me.CheckBoxq11D.Checked = True Then
                Me.CheckBoxq11D.Checked = False
            End If
            ans11 = 0
        End If
    End Sub

    Private Sub CheckBoxC_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq11C.CheckedChanged
        If Me.CheckBoxq11C.Checked = True Then
            If Me.CheckBoxq11B.Checked = True Then
                Me.CheckBoxq11B.Checked = False
            End If
            If Me.CheckBoxq11A.Checked = True Then
                Me.CheckBoxq11A.Checked = False
            End If
            If Me.CheckBoxq11D.Checked = True Then
                Me.CheckBoxq11D.Checked = False
            End If
            ans11 = 0
        End If
    End Sub

    Private Sub CheckBoxB_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq11B.CheckedChanged
        If Me.CheckBoxq11B.Checked = True Then
            If Me.CheckBoxq11A.Checked = True Then
                Me.CheckBoxq11A.Checked = False
            End If
            If Me.CheckBoxq11C.Checked = True Then
                Me.CheckBoxq11C.Checked = False
            End If
            If Me.CheckBoxq11D.Checked = True Then
                Me.CheckBoxq11D.Checked = False
            End If
            ans11 = 0
        End If
    End Sub

    Private Sub CheckBoxD_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq11D.CheckedChanged
        If Me.CheckBoxq11D.Checked = True Then
            If Me.CheckBoxq11B.Checked = True Then
                Me.CheckBoxq11B.Checked = False
            End If
            If Me.CheckBoxq11C.Checked = True Then
                Me.CheckBoxq11C.Checked = False
            End If
            If Me.CheckBoxq11A.Checked = True Then
                Me.CheckBoxq11A.Checked = False
            End If
            ans11 = 1
        End If
    End Sub
End Class
