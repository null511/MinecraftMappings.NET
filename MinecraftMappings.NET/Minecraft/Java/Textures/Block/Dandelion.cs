using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Dandelion : JavaBlockTexture
    {
        public Dandelion() : base("Dandelion")
        {
            AddVersion("dandelion")
                .WithDefaultModel<Java.Models.Block.Dandelion>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerDandelion>();
        }
    }
}
