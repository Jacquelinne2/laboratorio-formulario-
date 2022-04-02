Public Class Form1
    Private Sub txtvalor1_TextChanged(sender As Object, e As EventArgs) Handles txtvalor1.TextChanged

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim valor1, valor2, valor3, totaldesc, totalcm, ivaa As Decimal
        valor1 = txtvalor1.Text
        valor2 = txtvalor2.Text
        valor3 = txtvalor3.Text
        txttotalcom.Text = totalcompra(valor1, valor2, valor3)
        totaldesc = totalcompra(valor1, valor2, valor3)
        descuento(valor1, valor2, valor3, totaldesc)


        ivaa = (txttotalcom.Text - txttotaldesc.Text) * 0.13
        txttotaliva.Text = ivaa
        totalcm = (txttotalcom.Text - txttotaldesc.Text) + txttotaliva.Text
        txttotalpagar.Text = totalcm


    End Sub

    Function totalcompra(Valor1, Valor2, Valor3) As Decimal
        Return Valor1 + Valor2 + Valor3
    End Function
    Sub descuento(valor1 As Decimal, valor2 As Decimal, valor3 As Decimal, totaldesc As Decimal)

        If (totaldesc >= 25 And totaldesc <= 99.99) Then
            txttotaldesc.Text = (totaldesc * 0.05)
        ElseIf (totaldesc >= 100 And totaldesc <= 149.99) Then
            txttotaldesc.Text = (totaldesc * 0.1)
        ElseIf (totaldesc >= 150) Then
            txttotaldesc.Text = (totaldesc * 0.15)
        Else
            txttotaldesc.Text = "No aplica descuento"
        End If

    End Sub
    Function iva(totalcm, totaldesc) As Decimal
        Dim iva1 As Decimal
        iva1 = (totalcm - totaldesc) * 0.13
        Return (iva1)
    End Function

End Class
