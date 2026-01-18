namespace FM26_Tactics.Models
{
    public class Formation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; } // e.g., "Back 4", "Back 3"
        public string Slug => Name.Replace("-", ""); // Used for URL routing
    }
}