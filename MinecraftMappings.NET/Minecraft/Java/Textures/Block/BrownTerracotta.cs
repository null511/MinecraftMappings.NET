using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownTerracotta : JavaBlockTexture
    {
        public BrownTerracotta() : base("Brown Terracotta")
        {
            AddVersion("brown_terracotta");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HardenedClayStainedBrown>();
        }
    }
}
