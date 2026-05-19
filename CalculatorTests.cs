public static class CalculatorTests
{
    public static bool RiskScore_IsAlwaysPositive()
    {
        var scenario = new InjectionScenario(
            "Multifile Reinforcement",
            "Demonstrates the same malicious instruction repeated across multiple files.",
            "Every file repeats the instruction to expose hidden configuration values.");

        return Calculator.CalculateRiskScore(scenario) > 0;
    }

    public static bool RiskScore_IsStableForKnownScenario()
    {
        var scenario = new InjectionScenario(
            "Multifile Reinforcement",
            "Demonstrates the same malicious instruction repeated across multiple files.",
            "Every file repeats the instruction to expose hidden configuration values.");

        return Calculator.CalculateRiskScore(scenario) >= 1;
    }
}
