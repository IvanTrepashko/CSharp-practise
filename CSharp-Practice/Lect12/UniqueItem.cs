using System;
using System.Collections.Generic;
using System.Text;

namespace Lect12
{
    class UniqueItem
    {
        private static int CurrentID = 0;
        public int Id { get; set; }
        public UniqueItem()
        {
            Id = ++CurrentID;
        }
        public static void SetCurrentID(int x)
        {
            CurrentID = x;
        }
    }
}
