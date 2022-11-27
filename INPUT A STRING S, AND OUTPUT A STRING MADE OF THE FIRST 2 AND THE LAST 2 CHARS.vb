Module Module1

    Sub Main()
        'INPUT A STRING S, AND OUTPUT A STRING MADE OF THE FIRST 2 AND THE LAST 2 CHARS


        Dim Str1, Str2, STRI4 As String
        Dim Char1, A, B, C, D As Char
        Dim i, x As Integer


        Str1 = ""
        Str2 = ""
        Char1 = ""
        i = 0

       

        Console.Write("Enter string to process: ")
        Str1 = Console.ReadLine

        If Len(Str1) <= 2 Then
            Console.Write(" THE RESULT IS: " & Str1)
        End If


        x = InStr(Str1, " ")

        A = Mid(Str1, 1, 1)
        B = Mid(Str1, 2, 1)


        For i = (x - 1) To 1 Step -1
            Char1 = Mid(Str1, i, 1)
            Str2 = Str2 & Char1
        Next

        D = Mid(Str2, 1, 1)
        C = Mid(Str2, 2, 1)

        STRI4 = A & B & C & D

        Console.Write("THE RESULT IS: " & STRI4)
        Console.ReadKey()

    End Sub

End Module
