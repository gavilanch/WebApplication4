using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace WebApplication4.Migrations
{
    public partial class primera : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.DropSequence("DefaultSequence");
            migration.AlterColumn(
                name: "RolID",
                table: "Rol",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:ValueGeneration", "Identity");
            migration.AlterColumn(
                name: "UsuarioID",
                table: "Usuario",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:ValueGeneration", "Identity");
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.CreateSequence(
                name: "DefaultSequence",
                type: "bigint",
                startWith: 1L,
                incrementBy: 10);
            migration.AlterColumn(
                name: "RolID",
                table: "Rol",
                type: "int",
                nullable: false);
            migration.AlterColumn(
                name: "UsuarioID",
                table: "Usuario",
                type: "int",
                nullable: false);
        }
    }
}
