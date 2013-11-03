
Public Class ConcreteUsuarioFactory
    Inherits IUsuarioFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetUsuario() As Usuario
        Return New Usuario(_idUsuarioActual)
    End Function
    Public Overrides Function GetUsuarioFamilias() As UsuarioFamilias
        Return New UsuarioFamilias(_idUsuarioActual)
    End Function
End Class

Public Class ConcreteProductoFactory
    Inherits IProductoFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetProducto() As Producto
        Return New Producto(_idUsuarioActual)
    End Function
    Public Overrides Function GetTipoProducto() As TipoProducto
        Return New TipoProducto(_idUsuarioActual)
    End Function
End Class

Public Class ConcreteClienteFactory
    Inherits IClienteFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetCliente() As Cliente
        Return New Cliente(_idUsuarioActual)
    End Function
End Class

Public Class ConcreteTelefonoFactory
    Inherits ITelefonoFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetTelefono() As Telefono
        Return New Telefono(_idUsuarioActual)
    End Function
    Public Overrides Function GetTipoTelefono() As TipoTelefono
        Return New TipoTelefono(_idUsuarioActual)
    End Function
End Class

Public Class ConcretePermisosFactory
    Inherits IPermisosFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetPermisos() As Permisos
        Return New Permisos(_idUsuarioActual)
    End Function
End Class

Public Class ConcretePCFactory
    Inherits IPCFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetPC() As PC
        Return New PC(_idUsuarioActual)
    End Function
End Class

Public Class ConcreteLangFactory
    Inherits ILangFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetLang() As Lang
        Return New Lang(_idUsuarioActual)
    End Function
End Class

Public Class ConcreteFamilyFactory
    Inherits IFamilyFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetFamily() As Family
        Return New Family(_idUsuarioActual)
    End Function
    Public Overrides Function GetFamiliaPermisos() As FamiliaPermisos
        Return New FamiliaPermisos(_idUsuarioActual)
    End Function
End Class

Public Class ConcreteDescripcionPCFactory
    Inherits IDescripcionPCFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetDescripcionPC() As DescripcionPC
        Return New DescripcionPC(_idUsuarioActual)
    End Function
End Class

Public Class ConcreteAbonoClienteFactory
    Inherits IAbonoClienteFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetAbonoCliente() As AbonoCliente
        Return New AbonoCliente(_idUsuarioActual)
    End Function
End Class

Public Class ConcreteTarifaFactory
    Inherits ITarifaFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetTarifa() As Tarifa
        Return New Tarifa(_idUsuarioActual)
    End Function
End Class

Public Class ConcreteCajaTableFactory
    Inherits ICajaTableFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetCajaTable() As CajaTable
        Return New CajaTable(_idUsuarioActual)
    End Function
End Class

Public Class ConcreteCajaDetalleFactory
    Inherits ICajaDetalleFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetCajaDetalle() As CajaDetalle
        Return New CajaDetalle(_idUsuarioActual)
    End Function
End Class

Public Class ConcreteSecuenciaFactory
    Inherits ISecuenciaFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetSecuencia() As Secuencia
        Return New Secuencia(_idUsuarioActual)
    End Function
End Class

Public Class ConcreteDBFactory
    Inherits IDBFactory
    Private _idUsuarioActual As Long
    Public Sub New(ByVal idUsuarioActual As Long)
        _idUsuarioActual = idUsuarioActual
    End Sub
    Public Overrides Function GetDB() As DB
        Return New DB(_idUsuarioActual)
    End Function
End Class

