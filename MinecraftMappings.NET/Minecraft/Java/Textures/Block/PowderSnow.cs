using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PowderSnow : JavaBlockTexture
    {
        public PowderSnow() : base("Powder Snow")
        {
            AddVersion("powder_snow");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PowderSnow>();
        }
    }
}
