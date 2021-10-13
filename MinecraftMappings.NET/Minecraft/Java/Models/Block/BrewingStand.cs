using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrewingStand : JavaBlockModel
    {
        public BrewingStand() : base("Brewing Stand")
        {
            AddVersion("brewing_stand", "1.0.0")
                .WithPath("models/block")
                .AddTexture("base", "block/brewing_stand_base")
                .AddTexture("stand", "block/brewing_stand")
                .AddElement(element => {
                    element.From = new Vector3(7f, 0f, 7f);
                    element.To = new Vector3(9f, 14f, 9f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(7f, 7f, 9f, 9f),
                        Texture = "#stand",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(7f, 7f, 9f, 9f),
                        Texture = "#stand",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(7f, 2f, 9f, 16f),
                        Texture = "#stand",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(7f, 2f, 9f, 16f),
                        Texture = "#stand",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(7f, 2f, 9f, 16f),
                        Texture = "#stand",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(7f, 2f, 9f, 16f),
                        Texture = "#stand",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(9f, 0f, 5f);
                    element.To = new Vector3(15f, 2f, 11f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(9f, 5f, 15f, 11f),
                        Texture = "#base",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(9f, 5f, 15f, 11f),
                        Texture = "#base",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(9f, 14f, 15f, 16f),
                        Texture = "#base",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(9f, 14f, 15f, 16f),
                        Texture = "#base",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(5f, 14f, 11f, 16f),
                        Texture = "#base",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(5f, 14f, 11f, 16f),
                        Texture = "#base",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 0f, 1f);
                    element.To = new Vector3(8f, 2f, 7f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(2f, 1f, 8f, 7f),
                        Texture = "#base",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(2f, 1f, 8f, 7f),
                        Texture = "#base",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(2f, 14f, 8f, 16f),
                        Texture = "#base",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(2f, 14f, 8f, 16f),
                        Texture = "#base",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(1f, 14f, 7f, 16f),
                        Texture = "#base",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(1f, 14f, 7f, 16f),
                        Texture = "#base",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 0f, 9f);
                    element.To = new Vector3(8f, 2f, 15f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(2f, 9f, 8f, 15f),
                        Texture = "#base",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(2f, 9f, 8f, 15f),
                        Texture = "#base",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(2f, 14f, 8f, 16f),
                        Texture = "#base",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(2f, 14f, 8f, 16f),
                        Texture = "#base",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(9f, 14f, 15f, 16f),
                        Texture = "#base",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(9f, 14f, 15f, 16f),
                        Texture = "#base",
                    };
                });
        }
    }
}
