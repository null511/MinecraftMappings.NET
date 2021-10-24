using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class EndStone : BedrockBlockTexture
    {
        public EndStone() : base("End Stone")
        {
            AddVersion("end_stone")
                .MapsToJavaBlock<Java.Textures.Block.EndStone>();
        }
    }
}
