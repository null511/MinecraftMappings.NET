using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Leaves : JavaBlockModel
    {
        public Leaves() : base("Leaves")
        {
            AddVersion("leaves", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#all", UVFull);
                    element.FaceDown = new ModelFace("#all", UVFull);
                    element.FaceNorth = new ModelFace("#all", UVFull);
                    element.FaceSouth = new ModelFace("#all", UVFull);
                    element.FaceWest = new ModelFace("#all", UVFull);
                    element.FaceEast = new ModelFace("#all", UVFull);
                });
        }
    }
}
