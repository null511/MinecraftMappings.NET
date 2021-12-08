using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DragonEgg : JavaBlockTexture
    {
        public DragonEgg() : base("Dragon Egg")
        {
            AddVersion("dragon_egg");
                //.WithDefaultModel<Java.Models.Block.DragonEgg>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DragonEgg>();
        }
    }
}
