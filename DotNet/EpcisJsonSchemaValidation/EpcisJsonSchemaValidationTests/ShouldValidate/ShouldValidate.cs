using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

using Xunit;

namespace EpcisJsonSchemaValidationTests
{
    public class ShouldValidate : HelperMethods
    {
        [Fact]
        public void Test1()
        {
            string currentClassName = GetType().Name;
            string currentMethodName = nameof(Test1);

            string fileName = $"{currentClassName}/{currentMethodName}.json";
            JObject o = JObject.Parse(File.ReadAllText(fileName));

            IList<string> errorMessages;
            bool valid = o.IsValid(schema, out errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }
    }
}
