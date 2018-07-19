using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Newtonsoft.Json.Schema;

using Xunit;

namespace EpcisJsonSchemaValidationTests.Required
{
    public class Required : HelperMethods
    {
        [Fact]
        public void BusinessTransactionPass()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            IList<string> errorMessages;
            bool valid = json.IsValid(schema, out errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void BusinessTransactionFailBizTransaction()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            IList<string> errorMessages;
            bool valid = json.IsValid(schema, out errorMessages);

            Assert.False(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void FailEventTime()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            IList<string> errorMessages;
            bool valid = json.IsValid(schema, out errorMessages);

            Assert.False(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void FailEventTimeZoneOffset()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            IList<string> errorMessages;
            bool valid = json.IsValid(schema, out errorMessages);

            Assert.False(valid, errorMessages.FirstOrDefault());
        }
    }
}
