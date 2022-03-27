using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Illager
{
    public class Vindicator : JavaEntityTexture
    {
        public Vindicator() : base("Vindicator")
        {
            AddVersion("vindicator")
                .WithPath("entity/illager");
                //.WithDefaultModel<Java.Models.Entity.Vindicator>();
                //.MapsToBedrockEntity<BedrockEntities.Vindicator>();
        }
    }
}
