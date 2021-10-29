using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TemplateGlazedTerracotta : JavaBlockModel
    {
        public TemplateGlazedTerracotta() : base("Template Glazed Terracotta")
        {
            AddVersion("template_glazed_terracotta", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#pattern", UVFull);
                    element.FaceDown = new ModelFace("#pattern", UVFull);
                    element.FaceNorth = new ModelFace("#pattern", UVFull) {
                        Rotation = 90,
                    };
                    element.FaceSouth = new ModelFace("#pattern", UVFull) {
                        Rotation = 270,
                    };
                    element.FaceWest = new ModelFace("#pattern", UVFull);
                    element.FaceEast = new ModelFace("#pattern", UVFull) {
                        Rotation = 180,
                    };
                });
        }
    }
}
