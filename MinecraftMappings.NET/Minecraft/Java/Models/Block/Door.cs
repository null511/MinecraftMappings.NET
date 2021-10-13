using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Door : JavaBlockModel
    {
        public Door() : base("Door")
        {
            AddVersion("door", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(3f, 16f, 16f);
                    element.FaceDown = new ModelFace {
                        UV = UVMap(13f, 0f, 16f, 16f),
                        Texture = "#bottom",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(3f, 0f, 0f, 16f),
                        Texture = "#bottom",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 0f, 3f, 16f),
                        Texture = "#bottom",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#bottom",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(16f, 0f, 0f, 16f),
                        Texture = "#bottom",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 16f, 0f);
                    element.To = new Vector3(3f, 32f, 16f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(13f, 0f, 16f, 16f),
                        Texture = "#bottom",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(3f, 0f, 0f, 16f),
                        Texture = "#top",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 0f, 3f, 16f),
                        Texture = "#top",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#top",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(16f, 0f, 0f, 16f),
                        Texture = "#top",
                    };
                });
        }
    }
}
