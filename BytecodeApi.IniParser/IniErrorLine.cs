﻿namespace BytecodeApi.IniParser;

/// <summary>
/// Represents a line of an <see cref="IniFile" /> that could not be parsed.
/// </summary>
public sealed class IniErrorLine
{
	/// <summary>
	/// Gets the one-based line number of the line at which parsing failed.
	/// </summary>
	public int LineNumber { get; private init; }
	/// <summary>
	/// Gets the line at which parsing failed as its original <see cref="string" /> representation.
	/// </summary>
	public string Line { get; private init; }

	/// <summary>
	/// Initializes a new instance of the <see cref="IniErrorLine" /> class with the specified line number and line.
	/// </summary>
	/// <param name="lineNumber">The one-based line number of the line at which parsing failed.</param>
	/// <param name="line">The line at which parsing failed as its original <see cref="string" /> representation.</param>
	public IniErrorLine(int lineNumber, string line)
	{
		Check.ArgumentNull(line);

		LineNumber = lineNumber;
		Line = line;
	}
}