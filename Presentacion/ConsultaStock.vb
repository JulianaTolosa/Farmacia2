Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data

Public Class ConsultaStock


    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub



    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles Btnbuscar.Click
        If (String.IsNullOrEmpty(Txtbuscar.Text)) Then
            MsgBox("Por Favor, rellene los campos vacios")
        ElseIf RBid.Checked = True Then




        ElseIf RBnombre.Checked = True Then
            
        End If




    End Sub

   
End Class