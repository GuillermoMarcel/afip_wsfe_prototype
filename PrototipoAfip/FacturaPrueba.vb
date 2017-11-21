Public Class FacturaPrueba

    Public Sub New()
        InitializeComponent()
        f = New Factura
        actualizar()
    End Sub
    Sub actualizar()
        DataGridView1.DataSource = Nothing
        DataGridView2.DataSource = Nothing
        DataGridView1.DataSource = f.Detalles
        DataGridView2.DataSource = f.SubTotalesIva

        totalneto.Text = f.SubTotalPreDescuento.ToString("C")
        descuento.Text = f.Descuento.ToString("C")
        subtotal.Text = f.SubTotalNeto.ToString("C")
        iva21.Text = f.getSubTotalIva(21).ToString("C")
        tootal.Text = f.Total.ToString("C")

    End Sub
    Private f As Factura
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Dim cod As Long? = Long.Parse(InputBox("Codigo"))
        Dim cant As Integer = Integer.Parse(InputBox("Cantidad"))
        Dim desc As String = InputBox("Desc")
        Dim precio As Decimal = Decimal.Parse(InputBox("Precio"))
        Dim alicuota As Decimal = Decimal.Parse(InputBox("Alicuota"))
        Dim neto As Boolean = InputBox("Es Neto? s/n").Equals("s")

        If neto Then
            f.addDetalle(cod, cant, precio, desc, alicuota)
        Else
            f.addDetallePrecioFinal(cod, cant, precio, desc, alicuota)
        End If
        actualizar()
    End Sub

    Private Sub FacturaPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private r As Random
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        r = New Random
        For i = 0 To 10

            Dim cod = r.Next(1, 222)
            Dim cant = r.Next(1, 10)
            Dim prec = randDec(15, 200)
            Dim ali = 21
            Dim desc = Guid.NewGuid().ToString().Substring(0, 8)

            f.addDetalle(cod, cant, prec, desc, ali)
        Next
        actualizar()
    End Sub

    Private Function randDec(min As Decimal, max As Decimal) As Decimal
        min *= 100
        max *= 100
        Return r.Next(min, max) / 100

    End Function
End Class