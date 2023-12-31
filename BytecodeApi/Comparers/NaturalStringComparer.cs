﻿using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace BytecodeApi.Comparers;

/// <summary>
/// Represents a <see cref="string" /> comparison operation that uses natural <see cref="string" /> comparison.
/// </summary>
[SupportedOSPlatform("windows")]
public sealed class NaturalStringComparer : IComparer, IComparer<string>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="NaturalStringComparer" /> class.
	/// </summary>
	public NaturalStringComparer()
	{
	}

	/// <summary>
	/// Compares two <see cref="string" /> objects and returns an indication of their relative sort order. Specified <see cref="object" /> parameters that are not <see cref="string" /> objects are treated as <see langword="null" />.
	/// </summary>
	/// <param name="x">A <see cref="string" /> to compare to <paramref name="y" />.</param>
	/// <param name="y">A <see cref="string" /> to compare to <paramref name="x" />.</param>
	/// <returns>
	/// A signed integer that indicates the relative values of <paramref name="x" /> and <paramref name="y" />.
	/// </returns>
	public int Compare(object? x, object? y)
	{
		return Compare(x as string, y as string);
	}
	/// <summary>
	/// Compares two <see cref="string" /> objects and returns an indication of their relative sort order.
	/// </summary>
	/// <param name="x">A <see cref="string" /> to compare to <paramref name="y" />.</param>
	/// <param name="y">A <see cref="string" /> to compare to <paramref name="x" />.</param>
	/// <returns>
	/// A signed integer that indicates the relative values of <paramref name="x" /> and <paramref name="y" />.
	/// </returns>
	public int Compare(string? x, string? y)
	{
		return Native.StrCmpLogicalW(x ?? "", y ?? "");
	}
}

[SupportedOSPlatform("windows")]
file static class Native
{
	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
	public static extern int StrCmpLogicalW(string strA, string strB);
}