using FM26_Tactics.Models;

namespace FM26_Tactics.Services;

public class TacticService
{
    private readonly List<Tactic> _tactics = new()
    {
        // ==========================================
        // 1. JACKET TACTIC (Current)
        // ==========================================
        new Tactic
        {
            Title = "Jacket",
            Slug = "Jacket",
            Formation = "3-4-3",
            Description = "A waterproof defensive shell that suffocates opponents in the middle third.",
            InPossessionRoles = new() {
                new PlayerRole { Position = "GK", Role = "BGK", FullName = "Ball-Playing Goalkeeper", X = 50, Y = 5, PlayerInstructions = new() { "Dribbling Frequency - Dribble Less" } },
                new PlayerRole { Position = "DCL", Role = "ACB", FullName = "Advanced Centre-Back", X = 25, Y = 28, PlayerInstructions = new() { "Shooting - Shoot Less Often" } },
                new PlayerRole { Position = "DC", Role = "NCB", FullName = "No-Nonsense Center-Back", X = 50, Y = 25 },
                new PlayerRole { Position = "DCR", Role = "OCB", FullName = "Overlapping Centre-Back", X = 75, Y = 28, PlayerInstructions = new() { "Passing Risk - Take Fewer Risks" } },
                new PlayerRole { Position = "WBL", Role = "IWB", FullName = "Inside Wing-Back", X = 38, Y = 45, PlayerInstructions = new() { "Attacking Width - Sit Narrower" } },
                new PlayerRole { Position = "WBR", Role = "IWB", FullName = "Inside Wing-Back", X = 62, Y = 45, PlayerInstructions = new() { "Attacking Width - Sit Narrower" } },
                new PlayerRole { Position = "MC", Role = "CHM", FullName = "Channel Midfielder", X = 50, Y = 58, PlayerInstructions = new() { "Forward Runs - Make More Risks" } },
                new PlayerRole { Position = "AMCL", Role = "AP", FullName = "Advanced Playmaker", X = 35, Y = 78 },
                new PlayerRole { Position = "AML", Role = "W", FullName = "Winger", X = 15, Y = 78 },
                new PlayerRole { Position = "AMR", Role = "PW", FullName = "Playmaking Winger", X = 85, Y = 78 },
                new PlayerRole { Position = "STC", Role = "P", FullName = "Poacher", X = 50, Y = 92 }
            },
            OutOfPossessionRoles = new() {
                new PlayerRole { Position = "GK", Role = "GK", FullName = "Goalkeeper", X = 50, Y = 5, PlayerInstructions = new() { "Tackling - Tackle Harder" } },
                new PlayerRole { Position = "DCL", Role = "CWD", FullName = "Covering Wide Centre-Back", X = 30, Y = 20 },
                new PlayerRole { Position = "DC", Role = "CB", FullName = "Centre-Back", X = 50, Y = 20 },
                new PlayerRole { Position = "DCR", Role = "CWD", FullName = "Covering Wide Centre-Back", X = 70, Y = 20 },
                new PlayerRole { Position = "DML", Role = "SDM", FullName = "Screening Defensive Midfielder", X = 20, Y = 40 },
                new PlayerRole { Position = "DMR", Role = "SDM", FullName = "Screening Defensive Midfielder", X = 80, Y = 40 },
                new PlayerRole { Position = "MCR", Role = "SCM", FullName = "Screening Central Midfielder", X = 60, Y = 55 },
                new PlayerRole { Position = "MCL", Role = "PCM", FullName = "Pressing Central Midfielder", X = 40, Y = 55, PlayerInstructions = new() { "Marking - Mark Tighter" } },
                new PlayerRole { Position = "AML", Role = "WOW", FullName = "Wide Outlet Winger", X = 15, Y = 75 },
                new PlayerRole { Position = "AMR", Role = "TW", FullName = "Tracking Winger", X = 85, Y = 75 },
                new PlayerRole { Position = "STC", Role = "CFD", FullName = "Centre Forward", X = 50, Y = 85 }
            },
            InPossessionInstructions = new() {
                { "Passing Directness", "More Direct" }, { "Tempo", "Much Higher" }, { "Attacking Width", "Much Wider" },
                { "Attacking Transition", "Counter-Attack" }, { "Creative Freedom", "More Expressive" }, { "Time Wasting", "Less Often" },
                { "Play for Set Pieces", "Keep Ball in Play" }, { "Build-up Strategy", "Bypass Press" }, { "Goal Kicks", "Mixed" },
                { "GK Distribution (Speed)", "Distribute Quickly" }, { "GK Distribution", "Flanks" }, { "Supporting Runs", "Balanced" },
                { "Dribbling", "Encourage" }, { "Progress Through", "Both Flanks" }, { "Pass Reception", "Pass Into Space" },
                { "Patience", "Hit Early Crosses" }, { "Shots from Distance", "Encourage" }, { "Crossing Style", "Whipped Crosses" }
            },
            OutOfPossessionInstructions = new() {
                { "Line of Engagement", "High Press" }, { "Defensive Line", "Higher" }, { "Defensive Line Behaviour", "Drop Off More" },
                { "Trigger Press", "Much More Often" }, { "Defensive Transition", "Counter-Press" }, { "Tackling", "Get Stuck In" },
                { "Cross Engagement", "Invite Crosses" }, { "Pressing Trap", "Trap Outside" }, { "Short Goalkeeper Distribution", "No" }
            },
            TestResults = new() {
                { "Manchester City", new() {
                    new LeagueTableEntry { Position = 1, TeamName = "Manchester City", Pld = 38, Won = 32, Drn = 4, Lst = 2, For = 105, xG = 99.2, Ag = 20, xGA = 22.5, Pts = 100, XPTS = 97.4 },
                    new LeagueTableEntry { Position = 2, TeamName = "Arsenal", Pld = 38, Won = 26, Drn = 6, Lst = 6, For = 82, xG = 78.5, Ag = 31, xGA = 33.1, Pts = 84, XPTS = 82.1 }
                } }
            }
        },

        // ==========================================
        // ADD NEW TACTICS HERE (BLANK TEMPLATE BELOW)
        // ==========================================
        //new Tactic
        //{
        //    Title = "Protector",
        //    Slug = "Protector",
        //    Formation = "3-4-3",
        //    Description = "Brief description here.",
        //    InPossessionRoles = new() {
        //        new PlayerRole { Position = "GK", Role = "GK", FullName = "Goalkeeper", X = 50, Y = 5 },
        //        // ... add 10 more players
        //    },
        //    OutOfPossessionRoles = new() {
        //        new PlayerRole { Position = "GK", Role = "GK", FullName = "Goalkeeper", X = 50, Y = 5 },
        //        // ... add 10 more players (Ensure same order as InPossession for smooth sliding)
        //    },
        //    InPossessionInstructions = new() {
        //        { "Passing Directness", "Shorter" }, { "Tempo", "Higher" }, { "Attacking Width", "Fairly Narrow" },
        //        { "Attacking Transition", "Counter" }, { "Creative Freedom", "Disciplined" }, { "Time Wasting", "Never" },
        //        { "Play for Set Pieces", "Yes" }, { "Build-up Strategy", "Play Out Of Defence" }, { "Goal Kicks", "Short" },
        //        { "GK Distribution (Speed)", "Take Short Kicks" }, { "GK Distribution", "Center Backs" }, { "Supporting Runs", "Get Forward" },
        //        { "Dribbling", "Run At Defence" }, { "Progress Through", "Middle" }, { "Pass Reception", "To Feet" },
        //        { "Patience", "Work Ball Into Box" }, { "Shots from Distance", "Shoot Less" }, { "Crossing Style", "Low Crosses" }
        //    },
        //    OutOfPossessionInstructions = new() {
        //        { "Line of Engagement", "Mid Press" }, { "Defensive Line", "Standard" }, { "Defensive Line Behaviour", "Step Up" },
        //        { "Trigger Press", "Often" }, { "Defensive Transition", "Regroup" }, { "Tackling", "Stay On Feet" },
        //        { "Cross Engagement", "Prevent Crosses" }, { "Pressing Trap", "Trap Inside" }, { "Short Goalkeeper Distribution", "Yes" }
        //    },
        //    TestResults = new() { 
        //        { "Test Team Name", new() { 
        //            new LeagueTableEntry { Position = 1, TeamName = "Test Team Name", Pld = 38, Won = 20, Drn = 10, Lst = 8, For = 60, xG = 58.5, Ag = 30, xGA = 32.1, Pts = 70, XPTS = 68.4 }
        //        } } 
        //    }
        //},

        // ==========================================
        // ADD NEW TACTICS HERE (BLANK TEMPLATE BELOW)
        // ==========================================
        /*
        new Tactic
        {
            Title = "Tactic Name",
            Slug = "TacticSlug",
            Formation = "4-4-2",
            Description = "Brief description here.",
            InPossessionRoles = new() {
                new PlayerRole { Position = "GK", Role = "GK", FullName = "Goalkeeper", X = 50, Y = 5 },
                // ... add 10 more players
            },
            OutOfPossessionRoles = new() {
                new PlayerRole { Position = "GK", Role = "GK", FullName = "Goalkeeper", X = 50, Y = 5 },
                // ... add 10 more players (Ensure same order as InPossession for smooth sliding)
            },
            InPossessionInstructions = new() {
                { "Passing Directness", "Shorter" }, { "Tempo", "Higher" }, { "Attacking Width", "Fairly Narrow" },
                { "Attacking Transition", "Counter" }, { "Creative Freedom", "Disciplined" }, { "Time Wasting", "Never" },
                { "Play for Set Pieces", "Yes" }, { "Build-up Strategy", "Play Out Of Defence" }, { "Goal Kicks", "Short" },
                { "GK Distribution (Speed)", "Take Short Kicks" }, { "GK Distribution", "Center Backs" }, { "Supporting Runs", "Get Forward" },
                { "Dribbling", "Run At Defence" }, { "Progress Through", "Middle" }, { "Pass Reception", "To Feet" },
                { "Patience", "Work Ball Into Box" }, { "Shots from Distance", "Shoot Less" }, { "Crossing Style", "Low Crosses" }
            },
            OutOfPossessionInstructions = new() {
                { "Line of Engagement", "Mid Press" }, { "Defensive Line", "Standard" }, { "Defensive Line Behaviour", "Step Up" },
                { "Trigger Press", "Often" }, { "Defensive Transition", "Regroup" }, { "Tackling", "Stay On Feet" },
                { "Cross Engagement", "Prevent Crosses" }, { "Pressing Trap", "Trap Inside" }, { "Short Goalkeeper Distribution", "Yes" }
            },
            TestResults = new() { 
                { "Test Team Name", new() { 
                    new LeagueTableEntry { Position = 1, TeamName = "Test Team Name", Pld = 38, Won = 20, Drn = 10, Lst = 8, For = 60, xG = 58.5, Ag = 30, xGA = 32.1, Pts = 70, XPTS = 68.4 }
                } } 
            }
        },
        */
    };

