using System;
using System.Collections.Generic;
using System.Text;

namespace Lect12
{
    class UniqueItem
    {
        public static int TotalId { get; set; } = 0;
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
