Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Dim ip_address As IPAddress = IPAddress.Parse("127.0.0.1")

    Dim client As New Sockets.TcpClient

    Private Sub LigarBtn_Click(sender As Object, e As EventArgs) Handles LigarBtn.Click
        client.Connect(ip_address, 81)
    End Sub

    Private Sub LigarY0_MotorBtn_Click(sender As Object, e As EventArgs) Handles LigarY0_MotorBtn.Click
        CommandVars.Y0 = 1
    End Sub

    Private Sub DesligarY0_MotorBtn_Click(sender As Object, e As EventArgs) Handles DesligarY0_MotorBtn.Click
        CommandVars.Y0 = 0
    End Sub

    Private Sub LigarY1_EV_InBtn_Click(sender As Object, e As EventArgs) Handles LigarY1_EV_InBtn.Click
        CommandVars.Y1 = 1
    End Sub

    Private Sub DesligarY1_EV_In_Click(sender As Object, e As EventArgs) Handles DesligarY1_EV_In.Click
        CommandVars.Y1 = 0
    End Sub

    Private Sub LigarY2_EV_OutBtn_Click(sender As Object, e As EventArgs) Handles LigarY2_EV_OutBtn.Click
        CommandVars.Y2 = 1
    End Sub

    Private Sub DesligarY2_EV_OutBtn_Click(sender As Object, e As EventArgs) Handles DesligarY2_EV_OutBtn.Click
        CommandVars.Y2 = 0
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        estado_connecao_box.Text = client.Connected

        If client.Connected Then
            Dim message_size As Integer = client.Available

            If message_size > 0 Then
                Dim message_in_stream As NetworkStream = client.GetStream()
                Dim buffer(5000) As Byte
                message_in_stream.Read(buffer, 0, message_size)

                Dim message_in As String = ""
                Dim i As Integer
                For i = 0 To message_size - 1
                    message_in = message_in + Chr(buffer(i))
                Next i

                StateVars.X0 = Mid(message_in, 1, 1)
                StateVars.X1 = Mid(message_in, 2, 1)
                StateVars.X2 = Mid(message_in, 3, 1)
                StateVars.X3 = Mid(message_in, 4, 1)
                StateVars.nivel = Asc(Mid(message_in, 5, 1))

                StateVars.Y0 = Mid(message_in, 6, 1)
                StateVars.Y1 = Mid(message_in, 7, 1)
                StateVars.Y2 = Mid(message_in, 8, 1)

                X0_AlarmEmptyChk.Checked = StateVars.X0
                X1_EmptyChk.Checked = StateVars.X1
                X2_FullChk.Checked = StateVars.X2
                X3_AlarmMaxChk.Checked = StateVars.X3
                nivel_da_agua.Text = StateVars.nivel

                Y0_MotorChk.Checked = StateVars.Y0
                Y1_EV_InChk.Checked = StateVars.Y1
                Y2_EV_OutChk.Checked = StateVars.Y2
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerReceive.Interval = 100
        TimerReceive.Enabled = True

        TimerSend.Interval = 100
        TimerSend.Enabled = True
    End Sub

    Private Sub TimerSend_Tick(sender As Object, e As EventArgs) Handles TimerSend.Tick
        If client.Connected = True Then
            Dim buffer(3) As Byte
            buffer(0) = CommandVars.Y0 + 48
            buffer(1) = CommandVars.Y1 + 48
            buffer(2) = CommandVars.Y2 + 48

            Dim message_out_stream As NetworkStream
            message_out_stream = client.GetStream()
            Try
                message_out_stream.Write(buffer, 0, 3)
            Catch ex As Exception
                client.Close()
                client = New Sockets.TcpClient
            End Try
        End If
    End Sub

    Private Sub TimerReservatorio_Tick(sender As Object, e As EventArgs) Handles TimerReservatorio.Tick
        If X3_AlarmMaxChk.CheckState Then
            CommandVars.Y0 = 0
            CommandVars.Y1 = 0
            CommandVars.Y2 = 1
            AlertBox.Text = "Water too high!"
        ElseIf X2_FullChk.CheckState Then
            CommandVars.Y0 = 0
            CommandVars.Y1 = 0
            CommandVars.Y2 = 1
            AlertBox.Text = "None"
        ElseIf X1_EmptyChk.CheckState Then
            'CommandVars.Y0 = 1
            'CommandVars.Y1 = 1
            CommandVars.Y2 = 1
            AlertBox.Text = "None"
        ElseIf X0_AlarmEmptyChk.CheckState Then
            CommandVars.Y0 = 1
            CommandVars.Y1 = 1
            CommandVars.Y2 = 1
            AlertBox.Text = "None"
        Else
            CommandVars.Y0 = 1
            CommandVars.Y1 = 1
            CommandVars.Y2 = 0
            AlertBox.Text = "Water too low!"
        End If
    End Sub

    Private Sub AutoModeChk_CheckedChanged(sender As Object, e As EventArgs) Handles AutoModeChk.CheckedChanged
        If AutoModeChk.CheckState Then
            TimerReservatorio.Interval = 100
            TimerReservatorio.Enabled = True
        Else
            TimerReservatorio.Enabled = False
            CommandVars.Y0 = 0
            CommandVars.Y1 = 0
            CommandVars.Y2 = 0
        End If
    End Sub
End Class
