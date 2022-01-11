using System;
using System.Collections.Generic;

namespace FrontToBack.Models
{
    public class CATEGORY1
    {
        public int Id { get; set; }

        public string Name{ get; set; }

        public string DataId{ get; set; }

        public ICollection<PRODUCTS1> pRODUCTS1s { get; set; }
    }
}