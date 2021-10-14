using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MinecraftMappings.Internal.Models.Entity
{
    public class EntityElement
    {
        public string Name;
        public Vector3 Position;
        public Vector3 Size;
        public Vector2 UV;
        //public Vector2 TextureSize;
        //public ModelElementRotation Rotation;
        public Vector3 RotationOrigin;
        public float RotationAngleX;
        public float RotationAngleY;
        public float RotationAngleZ;
        public bool Rescale;
        public float Inflate;
        public bool InvertAxisX;
        public bool InvertAxisY;
        public bool InvertAxisZ;
        public bool MirrorTextureU;
        public bool MirrorTextureV;

        public List<EntityElement> Elements {get; set;}

        public bool HasRotation => RotationAngleX != 0 || RotationAngleY != 0 || RotationAngleZ != 0;

        public IEnumerable<(ElementFaces face, RectangleF region)> Faces => Enum.GetValues(typeof(ElementFaces))
            .OfType<ElementFaces>().Select(face => (face, GetFaceRectangle(face)));


        //public EntityElement()
        //{
        //    TextureSize = new Vector2(16f, 16f);
        //}

        public RectangleF GetFaceRectangle(ElementFaces face)
        {
            //var lookupFace = face;

            //if (MirrorTextureU) {
            //    if (face == ElementFaces.Up)
            //        lookupFace = ElementFaces.Down;
            //    else if (face == ElementFaces.Down)
            //        lookupFace = ElementFaces.Up;
            //}

            switch (face) {
                case ElementFaces.Up:
                    return new RectangleF(UV.X + Size.Z, UV.Y + Size.Z, Size.X, -Size.Z);
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
