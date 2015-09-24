using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Catom.Sky.Component.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IDbConnection Connection { get; }
    }
}
