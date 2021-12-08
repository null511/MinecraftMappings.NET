using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChorusFlowerDead : JavaBlockTexture
    {
        public ChorusFlowerDead() : base("Chorus Flower, Dead")
        {
            AddVersion("chorus_flower_dead");
                //.WithDefaultModel<Java.Models.Block.ChorusFlower>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ChorusFlowerDead>();
        }
    }
}
