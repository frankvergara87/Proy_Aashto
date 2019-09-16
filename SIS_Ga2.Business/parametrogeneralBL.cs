using SIS_Ga2.DataAccess;
using SIS_Ga2.Entity;
using System;

namespace SIS_Ga2.Business
{
    public class parametrogeneralBL
    {
        public static parametrogeneral GetParametroGeneral(Int32 idparametrogeneral)
        {
            parametrogeneralDAO parametrogeneraldao = new parametrogeneralDAO();
            return parametrogeneraldao.GetParametroGeneral(idparametrogeneral);
        }

        public static parametrogeneral GetParametroGeneralByEmpresaId(string codigosociedad)
        {
            parametrogeneralDAO parametrogeneraldao = new parametrogeneralDAO();
            return parametrogeneraldao.GetParametroGeneralByEmpresaId(codigosociedad);
        }
        public static parametrogeneral GetParametroGeneralByIdSociedadLogistica(int idSociedadLogistica)
        {
            parametrogeneralDAO parametrogeneraldao = new parametrogeneralDAO();
            return parametrogeneraldao.GetParametroGeneralByIdSociedadLogistica(idSociedadLogistica);
        }


        public static Boolean Save(parametrogeneral entity)
        {
            parametrogeneralDAO parametrogeneraldao = new parametrogeneralDAO();
            return parametrogeneraldao.Save(entity);
        }
    }
}
