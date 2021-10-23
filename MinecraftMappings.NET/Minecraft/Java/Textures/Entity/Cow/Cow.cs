using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cow
{
    public class Cow : JavaEntityTexture
    {
        public Cow() : base("Cow")
        {
            AddVersion("cow")
                .WithPath("entity/cow")
                .WithDefaultModel<Java.Models.Entity.Cow>();
                //.MapsToBedrockEntity<BedrockEntities.Cow>();
        }
    }
}
