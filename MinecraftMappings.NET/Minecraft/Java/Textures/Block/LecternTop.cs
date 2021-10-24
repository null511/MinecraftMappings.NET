using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LecternTop : JavaBlockTexture
    {
        public LecternTop() : base("Lectern Top")
        {
            AddVersion("lectern_top")
                .WithDefaultModel<Java.Models.Block.Lectern>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LecternTop>();
        }
    }
}
