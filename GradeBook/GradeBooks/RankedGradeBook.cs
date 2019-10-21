using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook: BaseGradeBook
    {
        //public GradeBookType Ranked;

        public RankedGradeBook(string name): base(name)
        {
            Type = GradeBookType.Ranked;
        }

    }
}
