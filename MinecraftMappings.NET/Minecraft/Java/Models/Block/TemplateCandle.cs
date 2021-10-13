using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TemplateCandle : JavaBlockModel
    {
        public TemplateCandle() : base("Template Candle")
        {
            AddVersion("template_candle", "1.17")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddElement(element => {
                    element.From = new Vector3(7f, 0f, 7f);
                    element.To = new Vector3(9f, 6f, 9f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(0f, 6f, 2f, 8f),
                        Texture = "#all",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(0f, 14f, 2f, 16f),
                        Texture = "#all",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 8f, 2f, 14f),
                        Texture = "#all",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 8f, 2f, 14f),
                        Texture = "#all",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 8f, 2f, 14f),
                        Texture = "#all",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 8f, 2f, 14f),
                        Texture = "#all",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7.5f, 6f, 8f);
                    element.To = new Vector3(8.5f, 7f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 6f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 5f, 1f, 6f),
                        Texture = "#all",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 5f, 1f, 6f),
                        Texture = "#all",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7.5f, 6f, 8f);
                    element.To = new Vector3(8.5f, 7f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 6f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = -45,
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 5f, 1f, 6f),
                        Texture = "#all",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 5f, 1f, 6f),
                        Texture = "#all",
                    };
                });
        }
    }
}
