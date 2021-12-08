using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedTerracotta : JavaBlockTexture
    {
        public RedTerracotta() : base("Red Terracotta")
        {
            AddVersion("red_terracotta");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HardenedClayStainedRed>();
        }
    }
}
