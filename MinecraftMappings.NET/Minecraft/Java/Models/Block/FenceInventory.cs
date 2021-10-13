using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FenceInventory : JavaBlockModel
    {
        public FenceInventory() : base("Fence Inventory")
        {
            AddVersion("fence_inventory", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddElement("Left post", element => {
                    element.From = new Vector3(6f, 0f, 0f);
                    element.To = new Vector3(10f, 16f, 4f);
                    element.FaceUp = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(6f, 0f, 10f, 4f),
                    };
                    element.FaceDown = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(6f, 0f, 10f, 4f),
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
                        UV = UVMap(0f, 0f, 4f, 16f),
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(0f, 0f, 4f, 16f),
                    };
                })
                .AddElement("Right post", element => {
                    element.From = new Vector3(6f, 0f, 12f);
                    element.To = new Vector3(10f, 16f, 16f);
                    element.FaceUp = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(6f, 12f, 10f, 16f),
                    };
                    element.FaceDown = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(6f, 12f, 10f, 16f),
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
                        UV = UVMap(12f, 0f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(12f, 0f, 16f, 16f),
                    };
                })
                .AddElement("top bar", element => {
                    element.From = new Vector3(7f, 13f, -2f);
                    element.To = new Vector3(9f, 15f, 18f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(7f, 0f, 9f, 16f),
                        Texture = "#texture",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(7f, 0f, 9f, 16f),
                        Texture = "#texture",
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(7f, 1f, 9f, 3f),
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(7f, 1f, 9f, 3f),
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(0f, 1f, 16f, 3f),
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(0f, 1f, 16f, 3f),
                    };
                })
                .AddElement("lower bar", element => {
                    element.From = new Vector3(7f, 5f, -2f);
                    element.To = new Vector3(9f, 7f, 18f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(7f, 0f, 9f, 16f),
                        Texture = "#texture",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(7f, 0f, 9f, 16f),
                        Texture = "#texture",
                    };
                    element.FaceNorth = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(7f, 9f, 9f, 11f),
                    };
                    element.FaceSouth = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(7f, 9f, 9f, 11f),
                    };
                    element.FaceWest = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(0f, 9f, 16f, 11f),
                    };
                    element.FaceEast = new ModelFace {
                        Texture = "#texture",
                        UV = UVMap(0f, 9f, 16f, 11f),
                    };
                });
        }
    }
}
