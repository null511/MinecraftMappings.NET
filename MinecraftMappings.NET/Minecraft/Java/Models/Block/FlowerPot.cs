using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FlowerPot : JavaBlockModel
    {
        public FlowerPot() : base("Flower Pot")
        {
            AddVersion("flower_pot", "1.4.2")
                .WithPath("models/block")
                .AddTexture("flowerpot", "block/flower_pot")
                .AddTexture("dirt", "block/dirt")
                .AddElement(element => {
                    element.From = new Vector3(5f, 0f, 5f);
                    element.To = new Vector3(6f, 6f, 11f);
                    element.FaceUp = new ModelFace("#flowerpot") {
                        UV = UVMap(5f, 5f, 6f, 11f),
                    };
                    element.FaceDown = new ModelFace("#flowerpot") {
                        UV = UVMap(5f, 5f, 6f, 11f),
                    };
                    element.FaceNorth = new ModelFace("#flowerpot") {
                        UV = UVMap(10f, 10f, 11f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#flowerpot") {
                        UV = UVMap(5f, 10f, 6f, 16f),
                    };
                    element.FaceWest = new ModelFace("#flowerpot") {
                        UV = UVMap(5f, 10f, 11f, 16f),
                    };
                    element.FaceEast = new ModelFace("#flowerpot") {
                        UV = UVMap(5f, 10f, 11f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(10f, 0f, 5f);
                    element.To = new Vector3(11f, 6f, 11f);
                    element.FaceUp = new ModelFace("#flowerpot") {
                        UV = UVMap(10f, 5f, 11f, 11f),
                    };
                    element.FaceDown = new ModelFace("#flowerpot") {
                        UV = UVMap(10f, 5f, 11f, 11f),
                    };
                    element.FaceNorth = new ModelFace("#flowerpot") {
                        UV = UVMap(5f, 10f, 6f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#flowerpot") {
                        UV = UVMap(10f, 10f, 11f, 16f),
                    };
                    element.FaceWest = new ModelFace("#flowerpot") {
                        UV = UVMap(5f, 10f, 11f, 16f),
                    };
                    element.FaceEast = new ModelFace("#flowerpot") {
                        UV = UVMap(5f, 10f, 11f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(6f, 0f, 5f);
                    element.To = new Vector3(10f, 6f, 6f);
                    element.FaceUp = new ModelFace("#flowerpot") {
                        UV = UVMap(6f, 5f, 10f, 6f),
                    };
                    element.FaceDown = new ModelFace("#flowerpot") {
                        UV = UVMap(6f, 10f, 10f, 11f),
                    };
                    element.FaceNorth = new ModelFace("#flowerpot") {
                        UV = UVMap(6f, 10f, 10f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#flowerpot") {
                        UV = UVMap(6f, 10f, 10f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(6f, 0f, 10f);
                    element.To = new Vector3(10f, 6f, 11f);
                    element.FaceUp = new ModelFace("#flowerpot") {
                        UV = UVMap(6f, 10f, 10f, 11f),
                    };
                    element.FaceDown = new ModelFace("#flowerpot") {
                        UV = UVMap(6f, 5f, 10f, 6f),
                    };
                    element.FaceNorth = new ModelFace("#flowerpot") {
                        UV = UVMap(6f, 10f, 10f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#flowerpot") {
                        UV = UVMap(6f, 10f, 10f, 16f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(6f, 0f, 6f);
                    element.To = new Vector3(10f, 4f, 10f);
                    element.FaceUp = new ModelFace("#dirt") {
                        UV = UVMap(6f, 6f, 10f, 10f),
                    };
                    element.FaceDown = new ModelFace("#flowerpot") {
                        UV = UVMap(6f, 12f, 10f, 16f),
                    };
                });
        }
    }
}
