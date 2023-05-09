# EfToJsonDiagram

            var converter = new EntityFrameworkCore.Diagrams.EfDiagramExtensions();
            var dbContextModel = _dbContext.Model;
            var json = converter.GetEfToJsonDiagram(dbContextModel);
