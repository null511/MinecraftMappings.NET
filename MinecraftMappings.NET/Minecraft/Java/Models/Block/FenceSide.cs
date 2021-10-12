using MinecraftMappings.Internal.Models;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FenceSide : JavaModelData
    {
        public FenceSide() : base("Fence Side")
        {
            AddVersion("fence_side", "1.0.0")
                .WithPath("models/block")
                .AddElement("top bar", element => {
                    element.From = new Vector3(7f, 12f, 0f);
                    element.To = new Vector3(9f, 15f, 9f);
                    element.FaceUp = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(7f, 0f, 9f, 9f),
                    };
                    element.FaceDown = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(7f, 0f, 9f, 9f),
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(7f, 1f, 9f, 4f),
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(0f, 1f, 9f, 4f),
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(0f, 1f, 9f, 4f),
                    };
                })
                .AddElement("lower bar", element => {
                    element.From = new Vector3(7f, 6f, 0f);
                    element.To = new Vector3(9f, 9f, 9f);
                    element.FaceUp = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(7f, 0f, 9f, 9f),
                    };
                    element.FaceDown = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(7f, 0f, 9f, 9f),
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(7f, 7f, 9f, 10f),
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(0f, 7f, 9f, 10f),
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(0f, 7f, 9f, 10f),
                    };
                });
        }
    }
}
