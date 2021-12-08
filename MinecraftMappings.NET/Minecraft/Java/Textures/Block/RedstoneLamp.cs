using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedstoneLamp : JavaBlockTexture
    {
        public RedstoneLamp() : base("Redstone Lamp")
        {
            AddVersion("redstone_lamp");
                //.WithDefaultModel<Java.Models.Block.RedstoneLamp>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedstoneLamp>();
        }
    }
}
