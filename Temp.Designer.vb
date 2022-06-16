<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Temp
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
        Me.components = New System.ComponentModel.Container()
        Me.L_min = New System.Windows.Forms.Label()
        Me.L_seg = New System.Windows.Forms.Label()
        Me.Up1 = New System.Windows.Forms.Button()
        Me.Down1 = New System.Windows.Forms.Button()
        Me.Up2 = New System.Windows.Forms.Button()
        Me.Down2 = New System.Windows.Forms.Button()
        Me.Iniciar1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Control = New System.Windows.Forms.Timer(Me.components)
        Me.Parar = New System.Windows.Forms.Button()
        Me.Temporizador = New System.Windows.Forms.Timer(Me.components)
        Me.Progreso = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'L_min
        '
        Me.L_min.AutoSize = True
        Me.L_min.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.L_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.L_min.ForeColor = System.Drawing.Color.White
        Me.L_min.Location = New System.Drawing.Point(4, 78)
        Me.L_min.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_min.Name = "L_min"
        Me.L_min.Size = New System.Drawing.Size(319, 226)
        Me.L_min.TabIndex = 0
        Me.L_min.Text = "00"
        '
        'L_seg
        '
        Me.L_seg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_seg.AutoSize = True
        Me.L_seg.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.L_seg.ForeColor = System.Drawing.Color.White
        Me.L_seg.Location = New System.Drawing.Point(427, 78)
        Me.L_seg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_seg.Name = "L_seg"
        Me.L_seg.Size = New System.Drawing.Size(319, 226)
        Me.L_seg.TabIndex = 1
        Me.L_seg.Text = "30"
        '
        'Up1
        '
        Me.Up1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Up1.Location = New System.Drawing.Point(144, 30)
        Me.Up1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Up1.Name = "Up1"
        Me.Up1.Size = New System.Drawing.Size(24, 30)
        Me.Up1.TabIndex = 2
        Me.Up1.Text = "٨"
        Me.Up1.UseVisualStyleBackColor = True
        '
        'Down1
        '
        Me.Down1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Down1.Location = New System.Drawing.Point(144, 307)
        Me.Down1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Down1.Name = "Down1"
        Me.Down1.Size = New System.Drawing.Size(24, 30)
        Me.Down1.TabIndex = 3
        Me.Down1.Text = "٧"
        Me.Down1.UseVisualStyleBackColor = True
        '
        'Up2
        '
        Me.Up2.BackColor = System.Drawing.Color.Transparent
        Me.Up2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Up2.Location = New System.Drawing.Point(572, 30)
        Me.Up2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Up2.Name = "Up2"
        Me.Up2.Size = New System.Drawing.Size(24, 30)
        Me.Up2.TabIndex = 4
        Me.Up2.Text = "٨"
        Me.Up2.UseVisualStyleBackColor = False
        '
        'Down2
        '
        Me.Down2.BackColor = System.Drawing.Color.Transparent
        Me.Down2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Down2.Location = New System.Drawing.Point(572, 307)
        Me.Down2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Down2.Name = "Down2"
        Me.Down2.Size = New System.Drawing.Size(24, 30)
        Me.Down2.TabIndex = 5
        Me.Down2.Text = "٧"
        Me.Down2.UseVisualStyleBackColor = False
        '
        'Iniciar1
        '
        Me.Iniciar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Iniciar1.FlatAppearance.BorderSize = 0
        Me.Iniciar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Iniciar1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Iniciar1.Location = New System.Drawing.Point(172, 445)
        Me.Iniciar1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Iniciar1.Name = "Iniciar1"
        Me.Iniciar1.Size = New System.Drawing.Size(124, 48)
        Me.Iniciar1.TabIndex = 6
        Me.Iniciar1.Text = "Iniciar"
        Me.Iniciar1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(489, 445)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 48)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Reiniciar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Control
        '
        Me.Control.Enabled = True
        '
        'Parar
        '
        Me.Parar.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Parar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Parar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Parar.Location = New System.Drawing.Point(172, 445)
        Me.Parar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Parar.Name = "Parar"
        Me.Parar.Size = New System.Drawing.Size(124, 48)
        Me.Parar.TabIndex = 9
        Me.Parar.Text = "Parar"
        Me.Parar.UseVisualStyleBackColor = False
        '
        'Temporizador
        '
        '
        'Progreso
        '
        Me.Progreso.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Up2)
        Me.Panel1.Controls.Add(Me.Down2)
        Me.Panel1.Controls.Add(Me.Up1)
        Me.Panel1.Controls.Add(Me.Down1)
        Me.Panel1.Controls.Add(Me.L_seg)
        Me.Panel1.Controls.Add(Me.L_min)
        Me.Panel1.Location = New System.Drawing.Point(51, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 371)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(288, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 226)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = ":"
        '
        'Temp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(844, 505)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Iniciar1)
        Me.Controls.Add(Me.Parar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Temp"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents L_min As Label
    Friend WithEvents L_seg As Label
    Friend WithEvents Up1 As Button
    Friend WithEvents Down1 As Button
    Friend WithEvents Up2 As Button
    Friend WithEvents Down2 As Button
    Friend WithEvents Iniciar1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Control As Timer
    Friend WithEvents Parar As Button
    Friend WithEvents Progreso As Timer
    Friend WithEvents Temporizador As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
