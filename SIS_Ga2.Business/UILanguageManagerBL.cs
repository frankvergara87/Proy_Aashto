using SIS_Ga2.DataAccess;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace SIS_Ga2.Business
{
    public class UILanguageManagerBL
    {
        public static String GetLanguageCode(Int32 IdIdioma)
        {
            UILanguageManagerDAO dao = new UILanguageManagerDAO();
            return dao.GetLanguageCode(IdIdioma);
        }

        public List<UIElement> listarElementos(Int32 IdUILanguage)
        {
            UILanguageManagerDAO dao = new UILanguageManagerDAO();
            return dao.ListarElementos(IdUILanguage);
        }

    public List<UILanguage> ListarIdiomas()
        {
            UILanguageManagerDAO dao = new UILanguageManagerDAO();
            return dao.ListarIdiomas();
        }

        public bool generarExcel<T>(string nombreexcel, IList<T> lista)
        {
            //aqui haces tu metodo que genera el excel

            foreach (T t in lista)
            {
                foreach (var prop in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public))
                {
                    Console.WriteLine("nombre: {0}, valor: {1}", prop.Name, prop.GetValue(t, null));
                }
            }


            return true;
        }



    }
}
