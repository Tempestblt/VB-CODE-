Module Module1

    Sub Main()
        'Find if the input string has all the alphabets; capital or small alike.


        Dim string1 As String
        Dim A As Char
        Dim i, COUNT As Integer


        Console.Write("PLEASE ENTER STRING: ")
        string1 = Console.ReadLine

        For i = 1 To Len(string1)
            A = Mid(string1, i, 1)
            If InStr("QWERTYUIOPASDFGHJKLZXCVBNM", A) > 0 Then
                COUNT = COUNT + 1

            ElseIf InStr("QWERTYUIOPASDFGHJKLZXCVBNM", A) = 0 Then
                COUNT = COUNT + 0

            End If

        Next
        If COUNT > 0 Then
            Console.WriteLine("ALL THE ALPHABETS ARE IN CAPITAL")
        ElseIf COUNT = 0 Then
            Console.WriteLine("ALL THE ALPHABETS ARE  SMALL")
        End If
      
        Console.ReadKey()
    End Sub

End Module
