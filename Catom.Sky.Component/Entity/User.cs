using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Catom.Sky.Component.Entity
{
    public class User
    {
        [PrimaryKey]
        public long Id { set; get; }
        public string Name { set; get; }
        public string Pwd { set; get; }
    }
}
