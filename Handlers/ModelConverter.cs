using NG_React_JS_Att.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NG_React_JS_Att.Handlers
{
    

    public static class ModelConverter<From, To> where From : IModelConvertable, To 
    {
        //public static To Convert(From from)
        //{
        //    return To.
        //}
    }
}
