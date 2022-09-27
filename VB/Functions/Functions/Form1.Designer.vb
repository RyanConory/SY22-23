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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PerimeterLabel = New System.Windows.Forms.Label()
        Me.Arealabel = New System.Windows.Forms.Label()
        Me.widthTextBox = New System.Windows.Forms.TextBox()
        Me.LengthTextBox = New System.Windows.Forms.TextBox()
        Me.clearbutton = New System.Windows.Forms.Button()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.triangleareabutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 51)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Width"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 51)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Perimeter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 51)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Area"
        '
        'PerimeterLabel
        '
        Me.PerimeterLabel.AutoSize = True
        Me.PerimeterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerimeterLabel.Location = New System.Drawing.Point(273, 177)
        Me.PerimeterLabel.Name = "PerimeterLabel"
        Me.PerimeterLabel.Size = New System.Drawing.Size(0, 51)
        Me.PerimeterLabel.TabIndex = 4
        '
        'Arealabel
        '
        Me.Arealabel.AutoSize = True
        Me.Arealabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Arealabel.Location = New System.Drawing.Point(273, 253)
        Me.Arealabel.Name = "Arealabel"
        Me.Arealabel.Size = New System.Drawing.Size(0, 51)
        Me.Arealabel.TabIndex = 5
        '
        'widthTextBox
        '
        Me.widthTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.widthTextBox.Location = New System.Drawing.Point(282, 92)
        Me.widthTextBox.Name = "widthTextBox"
        Me.widthTextBox.Size = New System.Drawing.Size(100, 61)
        Me.widthTextBox.TabIndex = 6
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LengthTextBox.Location = New System.Drawing.Point(282, 7)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(100, 61)
        Me.LengthTextBox.TabIndex = 7
        '
        'clearbutton
        '
        Me.clearbutton.Location = New System.Drawing.Point(21, 337)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(143, 60)
        Me.clearbutton.TabIndex = 8
        Me.clearbutton.Text = "Clear"
        Me.clearbutton.UseVisualStyleBackColor = True
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(265, 337)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(137, 60)
        Me.CalcButton.TabIndex = 9
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.Location = New System.Drawing.Point(497, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 100)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Aquamarine
        Me.Button3.Location = New System.Drawing.Point(497, 234)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 106)
        Me.Button3.TabIndex = 12
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button4.Location = New System.Drawing.Point(497, 118)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 110)
        Me.Button4.TabIndex = 13
        Me.Button4.UseVisualStyleBackColor = False
        '
        'triangleareabutton
        '
        Me.triangleareabutton.Location = New System.Drawing.Point(636, 12)
        Me.triangleareabutton.Name = "triangleareabutton"
        Me.triangleareabutton.Size = New System.Drawing.Size(120, 23)
        Me.triangleareabutton.TabIndex = 14
        Me.triangleareabutton.Text = "trianglearea"
        Me.triangleareabutton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 450)
        Me.Controls.Add(Me.triangleareabutton)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.clearbutton)
        Me.Controls.Add(Me.LengthTextBox)
        Me.Controls.Add(Me.widthTextBox)
        Me.Controls.Add(Me.Arealabel)
        Me.Controls.Add(Me.PerimeterLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PerimeterLabel As Label
    Friend WithEvents Arealabel As Label
    Friend WithEvents widthTextBox As TextBox
    Friend WithEvents LengthTextBox As TextBox
    Friend WithEvents clearbutton As Button
    Friend WithEvents CalcButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents triangleareabutton As Button
End Class
