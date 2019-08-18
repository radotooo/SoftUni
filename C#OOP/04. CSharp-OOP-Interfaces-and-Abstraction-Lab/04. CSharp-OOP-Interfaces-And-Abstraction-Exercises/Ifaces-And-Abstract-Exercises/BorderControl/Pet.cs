using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet : IInterface
    {
        public string Birthday { get; private set; }

        public string Name { get; private set; }

        public string Id { get; private set; }

        public Pet(string name , string birth)
        {
            this.Name = name;
            this.Birthday = birth;
            this.Id = string.Empty;
        }
    }
}
