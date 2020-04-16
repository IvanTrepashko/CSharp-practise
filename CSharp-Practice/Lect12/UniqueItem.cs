using System;
using System.Collections.Generic;
using System.Text;

namespace Lect12
{
    class UniqueItem
    {
        private static int TotalId = 0;
        public int Id { get; set; }
        public UniqueItem()
        {
            Id = ++TotalId;
        }
        public static void SetStartID(int x)
        {
            TotalId = x;
        }
    }
}
