using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Terracotta : JavaBlockTexture
    {
        public Terracotta() : base("Terracotta")
        {
            AddVersion("terracotta");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HardenedClayStained>();
        }
    }
}
