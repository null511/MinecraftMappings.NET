using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Repeater_1TickLocked : JavaBlockModel
    {
        public Repeater_1TickLocked() : base("Repeater, 1 Tick Locked")
        {
            AddVersion("repeater_1tick_locked", "1.5")
                .WithPath("models/block")
                .AddTexture("slab", "block/smooth_stone")
                .AddTexture("top", "block/repeater")
                .AddTexture("lock", "block/bedrock")
                .AddTexture("unlit", "block/redstone_torch_off")
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
                    element.From = new Vector3(2f, 2f, 6f);
                    element.To = new Vector3(14f, 4f, 8f);
                    element.FaceUp = new ModelFace("#lock") {
                        UV = UVMap(7f, 2f, 9f, 14f),
                        Rotation = 90,
                    };
                    element.FaceDown = new ModelFace("#lock") {
                        UV = UVMap(7f, 2f, 9f, 14f),
                        Rotation = 90,
                    };
                    element.FaceNorth = new ModelFace("#lock") {
                        UV = UVMap(2f, 7f, 14f, 9f),
                    };
                    element.FaceSouth = new ModelFace("#lock") {
                        UV = UVMap(2f, 7f, 14f, 9f),
                    };
                    element.FaceWest = new ModelFace("#lock") {
                        UV = UVMap(6f, 7f, 8f, 9f),
                    };
                    element.FaceEast = new ModelFace("#lock") {
                        UV = UVMap(6f, 7f, 8f, 9f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7f, 2f, 2f);
                    element.To = new Vector3(9f, 7f, 4f);
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
