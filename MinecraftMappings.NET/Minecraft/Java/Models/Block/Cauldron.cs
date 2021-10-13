using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cauldron : JavaBlockModel
    {
        public Cauldron() : base("Cauldron")
        {
            AddVersion("cauldron", "1.0.0")
                .WithPath("models/block")
                .AddTexture("top", "block/cauldron_top")
                .AddTexture("bottom", "block/cauldron_bottom")
                .AddTexture("side", "block/cauldron_side")
                .AddTexture("inside", "block/cauldron_inner")
                .AddElement(element => {
                    element.From = new Vector3(0f, 3f, 0f);
                    element.To = new Vector3(2f, 16f, 16f);
                    element.FaceUp = new ModelFace {
                        Texture = "#top",
                    };
                    element.FaceDown = new ModelFace {
                        Texture = "#inside",
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 3f, 2f);
                    element.To = new Vector3(14f, 4f, 14f);
                    element.FaceUp = new ModelFace {
                        Texture = "#inside",
                    };
                    element.FaceDown = new ModelFace {
                        Texture = "#inside",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(14f, 3f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace {
                        Texture = "#top",
                    };
                    element.FaceDown = new ModelFace {
                        Texture = "#inside",
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 3f, 0f);
                    element.To = new Vector3(14f, 16f, 2f);
                    element.FaceUp = new ModelFace {
                        Texture = "#top",
                    };
                    element.FaceDown = new ModelFace {
                        Texture = "#inside",
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 3f, 14f);
                    element.To = new Vector3(14f, 16f, 16f);
                    element.FaceUp = new ModelFace {
                        Texture = "#top",
                    };
                    element.FaceDown = new ModelFace {
                        Texture = "#inside",
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(4f, 3f, 2f);
                    element.FaceDown = new ModelFace {
                        Texture = "#bottom",
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 2f);
                    element.To = new Vector3(2f, 3f, 4f);
                    element.FaceDown = new ModelFace {
                        Texture = "#bottom",
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(12f, 0f, 0f);
                    element.To = new Vector3(16f, 3f, 2f);
                    element.FaceDown = new ModelFace {
                        Texture = "#bottom",
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(14f, 0f, 2f);
                    element.To = new Vector3(16f, 3f, 4f);
                    element.FaceDown = new ModelFace {
                        Texture = "#bottom",
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 14f);
                    element.To = new Vector3(4f, 3f, 16f);
                    element.FaceDown = new ModelFace {
                        Texture = "#bottom",
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 12f);
                    element.To = new Vector3(2f, 3f, 14f);
                    element.FaceDown = new ModelFace {
                        Texture = "#bottom",
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(12f, 0f, 14f);
                    element.To = new Vector3(16f, 3f, 16f);
                    element.FaceDown = new ModelFace {
                        Texture = "#bottom",
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#side",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(14f, 0f, 12f);
                    element.To = new Vector3(16f, 3f, 14f);
                    element.FaceDown = new ModelFace {
                        Texture = "#bottom",
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#side",
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#side",
                    };
                });
        }
    }
}
