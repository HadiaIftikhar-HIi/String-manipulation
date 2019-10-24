Module Module1

    Sub Main()
        Dim str1, nextchar As String


        Dim count, value, denarynum As Integer
        Dim validBinaryString As Boolean
        str1 = ""
        nextchar = ""
        count = 0
        value = 0
        denarynum = 0


        validBinaryString = True
        Console.Write("Enter Binary number:")
        str1 = Console.ReadLine
        If Len(str1) > 0 And Len(str1) <= 8 Then
            validBinaryString = True
        Else
            validBinaryString = False
        End If

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If nextchar = "0" Or nextchar = "1" Then
                validBinaryString = True
            Else
                validBinaryString = False
            End If

        Next
        If validBinaryString = False Then
            Console.WriteLine("not a valid binary number")
        End If

    If validBinaryString = True Then
    For count = Len(str1) To 1 Step -1



                nextchar = Mid(str1, count, 1)
        value = nextchar * (2 ^ (Len(str1)-count))
        denarynum = denarynum + value
    Next   
            Console.WriteLine(str1 & "=" & denarynum)
    EndIf
            Console.ReadKey()
    End Sub

End Module
