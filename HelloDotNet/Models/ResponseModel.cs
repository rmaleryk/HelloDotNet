﻿using System.Collections.Generic;

namespace HelloDotNet.Models
{
    public class ResponseModel<TModel>
    {
        public List<TModel> Data { get; set; }

        public int TotalCount { get; set; }
    }
}
