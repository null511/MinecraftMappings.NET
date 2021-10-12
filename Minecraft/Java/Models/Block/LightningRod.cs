using MinecraftMappings.Internal.Models;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class LightningRod : JavaModelData
    {
        public LightningRod() : base("Lightning Rod")
        {
            AddVersion("lightning_rod", "1.17")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("texture", "block/lightning_rod")
                .AddElement(element => {
                    element.From = new Vector3(6f, 12f, 6f);
                    element.To = new Vector3(10f, 16f, 10f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(4f, 4f, 0f, 0f),
                        Texture = "#texture",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(0f, 0f, 4f, 4f),
                        Texture = "#texture",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 0f, 4f, 4f),
                        Texture = "#texture",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 0f, 4f, 4f),
                        Texture = "#texture",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 0f, 4f, 4f),
                        Texture = "#texture",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 0f, 4f, 4f),
                        Texture = "#texture",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7f, 0f, 7f);
                    element.To = new Vector3(9f, 12f, 9f);
                    element.FaceDown = new ModelFace {
                        UV = UVMap(0f, 4f, 2f, 6f),
                        Texture = "#texture",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 4f, 2f, 16f),
                        Texture = "#texture",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 4f, 2f, 16f),
                        Texture = "#texture",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 4f, 2f, 16f),
                        Texture = "#texture",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 4f, 2f, 16f),
                        Texture = "#texture",
                    };
                });
        }
    }
}
