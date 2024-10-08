﻿namespace api_football.Models.Teams
{
    public class TeamInfo
    {
        public TeamInfo()
        {
        }
        public int id { get; set; }
        public required string name { get; set; }
        public required string code { get; set; }
        public required string country { get; set; }
        public int founded { get; set; }
        public bool national { get; set; }
        public required string logo { get; set; }
    }
}
