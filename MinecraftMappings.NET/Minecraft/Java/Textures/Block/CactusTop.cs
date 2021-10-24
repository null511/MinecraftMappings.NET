using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CactusTop : JavaBlockTexture
    {
        public CactusTop() : base("Cactus Top")
        {
            AddVersion("cactus_top")
                .WithDefaultModel<Java.Models.Block.Cactus>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CactusTop>();
        }
    }
}
