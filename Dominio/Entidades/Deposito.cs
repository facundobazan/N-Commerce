using Dominio.MetaData;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Deposito")]
    [MetadataType(typeof(IDeposito))]
    public class Deposito : EntidadBase
    {
        // Propiedades
        public string Descripcion { get; set; }

        public string Ubicacion { get; set; }


        // Propiedades de Navegacion
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
