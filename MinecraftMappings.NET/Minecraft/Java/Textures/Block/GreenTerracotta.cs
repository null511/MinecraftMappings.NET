using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GreenTerracotta : JavaBlockTexture
    {
        public GreenTerracotta() : base("Green Terracotta")
        {
            AddVersion("green_terracotta");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HardenedClayStainedGreen>();
        }
    }
}
