﻿namespace api_football.Models.Players
{
    public class SeasonPlayed
    {
        public SeasonPlayed()
        {
        }
        public int appearences { get; set; }
        public int lineups { get; set; }
        public int minutes { get; set; }
        public int? number { get; set; }
        public string? position { get; set; }
        public string? rating { get; set; }
        public bool captain { get; set; }
    }
}
