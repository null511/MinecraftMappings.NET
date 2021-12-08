using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GildedBlackstone : JavaBlockTexture
    {
        public GildedBlackstone() : base("Gilded Blackstone")
        {
            AddVersion("gilded_blackstone");
                //.WithDefaultModel<Java.Models.Block.GildedBlackstone>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GildedBlackstone>();
        }
    }
}
