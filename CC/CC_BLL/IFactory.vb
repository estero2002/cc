Public Class Context
    Public Shared idUsuarioActual As Integer
    Public Shared NickUsuarioActual As String
    Public Shared idioma As String
End Class
Public MustInherit Class IUsuarioFactory
    Public MustOverride Function GetUsuario() As Usuario
    Public MustOverride Function GetUsuarioFamilias() As UsuarioFamilias
    Public MustOverride Function GetUsuarioPermisos() As UsuarioPermisos
    Public MustOverride Function GetUsuarioPermisosNeg() As UsuarioPermisosNeg
End Class
Public MustInherit Class IProductoFactory
    Public MustOverride Function GetProducto() As Producto
    Public MustOverride Function GetTipoProducto() As TipoProducto
End Class
Public MustInherit Class IClienteFactory
    Public MustOverride Function GetCliente() As Cliente
End Class
Public MustInherit Class ITelefonoFactory
    Public MustOverride Function GetTelefono() As Telefono
    Public MustOverride Function GetTipoTelefono() As TipoTelefono
End Class
Public MustInherit Class IPermisosFactory
    Public MustOverride Function GetPermisos() As Permisos
End Class
Public MustInherit Class IPCFactory
    Public MustOverride Function GetPC() As PC
End Class
Public MustInherit Class ILangFactory
    Public MustOverride Function GetLang() As Lang
End Class
Public MustInherit Class IFamilyFactory
    Public MustOverride Function GetFamily() As Family
    Public MustOverride Function GetFamiliaPermisos() As FamiliaPermisos
End Class
Public MustInherit Class IDescripcionPCFactory
    Public MustOverride Function GetDescripcionPC() As DescripcionPC
End Class
Public MustInherit Class IAbonoClienteFactory
    Public MustOverride Function GetAbonoCliente() As AbonoCliente
End Class
Public MustInherit Class ITarifaFactory
    Public MustOverride Function GetTarifa() As Tarifa
End Class
Public MustInherit Class ICajaTableFactory
    Public MustOverride Function GetCajaTable() As CajaTable
End Class
Public MustInherit Class ICajaDetalleFactory
    Public MustOverride Function GetCajaDetalle() As CajaDetalle
End Class
Public MustInherit Class ISecuenciaFactory
    Public MustOverride Function GetSecuencia() As Secuencia
End Class
Public MustInherit Class IUsuariosBloqueadosFactory
    Public MustOverride Function GetUsuariosBloqueados() As UsuariosBloqueados
End Class
Public MustInherit Class IDBFactory
    Public MustOverride Function GetDB() As DB
End Class

