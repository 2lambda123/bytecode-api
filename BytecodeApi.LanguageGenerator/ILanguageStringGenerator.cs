﻿namespace BytecodeApi.LanguageGenerator;

/// <summary>
/// Defines base methods for generation of a linguistic <see cref="string" />.
/// </summary>
public interface ILanguageStringGenerator
{
	/// <summary>
	/// Generates a linguistic <see cref="string" />.
	/// </summary>
	/// <returns>
	/// The <see cref="string" /> generated by this instance.
	/// </returns>
	string Generate();
}