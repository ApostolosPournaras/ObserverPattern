Module Module1

    Sub Main()

        Dim sbj As New Subject()

        For i = 0 To 5
            sbj.observedQuantity = i
            sbj.addObserver(New Observer(i.ToString()))
            Console.WriteLine("--------------------")
        Next

        sbj.removeObserverAt(2)
        sbj.removeObserverAt(3)

        sbj.observedQuantity = 22.37
        Console.WriteLine("--------------------")

        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            System.Threading.Thread.Sleep(1000)
        Loop

    End Sub

End Module
