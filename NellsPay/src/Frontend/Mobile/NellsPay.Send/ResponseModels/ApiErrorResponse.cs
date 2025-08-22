﻿using System;
namespace NellsPay.Send.ResponseModels
{
    public class ApiErrorResponse
    {
        public string Title { get; set; }
        public int Status { get; set; }
        public string Detail { get; set; }
        public string Instance { get; set; }
        public string TraceId { get; set; }
    }
}

