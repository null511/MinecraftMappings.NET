using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_FireUpAlt : JavaBlockModel
    {
        public Template_FireUpAlt() : base("Template Fire, Up Alt")
        {
            AddVersion("template_fire_up_alt", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 16f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 16f, 16f),
                        Axis = ModelAxis.X,
                        Angle = -22.5m,
                        Rescale = true,
                    };
                    element.FaceDown = new ModelFace("#fire", UVFull) {
                        Rotation = 180,
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 16f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 16f, 0f),
                        Axis = ModelAxis.X,
                        Angle = 22.5m,
                        Rescale = true,
                    };
                    element.FaceDown = new ModelFace("#fire", UVFull);
                });
        }
    }
}
