using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OrangeTerracotta : JavaBlockTexture
    {
        public OrangeTerracotta() : base("Orange Terracotta")
        {
            AddVersion("orange_terracotta");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HardenedClayStainedOrange>();
        }
    }
}
