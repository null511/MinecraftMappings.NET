using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaTrapdoor : JavaBlockData
    {
        public AcaciaTrapdoor() : base("Acacia Trapdoor")
        {
            AddVersion("acacia_trapdoor")
                .WithDefaultModel<Java.Models.Block.AcaciaTrapdoorTop>()
                .MapsToBedrockBlock<BedrockBlocks.AcaciaTrapdoor>();
        }
    }
}
