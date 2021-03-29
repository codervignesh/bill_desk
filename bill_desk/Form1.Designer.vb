<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bill_desk
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pay = New System.Windows.Forms.Button()
        Me.nme = New System.Windows.Forms.TextBox()
        Me.cv = New System.Windows.Forms.TextBox()
        Me.amt = New System.Windows.Forms.TextBox()
        Me.mo = New System.Windows.Forms.ListBox()
        Me.yr = New System.Windows.Forms.ListBox()
        Me.crd_pic1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.crd_no2 = New System.Windows.Forms.TextBox()
        Me.crd_no1 = New System.Windows.Forms.TextBox()
        Me.hde = New System.Windows.Forms.Button()
        CType(Me.crd_pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(412, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BILL DESK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 72)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CARD NO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(sender)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "EXP DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 36)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NAME ON CARD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 439)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 36)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CVV"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(76, 506)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 36)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "AMOUNT"
        '
        'pay
        '
        Me.pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay.Location = New System.Drawing.Point(399, 609)
        Me.pay.Name = "pay"
        Me.pay.Size = New System.Drawing.Size(292, 54)
        Me.pay.TabIndex = 6
        Me.pay.Text = "Proceed to pay"
        Me.pay.UseVisualStyleBackColor = True
        '
        'nme
        '
        Me.nme.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nme.Location = New System.Drawing.Point(376, 367)
        Me.nme.Name = "nme"
        Me.nme.Size = New System.Drawing.Size(533, 38)
        Me.nme.TabIndex = 8
        '
        'cv
        '
        Me.cv.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cv.Location = New System.Drawing.Point(376, 439)
        Me.cv.Name = "cv"
        Me.cv.Size = New System.Drawing.Size(122, 38)
        Me.cv.TabIndex = 9
        '
        'amt
        '
        Me.amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amt.Location = New System.Drawing.Point(376, 504)
        Me.amt.Name = "amt"
        Me.amt.Size = New System.Drawing.Size(533, 38)
        Me.amt.TabIndex = 10
        '
        'mo
        '
        Me.mo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mo.FormattingEnabled = True
        Me.mo.ItemHeight = 29
        Me.mo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.mo.Location = New System.Drawing.Point(376, 295)
        Me.mo.Name = "mo"
        Me.mo.Size = New System.Drawing.Size(120, 33)
        Me.mo.TabIndex = 11
        '
        'yr
        '
        Me.yr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yr.FormattingEnabled = True
        Me.yr.ItemHeight = 29
        Me.yr.Items.AddRange(New Object() {"20", "21", "22", "23", "24", "25", "26"})
        Me.yr.Location = New System.Drawing.Point(556, 295)
        Me.yr.Name = "yr"
        Me.yr.Size = New System.Drawing.Size(120, 33)
        Me.yr.TabIndex = 12
        '
        'crd_pic1
        '
        Me.crd_pic1.Location = New System.Drawing.Point(934, 209)
        Me.crd_pic1.Name = "crd_pic1"
        Me.crd_pic1.Size = New System.Drawing.Size(62, 38)
        Me.crd_pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.crd_pic1.TabIndex = 13
        Me.crd_pic1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(233, 72)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ACCOUNT NO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(receiver)"
        '
        'crd_no2
        '
        Me.crd_no2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crd_no2.Location = New System.Drawing.Point(375, 115)
        Me.crd_no2.Name = "crd_no2"
        Me.crd_no2.Size = New System.Drawing.Size(533, 38)
        Me.crd_no2.TabIndex = 19
        '
        'crd_no1
        '
        Me.crd_no1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crd_no1.Location = New System.Drawing.Point(375, 203)
        Me.crd_no1.Name = "crd_no1"
        Me.crd_no1.Size = New System.Drawing.Size(533, 38)
        Me.crd_no1.TabIndex = 20
        '
        'hde
        '
        Me.hde.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hde.Location = New System.Drawing.Point(528, 439)
        Me.hde.Name = "hde"
        Me.hde.Size = New System.Drawing.Size(116, 38)
        Me.hde.TabIndex = 21
        Me.hde.Text = "SHOW"
        Me.hde.UseVisualStyleBackColor = True
        '
        'bill_desk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1093, 745)
        Me.Controls.Add(Me.hde)
        Me.Controls.Add(Me.crd_no1)
        Me.Controls.Add(Me.crd_no2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.crd_pic1)
        Me.Controls.Add(Me.yr)
        Me.Controls.Add(Me.mo)
        Me.Controls.Add(Me.amt)
        Me.Controls.Add(Me.cv)
        Me.Controls.Add(Me.nme)
        Me.Controls.Add(Me.pay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "bill_desk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BILL Desk"
        CType(Me.crd_pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pay As Button
    Friend WithEvents nme As TextBox
    Friend WithEvents cv As TextBox
    Friend WithEvents amt As TextBox
    Friend WithEvents mo As ListBox
    Friend WithEvents yr As ListBox
    Friend WithEvents crd_pic1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents crd_no2 As TextBox
    Friend WithEvents crd_no1 As TextBox
    Friend WithEvents hde As Button
End Class
