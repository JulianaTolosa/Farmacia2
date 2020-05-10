Imports System.Data.SqlClient
Imports System.Data


Public MustInherit Class Conexion

   

    Public connectionString As String
    Public Sub New()
        connectionString = "Data Source=ALUMN127\SQLEXPRESS;Initial Catalog=Tesis;Integrated Security=True"
    End Sub

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function



End Class
