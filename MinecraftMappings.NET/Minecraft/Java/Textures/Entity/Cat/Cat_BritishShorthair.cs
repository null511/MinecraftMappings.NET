using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cat
{
    public class Cat_BritishShorthair : JavaEntityTexture
    {
        public Cat_BritishShorthair() : base("Cat, British Shorthair")
        {
            AddVersion("british_shorthair")
                .WithPath("entity/cat")
                .WithDefaultModel<Java.Models.Entity.Cat>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_BritishShorthair>();
        }
    }
}
