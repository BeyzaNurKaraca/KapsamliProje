using KapsamliProje.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Repos.Abstract
{
    public interface IAuthRepos
    {
        void Register(string UserName, string Password);
        Users Login(string UserName, string Password);
   
    }
}
