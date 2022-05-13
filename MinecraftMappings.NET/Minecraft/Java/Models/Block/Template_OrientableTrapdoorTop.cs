using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_OrientableTrapdoorTop : JavaBlockModel
    {
        public Template_OrientableTrapdoorTop() : base("Template Orientable Trapdoor Top")
        {
            AddVersion("template_orientable_trapdoor_top", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 13f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#texture") {
                        UV = UVMap(0f, 16f, 16f, 0f),
                    };
                    element.FaceDown = new ModelFace("#texture") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceNorth = new ModelFace("#texture") {
                        UV = UVMap(0f, 0f, 16f, 3f),
                    };
                    element.FaceSouth = new ModelFace("#texture") {
                        UV = UVMap(0f, 0f, 16f, 3f),
                    };
                    element.FaceWest = new ModelFace("#texture") {
                        UV = UVMap(0f, 0f, 16f, 3f),
                    };
                    element.FaceEast = new ModelFace("#texture") {
                        UV = UVMap(0f, 0f, 16f, 3f),
                    };
                });
        }
    }
}
