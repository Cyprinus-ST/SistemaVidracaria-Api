﻿using System;

namespace Api.Domain.Entities.Material
{
    public class MaterialEntity : BaseEntity
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public Guid IdUser { get; set; }
    }
}
