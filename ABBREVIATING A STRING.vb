Module Module1

    Sub Main()
        Dim stri1, stri2 As String
        Dim space, numbofwords, secspace, Thirspace As Integer
        Dim FW, SW, TW, FFW As Char





        Console.Write("PLEASE ENTER THE STRING TO BE ABBREVIATED: ")
        stri1 = Console.ReadLine()
        Console.Write("PLEASE ENTER THE NUMBER OF WORDS IN YOUR STRING: ")
        numbofwords = Console.ReadLine

        stri2 = UCase(stri1)
        If numbofwords = 1 Then
            FW = Left(stri2, 1)

        ElseIf numbofwords = 2 Then
            FW = Left(stri2, 1)

            space = InStr(stri2, " ")
            SW = Mid(stri2, space + 1, 1)

        ElseIf numbofwords = 3 Then
            FW = Left(stri2, 1)

            space = InStr(stri2, " ")
            SW = Mid(stri2, space + 1, 1)

            secspace = InStr(space + 1, stri2, " ")
            TW = Mid(stri2, secspace + 1, 1)

        ElseIf numbofwords = 4 Then
            FW = Left(stri2, 1)

            space = InStr(stri2, " ")
            SW = Mid(stri2, space + 1, 1)

            secspace = InStr(space + 1, stri2, " ")
            TW = Mid(stri2, secspace + 1, 1)

            Thirspace = InStr(secspace + 1, stri2, " ")
            FFW = Mid(stri2, Thirspace + 1, 1)

        ElseIf numbofwords > 5 Then
            Console.Write("PLEASE ENTER YOU CORRECT NAME, NO PERSON HAVE 5 WORDS IN THEIR NAME")
        End If


        Console.Write(" THE ABBREVIATED VERSION IS: " & FW & SW & TW & FFW)

        Console.ReadKey()
    End Sub

End Module
