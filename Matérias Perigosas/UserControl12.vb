Public Class UserControl12
    Public Shared ans12 As Integer
    Private Sub CheckBoxq12A_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq12A.CheckedChanged
        If Me.CheckBoxq12A.Checked = True Then
            If Me.CheckBoxq12B.Checked = True Then
                Me.CheckBoxq12B.Checked = False
            End If
            If Me.CheckBoxq12C.Checked = True Then
                Me.CheckBoxq12C.Checked = False
            End If
            If Me.CheckBoxq12D.Checked = True Then
                Me.CheckBoxq12D.Checked = False
            End If
            ans12 = 0
        End If
    End Sub

    Private Sub CheckBoxq12C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq12C.CheckedChanged
        If Me.CheckBoxq12C.Checked = True Then
            If Me.CheckBoxq12B.Checked = True Then
                Me.CheckBoxq12B.Checked = False
            End If
            If Me.CheckBoxq12A.Checked = True Then
                Me.CheckBoxq12A.Checked = False
            End If
            If Me.CheckBoxq12D.Checked = True Then
                Me.CheckBoxq12D.Checked = False
            End If
            ans12 = 0
        End If
    End Sub

    Private Sub CheckBoxq12B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq12B.CheckedChanged
        If Me.CheckBoxq12B.Checked = True Then
            If Me.CheckBoxq12A.Checked = True Then
                Me.CheckBoxq12A.Checked = False
            End If
            If Me.CheckBoxq12C.Checked = True Then
                Me.CheckBoxq12C.Checked = False
            End If
            If Me.CheckBoxq12D.Checked = True Then
                Me.CheckBoxq12D.Checked = False
            End If
            ans12 = 1
        End If
    End Sub

    Private Sub CheckBoxq12D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxq12D.CheckedChanged
        If Me.CheckBoxq12D.Checked = True Then
            If Me.CheckBoxq12B.Checked = True Then
                Me.CheckBoxq12B.Checked = False
            End If
            If Me.CheckBoxq12C.Checked = True Then
                Me.CheckBoxq12C.Checked = False
            End If
            If Me.CheckBoxq12A.Checked = True Then
                Me.CheckBoxq12A.Checked = False
            End If
            ans12 = 0
        End If
    End Sub
End Class
