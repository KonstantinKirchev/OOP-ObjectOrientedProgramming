﻿using System;

namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface ISale
    {
        string ProductName { get; set; }

        DateTime Date { get; set; }

        decimal Price { get; set; }
    }
}
