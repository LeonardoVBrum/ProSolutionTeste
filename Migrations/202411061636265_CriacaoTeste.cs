namespace DesafioProSolutionsAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoTeste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArquivosModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeArquivo = c.String(),
                        CaminhoArquivo = c.String(),
                        TamanhoArquivo = c.Long(nullable: false),
                        DataUpload = c.DateTime(nullable: false),
                        TipoArquivo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ArquivosModels");
        }
    }
}
