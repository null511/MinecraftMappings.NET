using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_TrapdoorOpen : JavaBlockModel
    {
        public Template_TrapdoorOpen() : base("Template, Trapdoor Open")
        {
            AddVersion("template_trapdoor_open", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 13f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceDown = new ModelFace("#texture") {
                        UV = UVMap(0f, 13f, 16f, 16f),
                    };
                    element.FaceUp = new ModelFace("#texture") {
                        UV = UVMap(0f, 16f, 16f, 13f),
                    };
                    element.FaceNorth = new ModelFace("#texture") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#texture") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceWest = new ModelFace("#texture") {
                        UV = UVMap(16f, 0f, 13f, 16f),
                    };
                    element.FaceEast = new ModelFace("#texture") {
                        UV = UVMap(13f, 0f, 16f, 16f),
                    };
                });
        }
    }
}
