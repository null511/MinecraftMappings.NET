using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Cat
{
    public class Cat_Collar : JavaEntityTexture
    {
        public Cat_Collar() : base("Cat, Collar")
        {
            AddVersion("cat_collar")
                .WithPath("entity/cat")
                .WithDefaultModel<Java.Models.Entity.Cat>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_Collar>();
        }
    }
}
