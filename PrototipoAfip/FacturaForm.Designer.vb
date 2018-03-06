<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FacturaForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CargaBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TiposComprobantesCMB = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TipoConcepto = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MyCuitTX = New System.Windows.Forms.TextBox()
        Me.ptos_venta_cm = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TipoDocCMB = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MonedaCMB = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TipoIVACmb = New System.Windows.Forms.ComboBox()
        Me.DocTX = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NroCbteTX = New System.Windows.Forms.TextBox()
        Me.FechaDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NetoTX = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ImpIvaTx = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TotalTx = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.VtoDTP = New System.Windows.Forms.DateTimePicker()
        Me.VtoCB = New System.Windows.Forms.CheckBox()
        Me.CalcBtn = New System.Windows.Forms.Button()
        Me.NetoRB = New System.Windows.Forms.RadioButton()
        Me.TotalRB = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.testing_rb = New System.Windows.Forms.RadioButton()
        Me.produccion_rb = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LinearWinForm2 = New BarcodeLib.Barcode.WinForms.LinearWinForm()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CargaBtn
        '
        Me.CargaBtn.Location = New System.Drawing.Point(230, 34)
        Me.CargaBtn.Name = "CargaBtn"
        Me.CargaBtn.Size = New System.Drawing.Size(75, 44)
        Me.CargaBtn.TabIndex = 0
        Me.CargaBtn.Text = "Cargar"
        Me.CargaBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pto Venta"
        '
        'TiposComprobantesCMB
        '
        Me.TiposComprobantesCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TiposComprobantesCMB.FormattingEnabled = True
        Me.TiposComprobantesCMB.Location = New System.Drawing.Point(128, 193)
        Me.TiposComprobantesCMB.Name = "TiposComprobantesCMB"
        Me.TiposComprobantesCMB.Size = New System.Drawing.Size(224, 21)
        Me.TiposComprobantesCMB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Concepto"
        '
        'TipoConcepto
        '
        Me.TipoConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoConcepto.FormattingEnabled = True
        Me.TipoConcepto.Location = New System.Drawing.Point(128, 232)
        Me.TipoConcepto.Name = "TipoConcepto"
        Me.TipoConcepto.Size = New System.Drawing.Size(224, 21)
        Me.TipoConcepto.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mi CUIT"
        '
        'MyCuitTX
        '
        Me.MyCuitTX.Location = New System.Drawing.Point(82, 84)
        Me.MyCuitTX.Name = "MyCuitTX"
        Me.MyCuitTX.Size = New System.Drawing.Size(121, 20)
        Me.MyCuitTX.TabIndex = 2
        '
        'ptos_venta_cm
        '
        Me.ptos_venta_cm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ptos_venta_cm.FormattingEnabled = True
        Me.ptos_venta_cm.Location = New System.Drawing.Point(128, 167)
        Me.ptos_venta_cm.Name = "ptos_venta_cm"
        Me.ptos_venta_cm.Size = New System.Drawing.Size(224, 21)
        Me.ptos_venta_cm.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tipo Doc"
        '
        'TipoDocCMB
        '
        Me.TipoDocCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoDocCMB.FormattingEnabled = True
        Me.TipoDocCMB.Location = New System.Drawing.Point(128, 259)
        Me.TipoDocCMB.Name = "TipoDocCMB"
        Me.TipoDocCMB.Size = New System.Drawing.Size(224, 21)
        Me.TipoDocCMB.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(392, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Moneda"
        '
        'MonedaCMB
        '
        Me.MonedaCMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MonedaCMB.FormattingEnabled = True
        Me.MonedaCMB.Location = New System.Drawing.Point(452, 84)
        Me.MonedaCMB.Name = "MonedaCMB"
        Me.MonedaCMB.Size = New System.Drawing.Size(224, 21)
        Me.MonedaCMB.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(422, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "IVA"
        '
        'TipoIVACmb
        '
        Me.TipoIVACmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoIVACmb.FormattingEnabled = True
        Me.TipoIVACmb.Location = New System.Drawing.Point(452, 140)
        Me.TipoIVACmb.Name = "TipoIVACmb"
        Me.TipoIVACmb.Size = New System.Drawing.Size(224, 21)
        Me.TipoIVACmb.TabIndex = 3
        '
        'DocTX
        '
        Me.DocTX.Location = New System.Drawing.Point(128, 286)
        Me.DocTX.Name = "DocTX"
        Me.DocTX.Size = New System.Drawing.Size(224, 20)
        Me.DocTX.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Doc"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 315)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nro Cbte"
        '
        'NroCbteTX
        '
        Me.NroCbteTX.Location = New System.Drawing.Point(128, 312)
        Me.NroCbteTX.Name = "NroCbteTX"
        Me.NroCbteTX.ReadOnly = True
        Me.NroCbteTX.Size = New System.Drawing.Size(224, 20)
        Me.NroCbteTX.TabIndex = 4
        '
        'FechaDTP
        '
        Me.FechaDTP.Location = New System.Drawing.Point(128, 338)
        Me.FechaDTP.Name = "FechaDTP"
        Me.FechaDTP.Size = New System.Drawing.Size(200, 20)
        Me.FechaDTP.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(68, 344)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Fecha"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(378, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Importe Neto"
        '
        'NetoTX
        '
        Me.NetoTX.Location = New System.Drawing.Point(452, 111)
        Me.NetoTX.Name = "NetoTX"
        Me.NetoTX.Size = New System.Drawing.Size(224, 20)
        Me.NetoTX.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(384, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Importe IVA"
        '
        'ImpIvaTx
        '
        Me.ImpIvaTx.Location = New System.Drawing.Point(452, 167)
        Me.ImpIvaTx.Name = "ImpIvaTx"
        Me.ImpIvaTx.ReadOnly = True
        Me.ImpIvaTx.Size = New System.Drawing.Size(224, 20)
        Me.ImpIvaTx.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(377, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Importe Total"
        '
        'TotalTx
        '
        Me.TotalTx.Location = New System.Drawing.Point(452, 193)
        Me.TotalTx.Name = "TotalTx"
        Me.TotalTx.ReadOnly = True
        Me.TotalTx.Size = New System.Drawing.Size(224, 20)
        Me.TotalTx.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(68, 370)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Vto"
        '
        'VtoDTP
        '
        Me.VtoDTP.Enabled = False
        Me.VtoDTP.Location = New System.Drawing.Point(152, 364)
        Me.VtoDTP.Name = "VtoDTP"
        Me.VtoDTP.Size = New System.Drawing.Size(200, 20)
        Me.VtoDTP.TabIndex = 5
        '
        'VtoCB
        '
        Me.VtoCB.AutoSize = True
        Me.VtoCB.Location = New System.Drawing.Point(128, 369)
        Me.VtoCB.Name = "VtoCB"
        Me.VtoCB.Size = New System.Drawing.Size(15, 14)
        Me.VtoCB.TabIndex = 6
        Me.VtoCB.UseVisualStyleBackColor = True
        '
        'CalcBtn
        '
        Me.CalcBtn.Location = New System.Drawing.Point(452, 219)
        Me.CalcBtn.Name = "CalcBtn"
        Me.CalcBtn.Size = New System.Drawing.Size(75, 23)
        Me.CalcBtn.TabIndex = 7
        Me.CalcBtn.Text = "Calcular"
        Me.CalcBtn.UseVisualStyleBackColor = True
        '
        'NetoRB
        '
        Me.NetoRB.AutoSize = True
        Me.NetoRB.Checked = True
        Me.NetoRB.Location = New System.Drawing.Point(452, 61)
        Me.NetoRB.Name = "NetoRB"
        Me.NetoRB.Size = New System.Drawing.Size(48, 17)
        Me.NetoRB.TabIndex = 8
        Me.NetoRB.TabStop = True
        Me.NetoRB.Text = "Neto"
        Me.NetoRB.UseVisualStyleBackColor = True
        '
        'TotalRB
        '
        Me.TotalRB.AutoSize = True
        Me.TotalRB.Location = New System.Drawing.Point(506, 61)
        Me.TotalRB.Name = "TotalRB"
        Me.TotalRB.Size = New System.Drawing.Size(49, 17)
        Me.TotalRB.TabIndex = 8
        Me.TotalRB.Text = "Total"
        Me.TotalRB.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(506, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Registrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(596, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 29)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Ultimo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Resultado
        '
        Me.Resultado.Location = New System.Drawing.Point(412, 315)
        Me.Resultado.Multiline = True
        Me.Resultado.Name = "Resultado"
        Me.Resultado.ReadOnly = True
        Me.Resultado.Size = New System.Drawing.Size(305, 182)
        Me.Resultado.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(68, 170)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Pto Venta"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(68, 196)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Tipo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(68, 235)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Concepto"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(68, 262)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Tipo Doc"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(68, 289)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(27, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Doc"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(68, 315)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Nro Cbte"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(68, 344)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Fecha"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(68, 370)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(23, 13)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Vto"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(128, 369)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'testing_rb
        '
        Me.testing_rb.AutoSize = True
        Me.testing_rb.Checked = True
        Me.testing_rb.Location = New System.Drawing.Point(12, 21)
        Me.testing_rb.Name = "testing_rb"
        Me.testing_rb.Size = New System.Drawing.Size(60, 17)
        Me.testing_rb.TabIndex = 12
        Me.testing_rb.TabStop = True
        Me.testing_rb.Text = "Testing"
        Me.testing_rb.UseVisualStyleBackColor = True
        '
        'produccion_rb
        '
        Me.produccion_rb.AutoSize = True
        Me.produccion_rb.Location = New System.Drawing.Point(78, 21)
        Me.produccion_rb.Name = "produccion_rb"
        Me.produccion_rb.Size = New System.Drawing.Size(79, 17)
        Me.produccion_rb.TabIndex = 11
        Me.produccion_rb.TabStop = True
        Me.produccion_rb.Text = "Produccion"
        Me.produccion_rb.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.produccion_rb)
        Me.GroupBox1.Controls.Add(Me.testing_rb)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 59)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entorno"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(358, 272)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 34)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "CUIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LinearWinForm2
        '
        Me.LinearWinForm2.AddCheckSum = False
        Me.LinearWinForm2.AutoSize = True
        Me.LinearWinForm2.BackgroundColor = System.Drawing.Color.White
        Me.LinearWinForm2.BarColor = System.Drawing.Color.Black
        Me.LinearWinForm2.BarHeight = 80.0!
        Me.LinearWinForm2.BarHeightRatio = 0.4!
        Me.LinearWinForm2.BarWidth = 1.0!
        Me.LinearWinForm2.BearerBars = BarcodeLib.Barcode.BearerBar.None
        Me.LinearWinForm2.BearerBarWidth = 1.0!
        Me.LinearWinForm2.BottomMargin = 0!
        Me.LinearWinForm2.CodabarStartChar = BarcodeLib.Barcode.CodabarStartStopChar.A
        Me.LinearWinForm2.CodabarStopChar = BarcodeLib.Barcode.CodabarStartStopChar.A
        Me.LinearWinForm2.Data = "BLSample"
        Me.LinearWinForm2.ImageFormat = System.Drawing.Imaging.ImageFormat.Png
        Me.LinearWinForm2.ImageHeight = 0!
        Me.LinearWinForm2.ImageWidth = 0!
        Me.LinearWinForm2.InterGap = 1.0!
        Me.LinearWinForm2.LeftMargin = 0!
        Me.LinearWinForm2.Location = New System.Drawing.Point(98, 527)
        Me.LinearWinForm2.N = 2.0!
        Me.LinearWinForm2.Name = "LinearWinForm2"
        Me.LinearWinForm2.ProcessTilde = False
        Me.LinearWinForm2.ResizeImage = False
        Me.LinearWinForm2.Resolution = 96
        Me.LinearWinForm2.RightMargin = 0!
        Me.LinearWinForm2.Rotate = BarcodeLib.Barcode.RotateOrientation.BottomFacingDown
        Me.LinearWinForm2.SData = ""
        Me.LinearWinForm2.ShowStartStopChar = True
        Me.LinearWinForm2.ShowText = True
        Me.LinearWinForm2.Size = New System.Drawing.Size(143, 98)
        Me.LinearWinForm2.SSeparation = 12.0!
        Me.LinearWinForm2.TabIndex = 17
        Me.LinearWinForm2.TextFont = New System.Drawing.Font("Arial", 9.0!)
        Me.LinearWinForm2.TextFontColor = System.Drawing.Color.Black
        Me.LinearWinForm2.TopMargin = 0!
        Me.LinearWinForm2.Type = BarcodeLib.Barcode.BarcodeType.CODE128
        Me.LinearWinForm2.UOM = BarcodeLib.Barcode.UnitOfMeasure.PIXEL
        Me.LinearWinForm2.UPCENumber = 0
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 495)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Guardar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FacturaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 637)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.LinearWinForm2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TotalRB)
        Me.Controls.Add(Me.NetoRB)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CalcBtn)
        Me.Controls.Add(Me.VtoCB)
        Me.Controls.Add(Me.VtoDTP)
        Me.Controls.Add(Me.FechaDTP)
        Me.Controls.Add(Me.NroCbteTX)
        Me.Controls.Add(Me.TotalTx)
        Me.Controls.Add(Me.ImpIvaTx)
        Me.Controls.Add(Me.NetoTX)
        Me.Controls.Add(Me.DocTX)
        Me.Controls.Add(Me.TipoIVACmb)
        Me.Controls.Add(Me.MonedaCMB)
        Me.Controls.Add(Me.TipoDocCMB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TipoConcepto)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ptos_venta_cm)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TiposComprobantesCMB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MyCuitTX)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CargaBtn)
        Me.Name = "FacturaForm"
        Me.Text = "FacturaForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CargaBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TiposComprobantesCMB As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TipoConcepto As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MyCuitTX As TextBox
    Friend WithEvents ptos_venta_cm As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TipoDocCMB As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MonedaCMB As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TipoIVACmb As ComboBox
    Friend WithEvents DocTX As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NroCbteTX As TextBox
    Friend WithEvents FechaDTP As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents NetoTX As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ImpIvaTx As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TotalTx As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents VtoDTP As DateTimePicker
    Friend WithEvents VtoCB As CheckBox
    Friend WithEvents CalcBtn As Button
    Friend WithEvents NetoRB As RadioButton
    Friend WithEvents TotalRB As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Resultado As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents testing_rb As RadioButton
    Friend WithEvents produccion_rb As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents LinearWinForm2 As BarcodeLib.Barcode.WinForms.LinearWinForm
    Friend WithEvents Button5 As Button
End Class
