﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Infrastructure.Entity
{
    public class MovieCast
    {
        public int MovieId { get; set; }
        public int CastId { get; set; }
        public string Character { get; set; }
    }
}
