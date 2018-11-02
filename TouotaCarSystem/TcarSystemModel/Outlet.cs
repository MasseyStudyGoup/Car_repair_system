using System;
using System.Collections.Generic;
using System.Text;

namespace TcarSystem.Model
{
    public class Outlet
    {
        private int _id;
        private string _name;
        private string _address;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }
    }
}
