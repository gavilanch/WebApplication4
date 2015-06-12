using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using WebApplication4.Models;

namespace WebApplication4.Migrations
{
    [ContextType(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        public override IModel Model
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Identity");
                
                builder.Entity("WebApplication4.Models.Rol", b =>
                    {
                        b.Property<string>("Descripcion")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("NombreRol")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<int>("RolID")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 2)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Key("RolID");
                    });
                
                builder.Entity("WebApplication4.Models.Usuario", b =>
                    {
                        b.Property<bool>("Activo")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("Email")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("NombreUsuario")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<int>("RolID")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<string>("UserPass")
                            .Annotation("OriginalValueIndex", 4);
                        b.Property<int>("UsuarioID")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 5)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Key("UsuarioID");
                    });
                
                builder.Entity("WebApplication4.Models.Usuario", b =>
                    {
                        b.ForeignKey("WebApplication4.Models.Rol", "RolID");
                    });
                
                return builder.Model;
            }
        }
    }
}
