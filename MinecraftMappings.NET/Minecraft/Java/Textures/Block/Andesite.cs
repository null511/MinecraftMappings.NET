using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Andesite : JavaBlockTexture
    {
        public Andesite() : base("Andesite")
        {
            AddVersion("andesite")
                .WithDefaultModel<Java.Models.Block.Andesite>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StoneAndesite>();
        }
    }
}
