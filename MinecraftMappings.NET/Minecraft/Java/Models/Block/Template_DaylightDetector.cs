using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_DaylightDetector : JavaBlockModel
    {
        public Template_DaylightDetector() : base("Template Daylight Detector")
        {
            AddVersion("template_daylight_detector", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/thin_block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top", UVFull);
                    element.FaceDown = new ModelFace("#side", UVFull);
                    element.FaceNorth = new ModelFace("#side") {
                        UV = UVMap(0f, 10f, 16f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#side") {
                        UV = UVMap(0f, 10f, 16f, 16f),
                    };
                    element.FaceWest = new ModelFace("#side") {
                        UV = UVMap(0f, 10f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace("#side") {
                        UV = UVMap(0f, 10f, 16f, 16f),
                    };
                });
        }
    }
}
