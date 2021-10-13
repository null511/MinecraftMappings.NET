using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TemplateCampfire : JavaBlockModel
    {
        public TemplateCampfire() : base("Template Campfire")
        {
            AddVersion("template_campfire", "1.14")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("log", "block/campfire_log")
                .AddElement(element => {
                    element.From = new Vector3(1f, 0f, 0f);
                    element.To = new Vector3(5f, 4f, 16f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 4f),
                        Texture = "#log",
                        Rotation = 90,
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(0f, 0f, 16f, 4f),
                        Texture = "#log",
                        Rotation = 90,
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(0f, 4f, 4f, 8f),
                        Texture = "#log",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(0f, 4f, 4f, 8f),
                        Texture = "#log",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(16f, 0f, 0f, 4f),
                        Texture = "#log",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(0f, 1f, 16f, 5f),
                        Texture = "#lit_log",
                    };
                });
            // TODO: UNFINISHED!
        }
    }
}
