﻿namespace Contracts.Request
{
    public class GetItemRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
