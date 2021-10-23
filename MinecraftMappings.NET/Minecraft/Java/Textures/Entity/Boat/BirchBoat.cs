using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Boat
{
    public class BirchBoat : JavaEntityTexture
    {
        public BirchBoat() : base("Birch Boat")
        {
            AddVersion("birch")
                .WithPath("entity/boat")
                .WithMinVersion("1.9")
                .WithDefaultModel<Java.Models.Entity.Boat>();
                //.MapsToBedrockEntity<BedrockEntities.BirchBoat>();
        }
    }
}
