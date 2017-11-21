Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Xml
Imports System.Net
Imports System.Security
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Pkcs
Imports System.Security.Cryptography.X509Certificates
Imports System.IO
Imports System.Runtime.InteropServices
Public Class LoginClass
    Private Shared _globalId As UInt32 = 0

    Property serv As String
    Property url As String
    Private cert_path As String
    Private clave As SecureString

    Private XmlLoginTicketRequest As XmlDocument
    Private XmlLoginTicketResponse As XmlDocument
    Private uniqueId As UInt32
    Property GenerationTime As DateTime
    Property ExpirationTime As DateTime
    ReadOnly Property Logeado As Boolean
        Get
            Return Not Token = ""
        End Get
    End Property

    Public Property certificado As X509Certificate2

    Property XDocRequest As XDocument
    Property XDocResponse As XDocument

    Public ReadOnly Property Token As String
    Public ReadOnly Property Sign As String

    Public Sub New(serv As String, url As String, cert_path As String, clave As String)
        Me.serv = serv
        Me.url = url
        Me.cert_path = cert_path
        Me.clave = New SecureString
        For Each character As Char In clave
            Me.clave.AppendChar(character)
        Next
        Me.clave.MakeReadOnly()
    End Sub



    Public Sub hacerLogin()
        Dim cmsFirmadoBase64 As String
        Dim loginTicketResponse As String

        Dim uniqueIdNode As XmlNode
        Dim generationTimeNode As XmlNode
        Dim ExpirationTimeNode As XmlNode
        Dim ServiceNode As XmlNode

        Try
            Me._globalId += 1

            'Preparo el XML Request
            XmlLoginTicketRequest = New XmlDocument
            XMLLoader.loadTemplate(XmlLoginTicketRequest, "LoginTemplate")

            uniqueIdNode = XmlLoginTicketRequest.SelectSingleNode("//uniqueId")
            generationTimeNode = XmlLoginTicketRequest.SelectSingleNode("//generationTime")
            ExpirationTimeNode = XmlLoginTicketRequest.SelectSingleNode("//expirationTime")
            ServiceNode = XmlLoginTicketRequest.SelectSingleNode("//service")
            generationTimeNode.InnerText = DateTime.Now.AddMinutes(-10).ToString("s")
            ExpirationTimeNode.InnerText = DateTime.Now.AddMinutes(+10).ToString("s")
            uniqueIdNode.InnerText = CStr(_globalId)
            ServiceNode.InnerText = serv

            'Obtenemos el Cert
            certificado = New X509Certificate2
            If clave.IsReadOnly Then
                certificado.Import(File.ReadAllBytes(cert_path), clave, X509KeyStorageFlags.PersistKeySet)
            Else
                certificado.Import(File.ReadAllBytes(cert_path))
            End If

            Dim msgBytes As Byte() = Encoding.UTF8.GetBytes(XmlLoginTicketRequest.OuterXml)

            'Firmamos
            Dim infoContenido As New ContentInfo(msgBytes)
            Dim cmsFirmado As New SignedCms(infoContenido)

            Dim cmsFirmante As New CmsSigner(certificado)
            cmsFirmante.IncludeOption = X509IncludeOption.EndCertOnly

            cmsFirmado.ComputeSignature(cmsFirmante)

            cmsFirmadoBase64 = Convert.ToBase64String(cmsFirmado.Encode())

            'Hago el login
            Dim servicio As New WSAA.LoginCMSService
            servicio.Url = url

            loginTicketResponse = servicio.loginCms(cmsFirmadoBase64)

            'Analizamos la respuesta
            XmlLoginTicketResponse = New XmlDocument
            XmlLoginTicketResponse.LoadXml(loginTicketResponse)

            _Token = XmlLoginTicketResponse.SelectSingleNode("//token").InnerText
            _Sign = XmlLoginTicketResponse.SelectSingleNode("//sign").InnerText

            Dim exStr = XmlLoginTicketResponse.SelectSingleNode("//expirationTime").InnerText
            Dim genStr = XmlLoginTicketResponse.SelectSingleNode("//generationTime").InnerText
            ExpirationTime = DateTime.Parse(exStr)
            GenerationTime = DateTime.Parse(genStr)

            XDocRequest = XDocument.Parse(XmlLoginTicketRequest.OuterXml)
            XDocResponse = XDocument.Parse(XmlLoginTicketResponse.OuterXml)

            MsgBox("Exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class

Public Class XMLLoader
    Public Shared Sub load(doc As XmlDocument, file As String)
        doc.Load(Path.GetFullPath(Application.StartupPath & "\" & file & ".xml"))
    End Sub
    Public Shared Sub loadTemplate(doc As XmlDocument, file As String)
        load(doc, "Templates\" & file)
    End Sub

End Class
