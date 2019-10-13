Module Module1

    Sub Main()
        Dim str1, nextchar, alphastr As String
        Dim count As Integer
        Dim ispanagram As Boolean

        str1 = ""
        nextchar = ""
        alphastr = " abcdefghijklmnopqrstuvwxyz"
        count = 0
        ispanagram = True

        Console.Write("write string:")
        str1 = Console.ReadLine
        str1 = lcase(str1)
        For count = 1 To Len(alphastr)
            nextchar = Mid(alphastr, count, 1)
            If InStr(str1, nextchar) = 0 Then
                ispanagram = False


            End If

        Next
        If ispanagram = True Then
            Console.WriteLine(" it is a panagram ")
        Else
            Console.WriteLine("it is not a panagram ")

        End If
        Console.ReadKey()

    End Sub

End Module
