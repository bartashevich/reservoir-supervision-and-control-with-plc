<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.LigarY0_MotorBtn = New System.Windows.Forms.Button()
        Me.DesligarY0_MotorBtn = New System.Windows.Forms.Button()
        Me.DesligarY2_EV_OutBtn = New System.Windows.Forms.Button()
        Me.LigarY2_EV_OutBtn = New System.Windows.Forms.Button()
        Me.DesligarY1_EV_In = New System.Windows.Forms.Button()
        Me.LigarY1_EV_InBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Y0_MotorChk = New System.Windows.Forms.CheckBox()
        Me.Y1_EV_InChk = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.X3_AlarmMaxChk = New System.Windows.Forms.CheckBox()
        Me.X2_FullChk = New System.Windows.Forms.CheckBox()
        Me.X1_EmptyChk = New System.Windows.Forms.CheckBox()
        Me.X0_AlarmEmptyChk = New System.Windows.Forms.CheckBox()
        Me.Y2_EV_OutChk = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LigarBtn = New System.Windows.Forms.Button()
        Me.estado_connecao_box = New System.Windows.Forms.TextBox()
        Me.nivel_da_agua = New System.Windows.Forms.TextBox()
        Me.TimerSend = New System.Windows.Forms.Timer(Me.components)
        Me.TimerReservatorio = New System.Windows.Forms.Timer(Me.components)
        Me.AutoModeChk = New System.Windows.Forms.CheckBox()
        Me.AlertBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerReceive
        '
        '
        'LigarY0_MotorBtn
        '
        Me.LigarY0_MotorBtn.Location = New System.Drawing.Point(12, 243)
        Me.LigarY0_MotorBtn.Name = "LigarY0_MotorBtn"
        Me.LigarY0_MotorBtn.Size = New System.Drawing.Size(110, 35)
        Me.LigarY0_MotorBtn.TabIndex = 9
        Me.LigarY0_MotorBtn.Text = "LigarY0_Motor"
        Me.LigarY0_MotorBtn.UseVisualStyleBackColor = True
        '
        'DesligarY0_MotorBtn
        '
        Me.DesligarY0_MotorBtn.Location = New System.Drawing.Point(12, 276)
        Me.DesligarY0_MotorBtn.Name = "DesligarY0_MotorBtn"
        Me.DesligarY0_MotorBtn.Size = New System.Drawing.Size(110, 35)
        Me.DesligarY0_MotorBtn.TabIndex = 10
        Me.DesligarY0_MotorBtn.Text = "DesligarY0_Motor"
        Me.DesligarY0_MotorBtn.UseVisualStyleBackColor = True
        '
        'DesligarY2_EV_OutBtn
        '
        Me.DesligarY2_EV_OutBtn.Location = New System.Drawing.Point(579, 289)
        Me.DesligarY2_EV_OutBtn.Name = "DesligarY2_EV_OutBtn"
        Me.DesligarY2_EV_OutBtn.Size = New System.Drawing.Size(110, 35)
        Me.DesligarY2_EV_OutBtn.TabIndex = 12
        Me.DesligarY2_EV_OutBtn.Text = "DesligarY2_EV_Out"
        Me.DesligarY2_EV_OutBtn.UseVisualStyleBackColor = True
        '
        'LigarY2_EV_OutBtn
        '
        Me.LigarY2_EV_OutBtn.Location = New System.Drawing.Point(579, 256)
        Me.LigarY2_EV_OutBtn.Name = "LigarY2_EV_OutBtn"
        Me.LigarY2_EV_OutBtn.Size = New System.Drawing.Size(110, 35)
        Me.LigarY2_EV_OutBtn.TabIndex = 11
        Me.LigarY2_EV_OutBtn.Text = "LigarY2_EV_Out"
        Me.LigarY2_EV_OutBtn.UseVisualStyleBackColor = True
        '
        'DesligarY1_EV_In
        '
        Me.DesligarY1_EV_In.Location = New System.Drawing.Point(177, 205)
        Me.DesligarY1_EV_In.Name = "DesligarY1_EV_In"
        Me.DesligarY1_EV_In.Size = New System.Drawing.Size(110, 35)
        Me.DesligarY1_EV_In.TabIndex = 14
        Me.DesligarY1_EV_In.Text = "DesligarY1_EV_In"
        Me.DesligarY1_EV_In.UseVisualStyleBackColor = True
        '
        'LigarY1_EV_InBtn
        '
        Me.LigarY1_EV_InBtn.Location = New System.Drawing.Point(177, 172)
        Me.LigarY1_EV_InBtn.Name = "LigarY1_EV_InBtn"
        Me.LigarY1_EV_InBtn.Size = New System.Drawing.Size(110, 35)
        Me.LigarY1_EV_InBtn.TabIndex = 13
        Me.LigarY1_EV_InBtn.Text = "LigarY1_EV_In"
        Me.LigarY1_EV_InBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.com2com.My.Resources.Resources.Reservatorio_sem_labels_transparente
        Me.PictureBox1.Location = New System.Drawing.Point(1, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(715, 333)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Pumps"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "animated"
        '
        'Y0_MotorChk
        '
        Me.Y0_MotorChk.AutoSize = True
        Me.Y0_MotorChk.Location = New System.Drawing.Point(22, 110)
        Me.Y0_MotorChk.Name = "Y0_MotorChk"
        Me.Y0_MotorChk.Size = New System.Drawing.Size(72, 17)
        Me.Y0_MotorChk.TabIndex = 19
        Me.Y0_MotorChk.Text = "Y0_Motor"
        Me.Y0_MotorChk.UseVisualStyleBackColor = True
        '
        'Y1_EV_InChk
        '
        Me.Y1_EV_InChk.AutoSize = True
        Me.Y1_EV_InChk.Location = New System.Drawing.Point(177, 74)
        Me.Y1_EV_InChk.Name = "Y1_EV_InChk"
        Me.Y1_EV_InChk.Size = New System.Drawing.Size(74, 17)
        Me.Y1_EV_InChk.TabIndex = 22
        Me.Y1_EV_InChk.Text = "Y1_EV_In"
        Me.Y1_EV_InChk.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "animated"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(191, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Valves"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(474, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Light-Leds"
        '
        'X3_AlarmMaxChk
        '
        Me.X3_AlarmMaxChk.AutoSize = True
        Me.X3_AlarmMaxChk.Location = New System.Drawing.Point(477, 79)
        Me.X3_AlarmMaxChk.Name = "X3_AlarmMaxChk"
        Me.X3_AlarmMaxChk.Size = New System.Drawing.Size(91, 17)
        Me.X3_AlarmMaxChk.TabIndex = 24
        Me.X3_AlarmMaxChk.Text = "X3_AlarmMax"
        Me.X3_AlarmMaxChk.UseVisualStyleBackColor = True
        '
        'X2_FullChk
        '
        Me.X2_FullChk.AutoSize = True
        Me.X2_FullChk.Location = New System.Drawing.Point(477, 109)
        Me.X2_FullChk.Name = "X2_FullChk"
        Me.X2_FullChk.Size = New System.Drawing.Size(61, 17)
        Me.X2_FullChk.TabIndex = 25
        Me.X2_FullChk.Text = "X2_Full"
        Me.X2_FullChk.UseVisualStyleBackColor = True
        '
        'X1_EmptyChk
        '
        Me.X1_EmptyChk.AutoSize = True
        Me.X1_EmptyChk.Location = New System.Drawing.Point(472, 200)
        Me.X1_EmptyChk.Name = "X1_EmptyChk"
        Me.X1_EmptyChk.Size = New System.Drawing.Size(74, 17)
        Me.X1_EmptyChk.TabIndex = 26
        Me.X1_EmptyChk.Text = "X1_Empty"
        Me.X1_EmptyChk.UseVisualStyleBackColor = True
        '
        'X0_AlarmEmptyChk
        '
        Me.X0_AlarmEmptyChk.AutoSize = True
        Me.X0_AlarmEmptyChk.Location = New System.Drawing.Point(471, 251)
        Me.X0_AlarmEmptyChk.Name = "X0_AlarmEmptyChk"
        Me.X0_AlarmEmptyChk.Size = New System.Drawing.Size(100, 17)
        Me.X0_AlarmEmptyChk.TabIndex = 27
        Me.X0_AlarmEmptyChk.Text = "X0_AlarmEmpty"
        Me.X0_AlarmEmptyChk.UseVisualStyleBackColor = True
        '
        'Y2_EV_OutChk
        '
        Me.Y2_EV_OutChk.AutoSize = True
        Me.Y2_EV_OutChk.Location = New System.Drawing.Point(590, 164)
        Me.Y2_EV_OutChk.Name = "Y2_EV_OutChk"
        Me.Y2_EV_OutChk.Size = New System.Drawing.Size(82, 17)
        Me.Y2_EV_OutChk.TabIndex = 30
        Me.Y2_EV_OutChk.Text = "Y2_EV_Out"
        Me.Y2_EV_OutChk.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(599, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "animated"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(604, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Valves"
        '
        'LigarBtn
        '
        Me.LigarBtn.Location = New System.Drawing.Point(19, 44)
        Me.LigarBtn.Name = "LigarBtn"
        Me.LigarBtn.Size = New System.Drawing.Size(75, 23)
        Me.LigarBtn.TabIndex = 31
        Me.LigarBtn.Text = "Ligar"
        Me.LigarBtn.UseVisualStyleBackColor = True
        '
        'estado_connecao_box
        '
        Me.estado_connecao_box.Location = New System.Drawing.Point(7, 22)
        Me.estado_connecao_box.Name = "estado_connecao_box"
        Me.estado_connecao_box.Size = New System.Drawing.Size(100, 20)
        Me.estado_connecao_box.TabIndex = 32
        '
        'nivel_da_agua
        '
        Me.nivel_da_agua.Location = New System.Drawing.Point(337, 37)
        Me.nivel_da_agua.Name = "nivel_da_agua"
        Me.nivel_da_agua.Size = New System.Drawing.Size(100, 20)
        Me.nivel_da_agua.TabIndex = 33
        '
        'TimerSend
        '
        '
        'TimerReservatorio
        '
        '
        'AutoModeChk
        '
        Me.AutoModeChk.AutoSize = True
        Me.AutoModeChk.Location = New System.Drawing.Point(607, 12)
        Me.AutoModeChk.Name = "AutoModeChk"
        Me.AutoModeChk.Size = New System.Drawing.Size(78, 17)
        Me.AutoModeChk.TabIndex = 34
        Me.AutoModeChk.Text = "Modo Auto"
        Me.AutoModeChk.UseVisualStyleBackColor = True
        '
        'AlertBox
        '
        Me.AlertBox.Location = New System.Drawing.Point(194, 316)
        Me.AlertBox.Name = "AlertBox"
        Me.AlertBox.Size = New System.Drawing.Size(100, 20)
        Me.AlertBox.TabIndex = 35
        Me.AlertBox.Text = "None"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Alerts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Water Level"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Connection Status"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 346)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AlertBox)
        Me.Controls.Add(Me.AutoModeChk)
        Me.Controls.Add(Me.nivel_da_agua)
        Me.Controls.Add(Me.estado_connecao_box)
        Me.Controls.Add(Me.LigarBtn)
        Me.Controls.Add(Me.Y2_EV_OutChk)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.X0_AlarmEmptyChk)
        Me.Controls.Add(Me.X1_EmptyChk)
        Me.Controls.Add(Me.X2_FullChk)
        Me.Controls.Add(Me.X3_AlarmMaxChk)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Y1_EV_InChk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Y0_MotorChk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DesligarY2_EV_OutBtn)
        Me.Controls.Add(Me.DesligarY1_EV_In)
        Me.Controls.Add(Me.LigarY1_EV_InBtn)
        Me.Controls.Add(Me.LigarY2_EV_OutBtn)
        Me.Controls.Add(Me.DesligarY0_MotorBtn)
        Me.Controls.Add(Me.LigarY0_MotorBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimerReceive As Timer
    Friend WithEvents LigarY0_MotorBtn As Button
    Friend WithEvents DesligarY0_MotorBtn As Button
    Friend WithEvents DesligarY2_EV_OutBtn As Button
    Friend WithEvents LigarY2_EV_OutBtn As Button
    Friend WithEvents DesligarY1_EV_In As Button
    Friend WithEvents LigarY1_EV_InBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Y0_MotorChk As CheckBox
    Friend WithEvents Y1_EV_InChk As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents X3_AlarmMaxChk As CheckBox
    Friend WithEvents X2_FullChk As CheckBox
    Friend WithEvents X1_EmptyChk As CheckBox
    Friend WithEvents X0_AlarmEmptyChk As CheckBox
    Friend WithEvents Y2_EV_OutChk As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LigarBtn As Button
    Friend WithEvents estado_connecao_box As TextBox
    Friend WithEvents nivel_da_agua As TextBox
    Friend WithEvents TimerSend As Timer
    Friend WithEvents TimerReservatorio As Timer
    Friend WithEvents AutoModeChk As CheckBox
    Friend WithEvents AlertBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
End Class
