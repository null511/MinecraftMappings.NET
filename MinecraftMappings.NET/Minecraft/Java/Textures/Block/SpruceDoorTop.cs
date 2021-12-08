using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SpruceDoorTop : JavaBlockTexture
    {
        public SpruceDoorTop() : base("Spruce Door Top")
        {
            AddVersion("spruce_door_top")
                .WithDefaultModel<Java.Models.Block.SpruceDoorTop>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SpruceDoorTop>();
        }
    }
}
