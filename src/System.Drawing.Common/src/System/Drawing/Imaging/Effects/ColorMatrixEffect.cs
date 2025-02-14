﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NET9_0_OR_GREATER

using System.Runtime.Versioning;

namespace System.Drawing.Imaging.Effects;

/// <summary>
///  Color matrix adjustment effect.
/// </summary>
/// <remarks>
///  <para>
///   See <see href="https://learn.microsoft.com/windows/win32/gdiplus/-gdiplus-recoloring-use">Recoloring</see> for
///   examples of using a color matrix to adjust the colors of an image.
///  </para>
/// </remarks>
[RequiresPreviewFeatures]
public unsafe class ColorMatrixEffect : Effect
{
    private readonly ColorMatrix _matrix;

    /// <summary>
    ///  Creates a new <see cref="ColorMatrixEffect"/> with the given <paramref name="matrix"/>.
    /// </summary>
    /// <param name="matrix">Color transform matrix.</param>
    public ColorMatrixEffect(ColorMatrix matrix) : base(PInvoke.ColorMatrixEffectGuid)
    {
        fixed (float* p = &matrix.GetPinnableReference())
        {
            PInvoke.GdipSetEffectParameters(NativeEffect, p, (uint)sizeof(GdiPlus.ColorMatrix)).ThrowIfFailed();
            GC.KeepAlive(this);
        }

        _matrix = matrix;
    }
}
#endif
