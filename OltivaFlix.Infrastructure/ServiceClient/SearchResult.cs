﻿using OltivaFlix.Domain.Model;
using System.Collections.Generic;

namespace OltivaFlix.Infrastructure.ServiceClient
{
    internal class SearchResult
    {
        public ICollection<Movie> Search { get; set; }
        public int TotalResults { get; set; }
        public bool Result { get; set; }
    }
}