using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TemplateTorch : JavaBlockModel
    {
        public TemplateTorch() : base("Template Torch")
        {
            AddVersion("template_torch", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(7f, 0f, 7f);
                    element.To = new Vector3(9f, 10f, 9f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(7f, 6f, 9f, 8f),
                        Texture = "#torch",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(7f, 13f, 9f, 15f),
                        Texture = "#torch",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7f, 0f, 0f);
                    element.To = new Vector3(9f, 16f, 16f);
                    element.FaceWest = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#torch",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#torch",
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 7f);
                    element.To = new Vector3(16f, 16f, 9f);
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#torch",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 16f),
                        Texture = "#torch",
                    };
                });
        }
    }
}
