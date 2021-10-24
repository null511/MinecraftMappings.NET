using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LoomTop : JavaBlockTexture
    {
        public LoomTop() : base("Loom Top")
        {
            AddVersion("loom_top")
                .WithDefaultModel<Java.Models.Block.Loom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LoomTop>();
        }
    }
}
