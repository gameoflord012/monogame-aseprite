/* ----------------------------------------------------------------------------
MIT License

Copyright (c) 2018-2023 Christopher Whitley

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
---------------------------------------------------------------------------- */

using Microsoft.Xna.Framework;

namespace MonoGame.Aseprite.AsepriteTypes;

/// <summary>
/// Defines a cel in a frame that contains pixel data.
/// </summary>
public sealed class AsepriteImageCel : AsepriteCel
{
    private Color[] _pixels { get; }

    /// <summary>
    /// Gets a read-only span of the pixel data for this image cel.  Pixel order is from top-to-bottom, read
    /// left-to-right.
    /// </summary>
    public ReadOnlySpan<Color> Pixels => _pixels;

    /// <summary>
    /// Gets the width, in pixels, of this image cel.
    /// </summary>
    public int Width { get; }

    /// <summary>
    /// Gets the height, in pixels, of this image cel.
    /// </summary>
    public int Height { get; }

    internal AsepriteImageCel(int width, int height, Color[] pixels, AsepriteLayer layer, Point position, int opacity)
        : base(layer, position, opacity) => (Width, Height, _pixels) = (width, height, pixels);
}
