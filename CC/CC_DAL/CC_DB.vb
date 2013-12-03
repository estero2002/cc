

Namespace CC_DBTableAdapters
    
    Partial Public Class usuarioTableAdapter
        Public Overloads Function Insert(ByRef id As Long, ByVal legajo As String, ByVal dni As String, ByVal apellido As String, ByVal nombre As String, ByVal direccion As String, ByVal username As String, ByVal password As String, ByVal id_lang As Global.System.Nullable(Of Integer), ByVal strval As Global.System.Nullable(Of Integer)) As Integer
            id = 0
            If (legajo Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(legajo, String)
            End If
            If (dni Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(dni, String)
            End If
            If (apellido Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = CType(apellido, String)
            End If
            If (nombre Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(3).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(3).Value = CType(nombre, String)
            End If
            If (direccion Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(4).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(4).Value = CType(direccion, String)
            End If
            If (username Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(5).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(5).Value = CType(username, String)
            End If
            If (password Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(6).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(6).Value = CType(password, String)
            End If
            If (id_lang.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(7).Value = CType(id_lang.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(7).Value = Global.System.DBNull.Value
            End If
            If (strval.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(8).Value = CType(strval.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(8).Value = Global.System.DBNull.Value
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
                If returnValue = 1 Then
                    Dim cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "select @@IDENTITY"
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Me.Adapter.InsertCommand.Connection
                    id = cmd.ExecuteScalar()
                End If
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function


        Public Overloads Function Delete(ByVal id As Integer) As Integer
            Me.Adapter.DeleteCommand.Parameters(0).Value = CType(id, Integer)
            Me.Adapter.DeleteCommand.Parameters(1).Value = CType(1, Object)
            Me.Adapter.DeleteCommand.Parameters(2).Value = Global.System.DBNull.Value
            Me.Adapter.DeleteCommand.Parameters(3).Value = CType(1, Object)
            Me.Adapter.DeleteCommand.Parameters(4).Value = Global.System.DBNull.Value
            Me.Adapter.DeleteCommand.Parameters(5).Value = CType(1, Object)
            Me.Adapter.DeleteCommand.Parameters(6).Value = Global.System.DBNull.Value
            Me.Adapter.DeleteCommand.Parameters(7).Value = CType(1, Object)
            Me.Adapter.DeleteCommand.Parameters(8).Value = Global.System.DBNull.Value
            Me.Adapter.DeleteCommand.Parameters(9).Value = CType(1, Object)
            Me.Adapter.DeleteCommand.Parameters(10).Value = Global.System.DBNull.Value
            Me.Adapter.DeleteCommand.Parameters(11).Value = CType(1, Object)
            Me.Adapter.DeleteCommand.Parameters(12).Value = Global.System.DBNull.Value
            Me.Adapter.DeleteCommand.Parameters(13).Value = CType(1, Object)
            Me.Adapter.DeleteCommand.Parameters(14).Value = Global.System.DBNull.Value
            Me.Adapter.DeleteCommand.Parameters(15).Value = CType(1, Object)
            Me.Adapter.DeleteCommand.Parameters(16).Value = Global.System.DBNull.Value
            Me.Adapter.DeleteCommand.Parameters(17).Value = CType(1, Object)
            Me.Adapter.DeleteCommand.Parameters(18).Value = Global.System.DBNull.Value

            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.DeleteCommand.Connection.State
            If ((Me.Adapter.DeleteCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.DeleteCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.DeleteCommand.ExecuteNonQuery
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.DeleteCommand.Connection.Close()
                End If
            End Try

        End Function
    End Class
    Partial Public Class clienteTableAdapter
        Public Overridable Overloads Function Insert(ByRef id As Long, ByVal dni As Global.System.Nullable(Of Long), ByVal apellido As String, ByVal nombre As String, ByVal direccion As String, ByVal email As String, ByVal strval As Global.System.Nullable(Of Long)) As Integer
            If (dni.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(dni.Value, Long)
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (apellido Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(apellido, String)
            End If
            If (nombre Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = CType(nombre, String)
            End If
            If (direccion Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(3).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(3).Value = CType(direccion, String)
            End If
            If (email Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(4).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(4).Value = CType(email, String)
            End If
            If (strval.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(5).Value = CType(strval.Value, Long)
            Else
                Me.Adapter.InsertCommand.Parameters(5).Value = Global.System.DBNull.Value
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
                If returnValue = 1 Then
                    Dim cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "select @@IDENTITY"
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Me.Adapter.InsertCommand.Connection
                    id = cmd.ExecuteScalar()
                End If
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function

    End Class
    Partial Public Class telefonoTableAdapter
        Public Overridable Overloads Function Insert(ByRef id As Long, ByVal id_usuario As Global.System.Nullable(Of Long), ByVal id_tipo_num As Global.System.Nullable(Of Long), ByVal numero As String, ByVal strval As Global.System.Nullable(Of Long)) As Integer
            If (id_usuario.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(id_usuario.Value, Long)
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (id_tipo_num.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(id_tipo_num.Value, Long)
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            If (numero Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = CType(numero, String)
            End If
            If (strval.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(3).Value = CType(strval.Value, Long)
            Else
                Me.Adapter.InsertCommand.Parameters(3).Value = Global.System.DBNull.Value
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
                If returnValue = 1 Then
                    Dim cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "select @@IDENTITY"
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Me.Adapter.InsertCommand.Connection
                    id = cmd.ExecuteScalar()
                End If
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function

    End Class
    Partial Public Class ProductoTableAdapter
        Public Overridable Overloads Function Insert(ByRef id As Long, ByVal descripcion As String, ByVal precio As Global.System.Nullable(Of Decimal), ByVal tipo_producto As Global.System.Nullable(Of Long), ByVal strval As Global.System.Nullable(Of Long)) As Integer
            If (descripcion Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(descripcion, String)
            End If
            If (precio.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(precio.Value, Decimal)
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            If (tipo_producto.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(2).Value = CType(tipo_producto.Value, Long)
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
            End If
            If (strval.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(3).Value = CType(strval.Value, Long)
            Else
                Me.Adapter.InsertCommand.Parameters(3).Value = Global.System.DBNull.Value
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
                If returnValue = 1 Then
                    Dim cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "select @@IDENTITY"
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Me.Adapter.InsertCommand.Connection
                    id = cmd.ExecuteScalar()
                End If
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function
    End Class

    Partial Public Class PCTableAdapter
        Public Overridable Overloads Function Insert(ByRef id As Long, ByVal id_pc As Global.System.Nullable(Of Integer), ByVal CantidadMinutos As Global.System.Nullable(Of Integer), ByVal fecha As Global.System.Nullable(Of Date), ByVal id_cliente As Global.System.Nullable(Of Integer), ByVal id_usuario As Global.System.Nullable(Of Integer), ByVal strval As Global.System.Nullable(Of Integer), ByVal horaInicio As Global.System.Nullable(Of Date)) As Integer
            If (id_pc.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(id_pc.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (CantidadMinutos.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(CantidadMinutos.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            If (fecha.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(2).Value = CType(fecha.Value, Date)
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
            End If
            If (id_cliente.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(3).Value = CType(id_cliente.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(3).Value = Global.System.DBNull.Value
            End If
            If (id_usuario.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(4).Value = CType(id_usuario.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(4).Value = Global.System.DBNull.Value
            End If
            If (strval.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(5).Value = CType(strval.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(5).Value = Global.System.DBNull.Value
            End If
            If (horaInicio.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(6).Value = CType(horaInicio.Value, Date)
            Else
                Me.Adapter.InsertCommand.Parameters(6).Value = Global.System.DBNull.Value
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
                If returnValue = 1 Then
                    Dim cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "select @@IDENTITY"
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Me.Adapter.InsertCommand.Connection
                    id = cmd.ExecuteScalar()
                End If
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function
    End Class
    Partial Public Class familyTableAdapter
        Public Overridable Overloads Function Insert(ByRef id As Long, ByVal nombre As String, ByVal strval As String) As Integer
            If (nombre Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(nombre, String)
            End If
            If (strval Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(strval, String)
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
                If returnValue = 1 Then
                    Dim cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "select @@IDENTITY"
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Me.Adapter.InsertCommand.Connection
                    id = cmd.ExecuteScalar()
                End If
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function

    End Class

    Partial Public Class family_patternTableAdapter
        Public Overridable Overloads Function Insert(ByRef id As Long, ByVal id_fam As Global.System.Nullable(Of Long), ByVal id_patt As Global.System.Nullable(Of Long), ByVal strval As String) As Integer
            If (id_fam.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(id_fam.Value, Long)
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (id_patt.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(id_patt.Value, Long)
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            If (strval Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = CType(strval, String)
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
                If returnValue = 1 Then
                    Dim cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "select @@IDENTITY"
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Me.Adapter.InsertCommand.Connection
                    id = cmd.ExecuteScalar()
                End If
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function

    End Class
    Partial Public Class usuario_famTableAdapter
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), _
         Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Insert, True)> _
        Public Overridable Overloads Function Insert(ByRef id As Long, ByVal id_family As Global.System.Nullable(Of Long), ByVal id_usuario As Global.System.Nullable(Of Long), ByVal strval As String) As Integer
            If (id_family.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(id_family.Value, Long)
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (id_usuario.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(id_usuario.Value, Long)
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            If (strval Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = CType(strval, String)
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
                If returnValue = 1 Then
                    Dim cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "select @@IDENTITY"
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Me.Adapter.InsertCommand.Connection
                    id = cmd.ExecuteScalar()
                End If
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function
    End Class
    Partial Public Class logTableAdapter
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), _
        Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Insert, True)> _
        Public Overridable Overloads Function Insert(ByRef id As Long, ByVal _date As Global.System.Nullable(Of Date), ByVal action As String, ByVal id_usuario As Integer, ByVal strval As Global.System.Nullable(Of Integer), ByVal Parameters As String) As Integer
            If (_date.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(_date.Value, Date)
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (action Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(action, String)
            End If
            Me.Adapter.InsertCommand.Parameters(2).Value = CType(id_usuario, Integer)
            If (strval.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(3).Value = CType(strval.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(3).Value = Global.System.DBNull.Value
            End If
            If (Parameters Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Parameters")
            Else
                Me.Adapter.InsertCommand.Parameters(4).Value = CType(Parameters, String)
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
                If returnValue = 1 Then
                    Dim cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "select @@IDENTITY"
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Me.Adapter.InsertCommand.Connection
                    id = cmd.ExecuteScalar()
                End If
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function

    End Class

    Partial Public Class CajaDetalleTableAdapter
        Public Overridable Overloads Function Insert(ByRef id As Long, ByVal id_caja As Global.System.Nullable(Of Integer), ByVal id_producto As Global.System.Nullable(Of Integer), ByVal tipo_producto As Global.System.Nullable(Of Integer), ByVal cantidad As Global.System.Nullable(Of Integer), ByVal importe As Global.System.Nullable(Of Decimal), ByVal strval As Global.System.Nullable(Of Integer)) As Integer
            If (id_caja.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(id_caja.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (id_producto.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(id_producto.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            If (tipo_producto.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(2).Value = CType(tipo_producto.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
            End If
            If (cantidad.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(3).Value = CType(cantidad.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(3).Value = Global.System.DBNull.Value
            End If
            If (importe.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(4).Value = CType(importe.Value, Decimal)
            Else
                Me.Adapter.InsertCommand.Parameters(4).Value = Global.System.DBNull.Value
            End If
            If (strval.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(5).Value = CType(strval.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(5).Value = Global.System.DBNull.Value
            End If
            Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
                        <> Global.System.Data.ConnectionState.Open) Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If
            Try
                Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
                If returnValue = 1 Then
                    Dim cmd = New OleDb.OleDbCommand
                    cmd.CommandText = "select @@IDENTITY"
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Me.Adapter.InsertCommand.Connection
                    id = cmd.ExecuteScalar()
                End If
                Return returnValue
            Finally
                If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function
    End Class
End Namespace



Partial Public Class CC_DB
End Class
