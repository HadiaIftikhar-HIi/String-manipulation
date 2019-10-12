Module Module1

    Sub Main()
        Dim str1, nextchar, str2 As String
        Dim count As Integer
        Dim isanagram As Boolean
        str1 = ""
        str2 = ""
        nextchar = ""
        count = 0
        isanagram = True
        Console.Write("enter string1:")
        str1 = Console.ReadLine
        str1 = LCase(str1)
        Console.Write("enter string2:")
        str2 = Console.ReadLine
        str2 = LCase(str2)
        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If InStr(str2, nextchar) = 0 Then
                isanagram = False

            End If
        Next
        If isanagram = True Then
            Console.WriteLine("string1 and string2 are anagram")
        Else
            Console.WriteLine("string1 and string2 are not anagrams")
        End If
        Console.ReadKey()
    End Sub

End Module
