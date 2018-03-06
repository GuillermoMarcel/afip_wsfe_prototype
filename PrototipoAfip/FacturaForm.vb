Imports PrototipoAfip.WSFEHOMO

Public Class FacturaForm
    Property Login As LoginClass
    Property TiposComprobantes As CbteTipoResponse
    Property TipoConceptos As ConceptoTipoResponse
    Property TipoDoc As DocTipoResponse
    Property Monedas As MonedaResponse
    Property puntosventa As FEPtoVentaResponse
    Property TiposIVA As IvaTipoResponse
    Property opcionales As OpcionalTipoResponse
    Property authRequest As FEAuthRequest
    Private url As String
    Private Sub CargaBtn_Click(sender As Object, e As EventArgs) Handles CargaBtn.Click
        Try
            authRequest = New FEAuthRequest()
            authRequest.Cuit = MyCuitTX.Text
            authRequest.Sign = Login.Sign
            authRequest.Token = Login.Token

            Dim service As New WSFEHOMO.Service
            service.Url = url

            service.ClientCertificates.Add(Login.certificado)

            puntosventa = service.FEParamGetPtosVenta(authRequest)
            ptos_venta_cm.DataSource = puntosventa.ResultGet

            TiposComprobantes = service.FEParamGetTiposCbte(authRequest)
            TiposComprobantesCMB.DataSource = TiposComprobantes.ResultGet

            TipoConceptos = service.FEParamGetTiposConcepto(authRequest)
            TipoConcepto.DataSource = TipoConceptos.ResultGet

            TipoDoc = service.FEParamGetTiposDoc(authRequest)
            TipoDocCMB.DataSource = TipoDoc.ResultGet

            Monedas = service.FEParamGetTiposMonedas(authRequest)
            MonedaCMB.DataSource = Monedas.ResultGet

            TiposIVA = service.FEParamGetTiposIva(authRequest)
            TipoIVACmb.DataSource = TiposIVA.ResultGet

            Dim lastCbteObj = service.FECompUltimoAutorizado(authRequest, 4, TiposComprobantes.ResultGet(0).Id)
            NroCbteTX.Text = lastCbteObj.CbteNro + 1

            opcionales = service.FEParamGetTiposOpcional(authRequest)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FacturaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyCuitTX.Text = My.Settings.def_cuit
        ptos_venta_cm.DisplayMember = "Nro"
        TiposComprobantesCMB.DisplayMember = "Desc"
        TipoConcepto.DisplayMember = "Desc"
        TipoDocCMB.DisplayMember = "Desc"
        MonedaCMB.DisplayMember = "Desc"
        TipoIVACmb.DisplayMember = "Desc"
    End Sub

    Private Sub VtoCB_CheckedChanged(sender As Object, e As EventArgs) Handles VtoCB.CheckedChanged, CheckBox1.CheckedChanged
        VtoDTP.Enabled = VtoCB.Checked
    End Sub

    Private Sub CalcBtn_Click(sender As Object, e As EventArgs) Handles CalcBtn.Click
        Try
            Dim iva As IvaTipo = TipoIVACmb.SelectedItem

            Dim desc As String = iva.Desc
            Dim sep = Globalization.CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator

            desc = desc.Replace(".", Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
            desc = desc.Substring(0, desc.Count - 1)
            Dim ivaval As Decimal = Decimal.Parse(desc)

            If NetoRB.Checked Then
                Dim neto As Decimal = Decimal.Parse(NetoTX.Text)
                Dim imp_iva As Decimal = neto * ivaval / 100
                Dim total As Decimal = neto + imp_iva

                ImpIvaTx.Text = imp_iva
                TotalTx.Text = total
            Else
                Dim total As Decimal = Decimal.Parse(TotalTx.Text)
                Dim mul As Decimal = 1 + (ivaval / 100)
                Dim neto As Decimal = total / mul
                Dim imp_iva = total - neto
                ImpIvaTx.Text = imp_iva
                NetoTX.Text = neto

            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles TotalRB.CheckedChanged

        NetoTX.ReadOnly = TotalRB.Checked
        NetoTX.Text = ""
        TotalTx.Text = ""
        ImpIvaTx.Text = ""
        TotalTx.ReadOnly = NetoRB.Checked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim service As WSFEHOMO.Service = getServicio()
            service.ClientCertificates.Add(Login.certificado)
            Dim pvObj As PtoVenta = ptos_venta_cm.SelectedItem
            Dim pv As Integer = pvObj.Nro
            Dim cm As CbteTipo = TiposComprobantesCMB.SelectedItem

            Dim req As New FECAERequest
            Dim cab As New FECAECabRequest
            Dim det As New FECAEDetRequest

            cab.CantReg = 1
            cab.PtoVta = pv
            cab.CbteTipo = cm.Id
            req.FeCabReq = cab

            With det
                Dim concepto As ConceptoTipo = TipoConcepto.SelectedItem
                .Concepto = concepto.Id
                Dim doctipo As DocTipo = TipoDocCMB.SelectedItem
                .DocTipo = doctipo.Id
                .DocNro = Long.Parse(DocTX.Text)

                Dim lastRes As FERecuperaLastCbteResponse = service.FECompUltimoAutorizado(authRequest, pv, cm.Id)
                Dim last As Integer = lastRes.CbteNro

                .CbteDesde = last + 1
                .CbteHasta = last + 1

                .CbteFch = FechaDTP.Value.ToString("yyyyMMdd")

                .ImpNeto = NetoTX.Text
                .ImpIVA = ImpIvaTx.Text
                .ImpTotal = TotalTx.Text

                .ImpTotConc = 0
                .ImpOpEx = 0
                .ImpTrib = 0

                Dim mon As Moneda = MonedaCMB.SelectedItem
                .MonId = mon.Id
                .MonCotiz = 1

                Dim alicuota As New AlicIva
                Dim ivat As IvaTipo = TipoIVACmb.SelectedItem
                alicuota.Id = ivat.Id
                alicuota.BaseImp = NetoTX.Text
                alicuota.Importe = ImpIvaTx.Text

                .Iva = {alicuota}


            End With

            req.FeDetReq = {det}

            Dim r = service.FECAESolicitar(authRequest, req)

            Dim m As String = "Estado: " & r.FeCabResp.Resultado & vbCrLf
            m &= "Estado Esp: " & r.FeDetResp(0).Resultado
            m &= vbCrLf
            m &= "CAE: " & r.FeDetResp(0).CAE
            m &= vbCrLf
            m &= "Vto: " & r.FeDetResp(0).CAEFchVto
            m &= vbCrLf
            m &= "Desde-Hasta: " & r.FeDetResp(0).CbteDesde & "-" & r.FeDetResp(0).CbteHasta
            m &= vbCrLf

            If r.FeDetResp(0).Observaciones IsNot Nothing Then
                For Each o In r.FeDetResp(0).Observaciones
                    m &= String.Format("Obs: {0} ({1})", o.Msg, o.Code) & vbCrLf
                Next
            End If
            If r.Errors IsNot Nothing Then
                For Each er In r.Errors
                    m &= String.Format("Er: {0}: {1}", er.Code, er.Msg) & vbCrLf
                Next
            End If
            If r.Events IsNot Nothing Then
                For Each ev In r.Events
                    m &= String.Format("Ev: {0}: {1}", ev.Code, ev.Msg) & vbCrLf
                Next
            End If
            Resultado.Text = m

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim service As WSFEHOMO.Service = getServicio()
            service.ClientCertificates.Add(Login.certificado)
            Dim pvObj As PtoVenta = ptos_venta_cm.SelectedItem
            Dim pv As Integer = pvObj.Nro
            Dim cm As CbteTipo = TiposComprobantesCMB.SelectedItem

            Dim last As FERecuperaLastCbteResponse = service.FECompUltimoAutorizado(authRequest, pv, cm.Id)

            Dim consulta As New FECompConsultaReq
            consulta.CbteNro = last.CbteNro
            consulta.CbteTipo = last.CbteTipo
            consulta.PtoVta = last.PtoVta

            Dim asdf As FECompConsultaResponse = service.FECompConsultar(authRequest, consulta)
            mostrar(asdf)





            MsgBox("El Ultimo fue: " & last.CbteNro.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostrar(asdf As FECompConsultaResponse)
        Dim r = asdf.ResultGet
        Dim m As String = ""
        If r IsNot Nothing Then
            m = "Estado: " & r.Resultado & vbCrLf
            m &= "CAE: " & r.CodAutorizacion
            m &= vbCrLf
            m &= "Vto: " & r.FchVto
            m &= vbCrLf
            m &= "Desde-Hasta: " & r.CbteDesde & "-" & r.CbteHasta
            m &= vbCrLf
            m &= "Para: " & r.DocNro
            m &= vbCrLf
            m &= "Tipo Emision: " & r.EmisionTipo
            m &= vbCrLf
            m &= "Total: " & r.ImpTotal
            m &= vbCrLf

            If r.Observaciones IsNot Nothing Then
                For Each o In r.Observaciones
                    m &= String.Format("Obs: {0} ({1})", o.Msg, o.Code) & vbCrLf
                Next
            End If



            With LinearWinForm2
                .Type = BarcodeLib.Barcode.BarcodeType.INTERLEAVED25
                .Data = String.Concat(authRequest.Cuit,
                                      r.CbteTipo.ToString("00"),
                                      r.PtoVta.ToString("0000"),
                                      r.CodAutorizacion,
                                      r.FchVto)
                .AddCheckSum = True
                .UOM = BarcodeLib.Barcode.UnitOfMeasure.PIXEL
                .BarWidth = 2
                .BarHeight = 80
                .LeftMargin = 5
                .RightMargin = 5
                .TopMargin = 5
                .BottomMargin = 5
                .ImageFormat = Imaging.ImageFormat.Bmp
                .drawBarcode(LinearWinForm2.CreateGraphics)
            End With
        Else
            m = "No hay ninguno anterior"
        End If

        If asdf.Errors IsNot Nothing Then
            For Each er In asdf.Errors
                m &= vbCrLf & String.Format("Er: {0}: {1}", er.Code, er.Msg)
            Next
        End If
        If asdf.Events IsNot Nothing Then
            For Each ev In asdf.Events
                m &= vbCrLf & String.Format("Ev: {0}: {1}", ev.Code, ev.Msg)
            Next
        End If
        Resultado.Text = m
    End Sub

    Private Sub testing_rb_CheckedChanged(sender As Object, e As EventArgs) Handles testing_rb.CheckedChanged
        url = "https://wswhomo.afip.gov.ar/wsfev1/service.asmx?WSDL"
    End Sub

    Private Sub produccion_rb_CheckedChanged(sender As Object, e As EventArgs) Handles produccion_rb.CheckedChanged
        url = "https://servicios1.afip.gov.ar/wsfev1/service.asmx?WSDL"
    End Sub

    Private Function getServicio() As Service
        Dim s As New Service
        s.Url = url
        Return s
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start(String.Format("https://www.cuitonline.com/detalle/{0}/", DocTX.Text))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim p = String.Format("{0}\codigo.bmp", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
        LinearWinForm2.SaveAsImage(p)
    End Sub

    Private Sub TiposComprobantesCMB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TiposComprobantesCMB.SelectedIndexChanged
        Dim cm As CbteTipo = TiposComprobantesCMB.SelectedItem
        Dim last = getServicio.FECompUltimoAutorizado(authRequest, 4, cm.Id)
        Dim ultimo_nro As Integer = last.CbteNro
        NroCbteTX.Text = ultimo_nro + 1
    End Sub
End Class