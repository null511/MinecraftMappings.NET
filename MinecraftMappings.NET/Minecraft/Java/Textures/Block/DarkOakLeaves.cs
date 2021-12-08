using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DarkOakLeaves : JavaBlockTexture
    {
        public DarkOakLeaves() : base("Dark Oak Leaves")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dark_oak_leaves")
                .WithDefaultModel<Java.Models.Block.DarkOakLeaves>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesBigOak>();
        }
    }
}
