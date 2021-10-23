using SharpDX;
using System;
using System.Collections.Generic;

namespace MinecraftMappings.Internal.Models.Entity
{
    public class EntityElementCube
    {
        public Vector3 Position;
        public Vector3 Size;
        public Vector2 UV;
        public float Inflate;

        public static IEnumerable<ElementFaces> Faces => (ElementFaces[])Enum.GetValues(typeof(ElementFaces));


        public RectangleF GetFaceRectangle(ElementFaces face, bool mirrorUvX)
        {
            if (mirrorUvX) {
                switch (face) {
                    case ElementFaces.Up:
                        return new RectangleF(UV.X + Size.Z, UV.Y + Size.Z, Size.X, -Size.Z);
                    case ElementFaces.Down:
                        return new RectangleF(UV.X + Size.Z + 2f * Size.X, UV.Y, -Size.X, Size.Z);
                    case ElementFaces.East:
                        return new RectangleF(UV.X + 2f * Size.Z + Size.X, UV.Y + Size.Z, -Size.Z, Size.Y);
                    case ElementFaces.North:
                        return new RectangleF(UV.X + Size.Z + Size.X, UV.Y + Size.Z, -Size.X, Size.Y);
                    case ElementFaces.West:
                        return new RectangleF(UV.X + Size.Z, UV.Y + Size.Z, -Size.Z, Size.Y);
                    case ElementFaces.South:
                        return new RectangleF(UV.X + 2f * Size.Z + 2f * Size.X, UV.Y + Size.Z, -Size.X, Size.Y);
                    default:
                        throw new ApplicationException($"Unknown element face '{face}'!");
                }
            }
            else {
                switch (face) {
                    case ElementFaces.Up:
                        return new RectangleF(UV.X + Size.Z + Size.X, UV.Y + Size.Z, -Size.X, -Size.Z);
                    case ElementFaces.Down:
                        return new RectangleF(UV.X + Size.Z + Size.X, UV.Y, Size.X, Size.Z);
                    case ElementFaces.East:
                        return new RectangleF(UV.X, UV.Y + Size.Z, Size.Z, Size.Y);
                    case ElementFaces.North:
                        return new RectangleF(UV.X + Size.Z, UV.Y + Size.Z, Size.X, Size.Y);
                    case ElementFaces.West:
                        return new RectangleF(UV.X + Size.Z + Size.X, UV.Y + Size.Z, Size.Z, Size.Y);
                    case ElementFaces.South:
                        return new RectangleF(UV.X + 2f * Size.Z + Size.X, UV.Y + Size.Z, Size.X, Size.Y);
                    default:
                        throw new ApplicationException($"Unknown element face '{face}'!");
                }
            }
        }

        public (float width, float height, float offset) GetWidthHeightOffset(in ElementFaces face)
        {
            switch (face) {
                case ElementFaces.Up:
                case ElementFaces.Down:
                    return (
                        width: Size.X + Inflate,
                        height: Size.Z + Inflate,
                        offset: Size.Y + Inflate);
                case ElementFaces.North:
                case ElementFaces.South:
                    return (
                        width: Size.X + Inflate,
                        height: Size.Y + Inflate,
                        offset: Size.Z + Inflate);
                case ElementFaces.East:
                case ElementFaces.West:
                    return (
                        width: Size.Z + Inflate,
                        height: Size.Y + Inflate,
                        offset: Size.X + Inflate);
                default:
                    throw new ApplicationException($"Unknown element face '{face}'!");
            }
        }
    }
}
