using MinecraftMappings.Internal.Models;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Carpet : JavaModelData
    {
        public Carpet() : base("Carpet")
        {
            AddVersion("carpet", "1.6.1")
                .WithPath("models/block")
                .WithParent("block/thin_block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 1f, 16f);
                    element.FaceUp = new ModelFace {
                        UV = UVFull,
                        Texture = "#wool",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVFull,
                        Texture = "#wool",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 15f, 16f, 16f),
                        Texture = "#wool",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 15f, 16f, 16f),
                        Texture = "#wool",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 15f, 16f, 16f),
                        Texture = "#wool",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 15f, 16f, 16f),
                        Texture = "#wool",
                    };
                });
        }
    }
}
