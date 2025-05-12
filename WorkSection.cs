class WorkSection {
    public string CompanyName { get; set; } = string.Empty;

    public string FromDate { get; set; } = string.Empty;

    public string ToDate { get; set; } = string.Empty;

    public string Role { get; set; } = string.Empty;
    
    public string? Description { get; set; }
    
    public Project[] Projects { get; set; } = Array.Empty<Project>();
}