using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DomainOfModels
{
    public class Forest
    {
        public int ID { get; set; }
        public string ForestName { get; set; }
        public string Biome { get; set; }
        public ICollection<Tree> Trees { get; set; }
        public int Age { get; set; }

        //public Forest()
        //{
        //    Trees = new Collection<Tree>();
        //}
    }
}
