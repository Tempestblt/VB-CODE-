Module Module1

    Sub Main()
        'INPUT AN INT COUNT OF A NUMBER OF DONUTS

        Dim i As Integer

        Console.Write("PLEASE ENTER YOUR DONUTS COUNT: ")
        i = Console.ReadLine



            If i >= 10 Then
                Console.WriteLine("NUMBER OF DONUTS: MANY")

            ElseIf i < 10 Then
                Console.WriteLine("NUMBER OF DONUTS: " & i)


            End If

            Console.ReadKey()



    End Sub

End Module
