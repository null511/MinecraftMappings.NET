using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BellCeiling : JavaBlockModel
    {
        public BellCeiling() : base("Bell Ceiling")
        {
            AddVersion("bell_ceiling", "1.0.0")
                .WithPath("models/block")
                .AddTexture("bar", "block/dark_oak_planks")
                .AddElement(element => {
                    element.From = new Vector3(7f, 13f, 7f);
                    element.To = new Vector3(9f, 16f, 9f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(1f, 3f, 3f, 5f),
                        Texture = "#bar",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(7f, 2f, 9f, 5f),
                        Texture = "#bar",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(6f, 2f, 8f, 5f),
                        Texture = "#bar",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(4f, 2f, 6f, 5f),
                        Texture = "#bar",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(1f, 2f, 3f, 5f),
                        Texture = "#bar",
                    };
                });
        }
    }
}
