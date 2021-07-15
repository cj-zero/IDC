using IDC.Application.SSO;
using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Basics
{
    public class BaseApp
    {
        protected IAuth _auth;

        protected IRepositoryBase _repositoryBase;
        public BaseApp(IAuth auth, IRepositoryBase repositoryBase) 
        {
            _auth = auth;
            _repositoryBase = repositoryBase;
        }
    }
}
