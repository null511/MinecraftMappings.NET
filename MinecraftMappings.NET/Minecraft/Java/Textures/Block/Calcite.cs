using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Calcite : JavaBlockTexture
    {
        public Calcite() : base("Calcite")
        {
            AddVersion("calcite")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.Calcite>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StoneCalcite>();
        }
    }
}
