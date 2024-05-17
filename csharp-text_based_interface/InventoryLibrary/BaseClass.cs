using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public abstract class BaseClass
    {
        public string Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}