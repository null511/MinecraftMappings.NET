using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BellBetweenWalls : JavaBlockModel
    {
        public BellBetweenWalls() : base("Bell Between Walls")
        {
            AddVersion("bell_between_walls", "1.0.0")
                .WithPath("models/block")
                .AddTexture("bar", "block/dark_oak_planks")
                .AddElement(element => {
                    element.From = new Vector3(0f, 13f, 7f);
                    element.To = new Vector3(16f, 15f, 9f);
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
                    element.FaceWest = new ModelFace {
                        UV = UVMap(5f, 4f, 7f, 6f),
                        Texture = "#bar",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(5f, 4f, 7f, 6f),
                        Texture = "#bar",
                    };
                });
        }
    }
}
