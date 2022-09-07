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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.AmountLabel2 = New System.Windows.Forms.Label()
        Me.ZipLabel3 = New System.Windows.Forms.Label()
        Me.ExpLabel4 = New System.Windows.Forms.Label()
        Me.CCLabel5 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox2 = New System.Windows.Forms.TextBox()
        Me.ZipTextBox3 = New System.Windows.Forms.TextBox()
        Me.ExpTextBox4 = New System.Windows.Forms.TextBox()
        Me.CCTextBox5 = New System.Windows.Forms.TextBox()
        Me.BuyButton1 = New System.Windows.Forms.Button()
        Me.CancelButton2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel1
        '
        Me.NameLabel1.AutoSize = True
        Me.NameLabel1.Location = New System.Drawing.Point(47, 46)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(42, 13)
        Me.NameLabel1.TabIndex = 0
        Me.NameLabel1.Text = "Name"
        '
        'AmountLabel2
        '
        Me.AmountLabel2.AutoSize = True
        Me.AmountLabel2.Location = New System.Drawing.Point(47, 157)
        Me.AmountLabel2.Name = "AmountLabel2"
        Me.AmountLabel2.Size = New System.Drawing.Size(57, 13)
        Me.AmountLabel2.TabIndex = 1
        Me.AmountLabel2.Text = "Amount"
        '
        'ZipLabel3
        '
        Me.ZipLabel3.AutoSize = True
        Me.ZipLabel3.Location = New System.Drawing.Point(47, 134)
        Me.ZipLabel3.Name = "ZipLabel3"
        Me.ZipLabel3.Size = New System.Drawing.Size(26, 13)
        Me.ZipLabel3.TabIndex = 2
        Me.ZipLabel3.Text = "Zip"
        '
        'ExpLabel4
        '
        Me.ExpLabel4.AutoSize = True
        Me.ExpLabel4.Location = New System.Drawing.Point(47, 104)
        Me.ExpLabel4.Name = "ExpLabel4"
        Me.ExpLabel4.Size = New System.Drawing.Size(64, 13)
        Me.ExpLabel4.TabIndex = 3
        Me.ExpLabel4.Text = "Exp Date"
        '
        'CCLabel5
        '
        Me.CCLabel5.AutoSize = True
        Me.CCLabel5.Location = New System.Drawing.Point(47, 73)
        Me.CCLabel5.Name = "CCLabel5"
        Me.CCLabel5.Size = New System.Drawing.Size(35, 13)
        Me.CCLabel5.TabIndex = 4
        Me.CCLabel5.Text = "CC#"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(128, 39)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 5
        '
        'AmountTextBox2
        '
        Me.AmountTextBox2.Location = New System.Drawing.Point(128, 157)
        Me.AmountTextBox2.Name = "AmountTextBox2"
        Me.AmountTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox2.TabIndex = 6
        '
        'ZipTextBox3
        '
        Me.ZipTextBox3.Location = New System.Drawing.Point(128, 127)
        Me.ZipTextBox3.Name = "ZipTextBox3"
        Me.ZipTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.ZipTextBox3.TabIndex = 7
        '
        'ExpTextBox4
        '
        Me.ExpTextBox4.Location = New System.Drawing.Point(128, 97)
        Me.ExpTextBox4.Name = "ExpTextBox4"
        Me.ExpTextBox4.Size = New System.Drawing.Size(100, 20)
        Me.ExpTextBox4.TabIndex = 8
        '
        'CCTextBox5
        '
        Me.CCTextBox5.Location = New System.Drawing.Point(128, 66)
        Me.CCTextBox5.Name = "CCTextBox5"
        Me.CCTextBox5.Size = New System.Drawing.Size(100, 20)
        Me.CCTextBox5.TabIndex = 9
        '
        'BuyButton1
        '
        Me.BuyButton1.Location = New System.Drawing.Point(50, 191)
        Me.BuyButton1.Name = "BuyButton1"
        Me.BuyButton1.Size = New System.Drawing.Size(75, 23)
        Me.BuyButton1.TabIndex = 10
        Me.BuyButton1.Text = "Buy"
        Me.BuyButton1.UseVisualStyleBackColor = True
        '
        'CancelButton2
        '
        Me.CancelButton2.Location = New System.Drawing.Point(144, 191)
        Me.CancelButton2.Name = "CancelButton2"
        Me.CancelButton2.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton2.TabIndex = 11
        Me.CancelButton2.Text = "Cancel"
        Me.CancelButton2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(253, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 250)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CancelButton2)
        Me.Controls.Add(Me.BuyButton1)
        Me.Controls.Add(Me.CCTextBox5)
        Me.Controls.Add(Me.ExpTextBox4)
        Me.Controls.Add(Me.ZipTextBox3)
        Me.Controls.Add(Me.AmountTextBox2)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.CCLabel5)
        Me.Controls.Add(Me.ExpLabel4)
        Me.Controls.Add(Me.ZipLabel3)
        Me.Controls.Add(Me.AmountLabel2)
        Me.Controls.Add(Me.NameLabel1)
        Me.Font = New System.Drawing.Font("MS PGothic", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "My Application"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel1 As Label
    Friend WithEvents AmountLabel2 As Label
    Friend WithEvents ZipLabel3 As Label
    Friend WithEvents ExpLabel4 As Label
    Friend WithEvents CCLabel5 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AmountTextBox2 As TextBox
    Friend WithEvents ZipTextBox3 As TextBox
    Friend WithEvents ExpTextBox4 As TextBox
    Friend WithEvents CCTextBox5 As TextBox
    Friend WithEvents BuyButton1 As Button
    Friend WithEvents CancelButton2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
