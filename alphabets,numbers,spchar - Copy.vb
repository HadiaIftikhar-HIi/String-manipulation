Module Module1

    Sub Main()
        Dim str1, nextchar As String
        Dim count, alphabets, numbers, specialchars As Integer
        count = 0
        str1 = ""
        nextchar = ""
        alphabets = 0
        numbers = 0
        specialchars = 0
        Console.Write("enter string:")
        str1 = Console.ReadLine
        For count = 1 To Len(str1)
            nextchar = LCase(Mid(str1, count, 1))
            If nextchar >= "a" And nextchar <= "z" Then
                alphabets = alphabets + 1
            Else
                If nextchar >= "0" And nextchar <= "9" Then
                    numbers = numbers + 1
                Else
                    specialchars = specialchars + 1
                End If
            End If

        Next
        Console.WriteLine("number of alphabets is:" & alphabets)
        Console.WriteLine("total numbers are :" & numbers)
        Console.WriteLine("number of specialcharacters is:" & specialchars)
        Console.ReadKey()
    End Sub

End Module
