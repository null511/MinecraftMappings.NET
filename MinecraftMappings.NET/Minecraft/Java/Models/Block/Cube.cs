using MinecraftMappings.Internal.Models;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cube : JavaModelData
    {
        public Cube() : base("Cube")
        {
            AddVersion("cube", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace {
                        UV = UVFull,
                        Texture = "#up",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVFull,
                        Texture = "#down",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVFull,
                        Texture = "#north",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVFull,
                        Texture = "#south",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVFull,
                        Texture = "#west",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVFull,
                        Texture = "#east",
                    };
                });
        }
    }
}
