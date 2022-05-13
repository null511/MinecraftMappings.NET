using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_WallSideTall : JavaBlockModel
    {
        public Template_WallSideTall() : base("Template, Wall Side Tall")
        {
            AddVersion("template_wall_side_tall", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(5f, 0f, 0f);
                    element.To = new Vector3(11f, 16f, 8f);
                    element.FaceDown = new ModelFace("#wall");
                    element.FaceUp = new ModelFace("#wall");
                    element.FaceNorth = new ModelFace("#wall");
                    element.FaceWest = new ModelFace("#wall");
                    element.FaceEast = new ModelFace("#wall");
                });
        }
    }
}
