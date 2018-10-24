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

            bool valid = json.IsValid(schema, out IList<string> errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void ObjectEventPassQuantityList()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            bool valid = json.IsValid(schema, out IList<string> errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void ObjectEventPassBoth()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            bool valid = json.IsValid(schema, out IList<string> errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void ObjectEventFailNone()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            bool valid = json.IsValid(schema, out IList<string> errorMessages);

            Assert.False(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void ObjectEventFailQuantityListButNoEpcList()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            bool valid = json.IsValid(schema, out IList<string> errorMessages);

            Assert.False(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void TransactionEventFailNone()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            bool valid = json.IsValid(schema, out IList<string> errorMessages);

            Assert.False(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void TransactionEventFailNoneButActionDeleteWithoutEpcList()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            bool valid = json.IsValid(schema, out IList<string> errorMessages);

            Assert.False(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void TransactionEventFailQuantityListButNoEpcList()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            bool valid = json.IsValid(schema, out IList<string> errorMessages);

            Assert.False(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void TransactionEventPassBoth()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            bool valid = json.IsValid(schema, out IList<string> errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void TransactionEventPassEpcList()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            bool valid = json.IsValid(schema, out IList<string> errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void TransactionEventPassNoneButActionDelete()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            bool valid = json.IsValid(schema, out IList<string> errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }

        [Fact]
        public void TransactionEventPassQuantityList()
        {
            var json = GetJson(GetType().Name, MethodBase.GetCurrentMethod().Name);

            bool valid = json.IsValid(schema, out IList<string> errorMessages);

            Assert.True(valid, errorMessages.FirstOrDefault());
        }
    }
}
