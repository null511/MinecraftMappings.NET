using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackstoneTop : JavaBlockTexture
    {
        public BlackstoneTop() : base("Blackstone Top")
        {
            AddVersion("blackstone_top")
                .WithDefaultModel<Java.Models.Block.Blackstone>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BlackstoneTop>();
        }
    }
}
