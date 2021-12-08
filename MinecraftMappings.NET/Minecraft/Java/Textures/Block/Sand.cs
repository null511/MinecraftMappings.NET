using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Sand : JavaBlockTexture
    {
        public Sand() : base("Sand")
        {
            AddVersion("sand");
                //.WithDefaultModel<Java.Models.Block.Sand>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Sand>();
        }
    }
}
