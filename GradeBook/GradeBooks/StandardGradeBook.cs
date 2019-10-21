﻿using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook: BaseGradeBook
    {
        public static readonly GradeBookType Standard;

        public StandardGradeBook(string name) : base(name)
        {
            Type = StandardGradeBook.Standard;
        }
    }
}
