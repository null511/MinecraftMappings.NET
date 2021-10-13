using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Bamboo1_Age1 : JavaBlockModel
    {
        public Bamboo1_Age1() : base("Bamboo 1, Age 1")
        {
            AddVersion("bamboo1_age1", "1.14")
                .WithPath("models/block")
                .AddTexture("all", "block/bamboo_stalk")
                .AddElement(element => {
                    element.From = new Vector3(6.5f, 0f, 6.5f);
                    element.To = new Vector3(9.5f, 16f, 9.5f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(13f, 0f, 16f, 3f),
                        Texture = "#all",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(13f, 4f, 16f, 7f),
                        Texture = "#all",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 0f, 3f, 16f),
                        Texture = "#all",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 0f, 3f, 16f),
                        Texture = "#all",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 0f, 3f, 16f),
                        Texture = "#all",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 0f, 3f, 16f),
                        Texture = "#all",
                    };
                });
        }
    }
}
