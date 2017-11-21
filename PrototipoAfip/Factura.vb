Public Class Factura
    Property Numero As Integer?
    Property TipoFactura As String
    Property TipoFacturaId As Integer?
    Property PuntoVenta As Integer?
    Property MonedaId As Integer?
    Property DocTipo As Integer?
    Property Documento As Long?
    Property Concepto As Integer?
    Property Fecha As Date
    Property FechaVencimiento As Date
    Property CAE As Long?
    Property CAEVencimiento As Date



    Property Cliente
    Property Detalles As New List(Of DetalleFactura)
    ''' <summary>
    ''' Sumarizacion de los subtotales (cantidad + pUnitario) sin iva ni descuentos
    ''' </summary>
    ''' <returns></returns>
    ReadOnly Property SubTotalPreDescuento As Decimal
        Get
            Dim r As Decimal = 0
            For Each detalle In Detalles
                r += detalle.Subtotal
            Next
            Return r
        End Get
    End Property

    ''' <summary>
    ''' Valor Positivo que se substrae del neto
    ''' </summary>
    ''' <returns></returns>
    Property Descuento As Decimal

    ''' <summary>
    ''' SubTotalPreDescuento incluido el descuento
    ''' </summary>
    ''' <returns></returns>
    ReadOnly Property SubTotalNeto As Decimal
        Get
            Return SubTotalPreDescuento - Descuento
        End Get
    End Property

    ReadOnly Property SubTotalesIva As List(Of SubTotalIva)
        Get
            Dim lista As New List(Of SubTotalIva)
            Dim s As SubTotalIva
            For Each detalle In Detalles
                s = lista.Where(Function(x) x.Alicuota = detalle.Alicuota).FirstOrDefault

                If s Is Nothing Then
                    s = New SubTotalIva With {
                        .Valor = detalle.getSubTotalIva,
                        .Alicuota = detalle.Alicuota
                    }
                    lista.Add(s)
                Else
                    s.Valor += detalle.getSubTotalIva
                End If
            Next
            Return lista
        End Get
    End Property
    Function getSubTotalIva(alicuota As Decimal) As Decimal
        Dim s As SubTotalIva = SubTotalesIva.Where(Function(x) x.Alicuota = alicuota).FirstOrDefault
        Return If(IsNothing(s), 0, s.Valor)
    End Function

    ReadOnly Property Total As Decimal
        Get
            Dim t As Decimal = SubTotalNeto
            For Each iva As SubTotalIva In SubTotalesIva
                t += iva.Valor
            Next
            Return t
        End Get
    End Property

    Sub addDetalle(codigo As Long?,
                        cant As Integer,
                        precioNeto As Decimal,
                        descripcion As String,
                        alicuota As Decimal)
        Dim detalle As New DetalleFactura With {
            .Alicuota = alicuota,
            .Cantidad = cant,
            .Codigo = codigo,
            .Descripcion = descripcion,
            .PUnitario = precioNeto
        }
        Me.Detalles.Add(detalle)
    End Sub
    Sub addDetallePrecioFinal(codigo As Long?,
                              cant As Integer,
                              precioFinal As Decimal,
                              descripcion As String,
                              alicuota As Decimal)
        Dim neto As Decimal = precioFinal / (1 + (alicuota / 100))
        addDetalle(codigo, cant, neto, descripcion, alicuota)
    End Sub

End Class

Public Class SubTotalIva
    Property Alicuota As Decimal
    Property Valor As Decimal
End Class

