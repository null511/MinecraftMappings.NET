using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class Horse_Brown : JavaEntityTexture
    {
        public Horse_Brown() : base("Horse, Brown")
        {
            AddVersion("horse_brown")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.Horse_Brown>();
        }
    }
}
