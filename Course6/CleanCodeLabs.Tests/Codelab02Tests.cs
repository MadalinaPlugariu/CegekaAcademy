using System;
using System.IO;
using System.Text;
using CleanCodeLabs.Codelab02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeLabs.Tests
{
    [TestClass]
    public class Codelab02Tests
    {
        private ResourceAllocator _allocator;
        private StringBuilder _fakeOutput;

        [TestInitialize]
        public void Initialize()
        {
            _allocator = new ResourceAllocator();
            _fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(_fakeOutput));
        }

        [TestMethod]
        public void TestAllocateSpaceSlot()
        {
            _allocator.Allocate(ResourceAllocator.SlotCategory.SpaceSlot);
            Assert.IsTrue(_fakeOutput.ToString().StartsWith("Space slot Marked as busy for resourceId = "));
        }

        [TestMethod]
        public void TestDeAllocateSpaceSlot()
        {
            _allocator.Deallocate(ResourceAllocator.SlotCategory.SpaceSlot, 2);
            Assert.IsTrue(_fakeOutput.ToString().StartsWith("Space slot Marked as free for resourceId = 2"));
        }

        [TestMethod]
        public void TestAllocateTimeSlot()
        {
            _allocator.Allocate(ResourceAllocator.SlotCategory.TimeSlot);
            Assert.IsTrue(_fakeOutput.ToString().StartsWith("Time slot Marked as busy for resourceId = "));
        }

        [TestMethod]
        public void TestDeAllocateTimeSlot()
        {
            _allocator.Deallocate(ResourceAllocator.SlotCategory.TimeSlot, 2);
            Assert.IsTrue(_fakeOutput.ToString().StartsWith("Time slot Marked as free for resourceId = 2"));
        }
    }
}