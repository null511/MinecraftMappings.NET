using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class EndRod : BedrockBlockTexture
    {
        public EndRod() : base("End Rod")
        {
            AddVersion("end_rod")
                .MapsToJavaBlock<Java.Textures.Block.EndRod>();
        }
    }
}
