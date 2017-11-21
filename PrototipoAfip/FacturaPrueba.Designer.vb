<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaPrueba
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalneto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.descuento = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.iva21 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tootal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(785, 179)
        Me.DataGridView1.TabIndex = 0
        '
        'Addbtn
        '
        Me.Addbtn.Location = New System.Drawing.Point(564, 70)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(151, 25)
        Me.Addbtn.TabIndex = 1
        Me.Addbtn.Text = "Agregar"
        Me.Addbtn.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(557, 286)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 97)
        Me.DataGridView2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SubTotalNeto"
        '
        'totalneto
        '
        Me.totalneto.AutoSize = True
        Me.totalneto.Location = New System.Drawing.Point(370, 321)
        Me.totalneto.Name = "totalneto"
        Me.totalneto.Size = New System.Drawing.Size(39, 13)
        Me.totalneto.TabIndex = 2
        Me.totalneto.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descuento"
        '
        'descuento
        '
        Me.descuento.AutoSize = True
        Me.descuento.Location = New System.Drawing.Point(370, 334)
        Me.descuento.Name = "descuento"
        Me.descuento.Size = New System.Drawing.Size(39, 13)
        Me.descuento.TabIndex = 2
        Me.descuento.Text = "Label1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(278, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "SubTotal"
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Location = New System.Drawing.Point(370, 347)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(39, 13)
        Me.subtotal.TabIndex = 2
        Me.subtotal.Text = "Label1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(278, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "IVA 21"
        '
        'iva21
        '
        Me.iva21.AutoSize = True
        Me.iva21.Location = New System.Drawing.Point(370, 360)
        Me.iva21.Name = "iva21"
        Me.iva21.Size = New System.Drawing.Size(39, 13)
        Me.iva21.TabIndex = 2
        Me.iva21.Text = "Label1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(278, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total"
        '
        'tootal
        '
        Me.tootal.AutoSize = True
        Me.tootal.Location = New System.Drawing.Point(370, 373)
        Me.tootal.Name = "tootal"
        Me.tootal.Size = New System.Drawing.Size(39, 13)
        Me.tootal.TabIndex = 2
        Me.tootal.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(441, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Random"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FacturaPrueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 479)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tootal)
        Me.Controls.Add(Me.iva21)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.descuento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.totalneto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FacturaPrueba"
        Me.Text = "FacturaPrueba"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Addbtn As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents totalneto As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents descuento As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents subtotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents iva21 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tootal As Label
    Friend WithEvents Button1 As Button
End Class
