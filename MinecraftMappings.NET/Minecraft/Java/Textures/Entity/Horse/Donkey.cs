using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class Donkey : JavaEntityTexture
    {
        public Donkey() : base("Donkey")
        {
            AddVersion("donkey")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.Donkey>();
        }
    }
}
