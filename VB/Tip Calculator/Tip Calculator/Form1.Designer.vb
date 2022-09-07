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
        Me.CalcButton1 = New System.Windows.Forms.Button()
        Me.GrandTotalLabel1 = New System.Windows.Forms.Label()
        Me.TotalTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TipTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SalesTextBox1 = New System.Windows.Forms.TextBox()
        Me.SubLabel5 = New System.Windows.Forms.Label()
        Me.SalesLabel6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CalcButton1
        '
        Me.CalcButton1.Location = New System.Drawing.Point(12, 12)
        Me.CalcButton1.Name = "CalcButton1"
        Me.CalcButton1.Size = New System.Drawing.Size(100, 23)
        Me.CalcButton1.TabIndex = 0
        Me.CalcButton1.Text = "Calculate"
        Me.CalcButton1.UseVisualStyleBackColor = True
        '
        'GrandTotalLabel1
        '
        Me.GrandTotalLabel1.AutoSize = True
        Me.GrandTotalLabel1.Location = New System.Drawing.Point(112, 178)
        Me.GrandTotalLabel1.Name = "GrandTotalLabel1"
        Me.GrandTotalLabel1.Size = New System.Drawing.Size(0, 16)
        Me.GrandTotalLabel1.TabIndex = 1
        '
        'TotalTextBox1
        '
        Me.TotalTextBox1.Location = New System.Drawing.Point(113, 42)
        Me.TotalTextBox1.Name = "TotalTextBox1"
        Me.TotalTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TotalTextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Grand Total"
        '
        'TipTextBox1
        '
        Me.TipTextBox1.Location = New System.Drawing.Point(113, 76)
        Me.TipTextBox1.Name = "TipTextBox1"
        Me.TipTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TipTextBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tip"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sales Tax"
        '
        'SalesTextBox1
        '
        Me.SalesTextBox1.Location = New System.Drawing.Point(113, 110)
        Me.SalesTextBox1.Name = "SalesTextBox1"
        Me.SalesTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.SalesTextBox1.TabIndex = 8
        '
        'SubLabel5
        '
        Me.SubLabel5.AutoSize = True
        Me.SubLabel5.Location = New System.Drawing.Point(26, 144)
        Me.SubLabel5.Name = "SubLabel5"
        Me.SubLabel5.Size = New System.Drawing.Size(65, 16)
        Me.SubLabel5.TabIndex = 9
        Me.SubLabel5.Text = "Sub Total"
        '
        'SalesLabel6
        '
        Me.SalesLabel6.AutoSize = True
        Me.SalesLabel6.Location = New System.Drawing.Point(112, 144)
        Me.SalesLabel6.Name = "SalesLabel6"
        Me.SalesLabel6.Size = New System.Drawing.Size(0, 16)
        Me.SalesLabel6.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 221)
        Me.Controls.Add(Me.SalesLabel6)
        Me.Controls.Add(Me.SubLabel5)
        Me.Controls.Add(Me.SalesTextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TipTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotalTextBox1)
        Me.Controls.Add(Me.GrandTotalLabel1)
        Me.Controls.Add(Me.CalcButton1)
        Me.Name = "Form1"
        Me.Text = "Tip Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalcButton1 As Button
    Friend WithEvents GrandTotalLabel1 As Label
    Friend WithEvents TotalTextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TipTextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SalesTextBox1 As TextBox
    Friend WithEvents SubLabel5 As Label
    Friend WithEvents SalesLabel6 As Label
End Class
