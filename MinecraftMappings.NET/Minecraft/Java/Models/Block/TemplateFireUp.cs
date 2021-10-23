using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TemplateFireUp : JavaBlockModel
    {
        public TemplateFireUp() : base("Template Fire, Up")
        {
            AddVersion("template_fire_up", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 16f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(16f, 16f, 8f),
                        Axis = ModelAxis.Z,
                        Angle = 22.5m,
                        Rescale = true,
                    };
                    element.FaceDown = new ModelFace("#fire", UVFull) {
                        Rotation = 270,
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 16f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(0f, 16f, 8f),
                        Axis = ModelAxis.Z,
                        Angle = -22.5m,
                        Rescale = true,
                    };
                    element.FaceDown = new ModelFace("#fire", UVFull) {
                        Rotation = 90,
                    };
                });
        }
    }
}
