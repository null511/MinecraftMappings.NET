using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RoseBush : JavaBlockTexture
    {
        public RoseBush() : base("Rose Bush")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "rose_bush")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.RoseBush>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RoseBush>();
        }
    }
}
