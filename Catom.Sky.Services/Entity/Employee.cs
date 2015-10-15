using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Catom.Sky.Services.Entity
{
    public class Employee
    {
        [PrimaryKey]
        public long Id { set; get; }
        public string Num { set; get; }
        public string Name { set; get; }
        public string Tel { set; get; }
        public int Sex { set; get; }
        public int PostId { set; get; }
        public int Level { set; get; }
        public DateTime CreateAt { set; get; }

    }
}
