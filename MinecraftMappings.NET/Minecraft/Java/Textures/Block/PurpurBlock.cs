using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PurpurBlock : JavaBlockTexture
    {
        public PurpurBlock() : base("Purpur Block")
        {
            AddVersion("purpur_block");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PurpurBlock>();
        }
    }
}
