using System;
using SalesWebMVC.Views.Models;

namespace SalesWebMVC.Data
{
    internal class SelesRecord
    {
        public static implicit operator SelesRecord(SalesRecord v)
        {
            throw new NotImplementedException();
        }
    }
}