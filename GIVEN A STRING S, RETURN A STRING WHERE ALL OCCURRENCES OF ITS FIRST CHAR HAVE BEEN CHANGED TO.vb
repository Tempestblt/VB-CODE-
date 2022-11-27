Module Module1

    Sub Main()
        'GIVEN A STRING S, RETURN A STRING WHERE ALL OCCURRENCES OF ITS FIRST CHAR HAVE BEEN CHANGED TO

        Dim STRING1, STRING2 As String
        Dim i As Integer
        Dim A, B As Char


        Console.Write("PLEASE ENTER YOUR STRING: ")
        STRING1 = Console.ReadLine

        Const ALPHA = "*"

        STRING2 = " "

        STRING1 = UCase(STRING1)

        A = Mid(STRING1, 1, 1)

        STRING2 = STRING2 & A

        For i = 1 To Len(STRING1)
            B = Mid(STRING1, (i + 1), 1)

            If A = B Then
                STRING2 = STRING2 & ALPHA


            ElseIf B <> A Then
                STRING2 = STRING2 & B



            End If

            
        Next
        Console.Write("THE RESULTS ARE: " & STRING2)
        Console.ReadKey()
    End Sub
End Module