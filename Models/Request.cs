namespace project_management_system_backend.Models
{
    public class Request
    {
        public string ProjectName { get; set; }
        public int RequirementId { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }  
        public string Description { get; set; }
        public int Attachment { get; set; }



        
    }
}
