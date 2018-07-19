using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Newtonsoft.Json.Schema;

using Xunit;

namespace EpcisJsonSchemaValidationTests.AnyOfEpcQuantity
{
    public class AnyOfEpcQuantity : HelperMethods
    {
        [Fact]
        public void ObjectEventPassEpcList()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            IList<string> errorMessages;
            bool valid = json.IsValid(schema, out errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void ObjectEventPassQuantityList()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            IList<string> errorMessages;
            bool valid = json.IsValid(schema, out errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void ObjectEventPassBoth()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            IList<string> errorMessages;
            bool valid = json.IsValid(schema, out errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void ObjectEventFailNone()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            IList<string> errorMessages;
            bool valid = json.IsValid(schema, out errorMessages);

            Assert.False(valid, errorMessages.FirstOrDefault());
        }
    }
}
