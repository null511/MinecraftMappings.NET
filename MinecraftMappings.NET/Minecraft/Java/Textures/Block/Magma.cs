using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Magma : JavaBlockTexture
    {
        public Magma() : base("Magma")
        {
            AddVersion("magma");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Magma>();
        }
    }
}
