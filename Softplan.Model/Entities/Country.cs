using System;

namespace Softplan.Model.Entities
{
    public class Country
    {
        public Guid Id { get; set; }
        public decimal Area { get; set; }
        public decimal Population { get; set; }
        public string Capital { get; set; }

    }
}
