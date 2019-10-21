using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        private static readonly GradeBookType Ranked;

        public RankedGradeBook(string name): base(name)
        {
            Type = RankedGradeBook.Ranked;
        }

    }
}
