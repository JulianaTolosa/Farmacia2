Module Utilidades
    Public _UsuarioLogueado As New Usuario


    Public Sub SetearCadenaConexion()
        Try
            If System.Environment.MachineName.ToLower.Contains("juli") Then
                ConsultaSQL._Conexion = "Data Source=Juli-PC;Initial Catalog=Tesis;Integrated Security=True"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SetearIdDeMySettings(_Id As Integer)
        My.Settings.Id = _Id
        My.Settings.Save()
    End Sub


End Module
