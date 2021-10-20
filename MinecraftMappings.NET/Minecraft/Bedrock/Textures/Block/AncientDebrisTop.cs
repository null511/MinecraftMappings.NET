using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class AncientDebrisTop : BedrockBlockTexture
    {
        public AncientDebrisTop() : base("Ancient Debris, Top")
        {
            AddVersion("ancient_debris_top")
                .WithMinVersion(new GameVersion(1, 16))
                .MapsToJavaBlock<Java.Textures.Block.AncientDebrisTop>();
        }
    }
}
