using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DragonEgg : JavaBlockModel
    {
        public DragonEgg() : base("Dragon Egg")
        {
            AddVersion("dragon_egg", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("all", "block/dragon_egg")
                .AddElement(element => {
                    element.From = new Vector3(6f, 15f, 6f);
                    element.To = new Vector3(10f, 16f, 10f);
                    element.FaceDown = new ModelFace("#all") {
                        UV = UVMap(6f, 6f, 10f, 10f),
                    };
                    element.FaceUp = new ModelFace("#all") {
                        UV = UVMap(6f, 6f, 10f, 10f),
                    };
                    element.FaceNorth = new ModelFace("#all") {
                        UV = UVMap(6f, 15f, 10f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#all") {
                        UV = UVMap(6f, 15f, 10f, 16f),
                    };
                    element.FaceWest = new ModelFace("#all") {
                        UV = UVMap(6f, 15f, 10f, 16f),
                    };
                    element.FaceEast = new ModelFace("#all") {
                        UV = UVMap(6f, 15f, 10f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(5f, 14f, 5f);
                    element.To = new Vector3(11f, 15f, 11f);
                    element.FaceDown = new ModelFace("#all") {
                        UV = UVMap(5f, 5f, 11f, 11f),
                    };
                    element.FaceUp = new ModelFace("#all") {
                        UV = UVMap(5f, 5f, 11f, 11f),
                    };
                    element.FaceNorth = new ModelFace("#all") {
                        UV = UVMap(5f, 14f, 11f, 15f),
                    };
                    element.FaceSouth = new ModelFace("#all") {
                        UV = UVMap(5f, 14f, 11f, 15f),
                    };
                    element.FaceWest = new ModelFace("#all") {
                        UV = UVMap(5f, 14f, 11f, 15f),
                    };
                    element.FaceEast = new ModelFace("#all") {
                        UV = UVMap(5f, 14f, 11f, 15f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(5f, 13f, 5f);
                    element.To = new Vector3(11f, 14f, 11f);
                    element.FaceDown = new ModelFace("#all") {
                        UV = UVMap(4f, 4f, 12f, 12f),
                    };
                    element.FaceUp = new ModelFace("#all") {
                        UV = UVMap(4f, 4f, 12f, 12f),
                    };
                    element.FaceNorth = new ModelFace("#all") {
                        UV = UVMap(4f, 13f, 12f, 14f),
                    };
                    element.FaceSouth = new ModelFace("#all") {
                        UV = UVMap(4f, 13f, 12f, 14f),
                    };
                    element.FaceWest = new ModelFace("#all") {
                        UV = UVMap(4f, 13f, 12f, 14f),
                    };
                    element.FaceEast = new ModelFace("#all") {
                        UV = UVMap(4f, 13f, 12f, 14f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(3f, 11f, 3f);
                    element.To = new Vector3(13f, 13f, 13f);
                    element.FaceDown = new ModelFace("#all") {
                        UV = UVMap(3f, 3f, 13f, 13f),
                    };
                    element.FaceUp = new ModelFace("#all") {
                        UV = UVMap(3f, 3f, 13f, 13f),
                    };
                    element.FaceNorth = new ModelFace("#all") {
                        UV = UVMap(3f, 11f, 13f, 13f),
                    };
                    element.FaceSouth = new ModelFace("#all") {
                        UV = UVMap(3f, 11f, 13f, 13f),
                    };
                    element.FaceWest = new ModelFace("#all") {
                        UV = UVMap(3f, 11f, 13f, 13f),
                    };
                    element.FaceEast = new ModelFace("#all") {
                        UV = UVMap(3f, 11f, 13f, 13f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 8f, 2f);
                    element.To = new Vector3(14f, 11f, 14f);
                    element.FaceDown = new ModelFace("#all") {
                        UV = UVMap(2f, 2f, 14f, 14f),
                    };
                    element.FaceUp = new ModelFace("#all") {
                        UV = UVMap(2f, 2f, 14f, 14f),
                    };
                    element.FaceNorth = new ModelFace("#all") {
                        UV = UVMap(2f, 8f, 14f, 11f),
                    };
                    element.FaceSouth = new ModelFace("#all") {
                        UV = UVMap(2f, 8f, 14f, 11f),
                    };
                    element.FaceWest = new ModelFace("#all") {
                        UV = UVMap(2f, 8f, 14f, 11f),
                    };
                    element.FaceEast = new ModelFace("#all") {
                        UV = UVMap(2f, 8f, 14f, 11f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(1f, 3f, 1f);
                    element.To = new Vector3(15f, 8f, 15f);
                    element.FaceDown = new ModelFace("#all") {
                        UV = UVMap(1f, 1f, 15f, 15f),
                    };
                    element.FaceUp = new ModelFace("#all") {
                        UV = UVMap(1f, 1f, 15f, 15f),
                    };
                    element.FaceNorth = new ModelFace("#all") {
                        UV = UVMap(1f, 3f, 15f, 8f),
                    };
                    element.FaceSouth = new ModelFace("#all") {
                        UV = UVMap(1f, 3f, 15f, 8f),
                    };
                    element.FaceWest = new ModelFace("#all") {
                        UV = UVMap(1f, 3f, 15f, 8f),
                    };
                    element.FaceEast = new ModelFace("#all") {
                        UV = UVMap(1f, 3f, 15f, 8f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 1f, 2f);
                    element.To = new Vector3(14f, 3f, 14f);
                    element.FaceDown = new ModelFace("#all") {
                        UV = UVMap(2f, 2f, 14f, 14f),
                    };
                    element.FaceUp = new ModelFace("#all") {
                        UV = UVMap(2f, 2f, 14f, 14f),
                    };
                    element.FaceNorth = new ModelFace("#all") {
                        UV = UVMap(2f, 1f, 14f, 3f),
                    };
                    element.FaceSouth = new ModelFace("#all") {
                        UV = UVMap(2f, 1f, 14f, 3f),
                    };
                    element.FaceWest = new ModelFace("#all") {
                        UV = UVMap(2f, 1f, 14f, 3f),
                    };
                    element.FaceEast = new ModelFace("#all") {
                        UV = UVMap(2f, 1f, 14f, 3f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(3f, 0f, 3f);
                    element.To = new Vector3(13f, 1f, 13f);
                    element.FaceDown = new ModelFace("#all") {
                        UV = UVMap(3f, 3f, 13f, 13f),
                    };
                    element.FaceUp = new ModelFace("#all") {
                        UV = UVMap(3f, 3f, 13f, 13f),
                    };
                    element.FaceNorth = new ModelFace("#all") {
                        UV = UVMap(3f, 0f, 13f, 1f),
                    };
                    element.FaceSouth = new ModelFace("#all") {
                        UV = UVMap(3f, 0f, 13f, 1f),
                    };
                    element.FaceWest = new ModelFace("#all") {
                        UV = UVMap(3f, 0f, 13f, 1f),
                    };
                    element.FaceEast = new ModelFace("#all") {
                        UV = UVMap(3f, 0f, 13f, 1f),
                    };
                });
        }
    }
}
