using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CobbledDeepslate : JavaBlockTexture
    {
        public CobbledDeepslate() : base("Cobbled Deepslate")
        {
            AddVersion("cobbled_deepslate")
                .WithDefaultModel<Java.Models.Block.CobbledDeepslate>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate.CobbledDeepslate>();
        }
    }
}
