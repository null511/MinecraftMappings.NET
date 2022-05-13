using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_RailRaised_NE : JavaBlockModel
    {
        public Template_RailRaised_NE() : base("Template, Rail Raised NE")
        {
            AddVersion("template_rail_raised_ne", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 9f, 0f);
                    element.To = new Vector3(16f, 9f, 16f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 9f, 8f),
                        Axis = ModelAxis.X,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceDown = new ModelFace("#rail") {
                        UV = UVMap(0f, 16f, 16f, 0f),
                    };
                    element.FaceUp = new ModelFace("#rail") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                });
        }
    }
}
