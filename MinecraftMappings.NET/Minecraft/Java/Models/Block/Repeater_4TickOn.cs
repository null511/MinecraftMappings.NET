using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Repeater_4TickOn : JavaBlockModel
    {
        public Repeater_4TickOn() : base("Repeater, 4 Tick On")
        {
            AddVersion("repeater_4tick_on", "1.5")
                .WithPath("models/block")
                .AddTexture("slab", "block/smooth_stone")
                .AddTexture("top", "block/repeater_on")
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
                    element.From = new Vector3(7f, 7f, 12f);
                    element.To = new Vector3(9f, 7f, 14f);
                    element.FaceUp = new ModelFace("#lit") {
                        UV = UVMap(7f, 6f, 9f, 8f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7f, 2f, 11f);
                    element.To = new Vector3(9f, 8f, 15f);
                    element.FaceWest = new ModelFace("#lit") {
                        UV = UVMap(6f, 5f, 10f, 11f),
                    };
                    element.FaceEast = new ModelFace("#lit") {
                        UV = UVMap(6f, 5f, 10f, 11f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(6f, 2f, 12f);
                    element.To = new Vector3(10f, 8f, 14f);
                    element.FaceNorth = new ModelFace("#lit") {
                        UV = UVMap(6f, 5f, 10f, 11f),
                    };
                    element.FaceSouth = new ModelFace("#lit") {
                        UV = UVMap(6f, 5f, 10f, 11f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7f, 7f, 2f);
                    element.To = new Vector3(9f, 7f, 4f);
                    element.FaceUp = new ModelFace("#lit") {
                        UV = UVMap(7f, 6f, 9f, 8f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7f, 2f, 1f);
                    element.To = new Vector3(9f, 8f, 5f);
                    element.FaceWest = new ModelFace("#lit") {
                        UV = UVMap(6f, 5f, 10f, 11f),
                    };
                    element.FaceEast = new ModelFace("#lit") {
                        UV = UVMap(6f, 5f, 10f, 11f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(6f, 2f, 2f);
                    element.To = new Vector3(10f, 8f, 4f);
                    element.FaceNorth = new ModelFace("#lit") {
                        UV = UVMap(6f, 5f, 10f, 11f),
                    };
                    element.FaceSouth = new ModelFace("#lit") {
                        UV = UVMap(6f, 5f, 10f, 11f),
                    };
                });
        }
    }
}
