using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LecternFront : JavaBlockTexture
    {
        public LecternFront() : base("Lectern Front")
        {
            AddVersion("lectern_front")
                .WithDefaultModel<Java.Models.Block.Lectern>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LecternFront>();
        }
    }
}
