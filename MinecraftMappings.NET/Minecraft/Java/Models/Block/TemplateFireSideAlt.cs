using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TemplateFireSideAlt : JavaBlockModel
    {
        public TemplateFireSideAlt() : base("Template Fire, Side Alt")
        {
            AddVersion("template_fire_side_alt", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0.01f);
                    element.To = new Vector3(16f, 22.4f, 0.01f);
                    element.FaceNorth = new ModelFace("#fire") {
                        UV = UVMap(16f, 0f, 0f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#fire") {
                        UV = UVMap(16f, 0f, 0f, 16f),
                    };
                });
        }
    }
}
