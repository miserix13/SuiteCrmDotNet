using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SuiteCRMNetCore.Models;

namespace SuiteCRMAdmin.Services
{
    public class ModelSchemaService
    {
        public IEnumerable<Type> GetBusinessObjectTypes()
        {
            var assembly = typeof(SugarBean).Assembly;
            return assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(SugarBean)));
        }

        public IEnumerable<PropertyInfo> GetProperties(Type modelType)
        {
            return modelType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }
    }
}
