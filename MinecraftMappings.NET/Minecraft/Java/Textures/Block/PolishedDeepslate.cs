using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PolishedDeepslate : JavaBlockTexture
    {
        public PolishedDeepslate() : base("Polished Deepslate")
        {
            AddVersion("polished_deepslate")
                //.WithDefaultModel<Java.Models.Block.PolishedDeepslate>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate.PolishedDeepslate>();
        }
    }
}
