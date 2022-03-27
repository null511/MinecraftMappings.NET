using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueTerracotta : JavaBlockTexture
    {
        public BlueTerracotta() : base("Blue Terracotta")
        {
            AddVersion("blue_terracotta")
                .WithDefaultModel<Java.Models.Block.BlueTerracotta>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HardenedClayStainedBlue>();
        }
    }
}
