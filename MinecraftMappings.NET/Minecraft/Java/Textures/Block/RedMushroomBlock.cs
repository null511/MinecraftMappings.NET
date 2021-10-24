using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedMushroomBlock : JavaBlockTexture
    {
        public RedMushroomBlock() : base("Red Mushroom Block")
        {
            AddVersion("red_mushroom_block")
                .WithDefaultModel<Java.Models.Block.RedMushroomBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MushroomBlockSkinRed>();
        }
    }
}
