Module Module1

    Sub Main()

        'ANAGRAM

        Dim string1, string2 As String
        Dim i, stricount, NUMCOUNT As Integer
        Dim A As Char

        Console.Write("PLEASE ENTER YOUR FIRST STRING: ")
        string1 = Console.ReadLine

        Console.Write("PLEASE ENTER YOUR SECOND STRING: ")
        string2 = Console.ReadLine


        string1 = UCase(string1)
        string2 = UCase(string2)

        stricount = stricount + Len(string1)


        If Len(string1) = Len(string2) Then
            For i = 1 To Len(string1)
                A = Mid(string2, i, 1)
                If InStr(string1, A) > 0 Then
                    NUMCOUNT = NUMCOUNT + 1
                End If

            Next
        ElseIf Len(string1) <> Len(string2) Then
            Console.WriteLine("ANAGRAM FOUND FALSE")


        End If

        If NUMCOUNT = Len(string1) Then
            Console.WriteLine("ANAGRAM FOUND TRUE")

        ElseIf NUMCOUNT <> Len(string2) Then
            Console.WriteLine("ANAGRAM FOUND FALSE")
        End If



        Console.ReadKey()






    End Sub

End Module
