using System;
using Truget.Common.Utils;

namespace Truget.Translators
{
    public class Obj1
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }

    public class Obj2
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Translate<O1, O2> : ITranslator<Obj1, Obj2>
    {

        Obj1 ITranslator<Obj1, Obj2>.Translate(Obj2 from)
        {
            var to = new Obj1
            {
                Id = from.Id,
                FullName = $"{from.FirstName} {from.LastName}"
            };

            return to;
        }

        Obj2 ITranslator<Obj1, Obj2>.Translate(Obj1 from)
        {
            var to = new Obj2
            {
                Id = from.Id,
                FirstName = from.FullName
            };

            return to;
        }
    }

}
