using System;

namespace CleanCodeLabs.Codelab02
{
    public class ResourceAllocator 
    {
        ISlotCategory _slotCategory;

        public ResourceAllocator(ISlotCategory slotCat)
        {
            _slotCategory = slotCat;
        }

        public ResourceAllocator()
        {
        }

        public enum SlotCategory
        {
            TimeSlot,
            SpaceSlot
        }

        private static readonly int INVALID_RESOURCE_ID = -1;

        public int Allocate(SlotCategory slotCategory)
        {  
           return _slotCategory.Allocate();
        }

        public void Deallocate(SlotCategory slotCategory, int resourceId)
        {
            _slotCategory.Deallocate();
        }
    }
}