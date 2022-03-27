using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DarkPrismarine : JavaBlockTexture
    {
        public DarkPrismarine() : base("Dark Prismarine")
        {
            AddVersion("dark_prismarine")
                .WithDefaultModel<Java.Models.Block.DarkPrismarine>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DarkPrismarine>();
        }
    }
}
