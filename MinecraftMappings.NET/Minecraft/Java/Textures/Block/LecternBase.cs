using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LecternBase : JavaBlockTexture
    {
        public LecternBase() : base("Lectern Base")
        {
            AddVersion("lectern_base")
                .WithDefaultModel<Java.Models.Block.Lectern>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LecternBase>();
        }
    }
}
