using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Cobblestone : JavaBlockTexture
    {
        public Cobblestone() : base("Cobblestone")
        {
            AddVersion("cobblestone")
                .WithDefaultModel<Java.Models.Block.Cobblestone>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Cobblestone>();
        }
    }
}
