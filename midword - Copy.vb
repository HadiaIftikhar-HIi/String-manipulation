Module Module1

    Sub Main()
        Dim str1, midword, myword As String
        Dim SpPos1, spPos2 As Integer

        str1 = ""
        midword = ""
        myword = ""
        SpPos1 = 0
        spPos2 = 0

        Console.Write("enter string of 3 words:")
        str1 = Console.ReadLine

        SpPos1 = InStr(str1, " ")
        myword = Mid(str1, SpPos1 + 1, Len(str1))

        spPos2 = InStr(myword, " ")
        midword = Mid(myword, 1, spPos2 - 1)

        Console.WriteLine("mid word is" & midword)
        Console.ReadKey()
    End Sub

End Module
