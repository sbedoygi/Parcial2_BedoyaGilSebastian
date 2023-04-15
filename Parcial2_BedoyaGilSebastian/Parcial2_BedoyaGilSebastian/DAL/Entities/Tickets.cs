using System.ComponentModel.DataAnnotations;

namespace Parcial2_BedoyaGilSebastian.DAL.Entities
{
    public class Tickets: Entity
    {
        [Display(Name = "ingrese la Fecha de uso de la voleta")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime UseDate  { get; set; }

        [Display(Name = " Si la boleta fue usada o no")]
        public bool IsUsed { get; set; }

        [Display(Name = "Confirme Portería por la que entró la persona ")] //Nombre que quiero mostrar en la web
        [MaxLength(50)] //varchar(50)
        [Required(ErrorMessage = "El campo {0} es obligatorio")] //Not Null
        public string EntranceGate { get; set; }




    }
}
