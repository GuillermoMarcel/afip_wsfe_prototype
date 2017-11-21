
Public Class DetalleFactura
    Property Codigo As Long?
    Property Cantidad As Integer
    Property PUnitario As Decimal
    Property Descripcion As String
    Property Alicuota As Decimal
    ''' <summary>
    ''' SubTotal de Precios sin IVA
    ''' </summary>
    ''' <returns></returns>
    ReadOnly Property Subtotal As Decimal
        Get
            Return Cantidad * PUnitario
        End Get
    End Property
    ''' <summary>
    ''' SubTotal del IVA + Precio Total
    ''' </summary>
    ''' <returns></returns>
    ReadOnly Property SubTotalConIva As Decimal
        Get
            Return getSubTotalIva() + Subtotal
        End Get
    End Property
    ''' <summary>
    ''' Valor de IVA por unidad
    ''' </summary>
    ''' <returns></returns>
    Function getIvaUnitario() As Decimal
        Return Alicuota * PUnitario / 100
    End Function
    ''' <summary>
    ''' SubTotal del Iva Unicamente
    ''' </summary>
    ''' <returns></returns>
    Function getSubTotalIva() As Decimal
        Return getIvaUnitario() * Cantidad
    End Function




End Class
