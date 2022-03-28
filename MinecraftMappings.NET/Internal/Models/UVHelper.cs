using SharpDX;
using System;

namespace MinecraftMappings.Internal.Models
{
    public static class UVHelper
    {
        public static RectangleF UVMap(float left, float top, float right, float bottom)
        {
            return new RectangleF(left, top, right - left, bottom - top);
        }

        public static RectangleF GetDefaultUv(ModelElement element, in ElementFaces face)
        {
            return face switch {
                ElementFaces.Up => UVMap(element.From.X, element.From.Z, element.To.X, element.To.Z),
                ElementFaces.Down => UVMap(element.From.X, element.To.Z, element.To.X, element.From.Z),
                ElementFaces.North => UVMap(element.To.X, element.From.Y, element.From.X, element.To.Y),
                ElementFaces.South => UVMap(element.From.X, element.From.Y, element.To.X, element.To.Y),
                ElementFaces.West => UVMap(element.From.Z, element.From.Y, element.To.Z, element.To.Y),
                ElementFaces.East => UVMap(element.To.Z, element.From.Y, element.From.Z, element.To.Y),
                _ => throw new ApplicationException($"Unknown element face '{face}'!")
            };
        }

        public static RectangleF GetRotatedRegion(in RectangleF uv, in int uvRotation)
        {
            return uvRotation switch {
                0 => new RectangleF {
                    Left = uv.Left,
                    Top = uv.Top,
                    Right = uv.Right,
                    Bottom = uv.Bottom,
                },
                90 => new RectangleF {
                    Left = uv.Bottom,
                    Top = uv.Left,
                    Right = uv.Top,
                    Bottom = uv.Right,
                },
                180 => new RectangleF {
                    Left = uv.Right,
                    Top = uv.Bottom,
                    Right = uv.Left,
                    Bottom = uv.Top,
                },
                270 => new RectangleF {
                    Left = uv.Top,
                    Top = uv.Right,
                    Right = uv.Bottom,
                    Bottom = uv.Left,
                },
                _ => throw new ApplicationException($"Invalid block model texture rotation value '{uvRotation}'!")
            };
        }

        public static string GetFaceName(in string elementName, in ElementFaces face)
        {
            var faceName = GetFaceName(face);
            return $"{elementName}-{faceName}";
        }

        public static string GetFaceName(in ElementFaces face)
        {
            return face switch {
                ElementFaces.Up => "up",
                ElementFaces.Down => "down",
                ElementFaces.North => "north",
                ElementFaces.South => "south",
                ElementFaces.West => "west",
                ElementFaces.East => "east",
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }
}
