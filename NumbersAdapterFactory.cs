using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit.Testing._101
{
    public interface INumbersAdapterFactory
    {
        INumberAdapter Create(int type);
    }

    public class NumbersAdapterFactory : INumbersAdapterFactory 
    {
        public INumberAdapter Create(int type)
        {
            return new NumbersAdapter();
        }
    }
}
