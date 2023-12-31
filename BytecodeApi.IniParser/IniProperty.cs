﻿using BytecodeApi.Extensions;
using System.Diagnostics;

namespace BytecodeApi.IniParser;

/// <summary>
/// Represents a property of an <see cref="IniFile" />.
/// </summary>
[DebuggerDisplay($"{nameof(IniProperty)}: Name = {{Name}}, Value = {{Value}}")]
public sealed class IniProperty
{
	/// <summary>
	/// Gets or sets the name of this INI property.
	/// </summary>
	public string Name { get; set; }
	/// <summary>
	/// Gets or sets the value of this INI property.
	/// </summary>
	public string Value { get; set; }
	/// <summary>
	/// Gets or sets the parsed <see cref="int" /> value of the <see cref="Value" /> property. If conversion fails, <see langword="null" /> is returned. Assigning a value sets the <see cref="Value" /> property by converting the value to a <see cref="string" />.
	/// </summary>
	public int? Int32Value
	{
		get => Value?.ToInt32OrNull();
		set => Value = value?.ToString() ?? "";
	}
	/// <summary>
	/// Gets or sets the parsed <see cref="long" /> value of the <see cref="Value" /> property. If conversion fails, <see langword="null" /> is returned. Assigning a value sets the <see cref="Value" /> property by converting the value to a <see cref="string" />.
	/// </summary>
	public long? Int64Value
	{
		get => Value?.ToInt64OrNull();
		set => Value = value?.ToString() ?? "";
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="IniProperty" /> class with the specified name and value.
	/// </summary>
	/// <param name="name">A <see cref="string" /> value specifying the name of this INI property.</param>
	/// <param name="value">A <see cref="string" /> value specifying the value of this INI property.</param>
	public IniProperty(string name, string value)
	{
		Check.ArgumentNull(name);
		Check.ArgumentNull(value);

		Name = name;
		Value = value;
	}
}