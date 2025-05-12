class Project {
    public string FromDate { get; set; } = string.Empty;

    public string ToDate { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Role { get; set; } = string.Empty;

    public string? Description { get; set; }

    public string[] Highlights { get; set; } = Array.Empty<string>();
}