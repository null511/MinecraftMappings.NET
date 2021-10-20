using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaTrapdoor : JavaBlockTexture
    {
        public AcaciaTrapdoor() : base("Acacia Trapdoor")
        {
            AddVersion("acacia_trapdoor")
                .WithDefaultModel<Java.Models.Block.AcaciaTrapdoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.AcaciaTrapdoor>();
        }
    }
}
