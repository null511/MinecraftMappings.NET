using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FencePost : JavaBlockModel
    {
        public FencePost() : base("Fence Post")
        {
            AddVersion("fence_post", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(6f, 0f, 6f);
                    element.To = new Vector3(10f, 16f, 10f);
                    element.FaceUp = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(6f, 6f, 10f, 10f),
                    };
                    element.FaceDown = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(6f, 6f, 10f, 10f),
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(6f, 0f, 10f, 16f),
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(6f, 0f, 10f, 16f),
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(6f, 0f, 10f, 16f),
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(6f, 0f, 10f, 16f),
                    };
                });
        }
    }
}
