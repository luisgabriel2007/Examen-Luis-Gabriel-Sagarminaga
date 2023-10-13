<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Playbill", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(309, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 60)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Suma"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(292, 121)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(292, 175)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 27)
        Me.TextBox2.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Playbill", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(305, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 37)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Sumar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(292, 302)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(125, 27)
        Me.TextBox3.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Magneto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(29, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 31)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Pantalla de Inicio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Suma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
End Class
