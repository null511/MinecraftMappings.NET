using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Comparator : JavaBlockModel
    {
        public Comparator() : base("Comparator")
        {
            AddVersion("comparator", "1.5")
                .WithPath("models/block")
                .AddTexture("slab", "block/smooth_stone")
                .AddTexture("top", "block/comparator")
                .AddTexture("unlit", "block/redstone_torch_off")
                .AddTexture("lit", "block/redstone_torch")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 2f, 16f);
                    element.FaceUp = new ModelFace("#top", UVFull);
                    element.FaceDown = new ModelFace("#slab", UVFull);
                    element.FaceNorth = new ModelFace("#slab") {
                        UV = UVMap(0f, 14f, 16f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#slab") {
                        UV = UVMap(0f, 14f, 16f, 16f),
                    };
                    element.FaceWest = new ModelFace("#slab") {
                        UV = UVMap(0f, 14f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace("#slab") {
                        UV = UVMap(0f, 14f, 16f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(4f, 2f, 11f);
                    element.To = new Vector3(6f, 7f, 13f);
                    element.FaceUp = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 8f),
                    };
                    element.FaceDown = new ModelFace("#unlit") {
                        UV = UVMap(7f, 13f, 9f, 15f),
                    };
                    element.FaceNorth = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 11f),
                    };
                    element.FaceSouth = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 11f),
                    };
                    element.FaceWest = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 11f),
                    };
                    element.FaceEast = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 11f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(10f, 2f, 11f);
                    element.To = new Vector3(12f, 7f, 13f);
                    element.FaceUp = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 8f),
                    };
                    element.FaceDown = new ModelFace("#unlit") {
                        UV = UVMap(7f, 13f, 9f, 15f),
                    };
                    element.FaceNorth = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 11f),
                    };
                    element.FaceSouth = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 11f),
                    };
                    element.FaceWest = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 11f),
                    };
                    element.FaceEast = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 11f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7f, 2f, 2f);
                    element.To = new Vector3(9f, 4f, 4f);
                    element.FaceUp = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 8f),
                    };
                    element.FaceDown = new ModelFace("#unlit") {
                        UV = UVMap(7f, 13f, 9f, 15f),
                    };
                    element.FaceNorth = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 11f),
                    };
                    element.FaceSouth = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 11f),
                    };
                    element.FaceWest = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 11f),
                    };
                    element.FaceEast = new ModelFace("#unlit") {
                        UV = UVMap(7f, 6f, 9f, 11f),
                    };
                });
        }
    }
}
