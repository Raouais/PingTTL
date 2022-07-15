using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingTTL.Model {
    public interface Observer {

        void Update(Computer computer,string status);
    }
}
