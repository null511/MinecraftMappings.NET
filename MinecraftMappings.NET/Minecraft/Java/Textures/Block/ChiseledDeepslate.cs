using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChiseledDeepslate : JavaBlockTexture
    {
        public ChiseledDeepslate() : base("Chiseled Deepslate")
        {
            AddVersion("chiseled_deepslate")
                .WithDefaultModel<Java.Models.Block.ChiseledDeepslate>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ChiseledDeepslate>();
        }
    }
}
