﻿using BytecodeApi.Text;

namespace BytecodeApi.Wpf.Converters;

/// <summary>
/// Represents the converter that converts <see cref="TimeSpan" />? values to a human readable <see cref="string" />. The <see cref="Convert(TimeSpan?)" /> method returns a <see cref="string" /> based on the specified parameters used for the <see cref="Wording.FormatTimeSpan(TimeSpan, int, string)" /> method.
/// </summary>
public sealed class TimeSpanHumanReadableConverter : ConverterBase<TimeSpan?>
{
	/// <summary>
	/// Specifies the maxElements parameter that is passed to the <see cref="Wording.FormatTimeSpan(TimeSpan, int, string)" /> method during conversion.
	/// </summary>
	public int MaxElements { get; set; }
	/// <summary>
	/// Specifies the separator parameter that is passed to the <see cref="Wording.FormatTimeSpan(TimeSpan, int, string)" /> method during conversion.
	/// </summary>
	public string Separator { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="TimeSpanHumanReadableConverter" /> class.
	/// </summary>
	public TimeSpanHumanReadableConverter() : this(Wording.DefaultFormatTimeSpanMaxElements)
	{
	}
	/// <summary>
	/// Initializes a new instance of the <see cref="TimeSpanHumanReadableConverter" /> class with the specified <paramref name="maxElements" /> property.
	/// </summary>
	/// <param name="maxElements">The maxElements parameter that is passed to the <see cref="Wording.FormatTimeSpan(TimeSpan, int, string)" /> method during conversion.</param>
	public TimeSpanHumanReadableConverter(int maxElements) : this(maxElements, Wording.DefaultFormatTimeSpanSeparator)
	{
	}
	/// <summary>
	/// Initializes a new instance of the <see cref="TimeSpanHumanReadableConverter" /> class with the specified <paramref name="maxElements" /> and <paramref name="separator" /> property.
	/// </summary>
	/// <param name="maxElements">The maxElements parameter that is passed to the <see cref="Wording.FormatTimeSpan(TimeSpan, int, string)" /> method during conversion.</param>
	/// <param name="separator">The separator parameter that is passed to the <see cref="Wording.FormatTimeSpan(TimeSpan, int, string)" /> method during conversion.</param>
	public TimeSpanHumanReadableConverter(int maxElements, string separator)
	{
		MaxElements = maxElements;
		Separator = separator;
	}

	/// <summary>
	/// Converts the <see cref="TimeSpan" />? value to a human readable <see cref="string" /> based on the specified parameters used for the <see cref="Wording.FormatTimeSpan(TimeSpan, int, string)" /> method.
	/// </summary>
	/// <param name="value">The <see cref="TimeSpan" />? value to convert.</param>
	/// <returns>
	/// A <see cref="string" /> with the result of the conversion.
	/// </returns>
	public override object? Convert(TimeSpan? value)
	{
		if (value == null)
		{
			return null;
		}
		else
		{
			return Wording.FormatTimeSpan(value.Value, MaxElements, Separator);
		}
	}
}