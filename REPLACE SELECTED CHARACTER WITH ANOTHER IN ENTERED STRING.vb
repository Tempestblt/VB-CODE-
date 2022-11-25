Module Module1

    Sub Main()

        'REPLACE SELECTED CHARACTER WITH ANOTHER IN ENTERED STRING.

        Dim string1, string2 As String
        Dim character, REPLACECHARACTER, A As Char
        Dim i As Integer

        Console.Write("PLEASE ENTER YOUR STRING: ")
        string1 = Console.ReadLine

        Console.Write("PLEASE ENTER THE CHARACTER TO BE REPLACED: ")
        character = Console.ReadLine

        Console.Write("PLEASE ENTER THE CHARACTER TO BE REPLACED WITH: ")
        REPLACECHARACTER = Console.ReadLine


        string1 = UCase(string1)

        For i = 1 To Len(string1)
            A = Mid(string1, i, 1)
            If A <> character Then
                string2 = string2 & A

            ElseIf A = character Then
                string2 = string2 & REPLACECHARACTER
            End If

        Next
        Console.Write("THE FINAL PRODUCT OF STRING IS: " & string2)
        Console.ReadKey()








    End Sub

End Module
