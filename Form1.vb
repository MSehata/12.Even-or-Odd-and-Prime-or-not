Public Class Form1


    Private Sub lblHeading_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim number As Integer
        number = Val(txtNumber.Text)

        If IsEven(number) Then
            MsgBox("is an even number.")
        Else
            MsgBox("is an odd number.")
        End If

        If IsPrime(number) Then
            MsgBox(" is a prime number.")
        Else
            MsgBox(" is not a prime number.")
        End If
    End Sub

    Function IsEven(number As Integer) As Boolean
        Return number Mod 2 = 0
    End Function

    Function IsPrime(number As Integer) As Boolean
        If number < 2 Then
            Return False
        End If

        For i As Integer = 2 To Math.Sqrt(number)
            If number Mod i = 0 Then
                Return False
            End If
        Next

        Return True
    End Function

End Class
