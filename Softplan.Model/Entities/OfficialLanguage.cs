using System;

namespace Softplan.Model.Entities
{
    public class OfficialLanguage : Entity
    {
        public string Iso639_1 { get; set; }
        public string Iso639_2 { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }
        public Country Country { get; set; }
        public string CountryId { get; set; }
    }
}