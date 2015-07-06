using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCards.BLL
{
    public static class MyExtensionClass
    {
        public static Type GetListType<T>(this List<T> _)
        {
            return typeof (T);
        }

    }
}
