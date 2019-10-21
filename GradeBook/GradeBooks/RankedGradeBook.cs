using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook: BaseGradeBook
    {
        public static readonly GradeBookType Ranked;

        public RankedGradeBook(string name): base(name)
        {
            Type = RankedGradeBook.Ranked;
        }

    }
}
