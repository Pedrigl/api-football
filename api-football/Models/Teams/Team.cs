﻿namespace api_football.Models.Teams
{
    public class Team
    {
        public required TeamInfo team { get; set; }
        public required TeamVenue venue { get; set; }
    }
}
