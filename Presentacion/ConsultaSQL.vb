Imports System.Data.SqlClient
Imports System.Data

Public Class ConsultaSQL
    Private _Comando As New SqlCommand
    Private _Lector As SqlDataReader
    Private _Tabla As DataTable
    Private _Parametro As SqlParameter
    'Public Shared _Conexion As String = "Data Source=Juli-PC;Initial Catalog=Tesis;Integrated Security=True"
    Public Shared _Conexion As String = "Data Source=LEO-PC;Initial Catalog=Tesis;Integrated Security=True"
    Private _Consulta As String = ""



    Public Property Consulta() As String
        Get
            Return Me._Comando.CommandText
        End Get
        Set(value As String)
            Me._Comando.CommandText = value
        End Set
    End Property


    Public Sub New()
        Try
            Me._Comando.Connection = Me.ObtenerConexion()
            Me._Comando.CommandText = Me._Consulta
            Me._Tabla = New DataTable()
            Me._Lector = DirectCast(Nothing, SqlDataReader)
        Catch ex As Exception

        End Try
    End Sub

    Private Function ObtenerConexion() As SqlConnection
        Dim sqlConnection As New SqlConnection()
        sqlConnection.ConnectionString = _Conexion
        Return sqlConnection
    End Function

    Public Sub New(Consulta As String)
        Me._Comando = New SqlCommand()
        Me._Comando.Connection = Me.ObtenerConexion()
        Me._Comando.CommandText = Consulta
        Me._Tabla = New DataTable()
        Me._Lector = DirectCast(Nothing, SqlDataReader)
    End Sub


    Protected Overrides Sub Finalize()
        Try
        Finally
            MyBase.Finalize()
        End Try
    End Sub

    Public Sub AgregarParametro(Nombre As String, Valor As Object)
        Me._Comando.Parameters.Add(New SqlParameter(Nombre, Valor))
    End Sub

    Public Sub Ejecutar()
        If Me._Comando.Connection.State <> ConnectionState.Open Then
            Me._Comando.Connection.Open()
        End If
        Me._Comando.ExecuteNonQuery()
        Me.Cerrar()
    End Sub


    Public Function ObtenerTabla() As DataTable
        Dim _Retorno As New DataTable()
        Try
            If Me._Comando.Connection.State <> ConnectionState.Open Then
                Try
                    Me._Comando.Connection.Open()
                Catch
                End Try
                Dim _DR As SqlDataReader = Me._Comando.ExecuteReader()
                Me._Tabla.Load(_DR)
                _Retorno = Me._Tabla
            End If
        Catch oError As SqlException
            _Retorno = New DataTable()
        End Try
        Me.Cerrar()

        Return _Retorno
    End Function


    Public Sub Cerrar()
        If Me._Lector IsNot Nothing Then
            Me._Lector.Close()
            Me._Lector.Dispose()
            Me._Lector = DirectCast(Nothing, SqlDataReader)
        End If
        If Me._Comando Is Nothing Then
            Return
        End If
        If Me._Comando.Connection.State = ConnectionState.Open Then
            Me._Comando.Connection.Close()
        End If
        If Me._Comando.Connection IsNot Nothing Then
            Me._Comando.Connection.Dispose()
        End If
        Me._Comando.Parameters.Clear()
        Me._Comando.Dispose()
        Me._Comando = DirectCast(Nothing, SqlCommand)
    End Sub


End Class
