Imports System.Windows.Forms
Imports System.Globalization
Imports System.Threading
Imports System.Data
Imports CC_BLL


Public Class MDI_CC
    'Declarar variables para cada formulario
    Private AsignadorPCForm As Form
    Private CajaForm As caja
    Private ClienteForm As Form
    Private OrdenTrabajoForm As Form
    Private AbonoForm As Form
    Private CerrarSesionForm As Form
    Private CambioContraForm As Form
    Private RprtCajaForm As Form
    Private RprtAbonoForm As Form
    Private RprtClienteForm As Form
    Private RprtOrdenTrabajoForm As Form
    Private ProductoForm As Form
    Private BackupForm As Form
    Private RestoreForm As Form

    Private FamiliaForm As Form
    Private UsuarioForm As Form
    Private UsuarioFamiliaForm As Form
    Private BitacoraForm As Form
    Private DVForm As Form
    Private LibreriaForm As Form

    Private UsuarioPermisoForm As Form

    Private NoDeshabilitar As String = "SalirToolStripMenuItem"
    Public Sub New()
        MyBase.New()
        Dim localization As String
        localization = Context.idioma
        If localization <> "default" Then
            Thread.CurrentThread.CurrentUICulture = New CultureInfo(localization)
        End If
        'This call is required by the Win Forms Designer.
        InitializeComponent()
    End Sub


    Private Sub CajaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaToolStripMenuItem.Click
        If (CajaForm Is Nothing) Then

            CajaForm = New caja
            CajaForm.MdiParent = Me
            AddHandler CajaForm.FormClosing, AddressOf CajaForm_close
            CajaForm.strOpcion = ""
            CajaForm.Show()
        Else
            CajaForm.Activate()
        End If
    End Sub



    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub AsignadorDePCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignadorDePCToolStripMenuItem.Click
        If (AsignadorPCForm Is Nothing) Then

            AsignadorPCForm = New AsignadorPC
            AsignadorPCForm.MdiParent = Me
            AddHandler AsignadorPCForm.FormClosing, AddressOf AsignadorPCForm_close
            AsignadorPCForm.Show()
        Else
            AsignadorPCForm.Activate()
        End If
    End Sub

    Private Sub AsignadorPCForm_close()
        AsignadorPCForm = Nothing
    End Sub


    Private Sub CajaForm_close(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        If Not CajaForm.compraActual Is Nothing Then
            Dim result As DialogResult = Utilities.YesNoDialog(CajaForm.lblMsjSalida.Text)
            If result = DialogResult.Yes Then
                CajaForm.compraActual = Nothing
            Else
                e.Cancel = True
                Return
            End If
        End If
        CajaForm = Nothing
    End Sub
    Private Sub ClienteForm_close()
        ClienteForm = Nothing
    End Sub
    Private Sub OrdenTrabajoform_close()
        OrdenTrabajoForm = Nothing
    End Sub
    Private Sub AbonoForm_close()
        AbonoForm = Nothing
    End Sub
    Private Sub CerrarSesion_close()
        CerrarSesionForm = Nothing
    End Sub
    Private Sub CambioContra_close()
        CambioContraForm = Nothing
    End Sub
    Private Sub RprtCajaForm_close()
        RprtCajaForm = Nothing
    End Sub
    Private Sub RprtAbonoForm_close()
        RprtAbonoForm = Nothing
    End Sub
    Private Sub RprtClienteForm_close()
        RprtClienteForm = Nothing
    End Sub
    Private Sub ProductoForm_close()
        ProductoForm = Nothing
    End Sub
    Private Sub RprtOrdenTrabajoForm_close()
        RprtOrdenTrabajoForm = Nothing
    End Sub

    Private Sub BackupForm_close()
        BackupForm = Nothing
    End Sub
    
    Private Sub FamiliaForm_close()
        FamiliaForm = Nothing
    End Sub
    Private Sub UsuarioForm_close()
        UsuarioForm = Nothing
    End Sub
    Private Sub UsuarioFamiliaForm_close()
        UsuarioFamiliaForm = Nothing
    End Sub
    
    Private Sub BitacoraForm_close()
        BitacoraForm = Nothing
    End Sub
    Private Sub RestoreForm_close()
        RestoreForm = Nothing
    End Sub
    Private Sub DVForm_close()
        DVForm = Nothing
    End Sub
    Private Sub UsuarioPermisoForm_close()
        UsuarioPermisoForm = Nothing
    End Sub
    

    Private Sub OrdenesDeTrabajoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenesDeTrabajoToolStripMenuItem.Click
        If (OrdenTrabajoForm Is Nothing) Then

            OrdenTrabajoForm = New OrdenDeTrabajo
            OrdenTrabajoForm.MdiParent = Me
            AddHandler OrdenTrabajoForm.FormClosing, AddressOf OrdenTrabajoForm_close
            OrdenTrabajoForm.Show()
        Else
            OrdenTrabajoForm.Activate()
        End If
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click
        
        If (ClienteForm Is Nothing) Then

            ClienteForm = New FrmCliente
            ClienteForm.MdiParent = Me
            AddHandler ClienteForm.FormClosing, AddressOf ClienteForm_close
            ClienteForm.Show()
        Else
            ClienteForm.Activate()
        End If
    End Sub

    Private Sub AbonosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbonosToolStripMenuItem.Click
        If (AbonoForm Is Nothing) Then

            AbonoForm = New Abonos
            AbonoForm.MdiParent = Me
            AddHandler AbonoForm.FormClosing, AddressOf AbonoForm_close
            AbonoForm.Show()
        Else
            AbonoForm.Activate()
        End If
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (CerrarSesionForm Is Nothing) Then

            CerrarSesionForm = New CerrarSesion
            CerrarSesionForm.MdiParent = Me
            AddHandler CerrarSesionForm.FormClosing, AddressOf CerrarSesion_close
            CerrarSesionForm.Show()
        Else
            CerrarSesionForm.Activate()
        End If
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        If (CambioContraForm Is Nothing) Then

            CambioContraForm = New CambioContraseña
            CambioContraForm.MdiParent = Me
            AddHandler CambioContraForm.FormClosing, AddressOf CambioContra_close
            CambioContraForm.Show()
        Else
            CambioContraForm.Activate()
        End If
    End Sub

    Private Sub CajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaToolStripMenuItem1.Click
        If (RprtCajaForm Is Nothing) Then

            RprtCajaForm = New RprtCaja
            RprtCajaForm.MdiParent = Me
            AddHandler RprtCajaForm.FormClosing, AddressOf RprtCajaForm_close
            RprtCajaForm.Show()
        Else
            RprtCajaForm.Activate()
        End If
    End Sub

    Private Sub AbonosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbonosToolStripMenuItem1.Click
        If (RprtAbonoForm Is Nothing) Then

            RprtAbonoForm = New RprtAbono
            RprtAbonoForm.MdiParent = Me
            AddHandler RprtAbonoForm.FormClosing, AddressOf RprtAbonoForm_close
            RprtAbonoForm.Show()
        Else
            RprtAbonoForm.Activate()
        End If

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        If (RprtClienteForm Is Nothing) Then

            RprtClienteForm = New RprtClientes
            RprtClienteForm.MdiParent = Me
            AddHandler RprtClienteForm.FormClosing, AddressOf RprtClienteForm_close
            RprtClienteForm.Show()
        Else
            RprtClienteForm.Activate()
        End If
    End Sub

    Private Sub OrdenesDeTrabajoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenesDeTrabajoToolStripMenuItem1.Click
        If (RprtOrdenTrabajoForm Is Nothing) Then

            RprtOrdenTrabajoForm = New RprtOrdenTrabajo
            RprtOrdenTrabajoForm.MdiParent = Me
            AddHandler RprtOrdenTrabajoForm.FormClosing, AddressOf RprtOrdenTrabajoForm_close
            RprtOrdenTrabajoForm.Show()
        Else
            RprtOrdenTrabajoForm.Activate()
        End If
    End Sub

   

    Private Sub RespaldoDeInformacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RespaldoDeInformacionToolStripMenuItem.Click
        If (BackupForm Is Nothing) Then

            BackupForm = New Backup
            BackupForm.MdiParent = Me
            AddHandler BackupForm.FormClosing, AddressOf BackupForm_close
            BackupForm.Show()
        Else
            BackupForm.Activate()
        End If
    End Sub

   
    
    

    Private Sub AsiagnadorFamiliaPermisoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsiagnadorFamiliaPermisoToolStripMenuItem.Click
        If (FamiliaForm Is Nothing) Then

            FamiliaForm = New FrmFamily
            FamiliaForm.MdiParent = Me
            AddHandler FamiliaForm.FormClosing, AddressOf FamiliaForm_close
            FamiliaForm.Show()
        Else
            FamiliaForm.Activate()
        End If
    End Sub

    Private Sub AsignadorUsuarioFamiliaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignadorUsuarioFamiliaToolStripMenuItem.Click
        If (UsuarioFamiliaForm Is Nothing) Then

            UsuarioFamiliaForm = New Usuario_Familia
            UsuarioFamiliaForm.MdiParent = Me
            AddHandler UsuarioFamiliaForm.FormClosing, AddressOf UsuarioFamiliaForm_close
            UsuarioFamiliaForm.Show()
        Else

            UsuarioFamiliaForm.Activate()
        End If
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click
        If (UsuarioForm Is Nothing) Then

            UsuarioForm = New FrmUsuario
            UsuarioForm.MdiParent = Me
            AddHandler UsuarioForm.FormClosing, AddressOf UsuarioForm_close
            UsuarioForm.Show()
        Else

            UsuarioForm.Activate()
        End If
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BitacoraToolStripMenuItem.Click
        If (BitacoraForm Is Nothing) Then

            BitacoraForm = New Bitacora
            BitacoraForm.MdiParent = Me
            AddHandler BitacoraForm.FormClosing, AddressOf BitacoraForm_close
            BitacoraForm.Show()
        Else

            BitacoraForm.Activate()
        End If
    End Sub

    Private Sub RegenerarDVDeTablasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegenerarDVDeTablasToolStripMenuItem.Click
        If (DVForm Is Nothing) Then

            DVForm = New DV
            DVForm.MdiParent = Me
            AddHandler DVForm.FormClosing, AddressOf DVForm_close
            DVForm.Show()
        Else

            DVForm.Activate()
        End If
    End Sub

    Private Sub SalirDelSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Application.Exit()
    End Sub

    Private Sub MDI_CC_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub OperacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperacionesToolStripMenuItem.Click

    End Sub
    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem.Click
        If (ProductoForm Is Nothing) Then

            ProductoForm = New ActualizadorProducto
            ProductoForm.MdiParent = Me
            AddHandler ProductoForm.FormClosing, AddressOf ProductoForm_close
            ProductoForm.Show()
        Else
            ProductoForm.Activate()
        End If
    End Sub

    Private Sub MDI_CC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DeshabilitarOpcionesMenu()
        HabilitarOpcionesParaUsuario()
        Dim OperacionesMenu As ToolStripMenuItem = MenuStrip.Items("OperacionesToolStripMenuItem")
        Dim OrdenesMenu As ToolStripMenuItem = OperacionesMenu.DropDownItems("OrdenesDeTrabajoToolStripMenuItem")
        OrdenesMenu.Enabled = False
    End Sub
    Private Sub DeshabilitarOpcionesMenu()
        For Each OpcionMenu As ToolStripMenuItem In MenuStrip.Items
            If OpcionMenu.Name <> NoDeshabilitar Then
                OpcionMenu.Enabled = False
            End If
            For Each Subitem As ToolStripMenuItem In OpcionMenu.DropDownItems
                If Subitem.Name <> NoDeshabilitar Then
                    Subitem.Enabled = False
                End If
                For Each SubSubItem As ToolStripMenuItem In Subitem.DropDownItems
                    If SubSubItem.Name <> NoDeshabilitar Then
                        SubSubItem.Enabled = False
                    End If
                Next
            Next
        Next
    End Sub
    Private Sub HabilitarOpcionesParaUsuario()
        Dim _permisosfactory As New ConcretePermisosFactory(Context.idUsuarioActual)
        Dim _permisos As Permisos = _permisosfactory.GetPermisos()
        Dim dt As DataTable
        Dim CantHabilitados As Integer, CantSubItemsHabilitados As Integer
        dt = _permisos.GetPermisosByUsuario(Context.idUsuarioActual)
        For Each OpcionMenu As ToolStripMenuItem In MenuStrip.Items
            'MessageBox.Show("Opcion Menu " + OpcionMenu.Name)
            CantHabilitados = 0
            For Each Subitem As ToolStripMenuItem In OpcionMenu.DropDownItems
                Subitem.Enabled = Utilities.ExistsRecord(dt, "nombre", Subitem.Name)
                CantHabilitados += IIf(Subitem.Enabled, 1, 0)
                CantSubItemsHabilitados = 0
                'MessageBox.Show("subitem " + Subitem.Name)
                For Each SubSubItem As ToolStripMenuItem In Subitem.DropDownItems
                    SubSubItem.Enabled = Utilities.ExistsRecord(dt, "nombre", SubSubItem.Name)
                    CantHabilitados += IIf(SubSubItem.Enabled, 1, 0)
                    CantSubItemsHabilitados += IIf(SubSubItem.Enabled, 1, 0)
                Next
                If CantSubItemsHabilitados > 0 Then
                    Subitem.Enabled = True
                End If
            Next
            If CantHabilitados > 0 Then
                OpcionMenu.Enabled = True
            End If
        Next
        _permisos.Close()
    End Sub

    Private Sub Producto2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (ProductoForm Is Nothing) Then

            ProductoForm = New ActualizadorProducto
            ProductoForm.MdiParent = Me
            AddHandler ProductoForm.FormClosing, AddressOf ProductoForm_close
            ProductoForm.Show()
        Else
            ProductoForm.Activate()
        End If

    End Sub

    Private Sub RestauracionDeInformacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestauracionDeInformacionToolStripMenuItem.Click
        If (RestoreForm Is Nothing) Then

            RestoreForm = New Restore
            RestoreForm.MdiParent = Me
            AddHandler RestoreForm.FormClosing, AddressOf RestoreForm_close
            RestoreForm.Show()
        Else
            RestoreForm.Activate()
        End If

    End Sub

    Private Sub AsignadorUsuarioPermisoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignadorUsuarioPermisoToolStripMenuItem.Click
        If (UsuarioPermisoForm Is Nothing) Then
            UsuarioPermisoForm = New Usuario_Permiso
            UsuarioPermisoForm.MdiParent = Me
            AddHandler UsuarioPermisoForm.FormClosing, AddressOf UsuarioPermisoForm_close
            UsuarioPermisoForm.Show()
        Else
            UsuarioPermisoForm.Activate()
        End If
    End Sub
End Class





