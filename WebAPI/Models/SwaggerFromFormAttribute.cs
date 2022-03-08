using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace WebAPI.Models
{
    public class SwaggerFromFormAttribute:Attribute
    {

    }

    public class FromFormOperationFilter:IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters != null)
            {
                bool hasFromFormParam = false;
                var formParams = apiDescription.ActionDescriptor.GetParameters()
                    .Where(p => p.GetCustomAttributes<SwaggerFromFormAttribute>().Any())
                    .Select(p => p.ParameterName);
                operation.parameters
                    .Where(p => formParams.Contains(p.name))
                    .ToList().ForEach(p =>
                    {
                        p.@in = "formData";
                        hasFromFormParam = true;
                    });
                if (hasFromFormParam)
                {
                    List<string> consumes = operation.consumes?.ToList() ?? new List<string>();
                    consumes.Add("application/x-www-form-urlencoded");
                    operation.consumes = consumes;
                }
            }
        }
    }
}