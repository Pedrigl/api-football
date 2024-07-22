using api_football.Models.Coaches;
using api_football.Models.Root;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tests.Models.Coaches
{
    [TestClass]
    public class CoachTest
    {
        private string _coachJson;

        [TestInitialize]
        public void Setup()
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var filePath = Path.Combine(projectDirectory, "Data", "Coach", "Coaches.json");
            _coachJson = File.ReadAllText(filePath);
        }

        [TestMethod]
        public void TestCoach()
        {
            var convertedClass = JsonConvert.DeserializeObject<RootCallResult<Coach[]>>(_coachJson);
            Assert.IsNotNull(convertedClass);
            
            var deconvertedJson = JsonConvert.SerializeObject(convertedClass, Formatting.Indented);
            Assert.IsTrue(deconvertedJson == _coachJson);

        }

    }
}
