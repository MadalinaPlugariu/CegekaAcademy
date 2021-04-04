using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab02
{
    class ErrorWrite: ISlotCategory
    {
        private static readonly int INVALID_RESOURCE_ID = -1;
        int resourceId;
        public int Allocate()
        {
            Console.WriteLine("ERROR: Attempted to allocate invalid resource");
            resourceId = INVALID_RESOURCE_ID;
            return resourceId;

        }

        public void Deallocate()
        {
            Console.WriteLine("ERROR: attempted to free invalid resource");
        }
    }
}
