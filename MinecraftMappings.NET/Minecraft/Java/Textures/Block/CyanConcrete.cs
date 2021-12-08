using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CyanConcrete : JavaBlockTexture
    {
        public CyanConcrete() : base("Cyan Concrete")
        {
            AddVersion("cyan_concrete")
                .WithMinVersion(new GameVersion(1, 12));
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteCyan>();
        }
    }
}
