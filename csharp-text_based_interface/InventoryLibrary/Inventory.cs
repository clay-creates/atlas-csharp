using System;

public class Inventory : BaseClass
{
    public int user_id { get; set; }
    public int item_id { get; set; }

    public int quantity
    {
        get { return _quantity; }
        set { quantity = value >= 0}
    }


}