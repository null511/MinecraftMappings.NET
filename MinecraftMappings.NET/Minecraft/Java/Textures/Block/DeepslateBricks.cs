using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeepslateBricks : JavaBlockTexture
    {
        public DeepslateBricks() : base("Deepslate Bricks")
        {
            AddVersion("deepslate_bricks")
                .WithDefaultModel<Java.Models.Block.DeepslateBricks>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeepslateBricks>();
        }
    }
}
