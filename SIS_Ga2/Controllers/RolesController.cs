using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIS_Ga2.Entity;
using SIS_Ga2.Business;
namespace SIS_Ga2.Controllers
{
    public class RolesController : Controller
    {
        RolBL objrol = new RolBL();
        // GET: Cliente
        public ActionResult Index()
        {
            Autorizacionusuario usuario = new Autorizacionusuario();
            usuario = ((Autorizacionusuario)Session["sistema.usuario"]);
            if (usuario == null) return RedirectToAction("Login", "Seguridad");
            List<rol> model = new List<rol>();
            //if (usuario.BESOCIEDAD.CodigoSociedad == null) ViewBag.codigosociedad ="";
            //else ViewBag.codigosociedad = usuario.BESOCIEDAD.CodigoSociedad;

            //List<MenuOpcion> lista = objrol.ListarMenus();

            //List<MenubarOpcion> MenuBar = new List<MenubarOpcion>();
            //MenuBar.AddRange(lista.FindAll(a => a.idPadre == 0).OrderBy(a => a.Jerarquia).Select(b => new MenubarOpcion() { IdMenuOpcion = b.idMenuOpcion, IdMenuOpcion_Padre = 0, Jerarquia = b.Jerarquia, NombreOpcion = b.Nombreopcion, RutaRelativa = b.Rutarelativa, Icono = b.icono, MenubarDetalle = new List<MenubarOpcion>() }).ToList());

            //for (int i = 0; i < MenuBar.Count; i++)
            //{
            //    MenuBar[i] = AddDetalleMenubar(MenuBar[i], lista);

            //}
            //rol rol = new rol();
            //rol.BookViewModel = MenuBar;
            //model.Add(rol);
            //List<Usuario> model = new List<Usuario>();

            //Usuario firstAuthor = new Usuario
            //{
            //    Id = 1,
            //    Name = "John",
            //    BookViewModel = new List<BookViewModel>{
            //        new BookViewModel{
            //            Id=1,
            //            Title = "JQuery",
            //            IsWritten = false
            //        }, new BookViewModel{
            //            Id=1,
            //            Title = "JavaScript",
            //            IsWritten = false
            //        }
            //    }
            //};

            //Usuario secondAuthor = new Usuario
            //{
            //    Id = 2,
            //    Name = "Deo",
            //    BookViewModel = new List<BookViewModel>{
            //        new BookViewModel{
            //            Id=3,
            //            Title = "C#",
            //            IsWritten = false
            //        }, new BookViewModel{
            //            Id=4,
            //            Title = "Entity Framework",
            //            IsWritten = false
            //        }
            //    }
            //};
            //model.Add(firstAuthor);
            //model.Add(secondAuthor);
            return View();
        }


        private static MenubarOpcion AddDetalleMenubar(MenubarOpcion padre, List<MenuOpcion> lista)
        {
            padre.MenubarDetalle.AddRange(lista.FindAll(a => a.idPadre == padre.IdMenuOpcion).OrderBy(a => a.Jerarquia).Select(b => new MenubarOpcion() { IdMenuOpcion = b.idMenuOpcion, IdMenuOpcion_Padre = padre.IdMenuOpcion, Jerarquia = b.Jerarquia, NombreOpcion = b.Nombreopcion, RutaRelativa = b.Rutarelativa, Icono = b.icono, Estado = b.Estado, MenubarDetalle = new List<MenubarOpcion>() }).ToList());
            for (int i = 0; i < padre.MenubarDetalle.Count; i++) padre.MenubarDetalle[i] = AddDetalleMenubar(padre.MenubarDetalle[i], lista);
            return padre;
        }
        public JsonResult ListarRol()
        {
            Autorizacionusuario usuario = new Autorizacionusuario();
            usuario = ((Autorizacionusuario)Session["sistema.usuario"]);
            List<rol> listadorol = objrol.ListarRol();
            //if (usuario.CodigoSociedad.Replace(" ","") != "")  listadorol.RemoveAll(a => a.CodigoSociedad != usuario.CodigoSociedad);
            return Json(listadorol, JsonRequestBehavior.AllowGet);
        }
        public JsonResult RegistroRol(string idsociedad, string codigorol, string nombrerol)
        {
            rol rol = new rol();
            rol.idSociedadLogistica = Convert.ToInt32(idsociedad);
            rol.DescripcionRol = nombrerol;
            rol.CodigoRol = Convert.ToInt32(codigorol);

            bool resultado = objrol.RegistroRol(rol);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }


