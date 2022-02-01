using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class Horse_Creamy : JavaEntityTexture
    {
        public Horse_Creamy() : base("Horse, Creamy")
        {
            AddVersion("horse_creamy")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.Horse_Creamy>();
        }
    }
}
