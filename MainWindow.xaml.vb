Class MainWindow
    Private Sub CmdResult_Click(sender As Object, e As RoutedEventArgs) Handles CmdResult.Click
        Dim n, k, s As Integer
        Dim info, SInfo As String

        n = Val(TxtLet.Text)
        s = Val(SField.Text)

        If n >= 10 And n <= 20 Then
            info = "лет"
        Else
            k = n Mod 10
            Select Case k
                Case 1
                    info = "год"
                Case 2, 3, 4
                    info = "года"
                Case Else
                    info = "лет"
            End Select
        End If
        LblLet.Content = info

        Select Case s
            Case 12, 1, 2
                SInfo = "Зима"
            Case 3 To 5
                SInfo = "Весна"
            Case 6 To 8
                SInfo = "Лето"
            Case 9 To 11
                SInfo = "Осень"
        End Select

        Select Case n
            Case Is < 7
                info = "детский сад"
            Case 7 To 16
                info = "учеба в школе"
            Case 17 To 21
                info = "учеба в ВУЗе"
            Case 22 To 55
                info = "трудовая деятельность"
            Case Else
                info = "заслуженный отдых - пенсия"
        End Select
        LblInfo.Content = info
        If String.IsNullOrEmpty(SField.Text) Then
            LblSeasonOfYear.Content = "Вы забыли ввести месяц:)"
        Else
            LblSeasonOfYear.Content = "Ваше время года: " + SInfo
        End If

    End Sub

    Private Sub TxtLet_TextChanged(sender As Object, e As TextChangedEventArgs) Handles TxtLet.TextChanged

    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As RoutedEventArgs) Handles ExitBTN.Click
        If MsgBox("Вы действительно хотите выйти?", vbYesNo, "Подтверждение") = vbYes Then
            Windows.Application.Current.Shutdown()
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
