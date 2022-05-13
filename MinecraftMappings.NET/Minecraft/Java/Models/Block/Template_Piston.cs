using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_Piston : JavaBlockModel
    {
        public Template_Piston() : base("Template Piston")
        {
            AddVersion("template_piston", "1.3.1")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#side", UVFull);
                    element.FaceDown = new ModelFace("#side", UVFull) {
                        Rotation = 180,
                    };
                    element.FaceNorth = new ModelFace("#platform", UVFull);
                    element.FaceSouth = new ModelFace("#bottom", UVFull);
                    element.FaceWest = new ModelFace("#side", UVFull) {
                        Rotation = 270,
                    };
                    element.FaceEast = new ModelFace("#side", UVFull) {
                        Rotation = 90,
                    };
                });
        }
    }
}
