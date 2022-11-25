Module Module1

    Sub Main()
        Dim stri1, stri2, D As String
        Dim i, alphacount, A, B, numbercount As Integer

        Dim E As Char



        Console.Write("ENTER STRING: ")
        stri1 = Console.ReadLine



        stri2 = LCase(stri1)
        For i = 1 To Len(stri2)
            E = Mid(stri2, i, 1)
            A = InStr(E, "qwertyuiopasdfghjklzxcvbnm")
            If A <> 0 Then
                alphacount = alphacount + 1
            End If

        Next

        For i = 1 To Len(stri2)
            D = Mid(stri2, i, 1)
            B = InStr(D, "123456789")
            If B > 0 Then
                numbercount = numbercount + 1

            End If

        Next
        Console.WriteLine(" THIS IS THE NUMBER OF WORDS IN YOUR STRING " & alphacount)
        Console.WriteLine(" THIS IS THE NUMBER OF NUMBERS IN YOUR STRING " & Numbercount)
        Console.ReadKey()

    End Sub

End Module
