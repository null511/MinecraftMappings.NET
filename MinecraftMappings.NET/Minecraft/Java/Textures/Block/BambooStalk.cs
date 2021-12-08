using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BambooStalk : JavaBlockTexture
    {
        public BambooStalk() : base("Bamboo Stalk")
        {
            AddVersion(4, "bamboo_stalk")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.Bamboo1_Age0>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BambooStem>();
        }
    }
}
