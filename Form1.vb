Public Class Form1

    Private Sub btnMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMap.Click
        Dim intSeat(10, 4) As Integer
        Dim i As Integer = 0
        Dim n As Integer = 0
        Dim strFormat As String

        strFormat = "{0, 10} {1,10} {2,10} {3,10}"
        i = 3
        intSeat(5, 2) = 34
        ListBox1.Items.Add(String.Format(strFormat, intSeat(0, 0), intSeat(0, 1), intSeat(0, 2), intSeat(0, 3)))
        ListBox1.Items.Add(String.Format(strFormat, intSeat(1, 0), intSeat(1, 1), intSeat(1, 2), intSeat(1, 3)))
        ListBox1.Items.Add(String.Format(strFormat, intSeat(2, 0), intSeat(2, 1), intSeat(2, 2), intSeat(2, 3)))
        ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))
        i = i + 1
        ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))
        i = i + 1
        ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))
        i = i + 1
        ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))
        i = i + 1
        ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))
        i = i + 1
        ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))
        i = i + 1
        ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))



    End Sub


    
End Class
