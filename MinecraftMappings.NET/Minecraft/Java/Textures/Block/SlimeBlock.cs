using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SlimeBlock : JavaBlockTexture
    {
        public SlimeBlock() : base("Slime Block")
        {
            BlendMode = BlendModes.Transparent;

            AddVersion("slime_block");
                //.WithDefaultModel<Java.Models.Block.SlimeBlock>()
                //.MapsToBedrockBlock<BedrockBlocks.SlimeBlock>();
        }
    }
}
