namespace OrganogramaMinasPort.Server.Domain.Entities
{
    public class Hierarchy : BaseEntity
    {
        public int? EmployeeId { get; set; }
        public int? TeamId { get; set; }
        public string ParentId { get; set; }
    }
}
