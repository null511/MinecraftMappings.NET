using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LimeTerracotta : JavaBlockTexture
    {
        public LimeTerracotta() : base("Lime Terracotta")
        {
            AddVersion("lime_terracotta");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HardenedClayStainedLime>();
        }
    }
}
