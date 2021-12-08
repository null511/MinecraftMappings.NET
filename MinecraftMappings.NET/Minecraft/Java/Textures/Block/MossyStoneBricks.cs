using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MossyStoneBricks : JavaBlockTexture
    {
        public MossyStoneBricks() : base("Mossy Stone Bricks")
        {
            AddVersion("mossy_stone_bricks");
                //.WithDefaultModel<Java.Models.Block.MossyStoneBricks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MossyStoneBricks>();
        }
    }
}
