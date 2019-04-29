<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxReceber = New System.Windows.Forms.RichTextBox()
        Me.Y0_Chk = New System.Windows.Forms.CheckBox()
        Me.Y1_Chk = New System.Windows.Forms.CheckBox()
        Me.Y2_Chk = New System.Windows.Forms.CheckBox()
        Me.X2_Chk = New System.Windows.Forms.CheckBox()
        Me.X1_Chk = New System.Windows.Forms.CheckBox()
        Me.X0_Chk = New System.Windows.Forms.CheckBox()
        Me.X3_Chk = New System.Windows.Forms.CheckBox()
        Me.Desligar_Btn = New System.Windows.Forms.Button()
        Me.estado_ligacao_box = New System.Windows.Forms.TextBox()
        Me.TimerSend = New System.Windows.Forms.Timer(Me.components)
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.TimerVerifyConnection = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.velocidade_lida_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxReceber
        '
        Me.TextBoxReceber.Location = New System.Drawing.Point(13, 13)
        Me.TextBoxReceber.Name = "TextBoxReceber"
        Me.TextBoxReceber.Size = New System.Drawing.Size(164, 222)
        Me.TextBoxReceber.TabIndex = 0
        Me.TextBoxReceber.Text = ""
        '
        'Y0_Chk
        '
        Me.Y0_Chk.AutoSize = True
        Me.Y0_Chk.Location = New System.Drawing.Point(242, 14)
        Me.Y0_Chk.Name = "Y0_Chk"
        Me.Y0_Chk.Size = New System.Drawing.Size(39, 17)
        Me.Y0_Chk.TabIndex = 1
        Me.Y0_Chk.Text = "Y0"
        Me.Y0_Chk.UseVisualStyleBackColor = True
        '
        'Y1_Chk
        '
        Me.Y1_Chk.AutoSize = True
        Me.Y1_Chk.Location = New System.Drawing.Point(242, 37)
        Me.Y1_Chk.Name = "Y1_Chk"
        Me.Y1_Chk.Size = New System.Drawing.Size(39, 17)
        Me.Y1_Chk.TabIndex = 2
        Me.Y1_Chk.Text = "Y1"
        Me.Y1_Chk.UseVisualStyleBackColor = True
        '
        'Y2_Chk
        '
        Me.Y2_Chk.AutoSize = True
        Me.Y2_Chk.Location = New System.Drawing.Point(242, 60)
        Me.Y2_Chk.Name = "Y2_Chk"
        Me.Y2_Chk.Size = New System.Drawing.Size(39, 17)
        Me.Y2_Chk.TabIndex = 3
        Me.Y2_Chk.Text = "Y2"
        Me.Y2_Chk.UseVisualStyleBackColor = True
        '
        'X2_Chk
        '
        Me.X2_Chk.AutoSize = True
        Me.X2_Chk.Location = New System.Drawing.Point(242, 142)
        Me.X2_Chk.Name = "X2_Chk"
        Me.X2_Chk.Size = New System.Drawing.Size(39, 17)
        Me.X2_Chk.TabIndex = 6
        Me.X2_Chk.Text = "X2"
        Me.X2_Chk.UseVisualStyleBackColor = True
        '
        'X1_Chk
        '
        Me.X1_Chk.AutoSize = True
        Me.X1_Chk.Location = New System.Drawing.Point(242, 119)
        Me.X1_Chk.Name = "X1_Chk"
        Me.X1_Chk.Size = New System.Drawing.Size(39, 17)
        Me.X1_Chk.TabIndex = 5
        Me.X1_Chk.Text = "X1"
        Me.X1_Chk.UseVisualStyleBackColor = True
        '
        'X0_Chk
        '
        Me.X0_Chk.AutoSize = True
        Me.X0_Chk.Location = New System.Drawing.Point(242, 96)
        Me.X0_Chk.Name = "X0_Chk"
        Me.X0_Chk.Size = New System.Drawing.Size(39, 17)
        Me.X0_Chk.TabIndex = 4
        Me.X0_Chk.Text = "X0"
        Me.X0_Chk.UseVisualStyleBackColor = True
        '
        'X3_Chk
        '
        Me.X3_Chk.AutoSize = True
        Me.X3_Chk.Location = New System.Drawing.Point(242, 165)
        Me.X3_Chk.Name = "X3_Chk"
        Me.X3_Chk.Size = New System.Drawing.Size(39, 17)
        Me.X3_Chk.TabIndex = 7
        Me.X3_Chk.Text = "X3"
        Me.X3_Chk.UseVisualStyleBackColor = True
        '
        'Desligar_Btn
        '
        Me.Desligar_Btn.Location = New System.Drawing.Point(242, 188)
        Me.Desligar_Btn.Name = "Desligar_Btn"
        Me.Desligar_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Desligar_Btn.TabIndex = 12
        Me.Desligar_Btn.Text = "Desligar"
        Me.Desligar_Btn.UseVisualStyleBackColor = True
        '
        'estado_ligacao_box
        '
        Me.estado_ligacao_box.Location = New System.Drawing.Point(13, 275)
        Me.estado_ligacao_box.Name = "estado_ligacao_box"
        Me.estado_ligacao_box.Size = New System.Drawing.Size(164, 20)
        Me.estado_ligacao_box.TabIndex = 13
        '
        'TimerSend
        '
        '
        'TimerReceive
        '
        '
        'TimerVerifyConnection
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nivel da Agua"
        '
        'velocidade_lida_box
        '
        Me.velocidade_lida_box.Location = New System.Drawing.Point(218, 275)
        Me.velocidade_lida_box.Name = "velocidade_lida_box"
        Me.velocidade_lida_box.Size = New System.Drawing.Size(100, 20)
        Me.velocidade_lida_box.TabIndex = 11
        Me.velocidade_lida_box.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "---------------------------------"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Estado da conneccao"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 304)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.estado_ligacao_box)
        Me.Controls.Add(Me.Desligar_Btn)
        Me.Controls.Add(Me.velocidade_lida_box)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.X3_Chk)
        Me.Controls.Add(Me.X2_Chk)
        Me.Controls.Add(Me.X1_Chk)
        Me.Controls.Add(Me.X0_Chk)
        Me.Controls.Add(Me.Y2_Chk)
        Me.Controls.Add(Me.Y1_Chk)
        Me.Controls.Add(Me.Y0_Chk)
        Me.Controls.Add(Me.TextBoxReceber)
        Me.Name = "Form1"
        Me.Text = "Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxReceber As RichTextBox
    Friend WithEvents Y0_Chk As CheckBox
    Friend WithEvents Y1_Chk As CheckBox
    Friend WithEvents Y2_Chk As CheckBox
    Friend WithEvents X2_Chk As CheckBox
    Friend WithEvents X1_Chk As CheckBox
    Friend WithEvents X0_Chk As CheckBox
    Friend WithEvents X3_Chk As CheckBox
    Friend WithEvents Desligar_Btn As Button
    Friend WithEvents estado_ligacao_box As TextBox
    Friend WithEvents TimerSend As Timer
    Friend WithEvents TimerReceive As Timer
    Friend WithEvents TimerVerifyConnection As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents velocidade_lida_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
