using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperRepositoryLib.Interfaces
{
    public interface IConnectionHelper
    {
        IDbConnection GetConnection();
    }
}
