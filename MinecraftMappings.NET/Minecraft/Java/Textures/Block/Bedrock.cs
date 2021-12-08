using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Bedrock : JavaBlockTexture
    {
        public Bedrock() : base("Bedrock")
        {
            AddVersion(0, "bedrock")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.Bedrock>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Bedrock>();
        }
    }
}
