using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrackedDeepslateBricks : JavaBlockTexture
    {
        public CrackedDeepslateBricks() : base("Cracked Deepslate Bricks")
        {
            AddVersion("cracked_deepslate_bricks")
                //.WithDefaultModel<Java.Models.Block.CrackedDeepslateBricks>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate.CrackedDeepslateBricks>();
        }
    }
}
