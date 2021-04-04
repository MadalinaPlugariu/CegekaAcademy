using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab02
{
    public interface ISlotCategory
    {
        public int Allocate();
        public void Deallocate();
    }
}
