using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Slab : JavaBlockModel
    {
        public Slab() : base("Slab")
        {
            AddVersion("slab", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 8f, 16f);
                    element.FaceUp = new ModelFace {
                        UV = UVFull,
                        Texture = "#top",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVFull,
                        Texture = "#bottom",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 8f, 16f, 16f),
                        Texture = "#side",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 8f, 16f, 16f),
                        Texture = "#side",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 8f, 16f, 16f),
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 8f, 16f, 16f),
                        Texture = "#side",
                    };
                });
        }
    }
}
