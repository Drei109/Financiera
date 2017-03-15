using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiera;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Mapeos
{
    public class ClienteMapeo : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapeo()
        {
            ToTable("CLIENTES","FI");
            HasKey(k => k.CodigoCliente);
            Property(p => p.CodigoCliente).HasColumnName("COD_CLIENTE").IsRequired();
            Property(p => p.NombreCliente).HasColumnName("NOM_CLIENTE").IsRequired();
            Property(p => p.FechaNacimiento).HasColumnName("FECHA_CLIENTE").IsRequired();
        }

    }
}
