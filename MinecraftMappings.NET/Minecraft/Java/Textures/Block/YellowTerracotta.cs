using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class YellowTerracotta : JavaBlockTexture
    {
        public YellowTerracotta() : base("Yellow Terracotta")
        {
            AddVersion("yellow_terracotta")
                .WithDefaultModel<Java.Models.Block.YellowTerracotta>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HardenedClayStainedYellow>();
        }
    }
}
