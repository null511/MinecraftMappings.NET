using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PistonExtended : JavaBlockModel
    {
        public PistonExtended() : base("Piston Extended")
        {
            AddVersion("piston_extended", "1.3.1")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 4f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#side") {
                        UV = UVMap(0f, 4f, 16f, 16f),
                    };
                    element.FaceDown = new ModelFace("#side") {
                        UV = UVMap(0f, 4f, 16f, 16f),
                        Rotation = 180,
                    };
                    element.FaceNorth = new ModelFace("#inside", UVFull);
                    element.FaceSouth = new ModelFace("#bottom", UVFull);
                    element.FaceWest = new ModelFace("#side") {
                        UV = UVMap(0f, 4f, 16f, 16f),
                        Rotation = 270,
                    };
                    element.FaceEast = new ModelFace("#side") {
                        UV = UVMap(0f, 4f, 16f, 16f),
                        Rotation = 90,
                    };
                });
        }
    }
}
