using System;

namespace Softplan.Model.Entities
{
    public class OfficialLanguage : Entity
    {
        public string Iso639_1 { get; set; }
        public string Iso639_2 { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }
        public CountryV2 Country { get; set; }
        public Guid CountryId { get; set; }
    }
}