using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchTrapdoor : JavaBlockTexture
    {
        public BirchTrapdoor() : base("Birch Trapdoor")
        {
            AddVersion(4, "birch_trapdoor")
                .WithMinVersion("1.13")
                .WithDefaultModel<Java.Models.Block.BirchTrapdoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BirchTrapdoor>();
        }
    }
}
