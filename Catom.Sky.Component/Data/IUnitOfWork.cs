using System;
using System.Data;

namespace Catom.Sky.Component.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IDbConnection Connection { get; }
    }
}