        public JsonResult ChangeMenuPorAplicacion(string value, string rol,string codigosociedad)
        {
            List<rol> model = new List<rol>();
            List<MenuOpcion> lista = objrol.ChangeMenuPorAplicacion(Convert.ToInt32(value));
            List<MenubarOpcion> MenuBar = new List<MenubarOpcion>();
            List<AuthorViewModel> listado = new List<AuthorViewModel>();

            MenuBar.AddRange(lista.FindAll(a => a.idPadre == 0).OrderBy(a => a.Jerarquia).Select(b => new MenubarOpcion() { IdMenuOpcion = b.idMenuOpcion, IdMenuOpcion_Padre = 0, Jerarquia = b.Jerarquia, NombreOpcion = b.Nombreopcion, RutaRelativa = b.Rutarelativa, Icono = b.icono, MenubarDetalle = new List<MenubarOpcion>() }).ToList());
            for (int i = 0; i < MenuBar.Count; i++)
            {
                AuthorViewModel autor = new AuthorViewModel();
                
                MenuBar[i] = AddDetalleMenubar(MenuBar[i], lista);
                autor.id = Convert.ToString(i + 1);
                autor.pid = "";
                autor.name = MenuBar[i].NombreOpcion;                
                listado.Add(autor);
                for (int j = 0; j < MenuBar[i].MenubarDetalle.Count; j++)
                {

                    AuthorViewModel hijo = new AuthorViewModel();
                    if (rol!=null) hijo.checked_ = objrol.RolSeleccionado(rol, MenuBar[i].MenubarDetalle[j].IdMenuOpcion,codigosociedad);
                    hijo.id = Convert.ToString(MenuBar[i].MenubarDetalle[j].IdMenuOpcion);
                    hijo.pid = Convert.ToString(i + 1);
                    hijo.name = MenuBar[i].MenubarDetalle[j].NombreOpcion;
                    listado.Add(hijo);
                }
            }
            return Json(listado, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GuardarMenuRolAplicacion(string seleccionados, string rol, string aplicacion,string codigosociedad)
        {
            bool resultado = false;
            bool resultadoeliminacion = objrol.EliminacionMenuRolAplicacion(rol,aplicacion,codigosociedad);
            string[] array = seleccionados.Split('|');
            //int idpadre = 0;
            if (seleccionados != null && resultadoeliminacion == true)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    //  int index = padres.FindAll(x => x.Nombreopcion == array[i]).Count;

                    resultado = objrol.GuardarMenuRolAplicacion(array[i], rol, aplicacion,codigosociedad);
                }


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
            }

            return Json(resultado, JsonRequestBehavior.AllowGet);
        }
        public JsonResult EditarFunciones(string rol, string aplicacion)
        {
            List<paginaroles> paginasroles = objrol.EditarFunciones(rol, Convert.ToInt32(aplicacion));
            return Json(paginasroles, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GuardarRolAplicacionFunciones(string seleccionados,string rol,string aplicacion)
        {
            string[] array = seleccionados.Split('|');
            int index = (array.Length - 1) / 5;            
            bool resultado = false;
            string nombremenu ="";
            int contador = 0;
            if (seleccionados != null)
            {               
                for(int i=0;i<index;i++)
                {                      
                    paginaroles paginarol = new paginaroles();
                    for (int j = contador; j < contador+5 ; j++)
                    {
                        string[] array1 = array[j].Split('_');
                        nombremenu = array1[0];
                        if (array1[1] == "FuncionAll") paginarol.FuncionAll = Convert.ToBoolean(array1[2]);
                        else if (array1[1] == "FuncionBorrar") paginarol.FuncionBorrar = Convert.ToBoolean(array1[2]);
                        else if (array1[1] == "FuncionActualiza") paginarol.FuncionActualiza = Convert.ToBoolean(array1[2]);
                        else if (array1[1] == "FuncionIngreso") paginarol.FuncionIngreso = Convert.ToBoolean(array1[2]);
                        else if (array1[1] == "FuncionLectura") paginarol.FuncionLectura = Convert.ToBoolean(array1[2]);
                    }                    
                    resultado = objrol.GuardarRolAplicacionFunciones(nombremenu, paginarol, rol, aplicacion);
                    contador = contador + 5;
                }
            }
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }
       
    }
}