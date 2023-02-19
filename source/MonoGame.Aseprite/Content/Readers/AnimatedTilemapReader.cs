// /* ----------------------------------------------------------------------------
// MIT License

// Copyright (c) 2018-2023 Christopher Whitley

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// ---------------------------------------------------------------------------- */

// using Microsoft.Xna.Framework.Graphics;
// using MonoGame.Aseprite.RawTypes;
// using MonoGame.Aseprite.Tilemaps;

// namespace MonoGame.Aseprite.Content.Readers;

// /// <summary>
// ///     Defines a reader that reads an <see cref="AnimatedTilemap"/> from a file that was created using the
// ///     <see cref="MonoGame.Aseprite.Content.Writers.RawAnimatedTilemapWriter"/>
// /// </summary>
// /// <seealso cref="MonoGame.Aseprite.Content.Readers"/>
// /// <seealso cref="MonoGame.Aseprite.Content.Writers.RawAnimatedTilemapWriter"/>
// public static class AnimatedTilemapReader
// {
//     /// <summary>
//     ///     Reads an <see cref="AnimatedTilemap"/> fro the file at the specified path that was created using the
//     ///     <see cref="MonoGame.Aseprite.Content.Writers.RawAnimatedTilemapWriter"/>.
//     /// </summary>
//     /// <param name="path">
//     ///     The path and name of the file that contains the <see cref="AnimatedTilemap"/> to read.
//     /// </param>
//     /// <param name="device">
//     ///     The <see cref="Microsoft.Xna.Framework.Graphics.GraphicsDevice"/> used to create graphical resources.
//     ///  </param>
//     /// <returns>
//     ///     The <see cref="AnimatedTilemap"/> that was read.
//     /// </returns>
//     /// <seealso cref="MonoGame.Aseprite.Tilemaps.AnimatedTilemap"/>
//     public static AnimatedTilemap Read(string path, GraphicsDevice device)
//     {
//         Stream stream = File.OpenRead(path);
//         BinaryReader reader = new(stream);
//         return Read(device, reader);
//     }

//     internal static AnimatedTilemap Read(GraphicsDevice device, BinaryReader reader)
//     {
//         RawAnimatedTilemap rawAnimatedTilemap = RawAnimatedTilemapReader.Read(reader);
//         return AnimatedTilemap.FromRaw(device, rawAnimatedTilemap);
//     }
// }
