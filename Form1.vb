Public Class Form1

    Private Sub btnMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMap.Click
        Dim intSeat(10, 4) As Integer
        Dim i As Integer = 0
        Dim strFormat As String

        strFormat = "{0, 10} {1,10} {2,10} {3,10}"

        For i = 1 To 9
            intSeat(0, 0) = 2
            'intSeat(0, 0) = intSeat((0 + 1), 0)

            ListBox1.Items.Add(intSeat(0, 0))
        Next
        'For i = 1 To 9
        '    ListBox1.Items.Add(String.Format(strFormat, intSeat(0, 0), intSeat(0, 1), intSeat(0, 2), intSeat(0, 3)))

        'Next

    End Sub

    Private Function strFormat(ByVal intSeat As Integer, ByVal intSeat1 As Integer) As Object
        Throw New NotImplementedException
    End Function

End Class
