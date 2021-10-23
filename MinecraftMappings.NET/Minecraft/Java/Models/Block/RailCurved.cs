using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RailCurved : JavaBlockModel
    {
        public RailCurved() : base("Rail, Curved")
        {
            AddVersion("rail_curved", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 1f, 0f);
                    element.To = new Vector3(16f, 1f, 16f);
                    element.FaceUp = new ModelFace("#rail") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceDown = new ModelFace("#rail") {
                        UV = UVMap(0f, 16f, 16f, 0f),
                    };
                });
        }
    }
}
