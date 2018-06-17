Public Class Observer
    Implements IObserve

    Private name As String

    Sub New(name As String)
        Me.name = name
    End Sub

    Public Sub update(value As Double) Implements IObserve.update
        Console.WriteLine("Observer '" & Me.name & "'. value is: " & value)
    End Sub

End Class
