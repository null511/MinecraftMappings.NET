using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LecternSides : JavaBlockTexture
    {
        public LecternSides() : base("Lectern Sides")
        {
            AddVersion("lectern_sides")
                .WithDefaultModel<Java.Models.Block.Lectern>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LecternSides>();
        }
    }
}
