using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedstoneOre : JavaBlockTexture
    {
        public RedstoneOre() : base("Redstone Ore")
        {
            AddVersion("redstone_ore");
                //.WithDefaultModel<Java.Models.Block.RedstoneOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedstoneOre>();
        }
    }
}
