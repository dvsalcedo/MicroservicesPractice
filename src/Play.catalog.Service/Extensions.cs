﻿using Play.catalog.Service.Entities;
using Play.Catalog.Service.Dtos;

namespace Play.catalog.Service
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto(item.Id, item.Name, item.Description, item.Price, item.CreatedDate);
        }
    }
}
