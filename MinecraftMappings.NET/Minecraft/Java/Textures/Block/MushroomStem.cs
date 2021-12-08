using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MushroomStem : JavaBlockTexture
    {
        public MushroomStem() : base("Mushroom Stem")
        {
            AddVersion("mushroom_stem");
                //.WithDefaultModel<Java.Models.Block.MushroomStem>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MushroomStem>();
        }
    }
}
