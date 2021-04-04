using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab02
{
    class SpaceSlotAllocate : ISlotCategory
    {
        int resourceId;
        public int Allocate()
        {
            resourceId = FindFreeSpaceSlot();
            MarkSpaceSlotBusy(resourceId);
            return resourceId;
        }

        public void Deallocate()
        {
            MarkSpaceSlotFree(resourceId);
        }

        private void MarkSpaceSlotFree(int resourceId)
        {
            Console.WriteLine("Space slot Marked as free for resourceId = " + resourceId);
        }

        private void MarkSpaceSlotBusy(int resourceId)
        {
            Console.WriteLine("Space slot Marked as busy for resourceId = " + resourceId);
        }
        private int FindFreeSpaceSlot()
        {
            return new Random().Next() * 100;
        }

        
    }
}
