using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_RailRaised_SW : JavaBlockModel
    {
        public Template_RailRaised_SW() : base("Template, Rail Raised SW")
        {
            AddVersion("template_rail_raised_sw", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(5f, 0f, 4f);
                    element.To = new Vector3(9f, 7f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(0f, 9f, 0f),
                        Axis = ModelAxis.X,
                        Angle = -45,
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
