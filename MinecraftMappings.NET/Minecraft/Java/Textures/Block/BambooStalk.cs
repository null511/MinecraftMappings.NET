using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BambooStalk : JavaBlockTexture
    {
        public BambooStalk() : base("Bamboo Stalk")
        {
            AddVersion("bamboo_stalk")
                .WithDefaultModel<Java.Models.Block.Bamboo1_Age0>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BambooStem>();
        }
    }
}
