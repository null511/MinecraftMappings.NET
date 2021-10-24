using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrassBlockSnow : JavaBlockTexture
    {
        public GrassBlockSnow() : base("Grass Block, Snow")
        {
            AddVersion("grass_block_snow")
                .WithDefaultModel<Java.Models.Block.GrassBlockSnow>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GrassSideSnowed>();
        }
    }
}
