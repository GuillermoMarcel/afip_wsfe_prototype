Public Class Form1
    Private Sub Buscar_btn_Click(sender As Object, e As EventArgs) Handles Buscar_btn.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            CertificadoTX.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private l As LoginClass
    Private url As String = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms"
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        l = New LoginClass(ServicioTX.Text, url, CertificadoTX.Text, ClaveTX.Text)
        l.hacerLogin()
        guardar_params()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_params()
    End Sub
    Private Sub guardar_params()
        My.Settings.def_cert = CertificadoTX.Text
        My.Settings.def_pass = ClaveTX.Text
        My.Settings.def_serv = ServicioTX.Text
        My.Settings.def_url = url
        My.Settings.Save()
    End Sub

    Private Sub cargar_params()
        My.Settings.Reload()
        CertificadoTX.Text = My.Settings.def_cert
        ClaveTX.Text = My.Settings.def_pass
        ServicioTX.Text = My.Settings.def_serv
        url = My.Settings.def_url
    End Sub

    Private Sub VerTokenBtn_Click(sender As Object, e As EventArgs) Handles VerTokenBtn.Click
        LargeText.mostrarMensaje(l.Token)
    End Sub

    Private Sub VerSignBtn_Click(sender As Object, e As EventArgs) Handles VerSignBtn.Click
        LargeText.mostrarMensaje(l.Sign)
    End Sub

    Private Sub VerFullRequestBtn_Click(sender As Object, e As EventArgs) Handles VerFullRequestBtn.Click
        If l.XDocRequest Is Nothing Then Return
        LargeText.mostrarMensaje(l.XDocRequest.ToString)
    End Sub

    Private Sub VerFullResponseBtn_Click(sender As Object, e As EventArgs) Handles VerFullResponseBtn.Click
        If l.XDocResponse Is Nothing Then Return
        LargeText.mostrarMensaje(l.XDocResponse.ToString)
    End Sub

    Private Sub WSFE_BTN_Click(sender As Object, e As EventArgs) Handles WSFE_BTN.Click
        FacturaForm.Login = l
        FacturaForm.Show()
    End Sub

    Private Sub testing_rb_CheckedChanged(sender As Object, e As EventArgs) Handles testing_rb.CheckedChanged
        url = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms"
    End Sub

    Private Sub produccion_rb_CheckedChanged(sender As Object, e As EventArgs) Handles produccion_rb.CheckedChanged
        url = "https://wsaa.afip.gov.ar/ws/services/LoginCms?wsdl"
    End Sub

    Private Sub TestServerBTN_Click(sender As Object, e As EventArgs) Handles TestServerBTN.Click
        Dim s As New WSFEHOMO.Service
        Dim f As WSFEHOMO.DummyResponse = s.FEDummy
        MsgBox(String.Format("{0} - {1} - {2}", f.AppServer, f.AuthServer, f.DbServer))
    End Sub

    Private Sub FactObjTest_Click(sender As Object, e As EventArgs) Handles FactObjTest.Click
        Dim f As New FacturaPrueba
        f.Show()
    End Sub


End Class
