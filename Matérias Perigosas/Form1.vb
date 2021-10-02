Public Class main

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.nome.Text = "" Then
            MsgBox("Por favor insira um utilizador", , "Atenção!")
        Else
            questoes.Show()
            Me.Hide()
            questoes.qestao1btn.PerformClick()
        End If
    End Sub

End Class
