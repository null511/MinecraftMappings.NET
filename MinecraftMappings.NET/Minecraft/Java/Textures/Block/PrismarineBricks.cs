using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PrismarineBricks : JavaBlockTexture
    {
        public PrismarineBricks() : base("Prismarine Bricks")
        {
            AddVersion("prismarine_bricks");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PrismarineBricks>();
        }
    }
}
