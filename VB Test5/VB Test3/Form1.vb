Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_start.Click
        If bt_start.Text = "클릭되었습니다" Then
            bt_start.Text = "버 튼2"
        Else
            bt_start.Text = "클릭되었습니다"
        End If
        If Me.Text = "VB Test2" Then
            Me.Text = "잘했어요"
        Else
            Me.Text = "VB Test2"
        End If


    End Sub

    Private Sub bt_Start_MouseHover(sender As Object, e As EventArgs) Handles bt_start.MouseHover
        If bt_start.Text = "버튼위에마우스" Then
            bt_start.Text = "버 튼"
        Else
            bt_start.Text = "버튼위에마우스"
        End If
    End Sub

    Private Sub bt_msg_Click(sender As Object, e As EventArgs) Handles bt_msg.Click

        MsgBox("Hello World!")
        Label1.Text = Now.ToString
        '& " " & result

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Now.ToString
    End Sub

    Private Sub bt_Calc_Click(sender As Object, e As EventArgs) Handles bt_Calc.Click


        Try
            price = CDbl(tx_Price.Text)
            number = CDbl(tx_Number.Text)
            result = CStr(price * number)
            'tx_Result.Text = CStr(CDbl(tx_Price.Text) * CDbl(tx_Number.Text))
            tx_Result.Text = result

            Try
                Label1.Text = Now.ToString
            Catch ex As Exception
                MsgBox("현재시간을 확인할 수 없습니다")
            End Try

        Catch ex As Exception
            MsgBox("입력값이 잘못되었습니다")

        End Try

        'If IsNumeric(tx_Price.Text) = False Or IsNumeric(tx_Number.Text) = False Then
        '    MsgBox("숫자를 입력해주세요.")
        'Else
        '    tx_Result.Text = CStr(CDbl(tx_Price.Text) * CDbl(tx_Number.Text)) 'VB는 형변환을 하지 않아도 묵시적으로 형변환을 해주기는 하나 정확한 코딩을 위해서는 형변환을 해주는 것이 옳다'
        'End If

    End Sub
End Class
