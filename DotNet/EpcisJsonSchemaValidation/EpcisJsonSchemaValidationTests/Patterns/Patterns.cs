using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Newtonsoft.Json.Schema;

using Xunit;

namespace EpcisJsonSchemaValidationTests.Patterns
{
    public class Patterns : HelperMethods
    {
        [Fact]
        public void QuantityElementPass()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            IList<string> errorMessages;
            bool valid = json.IsValid(schema, out errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void QuantityElementFailUom()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            IList<string> errorMessages;
            bool valid = json.IsValid(schema, out errorMessages);

            Assert.False(valid, errorMessages.FirstOrDefault());
        }
    }
}
