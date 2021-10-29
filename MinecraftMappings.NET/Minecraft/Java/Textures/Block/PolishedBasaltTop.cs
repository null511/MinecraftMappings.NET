using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PolishedBasaltTop : JavaBlockTexture
    {
        public PolishedBasaltTop() : base("Polished Basalt Top")
        {
            AddVersion("polished_basalt_top")
                .WithDefaultModel<Java.Models.Block.PolishedBasalt>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PolishedBasaltSide>();
        }
    }
}