    public Tactic GetTacticBySlug(string slug) => _tactics.FirstOrDefault(t => t.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
    public List<Tactic> GetTacticsByFormation(string formation) => _tactics.Where(t => t.Formation == formation).ToList();

    // ===================================================================================
    // TACTICAL REFERENCE GUIDE (FOR YOUR REFERENCE WHEN CREATING NEW TACTICS)
    // ===================================================================================

    /*
    POSITIONS AVAILABLE (X/Y Coordinates Guide):
    - GK: X=50, Y=5
    - LB/RB: X=15/85, Y=25 (Defending) or Y=45 (Attacking)
    - CB: X=35/50/65, Y=20-25
    - WBL/WBR: X=20/80, Y=45-50
    - DM: X=40/50/60, Y=35-40
    - MC: X=40/50/60, Y=55-60
    - ML/MR: X=10/90, Y=55-60
    - AMC: X=40/50/60, Y=75-80
    - AML/AMR: X=15/85, Y=75-80
    - ST: X=40/50/60, Y=90-95

    ROLES (In-Possession):
    - GK: GK, BGK, NGK
    - LB/RB: FB, WB, IWB, IFB, PWB
    - DC: CB, ACB, BCB, NCB, WCB, OCB
    - WBL/WBR: WB, AWB, IWB, PWB
    - DM: DM, DLP, HB
    - ML/MR: WMF, W, PW, IW
    - MC: CM, AM, AP, WCM, CHM, MPM
    - AML/AMR: W, IF, PW, WFD, IW
    - AMC: AM, AP, FR, SS, CHM
    - ST: DLF, CFD, TF, P, CHF, F9

    ROLES (Out-of-Possession):
    - GK: GK, SK, LHK
    - LB/RB: FB, PFB, HFB
    - DC: CB, SCB, CCB, WCB, SWD, CWD
    - WBL/WBR: WB, PWB, HWB
    - DM: DM, DDM, PDM, SDM, WDM
    - ML/MR: WMF, TWM, OWM
    - MC: CM, PCM, SCM
    - AML/AMR: W, TW, IOW, WOW
    - AMC: AM, TAM, OAM
    - ST: CFD, TCF, OCF

    TEAM INSTRUCTIONS CATEGORIES (Keys must match these exactly):
    IP - OVERVIEW: Passing Directness, Tempo, Attacking Width, Attacking Transition, Creative Freedom, Time Wasting, Play for Set Pieces
    IP - BUILDUP: Build-up Strategy, Goal Kicks, GK Distribution (Speed), GK Distribution
    IP - PROGRESSION: Supporting Runs, Dribbling, Progress Through, Pass Reception
    IP - FINAL THIRD: Dribbling, Patience, Shots from Distance, Crossing Style

    OOP - OVERVIEW: Line of Engagement, Defensive Line, Defensive Line Behaviour, Trigger Press, Defensive Transition, Tackling
    OOP - LOW BLOCK: Cross Engagement
    OOP - MID BLOCK: Pressing Trap
    OOP - HIGH PRESS: Pressing Trap, Short Goalkeeper Distribution

    PLAYER INSTRUCTION OPTIONS:
    - Dribbling: Dribble More/Less, Run Wide With Ball, Cut Inside With Ball
    - Shooting: Shoot More Often, Shoot Less Often
    - Passing: Shorter, Standard, More Direct, Take More Risks, Take Fewer Risks
    - Movement: Move Into Channels, Stay Wider, Sit Narrower, Roam From Position, Hold Up Ball
    - Defensive: Mark Tighter, Tackle Harder, Ease Off Tackles, Trigger Press More/Less
    */
}