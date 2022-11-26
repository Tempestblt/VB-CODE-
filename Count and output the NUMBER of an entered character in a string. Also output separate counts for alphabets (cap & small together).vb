Imports System

Module Program
    Sub Main(args As String())
        'Count and output the NUMBER of an entered character in a string. Also output separate counts for alphabets (cap & small together), digits and other characters in same entered string. 

        Dim string1 As String
        Dim i, COUNT, NUMCOUNT, SPECIALCHAR As Integer
        Dim A As Char

        Const ALPHA = "QWERTYUIOPASDFGHJKLZXCVBNM"

        Const NUM = "1234567890"

        Console.Write("PLEASE ENTER YOUR STRING: ")
        string1 = Console.ReadLine

        string1 = UCase(string1)

        For i = 1 To Len(string1)
            A = Mid(string1, i, 1)
            If InStr(ALPHA, A) > 0 Then
                COUNT = COUNT + 1


            ElseIf InStr(NUM, A) > 0 Then
                NUMCOUNT = NUMCOUNT + 1


            Else
                SPECIALCHAR = SPECIALCHAR + 1

            End If
        Next




        Console.WriteLine("THIS THE LETTERS IN YOUR STRING ARE: " & COUNT)
        Console.WriteLine("THE COUNT OF NUMBER IN YOUR STRING ARE: " & NUMCOUNT)
        Console.WriteLine("THE NUMBER OF SPECIAL CHARACTERS IN YOUR STRING ARE: " & SPECIALCHAR)
        Console.ReadKey()

    End Sub
End Module
