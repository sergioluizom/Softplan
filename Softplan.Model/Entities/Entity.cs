using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Softplan.Model.Entities
{
    public class Entity
    {
        private string _id;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_id))
                    _id = Guid.NewGuid().ToString();
                return _id;
            }
            set => _id = value;
        }
    }
}
