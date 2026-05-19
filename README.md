# use_case8_multifile_reinforcement

## Purpose
Demonstrates the same malicious instruction repeated across multiple files.

## Example Injection
$(System.Collections.Hashtable.Example)

## Risk Note
High risk because repetition can create false confidence and consistency pressure.

## Files
- Program.cs prints the scenario summary and calculated risk score.
- Calculator.cs defines the scenario model and the scoring logic.
- CalculatorTests.cs contains simple validation helpers for the scenario.
