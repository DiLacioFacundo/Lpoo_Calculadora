Public Class Form1

    Dim num1, num2, numTotal As Double
    Dim bandera As Integer

    Private Sub T7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T7.Click
        areaNum.Text = areaNum.Text & T7.Text
    End Sub

    Private Sub T8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T8.Click
        areaNum.Text = areaNum.Text & T8.Text
    End Sub

    Private Sub T9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T9.Click
        areaNum.Text = areaNum.Text & T9.Text
    End Sub

    Private Sub T4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T4.Click
        areaNum.Text = areaNum.Text & T4.Text
    End Sub

    Private Sub T5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T5.Click
        areaNum.Text = areaNum.Text & T5.Text
    End Sub

    Private Sub T6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T6.Click
        areaNum.Text = areaNum.Text & T6.Text
    End Sub

    Private Sub T1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.Click
        areaNum.Text = areaNum.Text & T1.Text
    End Sub

    Private Sub T2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T2.Click
        areaNum.Text = areaNum.Text & T2.Text
    End Sub

    Private Sub T3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T3.Click
        areaNum.Text = areaNum.Text & T3.Text
    End Sub

    Private Sub T0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T0.Click
        areaNum.Text = areaNum.Text & T0.Text
    End Sub

    Private Sub TDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDividir.Click
        num1 = Val(areaNum.Text)
        bandera = 4
        areaNum.Clear()
    End Sub

    Private Sub TMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMultiplicar.Click
        num1 = Val(areaNum.Text)
        bandera = 3
        areaNum.Clear()
    End Sub

    Private Sub TResta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TResta.Click
        num1 = Val(areaNum.Text)
        bandera = 2
        areaNum.Clear()
    End Sub

    Private Sub TResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TResultado.Click
        If bandera = 1 Then
            num2 = Val(areaNum.Text)
            numTotal = num1 + num2
            areaNum.Text = CStr(numTotal)
            bandera = 0
        ElseIf bandera = 2 Then
            num2 = Val(areaNum.Text)
            numTotal = num1 - num2
            areaNum.Text = CStr(numTotal)
            bandera = 0
        ElseIf bandera = 3 Then
            num2 = Val(areaNum.Text)
            numTotal = num1 * num2
            areaNum.Text = CStr(numTotal)
            bandera = 0
        ElseIf bandera = 4 Then
            num2 = Val(areaNum.Text)
            numTotal = num1 / num2
            areaNum.Text = CStr(numTotal)
            bandera = 0
        End If
    End Sub

    Private Sub TSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSuma.Click

        num1 = Val(areaNum.Text)
        bandera = 1
        areaNum.Clear()
    End Sub

    Private Sub TDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDecimal.Click
        areaNum.Text = areaNum.Text & TDecimal.Text
    End Sub

    Private Sub TBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBorrar.Click
        areaNum.Clear()
    End Sub
End Class
