﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace baeswedding.Models
{
    public class CommentModel
    {
        public int CommentID { get; set; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }
    }
}