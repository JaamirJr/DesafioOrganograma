﻿namespace OrganogramaMinasPort.Server.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string PositionName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
