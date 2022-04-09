using SharpDX;
using System;

namespace MinecraftMappings.Internal.Models
{
    public static class UVHelper
    {
        public static RectangleF UVMap(in float left, in float top, in float right, in float bottom)
        {
            return new RectangleF(left, top, right - left, bottom - top);
        }

        public static void UVMap(in float left, in float top, in float right, in float bottom, out RectangleF region)
        {
            region.Left = left;
            region.Top = top;
            region.Right = right;
            region.Bottom = bottom;
        }

        public static void GetDefaultUv(ModelElement element, in ElementFaces face, out RectangleF region)
        {
            GetDefaultFaceUv(in element.From, in element.To, in face, out region);
        }

        private static void GetDefaultFaceUv(in Vector3 from, in Vector3 to, in ElementFaces face, out RectangleF region)
        {
            switch (face) {
                case ElementFaces.Up:
                    UVMap(from.X, from.Z, to.X, to.Z, out region);
                    break;
                case ElementFaces.Down:
                    UVMap(from.X, to.Z, to.X, from.Z, out region);
                    break;
                case ElementFaces.North:
                    UVMap(to.X, 16f - to.Y, from.X, 16f - from.Y, out region);
                    break;
                case ElementFaces.South:
                    UVMap(from.X, 16f - to.Y, to.X, 16f - from.Y, out region);
                    break;
                case ElementFaces.West:
                    UVMap(from.Z, 16f - to.Y, to.Z, 16f - from.Y, out region);
                    break;
                case ElementFaces.East:
                    UVMap(to.Z, 16f - to.Y, from.Z, 16f - from.Y, out region);
                    break;
                default:
                    throw new ApplicationException($"Unknown element face '{face}'!");
            }
        }

        public static void GetRotatedRegion(in RectangleF uv, in int uvRotation, out RectangleF region)
        {
            switch (uvRotation) {
                case 0:
                    region.Left = uv.Left;
                    region.Top = uv.Top;
                    region.Right = uv.Right;
                    region.Bottom = uv.Bottom;
                    break;
                case 90:
                    region.Left = uv.Bottom;
                    region.Top = uv.Left;
                    region.Right = uv.Top;
                    region.Bottom = uv.Right;
                    break;
                case 180:
                    region.Left = uv.Right;
                    region.Top = uv.Bottom;
                    region.Right = uv.Left;
                    region.Bottom = uv.Top;
                    break;
                case 270:
                    region.Left = uv.Top;
                    region.Top = uv.Right;
                    region.Right = uv.Bottom;
                    region.Bottom = uv.Left;
                    break;
                default:
                    throw new ApplicationException($"Invalid block model texture rotation value '{uvRotation}'!");
            }
        }

        public static string GetElementFaceName(in string elementName, in ElementFaces face)
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
