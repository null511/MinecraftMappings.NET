using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BasaltSide : JavaBlockTexture
    {
        public BasaltSide() : base("Basalt Side")
        {
            AddVersion(5, "basalt_side")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Block.Basalt>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BasaltSide>();
        }
    }
}
