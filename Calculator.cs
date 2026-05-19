public sealed record InjectionScenario(string Title, string Description, string Example);

public static class Calculator
{
    public static int CalculateRiskScore(InjectionScenario scenario)
    {
        ArgumentNullException.ThrowIfNull(scenario);

        var score = 0;

        if (scenario.Description.Contains("High risk", StringComparison.OrdinalIgnoreCase) ||
            scenario.Example.Contains("ignore", StringComparison.OrdinalIgnoreCase) ||
            scenario.Example.Contains("reveal", StringComparison.OrdinalIgnoreCase) ||
            scenario.Example.Contains("disclose", StringComparison.OrdinalIgnoreCase))
        {
            score += 3;
        }

        if (scenario.Title.Contains("Hijack", StringComparison.OrdinalIgnoreCase) ||
            scenario.Title.Contains("Leakage", StringComparison.OrdinalIgnoreCase) ||
            scenario.Title.Contains("Override", StringComparison.OrdinalIgnoreCase))
        {
            score += 2;
        }

        if (scenario.Example.Length > 60)
        {
            score += 1;
        }

        return Math.Max(score, 1);
    }
}

