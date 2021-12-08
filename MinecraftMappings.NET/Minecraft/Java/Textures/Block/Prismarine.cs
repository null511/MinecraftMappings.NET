using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Prismarine : JavaBlockTexture
    {
        public Prismarine() : base("Prismarine")
        {
            AddVersion("prismarine");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Prismarine>();
        }
    }
}
