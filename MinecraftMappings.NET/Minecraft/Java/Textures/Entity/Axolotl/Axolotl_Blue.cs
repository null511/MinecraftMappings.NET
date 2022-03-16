using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Axolotl
{
    public class Axolotl_Blue : JavaEntityTexture
    {
        public Axolotl_Blue() : base("Axolotl, Blue")
        {
            AddVersion("axolotl_blue")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Axolotl>();
                //.MapsToBedrockEntity<BedrockEntities.Axolotl_Blue>();
        }
    }
}
