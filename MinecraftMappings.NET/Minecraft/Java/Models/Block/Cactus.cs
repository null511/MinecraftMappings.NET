using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cactus : JavaBlockModel
    {
        public Cactus() : base("Cactus")
        {
            AddVersion("cactus", "1.0.6")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("bottom", "block/cactus_bottom")
                .AddTexture("top", "block/cactus_top")
                .AddTexture("side", "block/cactus_side")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#top",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#bottom",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 1f);
                    element.To = new Vector3(16f, 16f, 15f);
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#side",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(1f, 0f, 0f);
                    element.To = new Vector3(15f, 16f, 16f);
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#side",
                    };
                });
        }
    }
}
