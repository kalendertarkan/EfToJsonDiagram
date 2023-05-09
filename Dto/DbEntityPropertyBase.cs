using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCore.Diagrams.Dto
{
    public abstract class DbEntityPropertyBase
    {
        public string Name { get; set; }
        
        public string RelatedTableField { get; set; }

        public bool IsNullable { get; internal set; }

        public bool RequiresValueGenerator { get; internal set; }

        public ValueGenerated ValueGenerated { get; internal set; }
    }
}
