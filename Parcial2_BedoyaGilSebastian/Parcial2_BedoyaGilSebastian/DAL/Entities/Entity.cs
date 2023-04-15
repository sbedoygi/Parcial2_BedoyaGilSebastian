using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Parcial2_BedoyaGilSebastian.DAL.Entities
{
    public class Entity
    {
        [Key]
        public virtual Guid Id { get; set; }


        public virtual DateTime? CreatedDate { get; set; }


        public virtual DateTime? ModifiedDate { get; set; }
    }
}
