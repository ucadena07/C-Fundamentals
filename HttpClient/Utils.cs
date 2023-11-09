using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SomethinElse;

internal class Utils
{
    public static Dictionary<string,List<string>> ExtractErrorsFromWebAPI(string json)
    {
        var resp = new Dictionary<string, List<string>>();
        var deserialized = JsonConvert.DeserializeObject<dynamic>(json);  
        var errorFields = deserialized.errors;
        foreach ( dynamic errorField in errorFields ) {
            var field = errorField.Name;
            var errors = new List<string>();
            foreach (var error in errorField.Value)
            {
                errors.Add(error.ToString());
            }
            resp.Add(field, errors);    
        }

        return resp;
    }
}

