using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class NetherSprouts : JavaBlockTexture
    {
        public NetherSprouts() : base("Nether Sprouts")
        {
            AddVersion("nether_sprouts")
                .WithDefaultModel<Java.Models.Block.NetherSprouts>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.NetherSprouts>();
        }
    }
}
