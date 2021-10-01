using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE_19014267
{
    class GameEngine
    {
        private Map _map;

        public Map map
        {
            get { return _map; }
        }

        GameEngine()
        {
            map = new Map();
        }

    }
}
