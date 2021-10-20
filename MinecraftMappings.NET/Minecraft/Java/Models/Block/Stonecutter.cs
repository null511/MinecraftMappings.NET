using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Stonecutter : JavaBlockModel
    {
        public Stonecutter() : base("Stonecutter")
        {
            AddVersion("stonecutter", "1.0.6")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("top", "block/stonecutter_top")
                .AddTexture("bottom", "block/stonecutter_bottom")
                .AddTexture("side", "block/stonecutter_side")
                .AddTexture("saw", "block/stonecutter_saw")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 9f, 16f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#top",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#bottom",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 7f, 16f, 16f),
                        Texture = "#side",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 7f, 16f, 16f),
                        Texture = "#side",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 7f, 16f, 16f),
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 7f, 16f, 16f),
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(1f, 9f, 8f);
                    element.To = new Vector3(15f, 16f, 8f);
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(1f, 9f, 15f, 16f),
                        Texture = "#saw",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(15f, 9f, 1f, 16f),
                        Texture = "#saw",
                    };
                });
        }
    }
}
