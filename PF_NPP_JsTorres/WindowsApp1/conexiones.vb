Imports Npgsql

Public Class conexiones
    Dim strConexion As String = "Server=lab.anahuac.mx;port=5432;Database=a00260271;uid=a00260271;pwd=a00260271"

    Public Function ExisteUsuario(ByVal strNombre As String, ByVal strApellido As String) As Boolean
        Dim conn As New NpgsqlConnection(strConexion)
        Dim respuesta As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim query As String = "SELECT * FROM usuarios WHERE nombre='" + strNombre + "' AND apellidos='" + strApellido + "'"
                Dim comando As NpgsqlCommand = New NpgsqlCommand(query, conn)
                Dim da As NpgsqlDataReader
                da = comando.ExecuteReader
                If da.Read Then


                    respuesta = True
                Else
                    respuesta = False
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Error: " + Err.ToString)

        End Try
        Return respuesta

    End Function



    'Public Function BuscarClienteParaTexto(ByVal IdCliente As String) As AutoCompleteStringCollection
    '    Dim conn As New NpgsqlConnection(strConexion)
    '    Dim coll As New AutoCompleteStringCollection
    '    Dim source = New AutoCompleteStringCollection()
    '    Try
    '        If conn.State = ConnectionState.Closed Then
    '            conn.Open()
    '            Dim query As String = "SELECT ID, NOMBRE FROM CLIENTES WHERE ID LIKE '" + IdCliente + "'"
    '            Dim comando As NpgsqlCommand = New NpgsqlCommand(query, conn)
    '            Dim da As NpgsqlDataReader
    '            da = comando.ExecuteReader

    '            If da.Read Then
    '                While da.Read
    '                    source.AddRange(da.Item("nombre"))
    '                End While
    '            End If

    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error: " + Err.ToString)
    '    End Try
    '    Return source
    'End Function

    Public Function BuscarCliente(ByVal IdCliente As String) As String
        Dim conn As New NpgsqlConnection(strConexion)
        Dim nombre As String
        nombre = ""
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim query As String = "SELECT NOMBRE FROM CLIENTES WHERE ID='" + IdCliente + "'"
                Dim comando As NpgsqlCommand = New NpgsqlCommand(query, conn)
                Dim da As NpgsqlDataReader
                da = comando.ExecuteReader
                If da.Read Then
                    nombre = da.Item("nombre").ToString
                Else
                    nombre = ""
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Error: " + Err.ToString)
        End Try
        Return nombre
    End Function





    'Public Function UsuarioValido(ByVal strUsuario As String, ByVal strPassword As String) As Boolean
    '    Dim conn As New NpgsqlConnection(strConexion)
    '    Dim respuesta As Boolean
    '    Try
    '        If conn.State = ConnectionState.Closed Then
    '            conn.Open()
    '            Dim query As String = "SELECT id, clientes, provedores, productos, ventas, compras, reportes, usuarios FROM usuarios WHERE nombre='" + strUsuario + "' AND contrasena='" + strPassword + "'"
    '            Dim comando As NpgsqlCommand = New NpgsqlCommand(query, conn)
    '            Dim da As NpgsqlDataReader
    '            da = comando.ExecuteReader
    '            If da.Read Then
    '                gClientes = da.Item("clientes").ToString
    '                gProveedores = da.Item("provedores").ToString
    '                gProductos = da.Item("productos").ToString
    '                gVentas = da.Item("ventas").ToString
    '                gCompras = da.Item("compras").ToString
    '                gReportes = da.Item("reportes").ToString
    '                gUsuarios = da.Item("usuarios").ToString


    '                respuesta = True
    '            Else
    '                respuesta = False
    '            End If
    '            conn.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error: " + Err.ToString)

    '    End Try
    '    Return respuesta
    'End Function


    Public Function EjecutaQuery(ByVal Query As String) As Boolean
        Dim conn As New NpgsqlConnection(strConexion)
        Dim respuesta As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim comando As NpgsqlCommand = New NpgsqlCommand(Query, conn)
                comando.ExecuteNonQuery()
                respuesta = True
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Error: " + Err.ToString)

        End Try
        Return respuesta

    End Function

End Class
