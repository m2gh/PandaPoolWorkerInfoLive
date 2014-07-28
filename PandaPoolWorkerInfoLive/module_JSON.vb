Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module module_JSON

    Public Function JSON_GET(url As String)
        frmMain.UseWaitCursor = True
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Try

            'url = "https://api.mintpal.com/v1/market/stats/PND/LTC"

            request = DirectCast(WebRequest.Create(url), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()
            'Console.WriteLine(rawresp)
            frmMain.UseWaitCursor = False
            Return rawresp

        Finally
            If Not response Is Nothing Then response.Close()
            Console.WriteLine("")
        End Try
    End Function

End Module