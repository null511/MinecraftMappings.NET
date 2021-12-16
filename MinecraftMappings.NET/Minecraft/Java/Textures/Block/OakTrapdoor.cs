using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakTrapdoor : JavaBlockTexture
    {
        public OakTrapdoor() : base("Oak Trapdoor")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(0, "trapdoor")
                .WithMaxVersion("1.13")
                .WithDefaultModel<Java.Models.Block.OakTrapdoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Trapdoor>();

            AddVersion(4, "oak_trapdoor")
                .WithMinVersion("1.13")
                .WithDefaultModel<Java.Models.Block.OakTrapdoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Trapdoor>();
        }
    }
}
