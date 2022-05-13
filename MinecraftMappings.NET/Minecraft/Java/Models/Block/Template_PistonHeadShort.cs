using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_PistonHeadShort : JavaBlockModel
    {
        public Template_PistonHeadShort() : base("Template Piston Head, Short")
        {
            AddVersion("template_piston_head_short", "1.3.1")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 4f);
                    element.FaceUp = new ModelFace("#side") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                    };
                    element.FaceDown = new ModelFace("#side") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                        Rotation = 180,
                    };
                    element.FaceNorth = new ModelFace("#platform", UVFull);
                    element.FaceSouth = new ModelFace("#unsticky", UVFull);
                    element.FaceWest = new ModelFace("#side") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                        Rotation = 270,
                    };
                    element.FaceEast = new ModelFace("#side") {
                        UV = UVMap(0f, 0f, 16f, 4f),
                        Rotation = 90,
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(6f, 6f, 4f);
                    element.To = new Vector3(10f, 10f, 16f);
                    element.FaceUp = new ModelFace("#side") {
                        UV = UVMap(4f, 0f, 16f, 4f),
                        Rotation = 270,
                    };
                    element.FaceDown = new ModelFace("#side") {
                        UV = UVMap(4f, 0f, 16f, 4f),
                        Rotation = 90,
                    };
                    element.FaceWest = new ModelFace("#side") {
                        UV = UVMap(16f, 4f, 4f, 0f),
                    };
                    element.FaceEast = new ModelFace("#side") {
                        UV = UVMap(4f, 0f, 16f, 4f),
                    };
                });
        }
    }
}
