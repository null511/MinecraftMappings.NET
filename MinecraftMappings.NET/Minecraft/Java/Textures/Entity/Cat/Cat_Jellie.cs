using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cat
{
    public class Cat_Jellie : JavaEntityTexture
    {
        public Cat_Jellie() : base("Cat, Jellie")
        {
            AddVersion("jellie")
                .WithPath("entity/cat")
                .WithDefaultModel<Java.Models.Entity.Cat>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_Jellie>();
        }
    }
}
