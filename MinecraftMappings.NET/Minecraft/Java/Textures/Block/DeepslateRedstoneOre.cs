using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeepslateRedstoneOre : JavaBlockTexture
    {
        public DeepslateRedstoneOre() : base("Deepslate Redstone Ore")
        {
            AddVersion("deepslate_redstone_ore");
                //.WithDefaultModel<Java.Models.Block.DeepslateRedstoneOre>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeepslateRedstoneOre>();
        }
    }
}
