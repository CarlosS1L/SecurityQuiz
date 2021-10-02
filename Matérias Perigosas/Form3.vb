Public Class pontos

    Private Sub pontos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        questoes.Button1.Text = "Voltar"

        Me.rc.Text = app.UserControl1.ans1 + app.UserControl2.ans2 + app.UserControl3.ans3 + app.UserControl4.ans4 + app.UserControl5.ans5 + app.UserControl6.ans6 + app.UserControl7.ans7 + app.UserControl8.ans8 + app.UserControl9.ans9 + app.UserControl10.ans10 + app.UserControl11.ans11 + app.UserControl12.ans12 + app.UserControl13.ans13 + app.UserControl14.ans14 + app.UserControl15.ans15 + app.UserControl16.ans16 + app.UserControl17.ans17 + app.UserControl18.ans18 + app.UserControl19.ans19 + app.UserControl20.ans20
        Me.re.Text = 20 - Me.rc.Text
        Me.name_label2.Text = main.nome.Text

        If (Me.re.Text < 3) Then
            Me.imgup.Visible = True
            Me.imgdown.Visible = False
        Else
            Me.imgup.Visible = False
            Me.imgdown.Visible = True
        End If

        If app.UserControl1.ans1 = 1 Then
            Me.RectangleShape1.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape1.FillColor = Color.Red
        End If
        If app.UserControl2.ans2 = 1 Then
            Me.RectangleShape2.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape2.FillColor = Color.Red
        End If
        If app.UserControl3.ans3 = 1 Then
            Me.RectangleShape3.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape3.FillColor = Color.Red
        End If
        If app.UserControl4.ans4 = 1 Then
            Me.RectangleShape4.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape4.FillColor = Color.Red
        End If
        If app.UserControl5.ans5 = 1 Then
            Me.RectangleShape5.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape5.FillColor = Color.Red
        End If
        If app.UserControl6.ans6 = 1 Then
            Me.RectangleShape6.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape6.FillColor = Color.Red
        End If
        If app.UserControl7.ans7 = 1 Then
            Me.RectangleShape7.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape7.FillColor = Color.Red
        End If
        If app.UserControl8.ans8 = 1 Then
            Me.RectangleShape8.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape8.FillColor = Color.Red
        End If
        If app.UserControl9.ans9 = 1 Then
            Me.RectangleShape9.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape9.FillColor = Color.Red
        End If
        If app.UserControl10.ans10 = 1 Then
            Me.RectangleShape10.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape10.FillColor = Color.Red
        End If
        If app.UserControl11.ans11 = 1 Then
            Me.RectangleShape11.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape11.FillColor = Color.Red
        End If
        If app.UserControl12.ans12 = 1 Then
            Me.RectangleShape12.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape12.FillColor = Color.Red
        End If
        If app.UserControl13.ans13 = 1 Then
            Me.RectangleShape13.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape13.FillColor = Color.Red
        End If
        If app.UserControl14.ans14 = 1 Then
            Me.RectangleShape14.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape14.FillColor = Color.Red
        End If
        If app.UserControl15.ans15 = 1 Then
            Me.RectangleShape15.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape15.FillColor = Color.Red
        End If
        If app.UserControl16.ans16 = 1 Then
            Me.RectangleShape16.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape16.FillColor = Color.Red
        End If
        If app.UserControl17.ans17 = 1 Then
            Me.RectangleShape17.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape17.FillColor = Color.Red
        End If
        If app.UserControl18.ans18 = 1 Then
            Me.RectangleShape18.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape18.FillColor = Color.Red
        End If
        If app.UserControl19.ans19 = 1 Then
            Me.RectangleShape19.FillColor = Color.LimeGreen
        Else
            Me.RectangleShape19.FillColor = Color.Red
        End If
        If app.UserControl20.ans20 = 1 Then
            Me.RectangleShape20.FillColor = Color.LimeGreen
        Else
            If app.UserControl20.ans20 = 0.5 Then
                Me.RectangleShape20.FillColor = Color.PaleGreen
            Else
                If app.UserControl20.ans20 = 0 Then
                    Me.RectangleShape20.FillColor = Color.Yellow
                Else
                    Me.RectangleShape20.FillColor = Color.Red
                End If
            End If
        End If

    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao1btn.PerformClick()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao2btn.PerformClick()
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao3btn.PerformClick()
    End Sub

    Private Sub RectangleShape4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape4.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao4btn.PerformClick()
    End Sub

    Private Sub RectangleShape5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape5.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao5btn.PerformClick()
    End Sub

    Private Sub RectangleShape6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape6.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao6btn.PerformClick()
    End Sub

    Private Sub RectangleShape7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape7.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao7btn.PerformClick()
    End Sub

    Private Sub RectangleShape8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape8.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao8btn.PerformClick()
    End Sub

    Private Sub RectangleShape9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape9.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao9btn.PerformClick()
    End Sub

    Private Sub RectangleShape10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape10.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao10btn.PerformClick()
    End Sub

    Private Sub RectangleShape11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape11.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao11btn.PerformClick()
    End Sub

    Private Sub RectangleShape12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape12.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao12btn.PerformClick()
    End Sub

    Private Sub RectangleShape13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape13.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao13btn.PerformClick()
    End Sub

    Private Sub RectangleShape14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape14.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao14btn.PerformClick()
    End Sub

    Private Sub RectangleShape15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape15.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao15btn.PerformClick()
    End Sub

    Private Sub RectangleShape16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape16.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao16btn.PerformClick()
    End Sub

    Private Sub RectangleShape17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape17.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao17btn.PerformClick()
    End Sub

    Private Sub RectangleShape18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape18.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao18btn.PerformClick()
    End Sub

    Private Sub RectangleShape19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape19.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao19btn.PerformClick()
    End Sub

    Private Sub RectangleShape20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape20.Click
        questoes.Show()
        Me.Hide()
        questoes.qestao20btn.PerformClick()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class