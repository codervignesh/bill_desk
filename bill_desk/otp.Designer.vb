<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class otpPage
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
        Me.otpcode = New System.Windows.Forms.TextBox()
        Me.payment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'otpcode
        '
        Me.otpcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otpcode.Location = New System.Drawing.Point(293, 33)
        Me.otpcode.Name = "otpcode"
        Me.otpcode.Size = New System.Drawing.Size(100, 38)
        Me.otpcode.TabIndex = 0
        '
        'payment
        '
        Me.payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payment.Location = New System.Drawing.Point(95, 113)
        Me.payment.Name = "payment"
        Me.payment.Size = New System.Drawing.Size(232, 79)
        Me.payment.TabIndex = 1
        Me.payment.Text = "Make Payment"
        Me.payment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter 4 digit OTP"
        '
        'otpPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 222)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.payment)
        Me.Controls.Add(Me.otpcode)
        Me.Name = "otpPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "otp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents otpcode As TextBox
    Friend WithEvents payment As Button
    Friend WithEvents Label1 As Label
End Class
