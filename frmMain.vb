Public Class frmMain
    Dim strSeat(9, 3) As String
    Private Sub btnMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMap.Click

        'Dim i As Integer
        Dim n As Integer
        Dim c As Integer

        'build array
        For i As Integer = 0 To 9
            strSeat(n, 0) = c
            n = n + 1
            c = c + 1
        Next
        n = 0
        For i As Integer = 0 To 9
            strSeat(n, 1) = c
            n = n + 1
            c = c + 1
        Next
        n = 0
        For i As Integer = 0 To 9
            strSeat(n, 2) = c
            n = n + 1
            c = c + 1
        Next
        n = 0
        For i As Integer = 0 To 9
            strSeat(n, 3) = c
            n = n + 1
            c = c + 1
        Next

        'shows map
        lstMap.Items.Clear()
        Select Case txtSeatNum.Text
            Case 0 To 9
                assignseat()
        End Select
        For i As Integer = 0 To 9
            lstMap.Items.Add(strSeat(i, 0) & "          " & strSeat(i, 1) & "                 " & strSeat(i, 2) & "           " & strSeat(i, 3))
        Next


    End Sub

    Sub assignSeat()
        If txtSeatNum.Text = 0 Then
            strSeat(0, 0) = txtName.Text
        ElseIf txtSeatNum.Text = 1 Then
            strSeat(1, 0) = txtName.Text
        ElseIf txtSeatNum.Text = 2 Then
            strSeat(2, 0) = txtName.Text
        ElseIf txtSeatNum.Text = 3 Then
            strSeat(3, 0) = txtName.Text
        ElseIf txtSeatNum.Text = 4 Then
            strSeat(4, 0) = txtName.Text
        ElseIf txtSeatNum.Text = 5 Then
            strSeat(5, 0) = txtName.Text
        ElseIf txtSeatNum.Text = 6 Then
            strSeat(6, 0) = txtName.Text
        ElseIf txtSeatNum.Text = 7 Then
            strSeat(7, 0) = txtName.Text
        ElseIf txtSeatNum.Text = 8 Then
            strSeat(8, 0) = txtName.Text
        ElseIf txtSeatNum.Text = 9 Then
            strSeat(9, 0) = txtName.Text
        End If
    End Sub

    Sub assignSeat1()
        If txtSeatNum.Text = 0 Then
            strSeat(0, 1) = txtName.Text
        ElseIf txtSeatNum.Text = 1 Then
            strSeat(1, 1) = txtName.Text
        ElseIf txtSeatNum.Text = 2 Then
            strSeat(2, 1) = txtName.Text
        ElseIf txtSeatNum.Text = 3 Then
            strSeat(3, 1) = txtName.Text
        ElseIf txtSeatNum.Text = 4 Then
            strSeat(4, 1) = txtName.Text
        ElseIf txtSeatNum.Text = 5 Then
            strSeat(5, 1) = txtName.Text
        ElseIf txtSeatNum.Text = 6 Then
            strSeat(6, 1) = txtName.Text
        ElseIf txtSeatNum.Text = 7 Then
            strSeat(7, 1) = txtName.Text
        ElseIf txtSeatNum.Text = 8 Then
            strSeat(8, 1) = txtName.Text
        ElseIf txtSeatNum.Text = 9 Then
            strSeat(9, 1) = txtName.Text
        End If
    End Sub

End Class
