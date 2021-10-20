using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PumpkinTop : JavaBlockTexture
    {
        public PumpkinTop() : base("Pumpkin Top")
        {
            AddVersion("pumpkin_top")
                .WithDefaultModel<Java.Models.Block.Pumpkin>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PumpkinTop>();
        }
    }
}
