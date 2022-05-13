using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_WallPost : JavaBlockModel
    {
        public Template_WallPost() : base("Template, Wall Post")
        {
            AddVersion("template_wall_post", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(4f, 0f, 4f);
                    element.To = new Vector3(12f, 16f, 12f);
                    element.FaceDown = new ModelFace("#wall");
                    element.FaceUp = new ModelFace("#wall");
                    element.FaceNorth = new ModelFace("#wall");
                    element.FaceSouth = new ModelFace("#wall");
                    element.FaceWest = new ModelFace("#wall");
                    element.FaceEast = new ModelFace("#wall");
                });
        }
    }
}
