using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_OrientableTrapdoorBottom : JavaBlockModel
    {
        public Template_OrientableTrapdoorBottom() : base("Template Orientable Trapdoor Bottom")
        {
            AddVersion("template_orientable_trapdoor_bottom", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 3f, 16f);
                    element.FaceDown = new ModelFace("#texture") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceUp = new ModelFace("#texture") {
                        UV = UVMap(0f, 16f, 16f, 0f),
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
