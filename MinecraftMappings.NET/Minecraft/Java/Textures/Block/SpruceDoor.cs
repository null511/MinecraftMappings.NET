using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SpruceDoor : JavaBlockTexture
    {
        public SpruceDoor() : base("Spruce Door")
        {
            AddVersion("spruce_door")
                .WithDefaultModel<Java.Models.Block.SpruceDoor>();
        }
    }
}
