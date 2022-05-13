using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_OrientableTrapdoorOpen : JavaBlockModel
    {
        public Template_OrientableTrapdoorOpen() : base("Template, Orientable Trapdoor Open")
        {
            AddVersion("template_orientable_trapdoor_open", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 13f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceDown = new ModelFace("#texture") {
                        UV = UVMap(0f, 0f, 16f, 3f),
                    };
                    element.FaceUp = new ModelFace("#texture") {
                        UV = UVMap(0f, 3f, 16f, 0f),
                    };
                    element.FaceNorth = new ModelFace("#texture") {
                        UV = UVMap(0f, 16f, 16f, 0f),
                    };
                    element.FaceSouth = new ModelFace("#texture") {
                        UV = UVMap(0f, 16f, 16f, 0f),
                    };
                    element.FaceWest = new ModelFace("#texture") {
                        UV = UVMap(0f, 0f, 16f, 3f),
                        Rotation = 90,
                    };
                    element.FaceEast = new ModelFace("#texture") {
                        UV = UVMap(0f, 3f, 16f, 0f),
                        Rotation = 90,
                    };
                });
        }
    }
}
