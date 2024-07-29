using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas11.Contracts
{
    public interface IEmployee
    {
       /// <summary>
       /// Reads employee list from a specified file
       /// </summary>
       /// <returns></returns>
        List<string> ReadData();
        /// <summary>
        /// Writes employee info to a specified file
        /// </summary>
        void WriteData();
    }
}
