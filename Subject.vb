Public Class Subject

    Private observedQuantityValue As Double
    Public WriteOnly Property observedQuantity() As Double
        Set(ByVal value As Double)
            observedQuantityValue = value
            notify()
        End Set
    End Property

    Private observers As New List(Of Observer)

    Sub addObserver(observerToAdd As Observer)
        observers.Add(observerToAdd)
    End Sub

    Sub removeObserverAt(index As Integer)
        observers.Remove(observers(index))
    End Sub

    Private Sub notify()
        For Each obs As Observer In observers
            obs.update(observedQuantityValue)
        Next
    End Sub

End Class
