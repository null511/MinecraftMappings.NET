using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PolishedAndesite : JavaBlockTexture
    {
        public PolishedAndesite() : base("Polished Andesite")
        {
            AddVersion(1, "polished_andesite")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Block.PolishedAndesite>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StoneAndesite>();
        }
    }
}
