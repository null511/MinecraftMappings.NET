using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cube_Directional : JavaBlockModel
    {
        public Cube_Directional() : base("Cube, Directional")
        {
            AddVersion("cube_directional", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#up", UVFull);
                    element.FaceDown = new ModelFace("#down", UVFull) {
                        Rotation = 180,
                    };
                    element.FaceNorth = new ModelFace("#north", UVFull);
                    element.FaceSouth = new ModelFace("#south", UVFull);
                    element.FaceWest = new ModelFace("#west", UVFull) {
                        Rotation = 270,
                    };
                    element.FaceEast = new ModelFace("#east", UVFull) {
                        Rotation = 90,
                    };
                });
        }
    }
}
