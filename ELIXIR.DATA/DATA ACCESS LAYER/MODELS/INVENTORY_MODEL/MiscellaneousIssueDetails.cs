﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.INVENTORY_MODEL;

public class MiscellaneousIssueDetails : BaseEntity
{

    public string Customer {
        get;
        set;
    }
    public string CustomerCode {
        get;
        set;
    }

    public string ItemCode { 
        get; 
        set; 
    }
    public string ItemDescription { 
        get; 
        set; 
    }
    public string Uom { 
        get; 
        set; 
    }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Quantity {
        get;
        set; 
    }

    [Column(TypeName = "Date")]
    public DateTime? ExpirationDate {
        get;
        set;
    }

    public DateTime PreparedDate { 
        get;
        set;
    }

    public string PreparedBy { 
        get;
        set; 
    }

    public int WarehouseId { 
        get; 
        set;
    }
    public int IssuePKey { 
        get; 
        set;
    }
    public string Remarks {
        get;
        set; 
    }
    public bool IsActive {
        get; 
        set; 
    }
    public bool? IsTransact
    {
        get;
        set;
    }
    public decimal? UnitCost
    {
        get;
        set;
    }
    public string SupplierCode { get; set; }
    public string Supplier { get; set; }
}
