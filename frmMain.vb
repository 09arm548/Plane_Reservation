Public Class frmMain

    Private Sub btnMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMap.Click
        Dim strSeat(10, 4) As String
        Dim intSeat(10, 4) As Integer
        Dim i As Integer = 0
        'Dim n As Integer = 0
        Dim strFormat As String
        For n As Integer = 0 To 9
            strSeat(n, 0) = "OP"
            'ListBox1.Items.Add(strSeat(n, 0))
            n = n + 1
        Next

        'For i = 0 To 3
        '    strSeat(1, i) = "OPE"

        '    'ListBox1.Items.Add(strSeat(1, i))
        '    i = i + 1
        'Next

        strFormat = "{0, 10} {1,10} {2,10} {3,10}"
        'i = 3
        'intSeat(5, 2) = 34
        ListBox1.Items.Add(String.Format(strFormat, strSeat(0, 0), strSeat(0, 1), strSeat(1, 0), strSeat(3, 0)))
        'ListBox1.Items.Add(String.Format(strFormat, strSeat(1, 0), strSeat(1, 1), strSeat(1, 2), strSeat(1, 3)))
        'ListBox1.Items.Add(String.Format(strFormat, intSeat(2, 0), intSeat(2, 1), intSeat(2, 2), intSeat(2, 3)))
        'ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))
        'i = i + 1
        'ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))
        'i = i + 1
        'ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))
        'i = i + 1
        'ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))
        'i = i + 1
        'ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))
        'i = i + 1
        'ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))
        'i = i + 1
        'ListBox1.Items.Add(String.Format(strFormat, intSeat(i, 0), intSeat(i, 1), intSeat(i, 2), intSeat(i, 3)))



    End Sub



End Class
