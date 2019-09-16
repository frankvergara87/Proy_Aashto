using DbManager.DataObjects;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SIS_Ga2.DataAccess
{
    public class CatalogoDAO
    {

        public List<Catalogo> ListarPorTipo(string Tipo)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@Tipo", Tipo);
                SqlManager objSql = new SqlManager();
                List<Catalogo> lista = objSql.getStatement<Catalogo>("USP_ListarCatalogoPorTipo_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                //Rutina de Guardado en Log 
                //afilogDAO.Save(0, 0, "CatalogoDAO", "GetCatalogoToCombo", ex);
                throw ex;
            }
        }

    }
}
