﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CURD_API_Application.Models
{
   
    public class Book
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

    }
}
