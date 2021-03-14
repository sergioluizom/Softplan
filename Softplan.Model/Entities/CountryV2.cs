using System.Collections.Generic;

namespace Softplan.Model.Entities
{
    public class CountryV2 : Country
    {
        public IEnumerable<OfficialLanguage> OfficialLanguages { get; set; }
    }
}
