using Dominio.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Comprobante_NotaCredito")]
    [MetadataType(typeof(INotaCredito))]
    public class NotaCredito : Comprobante
    {
        // Propiedades
        public long ComprobanteId { get; set; }

        // Propiedades de Navegacion
        public virtual Comprobante Comprobante { get; set; }
    }
}