using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MossyCobblestone : JavaBlockTexture
    {
        public MossyCobblestone() : base("Mossy Cobblestone")
        {
            AddVersion("mossy_cobblestone")
                .WithDefaultModel<Java.Models.Block.MossyCobblestone>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CobblestoneMossy>();
        }
    }
}
