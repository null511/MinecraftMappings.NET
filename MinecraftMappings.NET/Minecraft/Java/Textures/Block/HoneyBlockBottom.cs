using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HoneyBlockBottom : JavaBlockTexture
    {
        public HoneyBlockBottom() : base("Honey Block Bottom")
        {
            AddVersion("honey_block_bottom")
                .WithMinVersion("1.15")
                .WithDefaultModel<Java.Models.Block.HoneyBlock>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HoneyBottom>();
        }
    }
}
