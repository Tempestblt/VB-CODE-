Module Module1

    Sub Main()
        Dim Fare, Totalfare As Decimal
        Dim Numofpass, stationfrom, stationto, Numberofstation As Integer

        stationfrom = 0
        stationto = 0
        Numofpass = 0
        Numberofstation = 0





        Console.Write("ENTER THE STATION OF DEPARTURE: ")
        stationfrom = Console.ReadLine()
        If stationfrom > 5 And stationfrom < 0 Then
            Console.Write("PLEASE ENTER VALID DEPARTURE TRAIN STATION: ")


        End If

        Console.Write("ENTER THE STATION OF ARRIVAL: ")
        stationto = Console.ReadLine()

        If stationto > 5 And stationto < 0 Then
            Console.Write("PLEASE ENTER VALID ARRIVAL TRAIN STATION: ")
        End If


        Console.Write("ENTER THE NUMBER OF PASSENGERS: ")
        Numofpass = Console.ReadLine()

        If stationfrom > stationto Then
            Numberofstation = stationfrom - stationto

        ElseIf stationto > stationfrom Then
            Numberofstation = stationto - stationfrom

        End If



        Totalfare = Numofpass * 2

        If Numofpass > 5 And Numofpass < 9 Then
            Totalfare = Totalfare - 8

        ElseIf Numofpass > 9 Then
            Totalfare = Totalfare - 15


        End If



        Fare = Totalfare / Numofpass

        Console.WriteLine("fare each person: " & Fare)
        Console.WriteLine("total fare is: " & Totalfare)














    End Sub

End Module
