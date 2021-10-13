using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TemplateAnvil : JavaBlockModel
    {
        public TemplateAnvil() : base("Template Anvil")
        {
            AddVersion("template_anvil", "1.4.2")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("body", "block/anvil")
                .AddElement("Anvil base", element => {
                    element.From = new Vector3(2f, 0f, 2f);
                    element.To = new Vector3(14f, 4f, 14f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(2f, 2f, 14f, 14f),
                        Texture = "#body",
                        Rotation = 180,
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(2f, 2f, 14f, 14f),
                        Texture = "#body",
                        Rotation = 180,
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(2f, 12f, 14f, 16f),
                        Texture = "#body",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(2f, 12f, 14f, 16f),
                        Texture = "#body",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 2f, 4f, 14f),
                        Texture = "#body",
                        Rotation = 90,
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(4f, 2f, 0f, 14f),
                        Texture = "#body",
                        Rotation = 270,
                    };
                })
                .AddElement("Lower narrow portion", element => {
                    element.From = new Vector3(4f, 4f, 3f);
                    element.To = new Vector3(12f, 5f, 13f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(4f, 3f, 12f, 13f),
                        Texture = "#body",
                        Rotation = 180,
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(4f, 11f, 12f, 12f),
                        Texture = "#body",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(4f, 11f, 12f, 12f),
                        Texture = "#body",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(4f, 3f, 5f, 13f),
                        Texture = "#body",
                        Rotation = 90,
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(5f, 3f, 4f, 13f),
                        Texture = "#body",
                        Rotation = 270,
                    };
                })
                .AddElement("Wider section beneath top portion", element => {
                    element.From = new Vector3(6f, 5f, 4f);
                    element.To = new Vector3(10f, 10f, 12f);
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(6f, 6f, 10f, 11f),
                        Texture = "#body",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(6f, 6f, 10f, 11f),
                        Texture = "#body",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(5f, 4f, 10f, 12f),
                        Texture = "#body",
                        Rotation = 90,
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(10f, 4f, 5f, 12f),
                        Texture = "#body",
                        Rotation = 270,
                    };
                })
                .AddElement("Anvil top", element => {
                    element.From = new Vector3(3f, 10f, 0f);
                    element.To = new Vector3(13f, 16f, 16f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(3f, 0f, 13f, 16f),
                        Texture = "#top",
                        Rotation = 180,
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(3f, 0f, 13f, 16f),
                        Texture = "#body",
                        Rotation = 180,
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(3f, 0f, 13f, 6f),
                        Texture = "#body",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(3f, 0f, 13f, 6f),
                        Texture = "#body",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(10f, 0f, 16f, 16f),
                        Texture = "#body",
                        Rotation = 90,
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(16f, 0f, 10f, 16f),
                        Texture = "#body",
                        Rotation = 270,
                    };
                });
        }
    }
}
