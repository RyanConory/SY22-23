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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Rhinoceros = New System.Windows.Forms.Button()
        Me.displayPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RhinoPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OrginLabel = New System.Windows.Forms.Label()
        Me.LifespanLabel = New System.Windows.Forms.Label()
        Me.EndangeredLabel = New System.Windows.Forms.Label()
        Me.DomesticatedLabel = New System.Windows.Forms.Label()
        Me.HippoPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HippoButton1 = New System.Windows.Forms.Button()
        Me.VulturePictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VultureButton1 = New System.Windows.Forms.Button()
        Me.EaglePictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EagleButton1 = New System.Windows.Forms.Button()
        Me.DogPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DogButton1 = New System.Windows.Forms.Button()
        CType(Me.displayPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RhinoPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HippoPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VulturePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EaglePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DogPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rhinoceros
        '
        Me.Rhinoceros.Location = New System.Drawing.Point(22, 328)
        Me.Rhinoceros.Name = "Rhinoceros"
        Me.Rhinoceros.Size = New System.Drawing.Size(113, 34)
        Me.Rhinoceros.TabIndex = 0
        Me.Rhinoceros.Text = "Rhinoceros"
        Me.Rhinoceros.UseVisualStyleBackColor = True
        '
        'displayPictureBox1
        '
        Me.displayPictureBox1.Location = New System.Drawing.Point(10, 10)
        Me.displayPictureBox1.Name = "displayPictureBox1"
        Me.displayPictureBox1.Size = New System.Drawing.Size(352, 178)
        Me.displayPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox1.TabIndex = 1
        Me.displayPictureBox1.TabStop = False
        '
        'RhinoPictureBox1
        '
        Me.RhinoPictureBox1.Image = CType(resources.GetObject("RhinoPictureBox1.Image"), System.Drawing.Image)
        Me.RhinoPictureBox1.Location = New System.Drawing.Point(22, 378)
        Me.RhinoPictureBox1.Name = "RhinoPictureBox1"
        Me.RhinoPictureBox1.Size = New System.Drawing.Size(163, 67)
        Me.RhinoPictureBox1.TabIndex = 2
        Me.RhinoPictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Orgin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lifespan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Endangered?:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Domesticated:"
        '
        'OrginLabel
        '
        Me.OrginLabel.AutoSize = True
        Me.OrginLabel.Location = New System.Drawing.Point(480, 22)
        Me.OrginLabel.Name = "OrginLabel"
        Me.OrginLabel.Size = New System.Drawing.Size(0, 16)
        Me.OrginLabel.TabIndex = 7
        '
        'LifespanLabel
        '
        Me.LifespanLabel.AutoSize = True
        Me.LifespanLabel.Location = New System.Drawing.Point(480, 56)
        Me.LifespanLabel.Name = "LifespanLabel"
        Me.LifespanLabel.Size = New System.Drawing.Size(0, 16)
        Me.LifespanLabel.TabIndex = 8
        '
        'EndangeredLabel
        '
        Me.EndangeredLabel.AutoSize = True
        Me.EndangeredLabel.Location = New System.Drawing.Point(480, 90)
        Me.EndangeredLabel.Name = "EndangeredLabel"
        Me.EndangeredLabel.Size = New System.Drawing.Size(0, 16)
        Me.EndangeredLabel.TabIndex = 9
        '
        'DomesticatedLabel
        '
        Me.DomesticatedLabel.AutoSize = True
        Me.DomesticatedLabel.Location = New System.Drawing.Point(480, 121)
        Me.DomesticatedLabel.Name = "DomesticatedLabel"
        Me.DomesticatedLabel.Size = New System.Drawing.Size(0, 16)
        Me.DomesticatedLabel.TabIndex = 10
        '
        'HippoPictureBox1
        '
        Me.HippoPictureBox1.Image = CType(resources.GetObject("HippoPictureBox1.Image"), System.Drawing.Image)
        Me.HippoPictureBox1.Location = New System.Drawing.Point(214, 378)
        Me.HippoPictureBox1.Name = "HippoPictureBox1"
        Me.HippoPictureBox1.Size = New System.Drawing.Size(163, 67)
        Me.HippoPictureBox1.TabIndex = 12
        Me.HippoPictureBox1.TabStop = False
        '
        'HippoButton1
        '
        Me.HippoButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.HippoButton1.Location = New System.Drawing.Point(214, 328)
        Me.HippoButton1.Name = "HippoButton1"
        Me.HippoButton1.Size = New System.Drawing.Size(113, 34)
        Me.HippoButton1.TabIndex = 11
        Me.HippoButton1.Text = "Hippopotamus"
        Me.HippoButton1.UseVisualStyleBackColor = True
        '
        'VulturePictureBox1
        '
        Me.VulturePictureBox1.Image = CType(resources.GetObject("VulturePictureBox1.Image"), System.Drawing.Image)
        Me.VulturePictureBox1.Location = New System.Drawing.Point(399, 378)
        Me.VulturePictureBox1.Name = "VulturePictureBox1"
        Me.VulturePictureBox1.Size = New System.Drawing.Size(163, 67)
        Me.VulturePictureBox1.TabIndex = 14
        Me.VulturePictureBox1.TabStop = False
        '
        'VultureButton1
        '
        Me.VultureButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.VultureButton1.Location = New System.Drawing.Point(399, 329)
        Me.VultureButton1.Name = "VultureButton1"
        Me.VultureButton1.Size = New System.Drawing.Size(113, 34)
        Me.VultureButton1.TabIndex = 13
        Me.VultureButton1.Text = "Vulture"
        Me.VultureButton1.UseVisualStyleBackColor = True
        '
        'EaglePictureBox1
        '
        Me.EaglePictureBox1.Image = CType(resources.GetObject("EaglePictureBox1.Image"), System.Drawing.Image)
        Me.EaglePictureBox1.Location = New System.Drawing.Point(581, 378)
        Me.EaglePictureBox1.Name = "EaglePictureBox1"
        Me.EaglePictureBox1.Size = New System.Drawing.Size(163, 67)
        Me.EaglePictureBox1.TabIndex = 16
        Me.EaglePictureBox1.TabStop = False
        '
        'EagleButton1
        '
        Me.EagleButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.EagleButton1.Location = New System.Drawing.Point(581, 329)
        Me.EagleButton1.Name = "EagleButton1"
        Me.EagleButton1.Size = New System.Drawing.Size(113, 34)
        Me.EagleButton1.TabIndex = 15
        Me.EagleButton1.Text = "Eagle"
        Me.EagleButton1.UseVisualStyleBackColor = True
        '
        'DogPictureBox1
        '
        Me.DogPictureBox1.Image = CType(resources.GetObject("DogPictureBox1.Image"), System.Drawing.Image)
        Me.DogPictureBox1.Location = New System.Drawing.Point(581, 239)
        Me.DogPictureBox1.Name = "DogPictureBox1"
        Me.DogPictureBox1.Size = New System.Drawing.Size(163, 67)
        Me.DogPictureBox1.TabIndex = 18
        Me.DogPictureBox1.TabStop = False
        '
        'DogButton1
        '
        Me.DogButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DogButton1.Location = New System.Drawing.Point(581, 191)
        Me.DogButton1.Name = "DogButton1"
        Me.DogButton1.Size = New System.Drawing.Size(113, 34)
        Me.DogButton1.TabIndex = 17
        Me.DogButton1.Text = "Dog"
        Me.DogButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DogPictureBox1)
        Me.Controls.Add(Me.DogButton1)
        Me.Controls.Add(Me.EaglePictureBox1)
        Me.Controls.Add(Me.EagleButton1)
        Me.Controls.Add(Me.VulturePictureBox1)
        Me.Controls.Add(Me.VultureButton1)
        Me.Controls.Add(Me.HippoPictureBox1)
        Me.Controls.Add(Me.HippoButton1)
        Me.Controls.Add(Me.DomesticatedLabel)
        Me.Controls.Add(Me.EndangeredLabel)
        Me.Controls.Add(Me.LifespanLabel)
        Me.Controls.Add(Me.OrginLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RhinoPictureBox1)
        Me.Controls.Add(Me.displayPictureBox1)
        Me.Controls.Add(Me.Rhinoceros)
        Me.Name = "Form1"
        Me.Text = "Animal Dex"
        CType(Me.displayPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RhinoPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HippoPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VulturePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EaglePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DogPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rhinoceros As Button
    Friend WithEvents displayPictureBox1 As PictureBox
    Friend WithEvents RhinoPictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OrginLabel As Label
    Friend WithEvents LifespanLabel As Label
    Friend WithEvents EndangeredLabel As Label
    Friend WithEvents DomesticatedLabel As Label
    Friend WithEvents HippoPictureBox1 As PictureBox
    Friend WithEvents HippoButton1 As Button
    Friend WithEvents VulturePictureBox1 As PictureBox
    Friend WithEvents VultureButton1 As Button
    Friend WithEvents EaglePictureBox1 As PictureBox
    Friend WithEvents EagleButton1 As Button
    Friend WithEvents DogPictureBox1 As PictureBox
    Friend WithEvents DogButton1 As Button
End Class
