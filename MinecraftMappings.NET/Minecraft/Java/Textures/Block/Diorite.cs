using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Diorite : JavaBlockTexture
    {
        public Diorite() : base("Diorite")
        {
            AddVersion("diorite");
                //.WithDefaultModel<Java.Models.Block.Diorite>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Diorite>();
        }
    }
}
