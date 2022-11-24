Module Module1

    Sub Main()
        Dim stri1 As String
        Dim space, secspace As Integer
        Dim FW, SW, TW As Char





        Console.Write("PLEASE ENTER THE STRING TO BE ABBREVIATED: ")
        stri1 = Console.ReadLine()

        FW = Left(stri1, 1)

        space = InStr(stri1, " ")
        SW = Mid(stri1, space + 1, 1)

        secspace = InStr(space + 1, stri1, " ")
        TW = Mid(stri1, secspace + 1, 1)

        Console.Write(" THE ABBREVIATED VERSION IS: " & FW & SW & TW)

        Console.ReadKey()

    End Sub

End Module
