Module Module1

    Sub Main()
        Dim str1, str2, nextchar As String
        Dim count As Integer
        str1 = ""
        str2 = ""
        nextchar = ""
        count = 0
        Console.Write("enter string:")
        str1 = Console.ReadLine
        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            str2 = str2 + nextchar
            If nextchar = " " Then
                Console.WriteLine(str2)
                str2 = ""

            End If


        Next
        Console.WriteLine(str2)
        Console.ReadKey()
    End Sub

End Module
