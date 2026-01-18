namespace FM26_Tactics.Models;

public class Tactic
{
    public string Title { get; set; }
    public string Formation { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }

    // Automatically derived paths based on your requirements
    public string ImagePath => $"images/{Formation}/{Slug.ToLower()}.jpg";
    public string DownloadUrl => $"tactics/{Formation}/{Slug.ToLower()}.fmf";

    public List<PlayerRole> InPossessionRoles { get; set; } = new();
    public List<PlayerRole> OutOfPossessionRoles { get; set; } = new();

    public Dictionary<string, string> InPossessionInstructions { get; set; } = new();
    public Dictionary<string, string> OutOfPossessionInstructions { get; set; } = new();

    public Dictionary<string, List<LeagueTableEntry>> TestResults { get; set; } = new();
}

public class PlayerRole
{
    public string Position { get; set; }
    public string Role { get; set; }
    public string FullName { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public List<string> PlayerInstructions { get; set; } = new();
}

public class LeagueTableEntry
{
    public int Position { get; set; }
    public string TeamName { get; set; }
    public int Pld { get; set; }
    public int Won { get; set; }
    public int Drn { get; set; }
    public int Lst { get; set; }
    public int For { get; set; }
    public double xG { get; set; }
    public int Ag { get; set; }
    public double xGA { get; set; }
    public int Pts { get; set; }
    public double XPTS { get; set; }
    public int GD => For - Ag;
    public double xGD => Math.Round(xG - xGA, 2);
}