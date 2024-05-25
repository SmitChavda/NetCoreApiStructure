using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class HomeService : IHomeService
    {
        public int GetHome()
        {
            return 1;
        }
    }
}
