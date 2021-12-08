using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedSandstoneBottom : JavaBlockTexture
    {
        public RedSandstoneBottom() : base("Red Sandstone Bottom")
        {
            AddVersion("red_sandstone_bottom");
                //.WithDefaultModel<Java.Models.Block.RedSandstoneBottom>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedSandstoneBottom>();
        }
    }
}
