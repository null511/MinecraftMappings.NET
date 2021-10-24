using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LecternSide : JavaBlockTexture
    {
        public LecternSide() : base("Lectern Side")
        {
            AddVersion("lectern_side")
                .WithDefaultModel<Java.Models.Block.Lectern>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LecternSides>();
        }
    }
}
