using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakTrapdoor : JavaBlockTexture
    {
        public OakTrapdoor() : base("Oak Trapdoor")
        {
            AddVersion("oak_trapdoor")
                .WithDefaultModel<Java.Models.Block.OakTrapdoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Trapdoor>();
        }
    }
}
