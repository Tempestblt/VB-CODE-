Imports System

Module Program
    Sub Main(args As String())
        'FIND THE CHARACTER THAT APPEARS MOST NUMBER OF TIMES IN AN ENTERED STRING AND OUTPUT IT.


        Dim STRING1, STRING2 As String
        Dim I, B, COUNT, HIGHEST As Integer
        Dim A, C, F As Char

        HIGHEST = 0
        Console.Write("PLEASE ENTER YOUR STRING: ")
        STRING1 = Console.ReadLine






        For I = 1 To Len(STRING1)
            A = Mid(STRING1, I, 1)

            COUNT = 0

            For B = 1 To Len(STRING1)
                C = Mid(STRING1, B, 1)
                If A = C Then
                    COUNT = COUNT + 1
                End If

            Next

            If COUNT > HIGHEST Then
                HIGHEST = COUNT
                F = A

            End If


        Next
        Console.WriteLine(F & " IS THE HIGHEST OCCURED CHARACTER AND IT OCCURED " & HIGHEST & " NUMBER OF TIMES")
        Console.ReadKey()
    End Sub
End Module
