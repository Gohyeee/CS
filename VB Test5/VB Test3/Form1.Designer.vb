<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bt_start = New System.Windows.Forms.Button()
        Me.bt_msg = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_Price = New System.Windows.Forms.TextBox()
        Me.tx_Result = New System.Windows.Forms.TextBox()
        Me.tx_Number = New System.Windows.Forms.TextBox()
        Me.bt_Calc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_start
        '
        Me.bt_start.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.bt_start.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_start.Location = New System.Drawing.Point(97, 85)
        Me.bt_start.Name = "bt_start"
        Me.bt_start.Size = New System.Drawing.Size(256, 58)
        Me.bt_start.TabIndex = 0
        Me.bt_start.Text = "버 튼"
        Me.bt_start.UseVisualStyleBackColor = True
        '
        'bt_msg
        '
        Me.bt_msg.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.bt_msg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_msg.Location = New System.Drawing.Point(97, 170)
        Me.bt_msg.Name = "bt_msg"
        Me.bt_msg.Size = New System.Drawing.Size(256, 58)
        Me.bt_msg.TabIndex = 1
        Me.bt_msg.Text = "메세지"
        Me.bt_msg.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(561, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "단가"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(561, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "합계"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.Location = New System.Drawing.Point(561, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "개수"
        '
        'tx_Price
        '
        Me.tx_Price.Location = New System.Drawing.Point(628, 84)
        Me.tx_Price.Name = "tx_Price"
        Me.tx_Price.Size = New System.Drawing.Size(100, 21)
        Me.tx_Price.TabIndex = 6
        Me.tx_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Result
        '
        Me.tx_Result.Location = New System.Drawing.Point(628, 169)
        Me.tx_Result.Name = "tx_Result"
        Me.tx_Result.ReadOnly = True
        Me.tx_Result.Size = New System.Drawing.Size(100, 21)
        Me.tx_Result.TabIndex = 7
        Me.tx_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_Number
        '
        Me.tx_Number.Location = New System.Drawing.Point(628, 125)
        Me.tx_Number.Name = "tx_Number"
        Me.tx_Number.Size = New System.Drawing.Size(100, 21)
        Me.tx_Number.TabIndex = 8
        Me.tx_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bt_Calc
        '
        Me.bt_Calc.Font = New System.Drawing.Font("굴림", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.bt_Calc.Location = New System.Drawing.Point(628, 209)
        Me.bt_Calc.Name = "bt_Calc"
        Me.bt_Calc.Size = New System.Drawing.Size(82, 30)
        Me.bt_Calc.TabIndex = 9
        Me.bt_Calc.Text = "계 산"
        Me.bt_Calc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bt_Calc)
        Me.Controls.Add(Me.tx_Number)
        Me.Controls.Add(Me.tx_Result)
        Me.Controls.Add(Me.tx_Price)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_msg)
        Me.Controls.Add(Me.bt_start)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_start As Button
    Friend WithEvents bt_msg As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tx_Price As TextBox
    Friend WithEvents tx_Result As TextBox
    Friend WithEvents tx_Number As TextBox
    Friend WithEvents bt_Calc As Button
End Class
