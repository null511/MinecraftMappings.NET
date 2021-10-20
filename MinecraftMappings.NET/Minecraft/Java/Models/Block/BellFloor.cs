using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BellFloor : JavaBlockModel
    {
        public BellFloor() : base("Bell Floor")
        {
            AddVersion("bell_floor", "1.0.0")
                .WithPath("models/block")
                .AddTexture("bar", "block/dark_oak_planks")
                .AddTexture("post", "block/stone")
                .AddElement(element => {
                    element.From = new Vector3(2f, 13f, 7f);
                    element.To = new Vector3(14f, 15f, 9f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(2f, 3f, 14f, 5f),
                        Texture = "#bar",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(2f, 3f, 14f, 5f),
                        Texture = "#bar",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(2f, 2f, 14f, 4f),
                        Texture = "#bar",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(2f, 3f, 14f, 5f),
                        Texture = "#bar",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(14f, 0f, 6f);
                    element.To = new Vector3(16f, 16f, 10f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(0f, 0f, 2f, 4f),
                        Texture = "#post",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(0f, 0f, 2f, 4f),
                        Texture = "#post",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 1f, 2f, 16f),
                        Texture = "#post",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 1f, 2f, 16f),
                        Texture = "#post",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 1f, 4f, 16f),
                        Texture = "#post",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 1f, 4f, 16f),
                        Texture = "#post",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 6f);
                    element.To = new Vector3(2f, 16f, 10f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(0f, 0f, 2f, 4f),
                        Texture = "#post",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(0f, 0f, 2f, 4f),
                        Texture = "#post",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 1f, 2f, 16f),
                        Texture = "#post",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 1f, 2f, 16f),
                        Texture = "#post",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 1f, 4f, 16f),
                        Texture = "#post",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 1f, 4f, 16f),
                        Texture = "#post",
                    };
                });
        }
    }
}
