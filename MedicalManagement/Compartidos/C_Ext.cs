using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagement.Compartidos
{
    public static class C_Ext
    {
        /// <summary>
        /// Convierte string a decimal por metodo extension
        /// </summary>
        /// <param name="Value">String para convertir a decimal</param>
        /// <param name="SetValue">Valor que devolvera si algo sale mal Ex para Div /0</param>
        /// <returns>decimal</returns>
        public static decimal ToDecimal(this string Value, decimal SetValue = 0)
        {
            //decimal outValue = SetValue;
            decimal outValue = (decimal.TryParse(Value, out outValue) == true) ? outValue : SetValue;
            return outValue;
        }

        /// <summary>
        /// convierte string a entero
        /// </summary>
        /// <param name="Value">para convertir</param>
        /// <param name="SetValue">devuelve este valor si algo sale mal </param>
        /// <returns></returns>
        public static int ToInt(this string Value, int SetValue = 0)
        {
            //int OutValue = SetValue;
            // parseando el valor
            int OutValue = (int.TryParse(Value, out OutValue) == true) ? OutValue : SetValue;
            return OutValue;
        }

        /*------------------------------------------objeto */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value">valor para convertir</param>
        /// <param name="SetValue">valor que devolvera si algo sale mal</param>
        /// <returns></returns>
        public static int ToIntObj(this object Value, int SetValue = 0)
        {
            if (Value is null)
                Value = "";

            //int OutValue = SetValue;
            // parseando el valor
            int OutValue = (int.TryParse(Value.ToString(), out OutValue)) ? OutValue : SetValue;
            return OutValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value">valor para convertir</param>
        /// <param name="SetValue">valor que devolvera si algo sale mal</param>
        /// <returns></returns>
        public static decimal ToDecObj(this object Value, Decimal SetValue = 0)
        {
            if (Value is null)
                Value = "";

            //decimal outValue = SetValue;
            //parseando el valor
            decimal outValue = (Decimal.TryParse(Value.ToString(), out outValue)) ? outValue : SetValue;
            return outValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value">valor para convertir</param>
        /// <param name="SetValue">valor que devolvera si algo sale mal</param>
        /// <returns></returns>
        public static Double ToDoubleObj(this object Value, Double SetValue = 0)
        {
            if (Value is null)
                Value = "";

            //Double outValue = SetValue;
            //parseando el valor
            Double outValue = (Double.TryParse(Value.ToString(), out outValue)) ? outValue : SetValue;
            return outValue;
        }
    }
}
