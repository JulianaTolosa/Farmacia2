Imports System.Data
Imports System.Data.SqlClient
Imports CapaComun

'Public Class UserDao
'    Inherits Conexion

'    'Public Sub editProfile(ByVal idusuario, ByVal nombreusuario, ByVal contrasena, ByVal Nombre, ByVal Apellido, ByVal Posicion, ByVal Correo)
'    '    Using Conexion = GetConnection()
'    '        Conexion.Open()
'    '        Using Command = New SqlCommand
'    '            Command.Connection = Conexion
'    '            Command.CommandText = "update Usuario nombreusuario=@user, contrasena=@pass,Nombre=@name,Apellido=@lastname,Correo=@email where idusurio=@id"
'    '            Command.Parameters.AddWithValue("@user", nombreusuario)
'    '            Command.Parameters.AddWithValue("@pass", contrasena)
'    '            Command.Parameters.AddWithValue("@name", Nombre)
'    '            Command.Parameters.AddWithValue("@lastname", Apellido)
'    '            Command.Parameters.AddWithValue("@email", Correo)
'    '            Command.Parameters.AddWithValue("@id", idusuario)
'    '            Command.CommandType = CommandType.Text
'    '            Command.ExecuteNonQuery()
'    '        End Using
'    '    End Using




'    'End Sub



'    'Public Function Login(ByVal user As String, ByVal pass As String) As Boolean
'    '    Using connection = GetConnection()
'    '        connection.Open()
'    '        Using Command = New SqlCommand()
'    '            Command.Connection = connection
'    '            Command.CommandText = "select * from Usuario where nombreusuario=@user and contrasena=@pass"
'    '            Command.Parameters.AddWithValue("@user", user)
'    '            Command.Parameters.AddWithValue("@pass", pass)
'    '            Command.CommandType = CommandType.Text
'    '            Dim reader = Command.ExecuteReader()

'    '            If reader.HasRows Then
'    '                While reader.Read()
'    '                    ActiveUser.idusuario = reader.GetInt32(0)
'    '                    ActiveUser.Nombre = reader.GetString(3)
'    '                    ActiveUser.Apellido = reader.GetString(4)
'    '                    ActiveUser.Posicion = reader.GetString(5)
'    '                    ActiveUser.Correo = reader.GetString(6)
'    '                End While
'    '                reader.Dispose()
'    '                Return True
'    '            Else
'    '                Return False
'    '            End If
'    '        End Using
'    '    End Using
'    'End Function

'    'Public Function existsUser(ByVal id As Integer) As Boolean
'    '    Using connection = GetConnection()
'    '        connection.Open()
'    '        Using Command = New SqlCommand()
'    '            Command.Connection = connection
'    '            Command.CommandText = "select * from Usuario where idusuario=@user"
'    '            Command.Parameters.AddWithValue("@user", id)
'    '            Command.CommandType = CommandType.Text
'    '            Dim reader = Command.ExecuteReader()
'    '            If reader.HasRows Then
'    '                Return True
'    '            Else
'    '                Return False
'    '            End If
'    '        End Using
'    '    End Using
'    'End Function

'    'Public Sub anyMethod2()
'    '    If ActiveUser.Posicion = Positions.Encargado Then

'    '    End If
'    '    If ActiveUser.Posicion = Positions.Vendedor Then

'    '    End If
'    'End Sub

'End Class
