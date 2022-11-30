Module Module1

    Sub Main()
        'VERBING

        Dim str1, str2, str3, str4, str5, str6 As String
        Dim i, x, z, O As Integer
        Dim A, B, D As Char

        str3 = " "
        str4 = " "
        str5 = " "
        str6 = " "

        Const ALPHA = "ING"
        Const ALPHA1 = " "

        Console.Write("PLEASE ENTER YOUR  STRING: ")
        str1 = Console.ReadLine

        str1 = UCase(str1)

        If Len(str1) < 3 Then
            Console.WriteLine("THE RESULTS  ARE: " & str1)

        End If

        If Len(str1) = 3 Then
            str2 = str1 & ALPHA
            Console.WriteLine("THE RESULT  ARE: " & str2)
        End If


        If Len(str1) > 3 Then
            For i = Len(str1) To 1 Step -1
                A = Mid(str1, i, 1)
                If A <> ALPHA1 Then
                    str3 = str3 & A
                End If


            Next

            For x = 3 To Len(str3)
                B = Mid(str3, x, 1)
                If InStr("ING", B) > 0 Then
                    z = z + 1
                End If
            Next

            If z < 3 Then
                Console.WriteLine("THE RESULTS  ARE: " & str1)

            End If
        End If



        str4 = str4 & "LY"

        If z = 3 Then


            For O = Len(str3) To 1 Step -1
                D = Mid(str3, O, 1)
                str5 = str5 & D

            Next

            str5 = str5 & "LY"

            Console.WriteLine("THE RESULTS  ARE: " & str5)

        End If






        Console.ReadKey()
    End Sub

End Module
