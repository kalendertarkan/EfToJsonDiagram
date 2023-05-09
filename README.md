# EfToJsonDiagram

            var converter = new EntityFrameworkCore.Diagrams.EfDiagramExtensions();
            var dbContextModel = _dbContext.Model;
            var json = converter.GetEfToJsonDiagram(dbContextModel);


# Ef Table Colum Propery
 public class ActionLog
    {   
        [Comment("(DbTest / DbProd).dbo.Users.Id")]
        public int UserId { get; set; }
        [Comment("(DbTest / DbProd).dbo.CustomerDealers.Id")]
        public int DealerId { get; set; }
        
    }
    
# Json Example
```json
{
  "entities": [
    {
      "clrType": {
        "namespace": "...Entities",
        "name": "ActionLog"
      },
      "properties": [
        {
          "clrType": {
            "namespace": "System",
            "name": "Int32"
          },
          "name": "Id",
          "relatedTableField": "",
          "isNullable": false,
          "requiresValueGenerator": true,
          "valueGenerated": 1
        },
        {
          "clrType": {
            "namespace": "System",
            "name": "Int32"
          },
          "name": "DealerId",
          "relatedTableField": "(DbTest / DbProd).dbo.CustomerDealers.Id",
          "isNullable": false,
          "requiresValueGenerator": false,
          "valueGenerated": 0
        },
        {
          "clrType": {
            "namespace": "System",
            "name": "Int32"
          },
          "name": "UserId",
          "relatedTableField": "(DbTest / DbProd).dbo.Users.Id",
          "isNullable": false,
          "requiresValueGenerator": false,
          "valueGenerated": 0
        }
      ],
      "keys": [
        {
          "properties": [
            {
              "clrType": {
                "namespace": "System",
                "name": "Int32"
              },
              "name": "Id",
              "relatedTableField": "",
              "isNullable": false,
              "requiresValueGenerator": true,
              "valueGenerated": 1
            }
          ]
        }
      ],
      "foreignKeys": [],
      "indexes": [],
      "name": "...Entities.ActionLog"
    }
  ]
}
