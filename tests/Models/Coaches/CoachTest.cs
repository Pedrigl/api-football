using api_football.Models.Coaches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests.Models.Coaches
{
    [TestClass]
    public class CoachTest
    {
        private string _coachJson;

        [TestInitialize]
        private void Setup()
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }

        [TestMethod]
        public void TestCoach()
        {


        }

    }
}
