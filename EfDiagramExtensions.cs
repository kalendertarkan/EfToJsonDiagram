using System.Threading.Tasks;
using EntityFrameworkCore.Diagrams.Dto;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EntityFrameworkCore.Diagrams
{
    public class EfDiagramExtensions
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="dbContextModel">var dbContextModel = _dbContext.CreateDbContext().Model</param>
     ///  /// <param name="dbContextModel">var dbContextModel = _dbContext.Model</param>
     /// <returns></returns>
        public Task<string> GetEfToJsonDiagram(IModel dbContextModel)
        {
            var converter = new DtoConverter();
            var dto = converter.ConvertToDto(dbContextModel);
            string json = JsonConvert.SerializeObject(dto, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });

            return Task.FromResult(json);   
        }
    }
}