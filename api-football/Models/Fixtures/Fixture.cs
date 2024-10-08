﻿using api_football.Models.Common;

namespace api_football.Models.Fixtures
{
    public class Fixture
    {
        public required FixtureInfo fixture { get; set; }
        public required FixtureLeague league { get; set; }
        public required FixtureMatch teams { get; set; }
        public GenericHomeAway<int>? goals { get; set; }
        public FixtureScore? score { get; set; }
    }
}
