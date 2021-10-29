using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class GrassBlock : JavaBlockModel
    {
        public GrassBlock() : base("Grass Block")
        {
            AddVersion("grass_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("top", "block/grass_block_top")
                .AddTexture("bottom", "block/dirt")
                .AddTexture("side", "block/grass_block_side")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top", UVFull);
                    element.FaceDown = new ModelFace("#bottom", UVFull);
                    element.FaceNorth = new ModelFace("#side", UVFull);
                    element.FaceSouth = new ModelFace("#side", UVFull);
                    element.FaceWest = new ModelFace("#side", UVFull);
                    element.FaceEast = new ModelFace("#side", UVFull);
                });
        }
    }
}
