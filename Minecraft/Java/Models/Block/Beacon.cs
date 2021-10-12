using MinecraftMappings.Internal.Models;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Beacon : JavaModelData
    {
        public Beacon() : base("Beacon")
        {
            AddVersion("beacon", "1.4.2")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("glass", "block/glass")
                .AddTexture("obsidian", "block/obsidian")
                .AddTexture("beacon", "block/beacon")
                .AddElement("Glass shell", element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace {
                        UV = UVFull,
                        Texture = "#glass",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVFull,
                        Texture = "#glass",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVFull,
                        Texture = "#glass",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVFull,
                        Texture = "#glass",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVFull,
                        Texture = "#glass",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVFull,
                        Texture = "#glass",
                    };
                })
                .AddElement("Obsidian base", element => {
                    element.From = new Vector3(2f, 0.1f, 2f);
                    element.To = new Vector3(14f, 3f, 14f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(2f, 2f, 14f, 14f),
                        Texture = "#obsidian",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(2f, 2f, 14f, 14f),
                        Texture = "#obsidian",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(2f, 13f, 14f, 16f),
                        Texture = "#obsidian",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(2f, 13f, 14f, 16f),
                        Texture = "#obsidian",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(2f, 13f, 14f, 16f),
                        Texture = "#obsidian",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(2f, 13f, 14f, 16f),
                        Texture = "#obsidian",
                    };
                })
                .AddElement("Inner beacon texture", element => {
                    element.From = new Vector3(3f, 3f, 3f);
                    element.To = new Vector3(13f, 14f, 13f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(3f, 3f, 13f, 13f),
                        Texture = "#beacon",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(3f, 3f, 13f, 13f),
                        Texture = "#beacon",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(3f, 2f, 13f, 13f),
                        Texture = "#beacon",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(3f, 2f, 13f, 13f),
                        Texture = "#beacon",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(3f, 2f, 13f, 13f),
                        Texture = "#beacon",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(3f, 2f, 13f, 13f),
                        Texture = "#beacon",
                    };
                });
        }
    }
}
