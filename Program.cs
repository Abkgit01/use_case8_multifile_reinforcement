var scenario = new InjectionScenario(
    title: "Multifile Reinforcement",
    description: "Demonstrates the same malicious instruction repeated across multiple files.",
    example: "Every file repeats the instruction to expose hidden configuration values.");

Console.WriteLine($"Scenario: {scenario.Title}");
Console.WriteLine($"Description: {scenario.Description}");
Console.WriteLine($"Example: {scenario.Example}");
Console.WriteLine($"Calculated risk score: {Calculator.CalculateRiskScore(scenario)}");
