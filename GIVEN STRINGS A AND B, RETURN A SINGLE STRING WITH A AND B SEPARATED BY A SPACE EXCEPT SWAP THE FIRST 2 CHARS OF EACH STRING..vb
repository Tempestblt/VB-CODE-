Module Module1

    Sub Main()
        'GIVEN STRINGS A AND B, RETURN A SINGLE STRING WITH A AND B SEPARATED BY A SPACE '<A> <B>', EXCEPT SWAP THE FIRST 2 CHARS OF EACH STRING.

        Dim string1, string2, string3, STRING4 As String
        Dim i, X As Integer

        Dim A, B, C, D, E, F As Char

        string3 = " "
        STRING4 = " "


        Console.Write("PLEASE ENTER STRING ONE: ")
        string1 = Console.ReadLine
        Console.Write("PLEASE ENTER STRING TWO: ")
        string2 = Console.ReadLine

        A = Mid(string1, 1, 1)
        B = Mid(string1, 2, 1)
        C = Mid(string2, 1, 1)
        D = Mid(string2, 2, 1)

        string3 = string3 & C & D
        STRING4 = STRING4 & A & B

        For i = 3 To Len(string1)
            E = Mid(string1, i, 1)
            string3 = string3 & E

        Next

        For X = 3 To Len(string2)
            F = Mid(string2, X, 1)
            STRING4 = STRING4 & F
        Next

        Console.Write("THE RESULTS ARE: " & string3 & STRING4)
        Console.ReadKey()

    End Sub

End Module
