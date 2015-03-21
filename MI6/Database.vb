Module Database
    Dim Code As Integer = 0

    Function Encrypt(ByVal message As String, ByVal code As Integer) As String
        Dim ReturnMessage As String = ""

        For i = 0 To message.Length - 1
            ReturnMessage += Convert.ToString(Convert.ToInt32(message(i)) + code)
            ReturnMessage += " "
        Next

        Return ReturnMessage
    End Function

    Function Decrypt(ByVal message As String, ByVal code As Integer) As String
        Dim ReturnMessage As String = ""
        Dim asci As String = ""

        For i = 0 To message.Length - 1
            If (Not message(i) = " ") Then
                asci += message(i)
            Else
                ReturnMessage += Convert.ToChar(Convert.ToInt32(asci - code))
                asci = ""
            End If
        Next

        Return ReturnMessage
    End Function

    Function KeyCode(ByVal Agent As String) As Integer
        Dim Key As Integer = 0

        If Agent = "James Bond" Then
            Key = 7
        ElseIf Agent = "Q" Then
            Key = 9
        ElseIf Agent = "Moneypenny" Then
            Key = 6
        End If

        Return Key
    End Function

End Module
