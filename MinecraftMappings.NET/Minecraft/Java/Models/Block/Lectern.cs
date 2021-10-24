using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Lectern : JavaBlockModel
    {
        public Lectern() : base("Lectern")
        {
            AddVersion("lectern", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("top", "block/lectern_top")
                .AddTexture("bottom", "block/oak_planks")
                .AddTexture("base", "block/lectern_base")
                .AddTexture("front", "block/lectern_front")
                .AddTexture("sides", "block/lectern_sides")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 2f, 16f);
                    element.FaceUp = new ModelFace("#base", UVFull) {
                        Rotation = 180,
                    };
                    element.FaceDown = new ModelFace("#bottom", UVFull);
                    element.FaceNorth = new ModelFace("#base") {
                        UV = UVMap(0f, 14f, 16f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#base") {
                        UV = UVMap(0f, 6f, 16f, 8f),
                    };
                    element.FaceWest = new ModelFace("#base") {
                        UV = UVMap(0f, 6f, 16f, 8f),
                    };
                    element.FaceEast = new ModelFace("#base") {
                        UV = UVMap(0f, 6f, 16f, 8f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(4f, 2f, 4f);
                    element.To = new Vector3(12f, 15f, 12f);
                    element.FaceNorth = new ModelFace("#front") {
                        UV = UVMap(0f, 0f, 8f, 13f),
                    };
                    element.FaceSouth = new ModelFace("#front") {
                        UV = UVMap(8f, 3f, 16f, 16f),
                    };
                    element.FaceWest = new ModelFace("#sides") {
                        UV = UVMap(2f, 8f, 15f, 16f),
                        Rotation = 90,
                    };
                    element.FaceEast = new ModelFace("#sides") {
                        UV = UVMap(2f, 16f, 15f, 8f),
                        Rotation = 90,
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0.0125f, 12f, 3f);
                    element.To = new Vector3(15.9875f, 16f, 16f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.X,
                        Angle = -22.5m,
                    };
                    element.FaceUp = new ModelFace("#top") {
                        UV = UVMap(0f, 1f, 16f, 14f),
                        Rotation = 180,
                    };
                    element.FaceDown = new ModelFace("#bottom") {
                        UV = UVMap(0f, 0f, 16f, 13f),
                    };
                    element.FaceNorth = new ModelFace("#sides") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                    };
                    element.FaceSouth = new ModelFace("#sides") {
                        UV = UVMap(0f, 4f, 16f, 8f),
                    };
                    element.FaceWest = new ModelFace("#sides") {
                        UV = UVMap(0f, 4f, 13f, 8f),
                    };
                    element.FaceEast = new ModelFace("#sides") {
                        UV = UVMap(0f, 4f, 13f, 8f),
                    };
                });
        }
    }
}
