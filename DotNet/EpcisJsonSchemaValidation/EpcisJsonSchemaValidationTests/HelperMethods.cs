using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

using Xunit;

namespace EpcisJsonSchemaValidationTests
{
    public class HelperMethods
    {
        public JSchema schema;

        public HelperMethods()
        {
            schema = JSchema.Parse(File.ReadAllText($"json_schema.json"));
        }
    }
}
