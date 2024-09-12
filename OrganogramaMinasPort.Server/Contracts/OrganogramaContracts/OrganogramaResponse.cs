namespace OrganogramaMinasPort.Server.Contracts.OrganogramaContracts
{
    public class OrganogramaResponse
    {
        public int Id { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public string Phone { get; set; }
        public string Email {  get; set; }
        public string Team { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
