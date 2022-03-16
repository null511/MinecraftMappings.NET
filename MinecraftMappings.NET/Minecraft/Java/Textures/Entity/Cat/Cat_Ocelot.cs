using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cat
{
    public class Cat_Ocelot : JavaEntityTexture
    {
        public Cat_Ocelot() : base("Cat, Ocelot")
        {
            AddVersion("ocelot")
                .WithPath("entity/cat")
                .WithDefaultModel<Java.Models.Entity.Cat>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_Ocelot>();
        }
    }
}
