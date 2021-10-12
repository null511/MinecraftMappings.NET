using MinecraftMappings.Internal.Models;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Leaves : JavaModelData
    {
        public Leaves() : base("Leaves")
        {
            AddVersion("leaves", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace {
                        UV = UVFull,
                        Texture = "#all",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVFull,
                        Texture = "#all",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVFull,
                        Texture = "#all",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVFull,
                        Texture = "#all",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVFull,
                        Texture = "#all",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVFull,
                        Texture = "#all",
                    };
                });
        }
    }
}
