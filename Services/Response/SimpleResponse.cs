﻿using System.Net;

namespace WhosThatPokemon.Services.Response
{
    public class SimpleResponse
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
    }
}
