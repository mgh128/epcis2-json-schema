using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Newtonsoft.Json.Schema;

using Xunit;

using EpcisJsonSchemaValidationTests;

namespace EpcisJsonSchemaValidationTests.ShouldValidate
{
    public class ShouldValidate : HelperMethods
    {
        [Fact]
        public void Test1()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            IList<string> errorMessages;
            bool valid = json.IsValid(schema, out errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }
    }
}
