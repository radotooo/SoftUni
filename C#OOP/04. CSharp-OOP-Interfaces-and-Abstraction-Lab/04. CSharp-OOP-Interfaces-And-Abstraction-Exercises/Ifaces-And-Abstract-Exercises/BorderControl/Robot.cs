using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : IInterface
    {
        public string Model { get; private set; }
        public string Id { get;private  set; }

        public string Birthday { get; private set; }

        public Robot(string model , string id)
        {
            this.Model = model;
            this.Id = id;
            this.Birthday = string.Empty;
        }
    }
}
