Public Class IniFile

    Private Declare Ansi Function GetPrivateProfileStringA Lib "kernel32.dll" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As System.Text.StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Ansi Function GetPrivateProfileSectionNamesA Lib "kernel32.dll" (ByVal lpszReturnBuffer() As Byte, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Ansi Function WritePrivateProfileStringA Lib "kernel32.dll" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Private Declare Ansi Function WritePrivateProfileSectionA Lib "kernel32.dll" (ByVal lpAppName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Private m_Filename As String
    Private m_Section As String
    Private Const MAX_ENTRY As Integer = 32767

    Public Sub New(ByVal file As String)
        Filename = file
    End Sub

    Public Property Filename() As String
        Get
            Return m_Filename
        End Get
        Set(ByVal Value As String)
            m_Filename = Value
        End Set
    End Property

    Public Property Section() As String
        Get
            Return m_Section
        End Get
        Set(ByVal Value As String)
            m_Section = Value
        End Set
    End Property

    Public Function WriteString(ByVal section As String, ByVal key As String, ByVal value As String) As Boolean
        Return (WritePrivateProfileStringA(section, key, value, Filename) <> 0)
    End Function

    Public Function WriteString(ByVal key As String, ByVal value As String) As Boolean
        Return (WritePrivateProfileStringA(Section, key, value, Filename) <> 0)
    End Function

    Public Function ReadString(ByVal section As String, ByVal key As String, ByVal defaultValue As String) As String
        Dim buffer As New System.Text.StringBuilder(MAX_ENTRY)
        GetPrivateProfileStringA(section, key, defaultValue, buffer, buffer.Capacity, Filename)
        Return buffer.ToString
    End Function

    Public Function ReadString(ByVal key As String, ByVal defaultValue As String) As String
        Dim buffer As New System.Text.StringBuilder(MAX_ENTRY)
        GetPrivateProfileStringA(Section, key, defaultValue, buffer, buffer.Capacity, Filename)
        Return buffer.ToString
    End Function

    Public Function DeleteKey(ByVal section As String, ByVal key As String) As Boolean
        Return (WritePrivateProfileStringA(section, key, Nothing, Filename) <> 0)
    End Function

    Public Function DeleteKey(ByVal key As String) As Boolean
        Return (WritePrivateProfileStringA(Section, key, Nothing, Filename) <> 0)
    End Function

    Public Function DeleteSection(ByVal section As String) As Boolean
        Return (WritePrivateProfileSectionA(section, Nothing, Filename) <> 0)
    End Function

    Public Function GetSectionNames() As ArrayList
        Try
            Dim buffer(MAX_ENTRY) As Byte
            GetPrivateProfileSectionNamesA(buffer, MAX_ENTRY, Filename)
            Dim parts() As String = System.Text.Encoding.ASCII.GetString(buffer).Trim(ControlChars.NullChar).Split(ControlChars.NullChar)
            Return New ArrayList(parts)
        Catch
        End Try
        Return Nothing
    End Function

End Class