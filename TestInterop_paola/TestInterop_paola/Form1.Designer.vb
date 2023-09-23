<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bttnGuardarExcel = New System.Windows.Forms.Button()
        Me.bttnGuardarWord = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttnGuardarExcel
        '
        Me.bttnGuardarExcel.BackgroundImage = CType(resources.GetObject("bttnGuardarExcel.BackgroundImage"), System.Drawing.Image)
        Me.bttnGuardarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttnGuardarExcel.Location = New System.Drawing.Point(435, 202)
        Me.bttnGuardarExcel.Name = "bttnGuardarExcel"
        Me.bttnGuardarExcel.Size = New System.Drawing.Size(104, 91)
        Me.bttnGuardarExcel.TabIndex = 7
        Me.bttnGuardarExcel.UseVisualStyleBackColor = True
        '
        'bttnGuardarWord
        '
        Me.bttnGuardarWord.BackgroundImage = CType(resources.GetObject("bttnGuardarWord.BackgroundImage"), System.Drawing.Image)
        Me.bttnGuardarWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttnGuardarWord.Location = New System.Drawing.Point(315, 202)
        Me.bttnGuardarWord.Name = "bttnGuardarWord"
        Me.bttnGuardarWord.Size = New System.Drawing.Size(104, 91)
        Me.bttnGuardarWord.TabIndex = 6
        Me.bttnGuardarWord.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(290, 109)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(264, 29)
        Me.TextBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingresa tu texto:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 390)
        Me.Controls.Add(Me.bttnGuardarExcel)
        Me.Controls.Add(Me.bttnGuardarWord)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttnGuardarExcel As Button
    Friend WithEvents bttnGuardarWord As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
