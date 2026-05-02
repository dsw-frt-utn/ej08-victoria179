using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        public long Code { get;set; }
        public string Description { get; set; } = string.Empty;

        public void SetDescription(string newDescription)
        {
            Description = newDescription;
        }

    }
}
