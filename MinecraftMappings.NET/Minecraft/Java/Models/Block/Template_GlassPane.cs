using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_GlassPane : JavaBlockModel
    {
        public Template_GlassPane() : base("Template Glass Pane")
        {
            AddVersion("template_glass_pane", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(7f, 0f, 0f);
                    element.To = new Vector3(9f, 16f, 16f);
                    element.FaceUp = new ModelFace("#edge", UVMap(7f, 0f, 9f, 16f));
                    element.FaceDown = new ModelFace("#edge", UVMap(7f, 0f, 9f, 16f));
                    element.FaceNorth = new ModelFace("#edge", UVMap(7f, 0f, 9f, 16f));
                    element.FaceSouth = new ModelFace("#edge", UVMap(7f, 0f, 9f, 16f));
                    element.FaceWest = new ModelFace("#pane", UVMap(16f, 0f, 0f, 16f));
                    element.FaceEast = new ModelFace("#pane", UVMap(0f, 0f, 16f, 16f));
                });
        }
    }
}
