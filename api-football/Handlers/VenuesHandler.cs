﻿using api_football.Handlers.Interfaces;
using api_football.Models;
using api_football.Models.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace api_football.Handlers
{
    public class VenuesHandler : GenericHandler, IVenuesHandler
    {
        public VenuesHandler(IHttpClientFactory clientFactory) : base(clientFactory) { }

        public async Task<RootCallResult<Venue[]>> GetVenues(int? id, string? name, string? city, string? country, string? search)
        {
            var url = BuildUrl("venues", new string[] {"id", "name", "city", "country", "search"}, 
                                new Dictionary<string, string> { { "id", id.ToString() }, {"name", name }, { "city", city},
                                                                    {"country", country }, {"search", search} });

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStreamAsync();

            if (response.StatusCode > System.Net.HttpStatusCode.NoContent)
                throw new HttpRequestException((await JsonSerializer.DeserializeAsync<ErrorMessage>(content)).message);
            
            return await JsonSerializer.DeserializeAsync<RootCallResult<Venue[]>>(content);
        }
    }
}