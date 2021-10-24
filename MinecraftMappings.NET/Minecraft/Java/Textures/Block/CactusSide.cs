using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CactusSide : JavaBlockTexture
    {
        public CactusSide() : base("Cactus Side")
        {
            AddVersion("cactus_side")
                .WithDefaultModel<Java.Models.Block.Cactus>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CactusSide>();
        }
    }
}
