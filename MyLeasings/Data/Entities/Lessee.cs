﻿using System.Collections.Generic;

namespace MyLeasings.Data.Entities
{
    public class Lessee
    {
        public int Id { get; set; }

        public User User { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
