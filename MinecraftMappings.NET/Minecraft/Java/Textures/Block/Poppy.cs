using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Poppy : JavaBlockTexture
    {
        public Poppy() : base("Poppy")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("rose")
                .WithMaxVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.Poppy>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerRose>();

            AddVersion(1, "poppy")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.Poppy>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerRose>();
        }
    }
}
