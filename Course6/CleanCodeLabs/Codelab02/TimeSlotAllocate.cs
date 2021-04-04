using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab02
{
    class TimeSlotAllocate : ISlotCategory
    {
        int resourceId;
        public int Allocate()
        {
            resourceId = FindFreeTimeSlot();
            MarkTimeSlotBusy(resourceId);

            return resourceId;

        }
        public void Deallocate()
        {
            MarkTimeSlotFree(resourceId);
        }

        private void MarkTimeSlotFree(int resourceId)
        {
            Console.WriteLine("Time slot Marked as free for resourceId = " + resourceId);
        }
        private int FindFreeTimeSlot()
        {
            return new Random().Next() * 50;
        }
        private void MarkTimeSlotBusy(int resourceId)
        {
            Console.WriteLine("Time slot Marked as busy for resourceId = " + resourceId);
        }

        
    }
}
