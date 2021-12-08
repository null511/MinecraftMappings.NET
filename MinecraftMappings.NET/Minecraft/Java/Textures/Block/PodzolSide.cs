using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PodzolSide : JavaBlockTexture
    {
        public PodzolSide() : base("Podzol Side")
        {
            AddVersion("podzol_side");
                //.WithDefaultModel<Java.Models.Block.Podzol>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PodzolSide>();
        }
    }
}
