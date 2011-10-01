﻿using System;
using System.Collections.Generic;

public class Provider {

    public int ProviderID {get;set;}
    public string Name { get; set; }

    public string CompanyNumber { get; set; }

    public string Address { get; set; }
    public string CP { get; set; }
    public string City { get; set; }

    public string Phone1 { get; set; }
    public string Phone2 { get; set; }

    public string Fax { get; set; }

    public string Email { get; set; }
    
    public virtual ICollection<Purchase> Purchases { get; set; }
}