using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RoseBush : JavaBlockTexture
    {
        public RoseBush() : base("Rose Bush")
        {
            AddVersion("rose_bush")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.RoseBush>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RoseBush>();
        }
    }
}
