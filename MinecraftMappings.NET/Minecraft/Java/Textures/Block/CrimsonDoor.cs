using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonDoor : JavaBlockTexture
    {
        public CrimsonDoor() : base("Crimson Door")
        {
            AddVersion("crimson_door");
                //.WithDefaultModel<Java.Models.Block.CrimsonDoor>();
        }
    }
}
