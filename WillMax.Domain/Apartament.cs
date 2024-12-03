﻿

namespace WillMax.Domain
{
    public  class Apartament
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public double Price { get; set; }
        public string? Image { get; set; }
        public string Description { get; set; }
        public Location? Location { get; set; }
    }
}