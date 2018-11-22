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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.folio = New System.Windows.Forms.Label()
        Me.lbl_folio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(56, 9)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(39, 13)
        Me.lbl_fecha.TabIndex = 1
        Me.lbl_fecha.Text = "Label2"
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Location = New System.Drawing.Point(236, 9)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(39, 13)
        Me.lbl_hora.TabIndex = 2
        Me.lbl_hora.Text = "Label3"
        '
        'folio
        '
        Me.folio.AutoSize = True
        Me.folio.Location = New System.Drawing.Point(299, 9)
        Me.folio.Name = "folio"
        Me.folio.Size = New System.Drawing.Size(32, 13)
        Me.folio.TabIndex = 3
        Me.folio.Text = "Folio:"
        '
        'lbl_folio
        '
        Me.lbl_folio.AutoSize = True
        Me.lbl_folio.Location = New System.Drawing.Point(337, 9)
        Me.lbl_folio.Name = "lbl_folio"
        Me.lbl_folio.Size = New System.Drawing.Size(39, 13)
        Me.lbl_folio.TabIndex = 4
        Me.lbl_folio.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Número de cliente"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(105, 30)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cliente"
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Location = New System.Drawing.Point(59, 62)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_cliente.TabIndex = 8
        Me.lbl_cliente.Text = "Label4"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(420, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Nuevo (F1)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(239, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_folio)
        Me.Controls.Add(Me.folio)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Proyecto Final Jesús Torres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents folio As Label
    Friend WithEvents lbl_folio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
End Class
