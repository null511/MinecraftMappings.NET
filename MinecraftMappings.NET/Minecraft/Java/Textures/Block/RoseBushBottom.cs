using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RoseBushBottom : JavaBlockTexture
    {
        public RoseBushBottom() : base("Rose Bush Bottom")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("rose_bush_bottom")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.RoseBushBottom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoublePlant_RoseBottom>();
        }
    }
}
