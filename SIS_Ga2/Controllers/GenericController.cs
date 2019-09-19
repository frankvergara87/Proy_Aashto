using SIS_Ga2.Entity;
using SIS_Ga2.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SIS_Ga2.Controllers
{
    public class GenericController : Controller
    {
        public List<TipoDisenos> ListarTipoDiseno(int idTipoDiseno)
        {
            GenericBL Generico = new GenericBL();
            List<TipoDisenos> Lista = new List<TipoDisenos>();

            //Lista = listado de Tipos de Diseño
            Lista = Generico.ListarTipoDiseno(idTipoDiseno);

            return Lista;
        }

        public List<Reglamentos> ListarReglamento(int idReglamento)
        {
            GenericBL Generico = new GenericBL();
            List<Reglamentos> Lista = new List<Reglamentos>();
            Lista = Generico.ListarReglamentos(idReglamento);
            return Lista;
        }

        public List<Periodo> ListarPeriodos()
        {
            GenericBL Generico = new GenericBL();
            List<Periodo> Lista = new List<Periodo>();
            Lista = Generico.ListarPeriodos();
            return Lista;
        }


        public List<BEPeriodo> ListarComboPeriodos(int idPeriodo)
        {
            BLPeriodos Periodos = new BLPeriodos();
            List<BEPeriodo> Lista = new List<BEPeriodo>();
            Lista = Periodos.ListarPeriodos(idPeriodo);
            return Lista;
        }

        public List<BETasaCrecimiento> ListarComboTasaCrecimiento(int idTasaCrecimiento)
        {
            BLTasaCrecimiento TasaCrecimiento = new BLTasaCrecimiento();
            List<BETasaCrecimiento> Lista = new List<BETasaCrecimiento>();
            Lista = TasaCrecimiento.ListarTasaCrecimiento(idTasaCrecimiento);
            return Lista;
        }

        public List<BETipoPavimento> ListarTipoPavimentos(int idTipoPavimento)
        {
            BLTipoPavimento TipoPavimento = new BLTipoPavimento();
            List<BETipoPavimento> Lista = new List<BETipoPavimento>();
            Lista = TipoPavimento.ListarTipoPavimento(idTipoPavimento);
            return Lista;
        }
        //-----------------------------------------------------------------------------------------------------------

        public IEnumerable<System.Web.Mvc.SelectListItem> ComboFiltro(string value)
        {
            TransportistasBL transportistasBL = new TransportistasBL();
            List<Transportistas> Lista = transportistasBL.obtener_RazonsocialTransportistas();
            List<SelectListItem> data_list = new List<SelectListItem> { new SelectListItem() { Text = string.Format("[{0}]", "SELECCIONAR"), Value = "0" } };
            data_list.AddRange(Lista.OrderBy(a => a.Nombre_Transportista).Select(a => new SelectListItem() { Text = a.Nombre_Transportista.ToUpper(), Value = a.Nombre_Transportista }));

            if (value == "0") return new SelectList(data_list, "Value", "Text");
            else return new SelectList(data_list, "Value", "Text", value);
        }

        public IEnumerable<System.Web.Mvc.SelectListItem> comboidiomas(string codigo)
        {
            UILanguageBL objbl = new UILanguageBL();
            List<UILanguage> listado = new List<UILanguage>();
            UILanguage uilanguague = new UILanguage();
            uilanguague.IdUILanguage = 0;
            listado = objbl.ListarIdiomas(uilanguague);

            List<SelectListItem> data_list = new List<SelectListItem> { new SelectListItem() { Text = string.Format("[{0}]", "SELECCIONAR"), Value = "0" } };
            data_list.AddRange(listado.OrderBy(a => a.IdUILanguage).Select(a => new SelectListItem() { Text = a.LangName.ToUpper(), Value = Convert.ToString(a.IdUILanguage) }));
            if (codigo == "0") return new SelectList(data_list, "Value", "Text");
            else return new SelectList(data_list, "Value", "Text", codigo);
        }

        public IEnumerable<System.Web.Mvc.SelectListItem> combotipoempresa(string value, string codigo)
        {
            CatalogoBL objBL = new CatalogoBL();
            List<Catalogo> Lista = objBL.ListarPorTipo("TIPO_EMPRESA_TRANSPORTISTA");
            List<SelectListItem> data_list = new List<SelectListItem> { new SelectListItem() { Text = string.Format("[{0}]", "SELECCIONAR"), Value = "0" } };
            data_list.AddRange(Lista.OrderBy(a => a.IdCatalogo).Select(a => new SelectListItem() { Text = a.Valor.ToUpper(), Value = a.Codigo }));

            if (codigo == "0") return new SelectList(data_list, "Value", "Text");
            else return new SelectList(data_list, "Value", "Text", codigo);
        }

        public IEnumerable<System.Web.Mvc.SelectListItem> combosociedades(string codigosociedad)
        {
            //Autorizacionusuario usuario = new Autorizacionusuario();
            //usuario = ((Autorizacionusuario)Session["sistema.usuario"]);

            Sociedades_LogisticaBL objsociedad = new Sociedades_LogisticaBL();
            List<Sociedades_Logistica> sociedades = objsociedad.ListarSociedades_Logistica();
            if (codigosociedad != "") sociedades.RemoveAll(a => a.CodigoSociedad != codigosociedad);
            List<SelectListItem> data_list = new List<SelectListItem> { new SelectListItem() { Text = string.Format("[{0}]", "SELECCIONAR"), Value = "0" } };
            data_list.AddRange(sociedades.OrderBy(a => a.idSociedadLogistica).Select(a => new SelectListItem() { Text = a.DescripcionSociedad.ToUpper(), Value = Convert.ToString(a.idSociedadLogistica) }));
            return new SelectList(data_list, "Value", "Text");
        }
        public IEnumerable<System.Web.Mvc.SelectListItem> comboaplicaciones()
        {
            AplicacionBL objaplicacion = new AplicacionBL();
            List<Aplicacion> aplicaciones = objaplicacion.ListarAplicacion();
            List<SelectListItem> data_list = new List<SelectListItem> { new SelectListItem() { Text = string.Format("[{0}]", "SELECCIONAR"), Value = "0" } };
            data_list.AddRange(aplicaciones.OrderBy(a => a.IdAplicacion).Select(a => new SelectListItem() { Text = a.NombreAplicacion.ToUpper(), Value = Convert.ToString(a.IdAplicacion) }));
            return new SelectList(data_list, "Value", "Text");
        }


        //public JsonResult ListarUsuariosByEntidad(String TipoEntidad, String CodigoUnico)
        //{
        //    List<EntidadGenerica> lista = new List<EntidadGenerica>();

        //    List<Autorizacionusuario> listaagd = autorizacionusuarioBL.ListarUsuariosByEntidad(TipoEntidad, CodigoUnico);
        //    lista.AddRange(listaagd.OrderBy(a => a.nombre).Select(a => new EntidadGenerica() { codigounico = a.idautorizacionusuario.ToString(), valor = a.nombre }));

        //    return Json(lista, JsonRequestBehavior.AllowGet);
        //}


        //public JsonResult getEntity(int tipo)
        //{
        //    List<EntidadGenerica> lista = new List<EntidadGenerica>();

        //    if (tipo == 1)
        //    {
        //        //Depositante
        //        ClienteBL objCliente = new ClienteBL();
        //        List<Cliente> listacliente = objCliente.listar();
        //        lista.AddRange(listacliente.OrderBy(a => a.razonsocial).Select(a => new EntidadGenerica() { codigounico = a.codigounico, valor = a.razonsocial }));
        //    }

        //    if (tipo == 2)
        //    {
        //        //Financiador
        //        FinanciadorBL objFinanciador = new FinanciadorBL();
        //        List<Financiador> listafinanciador = objFinanciador.listar();
        //        lista.AddRange(listafinanciador.OrderBy(a => a.razonsocial).Select(a => new EntidadGenerica() { codigounico = a.codigounico, valor = a.razonsocial }));
        //    }

        //    if (tipo == 3)
        //    {
        //        //AGD
        //        AlmacendepositoBL objAlmacenDeposito = new AlmacendepositoBL();
        //        List<Almacendeposito> listaagd = objAlmacenDeposito.listar();
        //        lista.AddRange(listaagd.OrderBy(a => a.razonsocial).Select(a => new EntidadGenerica() { codigounico = a.codigounico, valor = a.razonsocial }));
        //    }

        //    return Json(lista, JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult listar_financiador_autoriza(int tipo)
        //{
        //    List<EntidadGenerica> lista = new List<EntidadGenerica>();

        //    if (tipo == 1)
        //    {
        //        //Depositante
        //        ClienteBL objCliente = new ClienteBL();
        //        List<Cliente> listacliente = objCliente.listar();
        //        lista.AddRange(listacliente.OrderBy(a => a.razonsocial).Select(a => new EntidadGenerica() { codigounico = a.codigounico, valor = a.razonsocial }));
        //    }

        //    if (tipo == 2)
        //    {
        //        //Financiador
        //        FinanciadorBL objFinanciador = new FinanciadorBL();
        //        List<Financiador> listafinanciador = objFinanciador.listar_financiador_autoriza();
        //        lista.AddRange(listafinanciador.OrderBy(a => a.razonsocial).Select(a => new EntidadGenerica() { codigounico = a.codigounico, valor = a.razonsocial }));
        //    }

        //    if (tipo == 3)
        //    {
        //        //Almacenera
        //        AlmacendepositoBL objAlmacenDeposito = new AlmacendepositoBL();
        //        List<Almacendeposito> listaagd = objAlmacenDeposito.listar();
        //        lista.AddRange(listaagd.OrderBy(a => a.razonsocial).Select(a => new EntidadGenerica() { codigounico = a.codigounico, valor = a.razonsocial }));
        //    }

        //    if (tipo == 4)
        //    {
        //        //Almacenes
        //        EmpresaBL empresabl = new EmpresaBL();
        //        List<Empresa> listaagd = empresabl.listar();
        //        lista.AddRange(listaagd.OrderBy(a => a.nombre).Select(a => new EntidadGenerica() { codigounico = a.idempresa.ToString(), valor = a.nombre }));
        //    }

        //    return Json(lista, JsonRequestBehavior.AllowGet);
        //}
    }
}