﻿Imports System.Data.SqlClient

Public Class DAConsultas_Base
    Inherits Conexion
    Dim cmd As SqlCommand
    Public Function mostrarId_Promocion_Ultima() As Integer
        Try
            Conectar()
            cmd = New SqlCommand("select top 1 id_promocio as CODIGO from Promocion order by id_promocio desc")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            Dim da As Integer
            da = cmd.ExecuteScalar()
            Return da
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function
    Public Function mostrarId_Usuario(ByVal numero As Integer) As Integer
        Try
            Conectar()
            cmd = New SqlCommand("select top 1 id_usu from Usuario where id_emp=" & numero)
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            Dim da As Integer
            da = cmd.ExecuteScalar()
            Return da
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function
    Public Function mostrarIdPerfil(ByVal numero As Integer) As Integer
        Try
            Conectar()
            cmd = New SqlCommand("select top 1 id_perfil from Usuario where id_emp=" & numero)
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            Dim da As Integer
            da = cmd.ExecuteScalar()
            Return da
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function
    Public Function mostrar_Ultimo_Id_Empleado() As Integer
        Try
            Conectar()
            cmd = New SqlCommand("select top 1 id_emp from Empleado order by id_emp desc ")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            Dim da As Integer
            da = cmd.ExecuteScalar()
            Return da
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function mostrar_Ultimo_Id_Perfil() As Integer
        Try
            Conectar()
            cmd = New SqlCommand("select top 1 id_perfil from Perfil order by id_perfil desc")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            Dim da As Integer
            da = cmd.ExecuteScalar()
            Return da
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function mostrar_Id_Servicio(ByVal cod_ser As String) As Integer
        Try
            Conectar()
            cmd = New SqlCommand("select id_serv from servicio where cod_serv ='" & cod_ser & "' ")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            Dim da As Integer
            da = cmd.ExecuteScalar()
            Return da
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function



    Public Function mostrarCod_Promocion_Ultima() As String
        Try
            Conectar()
            cmd = New SqlCommand("select top 1 cod_promo as CODIGO from Promocion order by id_promocio desc")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            Dim da As String
            da = cmd.ExecuteScalar()
            Return da
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function mostrarId_Nombre_Servicio(ByVal id_serv As Integer) As String
        Try
            Conectar()
            cmd = New SqlCommand("select des_ser from Servicio where id_serv=" & id_serv)
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            Dim da As String
            da = cmd.ExecuteScalar()
            Return da
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

End Class