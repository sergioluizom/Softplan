using System;
using System.Collections.Generic;

namespace Softplan.Model.Entities
{
    public class Country : Entity
    {
        public Country()
        {
        }

        public string Name { get; set; }
        public double? Area { get; set; }
        public double? Population { get; set; }
        public string Capital { get; set; }
        public IEnumerable<OfficialLanguage> OfficialLanguages { get; set; }
        public string Address { get; set; }
        public Version Version { get; set; }
        public bool IsApi { get; set; }

        public bool Validate(Country country)
        {
            switch (country.Version)
            {
                case Version.V1:
                    break;
                case Version.V2:
                    if (string.IsNullOrEmpty(country.Address))
                        throw new ArgumentException("This field Address is required");
                    break;
            }
            return true;
        }
    }
    public enum Version
    {
        V1 = 1,
        V2 = 2
    }
}
