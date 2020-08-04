Imports System.Data.SqlClient
Public Class conexion1
    Public conexion As SqlConnection = New SqlConnection("Data Source= localhost;Initial Catalog=TiendaIIIP; Integrated Security=True")
    'Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public cmb As SqlCommand
    Public dr As SqlDataReader

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function insertarUsuario(idUsuario As Integer, nombre As String, apellido As String, userName As String,
                                    psw As String, rol As String, estado As String, correo As String)
        Dim enc As New Encriptador
        Try
            conexion.Open()
            cmb = New SqlCommand("insertarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idUsuario", idUsuario)
            cmb.Parameters.AddWithValue("@nombre", convertirMayusculas(nombre))
            cmb.Parameters.AddWithValue("@apellido", convertirMayusculas(apellido))
            cmb.Parameters.AddWithValue("@userName", userName)
            cmb.Parameters.AddWithValue("@psw", enc.Encriptar(psw))
            cmb.Parameters.AddWithValue("@rol", rol)
            cmb.Parameters.AddWithValue("@estado", estado)
            cmb.Parameters.AddWithValue("@correo", convertirMinusculas(correo))
            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function eliminarUsuario(idUsuario As Integer, rol As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("eliminarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idUsuario", idUsuario)
            cmb.Parameters.AddWithValue("@rol", rol)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function modificarUsuario(idUsuario As Integer, nombre As String, apellido As String, userName As String,
                                    psw As String, rol As String, correo As String)
        Dim enc As New Encriptador
        Try
            conexion.Open()
            cmb = New SqlCommand("modificarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idUsuario", idUsuario)
            cmb.Parameters.AddWithValue("@nombre", convertirMayusculas(nombre))
            cmb.Parameters.AddWithValue("@apellido", convertirMayusculas(apellido))
            cmb.Parameters.AddWithValue("@userName", userName)
            cmb.Parameters.AddWithValue("@psw", enc.Encriptar(psw))
            cmb.Parameters.AddWithValue("@rol", rol)
            cmb.Parameters.AddWithValue("@correo", convertirMinusculas(correo))
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function buscarUsuario(username As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("buscarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@userName", username)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function convertirMayusculas(ByVal Texto As String)
        Return StrConv(Texto, VbStrConv.ProperCase)
    End Function
    Public Function convertirMinusculas(ByVal Texto As String)
        Return StrConv(Texto, VbStrConv.Lowercase)
    End Function
    Public Function validarUsuario(userName As String, psw As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("validarUsuario", conexion)
            cmb.CommandType = 4
            cmb.Parameters.AddWithValue("@userName", userName)
            cmb.Parameters.AddWithValue("@psw", psw)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function


    '------------------------CONSULTA PERSONALIZADA-----------------------------
    Public Function consultarPSW(correo As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("buscarUsuarioPorCorreo", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@correo", correo)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function consultarProducto(idCodigo As Integer) As DataTable
        Try
            conexion.Open()
            Dim cmb As New SqlCommand("buscarProducto", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@idProducto", idCodigo)
            If cmb.ExecuteNonQuery <> 0 Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function
End Class