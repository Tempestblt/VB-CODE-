Module Module1

    Sub Main()
        Dim stri1, stri2 As String
        Dim i, alphacount, A, B, numbercount As Integer

        Dim E, D As Char



        Console.Write("ENTER STRING: ")
        stri1 = Console.ReadLine



        stri2 = LCase(stri1)
        For i = 1 To Len(stri2)
            E = Mid(stri2, i, 1)
            A = InStr("qwertyuiopasdfghjklzxcvbnm", E)
            If A <> 0 Then
                alphacount = alphacount + 1
            End If

        Next

        For i = 1 To Len(stri2)
            D = Mid(stri2, i, 1)
            B = InStr("123456789", D)
            If B > 0 Then
                numbercount = numbercount + 1

            End If

        Next
        Console.WriteLine(" THIS IS THE NUMBER OF WORDS IN YOUR STRING " & alphacount)
        Console.WriteLine(" THIS IS THE NUMBER OF NUMBERS IN YOUR STRING " & numbercount)
        Console.ReadKey()

    End Sub

End Module
