using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIS_Ga2.Entity;
using SIS_Ga2.Business;
namespace SIS_Ga2.Controllers
{
    public class UsuariosController : Controller
    {
        UsuarioBL objusuario = new UsuarioBL();
        public ActionResult Index()
        {
            Autorizacionusuario usuario = new Autorizacionusuario();
            usuario = ((Autorizacionusuario)Session["sistema.usuario"]);
            if (usuario == null) return RedirectToAction("Login", "Seguridad");
            //if (usuario.BESOCIEDAD.CodigoSociedad == null) ViewBag.codigosociedad = "";
            //else ViewBag.codigosociedad = usuario.BESOCIEDAD.CodigoSociedad;
            return View();
        }
        public JsonResult ListarUsuario()
        {
            Autorizacionusuario usuario = new Autorizacionusuario();
            usuario = ((Autorizacionusuario)Session["sistema.usuario"]);
            List<Usuario> listado = objusuario.ListarUsuario();
            //if (usuario.CodigoSociedad.Replace(" ", "") != "")  listado.RemoveAll(a => a.codigosociedad != null && a.codigosociedad != usuario.CodigoSociedad);
         //   if (usuario.CodigoSociedad.Replace(" ","") != "")  listado.RemoveAll(a => a.codigosociedad != usuario.CodigoSociedad);
            return Json(listado, JsonRequestBehavior.AllowGet);
        }
        public JsonResult RegistroUsuario(string cboidiomas, string cuenta, string clave, string nombre, string apellidos, string dni, string celular, string cargo, string correo, string chkrecibe)
        {
            Usuario usuario = new Usuario();
            usuario.cuenta = cuenta;
            usuario.clave = clave;
            usuario.Nombre = nombre;
            usuario.Apellido = apellidos;
            usuario.DNI = dni;
            usuario.Celular = celular;
            usuario.Cargo = cargo;
            usuario.Correo = correo;
            //usuario.RecibeCorreo = Convert.ToBoolean(chkrecibe);
            bool resultado = objusuario.RegistroUsuario(usuario);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }
        public JsonResult EditarUsuario(string idusuario)
        {
            Usuario usuario = objusuario.EditarUsuario(Convert.ToInt32(idusuario));
            return Json(usuario, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ActualizarUsuario(string cboidiomas, string cuenta, string clave, string nombre, string apellidos, string dni, string celular, string cargo, string correo, string chkrecibe, string idusuario, string chkestado)
        {
            Usuario usuario = new Usuario();
            usuario.cuenta = cuenta;
            usuario.clave = clave;
            usuario.Nombre = nombre;
            usuario.Apellido = apellidos;
            usuario.DNI = dni;
            usuario.Celular = celular;
            usuario.Cargo = cargo;
            usuario.Correo = correo;
            //usuario.RecibeCorreo = Convert.ToBoolean(chkrecibe);
            usuario.Estado = Convert.ToBoolean(chkestado);
            bool resultado = objusuario.ActualizarUsuario(usuario);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ListarRolesPorSociedad(string sociedad,string idusuario)
        {
            List<rol> listado = objusuario.ListarRolesPorSociedad(Convert.ToInt32(sociedad),Convert.ToInt32(idusuario));
            return Json(listado, JsonRequestBehavior.AllowGet);
        }
        public JsonResult AgregarRol(string seleccionados, string idusuario, string cbosociedades)
        {
            string[] array = seleccionados.Split('|');
            bool resultado = false;
            bool resultadodelete = false;
            resultadodelete = objusuario.DeleteRolUsuario(Convert.ToInt32(idusuario), Convert.ToInt32(cbosociedades));
            if (resultadodelete == true)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    resultado = objusuario.AgregarRol(Convert.ToInt32(idusuario), Convert.ToInt32(cbosociedades), Convert.ToInt32(array[i]));
                }
            }
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }
        //public JsonResult RegistroRol(string idsociedad, string codigorol, string nombrerol)
        //{
        //    rol rol = new rol();
        //    rol.idSociedadLogistica = Convert.ToInt32(idsociedad);
        //    rol.DescripcionRol = nombrerol;
        //    rol.CodigoRol = Convert.ToInt32(codigorol);

        //    bool resultado = objrol.RegistroRol(rol);
        //    return Json(resultado, JsonRequestBehavior.AllowGet);
        //}


        //public JsonResult ChangeMenuPorAplicacion(string value, string rol)
        //{
        //    List<rol> model = new List<rol>();
        //    List<MenuOpcion> lista = objrol.ChangeMenuPorAplicacion(Convert.ToInt32(value));
        //    List<MenubarOpcion> MenuBar = new List<MenubarOpcion>();
        //    List<AuthorViewModel> listado = new List<AuthorViewModel>();

        //    MenuBar.AddRange(lista.FindAll(a => a.idPadre == 0).OrderBy(a => a.Jerarquia).Select(b => new MenubarOpcion() { IdMenuOpcion = b.idMenuOpcion, IdMenuOpcion_Padre = 0, Jerarquia = b.Jerarquia, NombreOpcion = b.Nombreopcion, RutaRelativa = b.Rutarelativa, Icono = b.icono, MenubarDetalle = new List<MenubarOpcion>() }).ToList());
        //    for (int i = 0; i < MenuBar.Count; i++)
        //    {
        //        AuthorViewModel autor = new AuthorViewModel();

        //        MenuBar[i] = AddDetalleMenubar(MenuBar[i], lista);
        //        autor.id = Convert.ToString(i + 1);
        //        autor.pid = "";
        //        autor.name = MenuBar[i].NombreOpcion;                
        //        listado.Add(autor);
        //        for (int j = 0; j < MenuBar[i].MenubarDetalle.Count; j++)
        //        {

        //            AuthorViewModel hijo = new AuthorViewModel();
        //            if (rol!=null) hijo.checked_ = objrol.RolSeleccionado(rol, MenuBar[i].MenubarDetalle[j].IdMenuOpcion);
        //            hijo.id = Convert.ToString(MenuBar[i].MenubarDetalle[j].IdMenuOpcion);
        //            hijo.pid = Convert.ToString(i + 1);
        //            hijo.name = MenuBar[i].MenubarDetalle[j].NombreOpcion;
        //            listado.Add(hijo);
        //        }
        //    }
        //    return Json(listado, JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult GuardarMenuRolAplicacion(string seleccionados, string rol, string aplicacion)
        //{
        //    bool resultado = false;
        //    bool resultadoeliminacion = objrol.EliminacionMenuRolAplicacion(rol,aplicacion);
        //    string[] array = seleccionados.Split('|');
        //    //int idpadre = 0;
        //    if (seleccionados != null && resultadoeliminacion == true)
        //    {
        //        for (int i = 0; i < array.Length - 1; i++)
        //        {
        //            //  int index = padres.FindAll(x => x.Nombreopcion == array[i]).Count;

        //            resultado = objrol.GuardarMenuRolAplicacion(array[i], rol, aplicacion);
        //        }


        //List<MenuOpcion> padres = objrol.ListarPadres();
        //for(int i =0;i < array.Length;i++)
        //{
        //    int index = padres.FindAll(x => x.Nombreopcion == array[i]).Count;
        //    int jerarquia = i + 1;
        //    if (index != 0)
        //    {
        //        //ES PADRE
        //        idpadre = objrol.GuardarMenuRolAplicacionPadre(array[i], rol, aplicacion);
        //    }
        //    else if (idpadre != 0)
        //    {
        //        resultado = objrol.GuardarMenuRolAplicacionHijo(array[i], rol, aplicacion, jerarquia, idpadre);
        //    }
        //    else
        //    {
        //        resultado = objrol.GuardarMenuRolAplicacion(array[i], rol, aplicacion, jerarquia);
        //    }
        //}
        //    }

        //    return Json(resultado, JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult EditarFunciones(string rol, string aplicacion)
        //{
        //    List<paginaroles> paginasroles = objrol.EditarFunciones(rol, Convert.ToInt32(aplicacion));
        //    return Json(paginasroles, JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult GuardarRolAplicacionFunciones(string seleccionados,string rol,string aplicacion)
        //{
        //    string[] array = seleccionados.Split('|');
        //    int index = (array.Length - 1) / 5;            
        //    bool resultado = false;
        //    string nombremenu ="";
        //    int contador = 0;
        //    if (seleccionados != null)
        //    {               
        //        for(int i=0;i<index;i++)
        //        {                      
        //            paginaroles paginarol = new paginaroles();
        //            for (int j = contador; j < contador+5 ; j++)
        //            {
        //                string[] array1 = array[j].Split('_');
        //                nombremenu = array1[0];
        //                if (array1[1] == "FuncionAll") paginarol.FuncionAll = Convert.ToBoolean(array1[2]);
        //                else if (array1[1] == "FuncionBorrar") paginarol.FuncionBorrar = Convert.ToBoolean(array1[2]);
        //                else if (array1[1] == "FuncionActualiza") paginarol.FuncionActualiza = Convert.ToBoolean(array1[2]);
        //                else if (array1[1] == "FuncionIngreso") paginarol.FuncionIngreso = Convert.ToBoolean(array1[2]);
        //                else if (array1[1] == "FuncionLectura") paginarol.FuncionLectura = Convert.ToBoolean(array1[2]);
        //            }                    
        //            resultado = objrol.GuardarRolAplicacionFunciones(nombremenu, paginarol, rol, aplicacion);
        //            contador = contador + 5;
        //        }
        //    }
        //    return Json(resultado, JsonRequestBehavior.AllowGet);
        //}

    }
}