using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class GrassBlock : JavaBlockModel
    {
        public GrassBlock() : base("Grass Block, Overlay")
        {
            AddVersion("grass_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("top", "block/grass_block_top")
                .AddTexture("top", "block/grass_block_top")
                .AddTexture("dirt", "block/dirt")
                .AddTexture("overlay", "block/grass_block_side_overlay")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top", UVFull);
                    element.FaceDown = new ModelFace("#dirt", UVFull);
                    element.FaceNorth = new ModelFace("#dirt", UVFull);
                    element.FaceSouth = new ModelFace("#dirt", UVFull);
                    element.FaceWest = new ModelFace("#dirt", UVFull);
                    element.FaceEast = new ModelFace("#dirt", UVFull);
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceNorth = new ModelFace("#overlay", UVFull);
                    element.FaceSouth = new ModelFace("#overlay", UVFull);
                    element.FaceWest = new ModelFace("#overlay", UVFull);
                    element.FaceEast = new ModelFace("#overlay", UVFull);
                });
        }
    }
}
