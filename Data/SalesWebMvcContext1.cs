using System;

namespace SalesWebMvc.Data
{
    internal class SalesWebMvcContext
    {
        public object Seller { get; internal set; }
        public object SalesRecord { get; internal set; }
        public object Department { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}