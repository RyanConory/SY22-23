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
        Me.RedTextBox = New System.Windows.Forms.TextBox()
        Me.BlueTextBox = New System.Windows.Forms.TextBox()
        Me.GreenTextBox = New System.Windows.Forms.TextBox()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.colorOvalshape = New System.Windows.Forms.PictureBox()
        CType(Me.colorOvalshape, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Red (0-225)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Blue (0-225)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Green (0-225)"
        '
        'RedTextBox
        '
        Me.RedTextBox.Location = New System.Drawing.Point(22, 61)
        Me.RedTextBox.Name = "RedTextBox"
        Me.RedTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RedTextBox.TabIndex = 4
        '
        'BlueTextBox
        '
        Me.BlueTextBox.Location = New System.Drawing.Point(22, 137)
        Me.BlueTextBox.Name = "BlueTextBox"
        Me.BlueTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BlueTextBox.TabIndex = 5
        '
        'GreenTextBox
        '
        Me.GreenTextBox.Location = New System.Drawing.Point(22, 213)
        Me.GreenTextBox.Name = "GreenTextBox"
        Me.GreenTextBox.Size = New System.Drawing.Size(100, 22)
        Me.GreenTextBox.TabIndex = 6
        '
        'ViewButton
        '
        Me.ViewButton.Location = New System.Drawing.Point(22, 254)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(100, 23)
        Me.ViewButton.TabIndex = 7
        Me.ViewButton.Text = "View Color"
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(22, 296)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 23)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'colorOvalshape
        '
        Me.colorOvalshape.Location = New System.Drawing.Point(142, 26)
        Me.colorOvalshape.Name = "colorOvalshape"
        Me.colorOvalshape.Size = New System.Drawing.Size(100, 299)
        Me.colorOvalshape.TabIndex = 9
        Me.colorOvalshape.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 350)
        Me.Controls.Add(Me.colorOvalshape)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.GreenTextBox)
        Me.Controls.Add(Me.BlueTextBox)
        Me.Controls.Add(Me.RedTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Color Mixer"
        CType(Me.colorOvalshape, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RedTextBox As TextBox
    Friend WithEvents BlueTextBox As TextBox
    Friend WithEvents GreenTextBox As TextBox
    Friend WithEvents ViewButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents colorOvalshape As PictureBox
End Class
