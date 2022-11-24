Module Module1

    Sub Main()
        Dim stri1, number As String
        Dim i, alphacount, Numbercount, A, B As Integer



        Dim character As Char



        Console.Write("ENTER STRING: ")
        stri1 = Console.ReadLine




        For i = 1 To Len(stri1)
            character = Mid(stri1, i, 1)
            If A =  (character, "qwertyuiopasdfghjklzxcvbnm") > 0 Then
                alphacount = alphacount + 1
            End If

        Next

        For i = 1 To Len(stri1)
            number = Mid(stri1 , i , 1)
            If B = InStr(number, "123456789") > 0 Then
                Numbercount = Numbercount + 1

            End If

        Next
        Console.WriteLine(" THIS IS THE NUMBER OF WORDS IN YOUR STRING " & alphacount)
        Console.WriteLine(" THIS IS THE NUMBER OF NUMBERS IN YOUR STRING " & Numbercount)
        Console.ReadKey()

    End Sub

End Module
