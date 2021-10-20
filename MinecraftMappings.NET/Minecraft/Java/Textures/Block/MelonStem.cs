using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MelonStem : JavaBlockTexture
    {
        public MelonStem() : base("Melon Stem")
        {
            AddVersion("melon_stem")
                .WithDefaultModel<Java.Models.Block.MelonStem_Stage7>();
                //.MapsToBedrockBlock<BedrockBlocks.Grass>();
        }
    }
}
