using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_TurtleEgg : JavaBlockModel
    {
        public Template_TurtleEgg() : base("Template, Turtle Egg")
        {
            AddVersion("template_turtle_egg", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(5f, 0f, 4f);
                    element.To = new Vector3(9f, 7f, 8f);
                    element.FaceDown = new ModelFace("#all") {
                        UV = UVMap(0f, 0f, 4f, 4f),
                    };
                    element.FaceUp = new ModelFace("#all") {
                        UV = UVMap(0f, 0f, 4f, 4f),
                    };
                    element.FaceNorth = new ModelFace("#all") {
                        UV = UVMap(1f, 4f, 5f, 11f),
                    };
                    element.FaceSouth = new ModelFace("#all") {
                        UV = UVMap(1f, 4f, 5f, 11f),
                    };
                    element.FaceWest = new ModelFace("#all") {
                        UV = UVMap(1f, 4f, 5f, 11f),
                    };
                    element.FaceEast = new ModelFace("#all") {
                        UV = UVMap(1f, 4f, 5f, 11f),
                    };
                });
        }
    }
}
