using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cat
{
    public class Cat_Persian : JavaEntityTexture
    {
        public Cat_Persian() : base("Cat, Persian")
        {
            AddVersion("persian")
                .WithPath("entity/cat")
                .WithDefaultModel<Java.Models.Entity.Cat>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_Persian>();
        }
    }
}
