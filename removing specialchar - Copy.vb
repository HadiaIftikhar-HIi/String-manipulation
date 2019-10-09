Module Module1

    Sub Main()
        Dim str1, str2, nextchar, spchar As String
        Dim count As Integer
        nextchar = ""
        str1 = ""
        str2 = ""
        count = 0
        spchar = ""
        Console.Write("enter string:")
        str1 = Console.ReadLine
        Console.Write("enter character to remove:")
        spchar = Console.ReadLine
        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If nextchar <> spchar Then
                str2 = str2 + nextchar

            End If
        Next
        Console.WriteLine("the final string is:" & str2)
        Console.ReadKey()

    End Sub

End Module
