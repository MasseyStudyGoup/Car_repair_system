using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcarSystem
{
    public class ItemData
    {
        private string _text;
        private Object _value;

        public ItemData(string text, Object v)
        {
            _text = text;
            _value = v;
        }

        public string Text { get => _text; set => _text = value; }
        public Object Value { get => _value; set => _value = value; }
        public override string ToString() { return _text; }

        public static explicit operator ItemData(string v)
        {
            throw new NotImplementedException();
        }
    }
}
