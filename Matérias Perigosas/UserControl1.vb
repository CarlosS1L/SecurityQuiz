
Public Class UserControl1
    Public Shared ans1 As Integer

    Private Sub CheckBoxq1A_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq1A.CheckedChanged
        If Me.CheckBoxq1A.Checked = True Then
            If Me.CheckBoxq1B.Checked = True Then
                Me.CheckBoxq1B.Checked = False
            End If
            If Me.CheckBoxq1C.Checked = True Then
                Me.CheckBoxq1C.Checked = False
            End If
            If Me.CheckBoxq1D.Checked = True Then
                Me.CheckBoxq1D.Checked = False
            End If
            ans1 = 0
        End If
    End Sub

    Private Sub CheckBoxq1C_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq1C.CheckedChanged
        If Me.CheckBoxq1C.Checked = True Then
            If Me.CheckBoxq1B.Checked = True Then
                Me.CheckBoxq1B.Checked = False
            End If
            If Me.CheckBoxq1A.Checked = True Then
                Me.CheckBoxq1A.Checked = False
            End If
            If Me.CheckBoxq1D.Checked = True Then
                Me.CheckBoxq1D.Checked = False
            End If
            ans1 = 0
        End If
    End Sub

    Private Sub CheckBoxq1B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq1B.CheckedChanged
        If Me.CheckBoxq1B.Checked = True Then
            If Me.CheckBoxq1A.Checked = True Then
                Me.CheckBoxq1A.Checked = False
            End If
            If Me.CheckBoxq1C.Checked = True Then
                Me.CheckBoxq1C.Checked = False
            End If
            If Me.CheckBoxq1D.Checked = True Then
                Me.CheckBoxq1D.Checked = False
            End If
            ans1 = 1
        End If
    End Sub

    Private Sub CheckBoxq1D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq1D.CheckedChanged
        If Me.CheckBoxq1D.Checked = True Then
            If Me.CheckBoxq1B.Checked = True Then
                Me.CheckBoxq1B.Checked = False
            End If
            If Me.CheckBoxq1C.Checked = True Then
                Me.CheckBoxq1C.Checked = False
            End If
            If Me.CheckBoxq1A.Checked = True Then
                Me.CheckBoxq1A.Checked = False
            End If
            ans1 = 0
        End If
    End Sub
End Class
