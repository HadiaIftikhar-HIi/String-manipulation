Module Module1

    Sub Main()
        Dim str1, str2, firstword, secword As String
        Dim sp As Integer
        str1 = ""
        str2 = ""
        firstword = ""
        secword = ""
        sp = 0
        Console.Write("enter first string: ")
        str1 = Console.ReadLine
        sp = InStr(str1, " ")
        firstword = Left(str1, sp - 1)
        Console.Write("enter second string: ")
        str2 = Console.ReadLine
        sp = InStr(str2, " ")
        secword = Right(str2, Len(str2) - sp)
        Console.WriteLine("final string is: " & firstword & " " & secword)

        Console.ReadKey()

    End Sub

End Module
