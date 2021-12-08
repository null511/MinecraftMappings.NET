using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class NetherSprouts : JavaBlockTexture
    {
        public NetherSprouts() : base("Nether Sprouts")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("nether_sprouts")
                .WithDefaultModel<Java.Models.Block.NetherSprouts>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.NetherSprouts>();
        }
    }
}
