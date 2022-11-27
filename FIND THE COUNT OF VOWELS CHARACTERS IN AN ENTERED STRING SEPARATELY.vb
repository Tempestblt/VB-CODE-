Module Module1

    Sub Main()

        'FIND THE COUNT OF VOWELS CHARACTERS IN AN ENTERED STRING SEPARATELY



        Dim string1 As String
        Dim Z As Integer
        Dim X As Char
        Dim counta, countE, counti, countO, countU As Integer
        Dim TOTALVOWELS As Integer

        Console.Write("PLEASE ENTER STRING: ")
        string1 = Console.ReadLine

        string1 = UCase(string1)


        Const A = "A"
        Const E = "E"
        Const I = "I"
        Const O = "O"
        Const U = "U"


        For Z = 1 To Len(string1)
            X = Mid(string1, Z, 1)
            If InStr(X, A) > 0 Then
                counta = counta + 1

            ElseIf InStr(X, E) > 0 Then
                countE = countE + 1


            ElseIf InStr(X, I) > 0 Then
                counti = counti + 1


            ElseIf InStr(X, O) > 0 Then
                countO = countO + 1


            ElseIf InStr(X, U) > 0 Then
                countU = countU + 1
            End If


            TOTALVOWELS = counta + countE + counti + countO + countU
        Next
        Console.WriteLine("THE NUMBER OF As IN YOUR STRING ARE: " & counta)
        Console.WriteLine("THE NUMBER OF Es IN YOUR STRING ARE: " & countE)
        Console.WriteLine("THE NUMBER OF Is IN YOUR STRING ARE: " & counti)
        Console.WriteLine("THE NUMBER OF Os IN YOUR STRING ARE: " & countO)
        Console.WriteLine("THE NUMBER OF Us IN YOUR STRING ARE: " & countU)
        Console.WriteLine("THE TOTAL NUMBER OF VOWELS IN YOUR STRING ARE: " & TOTALVOWELS)

        Console.ReadKey()

    End Sub

End Module
