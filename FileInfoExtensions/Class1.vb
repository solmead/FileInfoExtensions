Imports System.Runtime.CompilerServices
Imports System.IO

Public Class Class1

End Class

Public Module Extensions

    Public VideoList() As String = {"FLV", "MOD", "AVI", "MPG", "MPEG", "MOV", "WMV", "VOB", "VRO", "MTS", "QT", "SWF", "MP4", "M4V", "OGV"}
    Public ImageList() As String = {"JPG", "JPEG", "PNG", "BMP", "TGA", "GIF", "ICO"}
    Public AudioList() As String = {"MP3", "WAV", "OGG", "AAC", "WMA", "M4A"}

    <Extension()> _
    Public Function FileNameWithoutExtension(ByVal File As FileInfo) As String
        Return Left(File.Name, Len(File.Name) - (Len(File.Extension)))
    End Function
    <Extension()> _
    Public Function IsImage(file As FileInfo) As Boolean
        Dim ext = file.Extension.Substring(1)
        Return ImageList.Contains(ext.ToUpper)
    End Function
    <Extension()> _
    Public Function IsVideo(file As FileInfo) As Boolean
        Dim ext = file.Extension.Substring(1)
        Return VideoList.Contains(ext.ToUpper)
    End Function
    <Extension()> _
    Public Function IsAudio(file As FileInfo) As Boolean
        Dim ext = file.Extension.Substring(1)
        Return AudioList.Contains(ext.ToUpper)
    End Function
    <Extension()> _
    Public Function ContentType(ByVal File As System.IO.FileInfo) As String
        Dim Extension As String = File.Extension.ToUpper.Substring(1)


        Dim mContentType = "application/octet-stream"
        If VideoList.Contains(Extension) Then
            mContentType = "video/mpeg"
        End If
        Select Case Extension
            Case "JPG"
                mContentType = "image/jpeg"
            Case "GIF"
                mContentType = "image/gif"
            Case "PNG"
                mContentType = "image/png"
            Case "ICO"
                mContentType = "image/ico"
            Case "BMP"
                mContentType = "image/bmp"
            Case "MP3"
                mContentType = "audio/mp3"
            Case "WAV"
                mContentType = "audio/wav"
            Case "M4A"
                mContentType = "audio/x-m4a"
            Case "MP4"
                mContentType = "video/mp4"
            Case "M4V"
                mContentType = "video/x-m4v"
            Case "MOV"
                mContentType = "video/quicktime"
            Case "PDF"
                mContentType = "application/pdf"
            Case "OGV"
                mContentType = "video/ogg"
            Case "WEBM"
                mContentType = "video/webm"
        End Select

        Return mContentType
    End Function
End Module
