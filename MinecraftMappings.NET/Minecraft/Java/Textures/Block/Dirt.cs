using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Dirt : JavaBlockTexture
    {
        public Dirt() : base("Dirt")
        {
            AddVersion("dirt")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.Dirt>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Dirt>();
        }
    }
}
