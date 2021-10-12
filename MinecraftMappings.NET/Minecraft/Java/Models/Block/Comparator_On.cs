using MinecraftMappings.Internal.Models;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Comparator_On : JavaModelData
    {
        public Comparator_On() : base("Comparator, On")
        {
            AddVersion("comparator_on", "1.5")
                .WithPath("models/block")
                .AddTexture("slab", "block/smooth_stone")
                .AddTexture("top", "block/comparator")
                .AddTexture("unlit", "block/redstone_torch_off")
                .AddTexture("lit", "block/redstone_torch")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 2f, 16f);
                    element.FaceUp = new ModelFace {
                        UV = UVFull,
                        Texture = "#top",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVFull,
                        Texture = "#slab",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 14f, 16f, 16f),
                        Texture = "#slab",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 14f, 16f, 16f),
                        Texture = "#slab",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 14f, 16f, 16f),
                        Texture = "#slab",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 14f, 16f, 16f),
                        Texture = "#slab",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(4f, 7f, 11f);
                    element.To = new Vector3(6f, 7f, 13f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 8f),
                        Texture = "#lit",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(4f, 2f, 10f);
                    element.To = new Vector3(6f, 8f, 14f);
                    element.FaceWest = new ModelFace {
                        UV = UVMap(6f, 5f, 10f, 11f),
                        Texture = "#lit",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(6f, 5f, 10f, 11f),
                        Texture = "#lit",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(3f, 2f, 11f);
                    element.To = new Vector3(7f, 8f, 13f);
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(6f, 5f, 10f, 11f),
                        Texture = "#lit",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(6f, 5f, 10f, 11f),
                        Texture = "#lit",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(10f, 7f, 11f);
                    element.To = new Vector3(12f, 7f, 13f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 8f),
                        Texture = "#lit",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(10f, 2f, 10f);
                    element.To = new Vector3(12f, 8f, 14f);
                    element.FaceWest = new ModelFace {
                        UV = UVMap(6f, 5f, 10f, 11f),
                        Texture = "#lit",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(6f, 5f, 10f, 11f),
                        Texture = "#lit",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(9f, 2f, 11f);
                    element.To = new Vector3(13f, 8f, 13f);
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(6f, 5f, 10f, 11f),
                        Texture = "#lit",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(6f, 5f, 10f, 11f),
                        Texture = "#lit",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7f, 2f, 2f);
                    element.To = new Vector3(9f, 4f, 4f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 8f),
                        Texture = "#unlit",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(7f, 13f, 9f, 15f),
                        Texture = "#unlit",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 8f),
                        Texture = "#unlit",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 8f),
                        Texture = "#unlit",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 8f),
                        Texture = "#unlit",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 8f),
                        Texture = "#unlit",
                    };
                });
        }
    }
}
