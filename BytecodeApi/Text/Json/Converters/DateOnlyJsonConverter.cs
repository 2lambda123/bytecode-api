﻿using BytecodeApi.Extensions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BytecodeApi.Text.Json.Converters;

/// <summary>
/// Converts JSON values to or from <see cref="DateOnly" /> values.
/// </summary>
public sealed class DateOnlyJsonConverter : JsonConverter<DateOnly>
{
	/// <summary>
	/// Reads and converts the JSON value to a <see cref="DateOnly" /> value.
	/// </summary>
	/// <param name="reader">The <see cref="Utf8JsonReader" /> to read from.</param>
	/// <param name="typeToConvert">This parameter is ignored.</param>
	/// <param name="options">This parameter is ignored.</param>
	/// <returns>
	/// An equivalent <see cref="DateOnly" /> value, parsed from the JSON value.
	/// </returns>
	public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		return DateOnly.Parse(reader.GetString()!);
	}
	/// <summary>
	/// Writes the <see cref="DateOnly" /> value as JSON with the format "yyyy-MM-dd".
	/// </summary>
	/// <param name="writer">The <see cref="Utf8JsonWriter" /> to write to.</param>
	/// <param name="value">The <see cref="DateOnly" /> value to be converted.</param>
	/// <param name="options">This parameter is ignored.</param>
	public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToStringInvariant("yyyy-MM-dd"));
	}
}