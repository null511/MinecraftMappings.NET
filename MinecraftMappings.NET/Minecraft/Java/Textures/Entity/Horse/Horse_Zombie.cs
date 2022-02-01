using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class Horse_Zombie : JavaEntityTexture
    {
        public Horse_Zombie() : base("Horse, Zombie")
        {
            AddVersion("horse_zombie")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.Horse_Zombie>();
        }
    }
}
