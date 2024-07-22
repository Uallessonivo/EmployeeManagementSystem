using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Relationship
    {
        // Relationships: One to Many
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
