using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PolishedBasaltSide : JavaBlockTexture
    {
        public PolishedBasaltSide() : base("Polished Basalt Side")
        {
            AddVersion("polished_basalt_side")
                .WithDefaultModel<Java.Models.Block.PolishedBasalt>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PolishedBasaltSide>();
        }
    }
}
