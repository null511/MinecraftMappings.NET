using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Deadbush : BedrockBlockTexture
    {
        public Deadbush() : base("Deadbush")
        {
            AddVersion("deadbush")
                .MapsToJavaBlock<Java.Textures.Block.DeadBush>();
        }
    }
}
