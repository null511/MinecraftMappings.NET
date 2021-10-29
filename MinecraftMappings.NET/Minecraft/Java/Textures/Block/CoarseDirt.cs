using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CoarseDirt : JavaBlockTexture
    {
        public CoarseDirt() : base("Coarse Dirt")
        {
            AddVersion("coarse_dirt")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.CoarseDirt>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CoarseDirt>();
        }
    }
}
